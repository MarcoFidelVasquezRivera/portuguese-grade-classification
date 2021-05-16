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

namespace PortugueseGradeClassification.GUI
{
    public partial class DecisionTreeControl : UserControl
    {
        private DepartmentManager manager;
        public DecisionTreeControl()
        {
            InitializeComponent();
        }

        public void SetManager(DepartmentManager manager)
        {
            this.manager = manager;
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            //llamar al metodo del boton que se encargue del entrenamiento del arbol
        }

        private void ClasiffyButton_Click(object sender, EventArgs e)
        {
            bool comboBoxConditional = (schoolComboBox.Text != "" && sexComboBox.Text != "" && addressComboBox.Text != "" && fSizeComboBox.Text != ""
                && pStatusComboBox.Text != "" && mJobComboBox.Text != "" && fJobComboBox.Text != "" && reasonComboBox.Text != "" && GuardianComboBox.Text != ""
                && sSupComboBox.Text != "" && fSuppComboBox.Text != "" && paidComboBox.Text != "" && activityComboBox.Text != "" && nurseryComboBox.Text != ""
                && hEduComboBox.Text != "" && internetComboBox.Text != "" && romanticComboBox.Text != "");

            bool textBoxVoidConditional = (ageTextBox.Text != "" && mEduTextBox.Text != "" && fEduTextBox.Text != "" && tTimeTextBox.Text != ""
                && sTimeTextBox.Text != "" && failTextBox.Text != "" && fRelationTextBox.Text != "" && fTimeTextBox.Text != "" && goOutTextBox.Text != ""
                && aWeekTextBox.Text!="" && aWeekendTextBox.Text!="" && healthTextBox.Text!="" && absencesTextBox.Text!="" && gOneTextBox.Text!=""
                && gTwoTextBox.Text!="");

            bool textBoxStringConditional = (IsNumeric(ageTextBox.Text,15,22) && IsNumeric(mEduTextBox.Text,0,4) && IsNumeric(fEduTextBox.Text,0,4) 
                && IsNumeric(tTimeTextBox.Text,1,4) && IsNumeric(sTimeTextBox.Text,1,4) && IsNumeric(failTextBox.Text,0,3) && IsNumeric(fRelationTextBox.Text,1,5)
                && IsNumeric(fTimeTextBox.Text,1,5) && IsNumeric(goOutTextBox.Text,1,5) && IsNumeric(aWeekTextBox.Text,1,5) && IsNumeric(aWeekendTextBox.Text,1,5)
                && IsNumeric(healthTextBox.Text,1,5) && IsNumeric(absencesTextBox.Text,0, 93) && IsNumeric(gOneTextBox.Text,0,20) && IsNumeric(gTwoTextBox.Text,0,20));

        
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
    }
}
