namespace InterfazUsuario
{
    partial class IUVoluntarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IUVoluntarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbBienvenida = new System.Windows.Forms.Label();
            this.lbMiminizar = new System.Windows.Forms.Label();
            this.lbCerrar = new System.Windows.Forms.Label();
            this.dgvVoluntarios = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbBusNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBusIndicativo = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnCuerpo = new System.Windows.Forms.Panel();
            this.pnCabezal = new System.Windows.Forms.Panel();
            this.lbEdicion = new System.Windows.Forms.Label();
            this.btnAñadirUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoluntarios)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnCuerpo.SuspendLayout();
            this.pnCabezal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 101);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbCargo);
            this.panel1.Controls.Add(this.lbBienvenida);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 101);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 2;
            // 
            // lbCargo
            // 
            this.lbCargo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCargo.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbCargo.Location = new System.Drawing.Point(351, 78);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(359, 23);
            this.lbCargo.TabIndex = 1;
            this.lbCargo.Text = "Cargo: ";
            // 
            // lbBienvenida
            // 
            this.lbBienvenida.AutoSize = true;
            this.lbBienvenida.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenida.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbBienvenida.Location = new System.Drawing.Point(351, 9);
            this.lbBienvenida.Name = "lbBienvenida";
            this.lbBienvenida.Size = new System.Drawing.Size(207, 23);
            this.lbBienvenida.TabIndex = 0;
            this.lbBienvenida.Text = "Nombre, Apellidos";
            // 
            // lbMiminizar
            // 
            this.lbMiminizar.AutoSize = true;
            this.lbMiminizar.BackColor = System.Drawing.Color.Orange;
            this.lbMiminizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMiminizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbMiminizar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiminizar.ForeColor = System.Drawing.Color.DimGray;
            this.lbMiminizar.Location = new System.Drawing.Point(1085, 0);
            this.lbMiminizar.Name = "lbMiminizar";
            this.lbMiminizar.Size = new System.Drawing.Size(15, 16);
            this.lbMiminizar.TabIndex = 15;
            this.lbMiminizar.Text = "-";
            this.lbMiminizar.Click += new System.EventHandler(this.lbMiminizar_Click);
            // 
            // lbCerrar
            // 
            this.lbCerrar.AutoSize = true;
            this.lbCerrar.BackColor = System.Drawing.Color.Orange;
            this.lbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbCerrar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCerrar.ForeColor = System.Drawing.Color.DimGray;
            this.lbCerrar.Location = new System.Drawing.Point(1100, 0);
            this.lbCerrar.Name = "lbCerrar";
            this.lbCerrar.Size = new System.Drawing.Size(18, 16);
            this.lbCerrar.TabIndex = 14;
            this.lbCerrar.Text = "X";
            this.lbCerrar.Click += new System.EventHandler(this.lbCerrar_Click);
            // 
            // dgvVoluntarios
            // 
            this.dgvVoluntarios.AllowUserToAddRows = false;
            this.dgvVoluntarios.AllowUserToDeleteRows = false;
            this.dgvVoluntarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvVoluntarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVoluntarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVoluntarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVoluntarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoluntarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Del});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVoluntarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVoluntarios.Location = new System.Drawing.Point(12, 244);
            this.dgvVoluntarios.MultiSelect = false;
            this.dgvVoluntarios.Name = "dgvVoluntarios";
            this.dgvVoluntarios.ReadOnly = true;
            this.dgvVoluntarios.RowHeadersVisible = false;
            this.dgvVoluntarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVoluntarios.Size = new System.Drawing.Size(1094, 424);
            this.dgvVoluntarios.TabIndex = 16;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Text = "►";
            this.Edit.ToolTipText = "Editar Registro";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 40;
            // 
            // Del
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del.DefaultCellStyle = dataGridViewCellStyle2;
            this.Del.HeaderText = "Del";
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            this.Del.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Del.Text = "X";
            this.Del.ToolTipText = "Borrar";
            this.Del.UseColumnTextForButtonValue = true;
            this.Del.Width = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Controls.Add(this.tbBusNombre);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tbBusIndicativo);
            this.panel3.Location = new System.Drawing.Point(12, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 69);
            this.panel3.TabIndex = 17;
            // 
            // tbBusNombre
            // 
            this.tbBusNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.tbBusNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusNombre.ForeColor = System.Drawing.Color.DimGray;
            this.tbBusNombre.Location = new System.Drawing.Point(164, 39);
            this.tbBusNombre.MaxLength = 50;
            this.tbBusNombre.Name = "tbBusNombre";
            this.tbBusNombre.Size = new System.Drawing.Size(238, 27);
            this.tbBusNombre.TabIndex = 20;
            this.tbBusNombre.TextChanged += new System.EventHandler(this.tbBusNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(162, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Indicativo";
            // 
            // tbBusIndicativo
            // 
            this.tbBusIndicativo.BackColor = System.Drawing.SystemColors.Menu;
            this.tbBusIndicativo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusIndicativo.ForeColor = System.Drawing.Color.DimGray;
            this.tbBusIndicativo.Location = new System.Drawing.Point(6, 39);
            this.tbBusIndicativo.MaxLength = 5;
            this.tbBusIndicativo.Name = "tbBusIndicativo";
            this.tbBusIndicativo.Size = new System.Drawing.Size(92, 27);
            this.tbBusIndicativo.TabIndex = 6;
            this.tbBusIndicativo.TextChanged += new System.EventHandler(this.tbBusIndicativo_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(12, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 33);
            this.panel4.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Busqueda";
            // 
            // pnCuerpo
            // 
            this.pnCuerpo.BackColor = System.Drawing.Color.Orange;
            this.pnCuerpo.Controls.Add(this.btnAñadirUsuario);
            this.pnCuerpo.Location = new System.Drawing.Point(628, 169);
            this.pnCuerpo.Name = "pnCuerpo";
            this.pnCuerpo.Size = new System.Drawing.Size(478, 69);
            this.pnCuerpo.TabIndex = 21;
            // 
            // pnCabezal
            // 
            this.pnCabezal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnCabezal.Controls.Add(this.lbEdicion);
            this.pnCabezal.Location = new System.Drawing.Point(628, 136);
            this.pnCabezal.Name = "pnCabezal";
            this.pnCabezal.Size = new System.Drawing.Size(171, 33);
            this.pnCabezal.TabIndex = 19;
            // 
            // lbEdicion
            // 
            this.lbEdicion.AutoSize = true;
            this.lbEdicion.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.lbEdicion.Location = new System.Drawing.Point(3, 8);
            this.lbEdicion.Name = "lbEdicion";
            this.lbEdicion.Size = new System.Drawing.Size(69, 18);
            this.lbEdicion.TabIndex = 3;
            this.lbEdicion.Text = "Edición";
            // 
            // btnAñadirUsuario
            // 
            this.btnAñadirUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAñadirUsuario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAñadirUsuario.Location = new System.Drawing.Point(15, 7);
            this.btnAñadirUsuario.Name = "btnAñadirUsuario";
            this.btnAñadirUsuario.Size = new System.Drawing.Size(238, 53);
            this.btnAñadirUsuario.TabIndex = 22;
            this.btnAñadirUsuario.Text = "Añadir Voluntario";
            this.btnAñadirUsuario.UseVisualStyleBackColor = false;
            // 
            // IUVoluntarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1118, 679);
            this.Controls.Add(this.pnCabezal);
            this.Controls.Add(this.pnCuerpo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvVoluntarios);
            this.Controls.Add(this.lbMiminizar);
            this.Controls.Add(this.lbCerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IUVoluntarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Voluntarios";
            this.Load += new System.EventHandler(this.IUVoluntarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoluntarios)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnCuerpo.ResumeLayout(false);
            this.pnCabezal.ResumeLayout(false);
            this.pnCabezal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.Label lbBienvenida;
        private System.Windows.Forms.Label lbMiminizar;
        private System.Windows.Forms.Label lbCerrar;
        private System.Windows.Forms.DataGridView dgvVoluntarios;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Del;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBusNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBusIndicativo;
        private System.Windows.Forms.Panel pnCuerpo;
        private System.Windows.Forms.Panel pnCabezal;
        private System.Windows.Forms.Label lbEdicion;
        private System.Windows.Forms.Button btnAñadirUsuario;
    }
}