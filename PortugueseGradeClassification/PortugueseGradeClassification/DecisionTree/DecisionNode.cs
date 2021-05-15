using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortugueseGradeClassification.DecisionTree
{
    class DecisionNode : Node
    {
        public Question question { get; private set; }
        public Node trueNode { get; set; }
        public Node falseNode { get; set; }
        public string[] trueRows { get; private set; }
        public string[] falseRows { get; private set; }

        public DecisionNode (Question q, string[] tRows, string[] fRows)
        {
            question = q;
            trueRows = tRows;
            falseRows = fRows;
        }

        public override string ToString()
        {
            return question.ToString();
        }

    }
}
