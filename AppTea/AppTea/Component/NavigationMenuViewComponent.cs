using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AppTea.Models;


namespace AppTea.Component
{

    //Tạo View Component để có thể sử dụng lại cho các thành phần khác cho trang web

    public class NavigationMenuViewComponent : ViewComponent
    {
        private IStoreRepository repository;

        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }

        //public string Invoke()
        //{
        //    return "Hello from the Nav View Component";
        //}
    }
}
