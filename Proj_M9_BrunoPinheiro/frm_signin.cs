using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_M9_BrunoPinheiro
{
    public partial class frm_signin : Form
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
        public frm_signin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 16, 16));
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb");
        OleDbCommand cmd = new OleDbCommand();
        private void lbl_sair_Click(object sender, EventArgs e)
        {
            frm_login frm_login = new frm_login();
            frm_login.Show();
            this.Close();
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

        private void pic_ocultado2_Click(object sender, EventArgs e)
        {
            if (txt_confirm.Text != "Confirmar Password")
            {
                txt_confirm.UseSystemPasswordChar = false;
            }
            pic_ocultado2.Enabled = false;
            pic_ocultado2.Visible = false;
            pic_mostrar2.Enabled = true;
            pic_mostrar2.Visible = true;
        }

        private void pic_mostrar2_Click(object sender, EventArgs e)
        {
            if (txt_confirm.Text != "Confirmar Password")
            {
                txt_confirm.UseSystemPasswordChar = true;
            }
            pic_ocultado2.Enabled = true;
            pic_ocultado2.Visible = true;
            pic_mostrar2.Enabled = false;
            pic_mostrar2.Visible = false;
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

        private void txt_confirm_Click(object sender, EventArgs e)
        {
            if (txt_confirm.Text == "Confirmar Password")
            {
                txt_confirm.UseSystemPasswordChar = false;
                txt_confirm.ResetText();
                txt_confirm.Focus();
            }
        }

        private void lbl_limpar_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_confirm.Clear();
            txt_username.ResetText();
            txt_password.ResetText();
            txt_confirm.ResetText();
            txt_username.Focus();
            txt_password.Text = "Password";
            txt_password.UseSystemPasswordChar = true;
            txt_confirm.Text = "Password";
            txt_confirm.UseSystemPasswordChar = true;
            pic_ocultado.Enabled = false;
            pic_ocultado.Visible = false;
            pic_mostrar.Enabled = true;
            pic_mostrar.Visible = true;
            pic_ocultado2.Enabled = false;
            pic_ocultado2.Visible = false;
            pic_mostrar2.Enabled = true;
            pic_mostrar2.Visible = true;
            lbl_limpar.Visible = false;
            lbl_limpar.Enabled = false;
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "" || txt_confirm.Text == "" || txt_username.Text == "Username" || txt_password.Text == "Password" || txt_confirm.Text == "Confirm Password")
            {
                btn_signin.Size = new Size(130, 35);
                btn_signin.Location = new Point(95, 440);
                lbl_invalido.Visible = false;
                lbl_vazio.Visible = true;
            }
            else if (txt_password.Text == txt_confirm.Text)
            {
                con.Open();
                string register = "INSERT INTO Users VALUES ('" + txt_username.Text + "','" + txt_password.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();
                btn_signin.Size = new Size(130, 35);
                btn_signin.Location = new Point(100, 442);
                frm_login frm_login = new frm_login();
                frm_login.Show();
                this.Close();
                MessageBox.Show("Registro concluido com sucesso! Agora faça log in.", "Sig in");
            }
            else
            {
                lbl_invalido.Visible = true;
                lbl_vazio.Visible = false;
                txt_username.Clear();
                txt_password.Clear();
                txt_confirm.Clear();
                txt_username.ResetText();
                txt_password.ResetText();
                txt_confirm.ResetText();
                txt_username.Focus();
            }
            btn_signin.Size = new Size(140, 37);
            btn_signin.Location = new Point(89, 440);
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            frm_sair frm_sair = new frm_sair();
            frm_sair.Show();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_password.Text == "Password")
                {
                    txt_password.UseSystemPasswordChar = false;
                    txt_password.ResetText();
                    txt_password.Focus();
                }
                e.SuppressKeyPress = true;
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_confirm.Text == "Confirmar Password")
                {
                    txt_confirm.UseSystemPasswordChar = false;
                    txt_confirm.ResetText();
                    txt_confirm.Focus();
                }
                e.SuppressKeyPress = true;
            }
        }

        private void txt_confirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_signin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
