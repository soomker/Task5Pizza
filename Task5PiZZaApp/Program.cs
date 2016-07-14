using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task5PiZZaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Engineer eng1 = new Engineer("Tirion", "Lanister");
            Engineer eng2 = new Engineer("Jhon", "Snow");
            Engineer eng3 = new Engineer("Aria", "Stark");

            int pizzaC = 12;
            if (File.Exists("Pizza.log")) File.Delete("Pizza.log");
            //eng1.GetPizza(ref pizzaC);
            //eng2.GetPizza(ref pizzaC);
            //eng3.GetPizza(ref pizzaC);

            NewThread thr1 = new NewThread(eng1, ref pizzaC);
            NewThread thr2 = new NewThread(eng2, ref pizzaC);
            NewThread thr3 = new NewThread(eng3, ref pizzaC);

            Console.ReadLine();
        }
    }
}
