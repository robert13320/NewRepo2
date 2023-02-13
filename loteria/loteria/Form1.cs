using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random numerosaleatorios= new Random();


        private void btnJuega_Click(object sender, EventArgs e)
        {
           int primera;
            int segunda;
            int tercera;
            int numero;

            primera = numerosaleatorios.Next(0, 99);
            segunda = numerosaleatorios.Next(0, 99);
            tercera = numerosaleatorios.Next(0, 99);


            numero = Convert.ToInt32(txtJugarnumero.Text);

            txtPrimera.Text = primera.ToString();
            txtSegunda.Text = segunda.ToString();
            txtTercera.Text = tercera.ToString();

            if (numero == primera)
            {
                lblResultado.Text = "te sacaste en primera";
            }
            else if (numero == segunda) 
            {
                lblResultado.Text = "te sacaste en segunda";
            }
            else if (numero == tercera) 
            {
                lblResultado.Text = "te sacaste en tercera";
            }
            else
            {
                lblResultado.Text = "te guallaste"; 
            }
        }
    }
}
