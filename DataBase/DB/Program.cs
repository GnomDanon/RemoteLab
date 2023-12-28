using DB;
using DB.Entities;
using System;
using System.Linq;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            using (ApplicationContext db = new ApplicationContext())
            {
                Group group = new Group { Name = "gr1" };
                db.Groups.AddRange(group);
                db.SaveChanges();

                Permission permission = new Permission { Name = "per1", Description = "21598", IsAdmin = false };
                db.Permissions.AddRange(permission);
                db.SaveChanges();

                Role admin = new Role { Name = "Admin", Description = "awfawgaw" };
                Role user = new Role { Name = "User", Description = "89510" };
                db.Roles.AddRange(admin, user);
                db.SaveChanges();

                ServiceType serviceType = new ServiceType { Name = "awfwaf", Description = "awf", DefaultTimeout = new DateTime(2020, 11, 26, 10 - 5, 0, 0, DateTimeKind.Utc), DickerFilename = "awf" };
                db.ServiceTypes.AddRange(serviceType);
                db.SaveChanges();

                Organization organization = new Organization { Name = "Org" };
                db.Organizations.AddRange(organization);
                db.SaveChanges();

                Scheduler scheduler = new Scheduler { Group = group, SessionStartTime = DateTime.UtcNow, SessionEndTime = DateTime.UtcNow, IsActive = true };
                db.Schedulers.AddRange(scheduler);
                db.SaveChanges();
            }

            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    // создаем два объекта User
            //    User user1 = new User { Name = "Www", Surname = "Lll", Organization_ID = 0, Role = db.Roles.First() };
            //    User user2 = new User { Name = "Aaaa", Surname = "Bbbb", Organization_ID = 0, Role = db.Roles.First() };
            //    // добавляем их в бд
            //    db.Users.AddRange(user1, user2);
            //    db.SaveChanges();
            //}
            //// получение данных
            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    // получаем объекты из бд и выводим на консоль
            //    var users = db.Users.ToList();
            //    Console.WriteLine("Users list:");
            //    foreach (User u in users)
            //    {
            //        Console.WriteLine($"{u.ID}.{u.Name} - {u.Surname}");
            //    }
            //}
        }
    }
}