namespace TapazParser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSiteLink = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnSaveNumbers = new System.Windows.Forms.Button();
            this.lblNeedToParse = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInProcess = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parse category :";
            // 
            // txtSiteLink
            // 
            this.txtSiteLink.Location = new System.Drawing.Point(223, 12);
            this.txtSiteLink.Multiline = true;
            this.txtSiteLink.Name = "txtSiteLink";
            this.txtSiteLink.Size = new System.Drawing.Size(328, 45);
            this.txtSiteLink.TabIndex = 1;
            this.txtSiteLink.Text = "https://tap.az/elanlar?utf8=%E2%9C%93&log=true&q%5Bkeywords%5D=oyunlar+&q%5Bregio" +
    "n_id%5D=";
            // 
            // btnParse
            // 
            this.btnParse.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnParse.Location = new System.Drawing.Point(24, 134);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(105, 47);
            this.btnParse.TabIndex = 2;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnSaveNumbers
            // 
            this.btnSaveNumbers.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveNumbers.Location = new System.Drawing.Point(24, 198);
            this.btnSaveNumbers.Name = "btnSaveNumbers";
            this.btnSaveNumbers.Size = new System.Drawing.Size(105, 47);
            this.btnSaveNumbers.TabIndex = 3;
            this.btnSaveNumbers.Text = "Save Numbers";
            this.btnSaveNumbers.UseVisualStyleBackColor = true;
            this.btnSaveNumbers.Click += new System.EventHandler(this.btnSaveNumbers_Click);
            // 
            // lblNeedToParse
            // 
            this.lblNeedToParse.AutoSize = true;
            this.lblNeedToParse.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNeedToParse.Location = new System.Drawing.Point(421, 77);
            this.lblNeedToParse.Name = "lblNeedToParse";
            this.lblNeedToParse.Size = new System.Drawing.Size(32, 40);
            this.lblNeedToParse.TabIndex = 6;
            this.lblNeedToParse.Text = "0";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(164, 124);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(483, 187);
            this.txtAuthor.TabIndex = 7;
            this.txtAuthor.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(24, 264);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 47);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(398, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "/";
            // 
            // lblInProcess
            // 
            this.lblInProcess.AutoSize = true;
            this.lblInProcess.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInProcess.Location = new System.Drawing.Point(360, 77);
            this.lblInProcess.Name = "lblInProcess";
            this.lblInProcess.Size = new System.Drawing.Size(32, 40);
            this.lblInProcess.TabIndex = 10;
            this.lblInProcess.Text = "0";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(587, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 322);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblInProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblNeedToParse);
            this.Controls.Add(this.btnSaveNumbers);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.txtSiteLink);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tap az Parser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSiteLink;
        private Button btnParse;
        private Button btnSaveNumbers;
        private Label lblNeedToParse;
        private RichTextBox txtAuthor;
        private Button btnClear;
        private Label label2;
        private Label lblInProcess;
        private Button btnBack;
    }
}