using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortugueseGradeClassification.DecisionTree;

namespace PortugueseGradeClassification.DecisionTree
{
    class DecisionTree<T>
    {
        private Node<T> root { get; set; }
        private Dictionary<String, T> dataDictionary { get; set; }

        //constructor
        public DecisionTree(Dictionary<String, T> dataDictionary)
        {
            this.dataDictionary = dataDictionary;
        }

        public List<T[]>[] Partition(List<T[]> rows, Question<T> question)
        {
            List<T[]> [] partition = { new List<T[]>(), new List<T[]>()};

            foreach (T[] row in rows)
            {
                if (question.compare(row))
                {
                    partition[0].Add(row);
                }
                else
                {
                    partition[1].Add(row);
                }
            }

            return partition;
        }

    }
}
