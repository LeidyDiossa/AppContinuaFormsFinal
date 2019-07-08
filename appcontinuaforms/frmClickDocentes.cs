using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appcontinuaforms;
namespace appcontinuaforms
{
    public partial class frmClickDocentes : Form
    {
        public frmClickDocentes()
        {
            InitializeComponent();
        }

        //METODO PARA QUE SE ABRA EN EL PANEL FORMULARIO DE CONSULTA DE DOCENTE
        private void AbrirFormConsultaD(Object frmClickDocentes)
        {
            if (this.panelConsulta.Controls.Count > 0)
                this.panelConsulta.Controls.RemoveAt(0);
            Form cd = frmClickDocentes as Form;
            cd.TopLevel = false;
            cd.Dock = DockStyle.Fill;
            this.panelConsulta.Controls.Add(cd);
            this.panelConsulta.Tag = cd;
            cd.Show();

        }

        //METODO PARA QUE SE ABRA EN EL PANEL FORMULARIO DE CONSULTA DE DOCENTE
        private void AbrirFormRDocente(Object frmregistrardocente)
        {
            if (this.panelConsulta.Controls.Count > 0)
                this.panelConsulta.Controls.RemoveAt(0);
            Form rd = frmregistrardocente as Form;
            rd.TopLevel = false;
            rd.Dock = DockStyle.Fill;
            this.panelConsulta.Controls.Add(rd);
            this.panelConsulta.Tag = rd;
            rd.Show();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegistrarDocentenConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormRDocente(new frmregistrardocente());
        }
    }
}
