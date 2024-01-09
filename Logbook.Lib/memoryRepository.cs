using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logbook.Lib
{
    public class memoryRepository : IRepository
    {
        public bool add(Entry entry)
        {
            throw new NotImplementedException();
        }

        public bool delete(Entry entry)
        {
            throw new NotImplementedException();
        }

        public List<Entry> GetAll()
        {
            List<Entry> list = new List<Entry>()
            {
                new Entry(DateTime.Now, DateTime.Now, 10000, 10100, "ZE-1234","Zell am See", "Salzburg"),
                new Entry(DateTime.Now, DateTime.Now, 10100, 10200, "ZE-1234","Salzburg", "Zell am See"),
            };
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
