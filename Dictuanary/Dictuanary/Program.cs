using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictuanary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, string>();
            dict.Add(2, "I can do it,");
            dict.Add(5, "of course I can");
            var key = new List<string>(dict.Values);
            foreach (string num in key)
            {
                Console.WriteLine(num);
            }
        }
    }
}
