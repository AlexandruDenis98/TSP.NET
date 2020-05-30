using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MemoriesManager
{
    public partial class Keyword
    {
        public bool CreateKeyword()
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                bool bResult = false;
                if (this == null) return bResult;
                if (this.Id == 0)
                {
                    context.Entry<Keyword>(this).State = EntityState.Added;
                    context.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public int DeleteKeyword(int id)
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                return context.Database.ExecuteSqlCommand("Delete From FileKeyword where Keywords_Id = @p0; Delete From Keywords where Id = @p0;", id);
            }
        }
        public List<Keyword> GetAllKeywords()
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                return context.Keywords.ToList<Keyword>();
            }
        }
        public Keyword GetKeywordByKword(string Kword)
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                var query = from k in context.Keywords where k.Kword == Kword select k;
                var keyword = query.FirstOrDefault<Keyword>();
                return keyword;
            }
        }
        //Update a Keyword kword giving its id
        public Keyword UpdateKeywordKwordById(int id, string Kword)
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                var query = from k in context.Keywords where k.Id == id select k;
                var keyword = query.FirstOrDefault<Keyword>();
                if (keyword != null)
                {
                    keyword.Kword = Kword;
                    context.SaveChanges();
                }
                return keyword;
            }
        }
    }
}
