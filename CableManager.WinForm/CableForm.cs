using AutoMapper;
using CableManager.WinForm.DTOs;
using CableManager.Business.Models;
using CableManager.Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CableManager.WinForm
{
    public partial class CableForm : Form
    {
        bool isaNewCable = true;

        private readonly ICableService _cableService;
        private readonly IMapper _mapper;

        CableDto _cableModel;

        public CableForm(CableDto cable, ICableService cableService, IMapper mapper)
        {
            _cableModel = cable;
            _mapper = mapper;
            _cableService = cableService;

            InitializeComponent();

            if(_cableModel == null)
            {
                lblCable.Text = "New Cable";
                isaNewCable = true;
            }
            else
            {
                isaNewCable = false;
                lblCable.Text = $"Cable: {_cableModel.Numero}";
                txtNumCable.Text = _cableModel.Numero;
                txtLongInicial.Text = _cableModel.Long_inicial.ToString();
                txtLongActual.Text = _cableModel.Long_actual.ToString();
                txtNumCarreras.Text = _cableModel.Carreras.ToString();
                txtNumDrum.Text = _cableModel.Drum;
                dtpFechaLlegada.Text = _cableModel.Fecha_llegada.ToString();
                dtpFechaInstalacion.Text = _cableModel.Fecha_instalacion.ToString();
                txtTipoCable.Text = _cableModel.Tipo_cable;               
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
                var newCableDto = ReadCableForm();

                _cableService.CreateCable(_mapper.Map<Cable>(newCableDto));

                bool wasInserted = _cableService.SaveChanges();

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
                var cableModel = ReadCableForm();
                var cableToUpdate = _cableService.GetCableById(_cableModel.Id);

                // mappea los atributos del modelo hacia el registro existente en la base de datos
                _mapper.Map(cableModel, cableToUpdate); 

                bool wasUpdated = _cableService.SaveChanges();

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

        private CableDto ReadCableForm()
        {
            var cModel = new CableDto()
            {
                Numero = txtNumCable.Text,
                Long_inicial = double.Parse(txtLongInicial.Text),
                Long_actual = double.Parse(txtLongActual.Text),
                Carreras = int.Parse(txtNumCarreras.Text),
                Drum = txtNumDrum.Text,
                Fecha_llegada = DateTime.Parse(dtpFechaLlegada.Text),
                Fecha_instalacion = DateTime.Parse(dtpFechaInstalacion.Text),
                Tipo_cable = txtTipoCable.Text
            };

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
