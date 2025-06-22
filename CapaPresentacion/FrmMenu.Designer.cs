namespace CapaPresentacion
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.limpiarCampos = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconBorrar = new FontAwesome.Sharp.IconButton();
            this.Busqueda = new System.Windows.Forms.Label();
            this.iconBusqueda = new FontAwesome.Sharp.IconButton();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridCategorias = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 29);
            this.label8.TabIndex = 32;
            this.label8.Text = "MENU";
            // 
            // limpiarCampos
            // 
            this.limpiarCampos.BackColor = System.Drawing.Color.Black;
            this.limpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarCampos.ForeColor = System.Drawing.Color.White;
            this.limpiarCampos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.limpiarCampos.IconColor = System.Drawing.Color.Black;
            this.limpiarCampos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.limpiarCampos.Location = new System.Drawing.Point(21, 872);
            this.limpiarCampos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.limpiarCampos.Name = "limpiarCampos";
            this.limpiarCampos.Size = new System.Drawing.Size(451, 54);
            this.limpiarCampos.TabIndex = 31;
            this.limpiarCampos.Text = "LIMPIAR CAMPOS";
            this.limpiarCampos.UseVisualStyleBackColor = false;
            this.limpiarCampos.Click += new System.EventHandler(this.limpiarCampos_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.Black;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnguardar.IconColor = System.Drawing.Color.Transparent;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.Location = new System.Drawing.Point(21, 677);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(451, 53);
            this.btnguardar.TabIndex = 30;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(32, 228);
            this.cboestado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(440, 37);
            this.cboestado.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Estado:";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(32, 123);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(440, 32);
            this.txtnombre.TabIndex = 23;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.Location = new System.Drawing.Point(21, 741);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(451, 53);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconBorrar);
            this.groupBox1.Controls.Add(this.Busqueda);
            this.groupBox1.Controls.Add(this.iconBusqueda);
            this.groupBox1.Controls.Add(this.textBusqueda);
            this.groupBox1.Controls.Add(this.cboBusqueda);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(565, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1389, 82);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // iconBorrar
            // 
            this.iconBorrar.BackColor = System.Drawing.Color.White;
            this.iconBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBorrar.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBorrar.ForeColor = System.Drawing.Color.White;
            this.iconBorrar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconBorrar.IconColor = System.Drawing.Color.Black;
            this.iconBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBorrar.IconSize = 29;
            this.iconBorrar.Location = new System.Drawing.Point(1107, 28);
            this.iconBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconBorrar.Name = "iconBorrar";
            this.iconBorrar.Size = new System.Drawing.Size(35, 30);
            this.iconBorrar.TabIndex = 72;
            this.iconBorrar.UseVisualStyleBackColor = false;
            this.iconBorrar.Click += new System.EventHandler(this.iconBorrar_Click);
            // 
            // Busqueda
            // 
            this.Busqueda.AutoSize = true;
            this.Busqueda.BackColor = System.Drawing.Color.White;
            this.Busqueda.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Busqueda.Location = new System.Drawing.Point(436, 34);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(110, 24);
            this.Busqueda.TabIndex = 68;
            this.Busqueda.Text = "Buscar por:";
            // 
            // iconBusqueda
            // 
            this.iconBusqueda.BackColor = System.Drawing.Color.White;
            this.iconBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBusqueda.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBusqueda.ForeColor = System.Drawing.Color.White;
            this.iconBusqueda.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iconBusqueda.IconColor = System.Drawing.Color.Black;
            this.iconBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBusqueda.IconSize = 29;
            this.iconBusqueda.Location = new System.Drawing.Point(1051, 28);
            this.iconBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconBusqueda.Name = "iconBusqueda";
            this.iconBusqueda.Size = new System.Drawing.Size(39, 30);
            this.iconBusqueda.TabIndex = 71;
            this.iconBusqueda.UseVisualStyleBackColor = false;
            this.iconBusqueda.Click += new System.EventHandler(this.iconBusqueda_Click);
            // 
            // textBusqueda
            // 
            this.textBusqueda.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBusqueda.Location = new System.Drawing.Point(815, 26);
            this.textBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(183, 32);
            this.textBusqueda.TabIndex = 70;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(587, 26);
            this.cboBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(200, 32);
            this.cboBusqueda.TabIndex = 69;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridCategorias);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(565, 166);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1389, 674);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado";
            // 
            // gridCategorias
            // 
            this.gridCategorias.AllowUserToAddRows = false;
            this.gridCategorias.AllowUserToDeleteRows = false;
            this.gridCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSeleccionar,
            this.Id,
            this.Nombre,
            this.EstadoValor,
            this.Estado});
            this.gridCategorias.Location = new System.Drawing.Point(12, 31);
            this.gridCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridCategorias.MultiSelect = false;
            this.gridCategorias.Name = "gridCategorias";
            this.gridCategorias.ReadOnly = true;
            this.gridCategorias.RowHeadersWidth = 51;
            this.gridCategorias.RowTemplate.Height = 24;
            this.gridCategorias.Size = new System.Drawing.Size(1377, 629);
            this.gridCategorias.TabIndex = 0;
            this.gridCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCategorias_CellContentClick);
            this.gridCategorias.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gridCategorias_CellPainting);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.HeaderText = "";
            this.BtnSeleccionar.MinimumWidth = 6;
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ReadOnly = true;
            this.BtnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtnSeleccionar.Width = 50;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 300;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.MinimumWidth = 6;
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            this.EstadoValor.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 950);
            this.label1.TabIndex = 17;
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(275, 50);
            this.txtIndice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIndice.Multiline = true;
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(29, 32);
            this.txtIndice.TabIndex = 40;
            this.txtIndice.Text = "-1";
            this.txtIndice.Visible = false;
            // 
            // textId
            // 
            this.textId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId.Location = new System.Drawing.Point(315, 48);
            this.textId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(43, 27);
            this.textId.TabIndex = 67;
            this.textId.Text = "0";
            this.textId.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-115, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 28);
            this.label4.TabIndex = 61;
            this.label4.Text = "Estado:";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(2553, 950);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.limpiarCampos);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton limpiarCampos;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndice;
        private FontAwesome.Sharp.IconButton iconBorrar;
        private System.Windows.Forms.Label Busqueda;
        private FontAwesome.Sharp.IconButton iconBusqueda;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}