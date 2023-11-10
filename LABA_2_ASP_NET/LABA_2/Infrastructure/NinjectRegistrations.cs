using LABA_2.Models;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static LABA_2.Models.Discount;
using Ninject.Web.Common;

namespace LABA_2.Infrastructure
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IValueCalculator>().To<LinqValueCalculator>().InRequestScope(); ;
            Bind<IDiscountHelper>().To<DefaultDiscountHelper>()
                                           .WithConstructorArgument("discountParam", 10M);
            Bind<IDiscountHelper>().To<FlexibleDiscountHelper>()
                                           .WhenInjectedInto<LinqValueCalculator>();



        }
    }


}