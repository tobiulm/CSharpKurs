using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulungen.CSharpKurs.ClassLibrary
{
    /// <summary>
    /// Stellt mögliche Geschlechtsangaben dar.
    /// </summary>
    /// <remarks>Enthält die Werte Female, Male, none und none_binary. Enum-Mitglieder sollten nach
    /// .NET-Richtlinien PascalCase verwenden (z. B. None, NonBinary).</remarks>
    public enum Gender
    {
        /// <summary>
        /// Weiblich.
        /// </summary>
        Female,
        /// <summary>
        /// Männliches Geschlecht.
        /// </summary>
        Male,
        /// <summary>
        /// Keine Angabe des Geschlechtes
        /// </summary>
        None,
        /// <summary>
        /// Repräsentiert das Geschlecht Divers.
        /// </summary>
        NoneBinary
    }
}
