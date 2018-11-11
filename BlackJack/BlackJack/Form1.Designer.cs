namespace BlackJack
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
            this.drawButton = new System.Windows.Forms.Button();
            this.dealButton = new System.Windows.Forms.Button();
            this.handLabel = new System.Windows.Forms.Label();
            this.keepButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.dealerHandLabel = new System.Windows.Forms.Label();
            this.dealerScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drawButton
            // 
            this.drawButton.Enabled = false;
            this.drawButton.Location = new System.Drawing.Point(12, 158);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(157, 79);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "DRAW";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(12, 12);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(75, 23);
            this.dealButton.TabIndex = 1;
            this.dealButton.Text = "DEAL";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // handLabel
            // 
            this.handLabel.AutoSize = true;
            this.handLabel.Location = new System.Drawing.Point(276, 293);
            this.handLabel.Name = "handLabel";
            this.handLabel.Size = new System.Drawing.Size(0, 13);
            this.handLabel.TabIndex = 2;
            // 
            // keepButton
            // 
            this.keepButton.Enabled = false;
            this.keepButton.Location = new System.Drawing.Point(12, 243);
            this.keepButton.Name = "keepButton";
            this.keepButton.Size = new System.Drawing.Size(157, 23);
            this.keepButton.TabIndex = 3;
            this.keepButton.Text = "KEEP";
            this.keepButton.UseVisualStyleBackColor = true;
            this.keepButton.Click += new System.EventHandler(this.keepButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(569, 408);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(32, 33);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "0";
            // 
            // dealerHandLabel
            // 
            this.dealerHandLabel.AutoSize = true;
            this.dealerHandLabel.Location = new System.Drawing.Point(279, 87);
            this.dealerHandLabel.Name = "dealerHandLabel";
            this.dealerHandLabel.Size = new System.Drawing.Size(0, 13);
            this.dealerHandLabel.TabIndex = 5;
            // 
            // dealerScoreLabel
            // 
            this.dealerScoreLabel.AutoSize = true;
            this.dealerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerScoreLabel.Location = new System.Drawing.Point(569, 9);
            this.dealerScoreLabel.Name = "dealerScoreLabel";
            this.dealerScoreLabel.Size = new System.Drawing.Size(32, 33);
            this.dealerScoreLabel.TabIndex = 6;
            this.dealerScoreLabel.Text = "0";
            this.dealerScoreLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.dealerScoreLabel);
            this.Controls.Add(this.dealerHandLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.keepButton);
            this.Controls.Add(this.handLabel);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.drawButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Label handLabel;
        private System.Windows.Forms.Button keepButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label dealerHandLabel;
        private System.Windows.Forms.Label dealerScoreLabel;
    }
}

