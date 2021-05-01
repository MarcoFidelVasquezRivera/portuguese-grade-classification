using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortugueseGradeClassification.DecisionTree
{
    class Question<T>
    {
        public int Column{ get; private set; }
        private string[] row;
        public object Value{get; private set; }


        public Question(int column, object value)
        {
            this.Column = column;
            this.Value = value;
        }

        private bool IsNumeric(object obj)
        {
            return (obj is double || obj is int);//retorna si el objeto es numerico o no
        }
        
        public bool compare(T[] row)
        {
            object rowValue = row[this.Column];
            
            if (IsNumeric(this.Value) && IsNumeric(rowValue))
            {
                return Convert.ToDouble(rowValue) >= Convert.ToDouble(Value);
            }
            else
            {
                return this.Value.Equals(rowValue);
            }
        }

        public override string ToString()
        {
            string message = "";
            if (IsNumeric(Value))
            {
                message = $"Is col.{Column} >= {(double)Value}?";
            }
            else
            {
                message = $"Is col.{Column} == {(string)Value}?";
            }
            return message;
        }
    }
}

