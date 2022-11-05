﻿using System;
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
    public partial class frm_semlimites : Form
    {
        Stopwatch stopWatch;
        private List<Circle6> Snake = new List<Circle6>();
        private Circle6 food = new Circle6();

        int maxWidth, maxHeight, score, highScore, maxWidthS, maxHeightS;
        string time, highTime;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp, gameover;

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
        public frm_semlimites()
        {
            InitializeComponent();
            new Settings6();
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

        private void tsmi_dificuldade_Click(object sender, EventArgs e)
        {
            tsmi_modo.ForeColor = Color.Black;
        }

        private void tsmi_modo_Click(object sender, EventArgs e)
        {
            tsmi_modo.ForeColor = Color.Black;
        }

        private void tsmi_menu_Click(object sender, EventArgs e)
        {
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
            this.Close();
        }

        private void tsmi_multiplayer_Click(object sender, EventArgs e)
        {
            frm_1v1 frm_1v1 = new frm_1v1();
            frm_1v1.Show();
            this.Close();
        }

        private void tsmi_mtfacil_Click(object sender, EventArgs e)
        {
            frm_mtfacil frm_mtfacil = new frm_mtfacil();
            frm_mtfacil.Show();
            this.Close();
        }

        private void tsmi_facil_Click(object sender, EventArgs e)
        {
            frm_facil frm_facil = new frm_facil();
            frm_facil.Show();
            this.Close();
        }

        private void tsmi_medio_Click(object sender, EventArgs e)
        {
            frm_medio frm_medio = new frm_medio();
            frm_medio.Show();
            this.Close();
        }

        private void tsmi_dificil_Click(object sender, EventArgs e)
        {
            frm_dificil frm_dificil = new frm_dificil();
            frm_dificil.Show();
            this.Close();
        }

        private void tsmi_modo_MouseLeave(object sender, EventArgs e)
        {
            tsmi_modo.ForeColor = Color.White;
        }

        private void tsmi_dificuldade_MouseLeave(object sender, EventArgs e)
        {
            tsmi_modo.ForeColor = Color.White;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void mst_snake_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
            if (e.KeyCode == Keys.Left && Settings6.directions != "right" && Settings6.directions != "left")
            {
                goLeft = true;
                if (gameover == false)
                {
                    left.URL = Application.StartupPath + @"\\left.mp3";
                    left.controls.play();
                }
            }
            if (e.KeyCode == Keys.Right && Settings6.directions != "left" && Settings6.directions != "right")
            {
                goRight = true;
                if (gameover == false)
                {
                    right.URL = Application.StartupPath + @"\\right.mp3";
                    right.controls.play();
                }
            }
            if (e.KeyCode == Keys.Up && Settings6.directions != "down" && Settings6.directions != "up")
            {
                goUp = true;
                if (gameover == false)
                {
                    up.URL = Application.StartupPath + @"\\up.mp3";
                    up.controls.play();
                }
            }
            if (e.KeyCode == Keys.Down && Settings6.directions != "up" && Settings6.directions != "down")
            {
                goDown = true;
                if (gameover == false)
                {
                    down.URL = Application.StartupPath + @"\\down.mp3";
                    down.controls.play();
                }
            }
            if (e.KeyCode == Keys.A && Settings6.directions != "right" && Settings6.directions != "left")
            {
                goLeft = true;
                if (gameover == false)
                {
                    left.URL = Application.StartupPath + @"\\left.mp3";
                    left.controls.play();
                }
            }
            if (e.KeyCode == Keys.D && Settings6.directions != "left" && Settings6.directions != "right")
            {
                goRight = true;
                if (gameover == false)
                {
                    right.URL = Application.StartupPath + @"\\right.mp3";
                    right.controls.play();
                }
            }
            if (e.KeyCode == Keys.W && Settings6.directions != "down" && Settings6.directions != "up")
            {
                goUp = true;
                if (gameover == false)
                {
                    up.URL = Application.StartupPath + @"\\up.mp3";
                    up.controls.play();
                }
            }
            if (e.KeyCode == Keys.S && Settings6.directions != "up" && Settings6.directions != "down")
            {
                goDown = true;
                if (gameover == false)
                {
                    down.URL = Application.StartupPath + @"\\down.mp3";
                    down.controls.play();
                }
            }
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
                    Snake[i].X * Settings6.Width,
                    Snake[i].Y * Settings6.Height,
                    Settings6.Width, Settings6.Height
                    ));
            }


            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
            (
            food.X * Settings6.Width,
            food.Y * Settings6.Height,
            Settings6.Width, Settings6.Height
            ));
        }

        private void tmr_prima_Tick(object sender, EventArgs e)
        {
            lbl_prima.ForeColor = lbl_prima.ForeColor == Color.FromArgb(17, 17, 17) ? Color.White : Color.FromArgb(17, 17, 17);
            lbl_prima2.ForeColor = lbl_prima2.ForeColor == Color.FromArgb(17, 17, 17) ? Color.White : Color.FromArgb(17, 17, 17);
        }

        private void TakeSnapShot()
        {
            Label caption = new Label();
            caption.Visible = true;
            caption.Text = "Número de Maçãs Comidas: " + score + " em " + time + " e Maior Número de Maçãs Comidas: " + highScore + " em " + highTime + " no Jogo do Snake - Modo Sem Limites";
            caption.Font = new Font("Comic sans MS", 14, FontStyle.Bold);
            caption.ForeColor = Color.White;
            caption.BackColor = Color.Transparent;
            caption.AutoSize = false;
            caption.Width = pic_canvas.Width;
            caption.Height = 100;
            caption.TextAlign = ContentAlignment.MiddleCenter;
            pic_canvas.Controls.Add(caption);
            pic_canvas.Controls.Add(pic_obanai);
            takeshot.URL = Application.StartupPath + @"\\takeshot.mp3";
            takeshot.controls.play();
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

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // setting the directions

            if (goLeft)
            {
                Settings6.directions = "left";
            }
            if (goRight)
            {
                Settings6.directions = "right";
            }
            if (goDown)
            {
                Settings6.directions = "down";
            }
            if (goUp)
            {
                Settings6.directions = "up";
            }
            // end of directions

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {

                    switch (Settings6.directions)
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
                    maxWidthS = pic_canvas.Size.Width / Settings6.Width - 1;
                    maxHeightS = pic_canvas.Size.Height / Settings6.Height - 1;

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

        WMPLib.WindowsMediaPlayer up = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer down = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer left = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer right = new WMPLib.WindowsMediaPlayer();

        private void tsmi_creditos_Click(object sender, EventArgs e)
        {
            frm_creditos frm_creditos = new frm_creditos();
            frm_creditos.Show();
        }

        private void pic_info_Click(object sender, EventArgs e)
        {
            frm_infosl frm_infosl = new frm_infosl();
            frm_infosl.Show();
        }

        private void tmr_temp_Tick(object sender, EventArgs e)
        {
            lbl_timer.Text = String.Format("{0:mm\\:ss\\.ff}", stopWatch.Elapsed);
        }

        WMPLib.WindowsMediaPlayer die = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer eat = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer start = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer takeshot = new WMPLib.WindowsMediaPlayer();
        private void frm_semlimites_Load(object sender, EventArgs e)
        {
            tmr_prima.Enabled = true;
            stopWatch = new Stopwatch();
        }

        private void RestartGame()
        {
            start.URL = Application.StartupPath + @"\\start.mp3";
            start.controls.play();
            gameover = false;
            maxWidth = pic_canvas.Width / Settings6.Width - 1;
            maxHeight = pic_canvas.Height / Settings6.Height - 1;

            Snake.Clear();
            ResetTimer();
            StartTimer();
            lbl_prima.Visible = false;
            lbl_prima2.Visible = false;
            pic_obanai.Visible = false;
            lbl_gameover.Visible = false;
            score = 0;
            lbl_score.Text = "Maçãs: " + score;

            Circle6 head = new Circle6 { X = 17, Y = 12 };
            Snake.Add(head); // adding the head part of the snake to the list

            for (int i = 0; i < 10; i++)
            {
                Circle6 body = new Circle6();
                Snake.Add(body);
            }

            food = new Circle6 { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            tmr_game.Start();
        }
        private void EatFood()
        {
            score += 1;
            eat.URL = Application.StartupPath + @"\\eat.mp3";
            eat.controls.play();
            lbl_score.Text = "Maçãs: " + score;
            Circle6 body = new Circle6
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food = new Circle6 { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }

        private void GameOver()
        {
            tmr_game.Stop();
            die.URL = Application.StartupPath + @"\\die.mp3";
            die.controls.play();
            gameover = true;
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
            food = new Circle6 { X = -1, Y = -1 };
            lbl_gameover.Visible = true;
            pic_obanai.Visible = true;
        }
    }
}
