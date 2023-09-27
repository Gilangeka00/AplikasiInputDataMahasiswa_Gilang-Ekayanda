namespace AplikasiInputDataMahasiswa
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
            this.txtnim = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtkelas = new System.Windows.Forms.TextBox();
            this.txtnilai = new System.Windows.Forms.TextBox();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btntampilkandata = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwMahasiswa = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nilai";
            // 
            // txtnim
            // 
            this.txtnim.Location = new System.Drawing.Point(97, 69);
            this.txtnim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnim.Name = "txtnim";
            this.txtnim.Size = new System.Drawing.Size(263, 22);
            this.txtnim.TabIndex = 4;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(97, 110);
            this.txtnama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(263, 22);
            this.txtnama.TabIndex = 5;
            // 
            // txtkelas
            // 
            this.txtkelas.Location = new System.Drawing.Point(97, 149);
            this.txtkelas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtkelas.Name = "txtkelas";
            this.txtkelas.Size = new System.Drawing.Size(263, 22);
            this.txtkelas.TabIndex = 6;
            // 
            // txtnilai
            // 
            this.txtnilai.Location = new System.Drawing.Point(97, 194);
            this.txtnilai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnilai.Name = "txtnilai";
            this.txtnilai.Size = new System.Drawing.Size(263, 22);
            this.txtnilai.TabIndex = 7;
            this.txtnilai.TextChanged += new System.EventHandler(this.txtnilai_TextChanged);
            this.txtnilai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnilai_KeyPress);
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(97, 241);
            this.btnsimpan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(100, 28);
            this.btnsimpan.TabIndex = 8;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(205, 241);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(100, 28);
            this.btnreset.TabIndex = 9;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btntampilkandata
            // 
            this.btntampilkandata.Location = new System.Drawing.Point(489, 103);
            this.btntampilkandata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntampilkandata.Name = "btntampilkandata";
            this.btntampilkandata.Size = new System.Drawing.Size(124, 28);
            this.btntampilkandata.TabIndex = 10;
            this.btntampilkandata.Text = "Tampilkan data";
            this.btntampilkandata.UseVisualStyleBackColor = true;
            this.btntampilkandata.Click += new System.EventHandler(this.btntampilkandata_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(621, 103);
            this.btnhapus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(100, 28);
            this.btnhapus.TabIndex = 11;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwMahasiswa);
            this.groupBox1.Location = new System.Drawing.Point(479, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(785, 546);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar mahasiswa";
            // 
            // lvwMahasiswa
            // 
            this.lvwMahasiswa.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwMahasiswa.HideSelection = false;
            this.lvwMahasiswa.HoverSelection = true;
            this.lvwMahasiswa.Location = new System.Drawing.Point(8, 102);
            this.lvwMahasiswa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwMahasiswa.Name = "lvwMahasiswa";
            this.lvwMahasiswa.Size = new System.Drawing.Size(768, 415);
            this.lvwMahasiswa.TabIndex = 0;
            this.lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            this.lvwMahasiswa.SelectedIndexChanged += new System.EventHandler(this.lvwmahasiswa_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 686);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btntampilkandata);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.txtnilai);
            this.Controls.Add(this.txtkelas);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtnim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "AplikasiInputDataMahasiswa";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnim;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtkelas;
        private System.Windows.Forms.TextBox txtnilai;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btntampilkandata;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwMahasiswa;
    }
}

