namespace WindowsFormsApplication2
{
    partial class MainForm
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.InputFileTxt = new System.Windows.Forms.TextBox();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(353, 12);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Buscar";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // InputFileTxt
            // 
            this.InputFileTxt.Location = new System.Drawing.Point(12, 12);
            this.InputFileTxt.Name = "InputFileTxt";
            this.InputFileTxt.Size = new System.Drawing.Size(335, 20);
            this.InputFileTxt.TabIndex = 1;
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Location = new System.Drawing.Point(353, 58);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(75, 23);
            this.ProcessBtn.TabIndex = 2;
            this.ProcessBtn.Text = "Procesar";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(12, 58);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateBtn.TabIndex = 3;
            this.GenerateBtn.Text = "Generar";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 93);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.InputFileTxt);
            this.Controls.Add(this.SearchBtn);
            this.Name = "MainForm";
            this.Text = "XML Importer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox InputFileTxt;
        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.Button GenerateBtn;
    }
}

