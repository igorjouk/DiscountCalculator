using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountСalculator.Discounts
{
    class GiftCardDiscount : IDiscount
    {
        private int _giftAmount;
        private DateTime Validity { get; set; }

        public GiftCardDiscount(int giftAmount, DateTime validity)
        {
            _giftAmount = giftAmount;
            Validity = validity;
        }

        public double ApplyDiscount(double productPrice)
        {
            return productPrice - _giftAmount;
        }

        public bool CheckDiscountValidity(DateTime date)
        {
            return date <= DateTime.Now;
        }
    }
}
