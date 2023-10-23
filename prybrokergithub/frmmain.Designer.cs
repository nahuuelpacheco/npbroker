
namespace prybroker23
{
    partial class frminicio
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
            this.BarradeTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aseguradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRegistroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verRegistrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelControlador = new System.Windows.Forms.Panel();
            this.lblNPBroker = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnapagar = new System.Windows.Forms.PictureBox();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.BarradeTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.PanelControlador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnapagar)).BeginInit();
            this.PanelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarradeTitulo
            // 
            this.BarradeTitulo.BackColor = System.Drawing.Color.CadetBlue;
            this.BarradeTitulo.Controls.Add(this.btnRestaurar);
            this.BarradeTitulo.Controls.Add(this.btnMinimizar);
            this.BarradeTitulo.Controls.Add(this.btnMaximizar);
            this.BarradeTitulo.Controls.Add(this.btnCerrar);
            this.BarradeTitulo.Controls.Add(this.menuStrip1);
            this.BarradeTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarradeTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarradeTitulo.Name = "BarradeTitulo";
            this.BarradeTitulo.Size = new System.Drawing.Size(740, 48);
            this.BarradeTitulo.TabIndex = 0;
            this.BarradeTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarradeTitulo_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::prybroker23.Properties.Resources.res;
            this.btnRestaurar.Location = new System.Drawing.Point(685, 27);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(23, 23);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::prybroker23.Properties.Resources.minimazar;
            this.btnMinimizar.Location = new System.Drawing.Point(656, 25);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(23, 23);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::prybroker23.Properties.Resources.maxi;
            this.btnMaximizar.Location = new System.Drawing.Point(685, 22);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(23, 23);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::prybroker23.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(714, 27);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aseguradosToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aseguradosToolStripMenuItem
            // 
            this.aseguradosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRegistroToolStripMenuItem,
            this.verRegistrosToolStripMenuItem});
            this.aseguradosToolStripMenuItem.Name = "aseguradosToolStripMenuItem";
            this.aseguradosToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.aseguradosToolStripMenuItem.Text = "Aseguradores";
            // 
            // nuevoRegistroToolStripMenuItem
            // 
            this.nuevoRegistroToolStripMenuItem.Name = "nuevoRegistroToolStripMenuItem";
            this.nuevoRegistroToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.nuevoRegistroToolStripMenuItem.Text = "Nuevo Registro";
            this.nuevoRegistroToolStripMenuItem.Click += new System.EventHandler(this.nuevoRegistroToolStripMenuItem_Click);
            // 
            // verRegistrosToolStripMenuItem
            // 
            this.verRegistrosToolStripMenuItem.Name = "verRegistrosToolStripMenuItem";
            this.verRegistrosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.verRegistrosToolStripMenuItem.Text = "Ver Registros";
            this.verRegistrosToolStripMenuItem.Click += new System.EventHandler(this.verRegistrosToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRegistroToolStripMenuItem1,
            this.verRegistrosToolStripMenuItem1});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // nuevoRegistroToolStripMenuItem1
            // 
            this.nuevoRegistroToolStripMenuItem1.Name = "nuevoRegistroToolStripMenuItem1";
            this.nuevoRegistroToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.nuevoRegistroToolStripMenuItem1.Text = "Nuevo Registro";
            this.nuevoRegistroToolStripMenuItem1.Click += new System.EventHandler(this.nuevoRegistroToolStripMenuItem1_Click);
            // 
            // verRegistrosToolStripMenuItem1
            // 
            this.verRegistrosToolStripMenuItem1.Name = "verRegistrosToolStripMenuItem1";
            this.verRegistrosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.verRegistrosToolStripMenuItem1.Text = "Ver Registros";
            this.verRegistrosToolStripMenuItem1.Click += new System.EventHandler(this.verRegistrosToolStripMenuItem1_Click);
            // 
            // PanelControlador
            // 
            this.PanelControlador.BackColor = System.Drawing.Color.MediumAquamarine;
            this.PanelControlador.Controls.Add(this.lblNPBroker);
            this.PanelControlador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlador.Location = new System.Drawing.Point(199, 48);
            this.PanelControlador.Name = "PanelControlador";
            this.PanelControlador.Size = new System.Drawing.Size(541, 402);
            this.PanelControlador.TabIndex = 2;
            this.PanelControlador.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelControlador_Paint);
            // 
            // lblNPBroker
            // 
            this.lblNPBroker.AutoSize = true;
            this.lblNPBroker.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNPBroker.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNPBroker.Location = new System.Drawing.Point(117, 142);
            this.lblNPBroker.Name = "lblNPBroker";
            this.lblNPBroker.Size = new System.Drawing.Size(316, 55);
            this.lblNPBroker.TabIndex = 0;
            this.lblNPBroker.Text = "NP BROKER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prybroker23.Properties.Resources.Untitled_Project__3___1__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnapagar
            // 
            this.btnapagar.Image = global::prybroker23.Properties.Resources.salir;
            this.btnapagar.Location = new System.Drawing.Point(3, 357);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(35, 42);
            this.btnapagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnapagar.TabIndex = 0;
            this.btnapagar.TabStop = false;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.DarkGray;
            this.PanelLateral.Controls.Add(this.btnapagar);
            this.PanelLateral.Controls.Add(this.pictureBox1);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 48);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(199, 402);
            this.PanelLateral.TabIndex = 1;
            // 
            // frminicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.PanelControlador);
            this.Controls.Add(this.PanelLateral);
            this.Controls.Add(this.BarradeTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frminicio";
            this.Text = "Form1";
            this.BarradeTitulo.ResumeLayout(false);
            this.BarradeTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelControlador.ResumeLayout(false);
            this.PanelControlador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnapagar)).EndInit();
            this.PanelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarradeTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel PanelControlador;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Label lblNPBroker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aseguradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoRegistroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verRegistrosToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnapagar;
        private System.Windows.Forms.Panel PanelLateral;
    }
}

