namespace Client
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(143, 292);
            this.btnRock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(100, 45);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(329, 292);
            this.btnPaper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(100, 45);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(521, 292);
            this.btnScissors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(100, 45);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors\t";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(372, 126);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 3;
            // 
            // picPlayer1
            // 
            this.picPlayer1.Location = new System.Drawing.Point(313, 10);
            this.picPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(132, 85);
            this.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer1.TabIndex = 4;
            this.picPlayer1.TabStop = false;
            // 
            // picPlayer2
            // 
            this.picPlayer2.Location = new System.Drawing.Point(313, 175);
            this.picPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(132, 78);
            this.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer2.TabIndex = 5;
            this.picPlayer2.TabStop = false;
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Location = new System.Drawing.Point(140, 126);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(69, 16);
            this.lblPlayer1Score.TabIndex = 6;
            this.lblPlayer1Score.Text = "Player 1: 0";
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.Location = new System.Drawing.Point(548, 126);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(69, 16);
            this.lblPlayer2Score.TabIndex = 7;
            this.lblPlayer2Score.Text = "Player 2: 0";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(20, 10);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(67, 29);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 360);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.picPlayer2);
            this.Controls.Add(this.picPlayer1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Button btnRestart;
    }
}

