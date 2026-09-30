using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulungen.CSharpKurs.ClassLibrary
{
    /// <summary>
    /// Stellt einen Mitarbeiter dar.
    /// </summary>
    /// <remarks>Verwendbar als Datenmodell für Personalinformationen. Erweiterbar um Eigenschaften wie
    /// Identifikation, Name und Rolle.</remarks>
    public class Employee
    {
        /// <summary>
        /// Vorname der Person.
        /// </summary>
        private string _firstName;
        /// <summary>
        /// Der Nachname der Person.
        /// </summary>
        private string _lastName;
        /// <summary>
        /// Das Geburtsdatum.
        /// </summary>
        /// <remarks>Enthält nur das Datum ohne Zeitanteil.</remarks>
        private DateOnly _dateOfBirth;
        /// <summary>
        /// Die zugeordnete Abteilung.
        /// </summary>
        private Department _department;
        /// <summary>
        /// Das Geschlecht der Person.
        /// </summary>
        /// <remarks>Verwendet den Aufzählungstyp <see cref="Gender"/></remarks>
        private Gender _sex;
        /// <summary>
        /// Gehalt des Mitarbeiters als Dezimalwert in der jeweiligen Währung.
        /// </summary>
        private decimal _salary;
        /// <summary>
        /// Eindeutige Kennung des Mitarbeiters.
        /// </summary>
        /// <remarks>Wird vom HR-System oder der Datenbank als Primärschlüssel verwendet.</remarks>
        private int _employeeId;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                }
            }
        }

        public DateOnly DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if(DateTime.Now.Year - value.Year > 15)
                {
                    _dateOfBirth = value;
                }
            }
        }

        public Department Department
        {
            get
            {
                return _department;
            }
            set
            {
                _department = value;
                SetSalary();
            }
        }

        public Gender Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return _salary;
            }
        }

        public int EmployeeId
        {
            get
            {
                return _employeeId;
            }
        }

        /// <summary>
        /// Gibt einen Begrüßungstext mit Vorname, Nachname und Abteilung zurück.
        /// </summary>
        /// <remarks>Verwendet die Instanz­eigenschaften FirstName, LastName und Department zur
        /// Formatierung.</remarks>
        /// <returns>Eine formatierte Begrüßung in der Form: Hallo, mein Name ist {FirstName} {LastName}. Ich arbeite in der
        /// Abteilung {Department}.</returns>
        public string Greet()
        {
            return $"Hallo, mein Name ist {_firstName} {_lastName}. Ich arbeite in der Abteilung {_department}.";
        }

        private void SetSalary()
        {
            switch (_department)
            {
                case Department.IT:
                    _salary = 52000.00m;
                    break;
                case Department.Production:
                    _salary = 45000.00m;
                    break;
                case Department.Sales:
                    _salary = 50000.00m;
                    break;
                case Department.Logistics:
                    _salary = 30000.00m;
                    break;
                case Department.Management:
                    _salary = 120000.00m;
                    break;
                default:
                    _salary = 15000.00m;
                    break;
            }
        }
    }
}