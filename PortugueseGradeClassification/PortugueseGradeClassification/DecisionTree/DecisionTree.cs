using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortugueseGradeClassification.DecisionTree;

namespace PortugueseGradeClassification.DecisionTree
{
    class DecisionTree<T> where T: DataRow
    {
        private Node<T> root { get; set; }
        private Dictionary<String, T> dataDictionary { get; set; }
        private DataTable info { get; set; }

        //constructor
        public DecisionTree(Dictionary<String, T> dataDictionary)
        {
            this.dataDictionary = dataDictionary;
        }

        

        //Reparte la distribucion de los datos objetivo y las veces que se repiten 
        private Dictionary<String, Int32> labelDistribution(List<String[]> rows) {
            Dictionary<String, Int32> distribution = new Dictionary<String, Int32>();
        

            foreach(String[] row in rows)
            {
                String[] attributes = row;

                //El ultimo atributo es el label (el ejemplo lo muestra como el target a llegar, en nuestro caso, la nota 3)
                String label = attributes[attributes.Length - 1];

                if (distribution.Keys.Contains(label))
                {
                    distribution[label] += 1;

                }
                else
                {

                    distribution.Add(label,0);
                
                }


            }

            return distribution;
        }

        public List<T[]>[] Partition(List<T[]> rows, Question<T> q)
        {
            List<T[]> [] partition = { new List<T[]>(), new List<T[]>()};

            foreach (T[] row in rows)
            {
                if (q.compare(row)) partition[0].Add(row);
                else partition[1].Add(row);
            }

            return partition;
        }

        //Calculo Gini
        public double Gini(List<String[]> rows)
        {
            Dictionary<String, Int32> dist = labelDistribution(rows);
            double impurity = 1;

            foreach (String key in dist.Keys)
            {
                double fraction = Convert.ToDouble(dist[key]) / Convert.ToDouble(rows.Count);
                impurity -= Math.Pow(fraction, 2);
            }

            return impurity;
        }

    }
}
