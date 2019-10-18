using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            boxTexto.SelectionStart = 0;
            boxTexto.SelectionLength = boxTexto.Text.Length;
            boxTexto.SelectionBackColor = Color.White;
            boxTexto.SelectionColor = Color.Black;

            string search = textBoxPesquisa.Text.ToLower();
            string text = boxTexto.Text;
            text = text.ToLower();
            List<int> indexes = new List<int>();

            if ((text.Contains(search)) && (text.Length > 0))
            {
                for (int i = 0; (i != -1)&&(i < text.Length);)
                {
                    i = text.IndexOf(search, i);
                    if (i == -1)
                    {
                        continue;
                    }
                    boxTexto.SelectionStart = i;
                    boxTexto.SelectionLength = search.Length;
                    boxTexto.SelectionColor = Color.White;
                    boxTexto.SelectionBackColor = Color.Crimson;
                    i += 1;
                }
            }
        }
    }
}
