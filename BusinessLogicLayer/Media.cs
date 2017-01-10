using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Media
    {
        public String Isbn { get; set; }
        public String MediaTitle { get; set; }
        public DateTime ReceiptDate { get; set; }
        public Boolean Purchased { get; set; }
        public Boolean Active { get; set; }
        public Boolean Donate { get; set; }
        public String Publisher { get; set; }

    }
}
