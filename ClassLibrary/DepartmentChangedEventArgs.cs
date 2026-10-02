using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulungen.CSharpKurs.ClassLibrary
{
    public class DepartmentChangedEventArgs : EventArgs
    {
        public Department OldDepartment { get; set; }

        public Department NewDepartment { get; set; }


        public DepartmentChangedEventArgs(Department oldDept, Department newDept)
        {
            OldDepartment = oldDept;
            NewDepartment = newDept;
        }
    }
}