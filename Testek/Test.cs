using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    abstract class Test
    {
        public string tipus;
        protected Test(string tipus)
        {
            this.tipus = tipus;
        }
        public abstract double Terfogat();
        public abstract double Felszin();
        public override string ToString()
        { return tipus; }
    }
}
