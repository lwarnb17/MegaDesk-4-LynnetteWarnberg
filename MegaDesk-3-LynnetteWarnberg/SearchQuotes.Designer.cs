namespace MegaDesk_3_LynnetteWarnberg
{
    partial class SearchQuotes
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
            this.CancelQuoteSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelQuoteSearch
            // 
            this.CancelQuoteSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CancelQuoteSearch.Location = new System.Drawing.Point(239, 123);
            this.CancelQuoteSearch.Name = "CancelQuoteSearch";
            this.CancelQuoteSearch.Size = new System.Drawing.Size(299, 78);
            this.CancelQuoteSearch.TabIndex = 0;
            this.CancelQuoteSearch.Text = "Cancel";
            this.CancelQuoteSearch.UseVisualStyleBackColor = true;
            this.CancelQuoteSearch.Click += new System.EventHandler(this.CancelQuoteSearch_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelQuoteSearch);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchQuotes_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelQuoteSearch;
    }
}