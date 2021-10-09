namespace Konveri_Suhu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsuhu = new System.Windows.Forms.TextBox();
            this.comboBoxSuhu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbCelcius = new System.Windows.Forms.RadioButton();
            this.rbFahreinheit = new System.Windows.Forms.RadioButton();
            this.rbReamur = new System.Windows.Forms.RadioButton();
            this.btnKonveri = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txthasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KONVERSI SUHU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SUHU";
            // 
            // txtsuhu
            // 
            this.txtsuhu.Location = new System.Drawing.Point(55, 65);
            this.txtsuhu.Name = "txtsuhu";
            this.txtsuhu.Size = new System.Drawing.Size(100, 20);
            this.txtsuhu.TabIndex = 2;
            this.txtsuhu.TextChanged += new System.EventHandler(this.txtsuhu_TextChanged);
            // 
            // comboBoxSuhu
            // 
            this.comboBoxSuhu.FormattingEnabled = true;
            this.comboBoxSuhu.Items.AddRange(new object[] {
            "Celcius",
            "Fahreinheit",
            "Reamur"});
            this.comboBoxSuhu.Location = new System.Drawing.Point(161, 64);
            this.comboBoxSuhu.Name = "comboBoxSuhu";
            this.comboBoxSuhu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSuhu.TabIndex = 3;
            this.comboBoxSuhu.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuhu_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "KE :";
            // 
            // rbCelcius
            // 
            this.rbCelcius.AutoSize = true;
            this.rbCelcius.Location = new System.Drawing.Point(55, 99);
            this.rbCelcius.Name = "rbCelcius";
            this.rbCelcius.Size = new System.Drawing.Size(59, 17);
            this.rbCelcius.TabIndex = 5;
            this.rbCelcius.TabStop = true;
            this.rbCelcius.Text = "Celcius";
            this.rbCelcius.UseVisualStyleBackColor = true;
            // 
            // rbFahreinheit
            // 
            this.rbFahreinheit.AutoSize = true;
            this.rbFahreinheit.Location = new System.Drawing.Point(55, 122);
            this.rbFahreinheit.Name = "rbFahreinheit";
            this.rbFahreinheit.Size = new System.Drawing.Size(77, 17);
            this.rbFahreinheit.TabIndex = 6;
            this.rbFahreinheit.TabStop = true;
            this.rbFahreinheit.Text = "Fahreinheit";
            this.rbFahreinheit.UseVisualStyleBackColor = true;
            // 
            // rbReamur
            // 
            this.rbReamur.AutoSize = true;
            this.rbReamur.Location = new System.Drawing.Point(55, 145);
            this.rbReamur.Name = "rbReamur";
            this.rbReamur.Size = new System.Drawing.Size(62, 17);
            this.rbReamur.TabIndex = 7;
            this.rbReamur.TabStop = true;
            this.rbReamur.Text = "Reamur";
            this.rbReamur.UseVisualStyleBackColor = true;
            // 
            // btnKonveri
            // 
            this.btnKonveri.Location = new System.Drawing.Point(55, 183);
            this.btnKonveri.Name = "btnKonveri";
            this.btnKonveri.Size = new System.Drawing.Size(182, 28);
            this.btnKonveri.TabIndex = 8;
            this.btnKonveri.Text = "KONVERSI";
            this.btnKonveri.UseVisualStyleBackColor = true;
            this.btnKonveri.Click += new System.EventHandler(this.btnKonveri_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "HASIL";
            // 
            // txthasil
            // 
            this.txthasil.Location = new System.Drawing.Point(107, 223);
            this.txthasil.Name = "txthasil";
            this.txthasil.Size = new System.Drawing.Size(130, 20);
            this.txthasil.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txthasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKonveri);
            this.Controls.Add(this.rbReamur);
            this.Controls.Add(this.rbFahreinheit);
            this.Controls.Add(this.rbCelcius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSuhu);
            this.Controls.Add(this.txtsuhu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsuhu;
        private System.Windows.Forms.ComboBox comboBoxSuhu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbCelcius;
        private System.Windows.Forms.RadioButton rbFahreinheit;
        private System.Windows.Forms.RadioButton rbReamur;
        private System.Windows.Forms.Button btnKonveri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthasil;
    }
}

