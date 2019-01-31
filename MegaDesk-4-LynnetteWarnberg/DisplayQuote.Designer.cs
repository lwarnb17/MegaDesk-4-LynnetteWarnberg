﻿namespace MegaDesk_3_LynnetteWarnberg
{
    partial class DisplayQuote
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
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.depth = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.lbNumberOfDrawers = new System.Windows.Forms.Label();
            this.lbSurfaceMaterial = new System.Windows.Forms.Label();
            this.lbDelivery = new System.Windows.Forms.Label();
            this.lbQuoteAmount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DisplayLabel.Location = new System.Drawing.Point(276, 39);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(326, 46);
            this.DisplayLabel.TabIndex = 0;
            this.DisplayLabel.Text = "Your Desk Quote";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CustomerName.Location = new System.Drawing.Point(70, 117);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(188, 29);
            this.CustomerName.TabIndex = 1;
            this.CustomerName.Text = "CustomerName:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerName.Location = new System.Drawing.Point(260, 113);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(359, 35);
            this.txtCustomerName.TabIndex = 2;
            // 
            // depth
            // 
            this.depth.AutoSize = true;
            this.depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.depth.Location = new System.Drawing.Point(276, 270);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(83, 29);
            this.depth.TabIndex = 3;
            this.depth.Text = "Depth:";
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.width.Location = new System.Drawing.Point(279, 208);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(80, 29);
            this.width.TabIndex = 4;
            this.width.Text = "Width:";
            // 
            // lbNumberOfDrawers
            // 
            this.lbNumberOfDrawers.AutoSize = true;
            this.lbNumberOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNumberOfDrawers.Location = new System.Drawing.Point(114, 325);
            this.lbNumberOfDrawers.Name = "lbNumberOfDrawers";
            this.lbNumberOfDrawers.Size = new System.Drawing.Size(245, 29);
            this.lbNumberOfDrawers.TabIndex = 5;
            this.lbNumberOfDrawers.Text = "Numbers Of Drawers:";
            // 
            // lbSurfaceMaterial
            // 
            this.lbSurfaceMaterial.AutoSize = true;
            this.lbSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSurfaceMaterial.Location = new System.Drawing.Point(478, 208);
            this.lbSurfaceMaterial.Name = "lbSurfaceMaterial";
            this.lbSurfaceMaterial.Size = new System.Drawing.Size(193, 29);
            this.lbSurfaceMaterial.TabIndex = 6;
            this.lbSurfaceMaterial.Text = "Surface Material:";
            // 
            // lbDelivery
            // 
            this.lbDelivery.AutoSize = true;
            this.lbDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDelivery.Location = new System.Drawing.Point(478, 270);
            this.lbDelivery.Name = "lbDelivery";
            this.lbDelivery.Size = new System.Drawing.Size(106, 29);
            this.lbDelivery.TabIndex = 7;
            this.lbDelivery.Text = "Delivery:";
            // 
            // lbQuoteAmount
            // 
            this.lbQuoteAmount.AutoSize = true;
            this.lbQuoteAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbQuoteAmount.Location = new System.Drawing.Point(153, 400);
            this.lbQuoteAmount.Name = "lbQuoteAmount";
            this.lbQuoteAmount.Size = new System.Drawing.Size(206, 32);
            this.lbQuoteAmount.TabIndex = 8;
            this.lbQuoteAmount.Text = "Quote Amount:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(322, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(240, 56);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 582);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbQuoteAmount);
            this.Controls.Add(this.lbDelivery);
            this.Controls.Add(this.lbSurfaceMaterial);
            this.Controls.Add(this.lbNumberOfDrawers);
            this.Controls.Add(this.width);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.DisplayLabel);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label depth;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label lbNumberOfDrawers;
        private System.Windows.Forms.Label lbSurfaceMaterial;
        private System.Windows.Forms.Label lbDelivery;
        private System.Windows.Forms.Label lbQuoteAmount;
        private System.Windows.Forms.Button btnCancel;
    }
}