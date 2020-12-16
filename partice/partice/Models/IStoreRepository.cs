using System.Linq;

namespace partice.Models
{
    public interface IStoreRepository
    {
        IQueryable<Employee> Employees { get; }
    }
}
