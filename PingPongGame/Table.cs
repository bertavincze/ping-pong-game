using System;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Table : Form
    {
        public bool IsRunning { get; set; }
        public bool MoveUp { get; set; }
        public bool MoveDown { get; set; }
        public int Speed { get; set; } = 5;
        public int BallX { get; set; } = 7;
        public int BallY { get; set; } = 7;
        public int Score { get; set; } = 0;
        public int ComputerScore { get; set; } = 0;

        public Table()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Table_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                MoveUp = true;
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                MoveDown = true;
            }
        }

        private void Table_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                MoveUp = false;
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                MoveDown = false;
            }
            else if (e.KeyCode == Keys.Space && IsRunning == true)
            {
                gameTimer.Stop();
                IsRunning = false;
            }
            else if (e.KeyCode == Keys.Space && IsRunning == false)
            {
                gameTimer.Start();
                IsRunning = true;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            IsRunning = true;
            playerScore.Text = "Player Score: " + Score;
            cpuScore.Text = "CPU Score: " + ComputerScore;

            ball.Top -= BallY;
            ball.Left -= BallX;

            cpu.Top += Speed;

            if (Score < 5)
            {
                if (cpu.Top < 0 || cpu.Top > 340)
                {
                    Speed = -Speed;
                }
            }
            else
            {
                cpu.Top = ball.Top + 15;
            }

            if (ball.Left < 0)
            {
                ball.Left = 356;
                BallX = -BallX;
                BallX += 5;
                ComputerScore++;
            }

            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 356;
                BallX = -BallX;
                BallX -= 5;
                Score++;
            }

            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                BallY = -BallY;
            }

            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                BallX = -BallX;
            }

            if (MoveUp == true && player.Top > 0)
            {
                player.Top -= 10;
            }

            if (MoveDown == true && player.Top < 340)
            {
                player.Top += 10;
            }

            if (Score > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("You win!");
            }

            if (ComputerScore > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("You lose!");
            }
        }
    }
}
