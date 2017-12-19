namespace InterfazUsuario
{
    partial class IUInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IUInicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbBienvenida = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCerrar = new System.Windows.Forms.Label();
            this.lbMiminizar = new System.Windows.Forms.Label();
            this.pnVoluntario = new System.Windows.Forms.Panel();
            this.lbInfoVol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnVoluntario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lbCargo);
            this.panel1.Controls.Add(this.lbBienvenida);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 101);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(716, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 33);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
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
            this.lbBienvenida.Size = new System.Drawing.Size(144, 23);
            this.lbBienvenida.TabIndex = 0;
            this.lbBienvenida.Text = "Bienvenido, ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 101);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbCerrar
            // 
            this.lbCerrar.AutoSize = true;
            this.lbCerrar.BackColor = System.Drawing.Color.Orange;
            this.lbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbCerrar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCerrar.ForeColor = System.Drawing.Color.DimGray;
            this.lbCerrar.Location = new System.Drawing.Point(728, 0);
            this.lbCerrar.Name = "lbCerrar";
            this.lbCerrar.Size = new System.Drawing.Size(18, 16);
            this.lbCerrar.TabIndex = 2;
            this.lbCerrar.Text = "X";
            this.lbCerrar.Click += new System.EventHandler(this.lbCerrar_Click);
            // 
            // lbMiminizar
            // 
            this.lbMiminizar.AutoSize = true;
            this.lbMiminizar.BackColor = System.Drawing.Color.Orange;
            this.lbMiminizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMiminizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbMiminizar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiminizar.ForeColor = System.Drawing.Color.DimGray;
            this.lbMiminizar.Location = new System.Drawing.Point(713, 0);
            this.lbMiminizar.Name = "lbMiminizar";
            this.lbMiminizar.Size = new System.Drawing.Size(15, 16);
            this.lbMiminizar.TabIndex = 3;
            this.lbMiminizar.Text = "-";
            this.lbMiminizar.Click += new System.EventHandler(this.lbMiminizar_Click);
            // 
            // pnVoluntario
            // 
            this.pnVoluntario.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pnVoluntario.Controls.Add(this.lbInfoVol);
            this.pnVoluntario.Controls.Add(this.label1);
            this.pnVoluntario.Controls.Add(this.pictureBox2);
            this.pnVoluntario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnVoluntario.Location = new System.Drawing.Point(5, 3);
            this.pnVoluntario.Name = "pnVoluntario";
            this.pnVoluntario.Size = new System.Drawing.Size(232, 123);
            this.pnVoluntario.TabIndex = 4;
            this.pnVoluntario.Click += new System.EventHandler(this.pnVoluntario_Click);
            // 
            // lbInfoVol
            // 
            this.lbInfoVol.AutoSize = true;
            this.lbInfoVol.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbInfoVol.ForeColor = System.Drawing.SystemColors.Info;
            this.lbInfoVol.Location = new System.Drawing.Point(122, 56);
            this.lbInfoVol.Name = "lbInfoVol";
            this.lbInfoVol.Size = new System.Drawing.Size(41, 13);
            this.lbInfoVol.TabIndex = 5;
            this.lbInfoVol.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Voluntarios";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-5, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 116);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pnVoluntario_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pnVoluntario);
            this.panel3.Location = new System.Drawing.Point(12, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 343);
            this.panel3.TabIndex = 6;
            // 
            // IUInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(746, 477);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbMiminizar);
            this.Controls.Add(this.lbCerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IUInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio GAPCS";
            this.Load += new System.EventHandler(this.IUInicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnVoluntario.ResumeLayout(false);
            this.pnVoluntario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbBienvenida;
        private System.Windows.Forms.Label lbCerrar;
        private System.Windows.Forms.Label lbMiminizar;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.Panel pnVoluntario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbInfoVol;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}