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
                    
                    DataTable trueRows = decisionNode.TrueRows;
                    DataTable falseRows = decisionNode.FalseRows;

                    decisionNode.TrueNode = BuildNode(trueRows);
                    decisionNode.FalseNode = BuildNode(falseRows);

                    treeNodes.Push(decisionNode.TrueNode);
                    treeNodes.Push(decisionNode.FalseNode);
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

        public LeafNode Classify(DataRow row)
        {
            Node thisNode;
            if (rootNode is DecisionNode) thisNode = (Node)(rootNode as DecisionNode);
            else thisNode = (Node)(rootNode as LeafNode);

            Question[] questions = (thisNode as DecisionNode).Question;
            bool val = false;

            while(!(thisNode is LeafNode))
            {
                for (int i = 0; i < questions.Length && !val; i++)
                {
                    if (!(thisNode is LeafNode))
                    {
                        val = questions[i].compare(row);
                    }
                }

                if (val)
                {
                    thisNode = (thisNode as DecisionNode).TrueNode;
                }
                else
                {
                    thisNode = (thisNode as DecisionNode).FalseNode;
                }

            }
            return (LeafNode)thisNode;
        }

        public static Tuple<double, Question> FindBestQuestion(DataTable rows)
        {
            double bestGain = 0;
            Question bestQuestion = null;
            double uncertainty = Gini(rows);
            int actualColumn = 0;

            foreach(DataRow row in rows.Rows)
            {
                foreach (DataColumn column in rows.Columns)
                {
                    Question q = new Question(actualColumn, row[column]);
                    actualColumn++;
                    Tuple<DataTable, DataTable> truefalse_rows = Partitions(rows, q);

                    if (truefalse_rows.Item1.Columns.Count == 0 || truefalse_rows.Item2.Columns.Count == 0) continue;

                    double gain = CalcInfoGain(truefalse_rows.Item1, truefalse_rows.Item2, uncertainty);

                    if (gain > bestGain)
                    {
                        bestGain = gain;
                        bestQuestion = q;
                    }
                    
                }
                
            }    
            return new Tuple<double, Question>(bestGain, bestQuestion);
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

        public static double CalcInfoGain(DataTable leftRows, DataTable rightRows, double uncertainty)
        {
            double prop = (double)leftRows.Columns.Count / ((double)leftRows.Columns.Count + (double)rightRows.Columns.Count);
            return uncertainty - prop * Gini(leftRows) - (1 - prop) * Gini(rightRows);
        }

        public static string[] UniqueValues(DataTable rows)
        {
            List<string> uniqueValues = new List<string>();
            
            foreach(DataRow row in rows.Rows)
            {
                string val = (string)row[rows.Columns.Count-1];
                if (!uniqueValues.Contains(val))
                {
                    uniqueValues.Add(val);
                }
            }
            return uniqueValues.ToArray();
        }

        public static Tuple<string, int>[] GetValueCounts(DataTable rows)
        {
            List<string> uniqueValues = new List<string>(UniqueValues(rows));
            int[] quant = new int[uniqueValues.Count];

            for (int i = 0; i < quant.Length; i++)
            {
                quant[i] = 0;
            }

            foreach (DataRow row in rows.Rows)
            {
                string rowValue = (string) row[rows.Columns.Count - 1];
                if (uniqueValues.Contains(rowValue))
                {
                    quant[uniqueValues.IndexOf(rowValue)] += 1; 
                }
            }

            Tuple<string, int>[] valueCounts = new Tuple<string, int>[uniqueValues.Count];

            for (int i = 0; i < valueCounts.Length; i++)
            {
                valueCounts[i] = new Tuple<string, int>(uniqueValues[i],quant[i]);
            }

            return valueCounts;
        }

        public static Tuple<DataTable,DataTable> Partitions(DataTable rows, Question q)
        {
            DataTable true_rows = new DataTable();
            DataTable false_rows = new DataTable();

            foreach (DataRow row in rows.Rows)
            {
                if (q.compare(row)) true_rows.Rows.Add(row);
                else false_rows.Rows.Add(row);
            }

            return new Tuple<DataTable, DataTable>(true_rows, false_rows);
        }
    }
}