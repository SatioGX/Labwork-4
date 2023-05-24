namespace Labwork_4_Q3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lightOffPicture = new PictureBox();
            lightOnPicture = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)lightOffPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lightOnPicture).BeginInit();
            SuspendLayout();
            // 
            // lightOffPicture
            // 
            lightOffPicture.Image = (Image)resources.GetObject("lightOffPicture.Image");
            lightOffPicture.Location = new Point(12, 12);
            lightOffPicture.Name = "lightOffPicture";
            lightOffPicture.Size = new Size(202, 265);
            lightOffPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            lightOffPicture.TabIndex = 0;
            lightOffPicture.TabStop = false;
            lightOffPicture.Visible = false;
            // 
            // lightOnPicture
            // 
            lightOnPicture.ErrorImage = null;
            lightOnPicture.Image = (Image)resources.GetObject("lightOnPicture.Image");
            lightOnPicture.Location = new Point(12, 12);
            lightOnPicture.Name = "lightOnPicture";
            lightOnPicture.Size = new Size(202, 265);
            lightOnPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            lightOnPicture.TabIndex = 1;
            lightOnPicture.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 334);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Switcher";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(155, 334);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 310);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 4;
            label1.Text = "On";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 374);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lightOnPicture);
            Controls.Add(lightOffPicture);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)lightOffPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)lightOnPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox lightOffPicture;
        private PictureBox lightOnPicture;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}