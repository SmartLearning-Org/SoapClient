using ServiceReference1;
using System;

namespace SoapClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new CurrencyServiceClient();

            Amount val = new();
            val.Value = 15;
            val.Currency = "USD";

            Amount result = client.ConvertToDkkAsync(val).Result.Body.ConvertToDkkResult;
            Console.WriteLine($"{result.Value} {result.Currency}");
        }
    }
}
