namespace WordfuedHelper
{
    partial class Form1
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
            this.btnRun = new System.Windows.Forms.Button();
            this.tbInputLetter = new System.Windows.Forms.TextBox();
            this.lwAnswers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 269);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(115, 33);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Find Words";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // tbInputLetter
            // 
            this.tbInputLetter.Location = new System.Drawing.Point(12, 105);
            this.tbInputLetter.Name = "tbInputLetter";
            this.tbInputLetter.Size = new System.Drawing.Size(115, 22);
            this.tbInputLetter.TabIndex = 1;
            // 
            // lwAnswers
            // 
            this.lwAnswers.Location = new System.Drawing.Point(213, 16);
            this.lwAnswers.Name = "lwAnswers";
            this.lwAnswers.Size = new System.Drawing.Size(169, 299);
            this.lwAnswers.TabIndex = 2;
            this.lwAnswers.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 327);
            this.Controls.Add(this.lwAnswers);
            this.Controls.Add(this.tbInputLetter);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox tbInputLetter;
        private System.Windows.Forms.ListView lwAnswers;
    }
}

