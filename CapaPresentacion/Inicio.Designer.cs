namespace CapaPresentacion
{
    partial class Inicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuusuario = new FontAwesome.Sharp.IconMenuItem();
            this.menumenu = new FontAwesome.Sharp.IconMenuItem();
            this.menuproductos = new FontAwesome.Sharp.IconMenuItem();
            this.iconMesas = new FontAwesome.Sharp.IconMenuItem();
            this.menuacerca = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPagos = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuario,
            this.menumenu,
            this.menuproductos,
            this.iconPagos,
            this.iconMesas,
            this.menuacerca});
            this.menu.Location = new System.Drawing.Point(0, 103);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(2579, 108);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuusuario
            // 
            this.menuusuario.AutoSize = false;
            this.menuusuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuusuario.ForeColor = System.Drawing.Color.Black;
            this.menuusuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.menuusuario.IconColor = System.Drawing.Color.Black;
            this.menuusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuario.IconSize = 60;
            this.menuusuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuario.Name = "menuusuario";
            this.menuusuario.Size = new System.Drawing.Size(150, 100);
            this.menuusuario.Text = "Usuarios";
            this.menuusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuusuario.Click += new System.EventHandler(this.menuusuario_Click);
            this.menuusuario.MouseEnter += new System.EventHandler(this.menuusuario_MouseEnter);
            // 
            // menumenu
            // 
            this.menumenu.AutoSize = false;
            this.menumenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menumenu.ForeColor = System.Drawing.Color.Black;
            this.menumenu.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.menumenu.IconColor = System.Drawing.Color.Black;
            this.menumenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumenu.IconSize = 60;
            this.menumenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumenu.Name = "menumenu";
            this.menumenu.Size = new System.Drawing.Size(150, 100);
            this.menumenu.Text = "Menu";
            this.menumenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menumenu.Click += new System.EventHandler(this.menumenu_Click);
            this.menumenu.MouseEnter += new System.EventHandler(this.menumenu_MouseEnter);
            // 
            // menuproductos
            // 
            this.menuproductos.AutoSize = false;
            this.menuproductos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuproductos.ForeColor = System.Drawing.Color.Black;
            this.menuproductos.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.menuproductos.IconColor = System.Drawing.Color.Black;
            this.menuproductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproductos.IconSize = 60;
            this.menuproductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproductos.Name = "menuproductos";
            this.menuproductos.Size = new System.Drawing.Size(150, 100);
            this.menuproductos.Text = "Productos";
            this.menuproductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuproductos.Click += new System.EventHandler(this.menuproductos_Click);
            this.menuproductos.MouseEnter += new System.EventHandler(this.menuproductos_MouseEnter);
            // 
            // iconMesas
            // 
            this.iconMesas.AutoSize = false;
            this.iconMesas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iconMesas.ForeColor = System.Drawing.Color.Black;
            this.iconMesas.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.iconMesas.IconColor = System.Drawing.Color.Black;
            this.iconMesas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMesas.IconSize = 60;
            this.iconMesas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMesas.Name = "iconMesas";
            this.iconMesas.Size = new System.Drawing.Size(150, 100);
            this.iconMesas.Text = "Mesas";
            this.iconMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMesas.Click += new System.EventHandler(this.iconMesas_Click);
            this.iconMesas.MouseEnter += new System.EventHandler(this.iconMenuItem1_MouseEnter);
            // 
            // menuacerca
            // 
            this.menuacerca.AutoSize = false;
            this.menuacerca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuacerca.ForeColor = System.Drawing.Color.Black;
            this.menuacerca.IconChar = FontAwesome.Sharp.IconChar.Sketch;
            this.menuacerca.IconColor = System.Drawing.Color.Black;
            this.menuacerca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuacerca.IconSize = 60;
            this.menuacerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuacerca.Name = "menuacerca";
            this.menuacerca.Size = new System.Drawing.Size(150, 100);
            this.menuacerca.Text = "Acerca de";
            this.menuacerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuacerca.MouseEnter += new System.EventHandler(this.menuacerca_MouseEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(2579, 103);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1228, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "FOODIE";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(2332, 65);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(81, 29);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "label2";
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(0, 222);
            this.contenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(2567, 1120);
            this.contenedor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2347, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "CERRAR SESION";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // iconPagos
            // 
            this.iconPagos.AutoSize = false;
            this.iconPagos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iconPagos.ForeColor = System.Drawing.Color.Black;
            this.iconPagos.IconChar = FontAwesome.Sharp.IconChar.Safari;
            this.iconPagos.IconColor = System.Drawing.Color.Black;
            this.iconPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPagos.IconSize = 60;
            this.iconPagos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconPagos.Name = "iconPagos";
            this.iconPagos.Size = new System.Drawing.Size(150, 100);
            this.iconPagos.Text = "Pagos";
            this.iconPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconPagos.Click += new System.EventHandler(this.iconPagos_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2579, 1192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menuacerca;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuusuario;
        private FontAwesome.Sharp.IconMenuItem menumenu;
        private FontAwesome.Sharp.IconMenuItem menuproductos;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem iconMesas;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconMenuItem iconPagos;
    }
}

