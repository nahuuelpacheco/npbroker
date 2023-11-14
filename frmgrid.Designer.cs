
namespace prybroker23
{
    partial class frmgrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pctlogo.Location = new System.Drawing.Point(329, 2);
            this.pctlogo.Name = "pctlogo";
            this.pctlogo.Size = new System.Drawing.Size(100, 138);
            this.pctlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctlogo.TabIndex = 0;
            this.pctlogo.TabStop = false;
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv.Location = new System.Drawing.Point(26, 146);
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(721, 164);
            this.Dgv.TabIndex = 0;
            this.Dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellContentClick);
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
            this.btnVerRegistro.Location = new System.Drawing.Point(269, 342);
            this.btnVerRegistro.Name = "btnVerRegistro";
            this.btnVerRegistro.Size = new System.Drawing.Size(205, 23);
            this.btnVerRegistro.TabIndex = 2;
            this.btnVerRegistro.Text = "VER REGISTRO";
            this.btnVerRegistro.UseVisualStyleBackColor = true;
            this.btnVerRegistro.Click += new System.EventHandler(this.btnVerRegistro_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Location = new System.Drawing.Point(269, 371);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(205, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(269, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(205, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmgrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(779, 452);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnVerRegistro);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.pctlogo);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmgrid";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmgrid_Load);
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