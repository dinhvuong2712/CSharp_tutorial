using Model.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class CategoriesDAO
    {
        public StoriesEntities1 dbContext = null;
        public CategoriesDAO()
        {
            dbContext = new StoriesEntities1();
        }
        public List<Category> CategoriesList()
        {
            return dbContext.Categories.ToList();
        }
        public List<Category> PageList(int? currentPage, int? pageSize, out int totalPage)
        {
            int firstPage = ((currentPage ?? 1) - 1) * (pageSize ?? 5);
            totalPage = CategoriesList().Count() % (pageSize ?? 5);
            var list = CategoriesList();
            if (totalPage == 0 || totalPage != 0 && currentPage != totalPage)
            {
                list = CategoriesList().OrderBy(x => x.categoriesId).Skip(firstPage).Take(pageSize ?? 5).ToList();
            }
            else
            {
                list = CategoriesList().OrderBy(x => x.categoriesId).Skip(firstPage).Take((pageSize ?? 5) + 1).ToList();
                totalPage++;
            }
            return list;
        }
    }
}
