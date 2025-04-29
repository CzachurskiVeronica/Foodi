namespace CapaPresentacion
{
    partial class FrmProducto
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
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbomenu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmodificar = new FontAwesome.Sharp.IconButton();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtstockmin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Detalle Producto";
            // 
            // btneliminar
            // 
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btneliminar.IconColor = System.Drawing.Color.Black;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.Location = new System.Drawing.Point(16, 497);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(252, 31);
            this.btneliminar.TabIndex = 31;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnguardar.IconColor = System.Drawing.Color.Black;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.Location = new System.Drawing.Point(16, 427);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(252, 30);
            this.btnguardar.TabIndex = 30;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(15, 391);
            this.cboestado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(254, 21);
            this.cboestado.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 375);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Estado:";
            // 
            // cbomenu
            // 
            this.cbomenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomenu.FormattingEnabled = true;
            this.cbomenu.Location = new System.Drawing.Point(12, 349);
            this.cbomenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbomenu.Name = "cbomenu";
            this.cbomenu.Size = new System.Drawing.Size(257, 21);
            this.cbomenu.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Menu:";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(112, 260);
            this.txtstock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtstock.Multiline = true;
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(157, 27);
            this.txtstock.TabIndex = 25;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(112, 138);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtprecio.Multiline = true;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(156, 27);
            this.txtprecio.TabIndex = 24;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(112, 86);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(156, 27);
            this.txtnombre.TabIndex = 23;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(115, 41);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcodigo.Multiline = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(154, 27);
            this.txtcodigo.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 609);
            this.label1.TabIndex = 17;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnmodificar.IconColor = System.Drawing.Color.Black;
            this.btnmodificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmodificar.Location = new System.Drawing.Point(16, 462);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(252, 30);
            this.btnmodificar.TabIndex = 33;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(112, 184);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(156, 62);
            this.txtdescripcion.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 184);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Descripcion:";
            // 
            // txtstockmin
            // 
            this.txtstockmin.Location = new System.Drawing.Point(112, 301);
            this.txtstockmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtstockmin.Multiline = true;
            this.txtstockmin.Name = "txtstockmin";
            this.txtstockmin.Size = new System.Drawing.Size(157, 27);
            this.txtstockmin.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 301);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Stock min:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtbusqueda);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(314, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(532, 67);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.Location = new System.Drawing.Point(399, 21);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(100, 30);
            this.btnbuscar.TabIndex = 31;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 24);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 25);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Text = "-Seleccione-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DodgerBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(194, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Menu:";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbusqueda.Location = new System.Drawing.Point(55, 23);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbusqueda.Multiline = true;
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(132, 27);
            this.txtbusqueda.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DodgerBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(314, 79);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(532, 462);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(856, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtstockmin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbomenu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbomenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnmodificar;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtstockmin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label11;
    }
}