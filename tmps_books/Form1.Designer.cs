
namespace tmps_books
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
            this.makeAnOrder = new System.Windows.Forms.Button();
            this.Books = new System.Windows.Forms.LinkLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.School = new System.Windows.Forms.LinkLabel();
            this.Conctov = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // makeAnOrder
            // 
            this.makeAnOrder.Location = new System.Drawing.Point(0, 0);
            this.makeAnOrder.Name = "makeAnOrder";
            this.makeAnOrder.Size = new System.Drawing.Size(75, 23);
            this.makeAnOrder.TabIndex = 0;
            // 
            // Books
            // 
            this.Books.AutoSize = true;
            this.Books.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Books.Location = new System.Drawing.Point(44, 85);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(69, 30);
            this.Books.TabIndex = 1;
            this.Books.TabStop = true;
            this.Books.Text = "Книги";
            this.Books.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 96);
            this.listBox1.TabIndex = 0;
            // 
            // School
            // 
            this.School.AutoSize = true;
            this.School.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.School.Location = new System.Drawing.Point(44, 146);
            this.School.Name = "School";
            this.School.Size = new System.Drawing.Size(77, 30);
            this.School.TabIndex = 2;
            this.School.TabStop = true;
            this.School.Text = "Школа";
            this.School.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.School_LinkClicked);
            // 
            // Conctov
            // 
            this.Conctov.AutoSize = true;
            this.Conctov.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Conctov.Location = new System.Drawing.Point(44, 209);
            this.Conctov.Name = "Conctov";
            this.Conctov.Size = new System.Drawing.Size(131, 30);
            this.Conctov.TabIndex = 3;
            this.Conctov.TabStop = true;
            this.Conctov.Text = "Канцтовары";
            this.Conctov.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Conctov_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(231, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Книжный магазин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(838, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Conctov);
            this.Controls.Add(this.School);
            this.Controls.Add(this.Books);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeAnOrder;
        private System.Windows.Forms.LinkLabel Books;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.LinkLabel School;
        private System.Windows.Forms.LinkLabel Conctov;
        private System.Windows.Forms.Label label1;
    }
}

