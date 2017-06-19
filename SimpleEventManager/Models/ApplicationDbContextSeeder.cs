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
                        StartDate = DateTime.Now.AddHours(i),
                        EndDate = DateTime.Now.AddHours(i + 1)
                    };
                    context.Events.Add(evt);
                }
            }

            base.Seed(context);
        }
    }
}