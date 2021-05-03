using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortugueseGradeClassification.DecisionTree
{
    class Leaf : NodeInterface
    {
        public string[] rows { get; private set; } //Las filas que pertecen a la hoja
        public int[] predictions { get; private set; } //Sujeto a cambiar dependiendo del arbol

        public Leaf(string[] rows)
        {
            this.rows = rows;
            //this.predictions = Metodo que obtiene los valores de interes de las filas
        }

        public string MakePrediction()
        {
            string message = "prediction: ";

            //Llenado del mensaje, en proceso

            return message;
        }
    }
}
