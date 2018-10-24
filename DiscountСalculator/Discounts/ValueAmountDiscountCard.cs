using System;

namespace DiscountСalculator.Discounts
{
    class ValueAmountDiscountCard : IDiscount
    {
        private double _discount;

        public ValueAmountDiscountCard(double discount)
        {
            _discount = discount;
        }
        public double ApplyDiscount(double productPrice)
        {
            return productPrice - _discount;
        }
    }
}
