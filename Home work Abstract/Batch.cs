using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_Abstract
{
    public class Batch : Product
    {
        public int Quantity { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Название: {Name}, Цена: {Price}, Количество: {Quantity}, Дата производства: {ProductionDate}, Срок годности: {ExpiryDate}");
        }

        public override bool IsExpired()
        {
            return DateTime.Now > ExpiryDate;
        }
    }
}
