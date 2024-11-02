using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V44DataB
{
    public static class InputHelper
    {
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"{prompt}: ");
            return Console.ReadLine();
        }
    }
}
