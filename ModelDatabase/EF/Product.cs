using System;
using System.Collections.Generic;
using System.Text;

namespace ModelDatabase.EF
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Quantiy { get; set; }
        public double Price { get; set; }
        public virtual Category category { set; get; }
        public string CategoryID { get; set; }
        public DateTime dateTime { get; set; }
        public List<BillItem>  billItems { set; get; }
    }
}
