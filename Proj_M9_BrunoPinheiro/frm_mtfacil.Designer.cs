﻿namespace Proj_M9_BrunoPinheiro
{
    partial class frm_mtfacil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mtfacil));
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_highscore = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.lbl_prima = new System.Windows.Forms.Label();
            this.mst_snake = new System.Windows.Forms.MenuStrip();
            this.snakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.regrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificuldadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_facil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_medio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.pic_canvas = new System.Windows.Forms.PictureBox();
            this.tmr_game = new System.Windows.Forms.Timer(this.components);
            this.tmr_temp = new System.Windows.Forms.Timer(this.components);
            this.difícilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_modo = new System.Windows.Forms.Label();
            this.lbl_win = new System.Windows.Forms.Label();
            this.lbl_prima2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_obanai = new System.Windows.Forms.PictureBox();
            this.lbl_gameover = new System.Windows.Forms.Label();
            this.mst_snake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_canvas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_obanai)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_score.Location = new System.Drawing.Point(622, 150);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(104, 21);
            this.lbl_score.TabIndex = 91;
            this.lbl_score.Text = "Pontuação: 0";
            // 
            // lbl_highscore
            // 
            this.lbl_highscore.AutoSize = true;
            this.lbl_highscore.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_highscore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_highscore.Location = new System.Drawing.Point(621, 182);
            this.lbl_highscore.Name = "lbl_highscore";
            this.lbl_highscore.Size = new System.Drawing.Size(151, 21);
            this.lbl_highscore.TabIndex = 90;
            this.lbl_highscore.Text = "Maior Pontuação: 0";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_timer.Location = new System.Drawing.Point(634, 90);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(118, 33);
            this.lbl_timer.TabIndex = 89;
            this.lbl_timer.Text = "00:00.00";
            // 
            // lbl_prima
            // 
            this.lbl_prima.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prima.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prima.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_prima.Location = new System.Drawing.Point(0, 176);
            this.lbl_prima.Name = "lbl_prima";
            this.lbl_prima.Size = new System.Drawing.Size(580, 23);
            this.lbl_prima.TabIndex = 88;
            this.lbl_prima.Text = "Prima \"Enter\" para começar / Prima \"S\" para tirar um Screenshot";
            this.lbl_prima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mst_snake
            // 
            this.mst_snake.BackColor = System.Drawing.Color.Black;
            this.mst_snake.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snakeToolStripMenuItem,
            this.tsmi_menu,
            this.regrasToolStripMenuItem,
            this.dificuldadeToolStripMenuItem,
            this.tsmi_logout,
            this.tsmi_sair});
            this.mst_snake.Location = new System.Drawing.Point(0, 0);
            this.mst_snake.Name = "mst_snake";
            this.mst_snake.Size = new System.Drawing.Size(800, 34);
            this.mst_snake.TabIndex = 87;
            this.mst_snake.Text = "mst_top";
            this.mst_snake.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mst_snake_MouseDown);
            // 
            // snakeToolStripMenuItem
            // 
            this.snakeToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snakeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.snakeToolStripMenuItem.Image = global::Proj_M9_BrunoPinheiro.Properties.Resources.snake1;
            this.snakeToolStripMenuItem.Name = "snakeToolStripMenuItem";
            this.snakeToolStripMenuItem.Size = new System.Drawing.Size(82, 30);
            this.snakeToolStripMenuItem.Text = "Snake";
            // 
            // tsmi_menu
            // 
            this.tsmi_menu.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmi_menu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmi_menu.Name = "tsmi_menu";
            this.tsmi_menu.Size = new System.Drawing.Size(71, 30);
            this.tsmi_menu.Text = "Menu";
            this.tsmi_menu.Click += new System.EventHandler(this.tsmi_menu_Click);
            // 
            // regrasToolStripMenuItem
            // 
            this.regrasToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regrasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.regrasToolStripMenuItem.Name = "regrasToolStripMenuItem";
            this.regrasToolStripMenuItem.Size = new System.Drawing.Size(84, 30);
            this.regrasToolStripMenuItem.Text = "Regras";
            // 
            // dificuldadeToolStripMenuItem
            // 
            this.dificuldadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_facil,
            this.tsmi_medio,
            this.difícilToolStripMenuItem});
            this.dificuldadeToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dificuldadeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dificuldadeToolStripMenuItem.Name = "dificuldadeToolStripMenuItem";
            this.dificuldadeToolStripMenuItem.Size = new System.Drawing.Size(123, 30);
            this.dificuldadeToolStripMenuItem.Text = "Dificuldade";
            // 
            // tsmi_facil
            // 
            this.tsmi_facil.BackColor = System.Drawing.Color.Black;
            this.tsmi_facil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmi_facil.Name = "tsmi_facil";
            this.tsmi_facil.Size = new System.Drawing.Size(180, 30);
            this.tsmi_facil.Text = "Fácil";
            this.tsmi_facil.Click += new System.EventHandler(this.tsmi_facil_Click);
            // 
            // tsmi_medio
            // 
            this.tsmi_medio.BackColor = System.Drawing.Color.Black;
            this.tsmi_medio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmi_medio.Name = "tsmi_medio";
            this.tsmi_medio.Size = new System.Drawing.Size(180, 30);
            this.tsmi_medio.Text = "Médio";
            this.tsmi_medio.Click += new System.EventHandler(this.tsmi_medio_Click);
            // 
            // tsmi_logout
            // 
            this.tsmi_logout.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmi_logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmi_logout.Name = "tsmi_logout";
            this.tsmi_logout.Size = new System.Drawing.Size(93, 30);
            this.tsmi_logout.Text = "Log Out";
            this.tsmi_logout.Click += new System.EventHandler(this.tsmi_logout_Click);
            // 
            // tsmi_sair
            // 
            this.tsmi_sair.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmi_sair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmi_sair.Name = "tsmi_sair";
            this.tsmi_sair.Size = new System.Drawing.Size(60, 30);
            this.tsmi_sair.Text = "Sair";
            this.tsmi_sair.Click += new System.EventHandler(this.tsmi_sair_Click);
            // 
            // pic_canvas
            // 
            this.pic_canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pic_canvas.Location = new System.Drawing.Point(0, 0);
            this.pic_canvas.Name = "pic_canvas";
            this.pic_canvas.Size = new System.Drawing.Size(580, 420);
            this.pic_canvas.TabIndex = 86;
            this.pic_canvas.TabStop = false;
            this.pic_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // tmr_game
            // 
            this.tmr_game.Interval = 70;
            this.tmr_game.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // tmr_temp
            // 
            this.tmr_temp.Enabled = true;
            this.tmr_temp.Tick += new System.EventHandler(this.tmr_temp_Tick);
            // 
            // difícilToolStripMenuItem
            // 
            this.difícilToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.difícilToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.difícilToolStripMenuItem.Name = "difícilToolStripMenuItem";
            this.difícilToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.difícilToolStripMenuItem.Text = "Difícil";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(635, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 87);
            this.label1.TabIndex = 92;
            this.label1.Text = "Objetivo: 15 pontos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(615, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 1);
            this.panel1.TabIndex = 94;
            // 
            // lbl_modo
            // 
            this.lbl_modo.AutoSize = true;
            this.lbl_modo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_modo.Location = new System.Drawing.Point(601, 47);
            this.lbl_modo.Name = "lbl_modo";
            this.lbl_modo.Size = new System.Drawing.Size(190, 27);
            this.lbl_modo.TabIndex = 93;
            this.lbl_modo.Text = "Modo - Muito Fácil";
            // 
            // lbl_win
            // 
            this.lbl_win.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_win.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_win.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(137)))));
            this.lbl_win.Location = new System.Drawing.Point(0, 97);
            this.lbl_win.Name = "lbl_win";
            this.lbl_win.Size = new System.Drawing.Size(580, 59);
            this.lbl_win.TabIndex = 96;
            this.lbl_win.Text = "Objetivo Concluído!";
            this.lbl_win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_win.Visible = false;
            // 
            // lbl_prima2
            // 
            this.lbl_prima2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prima2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prima2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_prima2.Location = new System.Drawing.Point(0, 193);
            this.lbl_prima2.Name = "lbl_prima2";
            this.lbl_prima2.Size = new System.Drawing.Size(580, 23);
            this.lbl_prima2.TabIndex = 95;
            this.lbl_prima2.Text = "Prima \"Enter\" para recomeçar / Prima \"S\" para tirar um Screenshot";
            this.lbl_prima2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_prima2.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.lbl_gameover);
            this.panel2.Controls.Add(this.pic_obanai);
            this.panel2.Controls.Add(this.lbl_prima);
            this.panel2.Controls.Add(this.lbl_prima2);
            this.panel2.Controls.Add(this.lbl_win);
            this.panel2.Controls.Add(this.pic_canvas);
            this.panel2.Location = new System.Drawing.Point(12, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 420);
            this.panel2.TabIndex = 97;
            // 
            // pic_obanai
            // 
            this.pic_obanai.Image = global::Proj_M9_BrunoPinheiro.Properties.Resources.obanaiico;
            this.pic_obanai.Location = new System.Drawing.Point(154, 244);
            this.pic_obanai.Name = "pic_obanai";
            this.pic_obanai.Size = new System.Drawing.Size(270, 149);
            this.pic_obanai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_obanai.TabIndex = 97;
            this.pic_obanai.TabStop = false;
            this.pic_obanai.Visible = false;
            // 
            // lbl_gameover
            // 
            this.lbl_gameover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_gameover.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_gameover.Location = new System.Drawing.Point(0, 97);
            this.lbl_gameover.Name = "lbl_gameover";
            this.lbl_gameover.Size = new System.Drawing.Size(580, 59);
            this.lbl_gameover.TabIndex = 98;
            this.lbl_gameover.Text = "Tu Falhaste!";
            this.lbl_gameover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_gameover.Visible = false;
            // 
            // frm_mtfacil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_modo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_highscore);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.mst_snake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_mtfacil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake - Modo Muito Fácil";
            this.Load += new System.EventHandler(this.frm_mtfacil_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.mst_snake.ResumeLayout(false);
            this.mst_snake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_canvas)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_obanai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_highscore;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Label lbl_prima;
        private System.Windows.Forms.MenuStrip mst_snake;
        private System.Windows.Forms.ToolStripMenuItem snakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_menu;
        private System.Windows.Forms.ToolStripMenuItem regrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dificuldadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_facil;
        private System.Windows.Forms.ToolStripMenuItem tsmi_medio;
        private System.Windows.Forms.ToolStripMenuItem tsmi_logout;
        private System.Windows.Forms.ToolStripMenuItem tsmi_sair;
        private System.Windows.Forms.PictureBox pic_canvas;
        private System.Windows.Forms.Timer tmr_game;
        private System.Windows.Forms.Timer tmr_temp;
        private System.Windows.Forms.ToolStripMenuItem difícilToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_modo;
        private System.Windows.Forms.Label lbl_win;
        private System.Windows.Forms.Label lbl_prima2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_obanai;
        private System.Windows.Forms.Label lbl_gameover;
    }
}