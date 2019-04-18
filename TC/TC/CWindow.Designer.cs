namespace TC
{
    partial class CWindow
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
            this.ComboBoxDrives = new System.Windows.Forms.ComboBox();
            this.LabelSelectHDIsk = new System.Windows.Forms.Label();
            this.ButtonCopy = new System.Windows.Forms.Button();
            this.ListBoxFile = new System.Windows.Forms.ListBox();
            this.LabelFIles = new System.Windows.Forms.Label();
            this.TextBoxCurrentPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComboBoxDrives
            // 
            this.ComboBoxDrives.FormattingEnabled = true;
            this.ComboBoxDrives.Location = new System.Drawing.Point(160, 9);
            this.ComboBoxDrives.Name = "ComboBoxDrives";
            this.ComboBoxDrives.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxDrives.TabIndex = 0;
            this.ComboBoxDrives.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDrives_SelectedIndexChanged);
            this.ComboBoxDrives.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBoxDrives_MouseClick);
            this.ComboBoxDrives.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ComboBoxDrives_MouseDown);
            // 
            // LabelSelectHDIsk
            // 
            this.LabelSelectHDIsk.AutoSize = true;
            this.LabelSelectHDIsk.Location = new System.Drawing.Point(3, 9);
            this.LabelSelectHDIsk.Name = "LabelSelectHDIsk";
            this.LabelSelectHDIsk.Size = new System.Drawing.Size(119, 17);
            this.LabelSelectHDIsk.TabIndex = 1;
            this.LabelSelectHDIsk.Text = "Select hard drive:";
            // 
            // ButtonCopy
            // 
            this.ButtonCopy.Location = new System.Drawing.Point(85, 333);
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.Size = new System.Drawing.Size(105, 24);
            this.ButtonCopy.TabIndex = 2;
            this.ButtonCopy.Text = "Copy";
            this.ButtonCopy.UseVisualStyleBackColor = true;
            // 
            // ListBoxFile
            // 
            this.ListBoxFile.FormattingEnabled = true;
            this.ListBoxFile.ItemHeight = 16;
            this.ListBoxFile.Location = new System.Drawing.Point(6, 84);
            this.ListBoxFile.Name = "ListBoxFile";
            this.ListBoxFile.Size = new System.Drawing.Size(275, 244);
            this.ListBoxFile.TabIndex = 3;
            // 
            // LabelFIles
            // 
            this.LabelFIles.AutoSize = true;
            this.LabelFIles.Location = new System.Drawing.Point(3, 64);
            this.LabelFIles.Name = "LabelFIles";
            this.LabelFIles.Size = new System.Drawing.Size(41, 17);
            this.LabelFIles.TabIndex = 4;
            this.LabelFIles.Text = "Files:";
            // 
            // TextBoxCurrentPath
            // 
            this.TextBoxCurrentPath.Location = new System.Drawing.Point(6, 39);
            this.TextBoxCurrentPath.Name = "TextBoxCurrentPath";
            this.TextBoxCurrentPath.Size = new System.Drawing.Size(275, 22);
            this.TextBoxCurrentPath.TabIndex = 5;
            // 
            // CWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxCurrentPath);
            this.Controls.Add(this.LabelFIles);
            this.Controls.Add(this.ListBoxFile);
            this.Controls.Add(this.ButtonCopy);
            this.Controls.Add(this.LabelSelectHDIsk);
            this.Controls.Add(this.ComboBoxDrives);
            this.Name = "CWindow";
            this.Size = new System.Drawing.Size(284, 383);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxDrives;
        private System.Windows.Forms.Label LabelSelectHDIsk;
        private System.Windows.Forms.Button ButtonCopy;
        private System.Windows.Forms.ListBox ListBoxFile;
        private System.Windows.Forms.Label LabelFIles;
        private System.Windows.Forms.TextBox TextBoxCurrentPath;
    }
}
