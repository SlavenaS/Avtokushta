using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AvtokushtaProject
{
    public class IComparatorPrice:IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
}
