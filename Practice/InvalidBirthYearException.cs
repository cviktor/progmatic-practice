using System;
using System.Runtime.Serialization;

namespace Practice
{
    [Serializable]
    internal class InvalidBirthYearException : Exception
    {
        public int InvalidYear { get; private set; }

        public InvalidBirthYearException(int invalidYear)
        {
            this.InvalidYear = invalidYear;
        }

        public InvalidBirthYearException(int invalidYear, string message) : base(message)
        {
            this.InvalidYear = invalidYear;
        }

        public InvalidBirthYearException(int invalidYear, string message, Exception innerException) : base(message, innerException)
        {
            this.InvalidYear = invalidYear;
        }

        protected InvalidBirthYearException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}