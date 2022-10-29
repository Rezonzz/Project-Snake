﻿using Microsoft.VisualBasic;
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
    public partial class frm_1v1 : Form
    {

        Stopwatch stopWatch;
        private List<Circle4> Snake = new List<Circle4>();
        private Circle4 food = new Circle4();
        private List<Circle5> Snake2 = new List<Circle5>();
        private Circle5 food2 = new Circle5();
        string time, vitoriaS;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp, goLeft2, goRight2, goDown2, goUp2, gameover, gameover2;
        int maxWidth, maxHeight, maxWidth2, maxHeight2, score, score2, maxWidthS, maxHeightS, maxWidthS2, maxHeightS2, vitoria = 10, scorej1=0, scorej2=0, numvitorias1=0, numvitorias2=0;

        private void StartTimer()
        {
            stopWatch.Start();
        }

        private void StopTimer()
        {
            stopWatch.Stop();
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft2 = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight2 = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp2 = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown2 = false;
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
                    Snake[i].X * Settings4.Width,
                    Snake[i].Y * Settings4.Height,
                    Settings4.Width, Settings4.Height
                    ));
            }


            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
            (
            food.X * Settings4.Width,
            food.Y * Settings4.Height,
            Settings4.Width, Settings4.Height
            ));
        }

        private void UpdatePictureBoxGraphics2(object sender, PaintEventArgs e)
        {
            Graphics canvas2 = e.Graphics;

            Brush snakeColour2;

            for (int i = 0; i < Snake2.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour2 = Brushes.LightSlateGray;
                }
                else
                {
                    snakeColour2 = Brushes.White;
                }

                canvas2.FillEllipse(snakeColour2, new Rectangle
                    (
                    Snake2[i].X2 * Settings5.Width,
                    Snake2[i].Y2 * Settings5.Height,
                    Settings5.Width, Settings5.Height
                    ));
            }


            canvas2.FillEllipse(Brushes.DarkRed, new Rectangle
            (
            food2.X2 * Settings5.Width,
            food2.Y2 * Settings5.Height,
            Settings5.Width, Settings5.Height
            ));
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // setting the directions

            if (goLeft)
            {
                Settings4.directions = "left";
            }
            if (goRight)
            {
                Settings4.directions = "right";
            }
            if (goDown)
            {
                Settings4.directions = "down";
            }
            if (goUp)
            {
                Settings4.directions = "up";
            }
            // end of directions

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {

                    switch (Settings4.directions)
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
                    maxWidthS = pic_canvas.Size.Width / Settings4.Width - 1;
                    maxHeightS = pic_canvas.Size.Height / Settings4.Height - 1;

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

        private void GameTimerEvent2(object sender, EventArgs e)
        {
            // setting the directions

            if (goLeft2)
            {
                Settings5.directions = "left";
            }
            if (goRight2)
            {
                Settings5.directions = "right";
            }
            if (goDown2)
            {
                Settings5.directions = "down";
            }
            if (goUp2)
            {
                Settings5.directions = "up";
            }
            // end of directions

            for (int i = Snake2.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {

                    switch (Settings5.directions)
                    {
                        case "left":
                            Snake2[i].X2--;
                            break;
                        case "right":
                            Snake2[i].X2++;
                            break;
                        case "down":
                            Snake2[i].Y2++;
                            break;
                        case "up":
                            Snake2[i].Y2--;
                            break;
                    }

                    if (Snake2[i].X2 < 0)
                    {
                        Snake2[i].X2 = maxWidth2;
                    }
                    if (Snake2[i].X2 > maxWidth2)
                    {
                        Snake2[i].X2 = 0;
                    }
                    if (Snake2[i].Y2 < 0)
                    {
                        Snake2[i].Y2 = maxHeight2;
                    }
                    if (Snake2[i].Y2 > maxHeight2)
                    {
                        Snake2[i].Y2 = 0;
                    }

                    if (Snake2[i].X2 == food2.X2 && Snake2[i].Y2 == food2.Y2)
                    {
                        EatFood2();
                    }

                    // restrict the snake from leaving the canvas
                    maxWidthS2 = pic_canvas2.Size.Width / Settings5.Width - 1;
                    maxHeightS2 = pic_canvas2.Size.Height / Settings5.Height - 1;

                    for (int j = 1; j < Snake2.Count; j++)
                    {
                        if (Snake2[i].X2 == Snake2[j].X2 && Snake2[i].Y2 == Snake2[j].Y2)
                        {
                            GameOver2();
                        }
                        else if (Snake2[i].X2 == 0 || Snake2[i].Y2 == 0 || Snake2[i].X2 == maxWidthS2 || Snake2[i].Y2 == maxHeightS2)
                        {
                            // end the game is snake either reaches edge of the canvas
                            GameOver2();
                        }
                    }
                }
                else
                {
                    Snake2[i].X2 = Snake2[i - 1].X2;
                    Snake2[i].Y2 = Snake2[i - 1].Y2;
                }
            }

            pic_canvas2.Invalidate();
        }

        private void RestartGame()
        {
            if (score >= vitoria)
            {
                maxWidth = pic_canvas.Width / Settings4.Width - 1;
                maxHeight = pic_canvas.Height / Settings4.Height - 1;
                maxWidth2 = pic_canvas2.Width / Settings5.Width - 1;
                maxHeight2 = pic_canvas2.Height / Settings5.Height - 1;

                Snake.Clear();
                Snake2.Clear();
                gameover = false;
                gameover2 = false;
                ResetTimer();
                StartTimer();
                score = 0;
                score2 = 0;
                lbl_score.Text = "Maçãs: " + score;
                lbl_score2.Text = "Maçãs: " + score2;

                Circle4 head = new Circle4 { X = 17, Y = 12 };
                Snake.Add(head); // adding the head part of the snake to the list

                for (int i = 0; i < 10; i++)
                {
                    Circle4 body = new Circle4();
                    Snake.Add(body);
                }

                food = new Circle4 { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

                Circle5 head2 = new Circle5 { X2 = 17, Y2 = 12 };
                Snake2.Add(head2); // adding the head part of the snake to the list

                for (int i = 0; i < 10; i++)
                {
                    Circle5 body2 = new Circle5();
                    Snake2.Add(body2);
                }

                food2 = new Circle5 { X2 = rand.Next(2, maxWidth2), Y2 = rand.Next(2, maxHeight2) };

                tmr_game.Start();
                tmr_game2.Start();
            }
            else
            {
                maxWidth = pic_canvas.Width / Settings4.Width - 1;
                maxHeight = pic_canvas.Height / Settings4.Height - 1;
                maxWidth2 = pic_canvas2.Width / Settings5.Width - 1;
                maxHeight2 = pic_canvas2.Height / Settings5.Height - 1;

                Snake.Clear();
                Snake2.Clear();
                gameover = false;
                gameover2 = false;
                ResetTimer();
                StartTimer();
                score = 0;
                score2 = 0;
                lbl_score.Text = "Maçãs: " + score;
                lbl_score2.Text = "Maçãs: " + score2;

                Circle4 head = new Circle4 { X = 17, Y = 12 };
                Snake.Add(head); // adding the head part of the snake to the list

                for (int i = 0; i < 10; i++)
                {
                    Circle4 body = new Circle4();
                    Snake.Add(body);
                }

                food = new Circle4 { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

                Circle5 head2 = new Circle5 { X2 = 17, Y2 = 12 };
                Snake2.Add(head2); // adding the head part of the snake to the list

                for (int i = 0; i < 10; i++)
                {
                    Circle5 body2 = new Circle5();
                    Snake2.Add(body2);
                }

                food2 = new Circle5 { X2 = rand.Next(2, maxWidth2), Y2 = rand.Next(2, maxHeight2) };

                tmr_game.Start();
                tmr_game2.Start();
            }
        }

        private void lbl_mudarp_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_mudarp.ForeColor = Color.Teal;
        }

        private void lbl_mudarp_MouseLeave(object sender, EventArgs e)
        {
            lbl_mudarp.ForeColor = Color.FromArgb(255, 255, 128);
        }

        private void EatFood()
        {
            score += 1;

            lbl_score.Text = "Maçãs: " + score;
            Circle4 body = new Circle4
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food = new Circle4 { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            
        }

        private void Win()
        {
            tmr_game.Stop();
            tmr_game2.Stop();
            if(scorej1 >= vitoria)
            {
                numvitorias1++;
                lbl_v1.Text = "Vitórias: " + numvitorias1;
            }
            if (scorej2 >= vitoria)
            {
                numvitorias2++;
                lbl_v2.Text = "Vitórias: " + numvitorias2;
            }
            time = lbl_timer.Text;
            scorej1 = 0;
            scorej2 = 0;
            lbl_j1p.Text = scorej1.ToString();
            lbl_j2p.Text = scorej2.ToString();
            Snake.Clear();
            Snake2.Clear();
            food = new Circle4 { X = 0, Y = 0 };
            food2 = new Circle5 { X2 = 0, Y2 = 0 };
            StopTimer();
        }

        private void EatFood2()
        {
            score2 += 1;

            lbl_score2.Text = "Maçãs: " + score2;
            Circle5 body2 = new Circle5
            {
                X2 = Snake2[Snake2.Count - 1].X2,
                Y2 = Snake2[Snake2.Count - 1].Y2
            };

            Snake2.Add(body2);

            food2 = new Circle5 { X2 = rand.Next(2, maxWidth2), Y2 = rand.Next(2, maxHeight2) };
            if (scorej1 >= vitoria)
            {
                Win();
            }
            if (scorej2 >= vitoria)
            {
                Win();
            }
        }

        private void lbl_mudarp_Click(object sender, EventArgs e)
        {
            vitoriaS = Interaction.InputBox("Digite a Pontuação para a Vitória", "Inserir Pontuação");
            if (vitoriaS.Length > 0)
            {
                bool validar = int.TryParse(vitoriaS, out vitoria);
                if (validar)
                {
                    if (vitoria < 5 || vitoria > 100)
                    {
                        MessageBox.Show("Digite uma pontuação entre 5 a 100", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        vitoria = 10;
                    }
                    else
                    {
                        tmr_game.Stop();
                        tmr_game2.Stop();
                        time = lbl_timer.Text;
                        scorej1 = 0;
                        scorej2 = 0;
                        lbl_j1p.Text = scorej1.ToString();
                        lbl_j2p.Text = scorej2.ToString();
                        Snake.Clear();
                        Snake2.Clear();
                        food = new Circle4 { X = 0, Y = 0 };
                        food2 = new Circle5 { X2 = 0, Y2 = 0 };
                        StopTimer();

                        MessageBox.Show("Pontuação para vitória mudada com sucesso", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lbl_vitoria.Text = "Vitória: " + vitoria + " pontos";
                    }
                }
                else
                {
                    MessageBox.Show("Digitou uma letra", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (vitoria == 100)
            {
                lbl_vitoria.Size = new Size(152, 71);
                lbl_vitoria.Location = new Point(446, 252);
            }
            if (vitoria < 100)
            {
                lbl_vitoria.Size = new Size(131, 70);
                lbl_vitoria.Location = new Point(457, 252);
            }
            if (vitoria < 10)
            {
                lbl_vitoria.Size = new Size(123, 70);
                lbl_vitoria.Location = new Point(460, 252);
            }
        }

        /*private void Win()
        {
            tmr_game.Stop();
            time = lbl_timer.Text;
            if (score > highScore)
            {
                highScore = score;
                lbl_highscore.Text = "Maior Pontuação: " + highScore;
                highTime = time;
            }
            Snake.Clear();
            food = new Circle { X = 0, Y = 0 };
            pic_obanai.Visible = true;
            lbl_prima2.Visible = true;
            lbl_win.Visible = true;
            StopTimer();
        }*/
        private void GameOver()
        {
            gameover = true;
            tmr_game.Stop();
            time = lbl_timer.Text;
            if (gameover == true && gameover2 == true)
            {
                StopTimer();
                if (score > score2)
                {
                    scorej1++;
                    lbl_j1p.Text = scorej1.ToString();
                }
                if (score < score2)
                {
                    scorej2++;
                    lbl_j2p.Text = scorej2.ToString();
                }
            }
            Snake.Clear();
            food = new Circle4 { X = -1, Y = -1 };
            if (scorej1 >= vitoria)
            {
                Win();
            }
            if (scorej2 >= vitoria)
            {
                Win();
            }
        }

        private void GameOver2()
        {
            gameover2 = true;
            tmr_game2.Stop();
            time = lbl_timer.Text;
            if (gameover == true && gameover2 == true)
            {
                StopTimer();
                if (score > score2)
                {
                    scorej1++;
                    lbl_j1p.Text = scorej1.ToString();
                }
                if (score < score2)
                {
                    scorej2++;
                    lbl_j2p.Text = scorej2.ToString();
                }
            }
            Snake2.Clear();
            food2 = new Circle5 { X2 = -1, Y2 = -1 };
            if (scorej1 >= vitoria)
            {
                Win();
            }
            if (scorej2 >= vitoria)
            {
                Win();
            }
        }

        private void ResetTimer()
        {
            stopWatch.Reset();
        }
        private void tmr_temp_Tick(object sender, EventArgs e)
        {
            lbl_timer.Text = String.Format("{0:mm\\:ss\\.ff}", stopWatch.Elapsed);
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

        private void tsmi_dificil_Click(object sender, EventArgs e)
        {
            frm_dificil frm_dificil = new frm_dificil();
            frm_dificil.Show();
            this.Hide();
        }

        private void tsmi_menu_Click(object sender, EventArgs e)
        {
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
            this.Hide();
        }

        private void tsmi_dificuldade_Click(object sender, EventArgs e)
        {
            tsmi_dificuldade.ForeColor = Color.Black;
        }

        private void tsmi_dificuldade_MouseLeave(object sender, EventArgs e)
        {
            tsmi_dificuldade.ForeColor = Color.White;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RestartGame();
            }
            if (e.KeyCode == Keys.T)
            {
                //TakeSnapShot();
            }
            if (e.KeyCode == Keys.Left && Settings5.directions != "right")
            {
                goLeft2 = true;
            }
            if (e.KeyCode == Keys.Right && Settings5.directions != "left")
            {
                goRight2 = true;
            }
            if (e.KeyCode == Keys.Up && Settings5.directions != "down")
            {
                goUp2 = true;
            }
            if (e.KeyCode == Keys.Down && Settings5.directions != "up")
            {
                goDown2 = true;
            }
            if (e.KeyCode == Keys.A && Settings4.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.D && Settings4.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.W && Settings4.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.S && Settings4.directions != "up")
            {
                goDown = true;
            }
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
        public frm_1v1()
        {
            InitializeComponent();
            new Settings4();
            new Settings5();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 16, 16));
        }

        private void frm_1v1_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }
    }
}
