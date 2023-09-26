using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPAW.Entities
{
    [Serializable]
    public class Reader
    {
        public int readerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Reader(int readerId, string Name, string Email)
        {
            this.readerId = readerId;
            this.Name = Name;
            this.Email = Email;
        }
       public  Reader() { }

    }
}
