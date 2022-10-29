using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_M9_BrunoPinheiro
{
    public partial class frm_dificil : Form
    {
        Stopwatch stopWatch;
        private List<Circle3> Snake = new List<Circle3>();
        private Circle3 food = new Circle3();

        int maxWidth, maxHeight, score, highScore, maxWidthS, maxHeightS;
        string time, highTime;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void tmr_temp_Tick(object sender, EventArgs e)
        {
            lbl_timer.Text = String.Format("{0:mm\\:ss\\.ff}", stopWatch.Elapsed);
        }

        private void StartTimer()
        {
            stopWatch.Start();
        }

        private void StopTimer()
        {
            stopWatch.Stop();
        }

        private void ResetTimer()
        {
            stopWatch.Reset();
        }

        private void frm_dificil_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RestartGame();
            }
            if (e.KeyCode == Keys.T)
            {
                TakeSnapShot();
            }
            if (e.KeyCode == Keys.Left && Settings3.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings3.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings3.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings3.directions != "up")
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.A && Settings3.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.D && Settings3.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.W && Settings3.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.S && Settings3.directions != "up")
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
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }
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
                    Snake[i].X * Settings3.Width,
                    Snake[i].Y * Settings3.Height,
                    Settings3.Width, Settings3.Height
                    ));
            }


            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
            (
            food.X * Settings3.Width,
            food.Y * Settings3.Height,
            Settings3.Width, Settings3.Height
            ));
        }

        private void tsmi_dificuldade_Click(object sender, EventArgs e)
        {
            tsmi_dificuldade.ForeColor = Color.Black;
        }

        private void tsmi_dificuldade_MouseLeave(object sender, EventArgs e)
        {
            tsmi_dificuldade.ForeColor = Color.White;
        }

        private void mst_snake_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // setting the directions

            if (goLeft)
            {
                Settings3.directions = "left";
            }
            if (goRight)
            {
                Settings3.directions = "right";
            }
            if (goDown)
            {
                Settings3.directions = "down";
            }
            if (goUp)
            {
                Settings3.directions = "up";
            }
            // end of directions

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {

                    switch (Settings3.directions)
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

                    // restrict the snake from leaving the canvas
                    maxWidthS = pic_canvas.Size.Width / Settings3.Width - 1;
                    maxHeightS = pic_canvas.Size.Height / Settings3.Height - 1;

                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                        else if (Snake[i].X == 0 || Snake[i].Y == 0 || Snake[i].X == maxWidthS || Snake[i].Y == maxHeightS)
                        {
                            // end the game is snake either reaches edge of the canvas
                            GameOver();
                        }
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
        public frm_dificil()
        {
            InitializeComponent();
            new Settings3();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 16, 16));
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

        private void tsmi_mtfacil_Click(object sender, EventArgs e)
        {
            frm_mtfacil frm_mtfacil = new frm_mtfacil();
            frm_mtfacil.Show();
            this.Hide();
        }

        private void tsmi_facil_Click(object sender, EventArgs e)
        {
            frm_facil frm_facil = new frm_facil();
            frm_facil.Show();
            this.Hide();
        }

        private void tsmi_medio_Click(object sender, EventArgs e)
        {
            frm_medio frm_medio = new frm_medio();
            frm_medio.Show();
            this.Hide();
        }

        private void TakeSnapShot()
        {
            Label caption = new Label();
            caption.Visible = true;
            caption.Text = "Número de Maçãs Comidas: " + score + " em " + time + " e Maior Número de Maçãs Comidas: " + highScore + " em " + highTime + " no Jogo do Snake - Modo Difícil";
            caption.Font = new Font("Comic sans MS", 14, FontStyle.Bold);
            caption.ForeColor = Color.White;
            caption.BackColor = Color.Transparent;
            caption.AutoSize = false;
            caption.Width = pic_canvas.Width;
            caption.Height = 60;
            caption.TextAlign = ContentAlignment.MiddleCenter;
            pic_canvas.Controls.Add(caption);
            pic_canvas.Controls.Add(lbl_gameover);
            pic_canvas.Controls.Add(lbl_win);
            pic_canvas.Controls.Add(pic_obanai);

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
        private void RestartGame()
        {
            if (score < 40)
            {
                maxWidth = pic_canvas.Width / Settings3.Width - 1;
                maxHeight = pic_canvas.Height / Settings3.Height - 1;

                Snake.Clear();
                ResetTimer();
                StartTimer();
                lbl_prima.Visible = false;
                lbl_prima2.Visible = false;
                pic_obanai.Visible = false;
                lbl_win.Visible = false;
                lbl_gameover.Visible = false;
                score = 0;
                lbl_score.Text = "Maçãs: " + score;

                Circle3 head = new Circle3 { X = 23, Y = 16 };
                Snake.Add(head); // adding the head part of the snake to the list

                for (int i = 0; i < 10; i++)
                {
                    Circle3 body = new Circle3();
                    Snake.Add(body);
                }

                food = new Circle3 { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

                tmr_game.Start();
            }
            else
            {
                maxWidth = pic_canvas.Width / Settings3.Width - 1;
                maxHeight = pic_canvas.Height / Settings3.Height - 1;

                Snake.Clear();
                ResetTimer();
                StartTimer();
                lbl_prima.Visible = false;
                lbl_prima2.Visible = false;
                pic_obanai.Visible = false;
                lbl_win.Visible = false;
                lbl_gameover.Visible = false;
                score = 0;
                lbl_score.Text = "Maçãs: " + score;
                highScore = 0;
                lbl_highscore.Text = "Maior Número de Maçãs Comidas: " + highScore;
                Circle3 head = new Circle3 { X = 10, Y = 5 };
                Snake.Add(head); // adding the head part of the snake to the list

                for (int i = 0; i < 10; i++)
                {
                    Circle3 body = new Circle3();
                    Snake.Add(body);
                }

                food = new Circle3 { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

                tmr_game.Start();
            }
        }
        private void EatFood()
        {
            score += 1;

            lbl_score.Text = "Maçãs: " + score;
            Circle3 body = new Circle3
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food = new Circle3 { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            if (score >= 40)
            {
                Win();
            }
        }

        private void Win()
        {
            tmr_game.Stop();
            time = lbl_timer.Text;
            if (score > highScore)
            {
                highScore = score;
                lbl_highscore.Text = "Maior Número de Maçãs Comidas: " + highScore;
                highTime = time;
            }
            Snake.Clear();
            food = new Circle3 { X = 0, Y = 0 };
            pic_obanai.Visible = true;
            lbl_prima2.Visible = true;
            lbl_win.Visible = true;
            StopTimer();
        }
        private void GameOver()
        {
            tmr_game.Stop();
            time = lbl_timer.Text;
            if (score > highScore)
            {
                highScore = score;
                lbl_highscore.Text = "Maior Número de Maçãs Comidas: " + highScore;
                highTime = time;
            }
            lbl_prima.Visible = true;
            StopTimer();


            Snake.Clear();
            food = new Circle3 { X = -1, Y = -1 };
            lbl_gameover.Visible = true;
            pic_obanai.Visible = true;
        }
    }
}
