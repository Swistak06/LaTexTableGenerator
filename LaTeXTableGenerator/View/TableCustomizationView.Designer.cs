namespace LaTeXTableGenerator.View
{
    partial class TableCustomizationView
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.mergeButton = new System.Windows.Forms.Button();
            this.splitCellsButton = new System.Windows.Forms.Button();
            this.leftAlignButton = new System.Windows.Forms.Button();
            this.rightAlignButton = new System.Windows.Forms.Button();
            this.centerAlignButton = new System.Windows.Forms.Button();
            this.TextAlignLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(33, 30);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 35);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateButton.Location = new System.Drawing.Point(868, 30);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(80, 35);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // mergeButton
            // 
            this.mergeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.mergeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mergeButton.Location = new System.Drawing.Point(142, 30);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(100, 35);
            this.mergeButton.TabIndex = 2;
            this.mergeButton.Text = "Merge Cells";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.MergeButton_Click);
            // 
            // splitCellsButton
            // 
            this.splitCellsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitCellsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.splitCellsButton.Location = new System.Drawing.Point(263, 30);
            this.splitCellsButton.Name = "splitCellsButton";
            this.splitCellsButton.Size = new System.Drawing.Size(100, 35);
            this.splitCellsButton.TabIndex = 3;
            this.splitCellsButton.Text = "Split Cells";
            this.splitCellsButton.UseVisualStyleBackColor = true;
            this.splitCellsButton.Click += new System.EventHandler(this.SplitCellsButton_Click);
            // 
            // leftAlignButton
            // 
            this.leftAlignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftAlignButton.Location = new System.Drawing.Point(424, 30);
            this.leftAlignButton.Name = "leftAlignButton";
            this.leftAlignButton.Size = new System.Drawing.Size(35, 35);
            this.leftAlignButton.TabIndex = 4;
            this.leftAlignButton.Text = "l";
            this.leftAlignButton.UseVisualStyleBackColor = true;
            this.leftAlignButton.Click += new System.EventHandler(this.LeftAlignButton_Click);
            // 
            // rightAlignButton
            // 
            this.rightAlignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightAlignButton.Location = new System.Drawing.Point(506, 30);
            this.rightAlignButton.Name = "rightAlignButton";
            this.rightAlignButton.Size = new System.Drawing.Size(35, 35);
            this.rightAlignButton.TabIndex = 5;
            this.rightAlignButton.Text = "r";
            this.rightAlignButton.UseVisualStyleBackColor = true;
            this.rightAlignButton.Click += new System.EventHandler(this.RightAlignButton_Click);
            // 
            // centerAlignButton
            // 
            this.centerAlignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.centerAlignButton.Location = new System.Drawing.Point(465, 30);
            this.centerAlignButton.Name = "centerAlignButton";
            this.centerAlignButton.Size = new System.Drawing.Size(35, 35);
            this.centerAlignButton.TabIndex = 6;
            this.centerAlignButton.Text = "c";
            this.centerAlignButton.UseVisualStyleBackColor = true;
            this.centerAlignButton.Click += new System.EventHandler(this.CenterAlignButton_Click);
            // 
            // TextAlignLabel
            // 
            this.TextAlignLabel.AutoSize = true;
            this.TextAlignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextAlignLabel.Location = new System.Drawing.Point(440, 11);
            this.TextAlignLabel.Name = "TextAlignLabel";
            this.TextAlignLabel.Size = new System.Drawing.Size(77, 16);
            this.TextAlignLabel.TabIndex = 7;
            this.TextAlignLabel.Text = "Text Align";
            // 
            // TableCustomizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.TextAlignLabel);
            this.Controls.Add(this.centerAlignButton);
            this.Controls.Add(this.rightAlignButton);
            this.Controls.Add(this.leftAlignButton);
            this.Controls.Add(this.splitCellsButton);
            this.Controls.Add(this.mergeButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.cancelButton);
            this.MaximizeBox = false;
            this.Name = "TableCustomizationView";
            this.Text = "LaTeX Table Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TableCustomizationView_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Button splitCellsButton;
        private System.Windows.Forms.Button leftAlignButton;
        private System.Windows.Forms.Button rightAlignButton;
        private System.Windows.Forms.Button centerAlignButton;
        private System.Windows.Forms.Label TextAlignLabel;
    }
}