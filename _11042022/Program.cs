using System;

namespace _11042022
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();
            Order order2 = new Order();
            Order order3 = new Order();
            Order order4 = new Order();
            order1.TotalAmount = 12;
            order2.TotalAmount = 24;
            order3.TotalAmount = 64;
            order4.TotalAmount = 68;
            
            Shop shop = new Shop();
            shop.AddOrder(order1);
            shop.AddOrder(order2);
            shop.AddOrder(order3);
            shop.AddOrder(order4);
            
            Console.WriteLine(shop.GetOrdersAvg());
            shop.RemoveOrderByNo(3);
            foreach (var item in shop.Orders)
            {
                Console.WriteLine(item.No);
            }

        }
    }
}
