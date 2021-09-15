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
        bool isNewUsuario;
        public FormUsuario()
        {
            persModel = new Persona();
            pos = new Posicion();
            posicionesDb = pos.GetAllPosiciones();
            InitializeComponent();
            isNewUsuario = true;
        }

        //FORM LOAD
        private void usuario_Load(object sender, EventArgs e)
        {
            cbPosicion.DataSource = posicionesDb;
            dgwUsuarios.DataSource = persModel.GetAllPersonas();
            ClearTxtInputs();
        }

       
        private void dgwUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwUsuarios.SelectedRows.Count > 0)
            {
                //var pModel = new Persona();
                DataGridViewRow row = dgwUsuarios.SelectedRows[0];
                int userId = int.Parse(row.Cells[0].Value.ToString());
                persModel = persModel.GetOnePersona(userId);
                txtNombre.Text = persModel.Nombre;
                txtApellido.Text = persModel.Apellido;
                txtDireccion.Text = persModel.Direccion;
                int posicionIndex = posicionesDb.FindIndex(x => x.PosicionName == persModel.Posicion);
                cbPosicion.SelectedIndex = posicionIndex;
                if(persModel.Activo==1)
                {
                    ChkBoxActivo.Checked = true;
                }
                else
                {
                    ChkBoxActivo.Checked = false;
                }
                isNewUsuario = false;
                btnGuardar.Text = "Guardar Usuario";
            }
        }

        private void ClearTxtInputs()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            btnGuardar.Text = "Guardar como Nuevo";
            isNewUsuario = true;
            ChkBoxActivo.Checked = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTxtInputs();            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           if (CheckTextInputs())
            {
                FillModel();
               
                if (isNewUsuario)
                {
                    //bool wasSaved = persModel.InsertOnePersona(persModel);
                    if (persModel.InsertOnePersona(persModel))
                    {
                        MessageBox.Show("Se guardo el Usuario Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se logro salvar el Usuario");
                    }
                }
                else//USUARIO EDITADO
                {
                    //bool wasUpdated = persModel.UpdateOnePersona(persModel);
                    if(persModel.UpdateOnePersona(persModel))
                    {
                        MessageBox.Show("Se guardo el Usuario Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se logro salvar el Usuario");
                    }
                }
                dgwUsuarios.DataSource = persModel.GetAllPersonas();
                ClearTxtInputs();
            }
           
        }

        private bool CheckTextInputs()
        {
            if (txtApellido.Text.Trim() == string.Empty )
            {
                MessageBox.Show("El Apellido esta vacio");
                return false;
            }
            if (txtDireccion.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La direccion esta vacia");
                return false;
            }
            if (txtNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Nombre esta vacio");
                return false;
            }
            return true;
        }

        private void FillModel()
        {
            pos = (Posicion)cbPosicion.SelectedItem;
            persModel.PosicionId = pos.Id;
            persModel.Posicion = pos.PosicionName;
            persModel.Apellido = txtApellido.Text;
            persModel.Direccion = txtDireccion.Text;
            persModel.Nombre = txtNombre.Text;
            if(ChkBoxActivo.Checked)
            {
                persModel.Activo = 1;
                persModel.StrActivo = "Activo";
            }
            else
            {
                persModel.Activo = 0;
                persModel.StrActivo = "Inactivo";
            }
            
        }

        
    }
}
