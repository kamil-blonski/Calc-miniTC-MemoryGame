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
            this.components = new System.ComponentModel.Container();
            this.ComboBoxDrives = new System.Windows.Forms.ComboBox();
            this.LabelSelectHDIsk = new System.Windows.Forms.Label();
            this.ListBoxFile = new System.Windows.Forms.ListBox();
            this.LabelFIles = new System.Windows.Forms.Label();
            this.TextBoxCurrentPath = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ButtonGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxDrives
            // 
            this.ComboBoxDrives.FormattingEnabled = true;
            this.ComboBoxDrives.Location = new System.Drawing.Point(233, 13);
            this.ComboBoxDrives.Name = "ComboBoxDrives";
            this.ComboBoxDrives.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxDrives.TabIndex = 0;
            this.ComboBoxDrives.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDrives_SelectedIndexChanged);
            this.ComboBoxDrives.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBoxDrives_MouseClick);
            // 
            // LabelSelectHDIsk
            // 
            this.LabelSelectHDIsk.AutoSize = true;
            this.LabelSelectHDIsk.Location = new System.Drawing.Point(3, 16);
            this.LabelSelectHDIsk.Name = "LabelSelectHDIsk";
            this.LabelSelectHDIsk.Size = new System.Drawing.Size(119, 17);
            this.LabelSelectHDIsk.TabIndex = 1;
            this.LabelSelectHDIsk.Text = "Select hard drive:";
            // 
            // ListBoxFile
            // 
            this.ListBoxFile.FormattingEnabled = true;
            this.ListBoxFile.ItemHeight = 16;
            this.ListBoxFile.Location = new System.Drawing.Point(3, 120);
            this.ListBoxFile.Name = "ListBoxFile";
            this.ListBoxFile.Size = new System.Drawing.Size(351, 356);
            this.ListBoxFile.TabIndex = 3;
            this.ListBoxFile.SelectedIndexChanged += new System.EventHandler(this.ListBoxFile_SelectedIndexChanged);
            this.ListBoxFile.DoubleClick += new System.EventHandler(this.ListBoxFile_DoubleClick);
            // 
            // LabelFIles
            // 
            this.LabelFIles.AutoSize = true;
            this.LabelFIles.Location = new System.Drawing.Point(3, 100);
            this.LabelFIles.Name = "LabelFIles";
            this.LabelFIles.Size = new System.Drawing.Size(41, 17);
            this.LabelFIles.TabIndex = 4;
            this.LabelFIles.Text = "Files:";
            // 
            // TextBoxCurrentPath
            // 
            this.TextBoxCurrentPath.Location = new System.Drawing.Point(3, 51);
            this.TextBoxCurrentPath.Name = "TextBoxCurrentPath";
            this.TextBoxCurrentPath.Size = new System.Drawing.Size(351, 22);
            this.TextBoxCurrentPath.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ButtonGoBack
            // 
            this.ButtonGoBack.Location = new System.Drawing.Point(317, 91);
            this.ButtonGoBack.Name = "ButtonGoBack";
            this.ButtonGoBack.Size = new System.Drawing.Size(37, 26);
            this.ButtonGoBack.TabIndex = 6;
            this.ButtonGoBack.Text = "<<";
            this.ButtonGoBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonGoBack.UseVisualStyleBackColor = true;
            this.ButtonGoBack.Click += new System.EventHandler(this.ButtonGoBack_Click);
            // 
            // CWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonGoBack);
            this.Controls.Add(this.TextBoxCurrentPath);
            this.Controls.Add(this.LabelFIles);
            this.Controls.Add(this.ListBoxFile);
            this.Controls.Add(this.LabelSelectHDIsk);
            this.Controls.Add(this.ComboBoxDrives);
            this.Name = "CWindow";
            this.Size = new System.Drawing.Size(360, 499);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxDrives;
        private System.Windows.Forms.Label LabelSelectHDIsk;
        private System.Windows.Forms.ListBox ListBoxFile;
        private System.Windows.Forms.Label LabelFIles;
        private System.Windows.Forms.TextBox TextBoxCurrentPath;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button ButtonGoBack;
    }
}
