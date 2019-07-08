using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appcontinuaforms
{
    public partial class frmClickRegistrarAspirante : Form
    {
        public frmClickRegistrarAspirante()
        {
            InitializeComponent();
        }

        //METODO PARA QUE SE ABRA EN EL PANEL FORMULARIO REGISTRO ASPIRANTE
        private void AbrirFormRegistrarAspirantes(Object frmregistraraspirante)
        {
            if (this.panelRegistrasAspirante.Controls.Count > 0)
                this.panelRegistrasAspirante.Controls.RemoveAt(0);
            Form ra = frmregistraraspirante as Form;
            ra.TopLevel = false;
            ra.Dock = DockStyle.Fill;
            this.panelRegistrasAspirante.Controls.Add(ra);
            this.panelRegistrasAspirante.Tag = ra;
            ra.Show();

        }

        private void FrmClickRegistrarAspirante_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrarAspirante_Click(object sender, EventArgs e)
        {
            AbrirFormRegistrarAspirantes(new frmregistraraspirante());
            //while (AbrirFormRegistrarAspirantes == )
        }

        private void PanelRegistrasAspirante_Paint(object sender, PaintEventArgs e)
        {

        }

        //METODO PARA QUE SE ABRA EN EL PANEL FORMULARIO REGISTRO DOCENTE
        private void AbrirFormRegistrarDocente(Object frmregistrardocente)
        {
            if (this.panelRegistrasAspirante.Controls.Count > 0)
                this.panelRegistrasAspirante.Controls.RemoveAt(0);
            Form rdoc = frmregistrardocente as Form;
            rdoc.TopLevel = false;
            rdoc.Dock = DockStyle.Fill;
            this.panelRegistrasAspirante.Controls.Add(rdoc);
            this.panelRegistrasAspirante.Tag = rdoc;
            rdoc.Show();

        }

        private void BtnRegistrarDocente_Click(object sender, EventArgs e)
        {
            AbrirFormRegistrarDocente(new frmregistrardocente());
        }
    }
}
