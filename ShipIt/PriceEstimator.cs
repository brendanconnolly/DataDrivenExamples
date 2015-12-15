using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipIt
{
    public class PriceEstimator
    {
        private Func<int, int, decimal,decimal> _zip2zipStrategy;

        public void setZip2ZipStrategy(Func<int,int,decimal,decimal> strategy)
        {
            _zip2zipStrategy = strategy;
        }
        public decimal getShippingRate(string srcZip, string destZip, decimal packageWeight)
        {
            int src = 1;
            int dest = 1;

            int.TryParse(srcZip.Split('-')[0],out src);
            int.TryParse(destZip.Split('-')[0],out dest);

            return _zip2zipStrategy(src, dest, packageWeight);
        }

    }
}
