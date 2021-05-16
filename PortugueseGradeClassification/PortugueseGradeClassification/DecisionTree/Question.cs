using System;
using System.Data;


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

        private bool IsNumeric(string obj)
        {
            try
            {
                Convert.ToInt32(obj);
                Convert.ToDouble(obj);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public bool compare(DataRow row)
        {
            string rowValue = Convert.ToString(row[this.Column]);
            
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

