namespace Service_Giris
{
    partial class TcknDoğrula
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
            this.mskdTckn = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskdDogumyili = new System.Windows.Forms.MaskedTextBox();
            this.btndogrula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // mskdTckn
            // 
            this.mskdTckn.Location = new System.Drawing.Point(136, 34);
            this.mskdTckn.Mask = "00000000000";
            this.mskdTckn.Name = "mskdTckn";
            this.mskdTckn.Size = new System.Drawing.Size(100, 20);
            this.mskdTckn.TabIndex = 1;
            this.mskdTckn.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İsim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyisim";
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(136, 82);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(100, 20);
            this.txtİsim.TabIndex = 4;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(136, 128);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(100, 20);
            this.txtSoyisim.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doğum Yılı:";
            // 
            // mskdDogumyili
            // 
            this.mskdDogumyili.Location = new System.Drawing.Point(136, 178);
            this.mskdDogumyili.Mask = "0000";
            this.mskdDogumyili.Name = "mskdDogumyili";
            this.mskdDogumyili.Size = new System.Drawing.Size(100, 20);
            this.mskdDogumyili.TabIndex = 7;
            this.mskdDogumyili.ValidatingType = typeof(int);
            // 
            // btndogrula
            // 
            this.btndogrula.Location = new System.Drawing.Point(160, 241);
            this.btndogrula.Name = "btndogrula";
            this.btndogrula.Size = new System.Drawing.Size(75, 23);
            this.btndogrula.TabIndex = 8;
            this.btndogrula.Text = "Doğrula";
            this.btndogrula.UseVisualStyleBackColor = true;
            this.btndogrula.Click += new System.EventHandler(this.btndogrula_Click);
            // 
            // TcknDoğrula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 315);
            this.Controls.Add(this.btndogrula);
            this.Controls.Add(this.mskdDogumyili);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskdTckn);
            this.Controls.Add(this.label1);
            this.Name = "TcknDoğrula";
            this.Text = "TcknDoğrula";
            this.Load += new System.EventHandler(this.TcknDoğrula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskdTckn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskdDogumyili;
        private System.Windows.Forms.Button btndogrula;
    }
}