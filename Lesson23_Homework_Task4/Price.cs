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


    struct Price
    {
        string productName;
        string storageName;
        decimal price;
        public string ProductName { get { return productName; } set { productName = value; } }
        public string StorageName { get { return storageName; } set { storageName = value; } }
        public decimal ProductPrice { get { return price; } set { price = value; } }

        public void ProductInfo()
        {
            Console.WriteLine($"Магазин: {storageName} Товар: {productName} Ціна: {price}"); 
        }
    }
}
