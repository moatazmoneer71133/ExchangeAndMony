namespace ExchangeAndMony.pages
{
    partial class currencie_com
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.com_currencie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // com_currencie
            // 
            this.com_currencie.Font = new System.Drawing.Font("Tahoma", 10F);
            this.com_currencie.FormattingEnabled = true;
            this.com_currencie.Location = new System.Drawing.Point(1, 0);
            this.com_currencie.Name = "com_currencie";
            this.com_currencie.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.com_currencie.Size = new System.Drawing.Size(190, 29);
            this.com_currencie.TabIndex = 0;
            this.com_currencie.SelectedIndexChanged += new System.EventHandler(this.Com_currencie_SelectedIndexChanged);
            this.com_currencie.Click += new System.EventHandler(this.Com_currencie_Click);
            // 
            // currencie_com
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.com_currencie);
            this.Name = "currencie_com";
            this.Size = new System.Drawing.Size(191, 25);
            this.Load += new System.EventHandler(this.Currencie_com_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox com_currencie;
    }
}
