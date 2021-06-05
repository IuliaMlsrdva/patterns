
namespace tmps_books
{
    partial class Flowers_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flowers_form));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameLab = new System.Windows.Forms.Label();
            this.LastnameLab = new System.Windows.Forms.Label();
            this.Name_text = new System.Windows.Forms.TextBox();
            this.Last_text = new System.Windows.Forms.TextBox();
            this.Show_res = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(637, 366);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 50);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Order";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 225);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(222, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Flowers in the attic";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(222, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // NameLab
            // 
            this.NameLab.AutoSize = true;
            this.NameLab.Location = new System.Drawing.Point(240, 331);
            this.NameLab.Name = "NameLab";
            this.NameLab.Size = new System.Drawing.Size(38, 15);
            this.NameLab.TabIndex = 8;
            this.NameLab.Text = "label4";
            // 
            // LastnameLab
            // 
            this.LastnameLab.AutoSize = true;
            this.LastnameLab.Location = new System.Drawing.Point(240, 362);
            this.LastnameLab.Name = "LastnameLab";
            this.LastnameLab.Size = new System.Drawing.Size(38, 15);
            this.LastnameLab.TabIndex = 9;
            this.LastnameLab.Text = "label5";
            // 
            // Name_text
            // 
            this.Name_text.Location = new System.Drawing.Point(31, 323);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(100, 23);
            this.Name_text.TabIndex = 10;
            // 
            // Last_text
            // 
            this.Last_text.Location = new System.Drawing.Point(31, 369);
            this.Last_text.Name = "Last_text";
            this.Last_text.Size = new System.Drawing.Size(100, 23);
            this.Last_text.TabIndex = 11;
            // 
            // Show_res
            // 
            this.Show_res.Location = new System.Drawing.Point(172, 393);
            this.Show_res.Name = "Show_res";
            this.Show_res.Size = new System.Drawing.Size(106, 23);
            this.Show_res.TabIndex = 12;
            this.Show_res.Text = "Show Result";
            this.Show_res.UseVisualStyleBackColor = true;
            this.Show_res.Click += new System.EventHandler(this.Show_res_Click);
            // 
            // Flowers_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Show_res);
            this.Controls.Add(this.Last_text);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.LastnameLab);
            this.Controls.Add(this.NameLab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Flowers_form";
            this.Text = "Flowers_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NameLab;
        private System.Windows.Forms.Label LastnameLab;
        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.TextBox Last_text;
        private System.Windows.Forms.Button Show_res;
    }
}