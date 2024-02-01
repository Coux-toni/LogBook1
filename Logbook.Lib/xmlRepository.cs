using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logbook.Lib
{
    public class xmlRepository : IRepository
    {
        XElement _rootelement;
        public xmlRepository(string path)
        {
            if (File.Exists(path))
            {
                _rootelement = XElement.Load(path);
            }
            else 
            { 
                _rootelement = new XElement("entries");
            }
        }
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
            var entries = from entry in this._rootelement.Descendants("entry")
                          select entry;
            throw new NotImplementedException();

            // Objekt erstellen
            // Liste zurückgeben
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
