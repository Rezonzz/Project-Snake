using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_M9_BrunoPinheiro
{
    public partial class frm_menu : Form
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
        public frm_menu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 16, 16));
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login frm_login = new frm_login();
            frm_login.Show();
            this.Close();
        }

        private void btn_logout_MouseMove(object sender, MouseEventArgs e)
        {
            btn_logout.BackColor = Color.FromArgb(172, 0, 14);
        }

        private void btn_logout_MouseLeave(object sender, EventArgs e)
        {
            btn_logout.BackColor = Color.FromArgb(64, 0, 0);
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_logout_MouseDown(object sender, MouseEventArgs e)
        {
            btn_logout.Size = new Size(145, 40);
            btn_logout.Location = new Point(95, 422);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            btn_sair.Size = new Size(145, 40);
            btn_sair.Location = new Point(93, 285);
            frm_sair frm_sair = new frm_sair();
            frm_sair.Show();
        }

        private void btn_sair_MouseMove(object sender, MouseEventArgs e)
        {
            btn_sair.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btn_sair_MouseLeave(object sender, EventArgs e)
        {
            btn_sair.BackColor = Color.FromArgb(24, 24, 27);
        }

        private void btn_regras_MouseDown(object sender, MouseEventArgs e)
        {
            btn_regras.Size = new Size(145, 40);
            btn_regras.Location = new Point(93, 208);
        }

        private void btn_regras_MouseMove(object sender, MouseEventArgs e)
        {
            btn_regras.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btn_regras_MouseLeave(object sender, EventArgs e)
        {
            btn_regras.BackColor = Color.FromArgb(24, 24, 27);
        }

        private void btn_jogar_MouseDown(object sender, MouseEventArgs e)
        {
            btn_jogar.Size = new Size(145, 40);
            btn_jogar.Location = new Point(93, 134);
        }

        private void btn_jogar_MouseLeave(object sender, EventArgs e)
        {
            btn_jogar.BackColor = Color.FromArgb(24, 24, 27);
        }

        private void btn_jogar_MouseMove(object sender, MouseEventArgs e)
        {
            btn_jogar.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            frm_dificuldade frm_dificuldade = new frm_dificuldade();
            frm_dificuldade.Show();
            this.Hide();
        }
    }
}
