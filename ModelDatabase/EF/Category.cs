using System;
using System.Collections.Generic;
using System.Text;

namespace ModelDatabase.EF
{
    public class Category
    {
        public string CategoryId { set; get; }
        public string Name { set; get; }
        public string Image { set; get; }
        public DateTime dateTime { set; get; }
        public List<Product> products { set; get; }
    }
}
