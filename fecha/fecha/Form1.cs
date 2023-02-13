using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fecha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
             calcularDiferencia();
        }

        void calcularDiferencia()
        {
            DateTime fechaInicial = dtpNacimiento.Value.Date;
            DateTime fechaFinal = dtpActual.Value.Date;

            TimeSpan tspan = fechaFinal - fechaInicial;

            int Dias = tspan.Days / 365;

            txtResultado.Text = Dias.ToString();
        }

    }
}
