namespace CardValidationTool
{
    partial class LuhmForm
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
            this.textEntryBox = new System.Windows.Forms.TextBox();
            this.textEntryLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.correctedNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textEntryBox
            // 
            this.textEntryBox.Location = new System.Drawing.Point(44, 215);
            this.textEntryBox.Name = "textEntryBox";
            this.textEntryBox.Size = new System.Drawing.Size(191, 22);
            this.textEntryBox.TabIndex = 0;
            this.textEntryBox.TextChanged += new System.EventHandler(this.textEntryBox_TextChanged);
            // 
            // textEntryLabel
            // 
            this.textEntryLabel.AutoSize = true;
            this.textEntryLabel.Location = new System.Drawing.Point(41, 195);
            this.textEntryLabel.Name = "textEntryLabel";
            this.textEntryLabel.Size = new System.Drawing.Size(170, 17);
            this.textEntryLabel.TabIndex = 1;
            this.textEntryLabel.Text = "Enter card number below.";
            // 
            // titleLabel
            // 
            this.titleLabel.AllowDrop = true;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.titleLabel.Location = new System.Drawing.Point(40, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(128, 24);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Card Validator";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::CardValidationTool.Properties.Resources.success;
            this.pictureBox.Location = new System.Drawing.Point(44, 63);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(110, 111);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // correctedNumber
            // 
            this.correctedNumber.AutoSize = true;
            this.correctedNumber.Location = new System.Drawing.Point(252, 215);
            this.correctedNumber.Name = "correctedNumber";
            this.correctedNumber.Size = new System.Drawing.Size(0, 17);
            this.correctedNumber.TabIndex = 4;
            // 
            // LuhmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 255);
            this.Controls.Add(this.correctedNumber);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.textEntryLabel);
            this.Controls.Add(this.textEntryBox);
            this.Name = "LuhmForm";
            this.Text = "Card Validator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEntryBox;
        private System.Windows.Forms.Label textEntryLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label correctedNumber;
    }
}

