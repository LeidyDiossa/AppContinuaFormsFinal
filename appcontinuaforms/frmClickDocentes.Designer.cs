namespace appcontinuaforms
{
    partial class frmClickDocentes
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
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrarDocentenConsulta = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtBoxCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsulta
            // 
            this.panelConsulta.BackColor = System.Drawing.Color.Transparent;
            this.panelConsulta.Controls.Add(this.pictureBox1);
            this.panelConsulta.Controls.Add(this.btnRegistrarDocentenConsulta);
            this.panelConsulta.Controls.Add(this.btnConfirmar);
            this.panelConsulta.Controls.Add(this.txtBoxCedula);
            this.panelConsulta.Controls.Add(this.label1);
            this.panelConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsulta.Location = new System.Drawing.Point(0, 0);
            this.panelConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(713, 528);
            this.panelConsulta.TabIndex = 3;
            this.panelConsulta.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appcontinuaforms.Properties.Resources.profesor__2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrarDocentenConsulta
            // 
            this.btnRegistrarDocentenConsulta.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrarDocentenConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarDocentenConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarDocentenConsulta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarDocentenConsulta.Location = new System.Drawing.Point(262, 413);
            this.btnRegistrarDocentenConsulta.Name = "btnRegistrarDocentenConsulta";
            this.btnRegistrarDocentenConsulta.Size = new System.Drawing.Size(222, 35);
            this.btnRegistrarDocentenConsulta.TabIndex = 3;
            this.btnRegistrarDocentenConsulta.Text = "REGISTRAR DOCENTE";
            this.btnRegistrarDocentenConsulta.UseVisualStyleBackColor = false;
            this.btnRegistrarDocentenConsulta.Click += new System.EventHandler(this.BtnRegistrarDocentenConsulta_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirmar.Location = new System.Drawing.Point(304, 335);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(145, 35);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // txtBoxCedula
            // 
            this.txtBoxCedula.BackColor = System.Drawing.Color.AliceBlue;
            this.txtBoxCedula.Location = new System.Drawing.Point(262, 229);
            this.txtBoxCedula.MinimumSize = new System.Drawing.Size(50, 50);
            this.txtBoxCedula.Name = "txtBoxCedula";
            this.txtBoxCedula.Size = new System.Drawing.Size(222, 20);
            this.txtBoxCedula.TabIndex = 1;
            this.txtBoxCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxCedula.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(270, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE IDENTIFICACIÓN \r\nDEL DOCENTE\r\n\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmClickDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(713, 528);
            this.Controls.Add(this.panelConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClickDocentes";
            this.Text = "frmClickDocentes";
            this.panelConsulta.ResumeLayout(false);
            this.panelConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsulta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistrarDocentenConsulta;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtBoxCedula;
        private System.Windows.Forms.Label label1;
    }
}