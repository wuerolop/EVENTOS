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
    public partial class fmlistas : Form
    {
        List<ClsContacto> contactos = new List<ClsContacto>();
        public fmlistas()
        {
            InitializeComponent();
        }
        ClsContacto Contacto = new ClsContacto();
        private void LlenarDataGrid()
        {
            dgContactos.DataSource = null;
            if (contactos.Count > 0)
                dgContactos.DataSource = contactos;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FmContacto Nuevo = new agendita.FmContacto();
            if(Nuevo.ShowDialog()==DialogResult.OK)
            {
                Contacto = new agendita.ClsContacto();
                Contacto.Nombre = Nuevo.Nombre;
                Contacto.Telefono = Nuevo.Telefono;
                Contacto.Ciudad = Nuevo.Ciudad;
                contactos.Add(Contacto);
                LlenarDataGrid();
            }
        }

        private void fmlistas_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            contactos.RemoveAt(dgContactos.CurrentRow.Index);
            LlenarDataGrid();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
