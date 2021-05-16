using System;
using System.Data;


namespace PortugueseGradeClassification.DecisionTreeSpace
{
    public class Question
    {
        public int Column{ get; private set; }
        public string Value{get; private set; }


        public Question(int column, string value)
        {
            this.Column = column;
            this.Value = value;
        }

        private bool IsNumeric(int obj)
        {
            int [] numColumns= {2,6,7,12,13,14,23,24,25,26,27,28,29,30,31,32};
            foreach (int i in numColumns)
            {
                if (i == obj)
                {
                    return true; ;
                }
            }
            return false;
        }
        
        public bool compare(DataRow row)
        {
            string rowValue = Convert.ToString(row[this.Column]);
            
            if (IsNumeric(this.Column))
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
            if (IsNumeric(this.Column))
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

