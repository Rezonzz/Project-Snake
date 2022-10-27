namespace Proj_M9_BrunoPinheiro
{
    partial class frm_medio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_medio));
            this.lbl_prima = new System.Windows.Forms.Label();
            this.mst_snake = new System.Windows.Forms.MenuStrip();
            this.tsmi_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.regrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificuldadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_facil = new System.Windows.Forms.ToolStripMenuItem();
            this.dificilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_highscore = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.tmr_game = new System.Windows.Forms.Timer(this.components);
            this.snakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic_canvas = new System.Windows.Forms.PictureBox();
            this.mst_snake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_prima
            // 
            this.lbl_prima.AutoSize = true;
            this.lbl_prima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lbl_prima.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prima.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_prima.Location = new System.Drawing.Point(42, 210);
            this.lbl_prima.Name = "lbl_prima";
            this.lbl_prima.Size = new System.Drawing.Size(529, 23);
            this.lbl_prima.TabIndex = 82;
            this.lbl_prima.Text = "Prima \"Enter\" para começar / Prima \"S\" para tirar um Screenshot";
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
            this.mst_snake.TabIndex = 81;
            this.mst_snake.Text = "mst_top";
            this.mst_snake.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mst_snake_MouseDown);
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
            this.dificilToolStripMenuItem});
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
            this.tsmi_facil.Size = new System.Drawing.Size(135, 30);
            this.tsmi_facil.Text = "Fácil";
            this.tsmi_facil.Click += new System.EventHandler(this.tsmi_facil_Click);
            // 
            // dificilToolStripMenuItem
            // 
            this.dificilToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.dificilToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dificilToolStripMenuItem.Name = "dificilToolStripMenuItem";
            this.dificilToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.dificilToolStripMenuItem.Text = "Dificil";
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
            // lbl_highscore
            // 
            this.lbl_highscore.AutoSize = true;
            this.lbl_highscore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_highscore.Enabled = false;
            this.lbl_highscore.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_highscore.ForeColor = System.Drawing.Color.White;
            this.lbl_highscore.Location = new System.Drawing.Point(614, 79);
            this.lbl_highscore.Name = "lbl_highscore";
            this.lbl_highscore.Size = new System.Drawing.Size(124, 19);
            this.lbl_highscore.TabIndex = 79;
            this.lbl_highscore.Text = "Maior Pontuação: ";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_score.Enabled = false;
            this.lbl_score.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.White;
            this.lbl_score.Location = new System.Drawing.Point(614, 47);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(83, 19);
            this.lbl_score.TabIndex = 78;
            this.lbl_score.Text = "Pontuação: ";
            // 
            // tmr_game
            // 
            this.tmr_game.Interval = 45;
            this.tmr_game.Tick += new System.EventHandler(this.GameTimerEvent);
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
            // pic_canvas
            // 
            this.pic_canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pic_canvas.Location = new System.Drawing.Point(12, 47);
            this.pic_canvas.Name = "pic_canvas";
            this.pic_canvas.Size = new System.Drawing.Size(580, 420);
            this.pic_canvas.TabIndex = 80;
            this.pic_canvas.TabStop = false;
            this.pic_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // frm_medio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.lbl_prima);
            this.Controls.Add(this.mst_snake);
            this.Controls.Add(this.pic_canvas);
            this.Controls.Add(this.lbl_highscore);
            this.Controls.Add(this.lbl_score);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_medio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_medio";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.mst_snake.ResumeLayout(false);
            this.mst_snake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_prima;
        private System.Windows.Forms.MenuStrip mst_snake;
        private System.Windows.Forms.ToolStripMenuItem snakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_menu;
        private System.Windows.Forms.ToolStripMenuItem regrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dificuldadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_facil;
        private System.Windows.Forms.ToolStripMenuItem dificilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_logout;
        private System.Windows.Forms.ToolStripMenuItem tsmi_sair;
        private System.Windows.Forms.PictureBox pic_canvas;
        private System.Windows.Forms.Label lbl_highscore;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Timer tmr_game;
    }
}