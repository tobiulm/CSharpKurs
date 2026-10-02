using ItSchulungen.CSharpKurs.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulungen.CSharpKurs.ConsoleApp
{
    internal static class MyExtensions
    {
        public static short CalculateAge(this Employee e)
        {
            short result;
            result = (short)(DateTime.Now.Year - e.DateOfBirth.Year);
            if(DateTime.Now.Date.Month < e.DateOfBirth.Month || DateTime.Now.Month == e.DateOfBirth.Month && DateTime.Now.Day < e.DateOfBirth.Day)
            {
                result--;
            }
            return result;
        }
    }
}