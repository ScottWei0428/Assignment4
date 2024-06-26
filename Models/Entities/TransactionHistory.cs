﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class TransactionHistory
    {
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }


        public virtual TransactionHistory Account { get; set; }
    }
}
