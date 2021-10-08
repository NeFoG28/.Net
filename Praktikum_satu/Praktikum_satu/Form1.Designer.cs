namespace Praktikum_satu
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cksop = new System.Windows.Forms.CheckBox();
            this.ckrica = new System.Windows.Forms.CheckBox();
            this.ckteh = new System.Windows.Forms.CheckBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.txtsop = new System.Windows.Forms.TextBox();
            this.txtrica = new System.Windows.Forms.TextBox();
            this.txtteh = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.rbYa = new System.Windows.Forms.RadioButton();
            this.rbTidak = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PELANGGAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MENU PILIHAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "JUMLAH";
            // 
            // cksop
            // 
            this.cksop.AutoSize = true;
            this.cksop.Location = new System.Drawing.Point(23, 113);
            this.cksop.Name = "cksop";
            this.cksop.Size = new System.Drawing.Size(134, 17);
            this.cksop.TabIndex = 4;
            this.cksop.Text = "SOP AYAM [Rp 9.000]";
            this.cksop.UseVisualStyleBackColor = true;
            this.cksop.CheckedChanged += new System.EventHandler(this.cksop_CheckedChanged);
            // 
            // ckrica
            // 
            this.ckrica.AutoSize = true;
            this.ckrica.Location = new System.Drawing.Point(23, 136);
            this.ckrica.Name = "ckrica";
            this.ckrica.Size = new System.Drawing.Size(165, 17);
            this.ckrica.TabIndex = 5;
            this.ckrica.Text = "AYAM RICA-RICA [Rp 8.500]";
            this.ckrica.UseVisualStyleBackColor = true;
            this.ckrica.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ckteh
            // 
            this.ckteh.AutoSize = true;
            this.ckteh.Location = new System.Drawing.Point(23, 159);
            this.ckteh.Name = "ckteh";
            this.ckteh.Size = new System.Drawing.Size(155, 17);
            this.ckteh.TabIndex = 6;
            this.ckteh.Text = "ES TEH MANIS [Rp 2.000]";
            this.ckteh.UseVisualStyleBackColor = true;
            this.ckteh.CheckedChanged += new System.EventHandler(this.ckteh_CheckedChanged);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(81, 198);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(120, 23);
            this.btnHitung.TabIndex = 7;
            this.btnHitung.Text = "HITUNG";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(119, 239);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(59, 13);
            this.total.TabIndex = 8;
            this.total.Text = "TOTAL Rp";
            // 
            // txtsop
            // 
            this.txtsop.Location = new System.Drawing.Point(194, 110);
            this.txtsop.Name = "txtsop";
            this.txtsop.Size = new System.Drawing.Size(100, 20);
            this.txtsop.TabIndex = 9;
            // 
            // txtrica
            // 
            this.txtrica.Location = new System.Drawing.Point(194, 136);
            this.txtrica.Name = "txtrica";
            this.txtrica.Size = new System.Drawing.Size(100, 20);
            this.txtrica.TabIndex = 10;
            // 
            // txtteh
            // 
            this.txtteh.Location = new System.Drawing.Point(194, 159);
            this.txtteh.Name = "txtteh";
            this.txtteh.Size = new System.Drawing.Size(100, 20);
            this.txtteh.TabIndex = 11;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(194, 232);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 12;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(122, 16);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(172, 20);
            this.txtnama.TabIndex = 13;
            // 
            // rbYa
            // 
            this.rbYa.AutoSize = true;
            this.rbYa.Location = new System.Drawing.Point(122, 46);
            this.rbYa.Name = "rbYa";
            this.rbYa.Size = new System.Drawing.Size(39, 17);
            this.rbYa.TabIndex = 14;
            this.rbYa.TabStop = true;
            this.rbYa.Text = "YA";
            this.rbYa.UseVisualStyleBackColor = true;
            // 
            // rbTidak
            // 
            this.rbTidak.AutoSize = true;
            this.rbTidak.Location = new System.Drawing.Point(166, 46);
            this.rbTidak.Name = "rbTidak";
            this.rbTidak.Size = new System.Drawing.Size(57, 17);
            this.rbTidak.TabIndex = 15;
            this.rbTidak.TabStop = true;
            this.rbTidak.Text = "TIDAK";
            this.rbTidak.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 261);
            this.Controls.Add(this.rbTidak);
            this.Controls.Add(this.rbYa);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtteh);
            this.Controls.Add(this.txtrica);
            this.Controls.Add(this.txtsop);
            this.Controls.Add(this.total);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.ckteh);
            this.Controls.Add(this.ckrica);
            this.Controls.Add(this.cksop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cksop;
        private System.Windows.Forms.CheckBox ckrica;
        private System.Windows.Forms.CheckBox ckteh;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox txtsop;
        private System.Windows.Forms.TextBox txtrica;
        private System.Windows.Forms.TextBox txtteh;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.RadioButton rbYa;
        private System.Windows.Forms.RadioButton rbTidak;
    }
}

