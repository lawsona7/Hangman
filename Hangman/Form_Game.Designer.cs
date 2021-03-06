﻿namespace Hangman
{
    partial class Form_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Game));
            this.cmdA = new System.Windows.Forms.Button();
            this.cmdB = new System.Windows.Forms.Button();
            this.hangImage = new System.Windows.Forms.PictureBox();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.lblShowWord = new System.Windows.Forms.Label();
            this.cmdC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdE = new System.Windows.Forms.Button();
            this.cmdD = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.restart_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdA
            // 
            this.cmdA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdA.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdA.Location = new System.Drawing.Point(905, 922);
            this.cmdA.Name = "cmdA";
            this.cmdA.Size = new System.Drawing.Size(71, 52);
            this.cmdA.TabIndex = 1;
            this.cmdA.Text = "a";
            this.cmdA.UseVisualStyleBackColor = false;
            this.cmdA.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdB
            // 
            this.cmdB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdB.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdB.Location = new System.Drawing.Point(999, 922);
            this.cmdB.Name = "cmdB";
            this.cmdB.Size = new System.Drawing.Size(70, 52);
            this.cmdB.TabIndex = 2;
            this.cmdB.Text = "b";
            this.cmdB.UseVisualStyleBackColor = false;
            this.cmdB.Click += new System.EventHandler(this.guessClick);
            // 
            // hangImage
            // 
            this.hangImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hangImage.BackColor = System.Drawing.SystemColors.Control;
            this.hangImage.Image = ((System.Drawing.Image)(resources.GetObject("hangImage.Image")));
            this.hangImage.Location = new System.Drawing.Point(687, -16);
            this.hangImage.Name = "hangImage";
            this.hangImage.Size = new System.Drawing.Size(1406, 729);
            this.hangImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hangImage.TabIndex = 0;
            this.hangImage.TabStop = false;
            // 
            // lblWinLose
            // 
            this.lblWinLose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWinLose.BackColor = System.Drawing.Color.Transparent;
            this.lblWinLose.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLose.Location = new System.Drawing.Point(2099, 575);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(682, 127);
            this.lblWinLose.TabIndex = 3;
            this.lblWinLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShowWord
            // 
            this.lblShowWord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblShowWord.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblShowWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowWord.Font = new System.Drawing.Font("Playbill", 24F);
            this.lblShowWord.Location = new System.Drawing.Point(687, 765);
            this.lblShowWord.Name = "lblShowWord";
            this.lblShowWord.Size = new System.Drawing.Size(1411, 84);
            this.lblShowWord.TabIndex = 4;
            this.lblShowWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdC
            // 
            this.cmdC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdC.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdC.Location = new System.Drawing.Point(1088, 922);
            this.cmdC.Name = "cmdC";
            this.cmdC.Size = new System.Drawing.Size(76, 52);
            this.cmdC.TabIndex = 5;
            this.cmdC.Text = "c";
            this.cmdC.UseVisualStyleBackColor = false;
            this.cmdC.Click += new System.EventHandler(this.guessClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1369, 922);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "f";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdE
            // 
            this.cmdE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdE.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdE.Location = new System.Drawing.Point(1282, 922);
            this.cmdE.Name = "cmdE";
            this.cmdE.Size = new System.Drawing.Size(64, 52);
            this.cmdE.TabIndex = 7;
            this.cmdE.Text = "e";
            this.cmdE.UseVisualStyleBackColor = false;
            this.cmdE.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdD
            // 
            this.cmdD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdD.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdD.Location = new System.Drawing.Point(1187, 922);
            this.cmdD.Name = "cmdD";
            this.cmdD.Size = new System.Drawing.Size(74, 52);
            this.cmdD.TabIndex = 6;
            this.cmdD.Text = "d";
            this.cmdD.UseVisualStyleBackColor = false;
            this.cmdD.Click += new System.EventHandler(this.guessClick);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1619, 922);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 52);
            this.button4.TabIndex = 11;
            this.button4.Text = "i";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.guessClick);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button5.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1535, 922);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 52);
            this.button5.TabIndex = 10;
            this.button5.Text = "h";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.guessClick);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button6.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1454, 922);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 52);
            this.button6.TabIndex = 9;
            this.button6.Text = "g";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.guessClick);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button7.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1088, 981);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 54);
            this.button7.TabIndex = 14;
            this.button7.Text = "l";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.guessClick);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button8.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(999, 981);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 54);
            this.button8.TabIndex = 13;
            this.button8.Text = "k";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.guessClick);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button9.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(905, 981);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 54);
            this.button9.TabIndex = 12;
            this.button9.Text = "j";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.guessClick);
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button10.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(1369, 981);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(63, 54);
            this.button10.TabIndex = 17;
            this.button10.Text = "o";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.guessClick);
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button11.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1282, 981);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(64, 54);
            this.button11.TabIndex = 16;
            this.button11.Text = "n";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.guessClick);
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button12.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(1187, 981);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(74, 54);
            this.button12.TabIndex = 15;
            this.button12.Text = "m";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.guessClick);
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button13.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(1619, 981);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(63, 54);
            this.button13.TabIndex = 20;
            this.button13.Text = "r";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.guessClick);
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button14.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(1535, 981);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(70, 54);
            this.button14.TabIndex = 19;
            this.button14.Text = "q";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.guessClick);
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button15.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button15.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(1454, 981);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(64, 54);
            this.button15.TabIndex = 18;
            this.button15.Text = "p";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.guessClick);
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button16.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button16.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(1088, 1039);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(76, 52);
            this.button16.TabIndex = 23;
            this.button16.Text = "u";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.guessClick);
            // 
            // button17
            // 
            this.button17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button17.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button17.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(999, 1039);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(70, 52);
            this.button17.TabIndex = 22;
            this.button17.Text = "t";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.guessClick);
            // 
            // button18
            // 
            this.button18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button18.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button18.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(905, 1039);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(71, 52);
            this.button18.TabIndex = 21;
            this.button18.Text = "s";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.guessClick);
            // 
            // button19
            // 
            this.button19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button19.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button19.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(1369, 1039);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(63, 52);
            this.button19.TabIndex = 26;
            this.button19.Text = "x";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.guessClick);
            // 
            // button20
            // 
            this.button20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button20.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button20.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(1282, 1039);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(64, 52);
            this.button20.TabIndex = 25;
            this.button20.Text = "w";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.guessClick);
            // 
            // button21
            // 
            this.button21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button21.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button21.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(1187, 1039);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(74, 52);
            this.button21.TabIndex = 24;
            this.button21.Text = "v";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.guessClick);
            // 
            // button23
            // 
            this.button23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button23.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button23.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(1535, 1039);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(70, 52);
            this.button23.TabIndex = 28;
            this.button23.Text = "z";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.guessClick);
            // 
            // button24
            // 
            this.button24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button24.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button24.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(1454, 1039);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(64, 52);
            this.button24.TabIndex = 27;
            this.button24.Text = "y";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.guessClick);
            // 
            // restart_Button
            // 
            this.restart_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.restart_Button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.restart_Button.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart_Button.Location = new System.Drawing.Point(2182, 854);
            this.restart_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.restart_Button.Name = "restart_Button";
            this.restart_Button.Size = new System.Drawing.Size(195, 69);
            this.restart_Button.TabIndex = 29;
            this.restart_Button.Text = "Restart?";
            this.restart_Button.UseVisualStyleBackColor = false;
            this.restart_Button.Click += new System.EventHandler(this.restart_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Hangman.Properties.Resources.high_noon_original;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(2094, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 554);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(2192, 1213);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 69);
            this.button2.TabIndex = 31;
            this.button2.Text = "Quit Game?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(2257, 1290);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 32;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Hangman.Properties.Resources.Background_Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2782, 1386);
            this.ControlBox = false;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.restart_Button);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdE);
            this.Controls.Add(this.cmdD);
            this.Controls.Add(this.cmdC);
            this.Controls.Add(this.lblShowWord);
            this.Controls.Add(this.lblWinLose);
            this.Controls.Add(this.cmdB);
            this.Controls.Add(this.cmdA);
            this.Controls.Add(this.hangImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHangman_Load);
            this.Click += new System.EventHandler(this.guessClick);
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox hangImage;
        private System.Windows.Forms.Button cmdA;
        private System.Windows.Forms.Button cmdB;
        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.Label lblShowWord;
        private System.Windows.Forms.Button cmdC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdE;
        private System.Windows.Forms.Button cmdD;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button restart_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

