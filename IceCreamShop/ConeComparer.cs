using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone? x, Cone? y)
        {
            if (x == null || y == null)
                throw new NullReferenceException();

            if (x.Cost == y.Cost)
                return 0;

            if (x.Cost > y.Cost)
                return 1;

            return -1;
        }
    }
}
