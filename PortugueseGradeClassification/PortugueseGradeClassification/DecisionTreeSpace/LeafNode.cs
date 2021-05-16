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
            Dictionary<String, int> count = new Dictionary<string, int>();
            foreach (DataRow dr in rows.Rows)
            {
                if (count.ContainsKey(Convert.ToString(dr[32])))
                {
                    count[Convert.ToString(dr[32])]++;
                }

                else count.Add(Convert.ToString(dr[32]), 1);
            }

            string mostCommonValue = "";
            int repeats = 0;

            foreach(KeyValuePair<String,int> kvp in count)
            {
                if(kvp.Value > repeats)
                {

                    mostCommonValue = kvp.Key;
                    repeats = kvp.Value;

                }
            }

            return mostCommonValue;
        }
    }
}
