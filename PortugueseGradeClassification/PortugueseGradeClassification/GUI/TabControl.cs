using PortugueseGradeClassification.Model;
using System.Windows.Forms;

namespace PortugueseGradeClassification.GUI
{
    public partial class TabControl : UserControl
    {
        private DepartmentManager manager;

        public TabControl(DepartmentManager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }
    }
}
