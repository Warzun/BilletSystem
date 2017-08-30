using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystem
{
   public class Bil
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public int pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }

    }
    
}
