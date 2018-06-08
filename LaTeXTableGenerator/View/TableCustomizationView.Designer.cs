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
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
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
            this.splitCellsButton.Click += new System.EventHandler(this.splitCellsButton_Click);
            // 
            // TableCustomizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.splitCellsButton);
            this.Controls.Add(this.mergeButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "TableCustomizationView";
            this.Text = "TableCustomizationView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TableCustomizationView_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Button splitCellsButton;
    }
}