namespace QLTHUVIEN
{
    partial class Dangnhap
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
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(78, 44);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(78, 17);
            this.lab1.TabIndex = 1;
            this.lab1.Text = "Đăng nhập";
            this.lab1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(246, 106);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(73, 17);
            this.lab2.TabIndex = 2;
            this.lab2.Text = "Username";
            this.lab2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(246, 161);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(69, 17);
            this.lab3.TabIndex = 3;
            this.lab3.Text = "Password";
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(341, 106);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(217, 22);
            this.txb1.TabIndex = 4;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(341, 156);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(217, 22);
            this.txb2.TabIndex = 5;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(341, 205);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 31);
            this.bt1.TabIndex = 6;
            this.bt1.Text = "Login";
            this.bt1.UseVisualStyleBackColor = true;
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(474, 205);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 31);
            this.bt2.TabIndex = 7;
            this.bt2.Text = "Exit";
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 312);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.KeyPreview = true;
            this.Name = "Dangnhap";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
    }
}

