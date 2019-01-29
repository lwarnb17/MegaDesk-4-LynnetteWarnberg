namespace MegaDesk_3_LynnetteWarnberg
{
    partial class ViewAllQuotes
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
            this.CancelAllQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelAllQuotes
            // 
            this.CancelAllQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CancelAllQuotes.Location = new System.Drawing.Point(292, 174);
            this.CancelAllQuotes.Name = "CancelAllQuotes";
            this.CancelAllQuotes.Size = new System.Drawing.Size(232, 72);
            this.CancelAllQuotes.TabIndex = 0;
            this.CancelAllQuotes.Text = "Cancel";
            this.CancelAllQuotes.UseVisualStyleBackColor = true;
            this.CancelAllQuotes.Click += new System.EventHandler(this.cancelQuoteButton_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelAllQuotes);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAllQuotes_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelAllQuotes;
    }
}