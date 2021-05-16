using System.Data;


namespace PortugueseGradeClassification.DecisionTree
{
    class DecisionNode : Node
    {
        public Question[] Question { get; private set; }
        public Node TrueNode { get; set; }
        public Node FalseNode { get; set; }
        public DataTable TrueRows { get; private set; }
        public DataTable FalseRows { get; private set; }

        public DecisionNode (Question[] q, DataTable tRows, DataTable fRows)
        {
            Question = q;
            TrueRows = tRows;
            FalseRows = fRows;
        }

        public override string ToString()
        {
            return "";
            //Cuando vayamos a imprimir lo miramos
        }

    }
}
