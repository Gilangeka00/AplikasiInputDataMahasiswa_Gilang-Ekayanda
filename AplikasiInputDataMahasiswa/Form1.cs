using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiInputDataMahasiswa
{
    public partial class Form1 : Form
    {
        private List<Mahasiswa> list = new List<Mahasiswa>();
        public Form1()
        {
            InitializeComponent();
            InisialisasiListView();
        }
        private void InisialisasiListView()
        {
            lvwMahasiswa.View = View.Details;
            lvwMahasiswa.FullRowSelect = true;
            lvwMahasiswa.GridLines = true;
            lvwMahasiswa.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nim", 91, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nama", 200, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Kelas", 70, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nilai", 50, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nilai Huruf", 80, HorizontalAlignment.Center);
        }
        private void ResetForm()
        {
            txtnim.Clear();
            txtnama.Clear();
            txtkelas.Clear();
            txtnilai.Text = "0";
            txtnim.Focus();
        }
        private void lvwmahasiswa_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private bool NumericOnly(KeyPressEventArgs e)
        {
            var strValid = "0123456789";
            if (!(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                // inputan selain angka
                if (strValid.IndexOf(e.KeyChar) < 0)
                {
                    return true;
                }
                return false;
            }
            else
                return false;
        }

        private void txtnilai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumericOnly(e);
        }

        private void txtnilai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            // membuat objek mahasiswa
            Mahasiswa mhs = new Mahasiswa();
            // set nilai masing-masing propertynya
            // berdasarkan inputan yang ada di form
            mhs.nim = txtnim.Text;
            mhs.nama = txtnama.Text;
            mhs.kelas = txtkelas.Text;
            mhs.nilai = int.Parse(txtnilai.Text);
            // tambahkan objek mahasiswa ke dalam collection
            list.Add(mhs);
            var msg = "Data mahasiswa berhasil disimpan.";
            // tampilkan dialog informasi
            MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            // reset form input

            if (mhs.nilai >= 0 && mhs.nilai <= 20)
            {
                mhs.huruf = "E";
            }
            else if (mhs.nilai >= 21 && mhs.nilai <= 40)
            {
                mhs.huruf = "D";
            }
            else if (mhs.nilai >= 41 && mhs.nilai <= 60)
            {
                mhs.huruf = "C";
            }
            else if (mhs.nilai >= 61 && mhs.nilai <= 80)
            {
                mhs.huruf = "B";
            }
            else if (mhs.nilai >= 81 && mhs.nilai <= 100)
            {
                mhs.huruf = "A";
            }
            else 
            {
                mhs.huruf = "###";
            }

            ResetForm();
        }

        private void TampilkanData()
        {
            // kosongkan data listview
            lvwMahasiswa.Items.Clear();
            // lakukan perulangan untuk menampilkan data mahasiswa ke listview
            foreach (var mhs in list)
            {
                var noUrut = lvwMahasiswa.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mhs.nim);
                item.SubItems.Add(mhs.nama);
                item.SubItems.Add(mhs.kelas);
                item.SubItems.Add(mhs.nilai.ToString());
                item.SubItems.Add(mhs.huruf);
                lvwMahasiswa.Items.Add(item);
            }
        }

        private void btntampilkandata_Click(object sender, EventArgs e)
        {
            TampilkanData();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            // cek apakah data mahasiswa sudah dipilih
            if (lvwMahasiswa.SelectedItems.Count > 0)
            {
                // tampilkan konfirmasi
                var konfirmasi = MessageBox.Show("Apakah data mahasiswa ingin dihapus ? ", "Konfirmasi",
               
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil index list yang di pilih
                    var index = lvwMahasiswa.SelectedIndices[0];
                    // hapus objek mahasiswa dari list
                    list.RemoveAt(index);
                    // refresh tampilan listivew
                    TampilkanData();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data mahasiswa belum dipilih !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
