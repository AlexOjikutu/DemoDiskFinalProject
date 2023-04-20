namespace DemoDisk
{
    partial class CasinoMain
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
            this.BlackJackBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BlackJackBtn
            // 
            this.BlackJackBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.BlackJackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BlackJackBtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BlackJackBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BlackJackBtn.Location = new System.Drawing.Point(108, 98);
            this.BlackJackBtn.Name = "BlackJackBtn";
            this.BlackJackBtn.Size = new System.Drawing.Size(114, 70);
            this.BlackJackBtn.TabIndex = 0;
            this.BlackJackBtn.Text = "Black Jack";
            this.BlackJackBtn.UseVisualStyleBackColor = false;
            this.BlackJackBtn.Click += new System.EventHandler(this.BlackJackBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(228, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "3 Card Poker";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CasinoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(456, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BlackJackBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CasinoMain";
            this.Text = "CasinoMain";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BlackJackBtn;
        private Button button1;
    }
}