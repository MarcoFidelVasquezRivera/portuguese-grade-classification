using System;
using System.Collections.Generic;
using System.Data;


namespace PortugueseGradeClassification.DecisionTreeSpace
{
    public class LeafNode : Node
    {
        public DataTable rows { get; private set; } //Las filas que pertecen a la hoja
        public Tuple<string, int>[] predictions { get; private set; } //Sujeto a cambiar dependiendo del arbol

        public LeafNode(DataTable rows)
        {
            this.rows = rows;
            this.predictions = DecisionTree.GetValueCounts(rows);
        }

        public override string ToString()
        {
            string message = "Predict: { ";
            foreach (Tuple<string, int> prediction in predictions) message += $"{prediction.Item1.ToString()}:{prediction.Item2} ";
            message += "}";

            return message;
        }
    }
}
