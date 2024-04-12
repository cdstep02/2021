
namespace Prog3
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
            this.farmLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.initialCostLabel = new System.Windows.Forms.Label();
            this.discountedCostLabel = new System.Windows.Forms.Label();
            this.shipmentCostLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.farmComboBox = new System.Windows.Forms.ComboBox();
            this.itemInput = new System.Windows.Forms.TextBox();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.intitalCostOutput = new System.Windows.Forms.Label();
            this.discountedCostOutput = new System.Windows.Forms.Label();
            this.shipmentCostOutput = new System.Windows.Forms.Label();
            this.totalPriceOutPut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // farmLabel
            // 
            this.farmLabel.AutoSize = true;
            this.farmLabel.Location = new System.Drawing.Point(121, 75);
            this.farmLabel.Name = "farmLabel";
            this.farmLabel.Size = new System.Drawing.Size(67, 25);
            this.farmLabel.TabIndex = 0;
            this.farmLabel.Text = "Farm:";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(130, 129);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(58, 25);
            this.itemLabel.TabIndex = 1;
            this.itemLabel.Text = "Item:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(42, 198);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(146, 25);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity (lbs):";
            // 
            // initialCostLabel
            // 
            this.initialCostLabel.AutoSize = true;
            this.initialCostLabel.Location = new System.Drawing.Point(70, 292);
            this.initialCostLabel.Name = "initialCostLabel";
            this.initialCostLabel.Size = new System.Drawing.Size(118, 25);
            this.initialCostLabel.TabIndex = 3;
            this.initialCostLabel.Text = "Initial Cost:";
            // 
            // discountedCostLabel
            // 
            this.discountedCostLabel.AutoSize = true;
            this.discountedCostLabel.Location = new System.Drawing.Point(12, 346);
            this.discountedCostLabel.Name = "discountedCostLabel";
            this.discountedCostLabel.Size = new System.Drawing.Size(176, 25);
            this.discountedCostLabel.TabIndex = 4;
            this.discountedCostLabel.Text = "Discounted Cost:";
            // 
            // shipmentCostLabel
            // 
            this.shipmentCostLabel.AutoSize = true;
            this.shipmentCostLabel.Location = new System.Drawing.Point(30, 396);
            this.shipmentCostLabel.Name = "shipmentCostLabel";
            this.shipmentCostLabel.Size = new System.Drawing.Size(158, 25);
            this.shipmentCostLabel.TabIndex = 5;
            this.shipmentCostLabel.Text = "Shipment Cost:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(67, 451);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(121, 25);
            this.totalPriceLabel.TabIndex = 6;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // calcButton
            // 
            this.calcButton.AutoSize = true;
            this.calcButton.Location = new System.Drawing.Point(176, 239);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(112, 35);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // farmComboBox
            // 
            this.farmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.farmComboBox.FormattingEnabled = true;
            this.farmComboBox.Items.AddRange(new object[] {
            "NE",
            "NW",
            "SE",
            "SW"});
            this.farmComboBox.Location = new System.Drawing.Point(194, 72);
            this.farmComboBox.Name = "farmComboBox";
            this.farmComboBox.Size = new System.Drawing.Size(121, 33);
            this.farmComboBox.TabIndex = 8;
            // 
            // itemInput
            // 
            this.itemInput.Location = new System.Drawing.Point(194, 126);
            this.itemInput.Name = "itemInput";
            this.itemInput.Size = new System.Drawing.Size(100, 31);
            this.itemInput.TabIndex = 9;
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(194, 195);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(100, 31);
            this.quantityInput.TabIndex = 10;
            // 
            // intitalCostOutput
            // 
            this.intitalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intitalCostOutput.Location = new System.Drawing.Point(194, 291);
            this.intitalCostOutput.Name = "intitalCostOutput";
            this.intitalCostOutput.Size = new System.Drawing.Size(100, 23);
            this.intitalCostOutput.TabIndex = 11;
            // 
            // discountedCostOutput
            // 
            this.discountedCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountedCostOutput.Location = new System.Drawing.Point(194, 345);
            this.discountedCostOutput.Name = "discountedCostOutput";
            this.discountedCostOutput.Size = new System.Drawing.Size(100, 23);
            this.discountedCostOutput.TabIndex = 12;
            // 
            // shipmentCostOutput
            // 
            this.shipmentCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shipmentCostOutput.Location = new System.Drawing.Point(194, 395);
            this.shipmentCostOutput.Name = "shipmentCostOutput";
            this.shipmentCostOutput.Size = new System.Drawing.Size(100, 23);
            this.shipmentCostOutput.TabIndex = 13;
            // 
            // totalPriceOutPut
            // 
            this.totalPriceOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOutPut.Location = new System.Drawing.Point(194, 450);
            this.totalPriceOutPut.Name = "totalPriceOutPut";
            this.totalPriceOutPut.Size = new System.Drawing.Size(100, 23);
            this.totalPriceOutPut.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.totalPriceOutPut);
            this.Controls.Add(this.shipmentCostOutput);
            this.Controls.Add(this.discountedCostOutput);
            this.Controls.Add(this.intitalCostOutput);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.itemInput);
            this.Controls.Add(this.farmComboBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.shipmentCostLabel);
            this.Controls.Add(this.discountedCostLabel);
            this.Controls.Add(this.initialCostLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.farmLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label farmLabel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label initialCostLabel;
        private System.Windows.Forms.Label discountedCostLabel;
        private System.Windows.Forms.Label shipmentCostLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.ComboBox farmComboBox;
        private System.Windows.Forms.TextBox itemInput;
        private System.Windows.Forms.TextBox quantityInput;
        private System.Windows.Forms.Label intitalCostOutput;
        private System.Windows.Forms.Label discountedCostOutput;
        private System.Windows.Forms.Label shipmentCostOutput;
        private System.Windows.Forms.Label totalPriceOutPut;
    }
}

