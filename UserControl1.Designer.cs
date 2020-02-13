namespace Assignment1GUI
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.citizenBox = new System.Windows.Forms.CheckBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.residentLabel = new System.Windows.Forms.Label();
            this.termsLabel = new System.Windows.Forms.Label();
            this.rebelledBox = new System.Windows.Forms.CheckBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.residentTextBox = new System.Windows.Forms.TextBox();
            this.termsTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // citizenBox
            // 
            this.citizenBox.AutoSize = true;
            this.citizenBox.Location = new System.Drawing.Point(224, 69);
            this.citizenBox.Name = "citizenBox";
            this.citizenBox.Size = new System.Drawing.Size(119, 17);
            this.citizenBox.TabIndex = 0;
            this.citizenBox.Text = "Natural Born Citizen";
            this.citizenBox.UseVisualStyleBackColor = true;
           
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(221, 121);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(118, 13);
            this.ageLabel.TabIndex = 1;
            this.ageLabel.Text = "What is your birth year?";
            // 
            // residentLabel
            // 
            this.residentLabel.AutoSize = true;
            this.residentLabel.Location = new System.Drawing.Point(221, 176);
            this.residentLabel.Name = "residentLabel";
            this.residentLabel.Size = new System.Drawing.Size(222, 13);
            this.residentLabel.TabIndex = 2;
            this.residentLabel.Text = "How many years have you resided in the US?";
            // 
            // termsLabel
            // 
            this.termsLabel.AutoSize = true;
            this.termsLabel.Location = new System.Drawing.Point(221, 223);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(196, 13);
            this.termsLabel.TabIndex = 3;
            this.termsLabel.Text = "How many prior terms have you served?";
            // 
            // rebelledBox
            // 
            this.rebelledBox.AutoSize = true;
            this.rebelledBox.Location = new System.Drawing.Point(224, 280);
            this.rebelledBox.Name = "rebelledBox";
            this.rebelledBox.Size = new System.Drawing.Size(169, 17);
            this.rebelledBox.TabIndex = 4;
            this.rebelledBox.Text = "I have rebelled against the US";
            this.rebelledBox.UseVisualStyleBackColor = true;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(500, 114);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(71, 20);
            this.ageTextBox.TabIndex = 5;

            // 
            // residentTextBox
            // 
            this.residentTextBox.Location = new System.Drawing.Point(500, 169);
            this.residentTextBox.Name = "residentTextBox";
            this.residentTextBox.Size = new System.Drawing.Size(71, 20);
            this.residentTextBox.TabIndex = 6;
            // 
            // termsTextBox
            // 
            this.termsTextBox.Location = new System.Drawing.Point(500, 216);
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.Size = new System.Drawing.Size(71, 20);
            this.termsTextBox.TabIndex = 7;
           
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(344, 340);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 43);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Determine Eligibility";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.termsTextBox);
            this.Controls.Add(this.residentTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.rebelledBox);
            this.Controls.Add(this.termsLabel);
            this.Controls.Add(this.residentLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.citizenBox);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox citizenBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label residentLabel;
        private System.Windows.Forms.Label termsLabel;
        private System.Windows.Forms.CheckBox rebelledBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox residentTextBox;
        private System.Windows.Forms.TextBox termsTextBox;
        private System.Windows.Forms.Button submitButton;
    }
}
