using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplos_de_ejercicios
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum= 1;
            progressBar1.Maximum= 100;
            progressBar1.Step= 2;

            for (int x=0; x<100; x++) 
            {
                progressBar1.PerformStep();
            }
        }
    }
}
