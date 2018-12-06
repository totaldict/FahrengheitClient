using Client777.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client777
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как переводить?\n1.Фаренгейты в Цельсия\n2.Цельсия в Фаренгейты");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                ConversionServiceClient con = new ConversionServiceClient();
                Console.WriteLine("Градусов Фаренгейта: ");
                double f = double.Parse(Console.ReadLine());
                double convert = (double)con.FahrenheitToCelsius(f);
                Console.WriteLine($"Это {convert} градусов Цельсия."); 
            }
            if (n == 2)
            {
                ConversionServiceClient con = new ConversionServiceClient();
                Console.WriteLine("Градусов Цельсия: ");
                double f = double.Parse(Console.ReadLine());
                double convert = (double)con.CelsiusToFahrenheit(f);
                Console.WriteLine($"Это {convert} градусов Фаренгейта.");
            }

        }
    }
}
