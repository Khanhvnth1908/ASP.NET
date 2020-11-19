using Microsoft.AspNetCore.Mvc;
using AppTea.Models;
using System.Linq;
using AppTea.Models.ViewModel;

namespace AppTea.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 3;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        //public ViewResult Index(int productPage = 1) 
        //    => View(repository.Products
        //        .OrderBy(p => p.ProductID)
        //        .Skip((productPage -1) *PageSize)
        //        .Take(PageSize)
        //        );

        //public ViewResult Index(int productPage = 1)
        //    => View(new ProductsListViewModel
        //    {
        //        Products = repository.Products
        //        .OrderBy(p => p.ID)
        //        .Skip((productPage - 1) * PageSize)
        //        .Take(PageSize),

        //        PagingInfo = new PagingInfo
        //        {
        //            CurrentPage = productPage,
        //            ItemsPerPage = PageSize,
        //            TotalItems = repository.Products.Count()
        //        }
        //    });

        public ViewResult Index(string category,int productPage = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            });
    }
}
