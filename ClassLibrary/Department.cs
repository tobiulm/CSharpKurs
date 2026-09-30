using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulungen.CSharpKurs.ClassLibrary
{
    /// <summary>
    /// Aufzählung der Unternehmensabteilungen.
    /// </summary>
    /// <remarks>Verwendet zur Klassifizierung von Mitarbeitenden, Zuständigkeiten und Prozessen innerhalb des
    /// Systems.</remarks>
    public enum Department
    {
        /// <summary>
        /// Kennzeichnet die Fertigung.
        /// </summary>
        /// <remarks>Hier werden unsere Produkte erstellt
        /// </remarks>
        Production,
        /// <summary>
        /// Repräsentiert den Verkauf und zugehörige Vorgänge.
        /// </summary>
        Sales,
        /// <summary>
        /// Repräsentiert Verwaltungsfunktionen oder einen Verwaltungsbereich.
        /// </summary>
        Management,
        /// <summary>
        /// Abstraktion für Funktionalität und Dienste im Bereich Informationstechnologie.
        /// </summary>
        IT,
        /// <summary>
        /// Stellt Funktionalität und Daten für Logistikvorgänge wie Versand, Lagerhaltung und Distribution bereit.
        /// </summary>
        /// <remarks>Verwaltet Versand-, Lager- und Distributionsprozesse. Implementierungen sollten
        /// Schnittstellen für Planung, Nachverfolgung und Fehlerbehandlung anbieten.</remarks>
        Logistics
    }
}