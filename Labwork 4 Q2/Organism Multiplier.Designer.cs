﻿namespace Labwork_4_Q2
{
    partial class Form1
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
            startingNumber = new TextBox();
            dailyIncrease = new TextBox();
            numberOfDaysMultiply = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // startingNumber
            // 
            startingNumber.Location = new Point(217, 16);
            startingNumber.Name = "startingNumber";
            startingNumber.Size = new Size(100, 23);
            startingNumber.TabIndex = 0;
            startingNumber.TextChanged += textBox1_TextChanged;
            // 
            // dailyIncrease
            // 
            dailyIncrease.Location = new Point(217, 58);
            dailyIncrease.Name = "dailyIncrease";
            dailyIncrease.Size = new Size(100, 23);
            dailyIncrease.TabIndex = 1;
            dailyIncrease.TextChanged += textBox2_TextChanged;
            // 
            // numberOfDaysMultiply
            // 
            numberOfDaysMultiply.Location = new Point(217, 104);
            numberOfDaysMultiply.Name = "numberOfDaysMultiply";
            numberOfDaysMultiply.Size = new Size(100, 23);
            numberOfDaysMultiply.TabIndex = 2;
            numberOfDaysMultiply.TextChanged += textBox3_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(41, 201);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(276, 124);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(228, 154);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 5;
            label1.Text = "Starting number of organisims";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 61);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 6;
            label2.Text = "Daily Increase";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 104);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 7;
            label3.Text = "Number of days to multiply";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 360);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(numberOfDaysMultiply);
            Controls.Add(dailyIncrease);
            Controls.Add(startingNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox startingNumber;
        private TextBox dailyIncrease;
        private TextBox numberOfDaysMultiply;
        private ListBox listBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}