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


        /// <summary>
        /// Liest oder schreibt den Vornamen der Person.
        /// </summary>
        /// <remarks>Der Setter weist das zugrunde liegende Feld nur zu, wenn sich der Wert
        /// ändert.</remarks>
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

        /// <summary>
        /// Liest oder schreibt den Nachnamen der Person.
        /// </summary>
        /// <remarks>Beim Setzen wird der interne Wert nur aktualisiert, wenn der neue Wert vom aktuellen
        /// abweicht.</remarks>
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

        /// <summary>
        /// Liest oder schreibt das Geburtsdatum; beim Setzen wird nur akzeptiert, wenn die Differenz der Kalenderjahre zum aktuellen Jahr
        /// größer als 15 ist.
        /// </summary>
        /// <remarks>Der Setter verwendet DateTime.Now.Year - value.Year zur Altersprüfung und ignoriert
        /// Monate und Tage; Werte, die ein Alter von 15 Jahren oder jünger ergäben, werden still verworfen (keine
        /// Ausnahme).</remarks>
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


        /// <summary>
        /// Ruft die Abteilung ab oder legt sie fest.
        /// </summary>
        /// <remarks>Beim Setzen wird SetSalary() aufgerufen, um das Gehalt entsprechend der Abteilung neu
        /// zu berechnen.</remarks>
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

        /// <summary>
        /// Gibt oder setzt das Geschlecht der Entität.
        /// </summary>
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

        /// <summary>
        /// Ruft das Gehalt ab.
        /// </summary>
        public decimal Salary
        {
            get
            {
                return _salary;
            }
        }

        /// <summary>
        /// Gibt die eindeutige Kennung des Mitarbeiters zurück.
        /// </summary>
        public int EmployeeId
        {
            get
            {
                return _employeeId;
            }
        }

        /// <summary>
        /// Initialisiert eine neue Instanz der Employee-Klasse.
        /// </summary>
        public Employee()
        { }

        /// <summary>
        /// Initialisiert eine neue Instanz der Employee-Klasse mit Vor- und Nachname.
        /// </summary>
        /// <param name="firstName">Vorname des Mitarbeiters.</param>
        /// <param name="lastName">Nachname des Mitarbeiters.</param>
        public Employee(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        /// <summary>
        /// Initialisiert eine neue Instanz der Employee-Klasse mit Vorname, Nachname, Geburtsdatum, Abteilung und
        /// Geschlecht.
        /// </summary>
        /// <param name="firstName">Vorname des Mitarbeiters.</param>
        /// <param name="lastName">Nachname des Mitarbeiters.</param>
        /// <param name="dateOfBirth">Geburtsdatum des Mitarbeiters.</param>
        /// <param name="department">Abteilung, der der Mitarbeiter zugeordnet ist.</param>
        /// <param name="sex">Geschlecht des Mitarbeiters.</param>
        public Employee(string firstName, string lastName, DateOnly dateOfBirth, Department department, Gender sex):this(firstName, lastName)
        {
            DateOfBirth = dateOfBirth;
            Department = department;
            _sex = sex;
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

        /// <summary>
        /// Setzt das interne Feld _salary auf einen vordefinierten Betrag entsprechend dem aktuellen _department.
        /// </summary>
        /// <remarks>Weist vordefinierte Gehälter zu: Department.IT = 52000.00m; Department.Production =
        /// 45000.00m; Department.Sales = 50000.00m; Department.Logistics = 30000.00m; Department.Management =
        /// 120000.00m. Bei unbekannter Abteilung wird der Standardwert 15000.00m verwendet.</remarks>
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