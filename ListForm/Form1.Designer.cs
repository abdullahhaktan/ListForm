namespace ListForm
{
    partial class Form1
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
            this.btnListele = new System.Windows.Forms.Button();
            this.btnListele1 = new System.Windows.Forms.Button();
            this.btnListele2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.btnListele4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(12, 174);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(306, 34);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele 1";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnListele1
            // 
            this.btnListele1.Location = new System.Drawing.Point(324, 174);
            this.btnListele1.Name = "btnListele1";
            this.btnListele1.Size = new System.Drawing.Size(303, 34);
            this.btnListele1.TabIndex = 1;
            this.btnListele1.Text = "Listele 2";
            this.btnListele1.UseVisualStyleBackColor = true;
            this.btnListele1.Click += new System.EventHandler(this.btnListele1_Click);
            // 
            // btnListele2
            // 
            this.btnListele2.Location = new System.Drawing.Point(12, 379);
            this.btnListele2.Name = "btnListele2";
            this.btnListele2.Size = new System.Drawing.Size(306, 34);
            this.btnListele2.TabIndex = 2;
            this.btnListele2.Text = "Listele 3";
            this.btnListele2.UseVisualStyleBackColor = true;
            this.btnListele2.Click += new System.EventHandler(this.btnListele2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(306, 156);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Location = new System.Drawing.Point(324, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(303, 156);
            this.listBox2.TabIndex = 4;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 19;
            this.listBox3.Location = new System.Drawing.Point(12, 214);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(306, 156);
            this.listBox3.TabIndex = 5;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 19;
            this.listBox4.Location = new System.Drawing.Point(324, 214);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(303, 156);
            this.listBox4.TabIndex = 7;
            // 
            // btnListele4
            // 
            this.btnListele4.Location = new System.Drawing.Point(324, 379);
            this.btnListele4.Name = "btnListele4";
            this.btnListele4.Size = new System.Drawing.Size(303, 34);
            this.btnListele4.TabIndex = 6;
            this.btnListele4.Text = "Listele 4";
            this.btnListele4.UseVisualStyleBackColor = true;
            this.btnListele4.Click += new System.EventHandler(this.btnListele4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 425);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.btnListele4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnListele2);
            this.Controls.Add(this.btnListele1);
            this.Controls.Add(this.btnListele);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnListele1;
        private System.Windows.Forms.Button btnListele2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button btnListele4;
    }
}

