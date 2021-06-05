
namespace tmps_books
{
    partial class Stationery
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
            this.card = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plactic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paper = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cardboard folder";
            // 
            // card
            // 
            this.card.Location = new System.Drawing.Point(210, 52);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(100, 23);
            this.card.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(210, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Plastic folder";
            // 
            // plactic
            // 
            this.plactic.Location = new System.Drawing.Point(210, 95);
            this.plactic.Name = "plactic";
            this.plactic.Size = new System.Drawing.Size(100, 23);
            this.plactic.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Paper folder";
            // 
            // paper
            // 
            this.paper.Location = new System.Drawing.Point(210, 140);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(100, 23);
            this.paper.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(234, 229);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Stationery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plactic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.card);
            this.Controls.Add(this.label1);
            this.Name = "Stationery";
            this.Text = "Stationery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox card;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox plactic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox paper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Save;
    }
}