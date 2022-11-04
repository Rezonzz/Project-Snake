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
    public partial class frm_infojogo : Form
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
        public frm_infojogo()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 16, 16));
        }
        private Form currentChildForm;
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_background.Controls.Add(childForm);
            pnl_background.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_page1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_infojogo1());
            btn_page1.BackColor = Color.FromArgb(192, 192, 0);
            btn_page1.ForeColor = Color.Black;
            btn_page2.BackColor = Color.FromArgb(24, 24, 27);
            btn_page2.ForeColor = Color.White;
            btn_page3.BackColor = Color.FromArgb(24, 24, 27);
            btn_page3.ForeColor = Color.White;
        }

        private void btn_page2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_info1v1_2());
            btn_page2.BackColor = Color.FromArgb(192, 192, 0);
            btn_page2.ForeColor = Color.Black;
            btn_page1.BackColor = Color.FromArgb(24, 24, 27);
            btn_page1.ForeColor = Color.White;
            btn_page3.BackColor = Color.FromArgb(24, 24, 27);
            btn_page3.ForeColor = Color.White;
        }

        private void btn_page3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_info1v1_3());
            btn_page3.BackColor = Color.FromArgb(192, 192, 0);
            btn_page3.ForeColor = Color.Black;
            btn_page1.BackColor = Color.FromArgb(24, 24, 27);
            btn_page1.ForeColor = Color.White;
            btn_page2.BackColor = Color.FromArgb(24, 24, 27);
            btn_page2.ForeColor = Color.White;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
