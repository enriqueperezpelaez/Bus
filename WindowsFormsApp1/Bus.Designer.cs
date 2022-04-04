namespace RedTransporte
{
    partial class Bus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCaminoMinimo = new System.Windows.Forms.Button();
            this.dgvParadas = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActividadPresupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTramos = new System.Windows.Forms.DataGridView();
            this.lblParadas = new System.Windows.Forms.Label();
            this.lblTramos = new System.Windows.Forms.Label();
            this.lblRutas = new System.Windows.Forms.Label();
            this.dgvRutas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTramosRuta = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCaminoMinimo = new System.Windows.Forms.DataGridView();
            this.lstRuta = new System.Windows.Forms.ListBox();
            this.lblCaminoMinimo = new System.Windows.Forms.Label();
            this.lblRutaMinima = new System.Windows.Forms.Label();
            this.chkBucle = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.IdTramo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoTramo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParadaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParadaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogitudTramo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionTramo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramosRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminoMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCaminoMinimo
            // 
            this.btnCaminoMinimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCaminoMinimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaminoMinimo.FlatAppearance.BorderSize = 0;
            this.btnCaminoMinimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCaminoMinimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaminoMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCaminoMinimo.Location = new System.Drawing.Point(885, 12);
            this.btnCaminoMinimo.Name = "btnCaminoMinimo";
            this.btnCaminoMinimo.Size = new System.Drawing.Size(131, 23);
            this.btnCaminoMinimo.TabIndex = 2;
            this.btnCaminoMinimo.Text = "Calcula";
            this.btnCaminoMinimo.UseVisualStyleBackColor = false;
            this.btnCaminoMinimo.Click += new System.EventHandler(this.btnCaminoMinimo_Click);
            // 
            // dgvParadas
            // 
            this.dgvParadas.AllowUserToAddRows = false;
            this.dgvParadas.AllowUserToDeleteRows = false;
            this.dgvParadas.AllowUserToResizeColumns = false;
            this.dgvParadas.AllowUserToResizeRows = false;
            this.dgvParadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvParadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle56.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle56;
            this.dgvParadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Codigo,
            this.ActividadPresupuesto,
            this.Latitud,
            this.Longitud});
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParadas.DefaultCellStyle = dataGridViewCellStyle57;
            this.dgvParadas.EnableHeadersVisualStyles = false;
            this.dgvParadas.Location = new System.Drawing.Point(25, 38);
            this.dgvParadas.Name = "dgvParadas";
            this.dgvParadas.ReadOnly = true;
            this.dgvParadas.RowHeadersVisible = false;
            this.dgvParadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParadas.Size = new System.Drawing.Size(568, 129);
            this.dgvParadas.TabIndex = 298;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "IdParada";
            this.Cantidad.HeaderText = "Id";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 40;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 70;
            // 
            // ActividadPresupuesto
            // 
            this.ActividadPresupuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActividadPresupuesto.DataPropertyName = "Descripcion";
            this.ActividadPresupuesto.HeaderText = "Descripción";
            this.ActividadPresupuesto.Name = "ActividadPresupuesto";
            this.ActividadPresupuesto.ReadOnly = true;
            // 
            // Latitud
            // 
            this.Latitud.DataPropertyName = "Latitud";
            this.Latitud.HeaderText = "Latitud";
            this.Latitud.Name = "Latitud";
            this.Latitud.ReadOnly = true;
            this.Latitud.Width = 80;
            // 
            // Longitud
            // 
            this.Longitud.DataPropertyName = "Longitud";
            this.Longitud.HeaderText = "Longitud";
            this.Longitud.Name = "Longitud";
            this.Longitud.ReadOnly = true;
            this.Longitud.Width = 80;
            // 
            // dgvTramos
            // 
            this.dgvTramos.AllowUserToAddRows = false;
            this.dgvTramos.AllowUserToDeleteRows = false;
            this.dgvTramos.AllowUserToResizeColumns = false;
            this.dgvTramos.AllowUserToResizeRows = false;
            this.dgvTramos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvTramos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTramos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTramos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle58;
            this.dgvTramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTramos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTramo,
            this.CodigoTramo,
            this.ParadaOrigen,
            this.ParadaDestino,
            this.LogitudTramo,
            this.DuracionTramo});
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTramos.DefaultCellStyle = dataGridViewCellStyle59;
            this.dgvTramos.EnableHeadersVisualStyles = false;
            this.dgvTramos.Location = new System.Drawing.Point(25, 217);
            this.dgvTramos.Name = "dgvTramos";
            this.dgvTramos.ReadOnly = true;
            this.dgvTramos.RowHeadersVisible = false;
            this.dgvTramos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTramos.Size = new System.Drawing.Size(568, 191);
            this.dgvTramos.TabIndex = 299;
            // 
            // lblParadas
            // 
            this.lblParadas.AutoSize = true;
            this.lblParadas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.lblParadas.Location = new System.Drawing.Point(48, 16);
            this.lblParadas.Name = "lblParadas";
            this.lblParadas.Size = new System.Drawing.Size(72, 19);
            this.lblParadas.TabIndex = 300;
            this.lblParadas.Text = "Paradas";
            // 
            // lblTramos
            // 
            this.lblTramos.AutoSize = true;
            this.lblTramos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.lblTramos.Location = new System.Drawing.Point(48, 195);
            this.lblTramos.Name = "lblTramos";
            this.lblTramos.Size = new System.Drawing.Size(66, 19);
            this.lblTramos.TabIndex = 301;
            this.lblTramos.Text = "Tramos";
            // 
            // lblRutas
            // 
            this.lblRutas.AutoSize = true;
            this.lblRutas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.lblRutas.Location = new System.Drawing.Point(48, 422);
            this.lblRutas.Name = "lblRutas";
            this.lblRutas.Size = new System.Drawing.Size(123, 19);
            this.lblRutas.TabIndex = 302;
            this.lblRutas.Text = "Rutas / Tramos";
            // 
            // dgvRutas
            // 
            this.dgvRutas.AllowUserToAddRows = false;
            this.dgvRutas.AllowUserToDeleteRows = false;
            this.dgvRutas.AllowUserToResizeColumns = false;
            this.dgvRutas.AllowUserToResizeRows = false;
            this.dgvRutas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvRutas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRutas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRutas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle60;
            this.dgvRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle61.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRutas.DefaultCellStyle = dataGridViewCellStyle61;
            this.dgvRutas.EnableHeadersVisualStyles = false;
            this.dgvRutas.Location = new System.Drawing.Point(25, 444);
            this.dgvRutas.Name = "dgvRutas";
            this.dgvRutas.ReadOnly = true;
            this.dgvRutas.RowHeadersVisible = false;
            this.dgvRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRutas.Size = new System.Drawing.Size(568, 129);
            this.dgvRutas.TabIndex = 303;
            this.dgvRutas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRutas_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdRuta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dgvTramosRuta
            // 
            this.dgvTramosRuta.AllowUserToAddRows = false;
            this.dgvTramosRuta.AllowUserToDeleteRows = false;
            this.dgvTramosRuta.AllowUserToResizeColumns = false;
            this.dgvTramosRuta.AllowUserToResizeRows = false;
            this.dgvTramosRuta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvTramosRuta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTramosRuta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTramosRuta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle62;
            this.dgvTramosRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTramosRuta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTramosRuta.DefaultCellStyle = dataGridViewCellStyle63;
            this.dgvTramosRuta.EnableHeadersVisualStyles = false;
            this.dgvTramosRuta.Location = new System.Drawing.Point(613, 444);
            this.dgvTramosRuta.Name = "dgvTramosRuta";
            this.dgvTramosRuta.ReadOnly = true;
            this.dgvTramosRuta.RowHeadersVisible = false;
            this.dgvTramosRuta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTramosRuta.Size = new System.Drawing.Size(598, 129);
            this.dgvTramosRuta.TabIndex = 304;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdTramo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Código";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdOrigen";
            this.dataGridViewTextBoxColumn6.HeaderText = "Parada Origen";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 130;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdDestino";
            this.dataGridViewTextBoxColumn7.HeaderText = "Parada Destino";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 130;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Longitud";
            this.dataGridViewTextBoxColumn8.HeaderText = "Longitud";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Duracion";
            this.dataGridViewTextBoxColumn9.HeaderText = "Duración (min.)";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 130;
            // 
            // dgvCaminoMinimo
            // 
            this.dgvCaminoMinimo.AllowUserToAddRows = false;
            this.dgvCaminoMinimo.AllowUserToDeleteRows = false;
            this.dgvCaminoMinimo.AllowUserToResizeColumns = false;
            this.dgvCaminoMinimo.AllowUserToResizeRows = false;
            this.dgvCaminoMinimo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCaminoMinimo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvCaminoMinimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCaminoMinimo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle64.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaminoMinimo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle64;
            this.dgvCaminoMinimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle65.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaminoMinimo.DefaultCellStyle = dataGridViewCellStyle65;
            this.dgvCaminoMinimo.EnableHeadersVisualStyles = false;
            this.dgvCaminoMinimo.Location = new System.Drawing.Point(629, 61);
            this.dgvCaminoMinimo.Name = "dgvCaminoMinimo";
            this.dgvCaminoMinimo.ReadOnly = true;
            dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle66.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle66.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle66.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle66.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaminoMinimo.RowHeadersDefaultCellStyle = dataGridViewCellStyle66;
            this.dgvCaminoMinimo.RowHeadersVisible = false;
            this.dgvCaminoMinimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCaminoMinimo.Size = new System.Drawing.Size(443, 362);
            this.dgvCaminoMinimo.TabIndex = 305;
            this.dgvCaminoMinimo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaminoMinimo_CellClick);
            // 
            // lstRuta
            // 
            this.lstRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lstRuta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstRuta.FormattingEnabled = true;
            this.lstRuta.Location = new System.Drawing.Point(1084, 89);
            this.lstRuta.Name = "lstRuta";
            this.lstRuta.Size = new System.Drawing.Size(271, 273);
            this.lstRuta.TabIndex = 306;
            // 
            // lblCaminoMinimo
            // 
            this.lblCaminoMinimo.AutoSize = true;
            this.lblCaminoMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaminoMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.lblCaminoMinimo.Location = new System.Drawing.Point(625, 16);
            this.lblCaminoMinimo.Name = "lblCaminoMinimo";
            this.lblCaminoMinimo.Size = new System.Drawing.Size(254, 19);
            this.lblCaminoMinimo.TabIndex = 307;
            this.lblCaminoMinimo.Text = "Camino Mínimo (Floyd-Warshall)";
            // 
            // lblRutaMinima
            // 
            this.lblRutaMinima.AutoSize = true;
            this.lblRutaMinima.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaMinima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.lblRutaMinima.Location = new System.Drawing.Point(1080, 61);
            this.lblRutaMinima.Name = "lblRutaMinima";
            this.lblRutaMinima.Size = new System.Drawing.Size(104, 19);
            this.lblRutaMinima.TabIndex = 308;
            this.lblRutaMinima.Text = "Ruta mínima";
            // 
            // chkBucle
            // 
            this.chkBucle.AutoSize = true;
            this.chkBucle.Location = new System.Drawing.Point(629, 38);
            this.chkBucle.Name = "chkBucle";
            this.chkBucle.Size = new System.Drawing.Size(225, 17);
            this.chkBucle.TabIndex = 309;
            this.chkBucle.Text = "Calcula ruta minima de un nodo a si mismo";
            this.chkBucle.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RedTransporte.Properties.Resources.bus_stop;
            this.pictureBox1.Location = new System.Drawing.Point(25, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 310;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RedTransporte.Properties.Resources.map_marker_distance;
            this.pictureBox2.Location = new System.Drawing.Point(25, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 311;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RedTransporte.Properties.Resources.map_marker_path;
            this.pictureBox3.Location = new System.Drawing.Point(25, 419);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 312;
            this.pictureBox3.TabStop = false;
            // 
            // IdTramo
            // 
            this.IdTramo.DataPropertyName = "IdTramo";
            this.IdTramo.HeaderText = "Id";
            this.IdTramo.Name = "IdTramo";
            this.IdTramo.ReadOnly = true;
            this.IdTramo.Width = 40;
            // 
            // CodigoTramo
            // 
            this.CodigoTramo.DataPropertyName = "Codigo";
            this.CodigoTramo.HeaderText = "Código";
            this.CodigoTramo.Name = "CodigoTramo";
            this.CodigoTramo.ReadOnly = true;
            this.CodigoTramo.Width = 70;
            // 
            // ParadaOrigen
            // 
            this.ParadaOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ParadaOrigen.DataPropertyName = "IdOrigen";
            this.ParadaOrigen.HeaderText = "Origen";
            this.ParadaOrigen.Name = "ParadaOrigen";
            this.ParadaOrigen.ReadOnly = true;
            // 
            // ParadaDestino
            // 
            this.ParadaDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ParadaDestino.DataPropertyName = "IdDestino";
            this.ParadaDestino.HeaderText = "Destino";
            this.ParadaDestino.Name = "ParadaDestino";
            this.ParadaDestino.ReadOnly = true;
            // 
            // LogitudTramo
            // 
            this.LogitudTramo.DataPropertyName = "Longitud";
            this.LogitudTramo.HeaderText = "Longitud";
            this.LogitudTramo.Name = "LogitudTramo";
            this.LogitudTramo.ReadOnly = true;
            this.LogitudTramo.Width = 80;
            // 
            // DuracionTramo
            // 
            this.DuracionTramo.DataPropertyName = "Duracion";
            this.DuracionTramo.HeaderText = "Duración (min.)";
            this.DuracionTramo.Name = "DuracionTramo";
            this.DuracionTramo.ReadOnly = true;
            this.DuracionTramo.Width = 130;
            // 
            // Bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1409, 607);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkBucle);
            this.Controls.Add(this.lblRutaMinima);
            this.Controls.Add(this.lblCaminoMinimo);
            this.Controls.Add(this.lstRuta);
            this.Controls.Add(this.dgvCaminoMinimo);
            this.Controls.Add(this.dgvTramosRuta);
            this.Controls.Add(this.dgvRutas);
            this.Controls.Add(this.lblRutas);
            this.Controls.Add(this.lblTramos);
            this.Controls.Add(this.lblParadas);
            this.Controls.Add(this.dgvTramos);
            this.Controls.Add(this.dgvParadas);
            this.Controls.Add(this.btnCaminoMinimo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Bus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramosRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminoMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCaminoMinimo;
        internal System.Windows.Forms.DataGridView dgvParadas;
        internal System.Windows.Forms.DataGridView dgvTramos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActividadPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitud;
        private System.Windows.Forms.Label lblParadas;
        private System.Windows.Forms.Label lblTramos;
        private System.Windows.Forms.Label lblRutas;
        internal System.Windows.Forms.DataGridView dgvRutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        internal System.Windows.Forms.DataGridView dgvTramosRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        internal System.Windows.Forms.DataGridView dgvCaminoMinimo;
        private System.Windows.Forms.ListBox lstRuta;
        private System.Windows.Forms.Label lblCaminoMinimo;
        private System.Windows.Forms.Label lblRutaMinima;
        private System.Windows.Forms.CheckBox chkBucle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTramo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoTramo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParadaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParadaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogitudTramo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionTramo;
    }
}

