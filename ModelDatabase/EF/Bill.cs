using System;
using System.Collections.Generic;
using System.Text;

namespace ModelDatabase.EF
{
    public class Bill
    {
        public string ID { set; get; }
        public virtual Customer Customer { set; get; }
        public string CustomerID { set; get; }
        public DateTime dateTime  { set; get; }
        public double Total { set; get; }
        public List<BillItem> billItems { set; get; }
    }
}
