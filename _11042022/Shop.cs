using System;
using System.Collections.Generic;
using System.Text;

namespace _11042022
{
    class Shop
    {
        public List<Order> Orders = new List<Order>();
        public void AddOrder(Order order)
        {
            if (!Orders.Exists(x => x.No == order.No))
                Orders.Add(order);
        }
        public double GetOrdersAvg()
        {
            double sum = 0;
            foreach (var item in Orders)
            {
                sum += item.TotalAmount;
            }
            return sum / Orders.Count;
        }

        public double GetOrdersAvg(DateTime dateTime)
        {
            List<Order> orders = Orders.FindAll(x => x.CreatedAt > dateTime);
            double sum = 0;
            foreach (var item in orders)
            {
                sum += item.TotalAmount;
            }
            return sum / orders.Count;
        }
        public void RemoveOrderByNo(int no)
        {
            Orders.Remove(Orders.Find(x => x.No == no));
        }
        public List<Order> FilterOrderByPrice(double max, double min)
        {
            List<Order> filteredOrders = Orders.FindAll(x => x.TotalAmount > min && x.TotalAmount < max);
            return filteredOrders;
        }

    }
}
