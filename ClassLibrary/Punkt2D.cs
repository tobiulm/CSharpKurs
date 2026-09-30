using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulungen.CSharpKurs.ClassLibrary
{
    public struct Punkt2D
    {
        public double X;
        public double Y;

        public Punkt2D AddiereVektor(double x, double y)
        {
            Punkt2D ergebnisPunkt;
            ergebnisPunkt.X = X + x;
            ergebnisPunkt.Y = Y + y;
            return ergebnisPunkt;
        }

        public Punkt2D AddiereVektor(Punkt2D p)
        {
            return AddiereVektor(p.X, p.Y);
        }
    }
}