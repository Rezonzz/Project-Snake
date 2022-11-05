namespace Proj_M9_BrunoPinheiro
{
    partial class frm_creditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_creditos));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_dp = new System.Windows.Forms.Label();
            this.lbl_nome1 = new System.Windows.Forms.Label();
            this.lbl_nome2 = new System.Windows.Forms.Label();
            this.lbl_ap = new System.Windows.Forms.Label();
            this.lbl_nome3 = new System.Windows.Forms.Label();
            this.lbl_ts = new System.Windows.Forms.Label();
            this.lbl_nome6 = new System.Windows.Forms.Label();
            this.lbl_dep = new System.Windows.Forms.Label();
            this.lbl_nome4 = new System.Windows.Forms.Label();
            this.lbl_d = new System.Windows.Forms.Label();
            this.lbl_nome5 = new System.Windows.Forms.Label();
            this.lbl_p = new System.Windows.Forms.Label();
            this.tmr_creditos = new System.Windows.Forms.Timer(this.components);
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.pnl_top.TabIndex = 68;
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
            // lbl_dp
            // 
            this.lbl_dp.AutoSize = true;
            this.lbl_dp.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_dp.Location = new System.Drawing.Point(61, 557);
            this.lbl_dp.Name = "lbl_dp";
            this.lbl_dp.Size = new System.Drawing.Size(214, 27);
            this.lbl_dp.TabIndex = 69;
            this.lbl_dp.Text = "Design e Programação";
            this.lbl_dp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nome1
            // 
            this.lbl_nome1.AutoSize = true;
            this.lbl_nome1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nome1.Location = new System.Drawing.Point(107, 589);
            this.lbl_nome1.Name = "lbl_nome1";
            this.lbl_nome1.Size = new System.Drawing.Size(113, 21);
            this.lbl_nome1.TabIndex = 70;
            this.lbl_nome1.Text = "Bruno Pinheiro";
            this.lbl_nome1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nome2
            // 
            this.lbl_nome2.AutoSize = true;
            this.lbl_nome2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nome2.Location = new System.Drawing.Point(107, 661);
            this.lbl_nome2.Name = "lbl_nome2";
            this.lbl_nome2.Size = new System.Drawing.Size(113, 21);
            this.lbl_nome2.TabIndex = 72;
            this.lbl_nome2.Text = "Bruno Pinheiro";
            this.lbl_nome2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ap
            // 
            this.lbl_ap.AutoSize = true;
            this.lbl_ap.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ap.Location = new System.Drawing.Point(38, 632);
            this.lbl_ap.Name = "lbl_ap";
            this.lbl_ap.Size = new System.Drawing.Size(262, 27);
            this.lbl_ap.TabIndex = 71;
            this.lbl_ap.Text = "Assistente de Programação";
            this.lbl_ap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nome3
            // 
            this.lbl_nome3.AutoSize = true;
            this.lbl_nome3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nome3.Location = new System.Drawing.Point(106, 733);
            this.lbl_nome3.Name = "lbl_nome3";
            this.lbl_nome3.Size = new System.Drawing.Size(113, 21);
            this.lbl_nome3.TabIndex = 76;
            this.lbl_nome3.Text = "Bruno Pinheiro";
            this.lbl_nome3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ts
            // 
            this.lbl_ts.AutoSize = true;
            this.lbl_ts.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ts.Location = new System.Drawing.Point(82, 703);
            this.lbl_ts.Name = "lbl_ts";
            this.lbl_ts.Size = new System.Drawing.Size(157, 27);
            this.lbl_ts.TabIndex = 75;
            this.lbl_ts.Text = "Técnico de Som";
            this.lbl_ts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nome6
            // 
            this.lbl_nome6.AutoSize = true;
            this.lbl_nome6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nome6.Location = new System.Drawing.Point(105, 955);
            this.lbl_nome6.Name = "lbl_nome6";
            this.lbl_nome6.Size = new System.Drawing.Size(113, 21);
            this.lbl_nome6.TabIndex = 78;
            this.lbl_nome6.Text = "Bruno Pinheiro";
            this.lbl_nome6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_dep
            // 
            this.lbl_dep.AutoSize = true;
            this.lbl_dep.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_dep.Location = new System.Drawing.Point(82, 921);
            this.lbl_dep.Name = "lbl_dep";
            this.lbl_dep.Size = new System.Drawing.Size(163, 27);
            this.lbl_dep.TabIndex = 77;
            this.lbl_dep.Text = "Desenvolvido por";
            this.lbl_dep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nome4
            // 
            this.lbl_nome4.AutoSize = true;
            this.lbl_nome4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nome4.Location = new System.Drawing.Point(106, 808);
            this.lbl_nome4.Name = "lbl_nome4";
            this.lbl_nome4.Size = new System.Drawing.Size(113, 21);
            this.lbl_nome4.TabIndex = 80;
            this.lbl_nome4.Text = "Bruno Pinheiro";
            this.lbl_nome4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_d
            // 
            this.lbl_d.AutoSize = true;
            this.lbl_d.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_d.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_d.Location = new System.Drawing.Point(118, 778);
            this.lbl_d.Name = "lbl_d";
            this.lbl_d.Size = new System.Drawing.Size(82, 27);
            this.lbl_d.TabIndex = 79;
            this.lbl_d.Text = "Direção";
            this.lbl_d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nome5
            // 
            this.lbl_nome5.AutoSize = true;
            this.lbl_nome5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nome5.Location = new System.Drawing.Point(105, 882);
            this.lbl_nome5.Name = "lbl_nome5";
            this.lbl_nome5.Size = new System.Drawing.Size(113, 21);
            this.lbl_nome5.TabIndex = 82;
            this.lbl_nome5.Text = "Bruno Pinheiro";
            this.lbl_nome5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p
            // 
            this.lbl_p.AutoSize = true;
            this.lbl_p.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_p.Location = new System.Drawing.Point(111, 846);
            this.lbl_p.Name = "lbl_p";
            this.lbl_p.Size = new System.Drawing.Size(101, 27);
            this.lbl_p.TabIndex = 81;
            this.lbl_p.Text = "Patrocinio";
            this.lbl_p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr_creditos
            // 
            this.tmr_creditos.Interval = 50;
            this.tmr_creditos.Tick += new System.EventHandler(this.tmr_creditos_Tick);
            // 
            // frm_creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(337, 514);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.lbl_nome5);
            this.Controls.Add(this.lbl_p);
            this.Controls.Add(this.lbl_nome4);
            this.Controls.Add(this.lbl_d);
            this.Controls.Add(this.lbl_nome6);
            this.Controls.Add(this.lbl_dep);
            this.Controls.Add(this.lbl_nome3);
            this.Controls.Add(this.lbl_ts);
            this.Controls.Add(this.lbl_nome2);
            this.Controls.Add(this.lbl_ap);
            this.Controls.Add(this.lbl_nome1);
            this.Controls.Add(this.lbl_dp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_creditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake - Créditos";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_dp;
        private System.Windows.Forms.Label lbl_nome1;
        private System.Windows.Forms.Label lbl_nome2;
        private System.Windows.Forms.Label lbl_ap;
        private System.Windows.Forms.Label lbl_nome3;
        private System.Windows.Forms.Label lbl_ts;
        private System.Windows.Forms.Label lbl_nome6;
        private System.Windows.Forms.Label lbl_dep;
        private System.Windows.Forms.Label lbl_nome4;
        private System.Windows.Forms.Label lbl_d;
        private System.Windows.Forms.Label lbl_nome5;
        private System.Windows.Forms.Label lbl_p;
        private System.Windows.Forms.Timer tmr_creditos;
    }
}