using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTest
{
    public class Banking
    {
        private readonly string m_customerName;
        private double m_amount;

        private Banking() { }

        public Banking(string customerName, double amount)
        {
            m_customerName = customerName;
            m_amount = amount;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance 
        {
            get { return m_amount; } 
        }

        public void Debit(double amount)
        {
            if (amount > m_amount)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_amount += amount; // intentionally incorrect code

            //correct cide is m_balance -= amount
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_amount += amount;
        }
    }
}
