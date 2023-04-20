namespace DemoDisk
{
    partial class ConsoleMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleMain));
            this.TTTButton = new System.Windows.Forms.Button();
            this.Hangmanbtn = new System.Windows.Forms.Button();
            this.Lockbtn = new System.Windows.Forms.Button();
            this.MazeGamebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TTTButton
            // 
            this.TTTButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TTTButton.BackgroundImage")));
            this.TTTButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TTTButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TTTButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TTTButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TTTButton.Location = new System.Drawing.Point(458, 445);
            this.TTTButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TTTButton.Name = "TTTButton";
            this.TTTButton.Size = new System.Drawing.Size(247, 132);
            this.TTTButton.TabIndex = 0;
            this.TTTButton.Text = "Tic Tac Toe";
            this.TTTButton.UseVisualStyleBackColor = true;
            this.TTTButton.Click += new System.EventHandler(this.TTTButton_Click);
            // 
            // Hangmanbtn
            // 
            this.Hangmanbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hangmanbtn.BackgroundImage")));
            this.Hangmanbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Hangmanbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hangmanbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Hangmanbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Hangmanbtn.Location = new System.Drawing.Point(458, 100);
            this.Hangmanbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Hangmanbtn.Name = "Hangmanbtn";
            this.Hangmanbtn.Size = new System.Drawing.Size(247, 132);
            this.Hangmanbtn.TabIndex = 1;
            this.Hangmanbtn.Text = "Hangman";
            this.Hangmanbtn.UseVisualStyleBackColor = true;
            this.Hangmanbtn.Click += new System.EventHandler(this.Hangmanbtn_Click);
            // 
            // Lockbtn
            // 
            this.Lockbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Lockbtn.BackgroundImage")));
            this.Lockbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lockbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lockbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Lockbtn.Location = new System.Drawing.Point(103, 280);
            this.Lockbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Lockbtn.Name = "Lockbtn";
            this.Lockbtn.Size = new System.Drawing.Size(247, 132);
            this.Lockbtn.TabIndex = 3;
            this.Lockbtn.Text = "Lock Picking";
            this.Lockbtn.UseVisualStyleBackColor = true;
            this.Lockbtn.Click += new System.EventHandler(this.Lockbtn_Click);
            // 
            // MazeGamebtn
            // 
            this.MazeGamebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MazeGamebtn.BackgroundImage")));
            this.MazeGamebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MazeGamebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MazeGamebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MazeGamebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MazeGamebtn.Location = new System.Drawing.Point(807, 280);
            this.MazeGamebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MazeGamebtn.Name = "MazeGamebtn";
            this.MazeGamebtn.Size = new System.Drawing.Size(247, 132);
            this.MazeGamebtn.TabIndex = 5;
            this.MazeGamebtn.Text = "Maze";
            this.MazeGamebtn.UseVisualStyleBackColor = true;
            this.MazeGamebtn.Click += new System.EventHandler(this.MazeGamebtn_Click);
            // 
            // ConsoleMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1154, 630);
            this.Controls.Add(this.MazeGamebtn);
            this.Controls.Add(this.Lockbtn);
            this.Controls.Add(this.Hangmanbtn);
            this.Controls.Add(this.TTTButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsoleMain";
            this.Text = "ConsoleMain";
            this.Load += new System.EventHandler(this.ConsoleMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button TTTButton;
        private Button Hangmanbtn;
        private Button Lockbtn;
        private Button MazeGamebtn;
    }
}