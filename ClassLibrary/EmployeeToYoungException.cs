using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulungen.CSharpKurs.ClassLibrary
{
    public class EmployeeToYoungException : Exception
    {
        public EmployeeToYoungException()
        {
        }

        public EmployeeToYoungException(string message) : base(message)
        {
        }

        public EmployeeToYoungException(string message, Exception innerException):base(message, innerException)
        {
        }
    }
}