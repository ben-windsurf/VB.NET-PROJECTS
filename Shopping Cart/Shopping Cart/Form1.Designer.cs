namespace Shopping_Cart
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(300, 111);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(297, 50);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Shopping Cart";
            // 
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(148, 288);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(116, 37);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Laptop";
            // 
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(148, 503);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(152, 37);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Keyboard";
            // 
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(148, 402);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(112, 37);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Mouse";
            // 
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.CheckBox1.Location = new System.Drawing.Point(592, 298);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(153, 41);
            this.CheckBox1.TabIndex = 8;
            this.CheckBox1.Text = "₹ 50000";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.CheckBox2.Location = new System.Drawing.Point(592, 398);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(153, 41);
            this.CheckBox2.TabIndex = 9;
            this.CheckBox2.Text = "₹ 10000";
            this.CheckBox2.UseVisualStyleBackColor = true;
            // 
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.CheckBox3.Location = new System.Drawing.Point(592, 499);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(136, 41);
            this.CheckBox3.TabIndex = 10;
            this.CheckBox3.Text = "₹ 8000";
            this.CheckBox3.UseVisualStyleBackColor = true;
            // 
            // 
            this.TextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(155, 611);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(590, 44);
            this.TextBox1.TabIndex = 11;
            this.TextBox1.Text = "Total is : ";
            // 
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(155, 754);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(194, 66);
            this.Button1.TabIndex = 12;
            this.Button1.Text = "TOTAL";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.Button2.Location = new System.Drawing.Point(551, 754);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(194, 66);
            this.Button2.TabIndex = 13;
            this.Button2.Text = "CLEAR";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 912);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.CheckBox3);
            this.Controls.Add(this.CheckBox2);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Shopping Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.CheckBox CheckBox2;
        private System.Windows.Forms.CheckBox CheckBox3;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
    }
}
