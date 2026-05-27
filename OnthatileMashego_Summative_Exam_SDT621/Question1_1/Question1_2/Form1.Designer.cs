namespace Question1_2
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
            lblName = new Label();
            txtName = new TextBox();
            btnGreeting = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(92, 88);
            lblName.Name = "lblName";
            lblName.Size = new Size(200, 32);
            lblName.TabIndex = 0;
            lblName.Text = "Enter your Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(327, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(383, 39);
            txtName.TabIndex = 1;
            // 
            // btnGreeting
            // 
            btnGreeting.Location = new Point(499, 154);
            btnGreeting.Name = "btnGreeting";
            btnGreeting.Size = new Size(211, 61);
            btnGreeting.TabIndex = 2;
            btnGreeting.Text = "Greeting";
            btnGreeting.UseVisualStyleBackColor = true;
            btnGreeting.Click += btnGreeting_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGreeting);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Button btnGreeting;
    }
}
