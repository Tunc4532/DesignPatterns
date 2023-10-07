using DessignPattern.ObServer.DAL;
using System;

namespace DessignPattern.ObServer.ObServerPattern
{
    public class CreateMaganizeAnnouncement : IObServer
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMaganizeAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            context.UserProceses.Add(new UserProcese
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Bilim Dergisi",
                Contente = "Mart sayısı dergimiz sizlerle iyi okumalar"
            });
            context.SaveChanges();
        }
    }
}
