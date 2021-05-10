using System;

namespace PortugueseGradeClassification.CustomExceptions
{
    [Serializable]
    internal class IncorrectLimitsException : Exception
    {
        public IncorrectLimitsException(string message)
            : base(message) { }
    }
}