using System.Linq;

namespace AppTea.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
