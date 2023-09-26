using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPAW.Entities
{
    [Serializable]
    public class AllLendings
    {

        public List<Lending> AllLending { get; set; }
        public string Name;

        public AllLendings()
        {
            AllLending = new List<Lending>();
        }

        public AllLendings(string name) : this()
        {
            this.Name = name;
        }

        public AllLendings(List <Lending> allLending)
        {
            AllLending = allLending;
        }
        
    }
}
