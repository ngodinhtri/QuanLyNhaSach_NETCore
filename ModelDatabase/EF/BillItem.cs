using System;
using System.Collections.Generic;
using System.Text;

namespace ModelDatabase.EF
{
    public class BillItem
    {
        public string ID { set; get; }
        public Bill Bill { set; get; }
        public string BillID { set; get; }
        public Product Product { set; get; }
        public string ProductID { set; get; }
        public int Quanity { set; get; }
    }
}
