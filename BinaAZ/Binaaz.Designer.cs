﻿namespace TapazParser.BinaAZ
{
    partial class Binaaz
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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.RichTextBox();
            this.lblNeedToParse = new System.Windows.Forms.Label();
            this.btnSaveNumbers = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.txtAddCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(50, 274);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 47);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(190, 134);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(483, 187);
            this.txtAuthor.TabIndex = 16;
            this.txtAuthor.Text = "";
            // 
            // lblNeedToParse
            // 
            this.lblNeedToParse.AutoSize = true;
            this.lblNeedToParse.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNeedToParse.Location = new System.Drawing.Point(420, 91);
            this.lblNeedToParse.Name = "lblNeedToParse";
            this.lblNeedToParse.Size = new System.Drawing.Size(32, 40);
            this.lblNeedToParse.TabIndex = 15;
            this.lblNeedToParse.Text = "0";
            // 
            // btnSaveNumbers
            // 
            this.btnSaveNumbers.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveNumbers.Location = new System.Drawing.Point(50, 208);
            this.btnSaveNumbers.Name = "btnSaveNumbers";
            this.btnSaveNumbers.Size = new System.Drawing.Size(105, 47);
            this.btnSaveNumbers.TabIndex = 14;
            this.btnSaveNumbers.Text = "Save Numbers";
            this.btnSaveNumbers.UseVisualStyleBackColor = true;
            this.btnSaveNumbers.Click += new System.EventHandler(this.btnSaveNumbers_Click);
            // 
            // btnParse
            // 
            this.btnParse.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnParse.Location = new System.Drawing.Point(50, 144);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(105, 47);
            this.btnParse.TabIndex = 13;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // txtAddCount
            // 
            this.txtAddCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAddCount.Location = new System.Drawing.Point(270, 22);
            this.txtAddCount.Multiline = true;
            this.txtAddCount.Name = "txtAddCount";
            this.txtAddCount.Size = new System.Drawing.Size(328, 45);
            this.txtAddCount.TabIndex = 12;
            this.txtAddCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add  page count :";
            // 
            // Binaaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 353);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblNeedToParse);
            this.Controls.Add(this.btnSaveNumbers);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.txtAddCount);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Binaaz";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binaaz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnClear;
        private RichTextBox txtAuthor;
        private Label lblNeedToParse;
        private Button btnSaveNumbers;
        private Button btnParse;
        private TextBox txtAddCount;
        private Label label1;
    }
}