namespace QIK_v1
{
    partial class Form1
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
            this.pic_goal = new System.Windows.Forms.PictureBox();
            this.pic_choix1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_choix1 = new System.Windows.Forms.Button();
            this.but_choix2 = new System.Windows.Forms.Button();
            this.pic_choix2 = new System.Windows.Forms.PictureBox();
            this.but_choix3 = new System.Windows.Forms.Button();
            this.pic_choix3 = new System.Windows.Forms.PictureBox();
            this.but_choix4 = new System.Windows.Forms.Button();
            this.pic_choix4 = new System.Windows.Forms.PictureBox();
            this.but_reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Score = new System.Windows.Forms.Label();
            this.lb_info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mutation = new System.Windows.Forms.TrackBar();
            this.lb_mutation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_goal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_choix1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_choix2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_choix3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_choix4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_mutation)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_goal
            // 
            this.pic_goal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pic_goal.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_goal.Location = new System.Drawing.Point(272, 26);
            this.pic_goal.Name = "pic_goal";
            this.pic_goal.Size = new System.Drawing.Size(131, 121);
            this.pic_goal.TabIndex = 0;
            this.pic_goal.TabStop = false;
            // 
            // pic_choix1
            // 
            this.pic_choix1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pic_choix1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_choix1.Location = new System.Drawing.Point(16, 205);
            this.pic_choix1.Name = "pic_choix1";
            this.pic_choix1.Size = new System.Drawing.Size(94, 94);
            this.pic_choix1.TabIndex = 1;
            this.pic_choix1.TabStop = false;
            this.pic_choix1.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_choix_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 76);
            this.label1.TabIndex = 6;
            this.label1.Text = "Goal :";
            // 
            // but_choix1
            // 
            this.but_choix1.Location = new System.Drawing.Point(12, 308);
            this.but_choix1.Name = "but_choix1";
            this.but_choix1.Size = new System.Drawing.Size(100, 49);
            this.but_choix1.TabIndex = 7;
            this.but_choix1.Text = "Choose";
            this.but_choix1.UseVisualStyleBackColor = true;
            this.but_choix1.Click += new System.EventHandler(this.Button_Click);
            // 
            // but_choix2
            // 
            this.but_choix2.Location = new System.Drawing.Point(118, 308);
            this.but_choix2.Name = "but_choix2";
            this.but_choix2.Size = new System.Drawing.Size(100, 49);
            this.but_choix2.TabIndex = 9;
            this.but_choix2.Text = "Choose";
            this.but_choix2.UseVisualStyleBackColor = true;
            this.but_choix2.Click += new System.EventHandler(this.Button_Click);
            // 
            // pic_choix2
            // 
            this.pic_choix2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pic_choix2.Location = new System.Drawing.Point(118, 202);
            this.pic_choix2.Name = "pic_choix2";
            this.pic_choix2.Size = new System.Drawing.Size(100, 100);
            this.pic_choix2.TabIndex = 8;
            this.pic_choix2.TabStop = false;
            this.pic_choix2.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_choix_Paint);
            // 
            // but_choix3
            // 
            this.but_choix3.Location = new System.Drawing.Point(224, 308);
            this.but_choix3.Name = "but_choix3";
            this.but_choix3.Size = new System.Drawing.Size(100, 49);
            this.but_choix3.TabIndex = 11;
            this.but_choix3.Text = "Choose";
            this.but_choix3.UseVisualStyleBackColor = true;
            this.but_choix3.Click += new System.EventHandler(this.Button_Click);
            // 
            // pic_choix3
            // 
            this.pic_choix3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pic_choix3.Location = new System.Drawing.Point(224, 202);
            this.pic_choix3.Name = "pic_choix3";
            this.pic_choix3.Size = new System.Drawing.Size(100, 100);
            this.pic_choix3.TabIndex = 10;
            this.pic_choix3.TabStop = false;
            this.pic_choix3.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_choix_Paint);
            // 
            // but_choix4
            // 
            this.but_choix4.Location = new System.Drawing.Point(330, 308);
            this.but_choix4.Name = "but_choix4";
            this.but_choix4.Size = new System.Drawing.Size(100, 49);
            this.but_choix4.TabIndex = 13;
            this.but_choix4.Text = "Choose";
            this.but_choix4.UseVisualStyleBackColor = true;
            this.but_choix4.Click += new System.EventHandler(this.Button_Click);
            // 
            // pic_choix4
            // 
            this.pic_choix4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pic_choix4.Location = new System.Drawing.Point(330, 202);
            this.pic_choix4.Name = "pic_choix4";
            this.pic_choix4.Size = new System.Drawing.Size(100, 100);
            this.pic_choix4.TabIndex = 12;
            this.pic_choix4.TabStop = false;
            this.pic_choix4.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_choix_Paint);
            // 
            // but_reset
            // 
            this.but_reset.Location = new System.Drawing.Point(10, 459);
            this.but_reset.Name = "but_reset";
            this.but_reset.Size = new System.Drawing.Size(100, 41);
            this.but_reset.TabIndex = 20;
            this.but_reset.Text = "reset";
            this.but_reset.UseVisualStyleBackColor = true;
            this.but_reset.Click += new System.EventHandler(this.but_reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(118, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 58);
            this.label2.TabIndex = 21;
            this.label2.Text = "Score:";
            // 
            // lb_Score
            // 
            this.lb_Score.AutoSize = true;
            this.lb_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lb_Score.Location = new System.Drawing.Point(272, 427);
            this.lb_Score.Name = "lb_Score";
            this.lb_Score.Size = new System.Drawing.Size(70, 76);
            this.lb_Score.TabIndex = 22;
            this.lb_Score.Text = "0";
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_info.Location = new System.Drawing.Point(12, 170);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(227, 29);
            this.lb_info.TabIndex = 23;
            this.lb_info.Text = "Choose the Mother";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(12, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(7, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mutation :";
            // 
            // tb_mutation
            // 
            this.tb_mutation.Location = new System.Drawing.Point(128, 362);
            this.tb_mutation.Maximum = 127;
            this.tb_mutation.Name = "tb_mutation";
            this.tb_mutation.Size = new System.Drawing.Size(302, 56);
            this.tb_mutation.TabIndex = 26;
            this.tb_mutation.Value = 40;
            this.tb_mutation.Scroll += new System.EventHandler(this.tb_mutation_Scroll);
            // 
            // lb_mutation
            // 
            this.lb_mutation.AutoSize = true;
            this.lb_mutation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_mutation.Location = new System.Drawing.Point(40, 391);
            this.lb_mutation.Name = "lb_mutation";
            this.lb_mutation.Size = new System.Drawing.Size(18, 20);
            this.lb_mutation.TabIndex = 27;
            this.lb_mutation.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 512);
            this.Controls.Add(this.lb_mutation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.lb_Score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_reset);
            this.Controls.Add(this.but_choix4);
            this.Controls.Add(this.pic_choix4);
            this.Controls.Add(this.but_choix3);
            this.Controls.Add(this.pic_choix3);
            this.Controls.Add(this.but_choix2);
            this.Controls.Add(this.pic_choix2);
            this.Controls.Add(this.but_choix1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_choix1);
            this.Controls.Add(this.pic_goal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_mutation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_goal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_choix1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_choix2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_choix3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_choix4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_mutation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_goal;
        private System.Windows.Forms.PictureBox pic_choix1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_choix1;
        private System.Windows.Forms.Button but_choix2;
        private System.Windows.Forms.PictureBox pic_choix2;
        private System.Windows.Forms.Button but_choix3;
        private System.Windows.Forms.PictureBox pic_choix3;
        private System.Windows.Forms.Button but_choix4;
        private System.Windows.Forms.PictureBox pic_choix4;
        private System.Windows.Forms.Button but_reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Score;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tb_mutation;
        private System.Windows.Forms.Label lb_mutation;
    }
}

