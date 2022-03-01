namespace EPOSTAGONDERME
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
            this.txbKime = new System.Windows.Forms.Label();
            this.txbKonu = new System.Windows.Forms.Label();
            this.txbIcerik = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbKime
            // 
            this.txbKime.AutoSize = true;
            this.txbKime.Location = new System.Drawing.Point(31, 59);
            this.txbKime.Name = "txbKime";
            this.txbKime.Size = new System.Drawing.Size(30, 13);
            this.txbKime.TabIndex = 0;
            this.txbKime.Text = "Kime";
            // 
            // txbKonu
            // 
            this.txbKonu.AutoSize = true;
            this.txbKonu.Location = new System.Drawing.Point(31, 89);
            this.txbKonu.Name = "txbKonu";
            this.txbKonu.Size = new System.Drawing.Size(32, 13);
            this.txbKonu.TabIndex = 1;
            this.txbKonu.Text = "Konu";
            // 
            // txbIcerik
            // 
            this.txbIcerik.AutoSize = true;
            this.txbIcerik.Location = new System.Drawing.Point(31, 118);
            this.txbIcerik.Name = "txbIcerik";
            this.txbIcerik.Size = new System.Drawing.Size(33, 13);
            this.txbIcerik.TabIndex = 2;
            this.txbIcerik.Text = "İçerik";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(71, 164);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 23);
            this.btnGonder.TabIndex = 6;
            this.btnGonder.Text = "Gonder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 271);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txbIcerik);
            this.Controls.Add(this.txbKonu);
            this.Controls.Add(this.txbKime);
            this.Name = "Form1";
            this.Text = "Eposta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txbKime;
        private System.Windows.Forms.Label txbKonu;
        private System.Windows.Forms.Label txbIcerik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnGonder;
    }
}

