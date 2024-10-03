using System;

namespace вар.задание_1
{
    // Класс "Банковский счет"
    public class BankAccount
    {
        // Поля класса
        private string accountNumber;  // Номер счета (уникальный идентификатор)
        private string owner;          // Владелец счета
        private decimal balance;       // Баланс счета
        // Конструктор для инициализации счета с номером, владельцем и начальным балансом
        public BankAccount(string accountNumber, string owner, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.owner = owner;
            balance = initialBalance;
        }
        // Свойства для получения значений полей
        public string AccountNumber
        {
            get { return accountNumber; }
        }
        public string Owner
        {
            get { return owner; }
            set { owner = value; } // Можно изменить владельца
        }
        public decimal Balance
        {
            get { return balance; }
        }
        // Метод для пополнения счета
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма депозита должна быть больше нуля.");
            }
            else
            {
                balance += amount;
                Console.WriteLine($"Пополнение счета на {amount}. Текущий баланс: {balance}");
            }
        }
        // Метод для снятия средств со счета
        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Недостаточно средств для снятия.");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Сумма для снятия должна быть больше нуля.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Снятие со счета {amount}. Текущий баланс: {balance}");
            }
        }
        // Метод для отображения информации о счете
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Номер счета: {accountNumber}");
            Console.WriteLine($"Владелец: {owner}");
            Console.WriteLine($"Баланс: {balance}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов класса "Банковский счет"
            BankAccount account1 = new BankAccount("1234567890", "Иван Иванов", 1000);
            BankAccount account2 = new BankAccount("0987654321", "Мария Петрова", 500);
            // Тестирование функциональности счета
            account1.DisplayAccountInfo();
            account1.Deposit(500);  // Пополнение счета
            account1.Withdraw(200); // Снятие средств
            Console.WriteLine();
            account2.DisplayAccountInfo();
            account2.Deposit(300);  // Пополнение счета
            account2.Withdraw(800); // Попытка снять больше, чем есть на счете
            Console.ReadLine();
        }
    }
}