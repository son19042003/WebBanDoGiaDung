using WebBanDoGiaDung.Models;
using Microsoft.AspNetCore.Mvc;
using WebBanDoGiaDung.Repository;

namespace WebBanDoGiaDung.ViewComponents
{
    public class MenuCateViewComponent: ViewComponent
    {
        private readonly categoriesRepository _category;
        public MenuCateViewComponent(categoriesRepository cateRe)
        {
            _category = cateRe;
        }
        public IViewComponentResult Invoke()
        {
            var cate = _category.GetAllCate().OrderBy(x => x.CatName);
            return View(cate);
        }
    }
}
