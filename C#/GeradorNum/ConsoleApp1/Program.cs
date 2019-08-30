using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeradorNum;

namespace GeradorNum
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            int[] v,vO;
            Gerador.Gerar();
            v = Gerador.Ler();
            vO = new int[v.Length];

            v.CopyTo(vO, 0);

            Selecionador.CombSort(vO);
            Console.ReadLine();


            /*foreach (int ele in vO)
            {
                Console.WriteLine(ele);
            }
            Console.ReadLine();*/

        }
    }
}
