namespace AirHockey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.winLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.AutoSize = true;
            this.player1ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.player1ScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.player1ScoreLabel.Location = new System.Drawing.Point(555, 386);
            this.player1ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(30, 33);
            this.player1ScoreLabel.TabIndex = 0;
            this.player1ScoreLabel.Text = "0";
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.AutoSize = true;
            this.player2ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.player2ScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.player2ScoreLabel.Location = new System.Drawing.Point(555, 483);
            this.player2ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(30, 33);
            this.player2ScoreLabel.TabIndex = 1;
            this.player2ScoreLabel.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.Location = new System.Drawing.Point(212, 389);
            this.winLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(0, 33);
            this.winLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 900);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.player2ScoreLabel);
            this.Controls.Add(this.player1ScoreLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Air Hockey";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label player2ScoreLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label winLabel;
    }
}

