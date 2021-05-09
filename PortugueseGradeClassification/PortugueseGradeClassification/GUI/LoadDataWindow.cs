using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PortugueseGradeClassification.Model;

namespace PortugueseGradeClassification.GUI
{
    public partial class LoadDataWindow : Form
    {

        private MainWindow mainWindow;
        private DepartmentManager manager;

        public LoadDataWindow()
        {
           
            InitializeComponent();
            manager = new DepartmentManager();
            mainWindow = new MainWindow(manager);
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                manager.Load(openFileDialog1.FileName);
            }         
            mainWindow.Show();
            this.Hide();
        }
    }
}
