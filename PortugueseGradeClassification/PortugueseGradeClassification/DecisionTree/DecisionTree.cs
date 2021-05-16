using System;
using System.Collections.Generic;

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
            return null;
        }

        public LeafNode Classify(string row)
        {
            return null;
        }

        public static Tuple<double, Question> FindBestQuestion(string[] rows)
        {
            return null;
        }

        static public double Gini(string[] rows)
        {
            return 0;
        }

        public static double CalcInfoGain(string[] leftRows, string[] rightRows, double uncertainty)
        {
            return 0;
        }

        public static string[] UniqueValues(string[] rows)
        {
            return null;
        }

        public static Tuple<string, int>[] GetValueCounts()
        {
            return null;
        }

        public static Tuple<string[], string[]> Partitions(string[] rows, Question q)
        {
            return null;
        }
    }
}