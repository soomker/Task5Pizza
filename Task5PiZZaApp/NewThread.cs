using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task5PiZZaApp
{
    class NewThread
    {
        private Engineer engn;
        private int count;
        public Thread thr;

        public NewThread(Engineer eng, ref int pizzaCount)
        {
            engn = eng;
            count = pizzaCount;
            thr = new Thread(Run);
            thr.Start();
        }

        private void Run()
        {
            engn.GetPizza(ref count);
        }
    }
}
