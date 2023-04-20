namespace DemoDisk
{
    partial class DemoDiskMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoDiskMain));
            this.CasinoBtn = new System.Windows.Forms.Button();
            this.Alec = new System.Windows.Forms.Button();
            this.Sam = new System.Windows.Forms.Button();
            this.Alex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CasinoBtn
            // 
            this.CasinoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CasinoBtn.BackgroundImage")));
            this.CasinoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CasinoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CasinoBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CasinoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CasinoBtn.Location = new System.Drawing.Point(148, 82);
            this.CasinoBtn.Name = "CasinoBtn";
            this.CasinoBtn.Size = new System.Drawing.Size(224, 110);
            this.CasinoBtn.TabIndex = 0;
            this.CasinoBtn.Text = "Card Casino";
            this.CasinoBtn.UseVisualStyleBackColor = true;
            this.CasinoBtn.Click += new System.EventHandler(this.CasinoBtn_Click);
            // 
            // Alec
            // 
            this.Alec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Alec.BackgroundImage")));
            this.Alec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Alec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alec.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Alec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Alec.Location = new System.Drawing.Point(408, 235);
            this.Alec.Name = "Alec";
            this.Alec.Size = new System.Drawing.Size(224, 110);
            this.Alec.TabIndex = 1;
            this.Alec.Text = "Console Games";
            this.Alec.UseVisualStyleBackColor = true;
            this.Alec.Click += new System.EventHandler(this.Alec_Click);
            // 
            // Sam
            // 
            this.Sam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sam.BackgroundImage")));
            this.Sam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sam.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Sam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Sam.Location = new System.Drawing.Point(408, 82);
            this.Sam.Name = "Sam";
            this.Sam.Size = new System.Drawing.Size(224, 110);
            this.Sam.TabIndex = 1;
            this.Sam.Text = "Zombie Game";
            this.Sam.UseVisualStyleBackColor = true;
            this.Sam.Click += new System.EventHandler(this.Sam_Click);
            // 
            // Alex
            // 
            this.Alex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Alex.BackgroundImage")));
            this.Alex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Alex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alex.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Alex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alex.Location = new System.Drawing.Point(148, 235);
            this.Alex.Name = "Alex";
            this.Alex.Size = new System.Drawing.Size(224, 110);
            this.Alex.TabIndex = 2;
            this.Alex.Text = "Pong";
            this.Alex.UseVisualStyleBackColor = true;
            this.Alex.Click += new System.EventHandler(this.button3_Click);
            // 
            // DemoDiskMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.BackgroundImage = global::DemoDisk.Properties.Resources._70619a9655183_560d7bfb8dc17;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Alex);
            this.Controls.Add(this.Sam);
            this.Controls.Add(this.Alec);
            this.Controls.Add(this.CasinoBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DemoDiskMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DemoDiskMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button CasinoBtn;
        private Button Alec;
        private Button Sam;
        private Button Alex;
    }
}