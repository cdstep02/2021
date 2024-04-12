
namespace WindowsFormsApp1
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
            this.gpaLabel = new System.Windows.Forms.Label();
            this.admissionTestScoreLabel = new System.Windows.Forms.Label();
            this.gpaInput = new System.Windows.Forms.TextBox();
            this.testScoreInput = new System.Windows.Forms.TextBox();
            this.decisionButton = new System.Windows.Forms.Button();
            this.admissionOutput = new System.Windows.Forms.Label();
            this.admissionStatusLabel = new System.Windows.Forms.Label();
            this.runningTotalLabel = new System.Windows.Forms.Label();
            this.runningTotalOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(35, 50);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(317, 25);
            this.gpaLabel.TabIndex = 0;
            this.gpaLabel.Text = "Enter numeric high school GPA:";
            // 
            // admissionTestScoreLabel
            // 
            this.admissionTestScoreLabel.AutoSize = true;
            this.admissionTestScoreLabel.Location = new System.Drawing.Point(80, 108);
            this.admissionTestScoreLabel.Name = "admissionTestScoreLabel";
            this.admissionTestScoreLabel.Size = new System.Drawing.Size(272, 25);
            this.admissionTestScoreLabel.TabIndex = 1;
            this.admissionTestScoreLabel.Text = "Enter admission test score:";
            // 
            // gpaInput
            // 
            this.gpaInput.Location = new System.Drawing.Point(358, 47);
            this.gpaInput.Name = "gpaInput";
            this.gpaInput.Size = new System.Drawing.Size(100, 31);
            this.gpaInput.TabIndex = 2;
            // 
            // testScoreInput
            // 
            this.testScoreInput.Location = new System.Drawing.Point(358, 105);
            this.testScoreInput.Name = "testScoreInput";
            this.testScoreInput.Size = new System.Drawing.Size(100, 31);
            this.testScoreInput.TabIndex = 3;
            // 
            // decisionButton
            // 
            this.decisionButton.Location = new System.Drawing.Point(252, 252);
            this.decisionButton.Name = "decisionButton";
            this.decisionButton.Size = new System.Drawing.Size(100, 36);
            this.decisionButton.TabIndex = 4;
            this.decisionButton.Text = "Submit";
            this.decisionButton.UseVisualStyleBackColor = true;
            this.decisionButton.Click += new System.EventHandler(this.decisionButton_Click);
            // 
            // admissionOutput
            // 
            this.admissionOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.admissionOutput.Location = new System.Drawing.Point(358, 177);
            this.admissionOutput.Name = "admissionOutput";
            this.admissionOutput.Size = new System.Drawing.Size(100, 23);
            this.admissionOutput.TabIndex = 5;
            // 
            // admissionStatusLabel
            // 
            this.admissionStatusLabel.AutoSize = true;
            this.admissionStatusLabel.Location = new System.Drawing.Point(168, 178);
            this.admissionStatusLabel.Name = "admissionStatusLabel";
            this.admissionStatusLabel.Size = new System.Drawing.Size(184, 25);
            this.admissionStatusLabel.TabIndex = 6;
            this.admissionStatusLabel.Text = "Admission Status:";
            // 
            // runningTotalLabel
            // 
            this.runningTotalLabel.AutoSize = true;
            this.runningTotalLabel.Location = new System.Drawing.Point(499, 50);
            this.runningTotalLabel.Name = "runningTotalLabel";
            this.runningTotalLabel.Size = new System.Drawing.Size(152, 25);
            this.runningTotalLabel.TabIndex = 7;
            this.runningTotalLabel.Text = "Running Total:";
            // 
            // runningTotalOutput
            // 
            this.runningTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.runningTotalOutput.Location = new System.Drawing.Point(657, 49);
            this.runningTotalOutput.Name = "runningTotalOutput";
            this.runningTotalOutput.Size = new System.Drawing.Size(100, 23);
            this.runningTotalOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.runningTotalOutput);
            this.Controls.Add(this.runningTotalLabel);
            this.Controls.Add(this.admissionStatusLabel);
            this.Controls.Add(this.admissionOutput);
            this.Controls.Add(this.decisionButton);
            this.Controls.Add(this.testScoreInput);
            this.Controls.Add(this.gpaInput);
            this.Controls.Add(this.admissionTestScoreLabel);
            this.Controls.Add(this.gpaLabel);
            this.Name = "Form1";
            this.Text = "Lab4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label admissionTestScoreLabel;
        private System.Windows.Forms.TextBox gpaInput;
        private System.Windows.Forms.TextBox testScoreInput;
        private System.Windows.Forms.Button decisionButton;
        private System.Windows.Forms.Label admissionOutput;
        private System.Windows.Forms.Label admissionStatusLabel;
        private System.Windows.Forms.Label runningTotalLabel;
        private System.Windows.Forms.Label runningTotalOutput;
    }
}

