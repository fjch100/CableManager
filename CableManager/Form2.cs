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
    public partial class FormCable : Form
    {
        bool isaNewCable = true;
        Cable cableModel;
        public FormCable(Cable cable)
        {
            cableModel = cable;
            InitializeComponent();
            if(cableModel==null)
            {
                lblCable.Text = "New Cable";
                isaNewCable = true;
            }else
            {
                isaNewCable = false;
                lblCable.Text = $"Cable: {cableModel.Numero}";
                txtNumCable.Text = cableModel.Numero;
                txtLongInicial.Text = cableModel.Long_inicial.ToString();
                txtLongActual.Text = cableModel.Long_actual.ToString();
                txtNumCarreras.Text = cableModel.Carreras.ToString();
                txtNumDrum.Text = cableModel.Drum;
                dtpFechaLlegada.Text = cableModel.Fecha_llegada.ToString();
                dtpFechaInstalacion.Text = cableModel.Fecha_instalacion.ToString();
                txtTipoCable.Text = cableModel.Tipo_cable;               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!VerificaformCableInputs())
            {
                return;
            }
           if (isaNewCable)//NEW CABLE
            {
                Cable cblModel = new Cable();
                cableModel = ReadCableForm(cblModel);
                bool wasInserted = cableModel.InsertOneCable(cableModel);
                if (wasInserted)
                {
                    MessageBox.Show("New Cable inserted OK");
                }else
                {
                    MessageBox.Show(" Cable was NOT inserted ");
                }                
            }
            else //Edit cable
            {
                cableModel = ReadCableForm(cableModel);
                bool wasUpdated = cableModel.UpdateOneCable(cableModel);
                if (wasUpdated)
                {
                    MessageBox.Show("Cable Updated OK");
                }
                else
                {
                    MessageBox.Show(" Cable was NOT Updated ");
                }
            }
            this.DialogResult = DialogResult.OK;
            Dispose();
        }
        private Cable ReadCableForm(Cable cModel)
        {            
            cModel.Numero = txtNumCable.Text;
            cModel.Long_inicial = double.Parse(txtLongInicial.Text);
            cModel.Long_actual = double.Parse(txtLongActual.Text);
            cModel.Carreras = int.Parse(txtNumCarreras.Text);
            cModel.Drum = txtNumDrum.Text;
            cModel.Fecha_llegada = DateTime.Parse(dtpFechaLlegada.Text);
            cModel.Fecha_instalacion = DateTime.Parse(dtpFechaInstalacion.Text);
            cModel.Tipo_cable = txtTipoCable.Text;
            return cModel;
        }

        private bool VerificaformCableInputs()
        {
            if (txtNumCable.Text.Trim() == string.Empty )
            {
                MessageBox.Show("El numero del cable no puede estar vacio");
                return false;
            }
            if (txtLongInicial.Text.Trim() == string.Empty || !txtLongInicial.Text.All(Char.IsDigit))
            {
                MessageBox.Show("La longitud Inicial necesita un numero de 0 a 10000 m");
                return false;
            }
            if (txtLongActual.Text.Trim() == string.Empty || !txtLongActual.Text.All(Char.IsDigit))
            {
                MessageBox.Show($"La longitud Actual necesita un numero de 0 a {double.Parse(txtLongActual.Text)} m");
                return false;
            }
            if (txtNumCarreras.Text.Trim() == string.Empty || !txtNumCarreras.Text.All(Char.IsDigit))
            {
                MessageBox.Show("El numero de carreras debe ser un numero de 0 a 100 m");
                return false;
            }
            if (txtNumDrum.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El numero del Drum no puede estar vacio");
                return false;
            }
            if (txtTipoCable.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El tipo de cable no puede estar vacio");
                return false;
            }
            return true;
        }
    }
}
