using System;
using System.Collections.Generic;
using System.Text;
using TTrendyol_new;

namespace Trendyol_new
{

    public class Customer:Person
    {
        public string CustomerNumber { get; set; }
        public string Type { get; set; }
        public string[] Bankaccount { get; set; }

    }
}

