namespace HelloWinForm
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
            this.btnService = new System.Windows.Forms.Button();
            this.rTxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(12, 12);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(180, 23);
            this.btnService.TabIndex = 0;
            this.btnService.Text = "Start Service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // rTxt
            // 
            this.rTxt.BackColor = System.Drawing.SystemColors.Control;
            this.rTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxt.Location = new System.Drawing.Point(13, 42);
            this.rTxt.Name = "rTxt";
            this.rTxt.Size = new System.Drawing.Size(179, 276);
            this.rTxt.TabIndex = 1;
            this.rTxt.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 330);
            this.Controls.Add(this.rTxt);
            this.Controls.Add(this.btnService);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.RichTextBox rTxt;
    }
}

