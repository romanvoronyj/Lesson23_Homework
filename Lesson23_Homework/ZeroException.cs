using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23_Homework
{
    class ZeroException: Exception
    {
        public string property;

        public ZeroException(string message, string property)
            : base(message)
        {
            this.property = property;
        }

    }
}
