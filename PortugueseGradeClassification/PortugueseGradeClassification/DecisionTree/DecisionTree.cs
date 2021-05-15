using System;

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
        }

        static public Node BuildNode()
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