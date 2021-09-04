using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.BisinessObject
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string FamilyName { get; set; }
        public DateTime YearOfBirth { get; set; }
    }
}
