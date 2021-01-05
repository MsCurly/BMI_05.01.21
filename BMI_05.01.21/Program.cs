//Züleyha ABAZİ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_05._01._21
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Lütfen kilonuzu kilogram cinsinden giriniz:");
                double kilo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Boyunuzu metre cinsinden giriniz: ");
                double boy = Convert.ToDouble(Console.ReadLine());
                double boyunKaresi = Math.Pow(boy, 2);
                double BMI = kilo / boyunKaresi;

                BMI = Math.Round(BMI, 2);
                if (kilo == 0 || boy == 0)
                {
                    Console.WriteLine("Kilonuz ya da boyunuz sıfır olamaz, lütfen geçerli bir sayı giriniz!");
                }
                else if (BMI < 18.5)
                {
                    Console.WriteLine($"Vucüt kitle indeksiniz {BMI} --> Normal kilonun altındasınız!");
                }
                else if (BMI >= 18.5 && BMI < 25)
                {
                    Console.WriteLine($"Vucüt kitle indeksiniz {BMI} --> Normal kilodasınız!");
                }
                else if (BMI >= 25 && BMI < 30)
                {
                    Console.WriteLine($"Vucüt kitle indeksiniz {BMI} --> Normal kilonun üzerindesiniz!");
                }
                else if (BMI >= 30 && BMI < 35)
                {
                    Console.WriteLine($"Vucüt kitle indeksiniz {BMI} --> I. sınıf obesitesiniz!");
                }
                else if (BMI >= 35 && BMI < 40)
                {
                    Console.WriteLine($"Vucüt kitle indeksiniz {BMI} --> II. sınıf obesitesiniz!");
                }
                else if (BMI >= 40)
                {
                    Console.WriteLine($"Vucüt kitle indeksiniz {BMI} --> III. sınıf obesitesiniz!");
                }


            }
            catch (FormatException format)
            {
                Console.WriteLine("Lütfen sadece sayısal değer giriniz!" + format);

            }

            Console.ReadLine();


        }
    }
}
