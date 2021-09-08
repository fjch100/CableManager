using AutoMapper;
using CableManager.Business.Data;
using CableManager.WinForm.DTOs;
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
    public partial class MainPage : Form
    {
        CableForm fmCable;
        CarreraForm fmcarrera;

        private readonly ICableService _cableService;
        private readonly ICarreraService _carreraService;
        private readonly IMapper _mapper;

        public MainPage(ICableService cableService, ICarreraService carreraService, IMapper mapper)
        {
            _mapper = mapper;
            _cableService = cableService;
            _carreraService = carreraService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cablesGridView.DataSource = _mapper.Map<List<CableDto>>(_cableService.GetAllCables());
            carrerasGridView.DataSource = _mapper.Map<List<CarreraDto>>(_carreraService.GetAllCarreras());
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (cablesGridView.SelectedRows.Count > 0)
            {
                var row = cablesGridView.SelectedRows[0];
                int cableId = int.Parse(row.Cells[0].Value.ToString());

                carrerasGridView.DataSource = _mapper.Map<List<CarreraDto>>(_carreraService.GetCarrerasByCableId(cableId));

                lblCarreras.Text = $"TRABAJOS/CARRERAS DEL CABLE: {row.Cells[1].Value}";    
                btnEditCable.Enabled = true;
                btnEliminaCable.Enabled = true;
            }
        }

        //NEW CABLE BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            fmCable = new CableForm(null, _cableService, _mapper);
            fmCable.ShowDialog();
            
            cablesGridView.DataSource = _mapper.Map<List<CableDto>>(_cableService.GetAllCables());
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
            if (cablesGridView.SelectedRows.Count > 0)
            {
                var row = cablesGridView.SelectedRows[0];
                int cableId = int.Parse(row.Cells[0].Value.ToString());

                var cableToEdit = _cableService.GetCableById(cableId);

                fmCable = new CableForm(_mapper.Map<CableDto>(cableToEdit), _cableService, _mapper);
                fmCable.ShowDialog();

                cablesGridView.DataSource = _mapper.Map<List<CableDto>>(_cableService.GetAllCables());
            }
        }

        private void btnEliminaCable_Click(object sender, EventArgs e)
        {
            if (cablesGridView.SelectedRows.Count > 0)
            {
                var row = cablesGridView.SelectedRows[0];
                int cableId = int.Parse(row.Cells[0].Value.ToString());

                _cableService.DeleteCable(cableId);
                _cableService.SaveChanges();
                
                cablesGridView.DataSource = _mapper.Map<List<CableDto>>(_cableService.GetAllCables());
            }
        }

        // AGREGA UN NUEVO TRABAJO A UN CABLE
        private void btnAddCarrera_Click(object sender, EventArgs e)
        {
            if (cablesGridView.SelectedRows.Count > 0)
            {
                CarreraDto craModel = new CarreraDto();
                DataGridViewRow row = cablesGridView.SelectedRows[0];

                int index = row.Index; // index del row para volverla a seleccionar despues
                int cableId = int.Parse(row.Cells[0].Value.ToString());
                var cable = _cableService.GetCableById(cableId);

                fmcarrera = new CarreraForm(_mapper.Map<CableDto>(cable), null, _cableService, _carreraService, _mapper);
                fmcarrera.ShowDialog();

                cablesGridView.DataSource = _mapper.Map<List<CableDto>>(_cableService.GetAllCables()); // actualiza los cables
                cablesGridView.Rows[index].Selected = true; //volvemos a seleccionar la row queteniamos al principio
                cablesGridView.CurrentCell = cablesGridView.Rows[index].Cells[1]; // movemos el triangulito al row que se selecciono arriba

                carrerasGridView.DataSource = _mapper.Map<List<CarreraDto>>(_carreraService.GetCarrerasByCableId(cableId)); // actualiza las carreras
            }

        }

        //EDITA UN TRABAJO DE UN CABLE
        private void btnEditaCarrera_Click(object sender, EventArgs e)
        {
            if (carrerasGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow rowCarrera = carrerasGridView.SelectedRows[0];
                int indexCra = rowCarrera.Index;//index del row para volverla a seleccionar despues

                DataGridViewRow rowCable = cablesGridView.SelectedRows[0];
                int indexCable = rowCable.Index;//index del row para volverla a seleccionar despues

                int carreraId = int.Parse(rowCarrera.Cells[0].Value.ToString());
                int cableId = int.Parse(rowCarrera.Cells[3].Value.ToString());

                var cableModel = _mapper.Map<CableDto>( _cableService.GetCableById(cableId));
                var craModel = _mapper.Map<CarreraDto>(_carreraService.GetCarreraById(carreraId));

                fmcarrera = new CarreraForm(cableModel, craModel, _cableService, _carreraService, _mapper);
                fmcarrera.ShowDialog();

                cablesGridView.DataSource = _mapper.Map<List<CableDto>>(_cableService.GetAllCables()); // actualiza los cables
                cablesGridView.Rows[indexCable].Selected = true; // volvemos a seleccionar la row queteniamos al principio
                cablesGridView.CurrentCell = cablesGridView.Rows[indexCable].Cells[1]; // movemos el triangulito al row que se selecciono arriba

                //carrerasGridView.DataSource = craModel.GetAllCarrerasFromCable(carreraId); // actualiza las carreras
                carrerasGridView.Rows[indexCra].Selected = true; //volvemos a seleccionar la row queteniamos al principio
                //dataGridView2.CurrentCell = dataGridView1.Rows[indexCra].Cells[1]; // movemos el triangulito al row que se selecciono
            }

        }

        //BOTON BORRAR TRABAJO/CARRERA
        private void btnEliminaCarrera_Click(object sender, EventArgs e)
        {
            if (carrerasGridView.SelectedRows.Count > 0)
            {
                string message = "Realmente quieres borrar este trabajo?";
                string title = "BORRAR TRABAJO";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }               

                DataGridViewRow rowCarrera = carrerasGridView.SelectedRows[0];
                DataGridViewRow rowCable = cablesGridView.SelectedRows[0];

                int indexCable = rowCable.Index;//index del row para volverla a seleccionar despues
                int carreraId = int.Parse(rowCarrera.Cells[0].Value.ToString());
                int cableId = int.Parse(rowCarrera.Cells[3].Value.ToString());

                var craModel = _carreraService.GetCarreraById(carreraId);

                _carreraService.DeleteCarrera(carreraId);
                bool wasDeleted = _carreraService.SaveChanges();

                if (wasDeleted)
                {
                    _cableService.UpdateCableInfoAfterCarreraDeletion(cableId, craModel);

                    if (_cableService.SaveChanges())
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

                cablesGridView.DataSource = _mapper.Map<List<CableDto>>(_cableService.GetAllCables()); // actualiza los cables                
                cablesGridView.Rows[indexCable].Selected = true; // volvemos a seleccionar la row queteniamos al principio
                cablesGridView.CurrentCell = cablesGridView.Rows[indexCable].Cells[1]; // movemos el triangulito al row que se selecciono arriba
            }
        }
    }
}
