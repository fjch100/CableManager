
namespace CableManager
{
    partial class MainPage
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cablesGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longinicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longactualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrerasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechallegadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainstalacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipocableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrerasGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CableNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cableIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcarrerasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxprofundidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxtensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longpreviaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadcortadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longactualDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malacateroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingenieroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newCableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditCable = new System.Windows.Forms.Button();
            this.btnEliminaCable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCarreras = new System.Windows.Forms.Label();
            this.btnAddCarrera = new System.Windows.Forms.Button();
            this.btnEditaCarrera = new System.Windows.Forms.Button();
            this.btnEliminaCarrera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cablesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cablesGridView
            // 
            this.cablesGridView.AllowUserToAddRows = false;
            this.cablesGridView.AllowUserToDeleteRows = false;
            this.cablesGridView.AutoGenerateColumns = false;
            this.cablesGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cablesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cablesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cablesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.longinicialDataGridViewTextBoxColumn,
            this.longactualDataGridViewTextBoxColumn,
            this.carrerasDataGridViewTextBoxColumn,
            this.drumDataGridViewTextBoxColumn,
            this.fechallegadaDataGridViewTextBoxColumn,
            this.fechainstalacionDataGridViewTextBoxColumn,
            this.tipocableDataGridViewTextBoxColumn,
            this.tablaDataGridViewTextBoxColumn});
            this.cablesGridView.DataSource = this.cableBindingSource;
            this.cablesGridView.Location = new System.Drawing.Point(1, 116);
            this.cablesGridView.Margin = new System.Windows.Forms.Padding(4);
            this.cablesGridView.MultiSelect = false;
            this.cablesGridView.Name = "cablesGridView";
            this.cablesGridView.ReadOnly = true;
            this.cablesGridView.RowHeadersWidth = 51;
            this.cablesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cablesGridView.Size = new System.Drawing.Size(1336, 266);
            this.cablesGridView.TabIndex = 0;
            this.cablesGridView.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Width = 125;
            // 
            // longinicialDataGridViewTextBoxColumn
            // 
            this.longinicialDataGridViewTextBoxColumn.DataPropertyName = "Long_inicial";
            this.longinicialDataGridViewTextBoxColumn.HeaderText = "Long_inicial";
            this.longinicialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.longinicialDataGridViewTextBoxColumn.Name = "longinicialDataGridViewTextBoxColumn";
            this.longinicialDataGridViewTextBoxColumn.ReadOnly = true;
            this.longinicialDataGridViewTextBoxColumn.Width = 125;
            // 
            // longactualDataGridViewTextBoxColumn
            // 
            this.longactualDataGridViewTextBoxColumn.DataPropertyName = "Long_actual";
            this.longactualDataGridViewTextBoxColumn.HeaderText = "Long_actual";
            this.longactualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.longactualDataGridViewTextBoxColumn.Name = "longactualDataGridViewTextBoxColumn";
            this.longactualDataGridViewTextBoxColumn.ReadOnly = true;
            this.longactualDataGridViewTextBoxColumn.Width = 125;
            // 
            // carrerasDataGridViewTextBoxColumn
            // 
            this.carrerasDataGridViewTextBoxColumn.DataPropertyName = "Carreras";
            this.carrerasDataGridViewTextBoxColumn.HeaderText = "Carreras";
            this.carrerasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carrerasDataGridViewTextBoxColumn.Name = "carrerasDataGridViewTextBoxColumn";
            this.carrerasDataGridViewTextBoxColumn.ReadOnly = true;
            this.carrerasDataGridViewTextBoxColumn.Width = 125;
            // 
            // drumDataGridViewTextBoxColumn
            // 
            this.drumDataGridViewTextBoxColumn.DataPropertyName = "Drum";
            this.drumDataGridViewTextBoxColumn.HeaderText = "Drum";
            this.drumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.drumDataGridViewTextBoxColumn.Name = "drumDataGridViewTextBoxColumn";
            this.drumDataGridViewTextBoxColumn.ReadOnly = true;
            this.drumDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechallegadaDataGridViewTextBoxColumn
            // 
            this.fechallegadaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_llegada";
            this.fechallegadaDataGridViewTextBoxColumn.HeaderText = "Fecha_llegada";
            this.fechallegadaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechallegadaDataGridViewTextBoxColumn.Name = "fechallegadaDataGridViewTextBoxColumn";
            this.fechallegadaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechallegadaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechainstalacionDataGridViewTextBoxColumn
            // 
            this.fechainstalacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_instalacion";
            this.fechainstalacionDataGridViewTextBoxColumn.HeaderText = "Fecha_instalacion";
            this.fechainstalacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechainstalacionDataGridViewTextBoxColumn.Name = "fechainstalacionDataGridViewTextBoxColumn";
            this.fechainstalacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechainstalacionDataGridViewTextBoxColumn.Width = 110;
            // 
            // tipocableDataGridViewTextBoxColumn
            // 
            this.tipocableDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipocableDataGridViewTextBoxColumn.DataPropertyName = "Tipo_cable";
            this.tipocableDataGridViewTextBoxColumn.HeaderText = "Tipo_cable";
            this.tipocableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipocableDataGridViewTextBoxColumn.Name = "tipocableDataGridViewTextBoxColumn";
            this.tipocableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tablaDataGridViewTextBoxColumn
            // 
            this.tablaDataGridViewTextBoxColumn.DataPropertyName = "Tabla";
            this.tablaDataGridViewTextBoxColumn.HeaderText = "Tabla";
            this.tablaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tablaDataGridViewTextBoxColumn.Name = "tablaDataGridViewTextBoxColumn";
            this.tablaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tablaDataGridViewTextBoxColumn.Visible = false;
            this.tablaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cableBindingSource
            // 
            this.cableBindingSource.DataSource = typeof(CableManager.Modelos.CableDto);
            // 
            // carrerasGridView
            // 
            this.carrerasGridView.AllowUserToAddRows = false;
            this.carrerasGridView.AllowUserToDeleteRows = false;
            this.carrerasGridView.AutoGenerateColumns = false;
            this.carrerasGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.carrerasGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.carrerasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carrerasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.fechaServicioDataGridViewTextBoxColumn,
            this.CableNumero,
            this.cableIdDataGridViewTextBoxColumn,
            this.serviceorderDataGridViewTextBoxColumn,
            this.numcarrerasDataGridViewTextBoxColumn,
            this.maxprofundidadDataGridViewTextBoxColumn,
            this.maxtensionDataGridViewTextBoxColumn,
            this.longpreviaDataGridViewTextBoxColumn,
            this.cantidadcortadaDataGridViewTextBoxColumn,
            this.longactualDataGridViewTextBoxColumn1,
            this.malacateroDataGridViewTextBoxColumn,
            this.ingenieroDataGridViewTextBoxColumn,
            this.comentariosDataGridViewTextBoxColumn,
            this.tablaDataGridViewTextBoxColumn1});
            this.carrerasGridView.DataSource = this.carreraBindingSource;
            this.carrerasGridView.Location = new System.Drawing.Point(1, 473);
            this.carrerasGridView.Margin = new System.Windows.Forms.Padding(4);
            this.carrerasGridView.MultiSelect = false;
            this.carrerasGridView.Name = "carrerasGridView";
            this.carrerasGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.carrerasGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.carrerasGridView.RowHeadersWidth = 51;
            this.carrerasGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carrerasGridView.Size = new System.Drawing.Size(1764, 346);
            this.carrerasGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // fechaServicioDataGridViewTextBoxColumn
            // 
            this.fechaServicioDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Servicio";
            this.fechaServicioDataGridViewTextBoxColumn.HeaderText = "Fecha Servicio";
            this.fechaServicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaServicioDataGridViewTextBoxColumn.Name = "fechaServicioDataGridViewTextBoxColumn";
            this.fechaServicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaServicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // CableNumero
            // 
            this.CableNumero.DataPropertyName = "CableNumero";
            this.CableNumero.HeaderText = "Numero de Cable";
            this.CableNumero.MinimumWidth = 6;
            this.CableNumero.Name = "CableNumero";
            this.CableNumero.ReadOnly = true;
            this.CableNumero.Width = 110;
            // 
            // cableIdDataGridViewTextBoxColumn
            // 
            this.cableIdDataGridViewTextBoxColumn.DataPropertyName = "CableId";
            this.cableIdDataGridViewTextBoxColumn.HeaderText = "CableId";
            this.cableIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cableIdDataGridViewTextBoxColumn.Name = "cableIdDataGridViewTextBoxColumn";
            this.cableIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cableIdDataGridViewTextBoxColumn.Visible = false;
            this.cableIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceorderDataGridViewTextBoxColumn
            // 
            this.serviceorderDataGridViewTextBoxColumn.DataPropertyName = "Service_order";
            this.serviceorderDataGridViewTextBoxColumn.HeaderText = "Services Order";
            this.serviceorderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceorderDataGridViewTextBoxColumn.Name = "serviceorderDataGridViewTextBoxColumn";
            this.serviceorderDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceorderDataGridViewTextBoxColumn.Width = 125;
            // 
            // numcarrerasDataGridViewTextBoxColumn
            // 
            this.numcarrerasDataGridViewTextBoxColumn.DataPropertyName = "Num_carreras";
            this.numcarrerasDataGridViewTextBoxColumn.HeaderText = "Numero de Carreras";
            this.numcarrerasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numcarrerasDataGridViewTextBoxColumn.Name = "numcarrerasDataGridViewTextBoxColumn";
            this.numcarrerasDataGridViewTextBoxColumn.ReadOnly = true;
            this.numcarrerasDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxprofundidadDataGridViewTextBoxColumn
            // 
            this.maxprofundidadDataGridViewTextBoxColumn.DataPropertyName = "Max_profundidad";
            this.maxprofundidadDataGridViewTextBoxColumn.HeaderText = "Max. Profundidad";
            this.maxprofundidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxprofundidadDataGridViewTextBoxColumn.Name = "maxprofundidadDataGridViewTextBoxColumn";
            this.maxprofundidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxprofundidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxtensionDataGridViewTextBoxColumn
            // 
            this.maxtensionDataGridViewTextBoxColumn.DataPropertyName = "Max_tension";
            this.maxtensionDataGridViewTextBoxColumn.HeaderText = "Max. Tension";
            this.maxtensionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxtensionDataGridViewTextBoxColumn.Name = "maxtensionDataGridViewTextBoxColumn";
            this.maxtensionDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxtensionDataGridViewTextBoxColumn.Width = 125;
            // 
            // longpreviaDataGridViewTextBoxColumn
            // 
            this.longpreviaDataGridViewTextBoxColumn.DataPropertyName = "Long_previa";
            this.longpreviaDataGridViewTextBoxColumn.HeaderText = "Long. Previa";
            this.longpreviaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.longpreviaDataGridViewTextBoxColumn.Name = "longpreviaDataGridViewTextBoxColumn";
            this.longpreviaDataGridViewTextBoxColumn.ReadOnly = true;
            this.longpreviaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadcortadaDataGridViewTextBoxColumn
            // 
            this.cantidadcortadaDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_cortada";
            this.cantidadcortadaDataGridViewTextBoxColumn.HeaderText = "Cantidad Cortada";
            this.cantidadcortadaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadcortadaDataGridViewTextBoxColumn.Name = "cantidadcortadaDataGridViewTextBoxColumn";
            this.cantidadcortadaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadcortadaDataGridViewTextBoxColumn.Width = 125;
            // 
            // longactualDataGridViewTextBoxColumn1
            // 
            this.longactualDataGridViewTextBoxColumn1.DataPropertyName = "Long_actual";
            this.longactualDataGridViewTextBoxColumn1.HeaderText = "Long. Actual";
            this.longactualDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.longactualDataGridViewTextBoxColumn1.Name = "longactualDataGridViewTextBoxColumn1";
            this.longactualDataGridViewTextBoxColumn1.ReadOnly = true;
            this.longactualDataGridViewTextBoxColumn1.Width = 125;
            // 
            // malacateroDataGridViewTextBoxColumn
            // 
            this.malacateroDataGridViewTextBoxColumn.DataPropertyName = "Malacatero";
            this.malacateroDataGridViewTextBoxColumn.HeaderText = "Malacatero";
            this.malacateroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.malacateroDataGridViewTextBoxColumn.Name = "malacateroDataGridViewTextBoxColumn";
            this.malacateroDataGridViewTextBoxColumn.ReadOnly = true;
            this.malacateroDataGridViewTextBoxColumn.Width = 125;
            // 
            // ingenieroDataGridViewTextBoxColumn
            // 
            this.ingenieroDataGridViewTextBoxColumn.DataPropertyName = "Ingeniero";
            this.ingenieroDataGridViewTextBoxColumn.HeaderText = "Ingeniero";
            this.ingenieroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ingenieroDataGridViewTextBoxColumn.Name = "ingenieroDataGridViewTextBoxColumn";
            this.ingenieroDataGridViewTextBoxColumn.ReadOnly = true;
            this.ingenieroDataGridViewTextBoxColumn.Width = 125;
            // 
            // comentariosDataGridViewTextBoxColumn
            // 
            this.comentariosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comentariosDataGridViewTextBoxColumn.DataPropertyName = "Comentarios";
            this.comentariosDataGridViewTextBoxColumn.HeaderText = "Comentarios";
            this.comentariosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.comentariosDataGridViewTextBoxColumn.Name = "comentariosDataGridViewTextBoxColumn";
            this.comentariosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tablaDataGridViewTextBoxColumn1
            // 
            this.tablaDataGridViewTextBoxColumn1.DataPropertyName = "Tabla";
            this.tablaDataGridViewTextBoxColumn1.HeaderText = "Tabla";
            this.tablaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tablaDataGridViewTextBoxColumn1.Name = "tablaDataGridViewTextBoxColumn1";
            this.tablaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tablaDataGridViewTextBoxColumn1.Visible = false;
            this.tablaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // carreraBindingSource
            // 
            this.carreraBindingSource.DataSource = typeof(CableManager.Modelos.CarreraDto);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1361, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(388, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nuevo Cable";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1771, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newCableToolStripMenuItem
            // 
            this.newCableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCableToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.newCableToolStripMenuItem.Name = "newCableToolStripMenuItem";
            this.newCableToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.newCableToolStripMenuItem.Text = "Cable";
            // 
            // newCableToolStripMenuItem1
            // 
            this.newCableToolStripMenuItem1.Name = "newCableToolStripMenuItem1";
            this.newCableToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.newCableToolStripMenuItem1.Text = "New Cable";
            this.newCableToolStripMenuItem1.Click += new System.EventHandler(this.newCableToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnEditCable
            // 
            this.btnEditCable.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditCable.Enabled = false;
            this.btnEditCable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCable.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCable.Location = new System.Drawing.Point(1361, 190);
            this.btnEditCable.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCable.Name = "btnEditCable";
            this.btnEditCable.Size = new System.Drawing.Size(388, 43);
            this.btnEditCable.TabIndex = 5;
            this.btnEditCable.Text = "Edita un Cable";
            this.btnEditCable.UseVisualStyleBackColor = false;
            this.btnEditCable.Click += new System.EventHandler(this.btnEditCable_Click);
            // 
            // btnEliminaCable
            // 
            this.btnEliminaCable.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminaCable.Enabled = false;
            this.btnEliminaCable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaCable.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaCable.Location = new System.Drawing.Point(1361, 338);
            this.btnEliminaCable.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminaCable.Name = "btnEliminaCable";
            this.btnEliminaCable.Size = new System.Drawing.Size(388, 43);
            this.btnEliminaCable.TabIndex = 6;
            this.btnEliminaCable.Text = "Elimina Cable";
            this.btnEliminaCable.UseVisualStyleBackColor = false;
            this.btnEliminaCable.Click += new System.EventHandler(this.btnEliminaCable_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1764, 68);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(823, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CABLES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.lblCarreras);
            this.panel2.Location = new System.Drawing.Point(1, 402);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1764, 63);
            this.panel2.TabIndex = 8;
            // 
            // lblCarreras
            // 
            this.lblCarreras.AutoSize = true;
            this.lblCarreras.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarreras.ForeColor = System.Drawing.Color.White;
            this.lblCarreras.Location = new System.Drawing.Point(619, 17);
            this.lblCarreras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarreras.Name = "lblCarreras";
            this.lblCarreras.Size = new System.Drawing.Size(461, 34);
            this.lblCarreras.TabIndex = 0;
            this.lblCarreras.Text = "TRABAJOS (TODOS LOS CABLES)";
            // 
            // btnAddCarrera
            // 
            this.btnAddCarrera.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCarrera.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCarrera.Location = new System.Drawing.Point(1361, 268);
            this.btnAddCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCarrera.Name = "btnAddCarrera";
            this.btnAddCarrera.Size = new System.Drawing.Size(388, 43);
            this.btnAddCarrera.TabIndex = 9;
            this.btnAddCarrera.Text = "Nuevo Trabajo / Carrera";
            this.btnAddCarrera.UseVisualStyleBackColor = false;
            this.btnAddCarrera.Click += new System.EventHandler(this.btnAddCarrera_Click);
            // 
            // btnEditaCarrera
            // 
            this.btnEditaCarrera.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditaCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditaCarrera.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditaCarrera.Location = new System.Drawing.Point(349, 846);
            this.btnEditaCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditaCarrera.Name = "btnEditaCarrera";
            this.btnEditaCarrera.Size = new System.Drawing.Size(388, 43);
            this.btnEditaCarrera.TabIndex = 10;
            this.btnEditaCarrera.Text = "Edita Trabajo";
            this.btnEditaCarrera.UseVisualStyleBackColor = false;
            this.btnEditaCarrera.Click += new System.EventHandler(this.btnEditaCarrera_Click);
            // 
            // btnEliminaCarrera
            // 
            this.btnEliminaCarrera.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminaCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaCarrera.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaCarrera.Location = new System.Drawing.Point(1044, 846);
            this.btnEliminaCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminaCarrera.Name = "btnEliminaCarrera";
            this.btnEliminaCarrera.Size = new System.Drawing.Size(388, 43);
            this.btnEliminaCarrera.TabIndex = 11;
            this.btnEliminaCarrera.Text = "Elimina un Trabajo";
            this.btnEliminaCarrera.UseVisualStyleBackColor = false;
            this.btnEliminaCarrera.Click += new System.EventHandler(this.btnEliminaCarrera_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1771, 908);
            this.Controls.Add(this.btnEliminaCarrera);
            this.Controls.Add(this.btnEditaCarrera);
            this.Controls.Add(this.btnAddCarrera);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminaCable);
            this.Controls.Add(this.btnEditCable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.carrerasGridView);
            this.Controls.Add(this.cablesGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.Text = "CABLES";
            //this.Activated += new System.EventHandler(this.OnActivated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cablesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cablesGridView;
        private System.Windows.Forms.BindingSource cableBindingSource;
        private System.Windows.Forms.DataGridView carrerasGridView;
        private System.Windows.Forms.BindingSource carreraBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newCableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCableToolStripMenuItem1;
        private System.Windows.Forms.Button btnEditCable;
        private System.Windows.Forms.Button btnEliminaCable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCarreras;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longinicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longactualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrerasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechallegadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainstalacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipocableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CableNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cableIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcarrerasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxprofundidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxtensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longpreviaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadcortadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longactualDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malacateroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingenieroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnAddCarrera;
        private System.Windows.Forms.Button btnEditaCarrera;
        private System.Windows.Forms.Button btnEliminaCarrera;
    }
}

