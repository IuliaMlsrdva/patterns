
namespace tmps_books
{
    partial class ListOfBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfBooks));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowers_in_the_Attick = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Hamp = new System.Windows.Forms.LinkLabel();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 225);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flowers_in_the_Attick
            // 
            this.flowers_in_the_Attick.AutoSize = true;
            this.flowers_in_the_Attick.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flowers_in_the_Attick.Location = new System.Drawing.Point(66, 282);
            this.flowers_in_the_Attick.Name = "flowers_in_the_Attick";
            this.flowers_in_the_Attick.Size = new System.Drawing.Size(137, 20);
            this.flowers_in_the_Attick.TabIndex = 1;
            this.flowers_in_the_Attick.TabStop = true;
            this.flowers_in_the_Attick.Text = "Flowers in the attic";
            this.flowers_in_the_Attick.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.flowers_in_the_Attick_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(341, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 225);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Hamp
            // 
            this.Hamp.AutoSize = true;
            this.Hamp.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hamp.Location = new System.Drawing.Point(341, 282);
            this.Hamp.Name = "Hamp";
            this.Hamp.Size = new System.Drawing.Size(174, 20);
            this.Hamp.TabIndex = 3;
            this.Hamp.TabStop = true;
            this.Hamp.Text = "Отель «Нью-Хэмпшир»";
            this.Hamp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Hamp_LinkClicked);
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(703, 404);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(75, 23);
            this.Back_btn.TabIndex = 4;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // ListOfBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Hamp);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.flowers_in_the_Attick);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListOfBooks";
            this.Text = "ListOfBooks";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel flowers_in_the_Attick;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel Hamp;
        private System.Windows.Forms.Button Back_btn;
    }
}