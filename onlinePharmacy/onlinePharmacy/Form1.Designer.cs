namespace onlinePharmacy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSymptoms = new System.Windows.Forms.ComboBox();
            this.lstSymptoms = new System.Windows.Forms.ListBox();
            this.submitSymptoms = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(2, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHARMACY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(58, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "at your finger tips";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select your symptoms below";
            // 
            // cmbSymptoms
            // 
            this.cmbSymptoms.FormattingEnabled = true;
            this.cmbSymptoms.Location = new System.Drawing.Point(2, 134);
            this.cmbSymptoms.Name = "cmbSymptoms";
            this.cmbSymptoms.Size = new System.Drawing.Size(197, 23);
            this.cmbSymptoms.TabIndex = 3;
            this.cmbSymptoms.SelectedIndexChanged += new System.EventHandler(this.cmbSymptoms_SelectedIndexChanged);
            // 
            // lstSymptoms
            // 
            this.lstSymptoms.FormattingEnabled = true;
            this.lstSymptoms.ItemHeight = 15;
            this.lstSymptoms.Location = new System.Drawing.Point(205, 115);
            this.lstSymptoms.Name = "lstSymptoms";
            this.lstSymptoms.Size = new System.Drawing.Size(144, 94);
            this.lstSymptoms.TabIndex = 4;
            this.lstSymptoms.SelectedIndexChanged += new System.EventHandler(this.lstSymptoms_SelectedIndexChanged);
            // 
            // submitSymptoms
            // 
            this.submitSymptoms.BackColor = System.Drawing.Color.Red;
            this.submitSymptoms.ForeColor = System.Drawing.Color.White;
            this.submitSymptoms.Location = new System.Drawing.Point(124, 179);
            this.submitSymptoms.Name = "submitSymptoms";
            this.submitSymptoms.Size = new System.Drawing.Size(75, 30);
            this.submitSymptoms.TabIndex = 5;
            this.submitSymptoms.Text = "Submit";
            this.submitSymptoms.UseVisualStyleBackColor = false;
            this.submitSymptoms.Click += new System.EventHandler(this.submitSymptoms_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(2, 235);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(161, 21);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "write your description";
            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblMedicine.ForeColor = System.Drawing.Color.White;
            this.lblMedicine.Location = new System.Drawing.Point(2, 296);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(161, 21);
            this.lblMedicine.TabIndex = 7;
            this.lblMedicine.Text = "write your description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Do you want us to recomend a Doctor for you?";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(300, 328);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(35, 23);
            this.btnYes.TabIndex = 9;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(331, 328);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(35, 23);
            this.btnNo.TabIndex = 9;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(367, 353);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMedicine);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.submitSymptoms);
            this.Controls.Add(this.lstSymptoms);
            this.Controls.Add(this.cmbSymptoms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSymptoms;
        private System.Windows.Forms.ListBox lstSymptoms;
        private System.Windows.Forms.Button submitSymptoms;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}

