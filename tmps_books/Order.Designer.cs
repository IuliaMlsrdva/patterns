
namespace tmps_books
{
    partial class Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button_next = new System.Windows.Forms.Button();
            this.book_format = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Language = new System.Windows.Forms.Label();
            this.language_text = new System.Windows.Forms.TextBox();
            this.coverType_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cover_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book format:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Purchase method:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(-240, 99);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(94, 19);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(213, 289);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(71, 30);
            this.button_next.TabIndex = 8;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // book_format
            // 
            this.book_format.FormattingEnabled = true;
            this.book_format.Items.AddRange(new object[] {
            "Paper book",
            "Audio book"});
            this.book_format.Location = new System.Drawing.Point(163, 70);
            this.book_format.Name = "book_format";
            this.book_format.Size = new System.Drawing.Size(121, 23);
            this.book_format.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Physical payment",
            "Online payment"});
            this.comboBox1.Location = new System.Drawing.Point(163, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cover Type:";
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Language.Location = new System.Drawing.Point(27, 218);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(59, 15);
            this.Language.TabIndex = 12;
            this.Language.Text = "Language";
            // 
            // language_text
            // 
            this.language_text.Location = new System.Drawing.Point(163, 218);
            this.language_text.Name = "language_text";
            this.language_text.Size = new System.Drawing.Size(121, 23);
            this.language_text.TabIndex = 13;
            // 
            // coverType_txt
            // 
            this.coverType_txt.Location = new System.Drawing.Point(163, 165);
            this.coverType_txt.Name = "coverType_txt";
            this.coverType_txt.Size = new System.Drawing.Size(121, 23);
            this.coverType_txt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 17;
            // 
            // Cover_label
            // 
            this.Cover_label.AutoSize = true;
            this.Cover_label.Location = new System.Drawing.Point(372, 173);
            this.Cover_label.Name = "Cover_label";
            this.Cover_label.Size = new System.Drawing.Size(0, 15);
            this.Cover_label.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(372, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Check your order";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(692, 398);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 20;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cover_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.coverType_txt);
            this.Controls.Add(this.language_text);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.book_format);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.ComboBox book_format;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.TextBox language_text;
        private System.Windows.Forms.TextBox coverType_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Cover_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button back_btn;
    }
}