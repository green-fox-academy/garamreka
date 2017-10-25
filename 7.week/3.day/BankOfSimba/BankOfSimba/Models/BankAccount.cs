﻿using BankOfSimba.Controllers;
using System.Collections.Generic;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AnimalType { get; set; }

        public string Currency = "Zebra";
        public List<BankAccount> clients = new List<BankAccount>();
        public bool IsKing;

        public BankAccount(string name, double balance, string type, bool isKing)
        {
            this.Name = name;
            this.Balance = balance;
            this.AnimalType = type;
            this.IsKing = isKing;
        }

        public BankAccount()
        {
        }
    }
}