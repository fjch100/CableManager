﻿using CableManager.Modelos;
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
    public partial class FormCarreras : Form
    {
        Cable cblModel;
        Carrera cra;
        public FormCarreras(Cable cable, Carrera carrera)
        {
            cblModel = cable;
            cra = carrera; 
            InitializeComponent();
            FillNumCable();
            txtLongPrevia.Text = cable.Long_actual.ToString();
            txtLongitudActual.Text = cable.Long_actual.ToString();
            txtCantidadCortada.Text = "0";
            if (carrera != null)
            {
                FillCarreraForm(carrera);
            }
        }

        private void FillCarreraForm(Carrera carrera)
        {
            txtNumCarreras.Text = carrera.Num_carreras.ToString();
            txtMaxProfundidad.Text = carrera.Max_profundidad.ToString();
            txtMaxTension.Text = carrera.Max_tension.ToString();
            txtServicesOrder.Text = carrera.Service_order;
            dateTimePicker1.Text = carrera.Fecha_Servicio.ToString();
            txtIngeniero.Text = carrera.Ingeniero;
            txtMalacatero.Text = carrera.Malacatero;
            txtComentarios.Text = carrera.Comentarios;
        }

        //boton Cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Dispose();
        }


        //llena el combobox del numero del cable en el formulario
        private void FillNumCable()
        {
            List<Cable> listaCables = cblModel.GetAllCables();
            cbNumCable.DataSource = listaCables;
            int modelIndex = listaCables.FindIndex(x => x.Numero ==cblModel.Numero);
            cbNumCable.SelectedIndex = modelIndex;
            cbNumCable.Enabled = false;
        }        
        

        //funcion helper para verificar el cambio en la longitud cortada y 
        //calcular la longitud actual, primero verifica que la cantidad cortada sea un numero
        private void CambioCantidadCortada(object sender, EventArgs e)
        {
            try
            {
                double long_previa = double.Parse(txtLongPrevia.Text);
                double cantidad_cortada = double.Parse(txtCantidadCortada.Text);
                double long_actual = long_previa - cantidad_cortada;
                txtLongitudActual.Text = long_actual.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("La cantidad cortada debe ser un numero");
            }
        }


        private void txtCantidadCortada_Leave(object sender, EventArgs e)
        {
            CambioCantidadCortada( sender, e);
        }


        //BOTON GUARDAR => (INSERT O EDIT UN TRABAJO)
        private void button1_Click(object sender, EventArgs e)
        {
            int numCarreraAnterior = 0;
            bool isaNewCarrera = false;
            if (!VerificaInputsFromForm())
            { 
                return; 
            }
            if (cra == null)
            {
                cra = new Carrera();
                isaNewCarrera = true;
            }
            else
            {
                numCarreraAnterior = cra.Num_carreras;
            }            
            cra.CableId = cblModel.Id;
            cra.Num_carreras = int.Parse(txtNumCarreras.Text.Trim());
            cra.Max_profundidad = double.Parse(txtMaxProfundidad.Text.Trim());
            cra.Max_tension = double.Parse(txtMaxTension.Text.Trim());
            cra.Service_order = txtServicesOrder.Text.Trim();
            cra.Fecha_Servicio = DateTime.Parse(dateTimePicker1.Text);
            cra.Ingeniero = txtIngeniero.Text;
            cra.Malacatero = txtMalacatero.Text;
            cra.Long_actual = double.Parse(txtLongitudActual.Text.Trim());
            cra.Cantidad_cortada = double.Parse(txtCantidadCortada.Text.Trim());
            cra.Long_previa = double.Parse(txtLongPrevia.Text.Trim());
            cra.Comentarios = txtComentarios.Text;
            if (isaNewCarrera)
            {
                if (cra.InsertOneCarrera(cra))
                {
                    cblModel.Carreras += cra.Num_carreras; 
                    cblModel.Long_actual = double.Parse(txtLongitudActual.Text.Trim());
                    if (cblModel.UpdateOneCable(cblModel))
                    {
                        MessageBox.Show("El Uso/Carrera se guardo Satisfactoriamente");
                    }
                }
                else
                {
                    MessageBox.Show("El uso o Carrera no se logro Guardar");
                }
            }
            else
            {
                if (cra.UpdateOneCarrera(cra))
                {
                    cblModel.Long_actual = double.Parse(txtLongitudActual.Text.Trim());
                    cblModel.Carreras += cra.Num_carreras - numCarreraAnterior;
                    if (cblModel.UpdateOneCable(cblModel))
                    {
                        MessageBox.Show("El Uso/Carrera se guardo Satisfactoriamente");
                    }
                }
                else
                {
                    MessageBox.Show("El uso o Carrera no se logro Guardar");
                }
            }
            this.DialogResult = DialogResult.OK;
            Dispose();
        }


        //verifica que los inputs no esten vacios
        private bool VerificaInputsFromForm()
        {            
            if (txtNumCarreras.Text.Trim() == string.Empty || txtNumCarreras.Text.All(Char.IsLetter))
            {
                MessageBox.Show("El numero de carreras necesita un numero de 0 a 100");
                return false;
            }
            if (txtMaxProfundidad.Text.Trim() == "")
            {
                MessageBox.Show($"la maxima profundidad necesita un numero de 0 a {cblModel.Long_actual}");
                return false;
            }
            if (int.Parse(txtMaxProfundidad.Text.Trim()) > cblModel.Long_actual)
            {
                MessageBox.Show($"la maxima profundidad necesita un numero de 0 a {cblModel.Long_actual}");
                return false;
            }
            if (txtMaxTension.Text.Trim() == "")
            {
                MessageBox.Show("La maxima tension necesita un numero de 0 a 16000");
                return false;
            }
            if (txtServicesOrder.Text.Trim() == "")
            {
                MessageBox.Show("El numero de Orden de Servicio no puede ir vacio");
                return false;
            }
            if (txtLongitudActual.Text.Trim() == "")
            {
                MessageBox.Show("la longitud Actual no puede ir vacia");
                return false;
            }
            return true;
        }
    }
}
