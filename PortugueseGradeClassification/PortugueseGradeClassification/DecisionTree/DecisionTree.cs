using System;
using System.Collections.Generic;
using System.Data;

namespace PortugueseGradeClassification.DecisionTree
{
    internal class DecisionTree
    {
        public Node rootNode { get; private set; }
        public string[] rows { get; private set; }
        public int[] ordinalIndex { get; private set; }

        public DecisionTree(string[] r)
        {
            rows = r;
        }

        public void BuildTree()
        {
            rootNode = BuildNode(rows);
            Stack<Node> treeNodes = new Stack<Node>();
            treeNodes.Push(rootNode);

            while (treeNodes.Count > 0)
            {
                Node actualNode = treeNodes.Pop();

                if (actualNode is DecisionNode)
                {
                    DecisionNode decisionNode = (DecisionNode)actualNode;
                    
                    string[] trueRows = decisionNode.trueRows;
                    string[] falseRows = decisionNode.falseRows;

                    decisionNode.trueNode = BuildNode(trueRows);
                    decisionNode.falseNode = BuildNode(falseRows);

                    treeNodes.Push(decisionNode.trueNode);
                    treeNodes.Push(decisionNode.falseNode);
                }
            }

        }

        static public Node BuildNode(string[] rows)
        {
            Tuple<double, Question> bestQuestion = FindBestQuestion(rows);

            if (bestQuestion.Item1 == 0) {
                return new LeafNode(rows);
            } 
            Tuple<String[], String[]> truefalse_rows = Partitions(rows, bestQuestion.Item2);

            return new DecisionNode(bestQuestion.Item2, truefalse_rows.Item1, truefalse_rows.Item2);
        }

        public LeafNode Classify(string row)
        {
            return null;
        }

        public static Tuple<double, Question> FindBestQuestion(string[] rows)
        {
            return null;
        }

        static public double Gini(DataTable rows)
        {
            //El gini se hace para encontrar la variedad de datos DESPUES de una partición
            //El infoGain se hace utilizan el gini del nodo antes de la partición 

            Tuple<string, int>[] vars = GetValueCounts(rows);
            double impurity = 1;

            foreach (Tuple<string, int> var in vars)
            {
                double prop = (double)var.Item2 / (double)rows.Rows.Count;
                double powerOfTwo = (prop * prop);
                impurity -= powerOfTwo;
            }
            return impurity;
        }

        public static double CalcInfoGain(string[] leftRows, string[] rightRows, double uncertainty)
        {
            return 0;
        }

        public static string[] UniqueValues(string[] rows)
        {
            return null;
        }

        public static Tuple<string, int>[] GetValueCounts(DataTable rows)
        {
            return null;
        }

        public static Tuple<string[], string[]> Partitions(string[] rows, Question q)
        {
            return null;
        }
    }
}