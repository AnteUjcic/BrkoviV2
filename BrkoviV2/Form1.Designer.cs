namespace BrkoviV2
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
            this.txtPod1 = new System.Windows.Forms.TextBox();
            this.txtPod2 = new System.Windows.Forms.TextBox();
            this.txtPod3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmBoxPod4 = new System.Windows.Forms.ComboBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtPod1
            // 
            this.txtPod1.Location = new System.Drawing.Point(12, 53);
            this.txtPod1.Name = "txtPod1";
            this.txtPod1.Size = new System.Drawing.Size(100, 20);
            this.txtPod1.TabIndex = 0;
            this.txtPod1.TextChanged += new System.EventHandler(this.TxtPod1_TextChanged);
            // 
            // txtPod2
            // 
            this.txtPod2.Location = new System.Drawing.Point(12, 92);
            this.txtPod2.Name = "txtPod2";
            this.txtPod2.Size = new System.Drawing.Size(100, 20);
            this.txtPod2.TabIndex = 1;
            this.txtPod2.TextChanged += new System.EventHandler(this.TxtPod2_TextChanged);
            // 
            // txtPod3
            // 
            this.txtPod3.Location = new System.Drawing.Point(12, 129);
            this.txtPod3.Name = "txtPod3";
            this.txtPod3.Size = new System.Drawing.Size(100, 20);
            this.txtPod3.TabIndex = 2;
            this.txtPod3.TextChanged += new System.EventHandler(this.TxtPod3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "podatak1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "podatak2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "podatak3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "podatak4";
            // 
            // cmBoxPod4
            // 
            this.cmBoxPod4.FormattingEnabled = true;
            this.cmBoxPod4.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.cmBoxPod4.Location = new System.Drawing.Point(12, 168);
            this.cmBoxPod4.Name = "cmBoxPod4";
            this.cmBoxPod4.Size = new System.Drawing.Size(100, 21);
            this.cmBoxPod4.TabIndex = 8;
            this.cmBoxPod4.SelectedIndexChanged += new System.EventHandler(this.CmBoxPod4_SelectedIndexChanged);
            // 
            // btnUnesi
            // 
            this.btnUnesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnUnesi.Location = new System.Drawing.Point(141, 53);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(187, 136);
            this.btnUnesi.TabIndex = 9;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = false;
            this.btnUnesi.Click += new System.EventHandler(this.BtnUnesi_Click);
            // 
            // btnObradi
            // 
            this.btnObradi.BackColor = System.Drawing.Color.Lime;
            this.btnObradi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnObradi.Location = new System.Drawing.Point(345, 53);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(187, 136);
            this.btnObradi.TabIndex = 10;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = false;
            this.btnObradi.Click += new System.EventHandler(this.BtnObradi_Click);
            // 
            // btnIspisi
            // 
            this.btnIspisi.BackColor = System.Drawing.Color.Aqua;
            this.btnIspisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnIspisi.Location = new System.Drawing.Point(549, 53);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(187, 136);
            this.btnIspisi.TabIndex = 11;
            this.btnIspisi.Text = "Ispisi";
            this.btnIspisi.UseVisualStyleBackColor = false;
            this.btnIspisi.Click += new System.EventHandler(this.BtnIspisi_Click);
            // 
            // rtbIspis
            // 
            this.rtbIspis.Location = new System.Drawing.Point(12, 196);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(724, 242);
            this.rtbIspis.TabIndex = 12;
            this.rtbIspis.Text = "";
            this.rtbIspis.TextChanged += new System.EventHandler(this.RtbIspis_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbIspis);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnObradi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.cmBoxPod4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPod3);
            this.Controls.Add(this.txtPod2);
            this.Controls.Add(this.txtPod1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPod1;
        private System.Windows.Forms.TextBox txtPod2;
        private System.Windows.Forms.TextBox txtPod3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmBoxPod4;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.RichTextBox rtbIspis;
    }
}

