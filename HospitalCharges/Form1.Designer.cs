namespace HospitalCharges
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
            this.box_days = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_med = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_surg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.box_lab = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.box_rehab = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.form_amount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box_days
            // 
            this.box_days.Location = new System.Drawing.Point(719, 169);
            this.box_days.Name = "box_days";
            this.box_days.Size = new System.Drawing.Size(225, 43);
            this.box_days.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Hospital Days";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Medication Charges";
            // 
            // box_med
            // 
            this.box_med.Location = new System.Drawing.Point(719, 252);
            this.box_med.Name = "box_med";
            this.box_med.Size = new System.Drawing.Size(225, 43);
            this.box_med.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surgical Charges";
            // 
            // box_surg
            // 
            this.box_surg.Location = new System.Drawing.Point(719, 344);
            this.box_surg.Name = "box_surg";
            this.box_surg.Size = new System.Drawing.Size(225, 43);
            this.box_surg.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lab Fees";
            this.label4.UseWaitCursor = true;
            // 
            // box_lab
            // 
            this.box_lab.Location = new System.Drawing.Point(719, 436);
            this.box_lab.Name = "box_lab";
            this.box_lab.Size = new System.Drawing.Size(225, 43);
            this.box_lab.TabIndex = 6;
            this.box_lab.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rehab Charges";
            this.label5.UseWaitCursor = true;
            // 
            // box_rehab
            // 
            this.box_rehab.Location = new System.Drawing.Point(719, 527);
            this.box_rehab.Name = "box_rehab";
            this.box_rehab.Size = new System.Drawing.Size(225, 43);
            this.box_rehab.TabIndex = 8;
            this.box_rehab.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1155, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Bill";
            this.label6.UseWaitCursor = true;
            // 
            // form_amount
            // 
            this.form_amount.AutoSize = true;
            this.form_amount.Location = new System.Drawing.Point(1155, 308);
            this.form_amount.Name = "form_amount";
            this.form_amount.Size = new System.Drawing.Size(112, 37);
            this.form_amount.TabIndex = 11;
            this.form_amount.Text = "Amount";
            this.form_amount.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 52);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calculate Bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 743);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.form_amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_rehab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_lab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_surg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_med);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_days);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox box_days;
        private Label label1;
        private Label label2;
        private TextBox box_med;
        private Label label3;
        private TextBox box_surg;
        private Label label4;
        private TextBox box_lab;
        private Label label5;
        private TextBox box_rehab;
        private Label label6;
        private Label form_amount;
        private Button button1;
    }
}