namespace CapaPresentacion
{
    partial class FormProductos
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
            this.GB_registroProd = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_cosultaProd = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GB_listaProd = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TBconsultaprod = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtstockmin = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.CBbusquedamenu = new System.Windows.Forms.ComboBox();
            this.cbmenu = new System.Windows.Forms.ComboBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnmodif = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.GB_registroProd.SuspendLayout();
            this.GB_cosultaProd.SuspendLayout();
            this.GB_listaProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_registroProd
            // 
            this.GB_registroProd.Controls.Add(this.btneliminar);
            this.GB_registroProd.Controls.Add(this.btnmodif);
            this.GB_registroProd.Controls.Add(this.btnregistrar);
            this.GB_registroProd.Controls.Add(this.txtdescripcion);
            this.GB_registroProd.Controls.Add(this.label12);
            this.GB_registroProd.Controls.Add(this.label13);
            this.GB_registroProd.Controls.Add(this.label14);
            this.GB_registroProd.Controls.Add(this.label15);
            this.GB_registroProd.Controls.Add(this.cbmenu);
            this.GB_registroProd.Controls.Add(this.txtnombre);
            this.GB_registroProd.Controls.Add(this.txtstock);
            this.GB_registroProd.Controls.Add(this.txtstockmin);
            this.GB_registroProd.Controls.Add(this.txtcodigo);
            this.GB_registroProd.Controls.Add(this.label11);
            this.GB_registroProd.Controls.Add(this.label10);
            this.GB_registroProd.Controls.Add(this.label9);
            this.GB_registroProd.Controls.Add(this.label8);
            this.GB_registroProd.Controls.Add(this.label5);
            this.GB_registroProd.Controls.Add(this.label4);
            this.GB_registroProd.Controls.Add(this.label3);
            this.GB_registroProd.Controls.Add(this.label2);
            this.GB_registroProd.Controls.Add(this.label1);
            this.GB_registroProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_registroProd.Location = new System.Drawing.Point(12, 12);
            this.GB_registroProd.Name = "GB_registroProd";
            this.GB_registroProd.Size = new System.Drawing.Size(305, 561);
            this.GB_registroProd.TabIndex = 0;
            this.GB_registroProd.TabStop = false;
            this.GB_registroProd.Text = "Producto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Stock min.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Stock";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Menu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GB_cosultaProd
            // 
            this.GB_cosultaProd.Controls.Add(this.btnbuscar);
            this.GB_cosultaProd.Controls.Add(this.CBbusquedamenu);
            this.GB_cosultaProd.Controls.Add(this.textBox1);
            this.GB_cosultaProd.Controls.Add(this.TBconsultaprod);
            this.GB_cosultaProd.Controls.Add(this.label6);
            this.GB_cosultaProd.Controls.Add(this.label7);
            this.GB_cosultaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_cosultaProd.Location = new System.Drawing.Point(323, 12);
            this.GB_cosultaProd.Name = "GB_cosultaProd";
            this.GB_cosultaProd.Size = new System.Drawing.Size(795, 81);
            this.GB_cosultaProd.TabIndex = 1;
            this.GB_cosultaProd.TabStop = false;
            this.GB_cosultaProd.Text = "Consulta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Menu";
            // 
            // GB_listaProd
            // 
            this.GB_listaProd.Controls.Add(this.dataGridView1);
            this.GB_listaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_listaProd.Location = new System.Drawing.Point(323, 99);
            this.GB_listaProd.Name = "GB_listaProd";
            this.GB_listaProd.Size = new System.Drawing.Size(795, 474);
            this.GB_listaProd.TabIndex = 1;
            this.GB_listaProd.TabStop = false;
            this.GB_listaProd.Text = "Listado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(783, 439);
            this.dataGridView1.TabIndex = 0;
            // 
            // TBconsultaprod
            // 
            this.TBconsultaprod.Location = new System.Drawing.Point(88, 31);
            this.TBconsultaprod.Multiline = true;
            this.TBconsultaprod.Name = "TBconsultaprod";
            this.TBconsultaprod.Size = new System.Drawing.Size(150, 22);
            this.TBconsultaprod.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(373, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 0);
            this.textBox1.TabIndex = 8;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(107, 100);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(150, 22);
            this.txtnombre.TabIndex = 9;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(107, 205);
            this.txtstock.Multiline = true;
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(150, 22);
            this.txtstock.TabIndex = 11;
            // 
            // txtstockmin
            // 
            this.txtstockmin.Location = new System.Drawing.Point(107, 256);
            this.txtstockmin.Multiline = true;
            this.txtstockmin.Name = "txtstockmin";
            this.txtstockmin.Size = new System.Drawing.Size(150, 22);
            this.txtstockmin.TabIndex = 12;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(107, 54);
            this.txtcodigo.Multiline = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(150, 22);
            this.txtcodigo.TabIndex = 13;
            // 
            // CBbusquedamenu
            // 
            this.CBbusquedamenu.FormattingEnabled = true;
            this.CBbusquedamenu.Location = new System.Drawing.Point(337, 26);
            this.CBbusquedamenu.Name = "CBbusquedamenu";
            this.CBbusquedamenu.Size = new System.Drawing.Size(155, 33);
            this.CBbusquedamenu.TabIndex = 9;
            this.CBbusquedamenu.Text = "--Seleccione--";
            // 
            // cbmenu
            // 
            this.cbmenu.FormattingEnabled = true;
            this.cbmenu.ItemHeight = 26;
            this.cbmenu.Location = new System.Drawing.Point(107, 153);
            this.cbmenu.Name = "cbmenu";
            this.cbmenu.Size = new System.Drawing.Size(150, 34);
            this.cbmenu.TabIndex = 14;
            this.cbmenu.Text = "Seleccione";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(107, 305);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(150, 75);
            this.txtdescripcion.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 307);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Descripcion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(70, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 29);
            this.label13.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(70, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 29);
            this.label14.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 298);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 29);
            this.label15.TabIndex = 15;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(84, 417);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(101, 29);
            this.btnregistrar.TabIndex = 20;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            // 
            // btnmodif
            // 
            this.btnmodif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodif.Location = new System.Drawing.Point(10, 465);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.Size = new System.Drawing.Size(101, 29);
            this.btnmodif.TabIndex = 21;
            this.btnmodif.Text = "Modificar";
            this.btnmodif.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(156, 465);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(101, 29);
            this.btneliminar.TabIndex = 22;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(615, 29);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(101, 29);
            this.btnbuscar.TabIndex = 23;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 585);
            this.Controls.Add(this.GB_listaProd);
            this.Controls.Add(this.GB_cosultaProd);
            this.Controls.Add(this.GB_registroProd);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.GB_registroProd.ResumeLayout(false);
            this.GB_registroProd.PerformLayout();
            this.GB_cosultaProd.ResumeLayout(false);
            this.GB_cosultaProd.PerformLayout();
            this.GB_listaProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_registroProd;
        private System.Windows.Forms.GroupBox GB_cosultaProd;
        private System.Windows.Forms.GroupBox GB_listaProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtstockmin;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TBconsultaprod;
        private System.Windows.Forms.ComboBox cbmenu;
        private System.Windows.Forms.ComboBox CBbusquedamenu;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodif;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnbuscar;
    }
}