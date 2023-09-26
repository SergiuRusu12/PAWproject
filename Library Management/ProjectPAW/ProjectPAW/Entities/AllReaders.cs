using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPAW.Entities
{
    [Serializable]
    public class AllReaders
    {
        public List<Reader> Readers { get; set; }

        public AllReaders() { 
            Readers = new List<Reader>();
        }
        public AllReaders(List<Reader> readers)
        {
            Readers = readers;
        }

        public string name;
        public AllReaders(string name) : this()
        {
            this.name = name;
        }
    }
}
