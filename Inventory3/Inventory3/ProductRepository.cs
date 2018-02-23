using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Inventory3
{
    public class ProductRepository
    {
        public ProductRepository(List<item> p)
        {
            p.Add(new item() { Name = "lettuce", Price = 10.5, Quantity = 50, Type = "Leafy green" });
            p.Add(new item() { Name = "cabbage", Price = 20, Quantity = 100, Type = "Cruciferous" });
            p.Add(new item() { Name = "pumpkin", Price = 30, Quantity = 30, Type = "Marrow" });
            p.Add(new item() { Name = "cauliflower", Price = 10, Quantity = 25, Type = "Cruciferous" });
            p.Add(new item() { Name = "zucchini", Price = 20.5, Quantity = 50, Type = "Marrow" });
            p.Add(new item() { Name = "yam", Price = 30, Quantity = 50, Type = "Root" });
            p.Add(new item() { Name = "spinach", Price = 10, Quantity = 100, Type = "Leafy green" });
            p.Add(new item() { Name = "broccoli", Price = 20.2, Quantity = 75, Type = "Cruciferous" });
            p.Add(new item() { Name = "Garlic", Price = 30, Quantity = 20, Type = "Leafy green" });
            p.Add(new item() { Name = "silverbeet", Price = 10, Quantity = 50, Type = "Marrow" });

        }

        public int total_ProductNumber(List<item> p)
        {
            return p.Count;

        }
        public List<item> add_NewProduct(List<item> p)
        {
            p.Add(new item() { Name = "Potato", Price = 10, Quantity = 50, Type = "Root" });
            return p;
        }

        public List<item> findProductByType(List<item> p,String ProductType)
        {
            List<item> p1 = new List<item>();
            foreach (var item in p)
            {
                if (item.Type.Equals(ProductType))
                    p1.Add(item);
            }
            return p1;
        }

        public List<item> deleteProduct(List<item> p,string ProductName)
        {
            p.RemoveAll(p1 => p1.Name.Equals(ProductName, StringComparison.OrdinalIgnoreCase));

            return p;
        }
        public double totalBoughtProduct(List<item> p, string Name, double Quan)
        {
            foreach (var item in p)
            {
                if (item.Name.Equals(Name))
                {
                    return (item.Price * Quan);
                }
            }
            return 0;
        }
    }
}
