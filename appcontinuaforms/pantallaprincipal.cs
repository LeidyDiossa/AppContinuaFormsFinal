using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace appcontinuaforms
{
    public partial class frmPantallaPrincipal : Form
    {
         
        public frmPantallaPrincipal()
        {
            InitializeComponent();
        }


        //METODO PARA QUE SE ABRA EN EL PANEL FORMULARIO DE CONSULTA DE ALUMNO
        private void AbrirFormConsulta(Object frmClickAlumnos)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fc = frmClickAlumnos as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fc);
            this.panelPrincipal.Tag = fc;
            fc.Show();

        }


        //METODO PARA QUE SE ABRA EN EL PANEL FORMULARIO PROGRAMAS
        private void AbrirFormProgramas(Object FormularioProgramas)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fp = FormularioProgramas as Form;
            fp.TopLevel = false;
            fp.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fp);
            this.panelPrincipal.Tag = fp;
            fp.Show();

        }

        //METODO PARA QUE SE ABRA EN EL PANEL MenuClickRegistrar
        private void AbrirMenuClickRegistrar(Object PanelMenuClickRegistrar)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form cr = PanelMenuClickRegistrar as Form;
            cr.TopLevel = false;
            cr.Dock = DockStyle.None;
            this.panelPrincipal.Controls.Add(cr);
            this.panelPrincipal.Tag = cr;
            cr.Show();

        }

        //METODO PARA QUE SE ABRA EN EL PANEL FORMULARIO DE CONSULTA DE DOCENTE
        private void AbrirFormConsultaD(Object frmClickDocentes)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form cd = frmClickDocentes as Form;
            cd.TopLevel = false;
            cd.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(cd);
            this.panelPrincipal.Tag = cd;
            cd.Show();

        }

        //METODO PARA QUE SE ABRA EN EL PANEL FORMULARIO REPORTES
        private void AbrirFormReportes(Object frmClickReportes)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form crp = frmClickReportes as Form;
            crp.TopLevel = false;
            crp.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(crp);
            this.panelPrincipal.Tag =crp;
            crp.Show();

        }

        //CODIGO DEL BOTON ALUMNOS DESPUES DE HABER HECHO EL METODO PARA QUE SE ABRA EN EL PANEL

        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormConsulta(new frmClickAlumnos());
        }



        // Código para mover ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Complemento para poder mover ventana y panel 
        private void Panel3_MouseDown(object sender, MouseEventArgs e)
        {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void PanelPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    // Código para cerrar ventana
        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    // Codigo para minimizar ventana
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void BtnProgramas_Click(object sender, EventArgs e)
        {
            AbrirFormProgramas(new FormularioProgramas());
        }

        private void PictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        //CODIGO DEL BOTON REGISTRAR DESPUES DE HABER HECHO EL METODO PARA QUE SE ABRA EN EL PANEL

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            AbrirMenuClickRegistrar(new frmClickRegistrarAspirante());
        }

        private void BtnDocentes_Click(object sender, EventArgs e)
        {
            AbrirFormConsultaD(new frmClickDocentes());
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormReportes(new frmClickReportes());
        }

        /*private void BtnRegistrarAspiranteFormulario_Click(object sender, EventArgs e)
        {
            AbrirFormRegistrarAspirante(new frmClickRegistrarAspirante());
        }

        METODO PARA QUE SE ABRA EN EL PANEL FORMULARIO DE CONSULTA DE ALUMNO
        private void AbrirFormRegistrarAspirante(Object frmregistraraspirante)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form ra = frmregistraraspirante as Form;
            ra.TopLevel = false;
            ra.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(ra);
            this.panelPrincipal.Tag = ra;
            ra.Show();

        }*/
    }
}
