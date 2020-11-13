using System;

namespace classes
{
    class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        public int AccountNumber { get; }
        public string OwnerName { get; set; }
        public decimal Balance { get; }

        public BankAccount(string name, decimal initialBalance)
        {
            this.OwnerName = name;
            this.Balance = initialBalance;
            this.AccountNumber = accountNumberSeed;
            accountNumberSeed++;
        }


        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }
        public void Withdrawl(decimal amount, DateTime date, string note)
        {

        }
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Dhurba", 1000);
            Console.WriteLine($"Account {account.AccountNumber} belongs to {account.OwnerName} with initial balance {account.Balance}");
        }
    }
}
