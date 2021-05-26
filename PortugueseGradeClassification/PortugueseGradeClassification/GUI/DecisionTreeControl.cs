using PortugueseGradeClassification.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PortugueseGradeClassification.GUI
{
    public partial class DecisionTreeControl : UserControl
    {
        private DepartmentManager manager;
        private Tuple<double, double> accuracies;
        public DecisionTreeControl()
        {
            InitializeComponent();
        }

        public void SetManager(DepartmentManager manager)
        {
            this.manager = manager;
            graphViewer.Enabled = false;
            ClasiffyButton.Enabled = false;
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            accuracies = manager.TrainTree();
            MessageBox.Show("Finished training trees", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            graphViewer.Enabled = true;
            ClasiffyButton.Enabled = true;
        }

        private void ClasiffyButton_Click(object sender, EventArgs e)
        {
            bool comboBoxConditional = (schoolComboBox.Text != "" && sexComboBox.Text != "" && addressComboBox.Text != "" && fSizeComboBox.Text != ""
                && pStatusComboBox.Text != "" && mJobComboBox.Text != "" && fJobComboBox.Text != "" && reasonComboBox.Text != "" && GuardianComboBox.Text != ""
                && sSupComboBox.Text != "" && fSuppComboBox.Text != "" && paidComboBox.Text != "" && activityComboBox.Text != "" && nurseryComboBox.Text != ""
                && hEduComboBox.Text != "" && internetComboBox.Text != "" && romanticComboBox.Text != "");

            bool textBoxVoidConditional = ((ageTextBox.Text != "" && mEduTextBox.Text != "" && fEduTextBox.Text != "" && tTimeTextBox.Text != ""
                && sTimeTextBox.Text != "" && failTextBox.Text != "" && fRelationTextBox.Text != "" && fTimeTextBox.Text != "" && goOutTextBox.Text != ""
                && aWeekTextBox.Text!="" && aWeekendTextBox.Text!="" && healthTextBox.Text!="" && absencesTextBox.Text!="" && gOneTextBox.Text!=""
                && gTwoTextBox.Text!="") == true
                
                && 
                
                (ageTextBox.Text != " Entre 15 y 22" && mEduTextBox.Text != " Entre 0 y 4" && fEduTextBox.Text != " Entre 0 y 4" && tTimeTextBox.Text != " Entre 1 y 4"
                && sTimeTextBox.Text != " Entre 1 y 4" && failTextBox.Text != " Entre 0 y 3" && fRelationTextBox.Text != " Entre 1 y 5" && fTimeTextBox.Text != " Entre 1 y 5" && goOutTextBox.Text != " Entre 1 y 5"
                && aWeekTextBox.Text != " Entre 1 y 5" && aWeekendTextBox.Text != " Entre 1 y 5" && healthTextBox.Text != " Entre 1 y 5" && absencesTextBox.Text != " Entre 0 y 93" && gOneTextBox.Text != " Entre 0 y 20"
                && gTwoTextBox.Text != " Entre 0 y 20") == true);

            bool textBoxStringConditional = (IsNumeric(ageTextBox.Text,15,22) && IsNumeric(mEduTextBox.Text,0,4) && IsNumeric(fEduTextBox.Text,0,4) 
                && IsNumeric(tTimeTextBox.Text,1,4) && IsNumeric(sTimeTextBox.Text,1,4) && IsNumeric(failTextBox.Text,0,3) && IsNumeric(fRelationTextBox.Text,1,5)
                && IsNumeric(fTimeTextBox.Text,1,5) && IsNumeric(goOutTextBox.Text,1,5) && IsNumeric(aWeekTextBox.Text,1,5) && IsNumeric(aWeekendTextBox.Text,1,5)
                && IsNumeric(healthTextBox.Text,1,5) && IsNumeric(absencesTextBox.Text,0, 93) && IsNumeric(gOneTextBox.Text,0,20) && IsNumeric(gTwoTextBox.Text,0,20));

            string errors = "";
            if (!(comboBoxConditional && textBoxVoidConditional && textBoxStringConditional))
            {
                if (!comboBoxConditional)
                {
                    if (schoolComboBox.Text == "") errors += "school, ";
                    if (sexComboBox.Text == "") errors += "gender, ";
                    if (addressComboBox.Text == "") errors += "address, ";
                    if (pStatusComboBox.Text == "") errors += "parental status, ";
                    if (mJobComboBox.Text == "") errors += "mother's job, ";
                    if (fJobComboBox.Text == "") errors += "father's job, ";
                    if (reasonComboBox.Text == "") errors += "reason, ";
                    if (GuardianComboBox.Text == "") errors += "guardian, ";
                    if (sSupComboBox.Text == "") errors += "school support, ";
                    if (fSuppComboBox.Text == "") errors += "family support, ";
                    if (paidComboBox.Text == "") errors += "extra paid classes, ";
                    if (activityComboBox.Text == "") errors += "extra-curricular activities, ";
                    if (nurseryComboBox.Text == "") errors += "attended nursery school, ";
                    if (hEduComboBox.Text == "") errors += "higher education, ";
                    if (internetComboBox.Text == "") errors += "has internet, ";
                    if (romanticComboBox.Text == "") errors += "romantic relationship ";

                    errors += "cannot be empty \n \n";

                }


                if (!textBoxVoidConditional)
                {
                   
                    if (ageTextBox.Text == " Entre 15 y 22") errors += "age, ";
                    if (mEduTextBox.Text == " Entre 0 y 4") errors += "mother's education, ";
                    if (fEduTextBox.Text == " Entre 0 y 4") errors += "father's education, ";
                    if (tTimeTextBox.Text == " Entre 1 y 4") errors += "travel time, ";
                    if (sTimeTextBox.Text == " Entre 1 y 4") errors += "study time, ";
                    if (failTextBox.Text == " Entre 0 y 3") errors += "failures, ";
                    if (fRelationTextBox.Text == " Entre 1 y 5") errors += "family relation, ";
                    if (fTimeTextBox.Text == " Entre 1 y 5") errors += "free time, ";
                    if (goOutTextBox.Text == " Entre 1 y 5") errors += "go out, ";
                    if (aWeekTextBox.Text == " Entre 1 y 5") errors += "alcohol on week days, ";
                    if (aWeekendTextBox.Text == " Entre 1 y 5") errors += "alcohol on weekends, ";
                    if (healthTextBox.Text == " Entre 1 y 5") errors += "health status, ";
                    if (absencesTextBox.Text == " Entre 0 y 93") errors += "absences, ";
                    if (gOneTextBox.Text == " Entre 0 y 20") errors += "grade 1, ";
                    if (gTwoTextBox.Text == " Entre 0 y 20") errors += "grade 1, ";


                    errors += "cannot be empty \n \n";
                }

                if (!textBoxStringConditional) 
                {
                    
                    if (!IsNumeric(ageTextBox.Text, 15, 22)) errors += "age must be a number between 15 and 20 \n";
                    if (!IsNumeric(mEduTextBox.Text, 0, 4)) errors += "mother's education must be a number between 0 and 4 \n";
                    if (!IsNumeric(fEduTextBox.Text, 0, 4)) errors += "father's education must be a number between 0 and 4 \n";
                    if (!IsNumeric(tTimeTextBox.Text, 1, 4)) errors += "travel time must be a number between 1 and 4 \n";
                    if (!IsNumeric(sTimeTextBox.Text, 1, 4)) errors += "study must be a number between 1 and 4 \n";
                    if (!IsNumeric(failTextBox.Text, 0, 3)) errors += "failures must be a number between 0 and 3 \n";
                    if (!IsNumeric(fRelationTextBox.Text, 1, 5)) errors += "family relation must be a number between 1 and 5 \n";
                    if (!IsNumeric(fTimeTextBox.Text, 1, 5)) errors += "travel time must be a number between 1 and 5 \n";
                    if (!IsNumeric(goOutTextBox.Text, 1, 5)) errors += "go out must be a number between 1 and 5 \n";
                    if (!IsNumeric(aWeekTextBox.Text, 1, 5)) errors += "alcohol on weekdays must be a number between 1 and 5 \n";
                    if (!IsNumeric(aWeekendTextBox.Text, 1, 5)) errors += "alcohol on weekends must be a number between 1 and 5 \n";
                    if (!IsNumeric(aWeekendTextBox.Text, 1, 5)) errors += "alcohol on weekends must be a number between 1 and 5 \n";
                    if (!IsNumeric(healthTextBox.Text, 1, 5)) errors += "health status must be a number between 1 and 5 \n";
                    if (!IsNumeric(absencesTextBox.Text, 0, 93)) errors += "absences must be a number between 0 and 93 \n";
                    if (!IsNumeric(gOneTextBox.Text, 0, 20)) errors += "grade 1 must be a number between 0 and 20 \n";
                    if (!IsNumeric(gTwoTextBox.Text, 0, 20)) errors += "grade 2 must be a number between 0 and 20 \n";
                }

            }

            if (errors != "")
            {
                MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
           {
                String[] info = { schoolComboBox.Text, sexComboBox.Text, ageTextBox.Text,addressComboBox.Text, fSizeComboBox.Text, pStatusComboBox.Text,
                mEduTextBox.Text, fEduTextBox.Text, mJobComboBox.Text, fJobComboBox.Text, reasonComboBox.Text, GuardianComboBox.Text, tTimeTextBox.Text,
                sTimeTextBox.Text, failTextBox.Text, sSupComboBox.Text, fSuppComboBox.Text, paidComboBox.Text, activityComboBox.Text, nurseryComboBox.Text,
                hEduComboBox.Text, internetComboBox.Text, romanticComboBox.Text, fRelationTextBox.Text, fTimeTextBox.Text, goOutTextBox.Text, aWeekTextBox.Text,
                aWeekendTextBox.Text, healthTextBox.Text, absencesTextBox.Text, gOneTextBox.Text, gTwoTextBox.Text};
                if (graphViewer.Text == "Manual Decision Tree")
                {
                    MessageBox.Show("Implemented tree prediction: " + manager.Clasify(info), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (graphViewer.Text == "Library Decision Tree") {
                    if (manager.LibraryClassify(info) != "-1") {
                        MessageBox.Show("Library tree prediction " + manager.LibraryClassify(info), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Library tree prediction returned -1, please retrain it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }
                
                else MessageBox.Show("Please choose an option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsNumeric(string value, int l, int h)
        {
            try{
                int valueNumeric = Convert.ToInt32(value);
                return (valueNumeric >= l && valueNumeric <= h);//devuelve true si es numerico y se encuentra entre el intervalo dado y false si no esta en el intervalo
            }
            catch(Exception)
            {
                return false;//devuelve false si no es numerico
            }
        }

        private void UpdateGraph(object sender, EventArgs e)
        {

                double impAccuracy = accuracies.Item1;
                double libAccuracy = accuracies.Item2;
                switch (graphViewer.Text)
                {
                    case ("Manual Decision Tree"):

                        guessesChart.Series.Clear();
                        guessesChart.Series.Add("Series1");
                        guessesChart.Titles.Clear();

                        guessesChart.Titles.Add("Accuracy");
                        guessesChart.Series["Series1"].IsValueShownAsLabel = true;
                        guessesChart.Series["Series1"].ChartType = SeriesChartType.Pie;
                        guessesChart.Series["Series1"].Points.AddXY("Correct", Math.Round(impAccuracy, 2));
                        guessesChart.Series["Series1"].Points.AddXY("Incorrect", Math.Round(1.0 - impAccuracy, 2));

                        guessesChart.Visible = true;
                        break;

                    case ("Library Decision Tree"):

                        guessesChart.Series.Clear();
                        guessesChart.Series.Add("Series1");
                        guessesChart.Titles.Clear();

                        guessesChart.Titles.Add("Accuracy");
                        guessesChart.Series["Series1"].IsValueShownAsLabel = true;
                        guessesChart.Series["Series1"].ChartType = SeriesChartType.Pie;
                        guessesChart.Series["Series1"].Points.AddXY("Correct", Math.Round(libAccuracy, 2));
                        guessesChart.Series["Series1"].Points.AddXY("Incorrect", Math.Round(1.0 - libAccuracy, 2));

                        guessesChart.Visible = true;
                        break;

                }
        }
        
    }
}
