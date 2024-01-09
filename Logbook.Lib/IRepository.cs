using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logbook.Lib
{
    public interface IRepository
    {
        bool add(Entry entry);
        bool delete(Entry entry);
        bool update(Entry entry);
        bool save();

        List<Entry> GetAll();
    }
}
