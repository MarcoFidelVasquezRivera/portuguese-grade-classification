using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortugueseGradeClassification.DecisionTree
{
    class Question
    {
        public int Column{ get; private set; }
        public string Value{get; private set; }


        public Question(int column, string value)
        {
            this.Column = column;
            this.Value = value;
        }

        private bool IsNumeric(object obj)
        {
            return (obj is double || obj is int);//retorna si el objeto es numerico o no
        }
        
        public bool compare(DataRow row)
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
                message = $"Is col.{Column} >= {Convert.ToDouble(Value)}?";
            }
            else
            {
                message = $"Is col.{Column} == {Value}?";
            }
            return message;
        }
    }
}

