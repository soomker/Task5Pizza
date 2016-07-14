using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Task5PiZZaApp
{
    class Engineer
    {
        public string Name { get; private set; }
        public string Surname { get; private set;}

        private object lockObj = new object();
        private Random rnd;

        public Engineer(string name, string surname)
        {
            Name = name;
            Surname = surname;
            rnd = new Random();
        }

        public void GetPizza(ref int numOfPieces)
        {
            int piecesOfPizza = rnd.Next(1,3);
           
            Console.WriteLine("I'm " + Name + " " + Surname + " and I took " + piecesOfPizza + " pieces");
          lock(lockObj)
            {
               Helper.WriteToFile(Name, Surname, piecesOfPizza);
            }

            numOfPieces = numOfPieces - piecesOfPizza;
            
        }

       
    }
}
