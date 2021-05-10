using PortugueseGradeClassification.Model;
using System.Windows.Forms;

namespace PortugueseGradeClassification.GUI
{
    public partial class MainWindow : Form
    {
        private DepartmentManager manager;

        public MainWindow(DepartmentManager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void MainWindow_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            LoadDataWindow obj = (LoadDataWindow)Application.OpenForms["LoadDataWindow"];
            obj.Close();
        }

        private void tableFilter1_Load(object sender, System.EventArgs e)
        {
            tableFilter1.setManager(manager);
        }

        private void graphView1_Load(object sender, System.EventArgs e)
        {
            graphView1.setManager(manager);
        }
    }
}