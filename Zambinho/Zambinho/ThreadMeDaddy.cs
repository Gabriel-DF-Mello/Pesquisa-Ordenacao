using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zambinho
{
    class ThreadMeDaddy
    {
        // cria um semaforo inicialmente bloqueado (0)
        static SemaphoreSlim semaphore = new SemaphoreSlim(0);

        ListBox list;
        public ThreadMeDaddy(ListBox l)
        {
            this.list = l;
        }
        class Params
        {
            public ListBox l;
        }

        public void Execute(Object obj)
        {
            ListBox localList = ((Params)obj).l;

            semaphore.Wait();

            for (int i = 0; i < 100; i++)
            {
                localList.Invoke(new Action(() => localList.Items.Add(i)));
            }
        }

        public void Run()
        {
            Thread t = new Thread(Execute);
            t.Start(new Params() { l = list });
        }

        internal void Libera()
        {
            semaphore.Release();
        }
    }
}
