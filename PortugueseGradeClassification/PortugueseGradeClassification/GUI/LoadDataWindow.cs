using PortugueseGradeClassification.Model;
using System;
using System.Windows.Forms;

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