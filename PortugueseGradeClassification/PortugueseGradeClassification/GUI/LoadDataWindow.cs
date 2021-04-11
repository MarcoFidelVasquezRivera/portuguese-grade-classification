using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortugueseGradeClassification
{
    public partial class LoadDataWindow : Form
    {

        MainWindow mainWindow;

        public LoadDataWindow()
        {
            //falta controladora en clase mainwindow 
            InitializeComponent();
            mainWindow = new MainWindow();
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            bool correctFile = true;
            //cargar datos .csv 
            //debe cambiar el boolean a false

            if (correctFile)
            {
                this.Hide();
                mainWindow.Show();
            }
        }
    }
}
