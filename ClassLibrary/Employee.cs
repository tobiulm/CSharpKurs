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
    [DeveloperInfo("Tobi", "tu@tobiasulm.net")]
    public class Employee : Human
    {
       
        /// <summary>
        /// Die zugeordnete Abteilung.
        /// </summary>
        private Department _department;
       
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
                if (_department != value)
                {
                    Department oldDept = _department;
                    _department = value;
                    SetSalary(); // Berechne das Gehalt neu auf basis der Abteilung
                    if (DepartmentChanged != null) // Gibt es irgendjemanden den die Änderung der Abteilung interessiert?
                    {
                        DepartmentChanged(new DepartmentChangedEventArgs(oldDept, _department)); // Benachrichtige alle die die Änderung der Abteilung mitbekommen wollen,das die Abteilung geändert wurde!
                    }
                }
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
        /// Ruft das Geburtsdatum des Mitarbeiters ab oder legt es fest.
        /// Beim Setzen wird überprüft, ob der Mitarbeiter mindestens 16 Jahre alt ist.
        /// Ist dies nicht der Fall, bleibt der vorhandene Wert unverändert.
        /// </summary>
        /// <value>Das Geburtsdatum als <see cref="DateOnly"/>.</value>
        /// <remarks>
        /// Die Altersprüfung erfolgt vereinfacht anhand des Jahres (aktuelles Jahr minus Geburtsjahr).
        /// Dadurch werden Monat und Tag nicht berücksichtigt. Für eine exaktere Prüfung sollte
        /// das vollständige Datum verglichen werden.
        /// </remarks>
        new public DateOnly DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if(DateTime.Now.Year - value.Year >=16)
                {
                    _dateOfBirth = value;
                }
                else
                {
                    throw new EmployeeToYoungException("Mitarbeiter müssen mindestens 16 Jahre alt sein!");
                }
            }
        }


        public delegate void DepartmentChangedEventHandler(DepartmentChangedEventArgs args);
        public event DepartmentChangedEventHandler DepartmentChanged;


        /// <summary>
        /// Initialisiert eine neue Instanz der Employee-Klasse.
        /// </summary>
        public Employee():this(string.Empty, string.Empty)
        { }

        /// <summary>
        /// Initialisiert eine neue Instanz der Employee-Klasse mit Vor- und Nachname.
        /// </summary>
        /// <param name="firstName">Vorname des Mitarbeiters.</param>
        /// <param name="lastName">Nachname des Mitarbeiters.</param>
        public Employee(string firstName, string lastName):this(firstName, lastName, new DateOnly(), Department.Production, Gender.None)
        {
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
        public Employee(string firstName, string lastName, DateOnly dateOfBirth, Department department, Gender sex):base(firstName, lastName, dateOfBirth, sex)
        {
            Department = department;
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

        /// <summary>
        /// Gibt einen Begrüßungstext mit Vorname, Nachname, Abteilung und Personalnummer zurück.
        /// </summary>
        /// <remarks>Verwendet die Instanz­eigenschaften FirstName, LastName, Department und EmployeeId zur
        /// Formatierung.</remarks>
        /// <returns>Eine formatierte Begrüßung in der Form: Hallo, mein Name ist {FirstName} {LastName}. Ich arbeite in Abteilung {_department} und meine Personalnummer lautet: {_employeeId}.
        /// </returns>
        public override string Greet()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("##########################################################################################################");
            result.AppendLine(base.Greet());
            result.AppendLine($"Ich arbeite in Abteilung {_department} und meine Personalnummer lautet: {_employeeId}.");
            result.AppendLine("##########################################################################################################");
            return result.ToString();
        }

    }
}