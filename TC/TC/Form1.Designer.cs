namespace TC
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
            this.ButtonCopyToRight = new System.Windows.Forms.Button();
            this.ControlRightPanel = new TC.CWindow();
            this.ControlLeftPanel = new TC.CWindow();
            this.ButtonCopyToLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCopyToRight
            // 
            this.ButtonCopyToRight.Location = new System.Drawing.Point(215, 550);
            this.ButtonCopyToRight.Name = "ButtonCopyToRight";
            this.ButtonCopyToRight.Size = new System.Drawing.Size(156, 34);
            this.ButtonCopyToRight.TabIndex = 2;
            this.ButtonCopyToRight.Text = "Copy >>";
            this.ButtonCopyToRight.UseVisualStyleBackColor = true;
            this.ButtonCopyToRight.Click += new System.EventHandler(this.ButtonCopyToRight_Click);
            // 
            // ControlRightPanel
            // 
            this.ControlRightPanel.CurrentPath = "";
            this.ControlRightPanel.Location = new System.Drawing.Point(415, 12);
            this.ControlRightPanel.Name = "ControlRightPanel";
            this.ControlRightPanel.SelectedItem = null;
            this.ControlRightPanel.Size = new System.Drawing.Size(366, 519);
            this.ControlRightPanel.TabIndex = 1;
            // 
            // ControlLeftPanel
            // 
            this.ControlLeftPanel.CurrentPath = "";
            this.ControlLeftPanel.Location = new System.Drawing.Point(21, 12);
            this.ControlLeftPanel.Name = "ControlLeftPanel";
            this.ControlLeftPanel.SelectedItem = null;
            this.ControlLeftPanel.Size = new System.Drawing.Size(361, 519);
            this.ControlLeftPanel.TabIndex = 0;
            // 
            // ButtonCopyToLeft
            // 
            this.ButtonCopyToLeft.Location = new System.Drawing.Point(415, 550);
            this.ButtonCopyToLeft.Name = "ButtonCopyToLeft";
            this.ButtonCopyToLeft.Size = new System.Drawing.Size(156, 34);
            this.ButtonCopyToLeft.TabIndex = 3;
            this.ButtonCopyToLeft.Text = "<< Copy";
            this.ButtonCopyToLeft.UseVisualStyleBackColor = true;
            this.ButtonCopyToLeft.Click += new System.EventHandler(this.ButtonCopyToLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 596);
            this.Controls.Add(this.ButtonCopyToLeft);
            this.Controls.Add(this.ButtonCopyToRight);
            this.Controls.Add(this.ControlRightPanel);
            this.Controls.Add(this.ControlLeftPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TC Kamil Błoński";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CWindow ControlLeftPanel;
        private CWindow ControlRightPanel;
        private System.Windows.Forms.Button ButtonCopyToRight;
        private System.Windows.Forms.Button ButtonCopyToLeft;
    }
}