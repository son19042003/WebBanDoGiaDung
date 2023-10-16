using WebBanDoGiaDung.Models;
namespace WebBanDoGiaDung.Repository
{
    public interface categoriesRepository
    {
        Category Add(Category cate);
        Category Update(Category cate);
        Category Delete(int cateId);
        Category Get(int cateId);
        IEnumerable<Category> GetAllCate();
    }
}
