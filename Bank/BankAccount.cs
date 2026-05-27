using System;

namespace BankAccountNS
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class BankAccount
    {

        private readonly string m_customerName;
        private double m_balance;

        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";
        
        /// <summary>
        /// Закрытый конструктор по умолчанию
        /// </summary>
        private BankAccount() { }

        /// <summary>
        /// Конструктор банковского счета
        /// </summary>
        /// <param name="customerName">Имя владельца счета</param>
        /// <param name="balance">Начальный баланс счета</param>
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        /// <summary>
        /// Получает имя владельца счета
        /// </summary>
        public string CustomerName
        {
            get { return m_customerName; }
        }

        /// <summary>
        /// Получает текущий баланс счета
        /// </summary>
        public double Balance
        {
            get { return m_balance; }
        }

        /// <summary>
        /// Снимает указанную сумму со счета
        /// </summary>
        /// <param name="amount">Сумма, снимаемая со счета</param>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если сумма больше баланса или отрицательна</exception>
        public void Debit(double amount)
        {
            if (amount > m_balance)
{
                throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }
            if (amount < 0)
{
                throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }
            m_balance -= amount;
        }

        /// <summary>
        /// Пополняет счет на указанную сумму
        /// </summary>
        /// <param name="amount">Сумма пополнения счета</param>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если сумма отрицательна</exception>
        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance += amount;
        }

        /// <summary>
        /// Главный метод для демонстрации работы банковского счета
        /// </summary>
        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Roman Abramovich", 11.99);
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
            Console.ReadLine();
        }
    }
}