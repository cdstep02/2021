
namespace Prog1
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
            this.title = new System.Windows.Forms.Label();
            this.gardenWidthLabel = new System.Windows.Forms.Label();
            this.gardenLengthLabel = new System.Windows.Forms.Label();
            this.soilPriceLabel = new System.Windows.Forms.Label();
            this.fertilizerLabel = new System.Windows.Forms.Label();
            this.yesNoLabel1 = new System.Windows.Forms.Label();
            this.firstGardenLabel = new System.Windows.Forms.Label();
            this.yesNoLabel2 = new System.Windows.Forms.Label();
            this.squareYardsLabel = new System.Windows.Forms.Label();
            this.soilCostLabel = new System.Windows.Forms.Label();
            this.fertilizerCostLabel = new System.Windows.Forms.Label();
            this.laborCostLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.gardenWidthTxt = new System.Windows.Forms.TextBox();
            this.gardenLengthTxt = new System.Windows.Forms.TextBox();
            this.soilPriceTxt = new System.Windows.Forms.TextBox();
            this.fertilizerTxt = new System.Windows.Forms.TextBox();
            this.firstGardenTxt = new System.Windows.Forms.TextBox();
            this.squareYardsOutput = new System.Windows.Forms.Label();
            this.soilCostOutput = new System.Windows.Forms.Label();
            this.fertilizerCostOutput = new System.Windows.Forms.Label();
            this.laborCostOutput = new System.Windows.Forms.Label();
            this.totalCostOutput = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(152, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(445, 25);
            this.title.TabIndex = 0;
            this.title.Text = "EZ-Garden and Landscaping Costs Estimator";
            // 
            // gardenWidthLabel
            // 
            this.gardenWidthLabel.AutoSize = true;
            this.gardenWidthLabel.Location = new System.Drawing.Point(87, 88);
            this.gardenWidthLabel.Name = "gardenWidthLabel";
            this.gardenWidthLabel.Size = new System.Drawing.Size(253, 25);
            this.gardenWidthLabel.TabIndex = 1;
            this.gardenWidthLabel.Text = "Max Width of Garden (ft):";
            // 
            // gardenLengthLabel
            // 
            this.gardenLengthLabel.AutoSize = true;
            this.gardenLengthLabel.Location = new System.Drawing.Point(76, 146);
            this.gardenLengthLabel.Name = "gardenLengthLabel";
            this.gardenLengthLabel.Size = new System.Drawing.Size(264, 25);
            this.gardenLengthLabel.TabIndex = 2;
            this.gardenLengthLabel.Text = "Max Length of Garden (ft):";
            // 
            // soilPriceLabel
            // 
            this.soilPriceLabel.AutoSize = true;
            this.soilPriceLabel.Location = new System.Drawing.Point(153, 205);
            this.soilPriceLabel.Name = "soilPriceLabel";
            this.soilPriceLabel.Size = new System.Drawing.Size(187, 25);
            this.soilPriceLabel.TabIndex = 3;
            this.soilPriceLabel.Text = "Soil Price (sq. yd):";
            // 
            // fertilizerLabel
            // 
            this.fertilizerLabel.AutoSize = true;
            this.fertilizerLabel.Location = new System.Drawing.Point(239, 259);
            this.fertilizerLabel.Name = "fertilizerLabel";
            this.fertilizerLabel.Size = new System.Drawing.Size(101, 25);
            this.fertilizerLabel.TabIndex = 4;
            this.fertilizerLabel.Text = "Fertilizer:";
            // 
            // yesNoLabel1
            // 
            this.yesNoLabel1.AutoSize = true;
            this.yesNoLabel1.Location = new System.Drawing.Point(152, 284);
            this.yesNoLabel1.Name = "yesNoLabel1";
            this.yesNoLabel1.Size = new System.Drawing.Size(184, 25);
            this.yesNoLabel1.TabIndex = 5;
            this.yesNoLabel1.Text = "(1 = YES, 0 = NO)";
            // 
            // firstGardenLabel
            // 
            this.firstGardenLabel.AutoSize = true;
            this.firstGardenLabel.Location = new System.Drawing.Point(203, 337);
            this.firstGardenLabel.Name = "firstGardenLabel";
            this.firstGardenLabel.Size = new System.Drawing.Size(137, 25);
            this.firstGardenLabel.TabIndex = 6;
            this.firstGardenLabel.Text = "First Garden:";
            // 
            // yesNoLabel2
            // 
            this.yesNoLabel2.AutoSize = true;
            this.yesNoLabel2.Location = new System.Drawing.Point(152, 362);
            this.yesNoLabel2.Name = "yesNoLabel2";
            this.yesNoLabel2.Size = new System.Drawing.Size(184, 25);
            this.yesNoLabel2.TabIndex = 7;
            this.yesNoLabel2.Text = "(1 = YES, 0 = NO)";
            // 
            // squareYardsLabel
            // 
            this.squareYardsLabel.AutoSize = true;
            this.squareYardsLabel.Location = new System.Drawing.Point(223, 449);
            this.squareYardsLabel.Name = "squareYardsLabel";
            this.squareYardsLabel.Size = new System.Drawing.Size(113, 25);
            this.squareYardsLabel.TabIndex = 8;
            this.squareYardsLabel.Text = "Sq. Yards:";
            // 
            // soilCostLabel
            // 
            this.soilCostLabel.AutoSize = true;
            this.soilCostLabel.Location = new System.Drawing.Point(232, 514);
            this.soilCostLabel.Name = "soilCostLabel";
            this.soilCostLabel.Size = new System.Drawing.Size(104, 25);
            this.soilCostLabel.TabIndex = 9;
            this.soilCostLabel.Text = "Soil Cost:";
            // 
            // fertilizerCostLabel
            // 
            this.fertilizerCostLabel.AutoSize = true;
            this.fertilizerCostLabel.Location = new System.Drawing.Point(185, 574);
            this.fertilizerCostLabel.Name = "fertilizerCostLabel";
            this.fertilizerCostLabel.Size = new System.Drawing.Size(151, 25);
            this.fertilizerCostLabel.TabIndex = 10;
            this.fertilizerCostLabel.Text = "Fertilizer Cost:";
            // 
            // laborCostLabel
            // 
            this.laborCostLabel.AutoSize = true;
            this.laborCostLabel.Location = new System.Drawing.Point(213, 625);
            this.laborCostLabel.Name = "laborCostLabel";
            this.laborCostLabel.Size = new System.Drawing.Size(123, 25);
            this.laborCostLabel.TabIndex = 11;
            this.laborCostLabel.Text = "Labor Cost:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(220, 679);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(116, 25);
            this.totalCostLabel.TabIndex = 12;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // gardenWidthTxt
            // 
            this.gardenWidthTxt.Location = new System.Drawing.Point(346, 85);
            this.gardenWidthTxt.Name = "gardenWidthTxt";
            this.gardenWidthTxt.Size = new System.Drawing.Size(100, 31);
            this.gardenWidthTxt.TabIndex = 13;
            // 
            // gardenLengthTxt
            // 
            this.gardenLengthTxt.Location = new System.Drawing.Point(346, 143);
            this.gardenLengthTxt.Name = "gardenLengthTxt";
            this.gardenLengthTxt.Size = new System.Drawing.Size(100, 31);
            this.gardenLengthTxt.TabIndex = 14;
            // 
            // soilPriceTxt
            // 
            this.soilPriceTxt.Location = new System.Drawing.Point(346, 202);
            this.soilPriceTxt.Name = "soilPriceTxt";
            this.soilPriceTxt.Size = new System.Drawing.Size(100, 31);
            this.soilPriceTxt.TabIndex = 15;
            // 
            // fertilizerTxt
            // 
            this.fertilizerTxt.Location = new System.Drawing.Point(346, 253);
            this.fertilizerTxt.Name = "fertilizerTxt";
            this.fertilizerTxt.Size = new System.Drawing.Size(100, 31);
            this.fertilizerTxt.TabIndex = 16;
            // 
            // firstGardenTxt
            // 
            this.firstGardenTxt.Location = new System.Drawing.Point(346, 334);
            this.firstGardenTxt.Name = "firstGardenTxt";
            this.firstGardenTxt.Size = new System.Drawing.Size(100, 31);
            this.firstGardenTxt.TabIndex = 17;
            // 
            // squareYardsOutput
            // 
            this.squareYardsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.squareYardsOutput.Location = new System.Drawing.Point(346, 448);
            this.squareYardsOutput.Name = "squareYardsOutput";
            this.squareYardsOutput.Size = new System.Drawing.Size(100, 23);
            this.squareYardsOutput.TabIndex = 18;
            // 
            // soilCostOutput
            // 
            this.soilCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soilCostOutput.Location = new System.Drawing.Point(346, 513);
            this.soilCostOutput.Name = "soilCostOutput";
            this.soilCostOutput.Size = new System.Drawing.Size(100, 23);
            this.soilCostOutput.TabIndex = 19;
            // 
            // fertilizerCostOutput
            // 
            this.fertilizerCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fertilizerCostOutput.Location = new System.Drawing.Point(346, 573);
            this.fertilizerCostOutput.Name = "fertilizerCostOutput";
            this.fertilizerCostOutput.Size = new System.Drawing.Size(100, 23);
            this.fertilizerCostOutput.TabIndex = 20;
            // 
            // laborCostOutput
            // 
            this.laborCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborCostOutput.Location = new System.Drawing.Point(346, 624);
            this.laborCostOutput.Name = "laborCostOutput";
            this.laborCostOutput.Size = new System.Drawing.Size(100, 23);
            this.laborCostOutput.TabIndex = 21;
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutput.Location = new System.Drawing.Point(346, 678);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.Size = new System.Drawing.Size(100, 23);
            this.totalCostOutput.TabIndex = 22;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(228, 725);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(220, 47);
            this.calcButton.TabIndex = 23;
            this.calcButton.Text = "Calculate Estimate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 974);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.totalCostOutput);
            this.Controls.Add(this.laborCostOutput);
            this.Controls.Add(this.fertilizerCostOutput);
            this.Controls.Add(this.soilCostOutput);
            this.Controls.Add(this.squareYardsOutput);
            this.Controls.Add(this.firstGardenTxt);
            this.Controls.Add(this.fertilizerTxt);
            this.Controls.Add(this.soilPriceTxt);
            this.Controls.Add(this.gardenLengthTxt);
            this.Controls.Add(this.gardenWidthTxt);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.laborCostLabel);
            this.Controls.Add(this.fertilizerCostLabel);
            this.Controls.Add(this.soilCostLabel);
            this.Controls.Add(this.squareYardsLabel);
            this.Controls.Add(this.yesNoLabel2);
            this.Controls.Add(this.firstGardenLabel);
            this.Controls.Add(this.yesNoLabel1);
            this.Controls.Add(this.fertilizerLabel);
            this.Controls.Add(this.soilPriceLabel);
            this.Controls.Add(this.gardenLengthLabel);
            this.Controls.Add(this.gardenWidthLabel);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label gardenWidthLabel;
        private System.Windows.Forms.Label gardenLengthLabel;
        private System.Windows.Forms.Label soilPriceLabel;
        private System.Windows.Forms.Label fertilizerLabel;
        private System.Windows.Forms.Label yesNoLabel1;
        private System.Windows.Forms.Label firstGardenLabel;
        private System.Windows.Forms.Label yesNoLabel2;
        private System.Windows.Forms.Label squareYardsLabel;
        private System.Windows.Forms.Label soilCostLabel;
        private System.Windows.Forms.Label fertilizerCostLabel;
        private System.Windows.Forms.Label laborCostLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.TextBox gardenWidthTxt;
        private System.Windows.Forms.TextBox gardenLengthTxt;
        private System.Windows.Forms.TextBox soilPriceTxt;
        private System.Windows.Forms.TextBox fertilizerTxt;
        private System.Windows.Forms.TextBox firstGardenTxt;
        private System.Windows.Forms.Label squareYardsOutput;
        private System.Windows.Forms.Label soilCostOutput;
        private System.Windows.Forms.Label fertilizerCostOutput;
        private System.Windows.Forms.Label laborCostOutput;
        private System.Windows.Forms.Label totalCostOutput;
        private System.Windows.Forms.Button calcButton;
    }
}

