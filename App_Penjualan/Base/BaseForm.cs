using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Penjualan.Base
{
    public partial class BaseForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        AppMenu mainMenu = new AppMenu();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg,
                                    IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public BaseForm()
        {
            InitializeComponent();
        }

        public  void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString(@"hh:mm:ss");
        }

        private void TitleBars_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, (IntPtr)0);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void Clock_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BaseFormdataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mendapatkan indeks baris yang di klik
            int rowIndex = e.RowIndex;

            // Mendapatkan nilai ID dari kolom pertama (kolom ID) pada baris yang di klik
            int id = Convert.ToInt32(BaseFormdataGridViewData.Rows[rowIndex].Cells[0].Value);

            // Menandai baris yang di klik dengan warna yang berbeda
            BaseFormdataGridViewData.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Yellow;

            // Menyimpan ID yang akan dihapus ke variabel global
            int selectedID = id;
        }
    }
}
