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
    class Calculator
    {
        decimal firstNumber;
        decimal secondNumber;
        string operation;

        public decimal FirstNumber
        {
            get
            {
                return firstNumber;
            }
            set
            {
                firstNumber = value;
            }
        }
        public decimal SecondNumber
        {
            get
            {
                return secondNumber;
            }
            set
            {
                secondNumber = value;
            }
        }
        public string Operation
        {
            get
            {
                return operation;
            }
            set
            {
                operation = value;
            }
        }

        public void Add(decimal firstNumber, decimal secondNumber)
        {
            Console.WriteLine($"Результат після додавання: {firstNumber + secondNumber}");
        }
        public void Sub(decimal firstNumber, decimal secondNumber)
        {
            Console.WriteLine($"Результат після віднімання: {firstNumber - secondNumber}");
        }
        public void Mul(decimal firstNumber, decimal secondNumber)
        {
            Console.WriteLine($"Результат після множення: {firstNumber * secondNumber}");
        }
        public void Div(decimal firstNumber, decimal secondNumber)
        {
            if(secondNumber.Equals(0))
            {
                throw new ZeroException("Ділення на 0 неможливе.", nameof(secondNumber));
            }
            Console.WriteLine($"Результат після ділення:{firstNumber / secondNumber}");
        }



    }
}
