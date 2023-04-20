namespace DemoDisk
{
    partial class PongGamevsCPU
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
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player1scoreLabel = new System.Windows.Forms.Label();
            this.player2scoreLabel = new System.Windows.Forms.Label();
            this.pongTimer = new System.Windows.Forms.Timer(this.components);
            this.rallycounterLabel = new System.Windows.Forms.Label();
            this.RallyCountLabel = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.ballReset = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.White;
            this.player2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2.Location = new System.Drawing.Point(748, 155);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(29, 123);
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.White;
            this.player1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1.Location = new System.Drawing.Point(21, 155);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(29, 123);
            this.player1.TabIndex = 2;
            this.player1.TabStop = false;
            // 
            // player1scoreLabel
            // 
            this.player1scoreLabel.AutoSize = true;
            this.player1scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.player1scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1scoreLabel.ForeColor = System.Drawing.Color.White;
            this.player1scoreLabel.Location = new System.Drawing.Point(479, 46);
            this.player1scoreLabel.Name = "player1scoreLabel";
            this.player1scoreLabel.Size = new System.Drawing.Size(40, 42);
            this.player1scoreLabel.TabIndex = 4;
            this.player1scoreLabel.Text = "0";
            // 
            // player2scoreLabel
            // 
            this.player2scoreLabel.AutoSize = true;
            this.player2scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.player2scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2scoreLabel.ForeColor = System.Drawing.Color.White;
            this.player2scoreLabel.Location = new System.Drawing.Point(313, 46);
            this.player2scoreLabel.Name = "player2scoreLabel";
            this.player2scoreLabel.Size = new System.Drawing.Size(40, 42);
            this.player2scoreLabel.TabIndex = 5;
            this.player2scoreLabel.Text = "0";
            // 
            // pongTimer
            // 
            this.pongTimer.Interval = 10;
            this.pongTimer.Tick += new System.EventHandler(this.pongTimer_Tick);
            // 
            // rallycounterLabel
            // 
            this.rallycounterLabel.AutoSize = true;
            this.rallycounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.rallycounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rallycounterLabel.ForeColor = System.Drawing.Color.White;
            this.rallycounterLabel.Location = new System.Drawing.Point(52, 400);
            this.rallycounterLabel.Name = "rallycounterLabel";
            this.rallycounterLabel.Size = new System.Drawing.Size(21, 24);
            this.rallycounterLabel.TabIndex = 6;
            this.rallycounterLabel.Text = "0";
            // 
            // RallyCountLabel
            // 
            this.RallyCountLabel.AutoSize = true;
            this.RallyCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.RallyCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RallyCountLabel.ForeColor = System.Drawing.Color.White;
            this.RallyCountLabel.Location = new System.Drawing.Point(17, 376);
            this.RallyCountLabel.Name = "RallyCountLabel";
            this.RallyCountLabel.Size = new System.Drawing.Size(95, 18);
            this.RallyCountLabel.TabIndex = 7;
            this.RallyCountLabel.Text = "Rally Count";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ball.Location = new System.Drawing.Point(683, 208);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 33;
            this.ball.TabStop = false;
            // 
            // ballReset
            // 
            this.ballReset.Tick += new System.EventHandler(this.ballReset_Tick);
            // 
            // PongGamevsCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.RallyCountLabel);
            this.Controls.Add(this.rallycounterLabel);
            this.Controls.Add(this.player2scoreLabel);
            this.Controls.Add(this.player1scoreLabel);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player2);
            this.Name = "PongGamevsCPU";
            this.Text = "PongGame";
            this.Load += new System.EventHandler(this.PongGamevsCPU_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PongGamevsCPU_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PongGamevsCPU_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.Label player1scoreLabel;
        private System.Windows.Forms.Label player2scoreLabel;
        private System.Windows.Forms.Timer pongTimer;
        private System.Windows.Forms.Label rallycounterLabel;
        private System.Windows.Forms.Label RallyCountLabel;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer ballReset;
    }
}