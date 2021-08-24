using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyConverterLibrary
{
    public class ReportService
    {
        public void OnCurrencyConverted(object source, EventArgs e)
        {
            Console.WriteLine("Report service: Sending an report...");
        }
    }
}
