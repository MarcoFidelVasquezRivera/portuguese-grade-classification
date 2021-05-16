using System;
using System.Collections.Generic;
using System.Data;

namespace PortugueseGradeClassification.DecisionTreeSpace
{
    public class DecisionTree
    {
        public Node RootNode { get; private set; }
        public DataTable Rows { get; private set; }
        public List<int> TypeIndex { get; private set; }

        public DecisionTree(DataTable rows)
        {
            this.Rows = rows;
        }

        public void BuildTree()
        {
            RootNode = BuildNode(Rows);
            Stack<Node> treeNodes = new Stack<Node>();
            treeNodes.Push(RootNode);

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

        public Node BuildNode(DataTable rows)
        {
            Tuple<double, Question> bestQuestion = FindBestQuestion(rows);

            if (bestQuestion.Item1 == 0)
            {
                return new LeafNode(rows);
            }
            Tuple<DataTable, DataTable> truefalse_rows = Partitions(rows, bestQuestion.Item2);

            return new DecisionNode(bestQuestion.Item2, truefalse_rows.Item1, truefalse_rows.Item2);
        }

        public string Classify(DataRow row)
        {
            Node thisNode;
            if (RootNode is DecisionNode) thisNode = (Node)(RootNode as DecisionNode);
            else thisNode = (Node)(RootNode as LeafNode);

            while (!(thisNode is LeafNode))
            {
                Question question = (thisNode as DecisionNode).Question;
                if (question.compare(row))
                {
                    thisNode = (thisNode as DecisionNode).TrueNode;
                    Console.WriteLine("Derecha "+question.ToString());
                }
                else
                {
                    thisNode = (thisNode as DecisionNode).FalseNode;
                    Console.WriteLine("Izquierda "+question.ToString());
                }
            }
            return ((LeafNode) thisNode).ToString();
        }

        //Si es numerico: Se organiza de menor a mayor y se utiliza el promedio entre dos valores para el gini
        //Si es categorico ordinal: Se organiza y se utilizan todos los valores menos el inicial para el gini
        //Si es categorico no ordinal: Se usan todas las posibles combinaciones no repetidas para el gini
        public Tuple<double, Question> FindBestQuestion(DataTable rows)
        {
            double bestGain = 0;
            Question bestQuestion = null;
            double uncertainty = Gini(rows);
            int actualColumn = 0;
            

            foreach (DataColumn column in rows.Columns)

            {
                if (actualColumn != 32)
                {
                    List<string> allValues = new List<string>(UniqueValues(rows, actualColumn));
                    allValues.Sort();

                    for (int i = 0; i < allValues.Count; i++)
                    {
                        Question q = new Question(actualColumn, allValues[i]);

                        Tuple<DataTable, DataTable> truefalse_rows = Partitions(rows, q);

                        if (truefalse_rows.Item1.Rows.Count != 0 && truefalse_rows.Item2.Rows.Count != 0)
                        {
                            double gain = CalcInfoGain(truefalse_rows.Item1, truefalse_rows.Item2, uncertainty);

                            if (gain > bestGain)
                            {
                                bestGain = gain;
                                bestQuestion = q;
                            }
                        }                  
                    }
                    actualColumn++;
                }             
            }

            return new Tuple<double, Question>(bestGain, bestQuestion);
        }

        public double Gini(DataTable rows)
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

        public double CalcInfoGain(DataTable leftRows, DataTable rightRows, double uncertainty)
        {
            double prop = (double)leftRows.Columns.Count / ((double)leftRows.Columns.Count + (double)rightRows.Columns.Count);
            return uncertainty - prop * Gini(leftRows) - (1 - prop) * Gini(rightRows);
        }

        public static string[] UniqueValues(DataTable rows, int column)
        {
            List<string> uniqueValues = new List<string>();

            foreach (DataRow row in rows.Rows)
            {
                string val = (string)row[column];
                if (!uniqueValues.Contains(val))
                {
                    uniqueValues.Add(val);
                }
            }
            return uniqueValues.ToArray();
        }

        public static Tuple<string, int>[] GetValueCounts(DataTable rows)
        {
            List<string> uniqueValues = new List<string>(UniqueValues(rows, rows.Columns.Count - 1));
            int[] quant = new int[uniqueValues.Count];

            for (int i = 0; i < quant.Length; i++)
            {
                quant[i] = 0;
            }

            foreach (DataRow row in rows.Rows)
            {
                string rowValue = (string)row[rows.Columns.Count - 1];
                if (uniqueValues.Contains(rowValue))
                {
                    quant[uniqueValues.IndexOf(rowValue)] += 1;
                }
            }

            Tuple<string, int>[] valueCounts = new Tuple<string, int>[uniqueValues.Count];

            for (int i = 0; i < valueCounts.Length; i++)
            {
                valueCounts[i] = new Tuple<string, int>(uniqueValues[i], quant[i]);
            }

            return valueCounts;
        }

        public Tuple<DataTable, DataTable> Partitions(DataTable rows, Question question)
        {
            DataTable trueRows = new DataTable();
            DataTable falseRows = new DataTable();
            for(int i = 0; i<33; i++)
            {
                trueRows.Columns.Add();
                falseRows.Columns.Add();
            }

            foreach (DataRow row in rows.Rows)
            {
                if (question.compare(row))
                {
                    trueRows.Rows.Add(row.ItemArray);
                }
                else
                {
                    falseRows.Rows.Add(row.ItemArray);
                }
            }

            return new Tuple<DataTable, DataTable>(trueRows, falseRows);
        }
    }
}