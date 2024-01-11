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
        public bool add(Entry entry)
        {
            list.Add(entry);
            return true;
        }

        public bool delete(Entry entry)
        {
            return list.Remove(entry);
        }

        public List<Entry> GetAll()
        {
          
            return list;
        }

        public bool save()
        {
            return true;
        }

        public bool update(Entry entry)
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
