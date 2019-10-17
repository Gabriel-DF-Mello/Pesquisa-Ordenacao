using System;
using System.Collections;
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
        private ArrayList messages;
        int[] template, v, ordered_v;
        
        void update_Ordenar(bool file)
        {
            if(file == true)
            {

                foreach (Control c in panelSorting.Controls)
                {
                    if (c is CheckBox)
                        c.Enabled = true;
                }
            }
            else
            {
                foreach (Control c in panelSorting.Controls)
                {
                    if (c is CheckBox)
                        c.Enabled = false;
                }
            }
        }

        void update_Pesquisa(bool file, bool ordered)
        {
            if(file == false)
            {
                foreach (Control c in panelPesquisa.Controls)
                {
                    if (c is CheckBox)
                        c.Enabled = false;
                }
            }

            if((file == true) && (ordered == false))
            {
                checkBoxBinarySearch.Enabled = false;
                checkBoxSequentialSearch.Enabled = true;
                checkBoxSequentialOrdered.Enabled = false;
            }
            else if ((file == true) && (ordered == true))
            {
                checkBoxBinarySearch.Enabled = true;
                checkBoxSequentialSearch.Enabled = true;
                checkBoxSequentialOrdered.Enabled = true;
            }
        }

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
                result = Ordenador.SelectionSort(v);
                v.CopyTo(ordered_v, 0);
                update_Pesquisa(true, true);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }
            if (checkBoxInsertion.Checked)
            {
                result = Ordenador.InsertionSort(v);
                v.CopyTo(ordered_v, 0);
                update_Pesquisa(true, true);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }
            if (checkBoxBubble.Checked)
            {
                result = Ordenador.BubbleSort(v);
                v.CopyTo(ordered_v, 0);
                update_Pesquisa(true, true);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }
            if (checkBoxCocktail.Checked)
            {
                result = Ordenador.CocktailSort(v);
                v.CopyTo(ordered_v, 0);
                update_Pesquisa(true, true);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }
            if (checkBoxComb.Checked)
            {
                result = Ordenador.CombSort(v);
                v.CopyTo(ordered_v, 0);
                update_Pesquisa(true, true);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }
            if (checkBoxShell.Checked)
            {
                result = Ordenador.ShellSort(v);
                v.CopyTo(ordered_v, 0);
                update_Pesquisa(true, true);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }

            if (checkBoxMerge.Checked)
            {
                result = Ordenador.DisplayMergeSort(v,0,v.Length-1);
                v.CopyTo(ordered_v, 0);
                update_Pesquisa(true, true);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }

            if (checkBoxQuick.Checked)
            {
                //result = Selecionador.DisplayMergeSort(v,0,v.Length-1);
                //v.CopyTo(ordered_v, 0);
                //ordered = true;
                //template.CopyTo(v, 0);
                //listResults.AppendText(result);
            }

            if (checkBoxHeap.Checked)
            {
                result = Ordenador.HeapSort(v);
                v.CopyTo(ordered_v, 0);
                update_Pesquisa(true, true);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }

            if (checkBoxBucket.Checked)
            {
                result = Ordenador.BucketSort(v, 1000000);
                v.CopyTo(ordered_v, 0);
                update_Pesquisa(true, true);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }

            if (checkBoxRadix.Checked)
            {
                result = Ordenador.RadixSort(v, 7);
                v.CopyTo(ordered_v, 0);
                update_Pesquisa(true, true);
                template.CopyTo(v, 0);
                listResults.AppendText(result);
            }
        }

        [STAThread]
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            template = Gerador.Ler();
            v = new int[template.Length];
            ordered_v = new int[template.Length];

            template.CopyTo(v, 0);
            labelCurrentFile.Text = "Qnt: " + template.Length;
            update_Ordenar(true);
            update_Pesquisa(true, false);
        }

        [STAThread]
        private void btnNewFile_Click(object sender, EventArgs e)
        {
            Gerador.Gerar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (checkBoxSequentialSearch.Checked)
            {
                
            }

            if (checkBoxBinarySearch.Checked)
            {

            }
        }
    }
}
