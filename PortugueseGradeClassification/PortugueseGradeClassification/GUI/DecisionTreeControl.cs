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

    }
}
