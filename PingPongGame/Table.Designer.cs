namespace PingPongGame
{
    partial class Table
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
            this.ball = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.ProgressBar();
            this.cpu = new System.Windows.Forms.ProgressBar();
            this.playerScore = new System.Windows.Forms.Label();
            this.cpuScore = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ball.Image = global::PingPongGame.Properties.Resources.ball;
            this.ball.InitialImage = global::PingPongGame.Properties.Resources.ball;
            this.ball.Location = new System.Drawing.Point(357, 217);
            this.ball.Margin = new System.Windows.Forms.Padding(0);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.White;
            this.player.Location = new System.Drawing.Point(1, 171);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(20, 115);
            this.player.TabIndex = 1;
            // 
            // cpu
            // 
            this.cpu.Location = new System.Drawing.Point(713, 171);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(20, 115);
            this.cpu.TabIndex = 2;
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.BackColor = System.Drawing.Color.Transparent;
            this.playerScore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerScore.ForeColor = System.Drawing.Color.White;
            this.playerScore.Location = new System.Drawing.Point(48, 16);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(45, 19);
            this.playerScore.TabIndex = 3;
            this.playerScore.Text = "label1";
            // 
            // cpuScore
            // 
            this.cpuScore.AutoSize = true;
            this.cpuScore.BackColor = System.Drawing.Color.Transparent;
            this.cpuScore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cpuScore.ForeColor = System.Drawing.Color.White;
            this.cpuScore.Location = new System.Drawing.Point(587, 16);
            this.cpuScore.Name = "cpuScore";
            this.cpuScore.Size = new System.Drawing.Size(45, 19);
            this.cpuScore.TabIndex = 4;
            this.cpuScore.Text = "label1";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.BackColor = System.Drawing.Color.Transparent;
            this.level.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.level.ForeColor = System.Drawing.Color.White;
            this.level.Location = new System.Drawing.Point(343, 9);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(52, 21);
            this.level.TabIndex = 5;
            this.level.Text = "label1";
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PingPongGame.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 456);
            this.Controls.Add(this.level);
            this.Controls.Add(this.cpuScore);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.player);
            this.Controls.Add(this.ball);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Table_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Table_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.ProgressBar player;
        private System.Windows.Forms.ProgressBar cpu;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label cpuScore;
        private System.Windows.Forms.Label level;
    }
}

