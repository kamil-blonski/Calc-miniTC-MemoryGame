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
            this.ControlLeftPanel = new TC.CWindow();
            this.ControlRightPanel = new TC.CWindow();
            this.SuspendLayout();
            // 
            // ControlLeftPanel
            // 
            this.ControlLeftPanel.CurrentPath = "";
            this.ControlLeftPanel.Location = new System.Drawing.Point(21, 12);
            this.ControlLeftPanel.Name = "ControlLeftPanel";
            this.ControlLeftPanel.Size = new System.Drawing.Size(361, 510);
            this.ControlLeftPanel.TabIndex = 0;
            // 
            // ControlRightPanel
            // 
            this.ControlRightPanel.CurrentPath = "";
            this.ControlRightPanel.Location = new System.Drawing.Point(415, 12);
            this.ControlRightPanel.Name = "ControlRightPanel";
            this.ControlRightPanel.Size = new System.Drawing.Size(380, 510);
            this.ControlRightPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 534);
            this.Controls.Add(this.ControlRightPanel);
            this.Controls.Add(this.ControlLeftPanel);
            this.Name = "Form1";
            this.Text = "TC Kamil Błoński";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CWindow ControlLeftPanel;
        private CWindow ControlRightPanel;
    }
}