using System;
using System.Collections.Generic;
using System.Text;

namespace _11042022
{
    class Order
    {
        public Order()
        {
            _totalCount++;
            No = _totalCount;
        }
        static int _totalCount;
        public int No { get; }
        public int ProductCount { get; set; }
        public int TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }


    }
}
