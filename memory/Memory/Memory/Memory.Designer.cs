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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.board1 = new Board();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.LabelWrongChoiceX = new System.Windows.Forms.Label();
            this.LabelCorrectChoiceX = new System.Windows.Forms.Label();
            this.LabelWrongChoice = new System.Windows.Forms.Label();
            this.LabelCorrectChoice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.board1);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 776);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // board1
            // 
            this.board1.AccessibleName = "boardControl";
            this.board1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.board1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.board1.CorrectChoices = 0;
            this.board1.FirstClick = null;
            this.board1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.board1.Location = new System.Drawing.Point(6, 9);
            this.board1.Name = "board1";
            this.board1.SecondClick = null;
            this.board1.Size = new System.Drawing.Size(948, 761);
            this.board1.TabIndex = 0;
            this.board1.WrongChoices = 0;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(18, 38);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(198, 38);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // LabelWrongChoiceX
            // 
            this.LabelWrongChoiceX.AutoSize = true;
            this.LabelWrongChoiceX.Location = new System.Drawing.Point(405, 9);
            this.LabelWrongChoiceX.Name = "LabelWrongChoiceX";
            this.LabelWrongChoiceX.Size = new System.Drawing.Size(143, 17);
            this.LabelWrongChoiceX.TabIndex = 2;
            this.LabelWrongChoiceX.Text = "Błędne dopasowania:";
            // 
            // LabelCorrectChoiceX
            // 
            this.LabelCorrectChoiceX.AutoSize = true;
            this.LabelCorrectChoiceX.Location = new System.Drawing.Point(591, 9);
            this.LabelCorrectChoiceX.Name = "LabelCorrectChoiceX";
            this.LabelCorrectChoiceX.Size = new System.Drawing.Size(158, 17);
            this.LabelCorrectChoiceX.TabIndex = 3;
            this.LabelCorrectChoiceX.Text = "Poprawne dopasowania";
            // 
            // LabelWrongChoice
            // 
            this.LabelWrongChoice.AutoSize = true;
            this.LabelWrongChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelWrongChoice.ForeColor = System.Drawing.Color.Red;
            this.LabelWrongChoice.Location = new System.Drawing.Point(455, 28);
            this.LabelWrongChoice.Name = "LabelWrongChoice";
            this.LabelWrongChoice.Size = new System.Drawing.Size(37, 39);
            this.LabelWrongChoice.TabIndex = 4;
            this.LabelWrongChoice.Text = "0";
            // 
            // LabelCorrectChoice
            // 
            this.LabelCorrectChoice.AutoSize = true;
            this.LabelCorrectChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCorrectChoice.ForeColor = System.Drawing.Color.Green;
            this.LabelCorrectChoice.Location = new System.Drawing.Point(648, 28);
            this.LabelCorrectChoice.Name = "LabelCorrectChoice";
            this.LabelCorrectChoice.Size = new System.Drawing.Size(37, 39);
            this.LabelCorrectChoice.TabIndex = 5;
            this.LabelCorrectChoice.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kliknij Start, aby rozpocząć.";
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(222, 38);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(193, 38);
            this.ButtonReset.TabIndex = 8;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 861);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonReset;
    }
}

