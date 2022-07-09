namespace TapazParser
{
    partial class LalafoParser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LalafoParser));
            this.lblInProcess = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.RichTextBox();
            this.lblNeedToParse = new System.Windows.Forms.Label();
            this.btnSaveNumbers = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.txtSiteLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInProcess
            // 
            this.lblInProcess.AutoSize = true;
            this.lblInProcess.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInProcess.Location = new System.Drawing.Point(378, 208);
            this.lblInProcess.Name = "lblInProcess";
            this.lblInProcess.Size = new System.Drawing.Size(34, 40);
            this.lblInProcess.TabIndex = 19;
            this.lblInProcess.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(418, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 40);
            this.label2.TabIndex = 18;
            this.label2.Text = "/";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(505, 73);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 47);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(129, 251);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(537, 187);
            this.txtAuthor.TabIndex = 16;
            this.txtAuthor.Text = "";
            // 
            // lblNeedToParse
            // 
            this.lblNeedToParse.AutoSize = true;
            this.lblNeedToParse.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNeedToParse.Location = new System.Drawing.Point(439, 208);
            this.lblNeedToParse.Name = "lblNeedToParse";
            this.lblNeedToParse.Size = new System.Drawing.Size(34, 40);
            this.lblNeedToParse.TabIndex = 15;
            this.lblNeedToParse.Text = "0";
            // 
            // btnSaveNumbers
            // 
            this.btnSaveNumbers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveNumbers.Location = new System.Drawing.Point(394, 73);
            this.btnSaveNumbers.Name = "btnSaveNumbers";
            this.btnSaveNumbers.Size = new System.Drawing.Size(105, 47);
            this.btnSaveNumbers.TabIndex = 14;
            this.btnSaveNumbers.Text = "Save Numbers";
            this.btnSaveNumbers.UseVisualStyleBackColor = true;
            // 
            // btnParse
            // 
            this.btnParse.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnParse.Location = new System.Drawing.Point(283, 73);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(105, 47);
            this.btnParse.TabIndex = 13;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // txtSiteLink
            // 
            this.txtSiteLink.Location = new System.Drawing.Point(282, 22);
            this.txtSiteLink.Multiline = true;
            this.txtSiteLink.Name = "txtSiteLink";
            this.txtSiteLink.Size = new System.Drawing.Size(328, 45);
            this.txtSiteLink.TabIndex = 12;
            this.txtSiteLink.Text = "https://tap.az/elanlar?utf8=%E2%9C%93&log=true&q%5Bkeywords%5D=oyunlar+&q%5Bregio" +
    "n_id%5D=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(115, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Parse link :";
            // 
            // LalafoParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "LalafoParser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LalafoParser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInProcess;
        private Label label2;
        private Button btnClear;
        private RichTextBox txtAuthor;
        private Label lblNeedToParse;
        private Button btnSaveNumbers;
        private Button btnParse;
        private TextBox txtSiteLink;
        private Label label1;
    }
}