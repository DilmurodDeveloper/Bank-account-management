using System.Collections.Generic;
namespace BAM.Classes
{
    public class Bank
    {
        private List<Customer> customers = new List<Customer>();
        private Dictionary<string, BankAccount> accounts = new Dictionary<string, BankAccount>();

        public void OpenAccount(string name, string accountNumber)
        {
            Customer customer = new Customer { Name = name, AccountNumber = accountNumber };
            customers.Add(customer);
            BankAccount account = new BankAccount();
            accounts.Add(accountNumber, account);
            Console.WriteLine($"{name} uchun hisob ochildi. Hisob raqami: {accountNumber}");
        }

        public void CloseAccount(string accountNumber)
        {
            Customer customer = customers.Find(c => c.AccountNumber == accountNumber);
            if (customer != null)
            {
                customers.Remove(customer);
                accounts.Remove(accountNumber);
                Console.WriteLine($"{customer.Name}ning hisobi yopildi.");
            }
            else
            {
                Console.WriteLine("Hisob topilmadi!");
            }
        }

        public void TransferMoney(string senderAccountNumber, string receiverAccountNumber, double amount)
        {
            if (accounts.ContainsKey(senderAccountNumber) && accounts.ContainsKey(receiverAccountNumber))
            {
                BankAccount senderAccount = accounts[senderAccountNumber];
                BankAccount receiverAccount = accounts[receiverAccountNumber];

                if (senderAccountNumber != receiverAccountNumber)
                {
                    senderAccount.Withdraw(amount);
                    receiverAccount.Deposit(amount);

                    Console.WriteLine($"{amount}$ {senderAccountNumber} hisobidan {receiverAccountNumber} hisobiga o'tkazildi.");
                }
                else
                {
                    Console.WriteLine("Yuboruvchining hisob raqami foydalanuvchi hisob raqami bilan bir xil.");
                }
            }
            else
            {
                Console.WriteLine("Noto'g'ri amal! Pul yetarli emas!");
            }
        }
        public void Deposit(string accountNumber, double amount)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                BankAccount account = accounts[accountNumber];
                account.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Hisob raqami topilmadi!");
            }
        }

        public void Withdraw(string accountNumber, double amount)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                BankAccount account = accounts[accountNumber];
                account.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Hisob raqami topilmadi!");
            }
        }
        public double ShowBalance(string accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                BankAccount account = accounts[accountNumber];
                return account.Balance;
            }
            else
            {
                Console.WriteLine("Hisob raqami topilmadi!");
                return 0;
            }
        }
    }
}