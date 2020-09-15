using Model.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class StatusDAO
    {
        public StoriesEntities1 dbContext = null;
        public StatusDAO()
        {
            dbContext = new StoriesEntities1();
        }
        public List<StatusStory> StatusesList()
        {
            return dbContext.StatusStories.ToList();
        }
        public List<StatusStory> PageList(int? currentPage, int? pageSize, out int totalPage)
        {
            int firstPage = ((currentPage ?? 1) - 1) * (pageSize ?? 5);
            totalPage = StatusesList().Count() % (pageSize ?? 5);
            var list = StatusesList();
            if (totalPage == 0 || totalPage != 0 && currentPage != totalPage)
            {
                list = StatusesList().OrderBy(x => x.statusId).Skip(firstPage).Take(pageSize ?? 5).ToList();
            }
            else
            {
                list = StatusesList().OrderBy(x => x.statusId).Skip(firstPage).Take((pageSize ?? 5) + 1).ToList();
                totalPage++;
            }
            return list;
        }
    }
}
