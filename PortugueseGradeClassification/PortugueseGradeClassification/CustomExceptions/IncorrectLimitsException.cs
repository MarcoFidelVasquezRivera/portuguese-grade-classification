using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortugueseGradeClassification.CustomExceptions
{
    [Serializable]
    class IncorrectLimitsException : Exception
    {
        public IncorrectLimitsException(string message)
            : base(message){ }
    }
}
