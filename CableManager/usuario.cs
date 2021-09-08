using CableManager.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CableManager
{
    public partial class FormUsuario : Form
    {
        Persona persModel;
        List<Posicion> posicionesDb;
        Posicion pos;
        public FormUsuario()
        {
            persModel = new Persona();
            pos = new Posicion();
            posicionesDb = pos.GetAllPosiciones();
            InitializeComponent();
        }

        //FORM LOAD
        private void usuario_Load(object sender, EventArgs e)
        {
            cbPosicion.DataSource = posicionesDb;
            dgwUsuarios.DataSource = persModel.GetAllPersonas();            
        }

       
        private void dgwUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwUsuarios.SelectedRows.Count > 0)
            {
                var pModel = new Persona();
                DataGridViewRow row = dgwUsuarios.SelectedRows[0];
                int userId = int.Parse(row.Cells[0].Value.ToString());
                pModel = pModel.GetOnePersona(userId);
                txtNombre.Text = pModel.Nombre;
                txtApellido.Text = pModel.Apellido;
                txtDireccion.Text = pModel.Direccion;
                int posicionIndex = posicionesDb.FindIndex(x => x.PosicionName == pModel.Posicion);
                cbPosicion.SelectedIndex = posicionIndex;
            }
        }
    }
}
