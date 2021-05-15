using PortugueseGradeClassification.CustomExceptions;
using PortugueseGradeClassification.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PortugueseGradeClassification.GUI
{
    public partial class TableFilter : UserControl
    {
        public enum Type { NUMERIC, CATEGORIC, CHAIN }

        private Dictionary<string, Type> columnTypes;
        private DepartmentManager manager;

        public TableFilter()
        {
            InitializeComponent();
            
        }

        public void setManager(DepartmentManager manager)
        {
            this.manager = manager;
            columnTypes = new Dictionary<string, Type>()
            {
                { "School",Type.CATEGORIC },
                { "Sex",Type.CATEGORIC },
                { "Age",Type.NUMERIC },
                { "Address",Type.CATEGORIC },
                { "Family size",Type.CATEGORIC },
                { "Parents status",Type.CATEGORIC },
                { "Mother's education",Type.NUMERIC },
                { "Father's education",Type.NUMERIC },
                { "Mother's job",Type.CATEGORIC },
                { "Father's job",Type.CATEGORIC },
                { "Reason",Type.CATEGORIC },
                { "Guardian",Type.CATEGORIC },
                { "Travel time",Type.NUMERIC },
                { "Study time",Type.NUMERIC },
                { "Failures",Type.NUMERIC },
                { "School support",Type.CATEGORIC },
                { "Family support",Type.CATEGORIC },
                { "Extra paid classes",Type.CATEGORIC },
                { "Extra activities",Type.CATEGORIC },
                { "Nursery",Type.CATEGORIC },
                { "Higher education",Type.CATEGORIC },
                { "Internet access",Type.CATEGORIC },
                { "Romantic relationship",Type.CATEGORIC },
                { "Family relation",Type.NUMERIC },
                { "Free time",Type.NUMERIC },
                { "Go out",Type.NUMERIC },
                { "Weekday alcohol",Type.NUMERIC },
                { "Weekend alcohol",Type.NUMERIC },
                { "Health",Type.NUMERIC },
                { "Absences",Type.NUMERIC },
                { "Grade 1",Type.NUMERIC },
                { "Grade 2",Type.NUMERIC },
                { "Grade 3",Type.NUMERIC },
            };
            PortuTable.DataSource = manager.GetTable();
        }

        private void filter(String field)
        {
            try
            {
                if (field.Equals("Filter by..."))
                {
                    throw new InvalidOperationException();
                }

                switch (columnTypes[field])
                {
                    case Type.NUMERIC:
                        int m1 = int.Parse(FilterText1.Text);
                        int m2 = int.Parse(FilterText2.Text);

                        manager.FilterByInterval(BiComboBox.Text.ToUpper(), m1, m2);
                        PortuTable.DataSource = manager.GetTable();
                        break;

                    case Type.CATEGORIC:

                        if (BiComboBox.Text == null || BiComboBox.Text.Equals("") || BiComboBox.Text.Equals("Pick a value..."))
                        {
                            throw new InvalidOperationException();
                        }

                        switch (field)
                        {
                            case "School":
                                if (BiComboBox.Text.Equals("Mousinho da Silveira School"))
                                {
                                    Console.WriteLine("entraaaaa -2-2-2");
                                    manager.FilterByCategory("School", "MS");
                                    PortuTable.DataSource = manager.GetTable();
                                }
                                else if (BiComboBox.Text.Equals("Gabriel Pereira School"))
                                {
                                    Console.WriteLine("entraaaaa");
                                    manager.FilterByCategory("School", "GP");
                                    PortuTable.DataSource = manager.GetTable();
                                }

                                break;

                            case "Sex":
                                if (BiComboBox.Text.Equals("Male"))
                                {
                                    manager.FilterByCategory("Sex", "M");
                                    PortuTable.DataSource = manager.GetTable();
                                }
                                else if (BiComboBox.Text.Equals("Female"))
                                {
                                    manager.FilterByCategory("Sex", "F");
                                    PortuTable.DataSource = manager.GetTable();
                                }

                                break;

                            case "Address":
                                if (BiComboBox.Text.Equals("Rural"))
                                {
                                    manager.FilterByCategory("Address", "R");
                                    PortuTable.DataSource = manager.GetTable();
                                }
                                else if (BiComboBox.Text.Equals("Urban"))
                                {
                                    manager.FilterByCategory("Address", "U");
                                    PortuTable.DataSource = manager.GetTable();
                                }

                                break;

                            case "Family size":
                                if (BiComboBox.Text.Equals("Less or equal to 3"))
                                {
                                    manager.FilterByCategory("Family Size", "LE3");
                                    PortuTable.DataSource = manager.GetTable();
                                }
                                else if (BiComboBox.Text.Equals("Greater than 3"))
                                {
                                    manager.FilterByCategory("Family Size", "GT3");
                                    PortuTable.DataSource = manager.GetTable();
                                }

                                break;

                            case "Parents status":
                                if (BiComboBox.Text.Equals("Living together"))
                                {
                                    manager.FilterByCategory("Parents status", "T");
                                    PortuTable.DataSource = manager.GetTable();
                                }
                                else if (BiComboBox.Text.Equals("Apart"))
                                {
                                    manager.FilterByCategory("Parents status", "A");
                                    PortuTable.DataSource = manager.GetTable();
                                }

                                break;

                            default:

                                manager.FilterByCategory(field, BiComboBox.Text);
                                PortuTable.DataSource = manager.GetTable();

                                break;

                        }
                        break;
                }
                
            }
            catch (IncorrectLimitsException e)
            {
                MessageBox.Show(e.Message, "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Only numbers are allowed.", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Select a filtering option.", "Select An Option", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String field = FilterComboBox.Text;
            Type type = columnTypes[field];
            switch (type)
            {
                case Type.CATEGORIC:
                    BiComboBox.Visible = true;
                    FilterText1.Visible = false;
                    FilterText2.Visible = false;
                    BiComboBox.Text = "Pick a value...";
                    switch (field)
                    {
                        case "School":
                            BiComboBox.Items.Clear();
                            String[] schools = new string[] { "Mousinho da Silveira School", "Gabriel Pereira School" };
                            BiComboBox.Items.AddRange(schools);
                            break;

                        case "Sex":
                            BiComboBox.Items.Clear();
                            String[] sex = new string[] { "Female", "Male" };
                            BiComboBox.Items.AddRange(sex);
                            break;

                        case "Address":
                            BiComboBox.Items.Clear();
                            String[] address = new string[] { "Rural", "Urban" };
                            BiComboBox.Items.AddRange(address);
                            break;

                        case "Family size":
                            BiComboBox.Items.Clear();
                            String[] fsize = new string[] { "Less or equal to 3", "Greater than 3" };
                            BiComboBox.Items.AddRange(fsize);
                            break;

                        case "Parents status":
                            BiComboBox.Items.Clear();
                            String[] pstatus = new string[] { "Living together", "Apart" };
                            BiComboBox.Items.AddRange(pstatus);
                            break;

                        case "Mother's job":
                            BiComboBox.Items.Clear();
                            String[] mjob = new string[] { "teacher", "health", "services", "at_home", "other" };
                            BiComboBox.Items.AddRange(mjob);
                            break;

                        case "Father's job":
                            BiComboBox.Items.Clear();
                            String[] fjob = new string[] { "teacher", "health", "services", "at_home", "other" };
                            BiComboBox.Items.AddRange(fjob);
                            break;

                        case "Reason":
                            BiComboBox.Items.Clear();
                            String[] reason = new string[] { "home", "reputation", "course", "other" };
                            BiComboBox.Items.AddRange(reason);
                            break;

                        case "Guardian":
                            BiComboBox.Items.Clear();
                            String[] guardian = new string[] { "mother", "father", "other" };
                            BiComboBox.Items.AddRange(guardian);
                            break;

                        default:
                            BiComboBox.Items.Clear();
                            String[] fsupp = new string[] { "Yes", "No" };
                            BiComboBox.Items.AddRange(fsupp);
                            break;
                    }
                    break;

                case Type.NUMERIC:
                    BiComboBox.Visible = false;
                    FilterText1.Visible = true;
                    FilterText2.Visible = true;
                    FilterText1.Text = "Min. Value...";
                    FilterText2.Text = "Max. Value...";
                    break;
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
                String field = FilterComboBox.Text;
                filter(field);
        }
    }
}