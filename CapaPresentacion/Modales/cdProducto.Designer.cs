namespace CapaPresentacion.Modales
{
    partial class cdProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.Busqueda = new System.Windows.Forms.Label();
            this.iconBorrar = new FontAwesome.Sharp.IconButton();
            this.iconBusqueda = new FontAwesome.Sharp.IconButton();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label2.Text = "Productos:";
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
            this.gridProductos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Stock,
            this.Stock_min,
            this.Precio,
            this.Menu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridProductos.Location = new System.Drawing.Point(12, 105);
            this.gridProductos.MultiSelect = false;
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.gridProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridProductos.RowTemplate.Height = 30;
            this.gridProductos.Size = new System.Drawing.Size(927, 428);
            this.gridProductos.TabIndex = 60;
            this.gridProductos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridProductos_CellMouseDoubleClick_1);
            // 
            // Id
            // 
            this.Id.HeaderText = "IdProducto";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Visible = false;
            this.Stock.Width = 125;
            // 
            // Stock_min
            // 
            this.Stock_min.HeaderText = "Stock Minimo";
            this.Stock_min.MinimumWidth = 6;
            this.Stock_min.Name = "Stock_min";
            this.Stock_min.ReadOnly = true;
            this.Stock_min.Visible = false;
            this.Stock_min.Width = 125;
            // 
            // Precio
            // 
            dataGridViewCellStyle2.Format = "N2";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Visible = false;
            this.Precio.Width = 125;
            // 
            // Menu
            // 
            this.Menu.HeaderText = "Menu";
            this.Menu.MinimumWidth = 6;
            this.Menu.Name = "Menu";
            this.Menu.ReadOnly = true;
            this.Menu.Width = 200;
            // 
            // cdProducto
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
            this.Name = "cdProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdProducto";
            this.Load += new System.EventHandler(this.cdProducto_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu;
    }
}