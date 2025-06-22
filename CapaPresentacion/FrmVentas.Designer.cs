namespace CapaPresentacion
{
    partial class FrmVentas
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
            this.tituloVenta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridVentas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.informacionVenta = new System.Windows.Forms.GroupBox();
            this.textVendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textfecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.informacionProducto = new System.Windows.Forms.GroupBox();
            this.cantStock = new System.Windows.Forms.Label();
            this.txtStockDisponible = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textProducto = new System.Windows.Forms.TextBox();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.iconAgregar = new FontAwesome.Sharp.IconButton();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.cancelarCompra = new FontAwesome.Sharp.IconButton();
            this.iconBorrar = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cboPago = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idMesa = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.idMesa2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cant = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).BeginInit();
            this.informacionVenta.SuspendLayout();
            this.informacionProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloVenta
            // 
            this.tituloVenta.AutoSize = true;
            this.tituloVenta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloVenta.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloVenta.Location = new System.Drawing.Point(369, 69);
            this.tituloVenta.Name = "tituloVenta";
            this.tituloVenta.Size = new System.Drawing.Size(252, 28);
            this.tituloVenta.TabIndex = 77;
            this.tituloVenta.Text = "REGISTRAR PEDIDO";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1581, 875);
            this.label2.TabIndex = 79;
            // 
            // gridVentas
            // 
            this.gridVentas.AllowUserToAddRows = false;
            this.gridVentas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Id,
            this.Producto,
            this.Stock,
            this.Precio,
            this.Subtotal,
            this.btnEliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridVentas.EnableHeadersVisualStyles = false;
            this.gridVentas.Location = new System.Drawing.Point(374, 397);
            this.gridVentas.MultiSelect = false;
            this.gridVentas.Name = "gridVentas";
            this.gridVentas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.gridVentas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridVentas.RowTemplate.Height = 30;
            this.gridVentas.Size = new System.Drawing.Size(1312, 443);
            this.gridVentas.TabIndex = 78;
            this.gridVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVentas_CellContentClick);
            this.gridVentas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gridVentas_CellPainting);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "btnSeleccion";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Id
            // 
            this.Id.HeaderText = "IdProducto";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 10;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 350;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Cantidad";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 125;
            // 
            // Precio
            // 
            dataGridViewCellStyle2.Format = "N2";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 150;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 200;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.MinimumWidth = 6;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 50;
            // 
            // informacionVenta
            // 
            this.informacionVenta.BackColor = System.Drawing.Color.White;
            this.informacionVenta.Controls.Add(this.textVendedor);
            this.informacionVenta.Controls.Add(this.label3);
            this.informacionVenta.Controls.Add(this.textfecha);
            this.informacionVenta.Controls.Add(this.label1);
            this.informacionVenta.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacionVenta.Location = new System.Drawing.Point(374, 116);
            this.informacionVenta.Name = "informacionVenta";
            this.informacionVenta.Size = new System.Drawing.Size(595, 126);
            this.informacionVenta.TabIndex = 96;
            this.informacionVenta.TabStop = false;
            this.informacionVenta.Text = "Información Pedido";
            // 
            // textVendedor
            // 
            this.textVendedor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVendedor.Location = new System.Drawing.Point(180, 75);
            this.textVendedor.Multiline = true;
            this.textVendedor.Name = "textVendedor";
            this.textVendedor.Size = new System.Drawing.Size(406, 32);
            this.textVendedor.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mozo:";
            // 
            // textfecha
            // 
            this.textfecha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textfecha.Location = new System.Drawing.Point(12, 75);
            this.textfecha.Name = "textfecha";
            this.textfecha.Size = new System.Drawing.Size(147, 32);
            this.textfecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // informacionProducto
            // 
            this.informacionProducto.BackColor = System.Drawing.Color.White;
            this.informacionProducto.Controls.Add(this.cantStock);
            this.informacionProducto.Controls.Add(this.txtStockDisponible);
            this.informacionProducto.Controls.Add(this.cantidad);
            this.informacionProducto.Controls.Add(this.textPrecio);
            this.informacionProducto.Controls.Add(this.textProducto);
            this.informacionProducto.Controls.Add(this.txtIndice);
            this.informacionProducto.Controls.Add(this.btnBuscarProducto);
            this.informacionProducto.Controls.Add(this.label7);
            this.informacionProducto.Controls.Add(this.label6);
            this.informacionProducto.Controls.Add(this.label4);
            this.informacionProducto.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacionProducto.Location = new System.Drawing.Point(374, 260);
            this.informacionProducto.Name = "informacionProducto";
            this.informacionProducto.Size = new System.Drawing.Size(1312, 126);
            this.informacionProducto.TabIndex = 97;
            this.informacionProducto.TabStop = false;
            this.informacionProducto.Text = "Información del Pedido";
            // 
            // cantStock
            // 
            this.cantStock.AutoSize = true;
            this.cantStock.Location = new System.Drawing.Point(973, 35);
            this.cantStock.Name = "cantStock";
            this.cantStock.Size = new System.Drawing.Size(59, 24);
            this.cantStock.TabIndex = 103;
            this.cantStock.Text = "Stock";
            // 
            // txtStockDisponible
            // 
            this.txtStockDisponible.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockDisponible.Location = new System.Drawing.Point(977, 74);
            this.txtStockDisponible.Multiline = true;
            this.txtStockDisponible.Name = "txtStockDisponible";
            this.txtStockDisponible.Size = new System.Drawing.Size(86, 33);
            this.txtStockDisponible.TabIndex = 102;
            // 
            // cantidad
            // 
            this.cantidad.AutoSize = true;
            this.cantidad.Location = new System.Drawing.Point(1078, 75);
            this.cantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(151, 32);
            this.cantidad.TabIndex = 100;
            this.cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_KeyPress);
            // 
            // textPrecio
            // 
            this.textPrecio.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecio.Location = new System.Drawing.Point(767, 75);
            this.textPrecio.Multiline = true;
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(180, 32);
            this.textPrecio.TabIndex = 99;
            // 
            // textProducto
            // 
            this.textProducto.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProducto.Location = new System.Drawing.Point(12, 75);
            this.textProducto.Multiline = true;
            this.textProducto.Name = "textProducto";
            this.textProducto.Size = new System.Drawing.Size(476, 32);
            this.textProducto.TabIndex = 98;
            this.textProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textProducto_KeyDown);
            this.textProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textProducto_KeyPress);
            // 
            // txtIndice
            // 
            this.txtIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndice.Location = new System.Drawing.Point(212, 32);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(43, 27);
            this.txtIndice.TabIndex = 29;
            this.txtIndice.Text = "-1";
            this.txtIndice.Visible = false;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 36;
            this.btnBuscarProducto.Location = new System.Drawing.Point(506, 75);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(43, 32);
            this.btnBuscarProducto.TabIndex = 26;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1074, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(763, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Producto:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.White;
            this.labelTotal.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(1693, 549);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(132, 24);
            this.labelTotal.TabIndex = 101;
            this.labelTotal.Text = "Total a pagar:";
            // 
            // textTotal
            // 
            this.textTotal.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal.Location = new System.Drawing.Point(1697, 596);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(206, 32);
            this.textTotal.TabIndex = 101;
            this.textTotal.Text = "0";
            // 
            // iconAgregar
            // 
            this.iconAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconAgregar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconAgregar.IconColor = System.Drawing.Color.ForestGreen;
            this.iconAgregar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconAgregar.IconSize = 60;
            this.iconAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconAgregar.Location = new System.Drawing.Point(1709, 274);
            this.iconAgregar.Name = "iconAgregar";
            this.iconAgregar.Size = new System.Drawing.Size(145, 112);
            this.iconAgregar.TabIndex = 98;
            this.iconAgregar.Text = "Agregar";
            this.iconAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconAgregar.UseVisualStyleBackColor = true;
            this.iconAgregar.Click += new System.EventHandler(this.iconAgregar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.btnRegistrar.IconColor = System.Drawing.Color.Red;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(1697, 782);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(206, 58);
            this.btnRegistrar.TabIndex = 102;
            this.btnRegistrar.Text = "Registrar ";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cancelarCompra
            // 
            this.cancelarCompra.BackColor = System.Drawing.Color.Black;
            this.cancelarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarCompra.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.cancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarCompra.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarCompra.ForeColor = System.Drawing.Color.White;
            this.cancelarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.cancelarCompra.IconColor = System.Drawing.Color.Black;
            this.cancelarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelarCompra.Location = new System.Drawing.Point(924, 876);
            this.cancelarCompra.Name = "cancelarCompra";
            this.cancelarCompra.Size = new System.Drawing.Size(304, 43);
            this.cancelarCompra.TabIndex = 86;
            this.cancelarCompra.Text = "Cancelar pedido";
            this.cancelarCompra.UseVisualStyleBackColor = false;
            this.cancelarCompra.Click += new System.EventHandler(this.cancelarCompra_Click);
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
            this.iconBorrar.Location = new System.Drawing.Point(1709, 154);
            this.iconBorrar.Name = "iconBorrar";
            this.iconBorrar.Size = new System.Drawing.Size(35, 29);
            this.iconBorrar.TabIndex = 85;
            this.iconBorrar.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1693, 649);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 24);
            this.label10.TabIndex = 103;
            this.label10.Text = "Tipo Pago:";
            // 
            // cboPago
            // 
            this.cboPago.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPago.FormattingEnabled = true;
            this.cboPago.Location = new System.Drawing.Point(1697, 687);
            this.cboPago.Name = "cboPago";
            this.cboPago.Size = new System.Drawing.Size(206, 32);
            this.cboPago.TabIndex = 104;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cant);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.idMesa);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.idMesa2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1091, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 126);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Mesa";
            // 
            // idMesa
            // 
            this.idMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idMesa.Location = new System.Drawing.Point(127, 35);
            this.idMesa.Name = "idMesa";
            this.idMesa.Size = new System.Drawing.Size(43, 27);
            this.idMesa.TabIndex = 104;
            this.idMesa.Text = "-1";
            this.idMesa.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 36;
            this.iconButton1.Location = new System.Drawing.Point(187, 75);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(43, 32);
            this.iconButton1.TabIndex = 27;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 2;
            // 
            // idMesa2
            // 
            this.idMesa2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.idMesa2.Location = new System.Drawing.Point(12, 75);
            this.idMesa2.Name = "idMesa2";
            this.idMesa2.Size = new System.Drawing.Size(147, 32);
            this.idMesa2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mesa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 30);
            this.label9.TabIndex = 104;
            this.label9.Text = "Cant. Personas:";
            // 
            // cant
            // 
            this.cant.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cant.Location = new System.Drawing.Point(279, 75);
            this.cant.Multiline = true;
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(86, 33);
            this.cant.TabIndex = 104;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1013);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelarCompra);
            this.Controls.Add(this.cboPago);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iconAgregar);
            this.Controls.Add(this.tituloVenta);
            this.Controls.Add(this.informacionVenta);
            this.Controls.Add(this.informacionProducto);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gridVentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconBorrar);
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVentas";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).EndInit();
            this.informacionVenta.ResumeLayout(false);
            this.informacionVenta.PerformLayout();
            this.informacionProducto.ResumeLayout(false);
            this.informacionProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tituloVenta;
        private FontAwesome.Sharp.IconButton cancelarCompra;
        private FontAwesome.Sharp.IconButton iconBorrar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView gridVentas;
        private System.Windows.Forms.GroupBox informacionVenta;
        private System.Windows.Forms.TextBox textfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox informacionProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textProducto;
        private System.Windows.Forms.TextBox txtIndice;
        private FontAwesome.Sharp.IconButton iconAgregar;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textTotal;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private System.Windows.Forms.TextBox textVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboPago;
        private System.Windows.Forms.TextBox txtStockDisponible;
        private System.Windows.Forms.Label cantStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idMesa2;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox idMesa;
        private System.Windows.Forms.TextBox cant;
        private System.Windows.Forms.Label label9;
    }
}