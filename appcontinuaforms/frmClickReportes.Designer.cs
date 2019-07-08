namespace appcontinuaforms
{
    partial class frmClickReportes
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
            this.btnGestionarListas = new System.Windows.Forms.Button();
            this.btnFinalizacionCurso = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelClickReportes = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelClickReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGestionarListas
            // 
            this.btnGestionarListas.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGestionarListas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestionarListas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarListas.ForeColor = System.Drawing.Color.White;
            this.btnGestionarListas.Location = new System.Drawing.Point(54, 40);
            this.btnGestionarListas.Name = "btnGestionarListas";
            this.btnGestionarListas.Size = new System.Drawing.Size(220, 45);
            this.btnGestionarListas.TabIndex = 1;
            this.btnGestionarListas.Text = "GESTIONAR LISTAS";
            this.btnGestionarListas.UseVisualStyleBackColor = false;
            this.btnGestionarListas.Click += new System.EventHandler(this.BtnGestionarListas_Click);
            // 
            // btnFinalizacionCurso
            // 
            this.btnFinalizacionCurso.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnFinalizacionCurso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalizacionCurso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizacionCurso.ForeColor = System.Drawing.Color.White;
            this.btnFinalizacionCurso.Location = new System.Drawing.Point(54, 131);
            this.btnFinalizacionCurso.Name = "btnFinalizacionCurso";
            this.btnFinalizacionCurso.Size = new System.Drawing.Size(220, 45);
            this.btnFinalizacionCurso.TabIndex = 2;
            this.btnFinalizacionCurso.Text = "FINALIZACION DE CURSO";
            this.btnFinalizacionCurso.UseVisualStyleBackColor = false;
            this.btnFinalizacionCurso.Click += new System.EventHandler(this.BtnFinalizacionCurso_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(54, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "REPORTE FACTURACIÓN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(54, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "REPORTE PERSONALIZADO";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(54, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "CERTIFICADOS ALUMNOS";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appcontinuaforms.Properties.Resources.certificado;
            this.pictureBox1.Location = new System.Drawing.Point(438, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelClickReportes
            // 
            this.panelClickReportes.Controls.Add(this.pictureBox1);
            this.panelClickReportes.Controls.Add(this.button3);
            this.panelClickReportes.Controls.Add(this.btnGestionarListas);
            this.panelClickReportes.Controls.Add(this.button2);
            this.panelClickReportes.Controls.Add(this.btnFinalizacionCurso);
            this.panelClickReportes.Controls.Add(this.button1);
            this.panelClickReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClickReportes.Location = new System.Drawing.Point(0, 0);
            this.panelClickReportes.Name = "panelClickReportes";
            this.panelClickReportes.Size = new System.Drawing.Size(713, 528);
            this.panelClickReportes.TabIndex = 6;
            // 
            // frmClickReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(713, 528);
            this.Controls.Add(this.panelClickReportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClickReportes";
            this.Text = "frmClickReportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelClickReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGestionarListas;
        private System.Windows.Forms.Button btnFinalizacionCurso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelClickReportes;
    }
}