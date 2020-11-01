using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23_Homework
{
    /*Створіть клас Calculator.
    У тілі класу створіть чотири методи для арифметичних дій: (Add - додавання, Sub - віднімання, Mul - множення, Div - розподіл).
    Метод поділу повинен робити перевірку ділення на нуль, якщо перевірка не проходить, згенерувати виняток.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Calculator myCalculator = new Calculator();

            Console.WriteLine("Введіть перше число:");
            myCalculator.FirstNumber = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            myCalculator.SecondNumber = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Введіть знак операції:");
            myCalculator.Operation = Console.ReadLine();

            while(true)
            {
                try
                {

                    switch (myCalculator.Operation)
                    {
                        case "+":
                            {
                                myCalculator.Add(myCalculator.FirstNumber, myCalculator.SecondNumber);
                                break;
                            }
                        case "-":
                            {
                                myCalculator.Sub(myCalculator.FirstNumber, myCalculator.SecondNumber);
                                break;
                            }
                        case "*":
                            {
                                myCalculator.Mul(myCalculator.FirstNumber, myCalculator.SecondNumber);
                                break;
                            }
                        case "/":
                            {
                                myCalculator.Div(myCalculator.FirstNumber, myCalculator.SecondNumber);
                                break;
                            }

                        default:
                            {
                                throw new OperatorException($"Введеного знака не існує!", nameof(myCalculator.Operation));
                            }
                    }
                    break;
                }
                catch (OperatorException e)
                {
                    Console.WriteLine($"{e.Message} - {e.property}");
                    throw;
                }

            }

        }
    }
}
