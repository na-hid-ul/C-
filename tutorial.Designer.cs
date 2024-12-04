namespace Bow_and_Arrow_1
{
    partial class tutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tutorial));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button4 = new Button();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arrow;
            pictureBox1.Location = new Point(50, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 24);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(130, 121);
            label2.Name = "label2";
            label2.Size = new Size(657, 32);
            label2.TabIndex = 2;
            label2.Text = "Shoot an arrow: Press the Right arrow key to shoot an arrow.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(170, 69);
            label3.Name = "label3";
            label3.Size = new Size(469, 32);
            label3.TabIndex = 3;
            label3.Text = "Welcome to the game! Here's how to play:";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(89, 201);
            label1.Name = "label1";
            label1.Size = new Size(599, 32);
            label1.TabIndex = 4;
            label1.Text = " Arrow limit: You start with a certain number of arrows. ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(107, 233);
            label4.Name = "label4";
            label4.Size = new Size(569, 32);
            label4.TabIndex = 5;
            label4.Text = "Each time you shoot an arrow, the count decreases. ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(130, 265);
            label5.Name = "label5";
            label5.Size = new Size(513, 32);
            label5.TabIndex = 6;
            label5.Text = " When you run out of arrows, the game is over";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(143, 296);
            label6.Name = "label6";
            label6.Size = new Size(496, 32);
            label6.TabIndex = 7;
            label6.Text = "Time limit: There is a time limit for the game.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(170, 328);
            label7.Name = "label7";
            label7.Size = new Size(442, 32);
            label7.TabIndex = 8;
            label7.Text = "The game ends when the time runs out.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(349, 162);
            label8.Name = "label8";
            label8.Size = new Size(74, 30);
            label8.TabIndex = 10;
            label8.Text = "Arrow";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(85, 37);
            button4.TabIndex = 274;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(216, 370);
            label10.Name = "label10";
            label10.Size = new Size(308, 32);
            label10.TabIndex = 276;
            label10.Text = "How to maintain this game:";
            // 
            // tutorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(861, 655);
            Controls.Add(label10);
            Controls.Add(button4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "tutorial";
            Text = "tutorial";
            Load += tutorial_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button4;
        private Label label10;
    }
}