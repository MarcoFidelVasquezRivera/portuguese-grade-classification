using System;
using System.Data;
using System.Linq;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Filters;

namespace PortugueseGradeClassification.Model
{
    class DecisionTreeLibrary
    {
        private DecisionTree tree;
        private Codification codeBook;
        private string[] headers;

        public DecisionTreeLibrary()
        {
           
        }


        //El ejemplo planteaba para solamente categóricos, revisar como funcionaria añadiendole los numéricos
        // o si funciona igual de bien
        public void TrainTree(DataTable data)
        {
            //Codebook convierte los datos de texto a labels numéricos (esto **podria** molestar con numéricos)
            codeBook = new Codification(data, "school", "sex", "address", "famsize", "Pstatus", "Mjob", "Fjob", "reason", "guardian",
                "schoolsup", "famsup", "paid", "activities","nursery", "higher", "internet", "romantic");
            
            DataTable convertedData = codeBook.Apply(data);

            String[] headers = new string[32];
            for(int i = 0; i<32; i++)
            {
                headers[i] = data.Columns[i].ColumnName;
            }

            setHeaders(headers);

            DecisionVariable[] attributes =
            {
                new DecisionVariable("school", 2),
                new DecisionVariable("sex", 2), 
                new DecisionVariable("age", DecisionVariableKind.Continuous),// revisar i=2 || i=6 || i=7 || (i>=12 && i<=14) || i>=23
                new DecisionVariable("address", 2),
                new DecisionVariable("famsize", 2),
                new DecisionVariable("Pstatus", 2),
                new DecisionVariable("Medu", DecisionVariableKind.Continuous),
                new DecisionVariable("Fedu", DecisionVariableKind.Continuous),
                new DecisionVariable("Mjob", 5),
                new DecisionVariable("Fjob", 5),
                new DecisionVariable("reason", 4),
                new DecisionVariable("guardian", 3),
                new DecisionVariable("traveltime", DecisionVariableKind.Continuous),
                new DecisionVariable("studytime", DecisionVariableKind.Continuous),
                new DecisionVariable("failures", DecisionVariableKind.Continuous),
                new DecisionVariable("schoolsup", 2),
                new DecisionVariable("famsup", 2),
                new DecisionVariable("paid", 2),
                new DecisionVariable("activities", 2),
                new DecisionVariable("nursery", 2),
                new DecisionVariable("higher", 2),
                new DecisionVariable("internet", 2),
                new DecisionVariable("romantic", 2),
                new DecisionVariable("famrel", DecisionVariableKind.Continuous),
                new DecisionVariable("freetime", DecisionVariableKind.Continuous),
                new DecisionVariable("goout", DecisionVariableKind.Continuous),
                new DecisionVariable("Dalc", DecisionVariableKind.Continuous),
                new DecisionVariable("Walc", DecisionVariableKind.Continuous),
                new DecisionVariable("health", DecisionVariableKind.Continuous),
                new DecisionVariable("absences", DecisionVariableKind.Continuous),
                new DecisionVariable("G1", DecisionVariableKind.Continuous),
                new DecisionVariable("G2", DecisionVariableKind.Continuous)
            };


            tree = new DecisionTree(attributes, 11);
            C45Learning c45 = new C45Learning(tree);

            //Convierte los valores traducidos a inputs y el output esperado.
            double[][] inputs = convertedData.ToJagged(headers);
            int[] outputs = convertedData.ToArray<int>("G3");



            //Entrenamiento del arbol
            c45.Learn(inputs, outputs);
        }

        public double Test(DataTable test)
        {
            DataTable convertedData = codeBook.Apply(test);

            //Convierte los valores traducidos a inputs y el output esperado.
            double[][] inputs = convertedData.ToJagged(headers);
            int[] outputs = convertedData.ToArray<int>("G3");

            double error = new ZeroOneLoss(outputs).Loss(tree.Decide(inputs));
            return (1 - error);
        }

        public string Classify(DataTable data)
        {
            DataTable convertedData = codeBook.Apply(data);

            double[][] inputs = convertedData.ToJagged(headers);
            int prediction = tree.Decide(inputs[0]);

            string answer = Convert.ToString(prediction);

            return answer; //lo que devuelva debería ser la nota, aunque existe la opcion "G3 {nota}"
        }

        public void setHeaders(string[] headers)
        {
            this.headers = headers;
        }
    }
}
