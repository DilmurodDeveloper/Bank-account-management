namespace BAM.Classes //BAM - Bank account management
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Depozit qo'yildi: +{amount}$");
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Pul yechib olingan: -{amount}$");
            }
            else
            {
                Console.WriteLine("Noto'g'ri amal! Balans yetarli emas!");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Hisob raqami: {AccountNumber}, Balans: {Balance}$");
        }
    }
}