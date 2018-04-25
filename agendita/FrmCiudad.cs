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
    public partial class FrmCiudad : Form
    {
        public string Nombre;
        public FrmCiudad()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Nombre = txtNombre.Text;
            this.DialogResult=DialogResult.OK;
            Close();
        }
    }
}
