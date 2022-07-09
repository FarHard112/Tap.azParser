namespace TapazParser
{
    partial class ChooseParser
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
            this.btnLalafo = new System.Windows.Forms.Button();
            this.btnTapaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLalafo
            // 
            this.btnLalafo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLalafo.Location = new System.Drawing.Point(34, 48);
            this.btnLalafo.Name = "btnLalafo";
            this.btnLalafo.Size = new System.Drawing.Size(160, 44);
            this.btnLalafo.TabIndex = 0;
            this.btnLalafo.Text = "LALAFO";
            this.btnLalafo.UseVisualStyleBackColor = true;
            this.btnLalafo.Click += new System.EventHandler(this.btnLalafo_Click);
            // 
            // btnTapaz
            // 
            this.btnTapaz.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTapaz.Location = new System.Drawing.Point(269, 48);
            this.btnTapaz.Name = "btnTapaz";
            this.btnTapaz.Size = new System.Drawing.Size(160, 44);
            this.btnTapaz.TabIndex = 1;
            this.btnTapaz.Text = "TAP.AZ";
            this.btnTapaz.UseVisualStyleBackColor = true;
            this.btnTapaz.Click += new System.EventHandler(this.btnTapaz_Click);
            // 
            // ChooseParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 141);
            this.Controls.Add(this.btnTapaz);
            this.Controls.Add(this.btnLalafo);
            this.Name = "ChooseParser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseParser";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLalafo;
        private Button btnTapaz;
    }
}