using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string nombreBuscado = txtNombreCliente.Text;
            string apellidoBuscado = txtApellido.Text;

            XDocument xmlDoc = XDocument.Load("C:\\Users\\DELL");

            var clientes = from cliente in xmlDoc.Descendants("cliente")
                           where cliente.Element("nombre").Value.ToLower().Contains(nombreBuscado.ToLower())
                           select new
                           {
                               Nombre = cliente.Element("nombre").Value,
                               Apellido = cliente.Element("apellido").Value
                           };

            dgvClientes.DataSource = clientes.ToList();
        }
    }
}
