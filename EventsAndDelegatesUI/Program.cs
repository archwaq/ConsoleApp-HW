using AviationLibrary;
using CurrencyConverterLibrary;
using System;

//  Домашно:​
//  Напишете клас, който да може да превръща долари в евро и обратното.
//  Нека всеки път когато някой иска да превърне сума по-голяма от 10 000 (долара или евро) да се „задейства“ събитие,
//  което да информира всички, които са се абонирали за него.​

//  Направете базов клас – самолет и два класа наследници – боен и пътнически.
//  Нека самолетите всеки самолет да има две полета – текуща скорост и текуща височина.
//  Пътническият има още брой пътници, докато бойният има брой ракети.
//  Създайте две  събития – едното да се „задейства“ при в достигане на определена височина, другото при достигане на определена скорост.
//  Може ли да направите различните самолети задействат събитията при различни скорост и височина? Ако да – направете го .​

namespace EventsAndDelegatesUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer() { Amount = 7663.95 };
            var currencyConverter = new CurrencyConverter();
            var reportService = new ReportService();

            currencyConverter.CurrencyConverted += reportService.OnCurrencyConverted;

            currencyConverter.ConvertToEuros(customer);
            currencyConverter.ConvertToDollars(customer);

            Console.WriteLine();

            var fighterJet = new FighterJet() { Speed = 0, Altitude = 0 };

            var touristJet = new TouristJet() { Speed = 4000, Altitude = 2000 };

            var certainSpeed = new CertainSpeed();
            var certainAltitude = new CertainAltitude();
            var airspeedIndicator = new AirspeedIndicator();
            var altimeterIndicator = new AltimeterIndicator();


            certainSpeed.SpeedReached += airspeedIndicator.OnSpeedReached;
            certainAltitude.AltitudeReached += altimeterIndicator.OnAltitudeReached;

            certainSpeed.SpeedProcessor(fighterJet);
            certainAltitude.AltitudeProcessor(fighterJet);

            Console.WriteLine();

            certainSpeed.SpeedProcessor(touristJet);
            certainAltitude.AltitudeProcessor(touristJet);
        }
    }
}
