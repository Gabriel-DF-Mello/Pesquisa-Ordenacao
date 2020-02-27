using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zambinho
{
    public partial class Form1 : Form
    {
        ThreadMeDaddy d1;
        ThreadMeDaddy d2;
        ThreadMeDaddy d3;

        public Form1()
        {
            InitializeComponent();
            d1 = new ThreadMeDaddy(listBox1);
            d2 = new ThreadMeDaddy(listBox2);
            d3 = new ThreadMeDaddy(listBox3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            d1.Run();
            d2.Run();
            d3.Run();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d1?.Libera();

        }
    }
}
