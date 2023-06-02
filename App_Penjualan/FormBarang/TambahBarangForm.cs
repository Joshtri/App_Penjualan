using App_Penjualan.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Penjualan.FormBarang
{
    public partial class TambahBarangForm : BaseTambah
    {
        public TambahBarangForm()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            //Kondisi apabila textbox kosong pada nama barang
            if (string.IsNullOrWhiteSpace(textBoxNamaBarang.Text))
            {
                MessageBox.Show("Kolom Nama Barang belum diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Kondisi apabila textbox kosong pada Harga Barang
            if (string.IsNullOrWhiteSpace(textBoxHarga.Text))
            {
                MessageBox.Show("Kolom Harga Barang belum diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Kondisi apabila textbox kosong pada Stock Barang
            if (string.IsNullOrWhiteSpace(textBoxStock.Text))
            {
                MessageBox.Show("Kolom Stock Barang belum diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Kondisi apabila textbox kosong pada nama Keterangan
            if (string.IsNullOrWhiteSpace(textBoxKeterangan.Text))
            {
                MessageBox.Show("Kolom Keterangan Barang belum diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Kondisi apabila textbox kosong pada Kategori Barang
            if (string.IsNullOrWhiteSpace(textBoxKategori.Text))
            {
                MessageBox.Show("Kolom Kategori Barang belum diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Kondisi apabila textbox kosong pada Kode Barang
            if (string.IsNullOrWhiteSpace(textBoxKodeBarang.Text))
            {
                MessageBox.Show("Kolom Kode Barang belum diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FIK5SPH\\SQLEXPRESS;Initial Catalog=penjualan_db;Integrated Security=True");

            con.Open();

            // Cek apakah data kode barang sudah ada di database
            SqlCommand checkCommandKodeBarang = new SqlCommand("SELECT COUNT(*) FROM Table_Barang WHERE KodeBarang = @KodeBarang", con);
            checkCommandKodeBarang.Parameters.AddWithValue("@KodeBarang", int.Parse(textBoxKodeBarang.Text));

            int count1 = (int)checkCommandKodeBarang.ExecuteScalar();

            // Cek apakah data nama barang sudah ada di database
            SqlCommand checkCommandNamaBarang = new SqlCommand("SELECT COUNT(*) FROM Table_Barang WHERE NamaBarang = @NamaBarang", con);
            checkCommandNamaBarang.Parameters.AddWithValue("@NamaBarang", (textBoxNamaBarang.Text));
            int count2 = (int)checkCommandNamaBarang.ExecuteScalar();



            if (count1 > 0)
            {
                MessageBox.Show(this,$"Kode barang {textBoxKodeBarang.Text} sudah ada di database.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
                return;
            }

            if (count2 > 0)
            {
                MessageBox.Show(this,$"Data Nama barang {textBoxNamaBarang.Text} sudah ada di database.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
                return;
            }




            SqlCommand cmd = new SqlCommand("insert into Table_Barang values (@KodeBarang,@NamaBarang,@KodeKategori,@Harga,@Stock,@Keterangan)", con);

            cmd.Parameters.AddWithValue("@KodeBarang", int.Parse(textBoxKodeBarang.Text));
            cmd.Parameters.AddWithValue("@NamaBarang", (textBoxKodeBarang.Text));
            cmd.Parameters.AddWithValue("@KodeKategori", (textBoxKodeBarang.Text));

            cmd.Parameters.AddWithValue("@Harga", (textBoxKodeBarang.Text));
            cmd.Parameters.AddWithValue("@Stock", int.Parse(textBoxKodeBarang.Text));
            cmd.Parameters.AddWithValue("@Keterangan", (textBoxKodeBarang.Text));

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Telah Terkirim");

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            DaftarBarangForm frm = new DaftarBarangForm();
            frm.Show();
        }
    }
}
