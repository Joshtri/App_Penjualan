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

namespace App_Penjualan
{
    public partial class Login_View : Form
    {
        public Login_View()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = PasswordTextBox.Text;

            // Konfigurasi koneksi ke database
            string connectionString = "Data Source=DESKTOP-FIK5SPH\\SQLEXPRESS;Initial Catalog=penjualan_db;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                // Query untuk memeriksa username dan password di tabel pengguna
                string query = "SELECT COUNT(*) FROM Admin WHERE username = @Username AND password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Login berhasil.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Lanjutkan ke form utama atau tampilkan menu admin
                    // Misalnya:
                    Hide();
                    AppMenu mainForm = new AppMenu();
                    mainForm.Show();


                }
                else
                {
                    // Cek kondisi username dan password
                    bool isUsernameValid = CheckUsername(username);
                    bool isPasswordValid = CheckPassword(password);

                    if (!isUsernameValid)
                    {
                        MessageBox.Show("Username salah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!isPasswordValid)
                    {
                        MessageBox.Show("Password salah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Username dan password salah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        // Fungsi untuk memeriksa validitas username
        private bool CheckUsername(string username)
        {
            // Implementasikan logika validasi username sesuai kebutuhan
            // Misalnya, memeriksa panjang minimum, karakter yang diperbolehkan, dll.
            return !string.IsNullOrWhiteSpace(username);
        }

        // Fungsi untuk memeriksa validitas password
        private bool CheckPassword(string password)
        {
            // Implementasikan logika validasi password sesuai kebutuhan
            // Misalnya, memeriksa panjang minimum, karakter yang diperbolehkan, dll.
            return !string.IsNullOrWhiteSpace(password);
        }
    }
}
