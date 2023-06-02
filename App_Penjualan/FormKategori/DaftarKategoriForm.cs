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
    public partial class DaftarKategoriForm : BaseForm
    {
        TambahKategoriForm tambahKategoriForm = new TambahKategoriForm();
        public DaftarKategoriForm()
        {
            InitializeComponent();
            labelJudul.Text = "Data Kategori";
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (tambahKategoriForm == null || tambahKategoriForm.IsDisposed)
            {
                tambahKategoriForm = new TambahKategoriForm();
            }

            tambahKategoriForm.Show();
            tambahKategoriForm.BringToFront();
            Hide();
        }

        private void ShowData()
        {

            SqlConnection connecting = new SqlConnection("Data Source=DESKTOP-FIK5SPH\\SQLEXPRESS;Initial Catalog=penjualan_db;Integrated Security=True");
            connecting.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_Kategori", connecting);

            SqlDataAdapter AdapterDate = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            AdapterDate.Fill(dt);
            BaseFormdataGridViewData.DataSource = dt;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            AppMenu frm = new AppMenu();
            frm.Show();
        }

        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
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
                    int primaryKey = Convert.ToInt32(selectedRow.Cells["KodeKategori"].Value); // Ganti "PrimaryKeyColumnName" dengan nama kolom kunci utama yang sesuai di tabel Anda

                    // Hapus data dari database
                    string query = "DELETE FROM Table_Kategori WHERE KodeKategori = @KodeKategori"; // Ganti "Table_Name" dan "PrimaryKeyColumnName" sesuai dengan tabel dan kolom kunci utama Anda
                    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FIK5SPH\\SQLEXPRESS;Initial Catalog=penjualan_db;Integrated Security=True"))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@KodeKategori", primaryKey);

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
                int primaryKey = Convert.ToInt32(selectedRow.Cells["KodeKategori"].Value); // Ganti "PrimaryKeyColumnName" dengan nama kolom kunci utama yang sesuai di tabel Anda

                // Update data dalam database
                string query = "UPDATE Table_Kategori SET NamaKategori = @NamaKategori, Keterangan = @Keterangan WHERE KodeKategori = @KodeKategori"; // Ganti "Table_Name", "Column_Name", dan "PrimaryKeyColumnName" sesuai dengan tabel, kolom, dan kunci utama Anda
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FIK5SPH\\SQLEXPRESS;Initial Catalog=penjualan_db;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Dapatkan nilai baru dari sel yang dipilih dalam DataGridView
                        string namaKategoriNewValue = selectedRow.Cells["NamaKategori"].Value.ToString(); // Ganti "Column_Name" dengan nama kolom yang sesuai di DataGridView
                        string keteranganNewValue = selectedRow.Cells["Keterangan"].Value.ToString(); // Ganti "Column_Name" dengan nama kolom yang sesuai di DataGridView

                        command.Parameters.AddWithValue("@NamaKategori", namaKategoriNewValue);
                        command.Parameters.AddWithValue("@Keterangan", keteranganNewValue);
                        command.Parameters.AddWithValue("@KodeKategori", primaryKey);

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
