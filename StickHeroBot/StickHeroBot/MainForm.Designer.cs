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
            this.analyzeButton = new System.Windows.Forms.Button();
            this.doItButton = new System.Windows.Forms.Button();
            this.allInOneButton = new System.Windows.Forms.Button();
            this.repeatCheckBox = new System.Windows.Forms.CheckBox();
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
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(213, 13);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(75, 23);
            this.analyzeButton.TabIndex = 2;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // doItButton
            // 
            this.doItButton.Location = new System.Drawing.Point(295, 13);
            this.doItButton.Name = "doItButton";
            this.doItButton.Size = new System.Drawing.Size(75, 23);
            this.doItButton.TabIndex = 3;
            this.doItButton.Text = "Do It";
            this.doItButton.UseVisualStyleBackColor = true;
            this.doItButton.Click += new System.EventHandler(this.doItButton_Click);
            // 
            // allInOneButton
            // 
            this.allInOneButton.Location = new System.Drawing.Point(377, 13);
            this.allInOneButton.Name = "allInOneButton";
            this.allInOneButton.Size = new System.Drawing.Size(75, 23);
            this.allInOneButton.TabIndex = 4;
            this.allInOneButton.Text = "All in One";
            this.allInOneButton.UseVisualStyleBackColor = true;
            this.allInOneButton.Click += new System.EventHandler(this.allInOneButton_Click);
            // 
            // repeatCheckBox
            // 
            this.repeatCheckBox.AutoSize = true;
            this.repeatCheckBox.Location = new System.Drawing.Point(458, 17);
            this.repeatCheckBox.Name = "repeatCheckBox";
            this.repeatCheckBox.Size = new System.Drawing.Size(61, 17);
            this.repeatCheckBox.TabIndex = 5;
            this.repeatCheckBox.Text = "Repeat";
            this.repeatCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 46);
            this.Controls.Add(this.repeatCheckBox);
            this.Controls.Add(this.allInOneButton);
            this.Controls.Add(this.doItButton);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.findWindowButton);
            this.Name = "MainForm";
            this.Text = "StickHeroBot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findWindowButton;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Button doItButton;
        private System.Windows.Forms.Button allInOneButton;
        private System.Windows.Forms.CheckBox repeatCheckBox;
    }
}

