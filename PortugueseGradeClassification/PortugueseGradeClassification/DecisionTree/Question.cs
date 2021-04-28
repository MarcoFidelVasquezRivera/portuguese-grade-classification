using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortugueseGradeClassification.DecisionTree
{
    class Question<T>
    {
        private int column;
        private string[] row;
        public object Value{get; private set; }


        public Question(int column, object value)
        {
            this.column = column;
            this.Value = value;
        }

        private bool IsNumeric(object obj)
        {
            return (obj is double || obj is int);//retorna si el objeto es numerico o no
        }
        /*
        public bool compare(T )
        {

        }
        */
    }
}
