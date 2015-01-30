namespace StickHeroBot
{
    partial class MainForm
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
            this.findWindowButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findWindowButton
            // 
            this.findWindowButton.Location = new System.Drawing.Point(13, 13);
            this.findWindowButton.Name = "findWindowButton";
            this.findWindowButton.Size = new System.Drawing.Size(111, 23);
            this.findWindowButton.TabIndex = 0;
            this.findWindowButton.Text = "Find Window";
            this.findWindowButton.UseVisualStyleBackColor = true;
            this.findWindowButton.Click += new System.EventHandler(this.findWindowButton_Click);
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(131, 13);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(75, 23);
            this.captureButton.TabIndex = 1;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.findWindowButton);
            this.Name = "MainForm";
            this.Text = "StickHeroBot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button findWindowButton;
        private System.Windows.Forms.Button captureButton;
    }
}

