namespace Attendance_System
{
    partial class LoginForm
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
            pictureBox1 = new PictureBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_password_key_80;
            pictureBox1.Location = new Point(134, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 94);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(45, 249);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(292, 27);
            maskedTextBox2.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(45, 342);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.PasswordChar = '*';
            maskedTextBox1.Size = new Size(292, 27);
            maskedTextBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 206);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 4;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 304);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(223, 392);
            button1.Name = "button1";
            button1.Size = new Size(108, 28);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Controls.Add(maskedTextBox2);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}