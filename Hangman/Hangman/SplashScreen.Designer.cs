namespace Hangman
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Easy = new System.Windows.Forms.CheckBox();
            this.Medium = new System.Windows.Forms.CheckBox();
            this.Hard = new System.Windows.Forms.CheckBox();
            this.Difficulty = new System.Windows.Forms.GroupBox();
            this.Difficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-22, -22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(204, 156);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(642, 55);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "The Hangman\'s Corner";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(240, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(539, 76);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Easy
            // 
            this.Easy.Font = new System.Drawing.Font("Playbill", 20F);
            this.Easy.Location = new System.Drawing.Point(15, 25);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(118, 56);
            this.Easy.TabIndex = 8;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = true;
            this.Easy.CheckedChanged += new System.EventHandler(this.Easy_CheckedChanged);
            // 
            // Medium
            // 
            this.Medium.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medium.Location = new System.Drawing.Point(182, 25);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(154, 56);
            this.Medium.TabIndex = 9;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            this.Medium.CheckedChanged += new System.EventHandler(this.Medium_CheckedChanged);
            // 
            // Hard
            // 
            this.Hard.Font = new System.Drawing.Font("Playbill", 20F);
            this.Hard.Location = new System.Drawing.Point(431, 25);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(108, 56);
            this.Hard.TabIndex = 10;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            this.Hard.CheckedChanged += new System.EventHandler(this.Hard_CheckedChanged);
            // 
            // Difficulty
            // 
            this.Difficulty.Controls.Add(this.Easy);
            this.Difficulty.Controls.Add(this.Hard);
            this.Difficulty.Controls.Add(this.Medium);
            this.Difficulty.Location = new System.Drawing.Point(240, 542);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(539, 100);
            this.Difficulty.TabIndex = 11;
            this.Difficulty.TabStop = false;
            this.Difficulty.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 795);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.Difficulty.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Easy;
        private System.Windows.Forms.CheckBox Medium;
        private System.Windows.Forms.CheckBox Hard;
        private System.Windows.Forms.GroupBox Difficulty;
    }
}