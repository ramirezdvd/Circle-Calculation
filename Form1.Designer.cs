namespace MathLibCircleInfo_DavidRamires
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
            this.txt_RadiusOfACircle = new System.Windows.Forms.TextBox();
            this.EROCLabel = new System.Windows.Forms.Label();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.DLabel = new System.Windows.Forms.Label();
            this.Label_Diameter = new System.Windows.Forms.Label();
            this.CLabel = new System.Windows.Forms.Label();
            this.Label_Circumference = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Area = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_RadiusOfACircle
            // 
            this.txt_RadiusOfACircle.Location = new System.Drawing.Point(11, 48);
            this.txt_RadiusOfACircle.Name = "txt_RadiusOfACircle";
            this.txt_RadiusOfACircle.Size = new System.Drawing.Size(100, 20);
            this.txt_RadiusOfACircle.TabIndex = 0;
            // 
            // EROCLabel
            // 
            this.EROCLabel.Location = new System.Drawing.Point(8, 12);
            this.EROCLabel.Name = "EROCLabel";
            this.EROCLabel.Size = new System.Drawing.Size(100, 33);
            this.EROCLabel.TabIndex = 1;
            this.EROCLabel.Text = "Please enter the radius of the circle:";
            this.EROCLabel.Click += new System.EventHandler(this.EROCLabel_Click);
            // 
            // button_Calculate
            // 
            this.button_Calculate.Location = new System.Drawing.Point(144, 45);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(75, 23);
            this.button_Calculate.TabIndex = 2;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // DLabel
            // 
            this.DLabel.Location = new System.Drawing.Point(67, 92);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(50, 16);
            this.DLabel.TabIndex = 3;
            this.DLabel.Text = "Diameter";
            // 
            // Label_Diameter
            // 
            this.Label_Diameter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Label_Diameter.Location = new System.Drawing.Point(119, 85);
            this.Label_Diameter.Name = "Label_Diameter";
            this.Label_Diameter.Size = new System.Drawing.Size(100, 23);
            this.Label_Diameter.TabIndex = 4;
            this.Label_Diameter.Click += new System.EventHandler(this.Label_Diameter_Click);
            // 
            // CLabel
            // 
            this.CLabel.Location = new System.Drawing.Point(42, 129);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(80, 16);
            this.CLabel.TabIndex = 3;
            this.CLabel.Text = "Circumference";
            // 
            // Label_Circumference
            // 
            this.Label_Circumference.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Label_Circumference.Location = new System.Drawing.Point(119, 122);
            this.Label_Circumference.Name = "Label_Circumference";
            this.Label_Circumference.Size = new System.Drawing.Size(100, 23);
            this.Label_Circumference.TabIndex = 4;
            this.Label_Circumference.Click += new System.EventHandler(this.Label_Circumference_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(85, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Area";
            // 
            // Label_Area
            // 
            this.Label_Area.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Label_Area.Location = new System.Drawing.Point(119, 159);
            this.Label_Area.Name = "Label_Area";
            this.Label_Area.Size = new System.Drawing.Size(100, 23);
            this.Label_Area.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 193);
            this.Controls.Add(this.Label_Area);
            this.Controls.Add(this.Label_Circumference);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Diameter);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.DLabel);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.EROCLabel);
            this.Controls.Add(this.txt_RadiusOfACircle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_RadiusOfACircle;
        private System.Windows.Forms.Label EROCLabel;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.Label DLabel;
        private System.Windows.Forms.Label Label_Diameter;
        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.Label Label_Circumference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Area;
    }
}

