using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
     public class Dobavki
    {
        public  int DobavkiId { get; set; }
        public string DobavkiName { get;set; }
        public decimal DobavkiPrice { get; set;}
        public int CofeId { get; set; }
        public virtual Cofe Cofe { get; set; }
    }
}
