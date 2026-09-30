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
        public string FirstName;
        /// <summary>
        /// Der Nachname der Person.
        /// </summary>
        public string LastName;
        /// <summary>
        /// Das Geburtsdatum.
        /// </summary>
        /// <remarks>Enthält nur das Datum ohne Zeitanteil.</remarks>
        public DateOnly DateOfBirth;
        /// <summary>
        /// Die zugeordnete Abteilung.
        /// </summary>
        public Department Department;
        /// <summary>
        /// Das Geschlecht der Person.
        /// </summary>
        /// <remarks>Verwendet den Aufzählungstyp <see cref="Gender"/></remarks>
        public Gender Sex;
        /// <summary>
        /// Gehalt des Mitarbeiters als Dezimalwert in der jeweiligen Währung.
        /// </summary>
        public decimal Salary;
        /// <summary>
        /// Eindeutige Kennung des Mitarbeiters.
        /// </summary>
        /// <remarks>Wird vom HR-System oder der Datenbank als Primärschlüssel verwendet.</remarks>
        public int EmployeeId;


        /// <summary>
        /// Gibt einen Begrüßungstext mit Vorname, Nachname und Abteilung zurück.
        /// </summary>
        /// <remarks>Verwendet die Instanz­eigenschaften FirstName, LastName und Department zur
        /// Formatierung.</remarks>
        /// <returns>Eine formatierte Begrüßung in der Form: Hallo, mein Name ist {FirstName} {LastName}. Ich arbeite in der
        /// Abteilung {Department}.</returns>
        public string Greet()
        {
            return $"Hallo, mein Name ist {FirstName} {LastName}. Ich arbeite in der Abteilung {Department}.";
        }
    }
}