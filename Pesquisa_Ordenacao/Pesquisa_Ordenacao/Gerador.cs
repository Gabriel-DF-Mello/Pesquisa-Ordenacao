using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pesquisa_Ordenacao
{
    static class Gerador
    {
        [STAThread]
        static public void Gerar()
        {
            int qtd = 0;
            string[] lines;
            Random rng = new Random();
            bool next = true;
            while (next)
            {
                try
                {
                    string input = Interaction.InputBox("Quantos números devem ser gerados?", "Quantidade", "Default", -1, -1);
                    qtd = Convert.ToInt32(input);
                    next = false;
                }
                catch (FormatException)
                {}
            }

            lines = new string[qtd];
            for (int i = 0; i < qtd; i += 1)
            {
                int n = rng.Next(1000000);
                lines[i] = n.ToString();
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "arquivo de texto (*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Path.GetFullPath(dialog.FileName);
            }
            string path = dialog.FileName;
            System.IO.File.WriteAllLines(path, lines);
        }


        [STAThread]
        static public int[] Ler()
        {
            int[] nums;
            int i = 0;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "arquivo de texto (*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Path.GetFullPath(dialog.FileName);
            }
            string path = dialog.FileName;

            string[] lines = File.ReadAllLines(path);
            nums = new int[lines.Length];
            foreach (string line in lines)
            {
                nums[i] = Int32.Parse(line);
                i += 1;
            }
            return nums;
        }
    }
}
