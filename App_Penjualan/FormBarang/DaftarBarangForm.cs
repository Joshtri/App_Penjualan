using App_Penjualan.Base;
using App_Penjualan.FormPenjualan;
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
    public partial class DaftarBarangForm : BaseForm
    {
        TambahBarangForm tambahBarangForm = new TambahBarangForm();
        public DaftarBarangForm()
        {
            InitializeComponent();
            labelJudul.Text = "Daftar Barang";
        }

        private void ShowData()
        {

            SqlConnection connecting = new SqlConnection("Data Source=DESKTOP-FIK5SPH\\SQLEXPRESS;Initial Catalog=penjualan_db;Integrated Security=True");
            connecting.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_Barang", connecting);

            SqlDataAdapter AdapterDate = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            AdapterDate.Fill(dt);
            BaseFormdataGridViewData.DataSource = dt;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = searchTextBox.Text;

            // Buat koneksi database
            string connectionString = "Data Source=DESKTOP-FIK5SPH\\SQLEXPRESS;Initial Catalog=penjualan_db;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Buat query pencarian
            string query = "SELECT * FROM Table_Barang WHERE NamaBarang LIKE '%' + @NamaBarang + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NamaBarang", keyword);

            // Eksekusi query
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Data tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Tampilkan hasil pencarian di DataGridView
                BaseFormdataGridViewData.DataSource = dataTable;
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (tambahBarangForm == null || tambahBarangForm.IsDisposed)
            {
                tambahBarangForm = new TambahBarangForm();
            }



            tambahBarangForm.Show();
            tambahBarangForm.BringToFront();
            Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            AppMenu frm = new AppMenu();
            frm.Show();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                // Konfirmasi penghapusan data
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Dapatkan baris yang dipilih dalam DataGridView
                    DataGridViewRow selectedRow = BaseFormdataGridViewData.SelectedRows[0];

                    // Dapatkan nilai kunci utama (primary key) dari baris tersebut
                    int primaryKey = Convert.ToInt32(selectedRow.Cells["KodeBarang"].Value); // Ganti "PrimaryKeyColumnName" dengan nama kolom kunci utama yang sesuai di tabel Anda

                    // Hapus data dari database
                    string query = "DELETE FROM Table_Barang WHERE KodeBarang = @KodeBarang"; // Ganti "Table_Name" dan "PrimaryKeyColumnName" sesuai dengan tabel dan kolom kunci utama Anda
                    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FIK5SPH\\SQLEXPRESS;Initial Catalog=penjualan_db;Integrated Security=True"))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@KodeBarang", primaryKey);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    // Hapus baris dari DataGridView
                    BaseFormdataGridViewData.Rows.Remove(selectedRow);

                    // Tampilkan pesan berhasil
                    MessageBox.Show("Data berhasil dihapus.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Pilih baris yang ingin dihapus terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                // Dapatkan baris yang dipilih dalam DataGridView
                DataGridViewRow selectedRow = BaseFormdataGridViewData.SelectedRows[0];

                // Dapatkan nilai kunci utama (primary key) dari baris tersebut
                int primaryKey = Convert.ToInt32(selectedRow.Cells["KodeBarang"].Value); // Ganti "PrimaryKeyColumnName" dengan nama kolom kunci utama yang sesuai di tabel Anda

                // Update data dalam database
                string query = "UPDATE Table_Barang SET KodeBarang = @KodeBarang, NamaBarang = @NamaBarang, KodeKategori = @KodeKategori, Harga = @Harga, Stock = @Stock, Keterangan = @Keterangan WHERE KodeKategori = @KodeKategori"; // Ganti "Table_Name", "Column_Name", dan "PrimaryKeyColumnName" sesuai dengan tabel, kolom, dan kunci utama Anda
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FIK5SPH\\SQLEXPRESS;Initial Catalog=penjualan_db;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Dapatkan nilai baru dari sel yang dipilih dalam DataGridView
                        string namaBarangNewValue = selectedRow.Cells["NamaBarang"].Value.ToString(); // Ganti "Column_Name" dengan nama kolom yang sesuai di DataGridView
                        string kodeKategoriNewValue = selectedRow.Cells["KodeKategori"].Value.ToString(); // Ganti "Column_Name" dengan nama kolom yang sesuai di DataGridView
                        string hargaNewValue = selectedRow.Cells["Harga"].Value.ToString(); // Ganti "Column_Name" dengan nama kolom yang sesuai di DataGridView
                        string stockKategoriNewValue = selectedRow.Cells["Stock"].Value.ToString(); // Ganti "Column_Name" dengan nama kolom yang sesuai di DataGridView
                        string keteranganNewValue = selectedRow.Cells["Keterangan"].Value.ToString(); // Ganti "Column_Name" dengan nama kolom yang sesuai di DataGridView

                        command.Parameters.AddWithValue("@NamaBarang", namaBarangNewValue);
                        command.Parameters.AddWithValue("@KodeKategori", kodeKategoriNewValue);
                        command.Parameters.AddWithValue("@Harga", hargaNewValue);
                        command.Parameters.AddWithValue("@Stock", stockKategoriNewValue);
                        command.Parameters.AddWithValue("@Keterangan", keteranganNewValue);
                        command.Parameters.AddWithValue("@KodeBarang", primaryKey);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                // Tampilkan pesan berhasil
                MessageBox.Show("Data berhasil diubah.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
