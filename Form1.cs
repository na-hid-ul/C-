using System;
using System.Data.SqlClient;
using System.Media;
using System.Reflection.Emit;
using System.Windows.Forms;
using NAudio.Wave;
using WMPLib;
using static System.Formats.Asn1.AsnWriter;

namespace Bow_and_Arrow_1
{
    public partial class Form1 : Form
    {
         SqlConnection con = new SqlConnection("Data Source=DESKTOP-I11GJ35\\SQLEXPRESS;Initial Catalog=game;Integrated Security=True");


        int score;
        string mood;
        bool isNotificationShown = false;
        int remainingTime = 120; // Initial time in seconds
        private WaveOut waveOut;
        private Mp3FileReader reader;
        int arrowCount = 0; // Add this line at the beginning of your class to keep track of the number of arrows shot
        int arrowLimit; // Add this line at the beginning of your class to set the limit of arrows
       
        // Default balloon speed
        int balloonSpeed = 5;

        Random rnd = new Random(); // Create a single instance of Random

        public Form1()
        {
            InitializeComponent();
        }



        void Game1()
        {

            Mp3FileReader reader = new Mp3FileReader("sound.mp3");
            WaveOut waveOut = new WaveOut(); // or WaveOutEvent()
            waveOut.Init(reader);

            if (Arrow.Bounds.IntersectsWith(b_1.Bounds))
            {
                b_1.Top = 400;
                score += 3;
                lbl_score.Text = "Score: " + score;
                Arrow.Image = Properties.Resources.Explosion;
                waveOut.Play();
            }

            if (Arrow.Bounds.IntersectsWith(b_2.Bounds))
            {
                b_2.Top = 400;
                score += 5;
                lbl_score.Text = "Score: " + score;
                Arrow.Image = Properties.Resources.Explosion;
                waveOut.Play();
            }

            if (Arrow.Bounds.IntersectsWith(b_3.Bounds))
            {
                b_3.Top = 400;
                score += 7;
                lbl_score.Text = "Score: " + score;
                Arrow.Image = Properties.Resources.Explosion;
                waveOut.Play();
            }

            // Show notification when score reaches 20 for the first time
            if (score >= 20 && !isNotificationShown)
            {
                isNotificationShown = true;
                MessageBox.Show("Great Work! You've reached a score of 20!");
            }
        }
        void Balloon()
        {
            int x, y, z;

            if (b_1.Top < 20)
            {
                b_1.Top = 300;
                x = rnd.Next(200, 600);
                b_1.Location = new Point(x, 500);
            }
            else
            {
                b_1.Top -= balloonSpeed;
            }

            if (b_2.Top < 20)
            {
                b_2.Top = 300;
                y = rnd.Next(200, 600);
                b_2.Location = new Point(y, 500);
            }
            else
            {
                b_2.Top -= balloonSpeed;
            }

            if (b_3.Top < 20)
            {
                b_3.Top = 300;
                z = rnd.Next(200, 600);
                b_3.Location = new Point(z, 500);
            }
            else
            {
                b_3.Top -= balloonSpeed;
            }
        }

        public void showspeed(int speed)
        {
            if (speed == 1)
            {
                mood = "Easy";
                arrowLimit = 15; // Set arrow limit for Easy
            }
            else if (speed == 2)
            {
                mood = "Medium";
                arrowLimit = 10; // Set arrow limit for Medium
            }
            else if (speed == 3)
            {
                mood = "Hard";
                arrowLimit = 5; // Set arrow limit for Hard
            }

            // Update label1 to show the number of arrows left
            label1.Text = "Arrows left: " + arrowLimit.ToString();
        }

        void Shoot()
        {
            if (arrowCount < arrowLimit) // Check if there are arrows left to shoot
            {
                Arrow.Left += 100;

                if (Arrow.Left > 600)
                {
                    player.Image = Properties.Resources.idle;
                    Arrow.Image = Properties.Resources.arrow;
                    Arrow.Top = player.Top + 35;

                    
                       
                }
            }

          
        }



        void CheckGameOver()
        {
            // Check if the remaining time is less than or equal to 0 or the arrow limit is reached
            if (remainingTime <= 0 || arrowCount >= arrowLimit)
            {
                timer1.Enabled = false; // Stop the game timer
                MessageBox.Show("Game Over! Your final score is: " + score);

                con.Open();
                SqlCommand cmd = new SqlCommand("insert into point values('" + login.loginName + "','" + score + "','" + mood + "','" + DateTime.Now + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();

                waveOut?.Stop();
                waveOut?.Dispose();
                reader?.Dispose();
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }



        // Function to multiply balloon speed
        public void MultiplyBalloonSpeed(int factor)
        {
            balloonSpeed *= factor;
        }


     

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Arrow.Left = player.Left;
                player.Image = Properties.Resources.shoot;

                arrowCount++; // Increment the arrow count after each shot


                // Update label1 to show the number of arrows left
                label1.Text = "Arrows left: " + (arrowLimit - arrowCount).ToString();
                // Check if all arrows have been shot
                if (arrowCount == arrowLimit)
                {
                    // Code to handle when the arrow limit is reached
                    label1.Text = "No arrows left";
                    CheckGameOver(); // Call CheckGameOver when the arrow limit is reached
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (player.Top > 40)
                {
                    player.Top -= 5;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (player.Top < 200)
                {
                    player.Top += 5;
                }
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Shoot();
            Balloon();
            Game1();
            CheckGameOver(); // Check for game over condition
            remainingTime--; // Decrement remaining time
            lblTime.Text = "Time: " + remainingTime + "s"; // Update the time label
        }

        private void b_2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_score_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            reader = new Mp3FileReader("a.mp3");
            waveOut = new WaveOut(); // or WaveOutEvent()
            waveOut.Init(reader);
            waveOut.Play();
        }



    }
}
