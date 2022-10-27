namespace Proj_M9_BrunoPinheiro
{
    partial class frm_facil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_facil));
            this.btn_comecar = new System.Windows.Forms.Button();
            this.btn_snap = new System.Windows.Forms.Button();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_highscore = new System.Windows.Forms.Label();
            this.pic_canvas = new System.Windows.Forms.PictureBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.tmr_game = new System.Windows.Forms.Timer(this.components);
            this.mst_snake = new System.Windows.Forms.MenuStrip();
            this.snakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.regrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificuldadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fácilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difícilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_canvas)).BeginInit();
            this.mst_snake.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_comecar
            // 
            this.btn_comecar.FlatAppearance.BorderSize = 2;
            this.btn_comecar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comecar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comecar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_comecar.Location = new System.Drawing.Point(617, 69);
            this.btn_comecar.Name = "btn_comecar";
            this.btn_comecar.Size = new System.Drawing.Size(160, 53);
            this.btn_comecar.TabIndex = 70;
            this.btn_comecar.Text = "Começar";
            this.btn_comecar.UseVisualStyleBackColor = true;
            this.btn_comecar.Click += new System.EventHandler(this.StartGame);
            // 
            // btn_snap
            // 
            this.btn_snap.FlatAppearance.BorderSize = 2;
            this.btn_snap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_snap.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_snap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_snap.Location = new System.Drawing.Point(617, 139);
            this.btn_snap.Name = "btn_snap";
            this.btn_snap.Size = new System.Drawing.Size(160, 53);
            this.btn_snap.TabIndex = 71;
            this.btn_snap.Text = "Snap";
            this.btn_snap.UseVisualStyleBackColor = true;
            this.btn_snap.Click += new System.EventHandler(this.TakeSnapShot);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_score.Enabled = false;
            this.lbl_score.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.White;
            this.lbl_score.Location = new System.Drawing.Point(613, 210);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(83, 19);
            this.lbl_score.TabIndex = 72;
            this.lbl_score.Text = "Pontuação: ";
            this.lbl_score.Visible = false;
            // 
            // lbl_highscore
            // 
            this.lbl_highscore.AutoSize = true;
            this.lbl_highscore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_highscore.Enabled = false;
            this.lbl_highscore.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_highscore.ForeColor = System.Drawing.Color.White;
            this.lbl_highscore.Location = new System.Drawing.Point(613, 242);
            this.lbl_highscore.Name = "lbl_highscore";
            this.lbl_highscore.Size = new System.Drawing.Size(124, 19);
            this.lbl_highscore.TabIndex = 73;
            this.lbl_highscore.Text = "Maior Pontuação: ";
            this.lbl_highscore.Visible = false;
            // 
            // pic_canvas
            // 
            this.pic_canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pic_canvas.Location = new System.Drawing.Point(12, 47);
            this.pic_canvas.Name = "pic_canvas";
            this.pic_canvas.Size = new System.Drawing.Size(580, 680);
            this.pic_canvas.TabIndex = 74;
            this.pic_canvas.TabStop = false;
            this.pic_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_time.Enabled = false;
            this.lbl_time.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(613, 271);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(61, 19);
            this.lbl_time.TabIndex = 75;
            this.lbl_time.Text = "Tempo: ";
            this.lbl_time.Visible = false;
            // 
            // tmr_game
            // 
            this.tmr_game.Interval = 40;
            this.tmr_game.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // mst_snake
            // 
            this.mst_snake.BackColor = System.Drawing.Color.Black;
            this.mst_snake.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snakeToolStripMenuItem,
            this.tsmi_menu,
            this.regrasToolStripMenuItem,
            this.dificuldadeToolStripMenuItem,
            this.tsmi_logout});
            this.mst_snake.Location = new System.Drawing.Point(0, 0);
            this.mst_snake.Name = "mst_snake";
            this.mst_snake.Size = new System.Drawing.Size(800, 34);
            this.mst_snake.TabIndex = 76;
            this.mst_snake.Text = "menuStrip1";
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
            this.fácilToolStripMenuItem,
            this.difícilToolStripMenuItem,
            this.dificilToolStripMenuItem});
            this.dificuldadeToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dificuldadeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dificuldadeToolStripMenuItem.Name = "dificuldadeToolStripMenuItem";
            this.dificuldadeToolStripMenuItem.Size = new System.Drawing.Size(123, 30);
            this.dificuldadeToolStripMenuItem.Text = "Dificuldade";
            // 
            // fácilToolStripMenuItem
            // 
            this.fácilToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.fácilToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fácilToolStripMenuItem.Name = "fácilToolStripMenuItem";
            this.fácilToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.fácilToolStripMenuItem.Text = "Fácil";
            // 
            // difícilToolStripMenuItem
            // 
            this.difícilToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.difícilToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.difícilToolStripMenuItem.Name = "difícilToolStripMenuItem";
            this.difícilToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.difícilToolStripMenuItem.Text = "Médio";
            // 
            // dificilToolStripMenuItem
            // 
            this.dificilToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.dificilToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dificilToolStripMenuItem.Name = "dificilToolStripMenuItem";
            this.dificilToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.dificilToolStripMenuItem.Text = "Dificil";
            // 
            // tsmi_logout
            // 
            this.tsmi_logout.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmi_logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmi_logout.Name = "tsmi_logout";
            this.tsmi_logout.Size = new System.Drawing.Size(93, 30);
            this.tsmi_logout.Text = "Log Out";
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Black;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Image = global::Proj_M9_BrunoPinheiro.Properties.Resources.minus__3___1_;
            this.btn_minimize.Location = new System.Drawing.Point(730, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(35, 35);
            this.btn_minimize.TabIndex = 78;
            this.btn_minimize.UseVisualStyleBackColor = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Black;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::Proj_M9_BrunoPinheiro.Properties.Resources.close__1___1_;
            this.btn_close.Location = new System.Drawing.Point(765, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 77;
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // frm_facil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.mst_snake);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.pic_canvas);
            this.Controls.Add(this.lbl_highscore);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.btn_snap);
            this.Controls.Add(this.btn_comecar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_facil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake - Modo Fácil";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic_canvas)).EndInit();
            this.mst_snake.ResumeLayout(false);
            this.mst_snake.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_comecar;
        private System.Windows.Forms.Button btn_snap;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_highscore;
        private System.Windows.Forms.PictureBox pic_canvas;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer tmr_game;
        private System.Windows.Forms.MenuStrip mst_snake;
        private System.Windows.Forms.ToolStripMenuItem snakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_menu;
        private System.Windows.Forms.ToolStripMenuItem regrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dificuldadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fácilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difícilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dificilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_logout;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
    }
}