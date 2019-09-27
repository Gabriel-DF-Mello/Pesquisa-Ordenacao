using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pesquisa_Ordenacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            listResults.Clear();

            string result;
            if (checkBoxSelection.Checked)
            {
                result = Selecionador.SelectionSort(v);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }
            if (checkBoxInsertion.Checked)
            {
                result = Selecionador.InsertionSort(v);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }
            if (checkBoxBubble.Checked)
            {
                result = Selecionador.BubbleSort(v);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }
            if (checkBoxCocktail.Checked)
            {
                result = Selecionador.CocktailSort(v);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }
            if (checkBoxComb.Checked)
            {
                result = Selecionador.CombSort(v);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }
            if (checkBoxShell.Checked)
            {
                result = Selecionador.ShellSort(v);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }

            if (checkBoxMerge.Checked)
            {
                result = Selecionador.DisplayMergeSort(v,0,v.Length-1);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }

            if (checkBoxQuick.Checked)
            {
                //result = Selecionador.DisplayMergeSort(v,0,v.Length-1);
                //template.CopyTo(v, 0);
                //listResults.AppendText(result);
            }

            if (checkBoxHeap.Checked)
            {
                result = Selecionador.HeapSort(v);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }

            if (checkBoxBucket.Checked)
            {
                //result = Selecionador.DisplayMergeSort(v, 0, v.Length - 1);
                //template.CopyTo(v, 0);
                //listResults.AppendText(result);
            }

            if (checkBoxRadix.Checked)
            {
                //result = Selecionador.DisplayMergeSort(v, 0, v.Length - 1);
                //template.CopyTo(v, 0);
                //listResults.AppendText(result);
            }
        }

        [STAThread]
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            template = Gerador.Ler();
            v = new int[template.Length];

            template.CopyTo(v, 0);
            labelCurrentFile.Text = "Qnt: " + template.Length;
        }

        [STAThread]
        private void btnNewFile_Click(object sender, EventArgs e)
        {
            Gerador.Gerar();
        }
    }
}
