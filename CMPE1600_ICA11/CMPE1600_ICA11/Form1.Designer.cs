namespace CMPE1600_ICA11
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
            this.UI_GenerateButton = new System.Windows.Forms.Button();
            this.UI_SortButton = new System.Windows.Forms.Button();
            this.UI_ClearButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.UI_StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_GenerateButton
            // 
            this.UI_GenerateButton.Location = new System.Drawing.Point(8, 31);
            this.UI_GenerateButton.Name = "UI_GenerateButton";
            this.UI_GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.UI_GenerateButton.TabIndex = 0;
            this.UI_GenerateButton.Text = "Generate";
            this.UI_GenerateButton.UseVisualStyleBackColor = true;
            this.UI_GenerateButton.Click += new System.EventHandler(this.UI_GenerateButton_Click);
            // 
            // UI_SortButton
            // 
            this.UI_SortButton.Location = new System.Drawing.Point(8, 60);
            this.UI_SortButton.Name = "UI_SortButton";
            this.UI_SortButton.Size = new System.Drawing.Size(75, 23);
            this.UI_SortButton.TabIndex = 1;
            this.UI_SortButton.Text = "Sort";
            this.UI_SortButton.UseVisualStyleBackColor = true;
            this.UI_SortButton.Click += new System.EventHandler(this.UI_SortButton_Click);
            // 
            // UI_ClearButton
            // 
            this.UI_ClearButton.Location = new System.Drawing.Point(8, 89);
            this.UI_ClearButton.Name = "UI_ClearButton";
            this.UI_ClearButton.Size = new System.Drawing.Size(75, 23);
            this.UI_ClearButton.TabIndex = 2;
            this.UI_ClearButton.Text = "Clear";
            this.UI_ClearButton.UseVisualStyleBackColor = true;
            this.UI_ClearButton.Click += new System.EventHandler(this.UI_ClearButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 177);
            this.progressBar1.Maximum = 50000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(138, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(134, 134);
            this.listBox1.TabIndex = 4;
            // 
            // UI_StatusLabel
            // 
            this.UI_StatusLabel.AutoSize = true;
            this.UI_StatusLabel.Location = new System.Drawing.Point(12, 223);
            this.UI_StatusLabel.Name = "UI_StatusLabel";
            this.UI_StatusLabel.Size = new System.Drawing.Size(75, 13);
            this.UI_StatusLabel.TabIndex = 5;
            this.UI_StatusLabel.Text = "Ready to Start";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.UI_StatusLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.UI_ClearButton);
            this.Controls.Add(this.UI_SortButton);
            this.Controls.Add(this.UI_GenerateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_GenerateButton;
        private System.Windows.Forms.Button UI_SortButton;
        private System.Windows.Forms.Button UI_ClearButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label UI_StatusLabel;
    }
}

