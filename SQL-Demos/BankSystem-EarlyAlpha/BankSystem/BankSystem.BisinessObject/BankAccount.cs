using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.BisinessObject
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string Statuse { get; set; }
        public string Iban { get; set; }
        public decimal SumTotal { get; set; }
        public bool IsItPaying { get; set; }
        public Client Client { get; set; }
    }
}
