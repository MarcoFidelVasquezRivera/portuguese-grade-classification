using System;
using System.Collections.Generic;
using System.Data;

namespace PortugueseGradeClassification.DecisionTree
{
    internal class DecisionTree
    {
        public Node rootNode { get; private set; }
        public DataTable Rows { get; private set; }
        public List<int> TypeIndex { get; private set; }

        public DecisionTree(DataTable rows, List<int> ordinalIndex)
        {
            this.Rows = rows;
            this.TypeIndex = ordinalIndex;
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

        public Node BuildNode(DataTable rows)
        {
            Tuple<double, Question[]> bestQuestion = FindBestQuestion(rows);

            if (bestQuestion.Item1 == 0)
            {
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

            while (!(thisNode is LeafNode))
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

        //Si es numerico: Se organiza de menor a mayor y se utiliza el promedio entre dos valores para el gini
        //Si es categorico ordinal: Se organiza y se utilizan todos los valores menos el inicial para el gini
        //Si es categorico no ordinal: Se usan todas las posibles combinaciones no repetidas para el gini
        public Tuple<double, Question[]> FindBestQuestion(DataTable rows)
        {
            double bestGain = 0;
            Question bestQuestion = null;
            Question[] bestQuestions = null;
            double uncertainty = Gini(rows);
            int actualColumn = 0;

            foreach (DataColumn column in rows.Columns)
            {
                List<string> value = VariableClassification(actualColumn, rows);

                //FALTA AÑADIR LA INSERCIÓN DE VALORES A LAS QUESTIONS

                Question q = new Question(actualColumn, value);
                Question[] qs = new Question[1];

                Tuple<DataTable, DataTable> truefalse_rows = Partitions(rows, qs);

                if (truefalse_rows.Item1.Columns.Count == 0 || truefalse_rows.Item2.Columns.Count == 0) continue;

                double gain = CalcInfoGain(truefalse_rows.Item1, truefalse_rows.Item2, uncertainty);

                if (gain > bestGain)
                {
                    bestGain = gain;
                    bestQuestion = q;
                }

                actualColumn++;
            }
            return new Tuple<double, Question[]>(bestGain, bestQuestions);
        }

        public List<string> VariableClassification(int column, DataTable rows)
        {
            //0 = Numeric variables
            //1 = Categorical, ordinal variables
            //2 = Categorical, non ordinal variables

            List<string> value = null;
            List<string> uniqueValues = new List<string>(UniqueValues(rows, column));

            if (TypeIndex[column] == 0 || TypeIndex[column] == 0)
            {
                value = uniqueValues;
            }
            else
            {
                int quant = uniqueValues.Count / 2;
                int[] indexes = new int[quant];

                for (int i = 0; i < indexes.Length; i++)
                {
                    indexes[i] = i;
                }

                while (true)
                {
                    //HACERLO
                }
            }
            return value;
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

        public string[] UniqueValues(DataTable rows, int column)
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

        public Tuple<string, int>[] GetValueCounts(DataTable rows)
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

        public Tuple<DataTable, DataTable> Partitions(DataTable rows, Question[] questions)
        {
            DataTable trueRows = new DataTable();
            DataTable falseRows = new DataTable();

            foreach (DataRow row in rows.Rows)
            {
                bool val = false;

                for (int i = 0; i < questions.Length && !val; i++)
                {
                    val = questions[i].compare(row);
                }

                if (val)
                {
                    trueRows.Rows.Add(row);
                }
                else
                {
                    falseRows.Rows.Add(row);
                }
            }

            return new Tuple<DataTable, DataTable>(trueRows, falseRows);
        }
    }
}