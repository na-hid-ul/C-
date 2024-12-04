namespace Bow_and_Arrow_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            player = new PictureBox();
            Arrow = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            b_1 = new PictureBox();
            b_2 = new PictureBox();
            b_3 = new PictureBox();
            lbl_score = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            lblTime = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Arrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)b_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)b_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)b_3).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.Image = Properties.Resources.idle;
            player.Location = new Point(48, 89);
            player.Name = "player";
            player.Size = new Size(104, 131);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // Arrow
            // 
            Arrow.Image = Properties.Resources.arrow;
            Arrow.Location = new Point(167, 125);
            Arrow.Name = "Arrow";
            Arrow.Size = new Size(63, 17);
            Arrow.SizeMode = PictureBoxSizeMode.AutoSize;
            Arrow.TabIndex = 1;
            Arrow.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Highlight;
            pictureBox1.Location = new Point(0, 323);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(684, 39);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Highlight;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(684, 45);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // b_1
            // 
            b_1.Image = Properties.Resources.balloon_1;
            b_1.Location = new Point(341, 175);
            b_1.Name = "b_1";
            b_1.Size = new Size(31, 45);
            b_1.SizeMode = PictureBoxSizeMode.AutoSize;
            b_1.TabIndex = 4;
            b_1.TabStop = false;
            // 
            // b_2
            // 
            b_2.Image = Properties.Resources.balloon_2;
            b_2.Location = new Point(410, 175);
            b_2.Name = "b_2";
            b_2.Size = new Size(31, 45);
            b_2.SizeMode = PictureBoxSizeMode.AutoSize;
            b_2.TabIndex = 5;
            b_2.TabStop = false;
            b_2.Click += b_2_Click;
            // 
            // b_3
            // 
            b_3.Image = Properties.Resources.balloon_3;
            b_3.Location = new Point(475, 175);
            b_3.Name = "b_3";
            b_3.Size = new Size(31, 45);
            b_3.SizeMode = PictureBoxSizeMode.AutoSize;
            b_3.TabIndex = 6;
            b_3.TabStop = false;
            // 
            // lbl_score
            // 
            lbl_score.AutoSize = true;
            lbl_score.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_score.ForeColor = Color.Red;
            lbl_score.Location = new Point(264, 2);
            lbl_score.Name = "lbl_score";
            lbl_score.Size = new Size(125, 37);
            lbl_score.TabIndex = 7;
            lbl_score.Text = "Score : 0";
            lbl_score.Click += lbl_score_Click;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.Red;
            lblTime.Location = new Point(542, 8);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(117, 30);
            lblTime.TabIndex = 8;
            lblTime.Text = "Time Limit";
            lblTime.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 9;
            label1.Text = "Arrow";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 359);
            Controls.Add(label1);
            Controls.Add(lblTime);
            Controls.Add(lbl_score);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(player);
            Controls.Add(Arrow);
            Controls.Add(b_3);
            Controls.Add(b_2);
            Controls.Add(b_1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Arrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)b_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)b_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)b_3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player;
        private PictureBox Arrow;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox b_1;
        private PictureBox b_2;
        private PictureBox b_3;
        private Label lbl_score;
        private System.Windows.Forms.Timer timer2;
        private Label lblTime;
        private Label label1;
    }
}