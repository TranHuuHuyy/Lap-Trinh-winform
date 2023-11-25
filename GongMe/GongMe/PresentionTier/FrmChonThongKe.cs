using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GongMe.PresentionTier
{
    public partial class FrmChonThongKe : Form
    {
        public FrmChonThongKe()
        {
            InitializeComponent();
        }

        //ChildForm
        private Form currentFromChild;
        private void OpenChildFormTK(Form childForm)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            currentFromChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChild.Controls.Add(childForm);
            pnlChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnTKDoanhThu_Click(object sender, EventArgs e)
        {
            //Form con thống kê doanh thu
            OpenChildFormTK(new FrmThongKe());

            btnTKDoanhThu.FillColor = Color.DeepSkyBlue;
            btnTKDoanhThu.FillColor2 = Color.DeepSkyBlue;

            btnTKTonKho.FillColor = Color.RoyalBlue;
            btnTKTonKho.FillColor2 = Color.RoyalBlue;

            btnTKNhapHang.FillColor = Color.RoyalBlue;
            btnTKNhapHang.FillColor2 = Color.RoyalBlue;

            btnTKXuatHang.FillColor = Color.RoyalBlue;
            btnTKXuatHang.FillColor2 = Color.RoyalBlue;
        }

        private void btnTKTonKho_Click(object sender, EventArgs e)
        {
            //Form con thống kê tồn kho
            OpenChildFormTK(new FrmThongKeTonKho());

            btnTKDoanhThu.FillColor = Color.RoyalBlue;
            btnTKDoanhThu.FillColor2 = Color.RoyalBlue;

            btnTKTonKho.FillColor = Color.DeepSkyBlue;
            btnTKTonKho.FillColor2 = Color.DeepSkyBlue;

            btnTKNhapHang.FillColor = Color.RoyalBlue;
            btnTKNhapHang.FillColor2 = Color.RoyalBlue;

            btnTKXuatHang.FillColor = Color.RoyalBlue;
            btnTKXuatHang.FillColor2 = Color.RoyalBlue;
        }

        private void btnTKNhapHang_Click(object sender, EventArgs e)
        {
            //Form con thống kê tồn kho
            OpenChildFormTK(new FrmThongKeNhapHang());

            btnTKDoanhThu.FillColor = Color.RoyalBlue;
            btnTKDoanhThu.FillColor2 = Color.RoyalBlue;

            btnTKTonKho.FillColor = Color.RoyalBlue;
            btnTKTonKho.FillColor2 = Color.RoyalBlue;

            btnTKNhapHang.FillColor = Color.DeepSkyBlue;
            btnTKNhapHang.FillColor2 = Color.DeepSkyBlue;

            btnTKXuatHang.FillColor = Color.RoyalBlue;
            btnTKXuatHang.FillColor2 = Color.RoyalBlue;
        }

        private void btnTKXuatHang_Click(object sender, EventArgs e)
        {
            //Form con thống kê tồn kho
            OpenChildFormTK(new FrmThongKeXuatHang());

            btnTKDoanhThu.FillColor = Color.RoyalBlue;
            btnTKDoanhThu.FillColor2 = Color.RoyalBlue;

            btnTKTonKho.FillColor = Color.RoyalBlue;
            btnTKTonKho.FillColor2 = Color.RoyalBlue;

            btnTKNhapHang.FillColor = Color.RoyalBlue;
            btnTKNhapHang.FillColor2 = Color.RoyalBlue;

            btnTKXuatHang.FillColor = Color.DeepSkyBlue;
            btnTKXuatHang.FillColor2 = Color.DeepSkyBlue;
        }
    }
}
