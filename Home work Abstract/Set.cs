using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_Abstract
{
    public class Set : Product
    {
        public List<Product> Products { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Название: {Name}, Цена: {Price}");
            foreach (var product in Products)
            {
                product.PrintInfo();
            }
        }

        public override bool IsExpired()
        {
            return Products.Any(p => p.IsExpired());
        }
    }
}
