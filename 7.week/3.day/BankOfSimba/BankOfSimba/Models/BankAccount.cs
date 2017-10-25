
namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AnimalType { get; set; }
        public string Currency = "Zebra";

        public BankAccount(string name, double balance, string type)
        {
            this.Name = name;
            this.Balance = balance;
            this.AnimalType = type;
        }
    }
}
