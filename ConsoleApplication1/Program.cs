using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                string value = "a";
                //Output to StdOutput variable
                Console.WriteLine("Value to convert:" + value);
                int i = int.Parse(value);
                return 0;
            }
            catch (Exception ex)
            {
                //Output to StdError variable
                Console.Error.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}
