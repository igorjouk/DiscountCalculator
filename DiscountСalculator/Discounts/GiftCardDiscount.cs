using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountСalculator.Discounts
{
    class GiftCardDiscount : IDiscount
    {
        public DateTime Validity { get; set; }
        public double ApplyDiscount(double productPrice)
        {
            throw new NotImplementedException();
        }
    }
}
