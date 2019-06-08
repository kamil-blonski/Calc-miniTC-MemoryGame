namespace Memory
{
    partial class Memory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.LabelWrongChoiceX = new System.Windows.Forms.Label();
            this.LabelCorrectChoiceX = new System.Windows.Forms.Label();
            this.LabelWrongChoice = new System.Windows.Forms.Label();
            this.LabelCorrectChoice = new System.Windows.Forms.Label();
            this.board1 = new Board();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.board1);
            this.groupBox1.Location = new System.Drawing.Point(10, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 800);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(22, 12);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(198, 123);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // LabelWrongChoiceX
            // 
            this.LabelWrongChoiceX.AutoSize = true;
            this.LabelWrongChoiceX.Location = new System.Drawing.Point(281, 118);
            this.LabelWrongChoiceX.Name = "LabelWrongChoiceX";
            this.LabelWrongChoiceX.Size = new System.Drawing.Size(143, 17);
            this.LabelWrongChoiceX.TabIndex = 2;
            this.LabelWrongChoiceX.Text = "Błędne dopasowania:";
            // 
            // LabelCorrectChoiceX
            // 
            this.LabelCorrectChoiceX.AutoSize = true;
            this.LabelCorrectChoiceX.Location = new System.Drawing.Point(499, 118);
            this.LabelCorrectChoiceX.Name = "LabelCorrectChoiceX";
            this.LabelCorrectChoiceX.Size = new System.Drawing.Size(158, 17);
            this.LabelCorrectChoiceX.TabIndex = 3;
            this.LabelCorrectChoiceX.Text = "Poprawne dopasowania";
            // 
            // LabelWrongChoice
            // 
            this.LabelWrongChoice.AutoSize = true;
            this.LabelWrongChoice.Location = new System.Drawing.Point(430, 118);
            this.LabelWrongChoice.Name = "LabelWrongChoice";
            this.LabelWrongChoice.Size = new System.Drawing.Size(0, 17);
            this.LabelWrongChoice.TabIndex = 4;
            // 
            // LabelCorrectChoice
            // 
            this.LabelCorrectChoice.AutoSize = true;
            this.LabelCorrectChoice.Location = new System.Drawing.Point(663, 118);
            this.LabelCorrectChoice.Name = "LabelCorrectChoice";
            this.LabelCorrectChoice.Size = new System.Drawing.Size(0, 17);
            this.LabelCorrectChoice.TabIndex = 5;
            // 
            // board1
            // 
            this.board1.AccessibleName = "boardControl";
            this.board1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.board1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.board1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.board1.Location = new System.Drawing.Point(111, 21);
            this.board1.Name = "board1";
            this.board1.Size = new System.Drawing.Size(720, 650);
            this.board1.TabIndex = 0;
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.LabelCorrectChoice);
            this.Controls.Add(this.LabelWrongChoice);
            this.Controls.Add(this.LabelCorrectChoiceX);
            this.Controls.Add(this.LabelWrongChoiceX);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.groupBox1);
            this.Name = "Memory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gra w pamięć";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label LabelWrongChoiceX;
        private System.Windows.Forms.Label LabelCorrectChoiceX;
        private System.Windows.Forms.Label LabelWrongChoice;
        private System.Windows.Forms.Label LabelCorrectChoice;
        private Board board1;
    }
}

