using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agendita
{
    public partial class FmContacto : Form
    {
        public string Nombre, Telefono, Ciudad;
        public FmContacto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Nombre = txtNombre.Text;
            Telefono = txtTelefono.Text;
            Ciudad = bnCiudad.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmCiudad ciudad = new agendita.FrmCiudad();
            if (ciudad.ShowDialog() == DialogResult.OK)
            {
                bnCiudad.Items.Add(ciudad.Nombre);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
