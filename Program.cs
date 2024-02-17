using System;
using BAM.Classes;
public class BankApp
{
    static void Main()
    {
        Bank bank = new Bank();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n1. Mijoz uchun hisob ochish");
            Console.WriteLine("2. Mijozning hisobini yopish");
            Console.WriteLine("3. Depozit qo'yish");
            Console.WriteLine("4. Pul yechish");
            Console.WriteLine("5. Balansni ko'rsatish");
            Console.WriteLine("6. Hisoblar o'rtasida pul o'tkazish");
            Console.WriteLine("7. Tranzaktsiyalardan keyin hisob balansini ko'rsatish");
            Console.WriteLine("8. Chiqish");
            Console.Write("\nTanlang (1-8): ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Mijoz ismi: ");
                    string name = Console.ReadLine();
                    Console.Write("Hisob raqami: ");
                    string accountNumber = Console.ReadLine();
                    bank.OpenAccount(name, accountNumber);
                    break;
                case "2":
                    Console.Write("Hisob raqami: ");
                    string closeAccountNumber = Console.ReadLine();
                    bank.CloseAccount(closeAccountNumber);
                    break;
                case "3":
                    Console.Write("Hisob raqami: ");
                    string depositAccountNumber = Console.ReadLine();
                    Console.Write("Depozit miqdori: ");
                    double depositAmount = double.Parse(Console.ReadLine());
                    bank.Deposit(depositAccountNumber, depositAmount);
                    break;
                case "4":
                    Console.Write("Hisob raqami: ");
                    string withdrawAccountNumber = Console.ReadLine();
                    Console.Write("Pul miqdori: ");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    bank.Withdraw(withdrawAccountNumber, withdrawAmount);
                    break;
                 case "5":
                    Console.Write("Hisob raqami: ");
                    string showBalanceAccountNumber2 = Console.ReadLine();
                    Console.WriteLine($"Balans: {bank.ShowBalance(showBalanceAccountNumber2)}$");
                    break;
                case "6":
                    Console.Write("Yuboruvchi hisob raqami: ");
                    string senderAccountNumber = Console.ReadLine();
                    Console.Write("Qabul qiluvchi hisob raqami: ");
                    string receiverAccountNumber = Console.ReadLine();
                    Console.Write("Pul miqdori: ");
                    double amount = double.Parse(Console.ReadLine());
                    bank.TransferMoney(senderAccountNumber, receiverAccountNumber, amount);
                    break;
                case "7":
                    Console.Write("Hisob raqami: ");
                    string showBalanceAccountNumber = Console.ReadLine();
                    Console.WriteLine($"Balans: {bank.ShowBalance(showBalanceAccountNumber)}$");
                    break;
                case "8":
                    exit = true;
                    Console.WriteLine("Dastur tugadi.");
                    break;
                default:
                    Console.WriteLine("Noto'g'ri tanlov! Qayta urinib ko'ring.");
                    break;
            }
        }
    }
}
