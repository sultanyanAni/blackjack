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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.emptyBox5 = new System.Windows.Forms.PictureBox();
            this.emptySpace1 = new System.Windows.Forms.PictureBox();
            this.emptyBox2 = new System.Windows.Forms.PictureBox();
            this.emptyBox4 = new System.Windows.Forms.PictureBox();
            this.emptyBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // drawButton
            // 
            this.drawButton.Enabled = false;
            this.drawButton.Location = new System.Drawing.Point(12, 316);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(157, 79);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "DRAW";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(51, 287);
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
            this.keepButton.Location = new System.Drawing.Point(12, 401);
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
            this.scoreLabel.Location = new System.Drawing.Point(1158, 724);
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
            this.dealerScoreLabel.Location = new System.Drawing.Point(1158, 2);
            this.dealerScoreLabel.Name = "dealerScoreLabel";
            this.dealerScoreLabel.Size = new System.Drawing.Size(32, 33);
            this.dealerScoreLabel.TabIndex = 6;
            this.dealerScoreLabel.Text = "0";
            this.dealerScoreLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackJack.Properties.Resources.empty_space;
            this.pictureBox1.Location = new System.Drawing.Point(927, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "-5";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BlackJack.Properties.Resources.empty_space;
            this.pictureBox2.Location = new System.Drawing.Point(140, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 233);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "-1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BlackJack.Properties.Resources.empty_space;
            this.pictureBox3.Location = new System.Drawing.Point(332, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 233);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "-2";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BlackJack.Properties.Resources.empty_space;
            this.pictureBox4.Location = new System.Drawing.Point(730, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(169, 233);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "-4";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BlackJack.Properties.Resources.empty_space;
            this.pictureBox5.Location = new System.Drawing.Point(536, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(169, 233);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "-3";
            // 
            // emptyBox5
            // 
            this.emptyBox5.Image = global::BlackJack.Properties.Resources.empty_space;
            this.emptyBox5.Location = new System.Drawing.Point(927, 483);
            this.emptyBox5.Name = "emptyBox5";
            this.emptyBox5.Size = new System.Drawing.Size(169, 233);
            this.emptyBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emptyBox5.TabIndex = 11;
            this.emptyBox5.TabStop = false;
            this.emptyBox5.Tag = "5";
            // 
            // emptySpace1
            // 
            this.emptySpace1.Image = global::BlackJack.Properties.Resources.empty_space;
            this.emptySpace1.Location = new System.Drawing.Point(140, 483);
            this.emptySpace1.Name = "emptySpace1";
            this.emptySpace1.Size = new System.Drawing.Size(169, 233);
            this.emptySpace1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emptySpace1.TabIndex = 10;
            this.emptySpace1.TabStop = false;
            this.emptySpace1.Tag = "1";
            // 
            // emptyBox2
            // 
            this.emptyBox2.Image = global::BlackJack.Properties.Resources.empty_space;
            this.emptyBox2.Location = new System.Drawing.Point(332, 483);
            this.emptyBox2.Name = "emptyBox2";
            this.emptyBox2.Size = new System.Drawing.Size(169, 233);
            this.emptyBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emptyBox2.TabIndex = 9;
            this.emptyBox2.TabStop = false;
            this.emptyBox2.Tag = "2";
            // 
            // emptyBox4
            // 
            this.emptyBox4.Image = global::BlackJack.Properties.Resources.empty_space;
            this.emptyBox4.Location = new System.Drawing.Point(730, 483);
            this.emptyBox4.Name = "emptyBox4";
            this.emptyBox4.Size = new System.Drawing.Size(169, 233);
            this.emptyBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emptyBox4.TabIndex = 8;
            this.emptyBox4.TabStop = false;
            this.emptyBox4.Tag = "4";
            // 
            // emptyBox3
            // 
            this.emptyBox3.Image = global::BlackJack.Properties.Resources.empty_space;
            this.emptyBox3.Location = new System.Drawing.Point(536, 483);
            this.emptyBox3.Name = "emptyBox3";
            this.emptyBox3.Size = new System.Drawing.Size(169, 233);
            this.emptyBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emptyBox3.TabIndex = 7;
            this.emptyBox3.TabStop = false;
            this.emptyBox3.Tag = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1202, 766);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.emptyBox5);
            this.Controls.Add(this.emptySpace1);
            this.Controls.Add(this.emptyBox2);
            this.Controls.Add(this.emptyBox4);
            this.Controls.Add(this.emptyBox3);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox emptyBox3;
        private System.Windows.Forms.PictureBox emptyBox4;
        private System.Windows.Forms.PictureBox emptyBox2;
        private System.Windows.Forms.PictureBox emptySpace1;
        private System.Windows.Forms.PictureBox emptyBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

