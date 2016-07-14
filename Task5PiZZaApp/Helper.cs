using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task5PiZZaApp
{
   static class Helper
    {
       public static void WriteToFile(string name, string surname, int pieces)
        {
            File.AppendAllText("Pizza.log", name + " " + surname + " have taken " + pieces + " pieces \n");
        }
    }
}
