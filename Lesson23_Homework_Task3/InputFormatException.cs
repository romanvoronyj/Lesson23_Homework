using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23_Homework_Task3
{
    class InputFormatException: Exception
    {
        public string property;

        public InputFormatException(string message, string property)
            : base(message)
        {
            this.property = property;
        }

    }
}
