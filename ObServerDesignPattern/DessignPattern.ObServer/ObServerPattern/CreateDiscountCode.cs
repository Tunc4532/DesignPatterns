using DessignPattern.ObServer.DAL;
using System;

namespace DessignPattern.ObServer.ObServerPattern
{
    public class CreateDiscountCode : IObServer
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                 DiscountCode = "DERGİMAJ",
                 DiscountAmount = 35,
                 DiscountCodeStatus = true
            });
            context.SaveChanges();
        }
    }
}
