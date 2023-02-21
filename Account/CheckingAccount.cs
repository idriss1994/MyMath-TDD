namespace Accounts
{
    public class CheckingAccount : IAccount
    {
        private double m_balance;

        public CheckingAccount(double balance)
        {
            m_balance = balance;
        }
        public void Withdraw(double amount)
        {
            if (m_balance >= amount)
            {
                m_balance -= amount;
            }
            else
            {
                throw new ArgumentException("Withdraw exceeds balance!.", nameof(amount));
            }
        }
    }
}