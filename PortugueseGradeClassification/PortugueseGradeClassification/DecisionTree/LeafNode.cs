using System;
using System.Data;


namespace PortugueseGradeClassification.DecisionTree
{
    class LeafNode : Node
    {
        public DataTable rows { get; private set; } //Las filas que pertecen a la hoja
        public Tuple<string, int>[] predictions { get; private set; } //Sujeto a cambiar dependiendo del arbol

        public LeafNode(DataTable rows)
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
