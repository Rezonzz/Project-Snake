using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Proj_M9_BrunoPinheiro
{
    public partial class frm_medio : Form
    {
        private List<Circle2> Snake = new List<Circle2>();
        private Circle2 food = new Circle2();

        int maxWidth, maxHeight, score, highScore, maxWidthS, maxHeightS;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RestartGame();
            }
            if (e.KeyCode == Keys.S)
            {
                TakeSnapShot();
            }
            if (e.KeyCode == Keys.Left && Settings2.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings2.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings2.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings2.directions != "up")
            {
                goDown = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // setting the directions

            if (goLeft)
            {
                Settings2.directions = "left";
            }
            if (goRight)
            {
                Settings2.directions = "right";
            }
            if (goDown)
            {
                Settings2.directions = "down";
            }
            if (goUp)
            {
                Settings2.directions = "up";
            }
            // end of directions

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {

                    switch (Settings2.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }

                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }

                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }

                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                    // restrict the snake from leaving the canvas
                    maxWidthS = pic_canvas.Size.Width / Settings2.Width - 1;
                    maxHeightS = pic_canvas.Size.Height / Settings2.Height - 1;
                    if (Snake[i].X == 0 || Snake[i].Y == 0 || Snake[i].X == maxWidthS || Snake[i].Y == maxHeightS)
                    {
                        // end the game is snake either reaches edge of the canvas
                        GameOver();
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }

            pic_canvas.Invalidate();
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColour;

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.LightSlateGray;
                }
                else
                {
                    snakeColour = Brushes.White;
                }

                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings2.Width,
                    Snake[i].Y * Settings2.Height,
                    Settings2.Width, Settings2.Height
                    ));
            }


            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
            (
            food.X * Settings2.Width,
            food.Y * Settings2.Height,
            Settings2.Width, Settings2.Height
            ));
        }

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
        public frm_medio()
        {
            InitializeComponent();
            new Settings2();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 16, 16));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void tsmi_facil_Click(object sender, EventArgs e)
        {
            frm_facil frm_facil = new frm_facil();
            frm_facil.Show();
            this.Hide();
        }

        private void tsmi_sair_Click(object sender, EventArgs e)
        {
            frm_sair frm_sair = new frm_sair();
            frm_sair.Show();
        }

        private void tsmi_logout_Click(object sender, EventArgs e)
        {
            frm_login frm_login = new frm_login();
            frm_login.Show();
            this.Close();
        }

        private void tsmi_menu_Click(object sender, EventArgs e)
        {
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
            this.Hide();
        }

        private void mst_snake_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RestartGame()
        {
            maxWidth = pic_canvas.Width / Settings2.Width - 1;
            maxHeight = pic_canvas.Height / Settings2.Height - 1;

            Snake.Clear();
            lbl_prima.Visible = false;
            score = 0;
            lbl_score.Text = "Pontuação: " + score;

            Circle2 head = new Circle2 { X = 10, Y = 5 };
            Snake.Add(head); // adding the head part of the snake to the list

            for (int i = 0; i < 10; i++)
            {
                Circle2 body = new Circle2();
                Snake.Add(body);
            }

            food = new Circle2 { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            tmr_game.Start();
        }
        private void EatFood()
        {
            score += 1;

            lbl_score.Text = "Pontuação: " + score;

            Circle2 body = new Circle2
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food = new Circle2 { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }

        private void GameOver()
        {
            tmr_game.Stop();

            if (score > highScore)
            {
                highScore = score;
                lbl_highscore.Text = "Maior pontuação: " + highScore;
            }
            lbl_prima.Visible = true;
        }

        private void TakeSnapShot()
        {
            Label caption = new Label();
            caption.Visible = true;
            caption.Text = "I scored: " + score + " and my highscore is " + highScore + " on the Snake";
            caption.Font = new Font("Comic sans MS", 14, FontStyle.Bold);
            caption.ForeColor = Color.White;
            caption.AutoSize = false;
            caption.Width = pic_canvas.Width;
            caption.Height = 30;
            caption.TextAlign = ContentAlignment.MiddleCenter;
            pic_canvas.Controls.Add(caption);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Snake Snapshot";
            dialog.DefaultExt = "png";
            dialog.Filter = "PNG Image File | *.png";
            dialog.ValidateNames = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pic_canvas.Width);
                int height = Convert.ToInt32(pic_canvas.Height);
                Bitmap bmp = new Bitmap(width, height);
                pic_canvas.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Png);
                pic_canvas.Controls.Remove(caption);
            }
            caption.Visible = false;
        }
    }
}
