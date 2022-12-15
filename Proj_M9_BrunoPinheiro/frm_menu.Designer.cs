namespace Proj_M9_BrunoPinheiro
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_jogar = new System.Windows.Forms.Button();
            this.btn_jogars = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_jogarm = new System.Windows.Forms.Button();
            this.btn_creditos = new System.Windows.Forms.Button();
            this.pic_info = new System.Windows.Forms.PictureBox();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_info)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.Black;
            this.pnl_top.Controls.Add(this.pictureBox2);
            this.pnl_top.Controls.Add(this.btn_minimize);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(337, 28);
            this.pnl_top.TabIndex = 67;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proj_M9_BrunoPinheiro.Properties.Resources.snake;
            this.pictureBox2.Location = new System.Drawing.Point(11, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // btn_minimize
            // 
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Image = global::Proj_M9_BrunoPinheiro.Properties.Resources.minus__3___1_;
            this.btn_minimize.Location = new System.Drawing.Point(278, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(28, 28);
            this.btn_minimize.TabIndex = 8;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::Proj_M9_BrunoPinheiro.Properties.Resources.close__1___1_;
            this.btn_close.Location = new System.Drawing.Point(306, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 28);
            this.btn_close.TabIndex = 7;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(38, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snake";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(108, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 51);
            this.label2.TabIndex = 68;
            this.label2.Text = "Menu";
            // 
            // btn_jogar
            // 
            this.btn_jogar.FlatAppearance.BorderSize = 2;
            this.btn_jogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jogar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jogar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_jogar.Location = new System.Drawing.Point(86, 130);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(160, 43);
            this.btn_jogar.TabIndex = 69;
            this.btn_jogar.Text = "Modo Singleplayer";
            this.btn_jogar.UseVisualStyleBackColor = true;
            this.btn_jogar.Click += new System.EventHandler(this.btn_jogar_Click);
            this.btn_jogar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_jogar_MouseDown);
            this.btn_jogar.MouseLeave += new System.EventHandler(this.btn_jogar_MouseLeave);
            this.btn_jogar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_jogar_MouseMove);
            // 
            // btn_jogars
            // 
            this.btn_jogars.FlatAppearance.BorderSize = 2;
            this.btn_jogars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jogars.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jogars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_jogars.Location = new System.Drawing.Point(86, 257);
            this.btn_jogars.Name = "btn_jogars";
            this.btn_jogars.Size = new System.Drawing.Size(160, 43);
            this.btn_jogars.TabIndex = 70;
            this.btn_jogars.Text = "Modo Sem Limites";
            this.btn_jogars.UseVisualStyleBackColor = true;
            this.btn_jogars.Click += new System.EventHandler(this.btn_jogars_Click);
            this.btn_jogars.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_jogars_MouseDown);
            this.btn_jogars.MouseLeave += new System.EventHandler(this.btn_jogars_MouseLeave);
            this.btn_jogars.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_jogars_MouseMove);
            // 
            // btn_sair
            // 
            this.btn_sair.FlatAppearance.BorderSize = 2;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sair.Location = new System.Drawing.Point(86, 322);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(160, 43);
            this.btn_sair.TabIndex = 71;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            this.btn_sair.MouseLeave += new System.EventHandler(this.btn_sair_MouseLeave);
            this.btn_sair.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_sair_MouseMove);
            // 
            // btn_jogarm
            // 
            this.btn_jogarm.FlatAppearance.BorderSize = 2;
            this.btn_jogarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jogarm.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jogarm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_jogarm.Location = new System.Drawing.Point(86, 194);
            this.btn_jogarm.Name = "btn_jogarm";
            this.btn_jogarm.Size = new System.Drawing.Size(160, 43);
            this.btn_jogarm.TabIndex = 76;
            this.btn_jogarm.Text = "Modo Multiplayer";
            this.btn_jogarm.UseVisualStyleBackColor = true;
            this.btn_jogarm.Click += new System.EventHandler(this.btn_jogarm_Click);
            this.btn_jogarm.MouseLeave += new System.EventHandler(this.btn_jogarm_MouseLeave);
            this.btn_jogarm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_jogarm_MouseMove);
            // 
            // btn_creditos
            // 
            this.btn_creditos.FlatAppearance.BorderSize = 2;
            this.btn_creditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_creditos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creditos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_creditos.Location = new System.Drawing.Point(86, 470);
            this.btn_creditos.Name = "btn_creditos";
            this.btn_creditos.Size = new System.Drawing.Size(160, 35);
            this.btn_creditos.TabIndex = 77;
            this.btn_creditos.Text = "Créditos";
            this.btn_creditos.UseVisualStyleBackColor = true;
            this.btn_creditos.Click += new System.EventHandler(this.btn_creditos_Click);
            this.btn_creditos.MouseLeave += new System.EventHandler(this.btn_creditos_MouseLeave);
            this.btn_creditos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_creditos_MouseMove);
            // 
            // pic_info
            // 
            this.pic_info.Image = global::Proj_M9_BrunoPinheiro.Properties.Resources.information;
            this.pic_info.Location = new System.Drawing.Point(290, 467);
            this.pic_info.Name = "pic_info";
            this.pic_info.Size = new System.Drawing.Size(35, 35);
            this.pic_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_info.TabIndex = 75;
            this.pic_info.TabStop = false;
            this.pic_info.Click += new System.EventHandler(this.pic_info_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(337, 514);
            this.Controls.Add(this.btn_creditos);
            this.Controls.Add(this.btn_jogarm);
            this.Controls.Add(this.pic_info);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_jogars);
            this.Controls.Add(this.btn_jogar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake - Menu";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_jogar;
        private System.Windows.Forms.Button btn_jogars;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.PictureBox pic_info;
        private System.Windows.Forms.Button btn_jogarm;
        private System.Windows.Forms.Button btn_creditos;
    }
}