using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace partice.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee
                    {
                        EmployeeName = "Ozuk",
                        EmployeeAge = 18,
                        EmployeeDes = "Ygoz olelothya vylagumtul ualmun erzem mogomnok buthuruth scegenul kynaal volek"
                    },
                    new Employee
                    {
                        EmployeeName = "Nequem",
                        EmployeeAge = 18,
                        EmployeeDes = "Scemem fuhazatum walasth thekunched ezes kyniuhhad viragnac halal ualallal owog"
                    },
                    new Employee
                    {
                        EmployeeName = "Owog",
                        EmployeeAge = 19,
                        EmployeeDes = "Uiraga farad fyon urodum fyon olelothya hioll felleyn fyomnok uilaga"
                    },
                    new Employee
                    {
                        EmployeeName = "Fuhazatum",
                        EmployeeAge = 20,
                        EmployeeDes = "Ne iunhum kethwe thekunched en viragnac fyaal kynzathul buol eses"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
