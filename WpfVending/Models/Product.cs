using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVending.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<string> Allergens { get; set; }

        public string Url { get; set; }
        public Product(int productID, string name, string description, double price, List<string> allergens, string url)
        {
            ProductID = productID;
            Name = name;
            Description = description;
            Price = price;
            Allergens = allergens;
            Url = url;
        }
    }
}
