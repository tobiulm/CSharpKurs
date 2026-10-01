using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulungen.CSharpKurs.InterfaceLibrary
{
    public interface IHuman
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateOnly DateOfBirth { get; set; }


        string Greet();
    }
}
