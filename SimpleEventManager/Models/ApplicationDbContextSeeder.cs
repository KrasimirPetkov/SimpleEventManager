using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleEventManager.Models
{
    public class ApplicationDbContextSeeder: DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            if (!context.Events.Any())
            {
                for (int i = 1; i <= 10; i++)
                {
                    var evt = new Event()
                    {
                        Name = $"Seeded Event {i}",
                        Location = $"Seeded Location {i}",
                        StartDate = new DateTime(2017, 7, 1, 1, 0, 0).AddHours(i),
                        EndDate = new DateTime(2017, 7, 1, 1, 0, 0).AddHours(i).AddDays(i)
                    };
                    context.Events.Add(evt);
                }
            }

            base.Seed(context);
        }
    }
}