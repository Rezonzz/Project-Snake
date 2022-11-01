namespace Proj_M9_BrunoPinheiro
{
    partial class frm_info1v1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_info1v1));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_background = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_page3 = new System.Windows.Forms.Button();
            this.btn_page2 = new System.Windows.Forms.Button();
            this.btn_page1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_top.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.pnl_top.TabIndex = 45;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
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
            // pnl_background
            // 
            this.pnl_background.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_background.Location = new System.Drawing.Point(0, 28);
            this.pnl_background.Name = "pnl_background";
            this.pnl_background.Size = new System.Drawing.Size(337, 520);
            this.pnl_background.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_page3);
            this.panel2.Controls.Add(this.btn_page2);
            this.panel2.Controls.Add(this.btn_page1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 548);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 45);
            this.panel2.TabIndex = 47;
            // 
            // btn_page3
            // 
            this.btn_page3.FlatAppearance.BorderSize = 2;
            this.btn_page3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_page3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_page3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_page3.Location = new System.Drawing.Point(187, 5);
            this.btn_page3.Name = "btn_page3";
            this.btn_page3.Size = new System.Drawing.Size(36, 36);
            this.btn_page3.TabIndex = 81;
            this.btn_page3.Text = "3";
            this.btn_page3.UseVisualStyleBackColor = true;
            this.btn_page3.Click += new System.EventHandler(this.btn_page3_Click);
            // 
            // btn_page2
            // 
            this.btn_page2.FlatAppearance.BorderSize = 2;
            this.btn_page2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_page2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_page2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_page2.Location = new System.Drawing.Point(145, 5);
            this.btn_page2.Name = "btn_page2";
            this.btn_page2.Size = new System.Drawing.Size(36, 36);
            this.btn_page2.TabIndex = 80;
            this.btn_page2.Text = "2";
            this.btn_page2.UseVisualStyleBackColor = true;
            this.btn_page2.Click += new System.EventHandler(this.btn_page2_Click);
            // 
            // btn_page1
            // 
            this.btn_page1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_page1.FlatAppearance.BorderSize = 2;
            this.btn_page1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_page1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_page1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_page1.Location = new System.Drawing.Point(103, 5);
            this.btn_page1.Name = "btn_page1";
            this.btn_page1.Size = new System.Drawing.Size(36, 36);
            this.btn_page1.TabIndex = 79;
            this.btn_page1.Text = "1";
            this.btn_page1.UseVisualStyleBackColor = false;
            this.btn_page1.Click += new System.EventHandler(this.btn_page1_Click);
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
            // frm_info1v1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(337, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_background);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_info1v1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info - 1v1";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_background;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_page3;
        private System.Windows.Forms.Button btn_page2;
        private System.Windows.Forms.Button btn_page1;
    }
}