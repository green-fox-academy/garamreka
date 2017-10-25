
namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public string AnimalType { get; set; }

        public BankAccount(string name, int balance, string type)
        {
            this.Name = name;
            this.Balance = balance;
            this.AnimalType = type;
        }
    }
}
