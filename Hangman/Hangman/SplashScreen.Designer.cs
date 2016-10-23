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
            this.butEZ = new System.Windows.Forms.Button();
            this.butNRM = new System.Windows.Forms.Button();
            this.butHRD = new System.Windows.Forms.Button();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textDesc = new System.Windows.Forms.TextBox();
            this.butHLP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-22, -22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // butEZ
            // 
            this.butEZ.BackColor = System.Drawing.Color.Green;
            this.butEZ.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEZ.Location = new System.Drawing.Point(763, 322);
            this.butEZ.Name = "butEZ";
            this.butEZ.Size = new System.Drawing.Size(142, 46);
            this.butEZ.TabIndex = 1;
            this.butEZ.Text = "Easy";
            this.butEZ.UseVisualStyleBackColor = false;
            this.butEZ.Click += new System.EventHandler(this.button1_Click);
            // 
            // butNRM
            // 
            this.butNRM.BackColor = System.Drawing.Color.Gold;
            this.butNRM.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNRM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butNRM.Location = new System.Drawing.Point(763, 401);
            this.butNRM.Name = "butNRM";
            this.butNRM.Size = new System.Drawing.Size(142, 46);
            this.butNRM.TabIndex = 3;
            this.butNRM.Text = "Normal";
            this.butNRM.UseVisualStyleBackColor = false;
            this.butNRM.Click += new System.EventHandler(this.button2_Click);
            // 
            // butHRD
            // 
            this.butHRD.BackColor = System.Drawing.Color.Red;
            this.butHRD.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHRD.Location = new System.Drawing.Point(763, 491);
            this.butHRD.Name = "butHRD";
            this.butHRD.Size = new System.Drawing.Size(142, 46);
            this.butHRD.TabIndex = 4;
            this.butHRD.Text = "Hard";
            this.butHRD.UseVisualStyleBackColor = false;
            // 
            // textTitle
            // 
            this.textTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTitle.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitle.Location = new System.Drawing.Point(204, 156);
            this.textTitle.Multiline = true;
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(642, 55);
            this.textTitle.TabIndex = 6;
            this.textTitle.Text = "The Hangman\'s Corner";
            this.textTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTitle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textDesc
            // 
            this.textDesc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textDesc.Font = new System.Drawing.Font("Playbill", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDesc.Location = new System.Drawing.Point(293, 497);
            this.textDesc.Name = "textDesc";
            this.textDesc.Size = new System.Drawing.Size(432, 40);
            this.textDesc.TabIndex = 7;
            this.textDesc.Text = "You Are Condemned to Learn";
            this.textDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDesc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // butHLP
            // 
            this.butHLP.BackColor = System.Drawing.Color.Blue;
            this.butHLP.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHLP.Location = new System.Drawing.Point(763, 575);
            this.butHLP.Name = "butHLP";
            this.butHLP.Size = new System.Drawing.Size(142, 44);
            this.butHLP.TabIndex = 8;
            this.butHLP.Text = "Help";
            this.butHLP.UseVisualStyleBackColor = false;
            this.butHLP.Click += new System.EventHandler(this.button4_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 795);
            this.Controls.Add(this.butHLP);
            this.Controls.Add(this.textDesc);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.butHRD);
            this.Controls.Add(this.butNRM);
            this.Controls.Add(this.butEZ);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button butEZ;
        private System.Windows.Forms.Button butNRM;
        private System.Windows.Forms.Button butHRD;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textDesc;
        private System.Windows.Forms.Button butHLP;
    }
}