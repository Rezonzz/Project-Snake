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
    public partial class frm_dificuldade : Form
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
        public frm_dificuldade()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 16, 16));
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

        private void btn_facil_MouseMove(object sender, MouseEventArgs e)
        {
            btn_facil.BackColor = Color.FromArgb(0, 187, 70);
        }

        private void btn_facil_MouseLeave(object sender, EventArgs e)
        {
            btn_facil.BackColor = Color.FromArgb(24, 24, 27);
        }

        private void btn_facil_MouseDown(object sender, MouseEventArgs e)
        {
            btn_facil.Size = new Size(145, 40);
            btn_facil.Location = new Point(95, 190);
        }

        private void btn_facil_Click(object sender, EventArgs e)
        {
            frm_facil frm_facil = new frm_facil();
            frm_facil.Show();
            this.Close();
        }

        private void btn_medio_MouseMove(object sender, MouseEventArgs e)
        {
            btn_medio.BackColor = Color.FromArgb(217, 160, 11);
        }

        private void btn_medio_MouseLeave(object sender, EventArgs e)
        {
            btn_medio.BackColor = Color.FromArgb(24, 24, 27);
        }

        private void btn_medio_MouseDown(object sender, MouseEventArgs e)
        {
            btn_medio.Size = new Size(145, 40);
            btn_medio.Location = new Point(95, 250);
        }

        private void btn_medio_Click(object sender, EventArgs e)
        {
            frm_medio frm_medio = new frm_medio();
            frm_medio.Show();
            this.Close();
        }

        private void btn_dificil_MouseDown(object sender, MouseEventArgs e)
        {
            btn_dificil.Size = new Size(145, 40);
            btn_dificil.Location = new Point(95, 311);
        }

        private void btn_dificil_MouseMove(object sender, MouseEventArgs e)
        {
            btn_dificil.BackColor = Color.FromArgb(121, 0, 3);
        }

        private void btn_dificil_MouseLeave(object sender, EventArgs e)
        {
            btn_dificil.BackColor = Color.FromArgb(24, 24, 27);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
            this.Close();
        }

        private void btn_mtfacil_MouseLeave(object sender, EventArgs e)
        {
            btn_mtfacil.BackColor = Color.FromArgb(24, 24, 27);
        }

        private void btn_mtfacil_MouseMove(object sender, MouseEventArgs e)
        {
            btn_mtfacil.BackColor = Color.FromArgb(128, 255, 137);
        }

        private void btn_mtfacil_Click(object sender, EventArgs e)
        {
            frm_mtfacil frm_mtfacil = new frm_mtfacil();
            frm_mtfacil.Show();
            this.Close();
        }

        private void btn_mtfacil_MouseDown(object sender, MouseEventArgs e)
        {
            btn_mtfacil.Size = new Size(145, 40);
            btn_mtfacil.Location = new Point(95, 131);
        }

        private void btn_dificil_Click(object sender, EventArgs e)
        {
            frm_dificil frm_dificil = new frm_dificil();
            frm_dificil.Show();
            this.Close();
        }
    }
}
