using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountСalculator.Discounts
{
    class PercentageDiscount : IDiscount
    {
        private double _percentDiscount;
        public double PercentDiscount
        {
            get { return _percentDiscount; }
            set
            {
                if (_percentDiscount > 0 && _percentDiscount < 100)
                {
                    _percentDiscount = value;
                }
                else
                {
                    _percentDiscount = 0;
                }
            }
        }
        public PercentageDiscount(double percentDiscount)
        {
            PercentDiscount = percentDiscount;
        }
        public double ApplyDiscount(double productPrice)
        {
            throw new NotImplementedException();
        }
    }
}
