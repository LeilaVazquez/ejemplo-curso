using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Azul");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;
            lwElementos.Items.Add(elemento);
        }

        private void cboColorFavorito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaDeNacimiento.Value;
            //operador ternario
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : " No le gusta el chocolate";
            string tipo;
            if (rbMuggle.Checked)
                tipo = "Muggle";
            else if (rbWizzard.Checked)
                tipo = "Wizzard";
            else
                tipo = "Squibs";

            string colorFavorito = cboColorFavorito.SelectedItem.ToString();

            string numeroFavorito = numNumFav.Value.ToString();
            string mensaje = chocolate + ", es " + tipo + ", su colore es: " + colorFavorito + ", su numero favorito es: " + numeroFavorito;
            MessageBox.Show("Nombre; " + nombre + "Fecha: " + fecha +  ", " + mensaje);

        }
    }
}
