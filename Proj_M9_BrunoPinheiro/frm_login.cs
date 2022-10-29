using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_M9_BrunoPinheiro
{
    public partial class frm_login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );
        OleDbConnection connection = new OleDbConnection();
        public frm_login()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb";
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 16, 16));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            frm_sair frm_sair = new frm_sair();
            frm_sair.Show();
        }

        private void lbl_limpar_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.ResetText();
            txt_password.ResetText();
            txt_username.Focus();
            txt_password.Text = "Password";
            txt_password.UseSystemPasswordChar = true;
            pic_ocultado.Enabled = false;
            pic_ocultado.Visible = false;
            pic_mostrar.Enabled = true;
            pic_mostrar.Visible = true;
            lbl_limpar.Visible = false;
            lbl_limpar.Enabled = false;
        }

        private void pic_ocultado_Click(object sender, EventArgs e)
        {
            if (txt_password.Text != "Password")
            {
                txt_password.UseSystemPasswordChar = false;
            }
            pic_ocultado.Enabled = false;
            pic_ocultado.Visible = false;
            pic_mostrar.Enabled = true;
            pic_mostrar.Visible = true;
        }

        private void pic_mostrar_Click(object sender, EventArgs e)
        {
            if (txt_password.Text != "Password")
            {
                txt_password.UseSystemPasswordChar = true;
            }
            pic_ocultado.Enabled = true;
            pic_ocultado.Visible = true;
            pic_mostrar.Enabled = false;
            pic_mostrar.Visible = false;
        }

        private void txt_username_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "Username")
            {
                txt_username.ResetText();
                txt_username.Focus();
            }
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.UseSystemPasswordChar = false;
                txt_password.ResetText();
                txt_password.Focus();
            }
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Users where Username='" + txt_username.Text + "'and Password='" + txt_password.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();

            int count = 0;

            while (reader.Read())
            {
                count = count + 1;
            }

            if (count == 1)
            {
                btn_login.Size = new Size(130, 35);
                btn_login.Location = new Point(96, 388);
                /*StreamWriter Login = new StreamWriter("Login.txt");
                Login.WriteLine("{0, -5}, {1, -4}",
                "*****", "true"
                    );
                Login.Dispose();*/
                frm_menu frm_menu = new frm_menu();
                frm_menu.Show();
                this.Hide();
                MessageBox.Show("Log in concluido com sucesso.", "Snake - Log in");
            }
            else
            {
                btn_login.Size = new Size(130, 35);
                btn_login.Location = new Point(96, 388);
                lbl_invalido.Visible = true;
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
            connection.Close();
            btn_login.Size = new Size(140, 37);
            btn_login.Location = new Point(90, 387);
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            frm_sair frm_sair = new frm_sair();
            frm_sair.Show();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if(txt_username.Text != "" && txt_username.Text != "Username")
            {
                lbl_limpar.Visible = true;
                lbl_limpar.Enabled = true;
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (txt_password.Text != "" && txt_password.Text != "Password")
            {
                lbl_limpar.Visible = true;
                lbl_limpar.Enabled = true;
            }
        }

        private void lbl_registrar_Click(object sender, EventArgs e)
        {
            frm_signin frm_signin = new frm_signin();
            frm_signin.Show();
            this.Hide();
        }
    }
}
