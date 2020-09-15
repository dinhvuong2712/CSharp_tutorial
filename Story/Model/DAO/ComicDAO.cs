using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entity_Framework;
namespace Model.DAO
{
    public class ComicDAO
    {
        public StoriesEntities1 dbContext = null;
        public ComicDAO()
        {
            dbContext = new StoriesEntities1();
        }
        public List<Comic> ComicsList()
        {
            return dbContext.Comics.ToList();//return list comic
        }
        public List<Comic> PageList(int? currentPage,int? pageSize,out int totalPage)
        {
            int firstPage = ((currentPage??1) - 1) * (pageSize??5);
            totalPage = ComicsList().Count() % (pageSize ?? 5);
            var list = ComicsList();
            if (totalPage == 0 || totalPage != 0 && currentPage != totalPage)
            {
                list = ComicsList().OrderByDescending(x => x.dateSubmitted).Skip(firstPage).Take(pageSize ?? 5).ToList();
            }
            else
            {
                list = ComicsList().OrderByDescending(x => x.dateSubmitted).Skip(firstPage).Take((pageSize ?? 5) + 1).ToList();
                totalPage ++;
            }
            return list;
        }
        public Comic FindComic(int id) { return dbContext.Comics.Find(id); }

        public 
    }
}
