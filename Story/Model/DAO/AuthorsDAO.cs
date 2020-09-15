using Model.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class AuthorsDAO
    {
        public StoriesEntities1 dbContext = null;
        public AuthorsDAO()
        {
            dbContext = new StoriesEntities1();
        }
        public List<Author> AuthorsList()
        {
            return dbContext.Authors.ToList();
        }
        public List<Author> PageList(int? currentPage, int? pageSize, out int totalPage)
        {
            int firstPage = ((currentPage ?? 1) - 1) * (pageSize ?? 5);
            totalPage = AuthorsList().Count() % (pageSize ?? 5);
            var list = AuthorsList();
            if (totalPage == 0 || totalPage != 0 && currentPage != totalPage)
            {
                list = AuthorsList().OrderBy(x => x.authorsId).Skip(firstPage).Take(pageSize ?? 5).ToList();
            }
            else
            {
                list = AuthorsList().OrderBy(x => x.authorsId).Skip(firstPage).Take((pageSize ?? 5) + 1).ToList();
                totalPage++;
            }
            return list;
        }
    }
}
