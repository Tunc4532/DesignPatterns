using DessignPattern.ObServer.DAL;
using System;

namespace DessignPattern.ObServer.ObServerPattern
{
    public class CreateWelcomeMessage : IObServer
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Contenter = "Haber bültenimize kayıt olduğunuz için çok teşekkür edderiz.bu bir test deneme mesajıdır iyi çalışmalar",
            });
            context.SaveChanges();
        }
    }
}
