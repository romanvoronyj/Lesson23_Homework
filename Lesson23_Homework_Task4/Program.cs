using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;         

namespace Lesson23_Homework_Task4
{
    /*Потрібно: Описати структуру з ім'ям Price, що містить наступні поля:
   • назва товару;
   • назва магазину, в якому продається товар;
   • вартість товару в гривнях.
   Написати програму, що виконує наступні дії:
   • введення з клавіатури даних в масив, що складається з двох елементів типу Price (записи повинні бути впорядковані в алфавітному порядку за назвами магазинів);
   • вивід на екран інформації про товари, що продаються в магазині, назва якого введено з клавіатури (якщо такого магазину немає, вивести виняток).
   */

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Price price = new Price();

            Price[] prices = new Price[2];
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine("Введіть назву магазину:");
                price.StorageName = Console.ReadLine();

                Console.WriteLine("Введіть назву товару:");
                price.ProductName = Console.ReadLine();

                Console.WriteLine("Введіть ціну товару:");
                price.ProductPrice = decimal.Parse(Console.ReadLine());

                prices[i] = price;

                Console.WriteLine(new string('-',20));
            }

            Console.WriteLine();

            //Array.Sort<Price>(prices);// чому не працює?
            //for (int i = 0; i < prices.Length; i++)
            //{
            //    Console.WriteLine(prices[i].ToString());
            //}

            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Введіть назву магазину: ");
            string customerShop = Console.ReadLine();

            if (customerShop == price.StorageName)
            {
                price.ProductInfo();
            }
            else
            {
                throw new Exception("Введеного магазину не існує.");
            }

            Console.ReadKey();
        }
    }
}
