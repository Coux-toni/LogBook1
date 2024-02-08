using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logbook.Lib
{
    public class memoryRepository : IRepository
    {
        List<Entry> list = new List<Entry>();
        public bool Add(Entry entry)
        {
            list.Add(entry);
            return true;
        }

        public bool Delete(Entry entry)
        {
            return list.Remove(entry);
        }

        public Entry? Find(string id)
        {
            var entries = from e in list
                          where e.ID == id
                          select e;
            return entries.FirstOrDefault();
        }

        public List<Entry> GetAll()
        {
          
            return list;
        }

        public bool Save()
        {
            return true;
        }

        public bool Update(Entry entry)
        {
            var item = (from search in list
                       where entry.ID == search.ID
                       select search).FirstOrDefault();
            if (item != null)
            {
                item = entry;
                return true;
            }
            return false;
        }
    }
}
