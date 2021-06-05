
namespace tmps_books
{
    partial class Complete_Order
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
            this.formatBookLabel = new System.Windows.Forms.Label();
            this.Purchase_label1 = new System.Windows.Forms.Label();
            this.Cover_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formatBookLabel
            // 
            this.formatBookLabel.AutoSize = true;
            this.formatBookLabel.Location = new System.Drawing.Point(67, 73);
            this.formatBookLabel.Name = "formatBookLabel";
            this.formatBookLabel.Size = new System.Drawing.Size(38, 15);
            this.formatBookLabel.TabIndex = 0;
            this.formatBookLabel.Text = "label1";
            this.formatBookLabel.Click += new System.EventHandler(this.formatBookLabel_Click);
            // 
            // Purchase_label1
            // 
            this.Purchase_label1.AutoSize = true;
            this.Purchase_label1.Location = new System.Drawing.Point(67, 125);
            this.Purchase_label1.Name = "Purchase_label1";
            this.Purchase_label1.Size = new System.Drawing.Size(38, 15);
            this.Purchase_label1.TabIndex = 1;
            this.Purchase_label1.Text = "label1";
            // 
            // Cover_label
            // 
            this.Cover_label.AutoSize = true;
            this.Cover_label.Location = new System.Drawing.Point(67, 177);
            this.Cover_label.Name = "Cover_label";
            this.Cover_label.Size = new System.Drawing.Size(38, 15);
            this.Cover_label.TabIndex = 2;
            this.Cover_label.Text = "label1";
            // 
            // Complete_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cover_label);
            this.Controls.Add(this.Purchase_label1);
            this.Controls.Add(this.formatBookLabel);
            this.Name = "Complete_Order";
            this.Text = "Complete_Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label formatBookLabel;
        public System.Windows.Forms.Label Purchase_label1;
        public System.Windows.Forms.Label Cover_label;
    }
}