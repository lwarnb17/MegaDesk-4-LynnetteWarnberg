namespace MegaDesk_3_LynnetteWarnberg
{
    partial class AddQuote
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
            this.CancelQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelQuote
            // 
            this.CancelQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CancelQuote.Location = new System.Drawing.Point(303, 184);
            this.CancelQuote.Name = "CancelQuote";
            this.CancelQuote.Size = new System.Drawing.Size(234, 75);
            this.CancelQuote.TabIndex = 0;
            this.CancelQuote.Text = "Cancel";
            this.CancelQuote.UseVisualStyleBackColor = true;
            this.CancelQuote.Click += new System.EventHandler(this.CancelQuoteButton);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelQuote);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQuote_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelQuote;
    }
}