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

using MySql.Data;
using MySql.Data.MySqlClient;
using appcontinuaforms;

namespace ProyectoFinal
{
    public partial class VentanaLogin : Form
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void VentanaLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Complemento para poder mover ventana y panel 
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void TxtUser_MouseEnter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USER")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }

        }

        private void TxtUser_MouseLeave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USER";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void TxtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "PASSWORD")
            {
                txtPassword.Text = "";
                txtUser.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void TxtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "PASSWORD";
                txtUser.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }
        
        private void BtnLogin_Click(object sender, EventArgs e)
        {

           
        } 

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

 

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            ConexionBD bd = new ConexionBD();
            bd.conectarBD();
            if (bd.numeroerror == null)
            {


                string sql = "SELECT contraseña FROM usuarios WHERE id_usuario = @txtUser";
                MySqlCommand cmd = new MySqlCommand(sql, bd.conn);
                cmd.Parameters.AddWithValue("@txtUser", txtUser.Text);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        if (rdr[0].Equals(txtPassword.Text))
                        {
                            MessageBox.Show("Inicio de sesión exitoso");
                        }
                        else
                        {
                            MessageBox.Show("Nombre de usuario y/o contraseña incorrectos");
                        }
                    }
                }
                rdr.Close();
                bd.desconectarBD();
            } else
            {
                MessageBox.Show(bd.numeroerror + " " +bd.mensajeerror);
                MessageBox.Show(bd.numeroerror + " " +bd.mensajeerror);
            }
        }
    }
}
