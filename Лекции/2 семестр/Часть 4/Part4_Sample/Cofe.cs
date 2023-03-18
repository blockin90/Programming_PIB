using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
      public class Cofe
    {
       public int CofeId { get; set; }  
        public string CofeName { get;set; }
        public string CofeCount { get; set; }
        public string CofeDescription { get; set; }
        public string CofeImage { get; set; }
        public virtual List<Dobavki> Dobavkis { get; set; }
        public Cofe()
        {
            Dobavkis= new List<Dobavki>();
        }
    }
}
