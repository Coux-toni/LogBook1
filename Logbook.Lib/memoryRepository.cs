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
            throw new NotImplementedException();
        }

        public List<Entry> GetAll()
        {
          
            return list;
        }

        public bool save()
        {
            throw new NotImplementedException();
        }

        public bool update(Entry entry)
        {
            throw new NotImplementedException();
        }
    }
}
