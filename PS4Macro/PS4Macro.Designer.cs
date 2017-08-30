﻿namespace PS4Macro
{
    partial class PS4Macro
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
            this.playButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.recordButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(13, 13);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(26, 23);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "▶";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(45, 13);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(26, 23);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "⏸";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(77, 13);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(26, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "⏹";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(109, 13);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(26, 23);
            this.recordButton.TabIndex = 3;
            this.recordButton.Text = "⏺";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(197, 13);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // PS4Macro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 47);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.playButton);
            this.Name = "PS4Macro";
            this.Text = "PS4 Macro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button clearButton;
    }
}
