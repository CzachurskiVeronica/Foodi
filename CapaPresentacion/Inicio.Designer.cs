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
            this.menumesas = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuario,
            this.menumenu,
            this.menuproductos,
            this.menumesas});
            this.menu.Location = new System.Drawing.Point(0, 69);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1024, 78);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuusuario
            // 
            this.menuusuario.AutoSize = false;
            this.menuusuario.ForeColor = System.Drawing.Color.Black;
            this.menuusuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.menuusuario.IconColor = System.Drawing.Color.Black;
            this.menuusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuario.IconSize = 50;
            this.menuusuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuario.Name = "menuusuario";
            this.menuusuario.Size = new System.Drawing.Size(80, 74);
            this.menuusuario.Text = "Usuarios";
            this.menuusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menumenu
            // 
            this.menumenu.AutoSize = false;
            this.menumenu.ForeColor = System.Drawing.Color.Black;
            this.menumenu.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.menumenu.IconColor = System.Drawing.Color.Black;
            this.menumenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumenu.IconSize = 50;
            this.menumenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumenu.Name = "menumenu";
            this.menumenu.Size = new System.Drawing.Size(80, 74);
            this.menumenu.Text = "Menu";
            this.menumenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuproductos
            // 
            this.menuproductos.AutoSize = false;
            this.menuproductos.ForeColor = System.Drawing.Color.Black;
            this.menuproductos.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.menuproductos.IconColor = System.Drawing.Color.Black;
            this.menuproductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproductos.IconSize = 50;
            this.menuproductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproductos.Name = "menuproductos";
            this.menuproductos.Size = new System.Drawing.Size(80, 74);
            this.menuproductos.Text = "Productos";
            this.menuproductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menumesas
            // 
            this.menumesas.AutoSize = false;
            this.menumesas.ForeColor = System.Drawing.Color.Black;
            this.menumesas.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.menumesas.IconColor = System.Drawing.Color.Black;
            this.menumesas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumesas.IconSize = 50;
            this.menumesas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumesas.Name = "menumesas";
            this.menumesas.Size = new System.Drawing.Size(80, 74);
            this.menumesas.Text = "Mesas";
            this.menumesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1024, 69);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(474, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "FOODIE";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menumesas;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuusuario;
        private FontAwesome.Sharp.IconMenuItem menumenu;
        private FontAwesome.Sharp.IconMenuItem menuproductos;
    }
}

