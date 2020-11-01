using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23_Homework_Task3
{
    /*Потрібно: Описати структуру з ім'ям Worker, що містить наступні поля:
   • прізвище та ініціали працівника; 
   • назва займаної посади;
   • рік надходження на роботу.
   Написати програму, що виконує наступні дії:
   • введення з клавіатури даних в масив, що складається з п'яти елементів типу Worker (записи повинні бути впорядковані за алфавітом);
   • якщо значення року введено не в відповідному форматі видає виняток.
   • вивід на екран прізвища працівника, стаж роботи який перевищує введене значення.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Worker companyWorker = new Worker();

            Worker[] workers = new Worker[1];
            for (int i = 0; i < workers.Length; i++)
            {
                try
                {
                    Console.WriteLine("Введіть прізвище та ініціали працівника:");
                    companyWorker.LastName = Console.ReadLine();

                    Console.WriteLine("Введіть посаду працівника:");
                    companyWorker.Post = Console.ReadLine();

                    Console.WriteLine("Вкажіть рік прийняття на роботу:");
                    string year = Console.ReadLine();

                    if (year == "" || year == null)
                    {
                        throw new Exception("Невірний формат строки!");
                    }
                    companyWorker.Year = Int32.Parse(year);

                    companyWorker.Experience = 2020 - companyWorker.Year;

                    workers[i] = companyWorker;
                }
                catch(InputFormatException e)
                {
                    Console.WriteLine($"{e.Message} - {e.property}");
                    throw;
                }
            }
            //Array.Sort<Worker>(workers);// чому не працює?
            //for (int i = 0; i < workers.Length; i++)
            //{
            //    Console.WriteLine(workers[i].ToString());
            //}


            Console.WriteLine("Введіть стаж працівника:");
            int inputExp = Int32.Parse(Console.ReadLine());
            if (companyWorker.Experience > inputExp )
            {
                companyWorker.WorkerInfo();
            }

            Console.ReadKey();
        }
    }
}
