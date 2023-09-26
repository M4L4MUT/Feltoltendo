using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    internal class Teglatest : Test
    {
        readonly double lapA;
        readonly double lapB;
        readonly double lapC;

        public double LapA => lapA;
        public double LapB => lapB;
        public double LapC => lapC;

        public Teglatest(double lapA, double lapB, double lapC) : base("Téglatest")
        {
            this.lapA = lapA;
            this.lapB = lapB;
            this.lapC = lapC;

        }
        public override double Terfogat()
        { return (lapA * lapB * lapC); }

        public override double Felszin()
        { return (2*(lapA * lapB + lapA * lapB + lapB * lapC)); }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
