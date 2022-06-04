using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol_new
{
    class Order
    {
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public int EmployerId { get; set; }
        public int ProductId { get; set; }
        public decimal Cost { get; set; }
    }
}
