using WebBanDoGiaDung.Models;
namespace WebBanDoGiaDung.Repository
{
    public class cateRepository : categoriesRepository
    {
        private readonly CuaHangGiaDungOnlineContext _context;
        public cateRepository(CuaHangGiaDungOnlineContext context)
        {
            _context = context;
        }

        public Category Add(Category cate)
        {
            _context.Categories.Add(cate);
            _context.SaveChanges();
            return cate;
        }

        public Category Delete(int cateId)
        {
            throw new NotImplementedException();
        }

        public Category Get(int cateId)
        {
            return _context.Categories.Find(cateId);
        }

        public IEnumerable<Category> GetAllCate()
        {
            return _context.Categories;
        }

        public Category Update(Category cate)
        {
            _context.Update(cate);
            _context.SaveChanges();
            return cate;
        }
    }
}
