namespace LaTeXTableGenerator.View
{
    partial class MainView
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.ColumnNumberInput = new System.Windows.Forms.NumericUpDown();
            this.RowNumberInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnNumberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowNumberInput)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.CreateTableButton.Location = new System.Drawing.Point(160, 203);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(160, 40);
            this.CreateTableButton.TabIndex = 0;
            this.CreateTableButton.Text = "Create Table";
            this.CreateTableButton.UseVisualStyleBackColor = true;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // ColumnNumberInput
            // 
            this.ColumnNumberInput.Location = new System.Drawing.Point(227, 49);
            this.ColumnNumberInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ColumnNumberInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ColumnNumberInput.Name = "ColumnNumberInput";
            this.ColumnNumberInput.Size = new System.Drawing.Size(120, 20);
            this.ColumnNumberInput.TabIndex = 1;
            this.ColumnNumberInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RowNumberInput
            // 
            this.RowNumberInput.Location = new System.Drawing.Point(227, 116);
            this.RowNumberInput.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.RowNumberInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RowNumberInput.Name = "RowNumberInput";
            this.RowNumberInput.Size = new System.Drawing.Size(120, 20);
            this.RowNumberInput.TabIndex = 2;
            this.RowNumberInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of columns:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of rows:";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.exitButton.Location = new System.Drawing.Point(160, 290);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 40);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Range 1 - 10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Range 1 - 15";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RowNumberInput);
            this.Controls.Add(this.ColumnNumberInput);
            this.Controls.Add(this.CreateTableButton);
            this.Name = "MainView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ColumnNumberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowNumberInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateTableButton;
        private System.Windows.Forms.NumericUpDown ColumnNumberInput;
        private System.Windows.Forms.NumericUpDown RowNumberInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

