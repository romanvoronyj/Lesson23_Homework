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
    struct Worker
    {
        string lastName;
        string post;
        int year;
        int experience;

        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Post { get { return post; } set { post = value; } }
        public int Year { get { return year; } set { year = value; } }
        public int Experience { get { return experience; } set { experience = value; } }

        public void WorkerInfo()
        {
            Console.WriteLine($"П.І.Б.:{LastName}\nПосада:{Post}\nПочаток кар'єри:{Year}");
        }
    }
}
