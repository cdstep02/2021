
namespace Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spherePic1 = new System.Windows.Forms.PictureBox();
            this.spherePic2 = new System.Windows.Forms.PictureBox();
            this.diameterLabel = new System.Windows.Forms.Label();
            this.diameterValue = new System.Windows.Forms.Label();
            this.surfaceAreaLabel = new System.Windows.Forms.Label();
            this.surfaceAreaValue = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.volumeValue = new System.Windows.Forms.Label();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.radiusInputValue = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spherePic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spherePic2)).BeginInit();
            this.SuspendLayout();
            // 
            // spherePic1
            // 
            this.spherePic1.Image = ((System.Drawing.Image)(resources.GetObject("spherePic1.Image")));
            this.spherePic1.Location = new System.Drawing.Point(12, 12);
            this.spherePic1.Name = "spherePic1";
            this.spherePic1.Size = new System.Drawing.Size(150, 150);
            this.spherePic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spherePic1.TabIndex = 0;
            this.spherePic1.TabStop = false;
            // 
            // spherePic2
            // 
            this.spherePic2.Image = ((System.Drawing.Image)(resources.GetObject("spherePic2.Image")));
            this.spherePic2.Location = new System.Drawing.Point(369, 311);
            this.spherePic2.Name = "spherePic2";
            this.spherePic2.Size = new System.Drawing.Size(150, 150);
            this.spherePic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spherePic2.TabIndex = 1;
            this.spherePic2.TabStop = false;
            // 
            // diameterLabel
            // 
            this.diameterLabel.AutoSize = true;
            this.diameterLabel.Location = new System.Drawing.Point(12, 230);
            this.diameterLabel.Name = "diameterLabel";
            this.diameterLabel.Size = new System.Drawing.Size(98, 25);
            this.diameterLabel.TabIndex = 2;
            this.diameterLabel.Text = "Diameter";
            // 
            // diameterValue
            // 
            this.diameterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameterValue.Location = new System.Drawing.Point(171, 230);
            this.diameterValue.Name = "diameterValue";
            this.diameterValue.Size = new System.Drawing.Size(100, 23);
            this.diameterValue.TabIndex = 3;
            // 
            // surfaceAreaLabel
            // 
            this.surfaceAreaLabel.AutoSize = true;
            this.surfaceAreaLabel.Location = new System.Drawing.Point(12, 285);
            this.surfaceAreaLabel.Name = "surfaceAreaLabel";
            this.surfaceAreaLabel.Size = new System.Drawing.Size(137, 25);
            this.surfaceAreaLabel.TabIndex = 4;
            this.surfaceAreaLabel.Text = "Surface Area";
            // 
            // surfaceAreaValue
            // 
            this.surfaceAreaValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surfaceAreaValue.Location = new System.Drawing.Point(171, 283);
            this.surfaceAreaValue.Name = "surfaceAreaValue";
            this.surfaceAreaValue.Size = new System.Drawing.Size(100, 23);
            this.surfaceAreaValue.TabIndex = 5;
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(12, 336);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(84, 25);
            this.volumeLabel.TabIndex = 6;
            this.volumeLabel.Text = "Volume";
            // 
            // volumeValue
            // 
            this.volumeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volumeValue.Location = new System.Drawing.Point(171, 336);
            this.volumeValue.Name = "volumeValue";
            this.volumeValue.Size = new System.Drawing.Size(100, 23);
            this.volumeValue.TabIndex = 7;
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(177, 53);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(199, 25);
            this.radiusLabel.TabIndex = 8;
            this.radiusLabel.Text = "Radius of a sphere:";
            // 
            // radiusInputValue
            // 
            this.radiusInputValue.Location = new System.Drawing.Point(382, 50);
            this.radiusInputValue.Name = "radiusInputValue";
            this.radiusInputValue.Size = new System.Drawing.Size(135, 31);
            this.radiusInputValue.TabIndex = 9;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(369, 110);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(148, 40);
            this.calcButton.TabIndex = 10;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 473);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.radiusInputValue);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.volumeValue);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.surfaceAreaValue);
            this.Controls.Add(this.surfaceAreaLabel);
            this.Controls.Add(this.diameterValue);
            this.Controls.Add(this.diameterLabel);
            this.Controls.Add(this.spherePic2);
            this.Controls.Add(this.spherePic1);
            this.Name = "Form1";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.spherePic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spherePic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox spherePic1;
        private System.Windows.Forms.PictureBox spherePic2;
        private System.Windows.Forms.Label diameterLabel;
        private System.Windows.Forms.Label diameterValue;
        private System.Windows.Forms.Label surfaceAreaLabel;
        private System.Windows.Forms.Label surfaceAreaValue;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label volumeValue;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.TextBox radiusInputValue;
        private System.Windows.Forms.Button calcButton;
    }
}

