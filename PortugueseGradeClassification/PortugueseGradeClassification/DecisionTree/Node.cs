using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortugueseGradeClassification.DecisionTree
{
    class Node<T> : NodeInterface
    {
        private Question<T> Question { get; }
        private Node<T> TrueNode { get; }
        private Node<T> FalseNode { get; }
        private Dictionary<String, Int32> Labels { get; }

        public Node(Question<T> Question, Node<T> TrueNode, Node<T> FalseNode) 
        {
            this.Question = Question;
            this.TrueNode = TrueNode;
            this.FalseNode = FalseNode;
        }

        public Node(Dictionary<String, Int32> labelCount)
        {
            this.Labels = labelCount;
        }

        override
        public String ToString()
        {
            String result = "";
            if (Question != null)
            {
                result = Question.ToString();
            }

            if (Labels != null) 
            {
                int amount = 0;

                foreach (String key in Labels.Keys)
                {
                    amount += Labels[key];
                       
                }


                foreach (String key in Labels.Keys)
                { 
                    double gini = Convert.ToDouble(Labels[key]) / Convert.ToDouble(amount);

                    if ((key.Equals("1") && gini == 1) || (key.Equals("0") && gini == 1))
                    {
                        result += key + "-" + gini + "%\n" + "0" + "-" + "99%";
                        break;                
                    }

                    result += key + "-" + gini + "%\n";

                }
            }


            return result;
        }


    }
}
