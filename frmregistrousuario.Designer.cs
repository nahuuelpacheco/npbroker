
namespace prybroker23
{
    partial class frmregistrousuario
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAgregarNuevoUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomUs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContUs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPerfiles = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.eL_CLUBDataSet1 = new prybroker23.EL_CLUBDataSet();
            this.sociosTableAdapter1 = new prybroker23.EL_CLUBDataSetTableAdapters.SOCIOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eL_CLUBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prybroker23.Properties.Resources.Untitled_Project__3___1__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(171, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAgregarNuevoUsuario
            // 
            this.lblAgregarNuevoUsuario.AutoSize = true;
            this.lblAgregarNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarNuevoUsuario.Location = new System.Drawing.Point(120, 154);
            this.lblAgregarNuevoUsuario.Name = "lblAgregarNuevoUsuario";
            this.lblAgregarNuevoUsuario.Size = new System.Drawing.Size(264, 24);
            this.lblAgregarNuevoUsuario.TabIndex = 1;
            this.lblAgregarNuevoUsuario.Text = "AGREGAR NUEVO USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrese nombre de usuario:";
            // 
            // txtNomUs
            // 
            this.txtNomUs.Location = new System.Drawing.Point(299, 210);
            this.txtNomUs.Name = "txtNomUs";
            this.txtNomUs.Size = new System.Drawing.Size(171, 20);
            this.txtNomUs.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ingrese la contraseña para el usuario:";
            // 
            // txtContUs
            // 
            this.txtContUs.Location = new System.Drawing.Point(299, 260);
            this.txtContUs.Name = "txtContUs";
            this.txtContUs.Size = new System.Drawing.Size(171, 20);
            this.txtContUs.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Seleccione el perfil del usuario:";
            // 
            // cmbPerfiles
            // 
            this.cmbPerfiles.DisplayMember = "perfil";
            this.cmbPerfiles.FormattingEnabled = true;
            this.cmbPerfiles.Location = new System.Drawing.Point(299, 313);
            this.cmbPerfiles.Name = "cmbPerfiles";
            this.cmbPerfiles.Size = new System.Drawing.Size(171, 21);
            this.cmbPerfiles.TabIndex = 19;
            this.cmbPerfiles.ValueMember = "perfil";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.Location = new System.Drawing.Point(137, 387);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(225, 35);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // eL_CLUBDataSet1
            // 
            this.eL_CLUBDataSet1.DataSetName = "EL_CLUBDataSet";
            this.eL_CLUBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sociosTableAdapter1
            // 
            this.sociosTableAdapter1.ClearBeforeFill = true;
            // 
            // frmregistrousuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(514, 461);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbPerfiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContUs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomUs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAgregarNuevoUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmregistrousuario";
            this.Text = "frmregistrousuario";
            this.Load += new System.EventHandler(this.frmregistrousuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eL_CLUBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAgregarNuevoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomUs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContUs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPerfiles;
        private System.Windows.Forms.Button btnAgregar;
        private EL_CLUBDataSet eL_CLUBDataSet1;
        private EL_CLUBDataSetTableAdapters.SOCIOSTableAdapter sociosTableAdapter1;
    }
}