using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortugueseGradeClassification.DecisionTree
{
    class LeafNode : Node
    {
        public string[] rows { get; private set; } //Las filas que pertecen a la hoja
        public Tuple<string, int>[] predictions { get; private set; } //Sujeto a cambiar dependiendo del arbol

        public LeafNode(string[] rows)
        {
            this.rows = rows;
            this.predictions = DecisionTree.GetValueCounts();
        }

        public override string ToString()
        {
            string message = "prediction: ";

            //Llenado del mensaje, en proceso

            return message;
        }
    }
}
