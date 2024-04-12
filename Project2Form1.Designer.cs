
namespace Prog2
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
            this.peopleLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.peopleInput = new System.Windows.Forms.TextBox();
            this.distanceInput = new System.Windows.Forms.TextBox();
            this.deliveryInput = new System.Windows.Forms.TextBox();
            this.resultsBox = new System.Windows.Forms.GroupBox();
            this.companyCCost = new System.Windows.Forms.Label();
            this.companyCLabel = new System.Windows.Forms.Label();
            this.companyBCost = new System.Windows.Forms.Label();
            this.CompanyBLabel = new System.Windows.Forms.Label();
            this.companyACost = new System.Windows.Forms.Label();
            this.companyALabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.lowestCostLabel = new System.Windows.Forms.Label();
            this.resultsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Location = new System.Drawing.Point(158, 231);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(79, 25);
            this.peopleLabel.TabIndex = 0;
            this.peopleLabel.Text = "People";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(70, 334);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(167, 25);
            this.distanceLabel.TabIndex = 1;
            this.distanceLabel.Text = "Distance (Miles)";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(92, 436);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(145, 25);
            this.daysLabel.TabIndex = 2;
            this.daysLabel.Text = "Delivery Days";
            // 
            // peopleInput
            // 
            this.peopleInput.Location = new System.Drawing.Point(252, 228);
            this.peopleInput.Name = "peopleInput";
            this.peopleInput.Size = new System.Drawing.Size(100, 31);
            this.peopleInput.TabIndex = 3;
            // 
            // distanceInput
            // 
            this.distanceInput.Location = new System.Drawing.Point(252, 331);
            this.distanceInput.Name = "distanceInput";
            this.distanceInput.Size = new System.Drawing.Size(100, 31);
            this.distanceInput.TabIndex = 4;
            // 
            // deliveryInput
            // 
            this.deliveryInput.Location = new System.Drawing.Point(252, 433);
            this.deliveryInput.Name = "deliveryInput";
            this.deliveryInput.Size = new System.Drawing.Size(100, 31);
            this.deliveryInput.TabIndex = 5;
            // 
            // resultsBox
            // 
            this.resultsBox.Controls.Add(this.lowestCostLabel);
            this.resultsBox.Controls.Add(this.companyCCost);
            this.resultsBox.Controls.Add(this.companyCLabel);
            this.resultsBox.Controls.Add(this.companyBCost);
            this.resultsBox.Controls.Add(this.CompanyBLabel);
            this.resultsBox.Controls.Add(this.companyACost);
            this.resultsBox.Controls.Add(this.companyALabel);
            this.resultsBox.Location = new System.Drawing.Point(408, 146);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(785, 411);
            this.resultsBox.TabIndex = 6;
            this.resultsBox.TabStop = false;
            this.resultsBox.Text = "Results";
            // 
            // companyCCost
            // 
            this.companyCCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyCCost.Location = new System.Drawing.Point(333, 249);
            this.companyCCost.Name = "companyCCost";
            this.companyCCost.Size = new System.Drawing.Size(100, 23);
            this.companyCCost.TabIndex = 5;
            // 
            // companyCLabel
            // 
            this.companyCLabel.AutoSize = true;
            this.companyCLabel.Location = new System.Drawing.Point(66, 250);
            this.companyCLabel.Name = "companyCLabel";
            this.companyCLabel.Size = new System.Drawing.Size(174, 25);
            this.companyCLabel.TabIndex = 4;
            this.companyCLabel.Text = "Company C Cost";
            // 
            // companyBCost
            // 
            this.companyBCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyBCost.Location = new System.Drawing.Point(333, 161);
            this.companyBCost.Name = "companyBCost";
            this.companyBCost.Size = new System.Drawing.Size(100, 23);
            this.companyBCost.TabIndex = 3;
            // 
            // CompanyBLabel
            // 
            this.CompanyBLabel.AutoSize = true;
            this.CompanyBLabel.Location = new System.Drawing.Point(66, 162);
            this.CompanyBLabel.Name = "CompanyBLabel";
            this.CompanyBLabel.Size = new System.Drawing.Size(173, 25);
            this.CompanyBLabel.TabIndex = 2;
            this.CompanyBLabel.Text = "Company B Cost";
            // 
            // companyACost
            // 
            this.companyACost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyACost.Location = new System.Drawing.Point(333, 65);
            this.companyACost.Name = "companyACost";
            this.companyACost.Size = new System.Drawing.Size(100, 23);
            this.companyACost.TabIndex = 1;
            // 
            // companyALabel
            // 
            this.companyALabel.AutoSize = true;
            this.companyALabel.Location = new System.Drawing.Point(66, 65);
            this.companyALabel.Name = "companyALabel";
            this.companyALabel.Size = new System.Drawing.Size(173, 25);
            this.companyALabel.TabIndex = 0;
            this.companyALabel.Text = "Company A Cost";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(97, 577);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(189, 39);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate Cost";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // lowestCostLabel
            // 
            this.lowestCostLabel.AutoSize = true;
            this.lowestCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowestCostLabel.Location = new System.Drawing.Point(243, 333);
            this.lowestCostLabel.Name = "lowestCostLabel";
            this.lowestCostLabel.Size = new System.Drawing.Size(2, 27);
            this.lowestCostLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 955);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.deliveryInput);
            this.Controls.Add(this.distanceInput);
            this.Controls.Add(this.peopleInput);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.peopleLabel);
            this.Name = "Form1";
            this.Text = "Food Delivery Cost Calculation";
            this.resultsBox.ResumeLayout(false);
            this.resultsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label peopleLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.TextBox peopleInput;
        private System.Windows.Forms.TextBox distanceInput;
        private System.Windows.Forms.TextBox deliveryInput;
        private System.Windows.Forms.GroupBox resultsBox;
        private System.Windows.Forms.Label companyCCost;
        private System.Windows.Forms.Label companyCLabel;
        private System.Windows.Forms.Label companyBCost;
        private System.Windows.Forms.Label CompanyBLabel;
        private System.Windows.Forms.Label companyACost;
        private System.Windows.Forms.Label companyALabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label lowestCostLabel;
    }
}

