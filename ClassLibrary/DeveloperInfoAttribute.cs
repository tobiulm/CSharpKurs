using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulungen.CSharpKurs.ClassLibrary
{
    [AttributeUsage(AttributeTargets.All)]
    public class DeveloperInfoAttribute : Attribute
    {
        public string DevName { get; set; }
        public string EmailAddress { get; set; }

        public DeveloperInfoAttribute(string name, string email)
        {
            DevName = name;
            EmailAddress = email;
        }

    }
}