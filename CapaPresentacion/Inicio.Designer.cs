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
            this.usuario = new FontAwesome.Sharp.IconMenuItem();
            this.carta = new FontAwesome.Sharp.IconMenuItem();
            this.productos = new FontAwesome.Sharp.IconMenuItem();
            this.pagos = new FontAwesome.Sharp.IconMenuItem();
            this.mesas = new FontAwesome.Sharp.IconMenuItem();
            this.pedidos = new FontAwesome.Sharp.IconMenuItem();
            this.reportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuacerca = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuario,
            this.carta,
            this.productos,
            this.pagos,
            this.mesas,
            this.pedidos,
            this.reportes,
            this.menuacerca});
            this.menu.Location = new System.Drawing.Point(0, 103);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1924, 108);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // usuario
            // 
            this.usuario.AutoSize = false;
            this.usuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usuario.ForeColor = System.Drawing.Color.Black;
            this.usuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.usuario.IconColor = System.Drawing.Color.Black;
            this.usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.usuario.IconSize = 60;
            this.usuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(150, 100);
            this.usuario.Text = "Usuarios";
            this.usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.usuario.Click += new System.EventHandler(this.menuusuario_Click);
            this.usuario.MouseEnter += new System.EventHandler(this.menuusuario_MouseEnter);
            // 
            // carta
            // 
            this.carta.AutoSize = false;
            this.carta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.carta.ForeColor = System.Drawing.Color.Black;
            this.carta.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.carta.IconColor = System.Drawing.Color.Black;
            this.carta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.carta.IconSize = 60;
            this.carta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.carta.Name = "carta";
            this.carta.Size = new System.Drawing.Size(150, 100);
            this.carta.Text = "Menu";
            this.carta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.carta.Click += new System.EventHandler(this.menumenu_Click);
            this.carta.MouseEnter += new System.EventHandler(this.menumenu_MouseEnter);
            // 
            // productos
            // 
            this.productos.AutoSize = false;
            this.productos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.productos.ForeColor = System.Drawing.Color.Black;
            this.productos.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.productos.IconColor = System.Drawing.Color.Black;
            this.productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.productos.IconSize = 60;
            this.productos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(150, 100);
            this.productos.Text = "Productos";
            this.productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.productos.Click += new System.EventHandler(this.menuproductos_Click);
            this.productos.MouseEnter += new System.EventHandler(this.menuproductos_MouseEnter);
            // 
            // pagos
            // 
            this.pagos.AutoSize = false;
            this.pagos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pagos.ForeColor = System.Drawing.Color.Black;
            this.pagos.IconChar = FontAwesome.Sharp.IconChar.Safari;
            this.pagos.IconColor = System.Drawing.Color.Black;
            this.pagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pagos.IconSize = 60;
            this.pagos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pagos.Name = "pagos";
            this.pagos.Size = new System.Drawing.Size(150, 100);
            this.pagos.Text = "Pagos";
            this.pagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pagos.Click += new System.EventHandler(this.iconPagos_Click);
            // 
            // mesas
            // 
            this.mesas.AutoSize = false;
            this.mesas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mesas.ForeColor = System.Drawing.Color.Black;
            this.mesas.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.mesas.IconColor = System.Drawing.Color.Black;
            this.mesas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mesas.IconSize = 60;
            this.mesas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mesas.Name = "mesas";
            this.mesas.Size = new System.Drawing.Size(150, 100);
            this.mesas.Text = "Mesas";
            this.mesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mesas.Click += new System.EventHandler(this.iconMesas_Click);
            this.mesas.MouseEnter += new System.EventHandler(this.iconMenuItem1_MouseEnter);
            // 
            // pedidos
            // 
            this.pedidos.AutoSize = false;
            this.pedidos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pedidos.ForeColor = System.Drawing.Color.Black;
            this.pedidos.IconChar = FontAwesome.Sharp.IconChar.ShareFromSquare;
            this.pedidos.IconColor = System.Drawing.Color.Black;
            this.pedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pedidos.IconSize = 60;
            this.pedidos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pedidos.Name = "pedidos";
            this.pedidos.Size = new System.Drawing.Size(150, 100);
            this.pedidos.Text = "Pedidos";
            this.pedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pedidos.Click += new System.EventHandler(this.iconVenta_Click);
            // 
            // reportes
            // 
            this.reportes.AutoSize = false;
            this.reportes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reportes.ForeColor = System.Drawing.Color.Black;
            this.reportes.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.reportes.IconColor = System.Drawing.Color.Black;
            this.reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reportes.IconSize = 60;
            this.reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportes.Name = "reportes";
            this.reportes.Size = new System.Drawing.Size(150, 100);
            this.reportes.Text = "Reportes";
            this.reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reportes.Click += new System.EventHandler(this.reportes_Click);
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
            this.menuacerca.Click += new System.EventHandler(this.menuacerca_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1924, 103);
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
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
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
        private FontAwesome.Sharp.IconMenuItem usuario;
        private FontAwesome.Sharp.IconMenuItem carta;
        private FontAwesome.Sharp.IconMenuItem productos;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem mesas;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconMenuItem pagos;
        private FontAwesome.Sharp.IconMenuItem pedidos;
        private FontAwesome.Sharp.IconMenuItem reportes;
    }
}

