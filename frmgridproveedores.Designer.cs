
namespace prybroker23
{
    partial class frmgridproveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pctlogo = new System.Windows.Forms.PictureBox();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.ColumnN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColoumnEntidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaAPERTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNEXPED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJUZG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJURISD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLIQUIDADORRESPONSABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerRegistro = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pctlogo
            // 
            this.pctlogo.Image = global::prybroker23.Properties.Resources.Untitled_Project__3___1__removebg_preview;
            this.pctlogo.Location = new System.Drawing.Point(328, 12);
            this.pctlogo.Name = "pctlogo";
            this.pctlogo.Size = new System.Drawing.Size(100, 138);
            this.pctlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctlogo.TabIndex = 1;
            this.pctlogo.TabStop = false;
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnN,
            this.ColoumnEntidad,
            this.ColumnaAPERTURA,
            this.ColumnNEXPED,
            this.ColumnJUZG,
            this.ColumnJURISD,
            this.ColumnDIRECCION,
            this.ColumnLIQUIDADORRESPONSABLE});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv.DefaultCellStyle = dataGridViewCellStyle16;
            this.Dgv.Location = new System.Drawing.Point(28, 156);
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(721, 164);
            this.Dgv.TabIndex = 2;
            // 
            // ColumnN
            // 
            this.ColumnN.HeaderText = "N";
            this.ColumnN.Name = "ColumnN";
            this.ColumnN.ReadOnly = true;
            // 
            // ColoumnEntidad
            // 
            this.ColoumnEntidad.HeaderText = "Entidad";
            this.ColoumnEntidad.Name = "ColoumnEntidad";
            this.ColoumnEntidad.ReadOnly = true;
            // 
            // ColumnaAPERTURA
            // 
            this.ColumnaAPERTURA.HeaderText = "APERTURA";
            this.ColumnaAPERTURA.Name = "ColumnaAPERTURA";
            this.ColumnaAPERTURA.ReadOnly = true;
            // 
            // ColumnNEXPED
            // 
            this.ColumnNEXPED.HeaderText = "N°EXPTE";
            this.ColumnNEXPED.Name = "ColumnNEXPED";
            this.ColumnNEXPED.ReadOnly = true;
            // 
            // ColumnJUZG
            // 
            this.ColumnJUZG.HeaderText = "JUZG";
            this.ColumnJUZG.Name = "ColumnJUZG";
            this.ColumnJUZG.ReadOnly = true;
            // 
            // ColumnJURISD
            // 
            this.ColumnJURISD.HeaderText = "JURISD";
            this.ColumnJURISD.Name = "ColumnJURISD";
            this.ColumnJURISD.ReadOnly = true;
            // 
            // ColumnDIRECCION
            // 
            this.ColumnDIRECCION.HeaderText = "DIRECCION";
            this.ColumnDIRECCION.Name = "ColumnDIRECCION";
            this.ColumnDIRECCION.ReadOnly = true;
            // 
            // ColumnLIQUIDADORRESPONSABLE
            // 
            this.ColumnLIQUIDADORRESPONSABLE.HeaderText = "LIQUIDADOR RESPONSABLE";
            this.ColumnLIQUIDADORRESPONSABLE.Name = "ColumnLIQUIDADORRESPONSABLE";
            this.ColumnLIQUIDADORRESPONSABLE.ReadOnly = true;
            // 
            // btnVerRegistro
            // 
            this.btnVerRegistro.ForeColor = System.Drawing.Color.Black;
            this.btnVerRegistro.Location = new System.Drawing.Point(279, 341);
            this.btnVerRegistro.Name = "btnVerRegistro";
            this.btnVerRegistro.Size = new System.Drawing.Size(205, 23);
            this.btnVerRegistro.TabIndex = 3;
            this.btnVerRegistro.Text = "VER REGISTRO";
            this.btnVerRegistro.UseVisualStyleBackColor = true;
            this.btnVerRegistro.Click += new System.EventHandler(this.btnVerRegistro_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Location = new System.Drawing.Point(279, 370);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(205, 23);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(279, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(205, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmgridproveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnVerRegistro);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.pctlogo);
            this.Name = "frmgridproveedores";
            this.Text = "gridproveedores";
            this.Load += new System.EventHandler(this.frmgridproveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctlogo;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColoumnEntidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaAPERTURA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNEXPED;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJUZG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJURISD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLIQUIDADORRESPONSABLE;
        private System.Windows.Forms.Button btnVerRegistro;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSalir;
    }
}