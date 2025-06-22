namespace CapaPresentacion.Modales
{
    partial class cdMesas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.Busqueda = new System.Windows.Forms.Label();
            this.iconBorrar = new FontAwesome.Sharp.IconButton();
            this.iconBusqueda = new FontAwesome.Sharp.IconButton();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(927, 63);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mesas:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBusqueda
            // 
            this.textBusqueda.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBusqueda.Location = new System.Drawing.Point(628, 35);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(183, 32);
            this.textBusqueda.TabIndex = 57;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(422, 35);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(200, 32);
            this.cboBusqueda.TabIndex = 56;
            // 
            // Busqueda
            // 
            this.Busqueda.AutoSize = true;
            this.Busqueda.BackColor = System.Drawing.Color.White;
            this.Busqueda.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Busqueda.Location = new System.Drawing.Point(230, 39);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(110, 24);
            this.Busqueda.TabIndex = 55;
            this.Busqueda.Text = "Buscar por:";
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
            this.iconBorrar.Location = new System.Drawing.Point(896, 36);
            this.iconBorrar.Name = "iconBorrar";
            this.iconBorrar.Size = new System.Drawing.Size(35, 29);
            this.iconBorrar.TabIndex = 59;
            this.iconBorrar.UseVisualStyleBackColor = false;
            this.iconBorrar.Click += new System.EventHandler(this.iconBorrar_Click_1);
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
            this.iconBusqueda.Location = new System.Drawing.Point(842, 36);
            this.iconBusqueda.Name = "iconBusqueda";
            this.iconBusqueda.Size = new System.Drawing.Size(39, 29);
            this.iconBusqueda.TabIndex = 58;
            this.iconBusqueda.UseVisualStyleBackColor = false;
            this.iconBusqueda.Click += new System.EventHandler(this.iconBusqueda_Click_1);
            // 
            // gridProductos
            // 
            this.gridProductos.AllowUserToAddRows = false;
            this.gridProductos.AllowUserToDeleteRows = false;
            this.gridProductos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSeleccionar,
            this.nro,
            this.cant,
            this.EstadoValor,
            this.Estado,
            this.EstadoValor2,
            this.Estado2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridProductos.Location = new System.Drawing.Point(12, 95);
            this.gridProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridProductos.MultiSelect = false;
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.RowHeadersWidth = 51;
            this.gridProductos.RowTemplate.Height = 24;
            this.gridProductos.Size = new System.Drawing.Size(927, 377);
            this.gridProductos.TabIndex = 61;
            this.gridProductos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridProductos_CellMouseDoubleClick);
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
            // nro
            // 
            this.nro.HeaderText = "Nro Mesa";
            this.nro.MinimumWidth = 6;
            this.nro.Name = "nro";
            this.nro.ReadOnly = true;
            this.nro.Width = 200;
            // 
            // cant
            // 
            this.cant.HeaderText = "Cant. Personas";
            this.cant.MinimumWidth = 6;
            this.cant.Name = "cant";
            this.cant.ReadOnly = true;
            this.cant.Width = 250;
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
            this.Estado.HeaderText = "Ocupado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            this.Estado.Width = 175;
            // 
            // EstadoValor2
            // 
            this.EstadoValor2.HeaderText = "EstadoValor2";
            this.EstadoValor2.MinimumWidth = 6;
            this.EstadoValor2.Name = "EstadoValor2";
            this.EstadoValor2.ReadOnly = true;
            this.EstadoValor2.Visible = false;
            this.EstadoValor2.Width = 125;
            // 
            // Estado2
            // 
            this.Estado2.HeaderText = "Estado";
            this.Estado2.MinimumWidth = 6;
            this.Estado2.Name = "Estado2";
            this.Estado2.ReadOnly = true;
            this.Estado2.Visible = false;
            this.Estado2.Width = 175;
            // 
            // cdMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 545);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.iconBorrar);
            this.Controls.Add(this.iconBusqueda);
            this.Controls.Add(this.textBusqueda);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.label2);
            this.Name = "cdMesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdMesas";
            this.Load += new System.EventHandler(this.cdMesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconBorrar;
        private FontAwesome.Sharp.IconButton iconBusqueda;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Label Busqueda;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado2;
    }
}