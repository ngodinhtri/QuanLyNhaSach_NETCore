using System;
using System.Collections.Generic;
using System.Text;

namespace ModelDatabase.EF
{
    public class Customer
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime dateTime { get; set; }
        public List<Bill> Bills { set; get; }
    }
}
