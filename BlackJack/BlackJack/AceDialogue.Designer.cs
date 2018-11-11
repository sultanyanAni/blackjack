namespace BlackJack
{
    partial class AceDialogue
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
            this.OneButton = new System.Windows.Forms.Button();
            this.ElevenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OneButton
            // 
            this.OneButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OneButton.Location = new System.Drawing.Point(12, 55);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(75, 23);
            this.OneButton.TabIndex = 0;
            this.OneButton.Text = "One";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // ElevenButton
            // 
            this.ElevenButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ElevenButton.Location = new System.Drawing.Point(148, 55);
            this.ElevenButton.Name = "ElevenButton";
            this.ElevenButton.Size = new System.Drawing.Size(75, 23);
            this.ElevenButton.TabIndex = 1;
            this.ElevenButton.Text = "Eleven";
            this.ElevenButton.UseVisualStyleBackColor = true;
            this.ElevenButton.Click += new System.EventHandler(this.ElevenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "You drew an Ace. \r\nWhat do you want to treat it as?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(48, 35);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(113, 13);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Your current score is:  ";
            // 
            // AceDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 94);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ElevenButton);
            this.Controls.Add(this.OneButton);
            this.Name = "AceDialogue";
            this.Text = "AceDialogue";
            this.Load += new System.EventHandler(this.AceDialogue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button ElevenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
    }
}