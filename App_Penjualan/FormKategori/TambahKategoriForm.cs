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

namespace App_Penjualan.FormKategori
{
    public partial class TambahKategoriForm : BaseTambah
    {
        public TambahKategoriForm()
        {
            InitializeComponent();
            LabelJudulUbahtambah.Text = "Tambah Data Kategori";
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            //Kondisi apabila textbox kosong pada kode kategori
            if (string.IsNullOrWhiteSpace(textBoxKodeKategori.Text))
            {
                MessageBox.Show("Kolom Kode Kategori belum diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Kondisi apabila textbox kosong pada nama kategori
            if (string.IsNullOrWhiteSpace(textBoxNamaKategori.Text))
            {
                MessageBox.Show("Kolom Nama Kategori belum diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FIK5SPH\\SQLEXPRESS;Initial Catalog=penjualan_db;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_Kategori values (@KodeKategori,@NamaKategori,@Keterangan)", con);
            cmd.Parameters.AddWithValue("@KodeKategori", int.Parse(textBoxKodeKategori.Text));
            cmd.Parameters.AddWithValue("@NamaKategori", (textBoxNamaKategori.Text));
            cmd.Parameters.AddWithValue("@Keterangan", (textBoxKeterangan.Text));

            //cmd.Parameters.AddWithValue("@Harga", (textBoxKodeBarang.Text));
            //cmd.Parameters.AddWithValue("@Stock", int.Parse(textBoxKodeBarang.Text));
            //cmd.Parameters.AddWithValue("@Keterangan", (textBoxKodeBarang.Text));

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Succesfully Added");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            DaftarKategoriForm frm = new DaftarKategoriForm();
            frm.Show();
        }

        private void LabelJudulUbahtambah_Click(object sender, EventArgs e)
        {

        }
    }
}
