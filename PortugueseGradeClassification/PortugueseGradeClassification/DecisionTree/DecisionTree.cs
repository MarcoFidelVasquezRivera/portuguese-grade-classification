﻿using System;
using System.Collections.Generic;
using System.Data;

namespace PortugueseGradeClassification.DecisionTree
{
    internal class DecisionTree
    {
        public Node rootNode { get; private set; }
        public DataTable Rows { get; private set; }
        public int[] ordinalIndex { get; private set; }

        public DecisionTree(DataTable Rows)
        {
            this.Rows = Rows;
        }

        public void BuildTree()
        {
            rootNode = BuildNode(Rows);
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

        static public Node BuildNode(DataTable rows)
        {
            Tuple<double, Question> bestQuestion = FindBestQuestion(rows);

            if (bestQuestion.Item1 == 0) {
                return new LeafNode(rows);
            } 
            Tuple<DataTable, DataTable> truefalse_rows = Partitions(rows, bestQuestion.Item2);

            return new DecisionNode(bestQuestion.Item2, truefalse_rows.Item1, truefalse_rows.Item2);
        }

        public LeafNode Classify(string row)
        {
            return null;
        }

        public static Tuple<double, Question> FindBestQuestion(DataTable rows)
        {
            double bestGain = 0;
            Question bestQuestion = null;
            double uncertainty = Gini(rows);
            int actualRow = 0;

            foreach(DataRow row in rows.Rows)
            {
                foreach (DataColumn column in rows.Columns)
                {
                    Question q = new Question(actualRow, row[column]);

                    Tuple<DataTable, DataTable> truefalse_rows = Partitions(rows, q);

                    if (truefalse_rows.Item1.Columns.Count == 0 || truefalse_rows.Item2.Columns.Count == 0) continue;

                    double gain = CalcInfoGain(truefalse_rows.Item1, truefalse_rows.Item2, uncertainty);

                    if (gain > bestGain)
                    {
                        bestGain = gain;
                        bestQuestion = q;
                    }
                }
                actualRow++;
            }    
            return new Tuple<double, Question>(bestGain, bestQuestion);
        }

        static public double Gini(DataTable rows)
        {
            return 0;
        }

        public static double CalcInfoGain(DataTable leftRows, DataTable rightRows, double uncertainty)
        {
            return 0;
        }

        public static string[] UniqueValues(DataTable rows)
        {
            return null;
        }

        public static Tuple<string, int>[] GetValueCounts()
        {
            return null;
        }

        public static Tuple<DataTable,DataTable> Partitions(DataTable rows, Question q)
        {
            return null;
        }
    }
}