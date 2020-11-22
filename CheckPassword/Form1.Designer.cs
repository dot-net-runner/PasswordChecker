namespace CheckPassword
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
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.PasswordStatus = new System.Windows.Forms.Label();
            this.PasswordStatusPB = new System.Windows.Forms.ProgressBar();
            this.CheckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(12, 12);
            this.PasswordInput.Multiline = true;
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(288, 50);
            this.PasswordInput.TabIndex = 0;
            // 
            // PasswordStatus
            // 
            this.PasswordStatus.AutoSize = true;
            this.PasswordStatus.Location = new System.Drawing.Point(306, 89);
            this.PasswordStatus.Name = "PasswordStatus";
            this.PasswordStatus.Size = new System.Drawing.Size(50, 20);
            this.PasswordStatus.TabIndex = 1;
            this.PasswordStatus.Text = "label1";
            // 
            // PasswordStatusPB
            // 
            this.PasswordStatusPB.Location = new System.Drawing.Point(12, 80);
            this.PasswordStatusPB.Name = "PasswordStatusPB";
            this.PasswordStatusPB.Size = new System.Drawing.Size(288, 29);
            this.PasswordStatusPB.TabIndex = 2;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(306, 12);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(102, 50);
            this.CheckButton.TabIndex = 3;
            this.CheckButton.Text = "Проверить";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckPassword);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 143);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.PasswordStatusPB);
            this.Controls.Add(this.PasswordStatus);
            this.Controls.Add(this.PasswordInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label PasswordStatus;
        private System.Windows.Forms.ProgressBar PasswordStatusPB;
        private System.Windows.Forms.Button CheckButton;
    }
}

