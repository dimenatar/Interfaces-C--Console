using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class DoubleMas : IComparer<DoubleMas>
    {
        private double chislo;
        public DoubleMas(double chislo)
        {
            Chislo = chislo;
        }

        public double Chislo { get => chislo; set => chislo = value; }

        public int Compare(DoubleMas x, DoubleMas y)
        {
            double temp = Math.Round(x.Chislo - Math.Truncate(x.Chislo),1);
            double temp2 = Math.Round(y.Chislo - Math.Truncate(y.Chislo),1);

            temp *= 10;
            temp2 *= 10;
            return (int)(temp-temp2);
        }
    }
  
}

