using DisabilityConfidentWebsite.Models;
using System.Linq;

namespace DisabilityConfidentWebsite.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EmployerContext context)
        {
            context.Database.EnsureCreated();

            if (context.Employers.Any())
            {
                // DB has been seeded
                return;
            }

            var employers = new Employer[]
            {
               new Employer{Name="1 Business Enterprise t/a Get Set Academy",Place="Blackburn",Postcode="BB2", Sector="Education / Teaching",DCLevel="Committed"},
               new Employer{Name="2 Minds",Place="Thornton Hough",Postcode="CH63", Sector="Other",DCLevel="Committed"}

            };
            
            foreach (Employer e in employers)
            {
                context.Employers.Add(e);
            }

            context.SaveChanges();
        }
    }
}
