namespace WinFormsDI
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
            this.helloText = new System.Windows.Forms.Label();
            this.goodbyeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloText
            // 
            this.helloText.AutoSize = true;
            this.helloText.Location = new System.Drawing.Point(55, 54);
            this.helloText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.helloText.Name = "helloText";
            this.helloText.Size = new System.Drawing.Size(90, 37);
            this.helloText.TabIndex = 0;
            this.helloText.Text = "label1";
            // 
            // goodbyeText
            // 
            this.goodbyeText.AutoSize = true;
            this.goodbyeText.Location = new System.Drawing.Point(55, 153);
            this.goodbyeText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.goodbyeText.Name = "goodbyeText";
            this.goodbyeText.Size = new System.Drawing.Size(90, 37);
            this.goodbyeText.TabIndex = 0;
            this.goodbyeText.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 620);
            this.Controls.Add(this.goodbyeText);
            this.Controls.Add(this.helloText);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label helloText;
        private Label goodbyeText;
    }
}