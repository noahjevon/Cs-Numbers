namespace WinFormsApp1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_prime = new System.Windows.Forms.Button();
            this.btn_odd_even = new System.Windows.Forms.Button();
            this.lbl_prime = new System.Windows.Forms.Label();
            this.lbl_odd_even = new System.Windows.Forms.Label();
            this.lbl_entry = new System.Windows.Forms.Label();
            this.txt_entry = new System.Windows.Forms.TextBox();
            this.lbl_help = new System.Windows.Forms.Label();
            this.lbl_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_prime
            // 
            this.btn_prime.Location = new System.Drawing.Point(285, 270);
            this.btn_prime.Name = "btn_prime";
            this.btn_prime.Size = new System.Drawing.Size(73, 28);
            this.btn_prime.TabIndex = 0;
            this.btn_prime.Text = "Go";
            this.btn_prime.UseVisualStyleBackColor = true;
            this.btn_prime.Click += new System.EventHandler(this.btn_prime_Click);
            // 
            // btn_odd_even
            // 
            this.btn_odd_even.Location = new System.Drawing.Point(434, 270);
            this.btn_odd_even.Name = "btn_odd_even";
            this.btn_odd_even.Size = new System.Drawing.Size(73, 28);
            this.btn_odd_even.TabIndex = 1;
            this.btn_odd_even.Text = "Go";
            this.btn_odd_even.UseVisualStyleBackColor = true;
            this.btn_odd_even.Click += new System.EventHandler(this.btn_odd_even_Click);
            // 
            // lbl_prime
            // 
            this.lbl_prime.Location = new System.Drawing.Point(285, 250);
            this.lbl_prime.Name = "lbl_prime";
            this.lbl_prime.Size = new System.Drawing.Size(73, 17);
            this.lbl_prime.TabIndex = 2;
            this.lbl_prime.Text = "Prime\r\n";
            this.lbl_prime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_odd_even
            // 
            this.lbl_odd_even.Location = new System.Drawing.Point(434, 250);
            this.lbl_odd_even.Name = "lbl_odd_even";
            this.lbl_odd_even.Size = new System.Drawing.Size(73, 17);
            this.lbl_odd_even.TabIndex = 3;
            this.lbl_odd_even.Text = "Odd/Even";
            this.lbl_odd_even.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_entry
            // 
            this.lbl_entry.Location = new System.Drawing.Point(285, 115);
            this.lbl_entry.Name = "lbl_entry";
            this.lbl_entry.Size = new System.Drawing.Size(123, 20);
            this.lbl_entry.TabIndex = 4;
            this.lbl_entry.Text = "Enter some numbers:\r\n\r\n";
            this.lbl_entry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txt_entry
            // 
            this.txt_entry.Location = new System.Drawing.Point(434, 115);
            this.txt_entry.MaxLength = 16;
            this.txt_entry.Name = "txt_entry";
            this.txt_entry.Size = new System.Drawing.Size(73, 20);
            this.txt_entry.TabIndex = 5;
            // 
            // lbl_help
            // 
            this.lbl_help.Location = new System.Drawing.Point(285, 181);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(221, 30);
            this.lbl_help.TabIndex = 6;
            this.lbl_help.Text = "Would you like to find prime numbers, or odd and even numbers?";
            this.lbl_help.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_output
            // 
            this.lbl_output.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_output.Location = new System.Drawing.Point(285, 301);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(221, 56);
            this.lbl_output.TabIndex = 7;
            this.lbl_output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lbl_help);
            this.Controls.Add(this.txt_entry);
            this.Controls.Add(this.lbl_entry);
            this.Controls.Add(this.lbl_odd_even);
            this.Controls.Add(this.lbl_prime);
            this.Controls.Add(this.btn_odd_even);
            this.Controls.Add(this.btn_prime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl_output;

        private System.Windows.Forms.Label lbl_entry;
        private System.Windows.Forms.TextBox txt_entry;
        private System.Windows.Forms.Label lbl_help;

        private System.Windows.Forms.Label lbl_prime;

        private System.Windows.Forms.Label lbl_odd_even;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btn_prime;
        private System.Windows.Forms.Button btn_odd_even;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}