using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebBanDoGiaDung.Models;
using X.PagedList;

namespace WebBanDoGiaDung.Controllers
{
    public class HomeController : Controller
    {
        CuaHangGiaDungOnlineContext db = new CuaHangGiaDungOnlineContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? page)
        {
            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;

            var list_sp = db.Products.AsNoTracking().OrderBy(x=>x.ProductName);
            PagedList<Product> list = new PagedList<Product>(list_sp, pageNumber, pageSize);

            return View(list);
        }

        public IActionResult products_cate(int catId, int? page)
        {
            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;

            var list_sp = db.Products.AsNoTracking().Where(x => x.CatId == catId).OrderBy(x => x.ProductName);
            PagedList<Product> list = new PagedList<Product>(list_sp, pageNumber, pageSize);
            ViewBag.catId = catId;
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}