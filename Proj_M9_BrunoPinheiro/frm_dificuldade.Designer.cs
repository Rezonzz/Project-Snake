namespace Proj_M9_BrunoPinheiro
{
    partial class frm_dificuldade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dificuldade));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_dificil = new System.Windows.Forms.Button();
            this.btn_medio = new System.Windows.Forms.Button();
            this.btn_facil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_mtfacil = new System.Windows.Forms.Button();
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
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btn_voltar.FlatAppearance.BorderSize = 2;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_voltar.Location = new System.Drawing.Point(88, 417);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(160, 43);
            this.btn_voltar.TabIndex = 77;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_dificil
            // 
            this.btn_dificil.FlatAppearance.BorderSize = 2;
            this.btn_dificil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dificil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dificil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_dificil.Location = new System.Drawing.Point(88, 309);
            this.btn_dificil.Name = "btn_dificil";
            this.btn_dificil.Size = new System.Drawing.Size(160, 43);
            this.btn_dificil.TabIndex = 76;
            this.btn_dificil.Text = "Dificíl";
            this.btn_dificil.UseVisualStyleBackColor = true;
            this.btn_dificil.Click += new System.EventHandler(this.btn_dificil_Click);
            this.btn_dificil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_dificil_MouseDown);
            this.btn_dificil.MouseLeave += new System.EventHandler(this.btn_dificil_MouseLeave);
            this.btn_dificil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_dificil_MouseMove);
            // 
            // btn_medio
            // 
            this.btn_medio.FlatAppearance.BorderSize = 2;
            this.btn_medio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_medio.Location = new System.Drawing.Point(88, 248);
            this.btn_medio.Name = "btn_medio";
            this.btn_medio.Size = new System.Drawing.Size(160, 43);
            this.btn_medio.TabIndex = 75;
            this.btn_medio.Text = "Médio";
            this.btn_medio.UseVisualStyleBackColor = true;
            this.btn_medio.Click += new System.EventHandler(this.btn_medio_Click);
            this.btn_medio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_medio_MouseDown);
            this.btn_medio.MouseLeave += new System.EventHandler(this.btn_medio_MouseLeave);
            this.btn_medio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_medio_MouseMove);
            // 
            // btn_facil
            // 
            this.btn_facil.FlatAppearance.BorderSize = 2;
            this.btn_facil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_facil.Location = new System.Drawing.Point(88, 188);
            this.btn_facil.Name = "btn_facil";
            this.btn_facil.Size = new System.Drawing.Size(160, 43);
            this.btn_facil.TabIndex = 74;
            this.btn_facil.Text = "Fácil";
            this.btn_facil.UseVisualStyleBackColor = true;
            this.btn_facil.Click += new System.EventHandler(this.btn_facil_Click);
            this.btn_facil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_facil_MouseDown);
            this.btn_facil.MouseLeave += new System.EventHandler(this.btn_facil_MouseLeave);
            this.btn_facil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_facil_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(62, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 51);
            this.label2.TabIndex = 73;
            this.label2.Text = "Dificuldade";
            // 
            // btn_mtfacil
            // 
            this.btn_mtfacil.FlatAppearance.BorderSize = 2;
            this.btn_mtfacil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mtfacil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mtfacil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_mtfacil.Location = new System.Drawing.Point(88, 128);
            this.btn_mtfacil.Name = "btn_mtfacil";
            this.btn_mtfacil.Size = new System.Drawing.Size(160, 43);
            this.btn_mtfacil.TabIndex = 78;
            this.btn_mtfacil.Text = "Muito Fácil";
            this.btn_mtfacil.UseVisualStyleBackColor = true;
            this.btn_mtfacil.Click += new System.EventHandler(this.btn_mtfacil_Click);
            this.btn_mtfacil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_mtfacil_MouseDown);
            this.btn_mtfacil.MouseLeave += new System.EventHandler(this.btn_mtfacil_MouseLeave);
            this.btn_mtfacil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_mtfacil_MouseMove);
            // 
            // frm_dificuldade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(337, 514);
            this.Controls.Add(this.btn_mtfacil);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_dificil);
            this.Controls.Add(this.btn_medio);
            this.Controls.Add(this.btn_facil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_dificuldade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake - Dificuldade";
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
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_dificil;
        private System.Windows.Forms.Button btn_medio;
        private System.Windows.Forms.Button btn_facil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_mtfacil;
    }
}