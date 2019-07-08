namespace appcontinuaforms
{
    partial class frmClickRegistrarAspirante
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
            this.btnRegistrarAspirante = new System.Windows.Forms.Button();
            this.panelRegistrasAspirante = new System.Windows.Forms.Panel();
            this.btnRegistrarDocente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRegistrasAspirante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarAspirante
            // 
            this.btnRegistrarAspirante.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrarAspirante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarAspirante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAspirante.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarAspirante.Location = new System.Drawing.Point(223, 185);
            this.btnRegistrarAspirante.Name = "btnRegistrarAspirante";
            this.btnRegistrarAspirante.Size = new System.Drawing.Size(305, 55);
            this.btnRegistrarAspirante.TabIndex = 0;
            this.btnRegistrarAspirante.Text = "REGISTRAR ASPIRANTE";
            this.btnRegistrarAspirante.UseVisualStyleBackColor = false;
            this.btnRegistrarAspirante.Click += new System.EventHandler(this.BtnRegistrarAspirante_Click);
            // 
            // panelRegistrasAspirante
            // 
            this.panelRegistrasAspirante.Controls.Add(this.btnRegistrarDocente);
            this.panelRegistrasAspirante.Controls.Add(this.pictureBox1);
            this.panelRegistrasAspirante.Controls.Add(this.btnRegistrarAspirante);
            this.panelRegistrasAspirante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistrasAspirante.Location = new System.Drawing.Point(0, 0);
            this.panelRegistrasAspirante.Name = "panelRegistrasAspirante";
            this.panelRegistrasAspirante.Size = new System.Drawing.Size(713, 528);
            this.panelRegistrasAspirante.TabIndex = 1;
            this.panelRegistrasAspirante.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRegistrasAspirante_Paint);
            // 
            // btnRegistrarDocente
            // 
            this.btnRegistrarDocente.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarDocente.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarDocente.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarDocente.Location = new System.Drawing.Point(223, 272);
            this.btnRegistrarDocente.Name = "btnRegistrarDocente";
            this.btnRegistrarDocente.Size = new System.Drawing.Size(305, 55);
            this.btnRegistrarDocente.TabIndex = 2;
            this.btnRegistrarDocente.Text = "REGISTRAR DOCENTE";
            this.btnRegistrarDocente.UseVisualStyleBackColor = false;
            this.btnRegistrarDocente.Click += new System.EventHandler(this.BtnRegistrarDocente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appcontinuaforms.Properties.Resources.ebook;
            this.pictureBox1.Location = new System.Drawing.Point(264, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmClickRegistrarAspirante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(713, 528);
            this.Controls.Add(this.panelRegistrasAspirante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClickRegistrarAspirante";
            this.Text = "frmClickRegistrarAspirante";
            this.Load += new System.EventHandler(this.FrmClickRegistrarAspirante_Load);
            this.panelRegistrasAspirante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarAspirante;
        private System.Windows.Forms.Panel panelRegistrasAspirante;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistrarDocente;
    }
}