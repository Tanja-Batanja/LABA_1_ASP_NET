﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LABA_2.Models
{
    public class Discount
    {
        public interface IDiscountHelper
        {
            decimal ApplyDiscount(decimal totalParam);
        }
        public class DefaultDiscountHelper : IDiscountHelper
        {
            private decimal discountSize;
            public DefaultDiscountHelper(decimal discountParam)
            {
                discountSize = discountParam;
            }
            public decimal ApplyDiscount(decimal totalParam)
            {
                return (totalParam - (discountSize / 100m * totalParam));
            }

        }


    }
}