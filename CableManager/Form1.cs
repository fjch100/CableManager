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
    public partial class Form1 : Form
    {
        FormCable fmCable;
        FormCarreras fmcarrera;
        FormUsuario fmUsuario;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cable cable = new Cable();
            Carrera carrera = new Carrera();
            dataGridView1.DataSource = cable.GetAllCables();
            //dataGridView2.DataSource = carrera.GetAllCarreras();
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int id = int.Parse(row.Cells[0].Value.ToString());
                lblCarreras.Text = $"TRABAJOS/CARRERAS DEL CABLE: {row.Cells[1].Value.ToString()}";                 
                Carrera carrera = new Carrera();
                dataGridView2.DataSource = carrera.GetAllCarrerasFromCable(id);
                btnEditCable.Enabled = true;
                btnEliminaCable.Enabled = true;
            }
           

        }
        //NEW CABLE BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            Cable cable = new Cable();
            fmCable = new FormCable(null);
            fmCable.ShowDialog();
            dataGridView1.DataSource = cable.GetAllCables();
        }
        //EXIT
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //NEW CABLE FROM MENU
        private void newCableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
       
        // EDIT BUTTON        
        private void btnEditCable_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Cable cableModel = new Cable();
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int id = int.Parse(row.Cells[0].Value.ToString());
                cableModel = cableModel.DbGetOne<Cable>(id);
                fmCable = new FormCable(cableModel);
                fmCable.ShowDialog();
                dataGridView1.DataSource = cableModel.GetAllCables();
            }
        }

        private void btnEliminaCable_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Cable cableModel = new Cable();
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int id = int.Parse(row.Cells[0].Value.ToString());
                var wasDeleted = cableModel.DbDelete(id);                
                dataGridView1.DataSource = cableModel.GetAllCables();
            }
        }

        // AGREGA UN NUEVO TRABAJO A UN CABLE
        private void btnAddCarrera_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Carrera craModel = new Carrera();
                Cable cable = new Cable();
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int index =row.Index;//index del row para volverla a seleccionar despues
                int id = int.Parse(row.Cells[0].Value.ToString());
                cable = cable.DbGetOne<Cable>(id);
                fmcarrera = new FormCarreras(cable, null);
                fmcarrera.ShowDialog();
                dataGridView1.DataSource = cable.GetAllCables();// actualiza los cables
                dataGridView1.Rows[index].Selected = true;//volvemos a seleccionar la row queteniamos al principio
                dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[1];// movemos el triangulito al row que se selecciono arriba
                dataGridView2.DataSource = craModel.GetAllCarrerasFromCable(id);//actualiza las carreras
            }

        }

        //EDITA UN TRABAJO DE UN CABLE
        private void btnEditaCarrera_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                Carrera craModel = new Carrera();
                Cable cableModel = new Cable();
                DataGridViewRow rowCarrera = dataGridView2.SelectedRows[0];
                int indexCra = rowCarrera.Index;//index del row para volverla a seleccionar despues
                DataGridViewRow rowCable = dataGridView1.SelectedRows[0];
                int indexCable = rowCable.Index;//index del row para volverla a seleccionar despues
                int carreraId = int.Parse(rowCarrera.Cells[0].Value.ToString());
                int cableId = int.Parse(rowCarrera.Cells[3].Value.ToString());
                cableModel = cableModel.DbGetOne<Cable>(cableId);           
                craModel = craModel.DbGetOne<Carrera>(carreraId);
                fmcarrera = new FormCarreras(cableModel, craModel);
                fmcarrera.ShowDialog();
                dataGridView1.DataSource = cableModel.GetAllCables();// actualiza los cables
                //dataGridView2.DataSource = craModel.GetAllCarrerasFromCable(carreraId);//actualiza las carreras
                dataGridView1.Rows[indexCable].Selected = true;//volvemos a seleccionar la row queteniamos al principio
                dataGridView1.CurrentCell = dataGridView1.Rows[indexCable].Cells[1];// movemos el triangulito al row que se selecciono arriba
                
                dataGridView2.Rows[indexCra].Selected = true;//volvemos a seleccionar la row queteniamos al principio
                //dataGridView2.CurrentCell = dataGridView1.Rows[indexCra].Cells[1];// movemos el triangulito al row que se selecciono
            }

        }

        //BOTON BORRAR TRABAJO/CARRERA
        private void btnEliminaCarrera_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string message = "Realmente quieres borrar este trabajo?";
                string title = "BORRAR TRABAJO";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }               

                Carrera craModel = new Carrera();
                Cable cableModel = new Cable();
                DataGridViewRow rowCarrera = dataGridView2.SelectedRows[0];
                DataGridViewRow rowCable = dataGridView1.SelectedRows[0];
                int indexCable = rowCable.Index;//index del row para volverla a seleccionar despues
                int carreraId = int.Parse(rowCarrera.Cells[0].Value.ToString());
                int cableId = int.Parse(rowCarrera.Cells[3].Value.ToString());
                cableModel = cableModel.DbGetOne<Cable>(cableId);
                craModel = craModel.DbGetOne<Carrera>(carreraId);

                bool wasDeleted = craModel.DbDelete(carreraId);               

                if ( wasDeleted)
                {
                    cableModel.Long_actual = craModel.Long_previa;
                    cableModel.Carreras = cableModel.Carreras - craModel.Num_carreras;
                    if (cableModel.UpdateOneCable(cableModel))
                    {
                        MessageBox.Show("Trabajo borrado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Se logro borrar el trabajo, pero hubo un problema actualizando el cable");
                    }
                    
                }
                else
                {
                    MessageBox.Show("No se logro borrar el trabajo");
                }
                dataGridView1.DataSource = cableModel.GetAllCables();// actualiza los cables                
                dataGridView1.Rows[indexCable].Selected = true;//volvemos a seleccionar la row queteniamos al principio
                dataGridView1.CurrentCell = dataGridView1.Rows[indexCable].Cells[1];// movemos el triangulito al row que se selecciono arriba
            }
        }

        //MENU USUARIO ABRE VENTANA USUARIOS (PERSONAS)
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmUsuario = new FormUsuario();
            fmUsuario.ShowDialog();
        }
    }
}
