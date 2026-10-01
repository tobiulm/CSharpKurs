using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulungen.CSharpKurs.ClassLibrary
{

    /// <summary>
    /// Repräsentiert einen Menschen.
    /// </summary>
    /// <remarks>Platzhalterklasse zur Modellierung von Personendaten; erweitern Sie sie um Eigenschaften (z.
    /// B. Name, Alter) und Verhalten.</remarks>
    public class Human
    {
        /// <summary>
        /// Vorname der Person.
        /// </summary>
        private string _firstName;
        /// <summary>
        /// Der Nachname der Person.
        /// </summary>
        protected string _lastName;
        /// <summary>
        /// Das Geburtsdatum.
        /// </summary>
        /// <remarks>Enthält nur das Datum ohne Zeitanteil.</remarks>
        internal DateOnly _dateOfBirth;
        /// <summary>
        /// Das Geschlecht der Person.
        /// </summary>
        /// <remarks>Verwendet den Aufzählungstyp <see cref="Gender"/></remarks>
        protected internal Gender _sex;

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
                if (DateTime.Now.Year - value.Year > 15)
                {
                    _dateOfBirth = value;
                }
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

        public Human()
        {
            
        }

        public Human(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public Human(string firstName, string lastName, DateOnly dateOfBirth, Gender sex):this(firstName, lastName)
        {
            DateOfBirth = dateOfBirth;
            Sex = sex;
        }

        /// <summary>
        /// Gibt einen Begrüßungstext mit Vorname, Nachname zurück.
        /// </summary>
        /// <remarks>Verwendet die Instanz­eigenschaften FirstName, LastName zur
        /// Formatierung.</remarks>
        /// <returns>Eine formatierte Begrüßung in der Form: Hallo, mein Name ist {FirstName} {LastName}.
        /// </returns>
        public virtual string Greet()
        {
            return $"Hallo, mein Name ist {_firstName} {_lastName}.";
        }
    }
}
