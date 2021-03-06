﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountСalculator.Discounts
{
    class PercentageDiscountCard : IDiscount
    {
        private double _percentDiscount;
        public double PercentDiscount
        {
            get { return _percentDiscount; }
            set
            {
                if (value > 0 && value < 100)
                {
                    _percentDiscount = value;
                }
                else
                {
                    _percentDiscount = 0;
                }
            }
        }
        public PercentageDiscountCard(double percentDiscount)
        {
            PercentDiscount = percentDiscount;
        }
        public double ApplyDiscount(double productPrice)
        {
            return productPrice - productPrice * PercentDiscount / 100;
        }
    }
}
