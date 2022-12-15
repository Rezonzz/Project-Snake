using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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


        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btn_sair_Click(object sender, EventArgs e)
        {
            btn_sair.Size = new Size(145, 40);
            btn_sair.Location = new Point(93, 325);
            frm_sair frm_sair = new frm_sair();
            frm_sair.Show();
            btn_sair.Size = new Size(160, 43);
            btn_sair.Location = new Point(86, 322);
        }

        private void btn_sair_MouseMove(object sender, MouseEventArgs e)
        {
            btn_sair.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btn_sair_MouseLeave(object sender, EventArgs e)
        {
            btn_sair.BackColor = Color.FromArgb(24, 24, 27);
        }

        private void btn_jogar_MouseDown(object sender, MouseEventArgs e)
        {
            btn_jogar.Size = new Size(145, 40);
            btn_jogar.Location = new Point(93, 134);
            btn_jogar.Font = new Font("Comic Sans MS", 10);
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
            this.Close();
        }

        private void pic_info_Click(object sender, EventArgs e)
        {
            frm_info frm_info = new frm_info();
            frm_info.Show();
        }

        private void btn_jogarm_Click(object sender, EventArgs e)
        {
            frm_1v1 frm_1v1 = new frm_1v1();
            frm_1v1.Show();
            this.Close();
        }

        private void btn_jogarm_MouseMove(object sender, MouseEventArgs e)
        {
            btn_jogarm.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btn_jogarm_MouseLeave(object sender, EventArgs e)
        {
            btn_jogarm.BackColor = Color.FromArgb(24, 24, 27);
        }

        private void btn_jogarm_MouseDown(object sender, MouseEventArgs e)
        {
            btn_jogarm.Size = new Size(145, 40);
            btn_jogarm.Location = new Point(93, 195);
            btn_jogarm.Font = new Font("Comic Sans MS", 11);
        }

        private void btn_jogars_Click(object sender, EventArgs e)
        {
            btn_jogars.Font = new Font("Comic Sans MS", 10);
            frm_semlimites frm_semlimites = new frm_semlimites();
            frm_semlimites.Show();
            this.Close();
        }

        private void btn_jogars_MouseDown(object sender, MouseEventArgs e)
        {
            btn_jogars.Size = new Size(145, 40);
            btn_jogars.Location = new Point(93, 259);
        }

        private void btn_jogars_MouseMove(object sender, MouseEventArgs e)
        {
            btn_jogars.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btn_jogars_MouseLeave(object sender, EventArgs e)
        {
            btn_jogars.BackColor = Color.FromArgb(24, 24, 27);
        }

        private void btn_creditos_Click(object sender, EventArgs e)
        {
            btn_creditos.Size = new Size(147, 32);
            btn_creditos.Location = new Point(92, 470);
            frm_creditos frm_creditos = new frm_creditos();
            frm_creditos.Show();
            btn_creditos.Size = new Size(160, 35);
            btn_creditos.Location = new Point(86, 470);
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_creditos_MouseMove(object sender, MouseEventArgs e)
        {
            btn_creditos.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btn_creditos_MouseLeave(object sender, EventArgs e)
        {
            btn_creditos.BackColor = Color.FromArgb(24, 24, 27);
        }
    }
}
