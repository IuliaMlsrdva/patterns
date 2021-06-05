
namespace tmps_books
{
    partial class Ucebniki
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Math",
            "Literature"});
            this.comboBox1.Location = new System.Drawing.Point(61, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 23);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 23);
            this.textBox3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Paper house";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(106, 300);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(700, 406);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 11;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Ucebniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Ucebniki";
            this.Text = "Ucebniki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button back_btn;
    }
}