using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    internal class Kocka : Test
    {
        readonly double lapA;

        public double LapA => lapA;

        public Kocka(double lapA) : base ("Kocka")
        {
            this.lapA = lapA;
        }

        public override double Terfogat()
        { return (lapA * lapA * lapA); }

        public override double Felszin()
        { return (lapA * lapA * 6); }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
