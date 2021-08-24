using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesUI
{
    public class CurrencyConverter
    {
        //Here we define a delegate which determines the shape or the signature of the method in the subsciber
        public delegate void CurrencyConvertedEventHandler(object source, EventArgs args);

        //Second we created event based on the delegate name
        public event CurrencyConvertedEventHandler CurrencyConverted; 
        public void ConvertToEuros(Customer customer)
        {
            if (customer.Amount > 10000)
            {
                OnCurrencyConverted();
            }

            else
            {
                double initialAmount = customer.Amount;
                double eurReturn;
                double eurValue = 0.85155;

                eurReturn = initialAmount * eurValue;
                Console.WriteLine("{0} USD = {1} EUR", initialAmount, eurReturn);
            }            
        }

        public void ConvertToDollars(Customer customer)
        {
            if (customer.Amount > 10000)
            {
                OnCurrencyConverted();
            }

            else
            {
                double initialAmount = customer.Amount;
                double usdReturn;
                double usdValue = 1.17440;

                usdReturn = initialAmount * usdValue;
                Console.WriteLine("{0} EUR = {1} USD", initialAmount, usdReturn);
            }
        }

        protected virtual void OnCurrencyConverted()
        {
            CurrencyConverted?.Invoke(this, EventArgs.Empty);
        }
    }
}
