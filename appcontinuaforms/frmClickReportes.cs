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
    public partial class frmClickReportes : Form
    {
        public frmClickReportes()
        {
            InitializeComponent();
        }

        //METODO PARA QUE SE ABRA EN EL PANEL FORMULARIO DE CLICK GESTIONAR LISTAS
        private void AbrirFormListas(Object frmClickGestionarListas)
        {
            if (this.panelClickReportes.Controls.Count > 0)
                this.panelClickReportes.Controls.RemoveAt(0);
            Form li = frmClickGestionarListas as Form;
            li.TopLevel = false;
            li.Dock = DockStyle.Fill;
            this.panelClickReportes.Controls.Add(li);
            this.panelClickReportes.Tag = li;
            li.Show();

        }


        //METODO PARA QUE SE ABRA EN EL PANEL FORMULARIO DE CLICK FINALIZACION DE CURSO
        private void AbrirFormFinalCurso(Object frmClickFinalizaciónCurso)
        {
            if (this.panelClickReportes.Controls.Count > 0)
                this.panelClickReportes.Controls.RemoveAt(0);
            Form finc = frmClickFinalizaciónCurso as Form;
            finc.TopLevel = false;
            finc.Dock = DockStyle.Fill;
            this.panelClickReportes.Controls.Add(finc);
            this.panelClickReportes.Tag =finc;
            finc.Show();

        }

        private void BtnGestionarListas_Click(object sender, EventArgs e)
        {
            AbrirFormListas(new frmClickGestionarListas());
        }

        private void BtnFinalizacionCurso_Click(object sender, EventArgs e)
        {
            AbrirFormFinalCurso(new frmClickFinalizaciónCurso());
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
