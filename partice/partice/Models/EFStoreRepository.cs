using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace partice.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;

        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Employee> Employees => context.Employees;
    }
}
