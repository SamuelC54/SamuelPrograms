namespace Genetic
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LbDistance0 = new System.Windows.Forms.Label();
            this.LbDistance1 = new System.Windows.Forms.Label();
            this.LbDistance2 = new System.Windows.Forms.Label();
            this.LbDistance3 = new System.Windows.Forms.Label();
            this.LbDistance4 = new System.Windows.Forms.Label();
            this.LbDistance5 = new System.Windows.Forms.Label();
            this.rbGene0 = new System.Windows.Forms.RadioButton();
            this.rbGene1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGene2 = new System.Windows.Forms.RadioButton();
            this.rbGene3 = new System.Windows.Forms.RadioButton();
            this.rbGene4 = new System.Windows.Forms.RadioButton();
            this.rbGene5 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 296);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gene 0:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gene 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gene 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gene 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gene 4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gene 5:";
            // 
            // LbDistance0
            // 
            this.LbDistance0.AutoSize = true;
            this.LbDistance0.Location = new System.Drawing.Point(121, 28);
            this.LbDistance0.Name = "LbDistance0";
            this.LbDistance0.Size = new System.Drawing.Size(13, 13);
            this.LbDistance0.TabIndex = 8;
            this.LbDistance0.Text = "0";
            // 
            // LbDistance1
            // 
            this.LbDistance1.AutoSize = true;
            this.LbDistance1.Location = new System.Drawing.Point(121, 58);
            this.LbDistance1.Name = "LbDistance1";
            this.LbDistance1.Size = new System.Drawing.Size(13, 13);
            this.LbDistance1.TabIndex = 9;
            this.LbDistance1.Text = "0";
            // 
            // LbDistance2
            // 
            this.LbDistance2.AutoSize = true;
            this.LbDistance2.Location = new System.Drawing.Point(121, 88);
            this.LbDistance2.Name = "LbDistance2";
            this.LbDistance2.Size = new System.Drawing.Size(13, 13);
            this.LbDistance2.TabIndex = 10;
            this.LbDistance2.Text = "0";
            // 
            // LbDistance3
            // 
            this.LbDistance3.AutoSize = true;
            this.LbDistance3.Location = new System.Drawing.Point(121, 118);
            this.LbDistance3.Name = "LbDistance3";
            this.LbDistance3.Size = new System.Drawing.Size(13, 13);
            this.LbDistance3.TabIndex = 11;
            this.LbDistance3.Text = "0";
            // 
            // LbDistance4
            // 
            this.LbDistance4.AutoSize = true;
            this.LbDistance4.Location = new System.Drawing.Point(121, 148);
            this.LbDistance4.Name = "LbDistance4";
            this.LbDistance4.Size = new System.Drawing.Size(13, 13);
            this.LbDistance4.TabIndex = 12;
            this.LbDistance4.Text = "0";
            // 
            // LbDistance5
            // 
            this.LbDistance5.AutoSize = true;
            this.LbDistance5.Location = new System.Drawing.Point(121, 178);
            this.LbDistance5.Name = "LbDistance5";
            this.LbDistance5.Size = new System.Drawing.Size(13, 13);
            this.LbDistance5.TabIndex = 13;
            this.LbDistance5.Text = "0";
            // 
            // rbGene0
            // 
            this.rbGene0.AutoSize = true;
            this.rbGene0.Checked = true;
            this.rbGene0.Location = new System.Drawing.Point(32, 28);
            this.rbGene0.Name = "rbGene0";
            this.rbGene0.Size = new System.Drawing.Size(14, 13);
            this.rbGene0.TabIndex = 14;
            this.rbGene0.UseVisualStyleBackColor = true;
            this.rbGene0.CheckedChanged += new System.EventHandler(this.rbGene0_CheckedChanged);
            // 
            // rbGene1
            // 
            this.rbGene1.AutoSize = true;
            this.rbGene1.Location = new System.Drawing.Point(32, 58);
            this.rbGene1.Name = "rbGene1";
            this.rbGene1.Size = new System.Drawing.Size(14, 13);
            this.rbGene1.TabIndex = 15;
            this.rbGene1.UseVisualStyleBackColor = true;
            this.rbGene1.CheckedChanged += new System.EventHandler(this.rbGene1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGene5);
            this.groupBox1.Controls.Add(this.rbGene4);
            this.groupBox1.Controls.Add(this.rbGene3);
            this.groupBox1.Controls.Add(this.rbGene2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbGene1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbGene0);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LbDistance5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LbDistance4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LbDistance3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LbDistance2);
            this.groupBox1.Controls.Add(this.LbDistance0);
            this.groupBox1.Controls.Add(this.LbDistance1);
            this.groupBox1.Location = new System.Drawing.Point(404, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 217);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // rbGene2
            // 
            this.rbGene2.AutoSize = true;
            this.rbGene2.Location = new System.Drawing.Point(32, 88);
            this.rbGene2.Name = "rbGene2";
            this.rbGene2.Size = new System.Drawing.Size(14, 13);
            this.rbGene2.TabIndex = 16;
            this.rbGene2.UseVisualStyleBackColor = true;
            this.rbGene2.CheckedChanged += new System.EventHandler(this.rbGene2_CheckedChanged);
            // 
            // rbGene3
            // 
            this.rbGene3.AutoSize = true;
            this.rbGene3.Location = new System.Drawing.Point(32, 118);
            this.rbGene3.Name = "rbGene3";
            this.rbGene3.Size = new System.Drawing.Size(14, 13);
            this.rbGene3.TabIndex = 17;
            this.rbGene3.UseVisualStyleBackColor = true;
            this.rbGene3.CheckedChanged += new System.EventHandler(this.rbGene3_CheckedChanged);
            // 
            // rbGene4
            // 
            this.rbGene4.AutoSize = true;
            this.rbGene4.Location = new System.Drawing.Point(32, 148);
            this.rbGene4.Name = "rbGene4";
            this.rbGene4.Size = new System.Drawing.Size(14, 13);
            this.rbGene4.TabIndex = 18;
            this.rbGene4.UseVisualStyleBackColor = true;
            this.rbGene4.CheckedChanged += new System.EventHandler(this.rbGene4_CheckedChanged);
            // 
            // rbGene5
            // 
            this.rbGene5.AutoSize = true;
            this.rbGene5.Location = new System.Drawing.Point(32, 178);
            this.rbGene5.Name = "rbGene5";
            this.rbGene5.Size = new System.Drawing.Size(14, 13);
            this.rbGene5.TabIndex = 19;
            this.rbGene5.UseVisualStyleBackColor = true;
            this.rbGene5.CheckedChanged += new System.EventHandler(this.rbGene5_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Selection";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Croisement";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Random";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "0";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(404, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Show ADN";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(45, 459);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "Mutation";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(387, 401);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 23;
            this.button7.Text = "StartTimer";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(387, 430);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 24;
            this.button8.Text = "Stop Timer";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 488);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Genetic ALG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LbDistance0;
        private System.Windows.Forms.Label LbDistance1;
        private System.Windows.Forms.Label LbDistance2;
        private System.Windows.Forms.Label LbDistance3;
        private System.Windows.Forms.Label LbDistance4;
        private System.Windows.Forms.Label LbDistance5;
        private System.Windows.Forms.RadioButton rbGene0;
        private System.Windows.Forms.RadioButton rbGene1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGene5;
        private System.Windows.Forms.RadioButton rbGene4;
        private System.Windows.Forms.RadioButton rbGene3;
        private System.Windows.Forms.RadioButton rbGene2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

