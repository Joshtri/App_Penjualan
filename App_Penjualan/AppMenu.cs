using App_Penjualan.FormBarang;
using App_Penjualan.FormKategori;
using App_Penjualan.FormPenjualan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Penjualan
{
    public partial class AppMenu : Form
    {
        private DaftarBarangForm daftarBarangForm;
        private DaftarKategoriForm daftarKategoriForm;
        private MenuPenjualanForm menuPenjualanForm;
        public AppMenu()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg,
                                    IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TitleBars_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, (IntPtr)0);
            }
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString(@"hh:mm:ss");
            //Dates.Text = DateTime.Now.ToString(@"ddd,dd:MM:yyyy");
        }

        private void button_dataBarang_Click(object sender, EventArgs e)
        {
            if (daftarBarangForm == null || daftarBarangForm.IsDisposed)
            {
                daftarBarangForm = new DaftarBarangForm();
            }



            daftarBarangForm.Show();
            daftarBarangForm.BringToFront();
            Hide();

        }

        private void button_dataKategori_Click(object sender, EventArgs e)
        {
            if (daftarKategoriForm == null || daftarKategoriForm.IsDisposed)
            {
                daftarKategoriForm = new DaftarKategoriForm();
            }



            daftarKategoriForm.Show();
            daftarKategoriForm.BringToFront();
            Hide();
        }

        private void button_MenuPenjualan_Click(object sender, EventArgs e)
        {
            if (menuPenjualanForm == null || menuPenjualanForm.IsDisposed)
            {
                menuPenjualanForm = new MenuPenjualanForm();
            }



            menuPenjualanForm.Show();
            menuPenjualanForm.BringToFront();
            //Close();
        }

        private void Clock_Click(object sender, EventArgs e)
        {

        }
    }
}
