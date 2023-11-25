using GongMe.BusinessTier;
using GongMe.DataTier.Models;
using GongMe.PresentionTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GongMe
{
    public partial class FrmTraSuaGongMe : Form
    {
        string MACHUCVU = "";
        string MANHANVIEN;
        string user = "", HOTEN = "";

        public FrmTraSuaGongMe()
        {
            InitializeComponent();
        }

        public FrmTraSuaGongMe(string MACHUCVU, string MANHANVIEN, string user, string HOTEN)
        {
            InitializeComponent();
            this.MACHUCVU = MACHUCVU;
            this.MANHANVIEN = MANHANVIEN;
            this.user = user;
            this.HOTEN = HOTEN;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            //Form con hóa đơn
            OpenChildForm(new FrmHoaDon(MACHUCVU));
            labelTop.Text = btnHoaDon.Text;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            //Form con thống kê
            OpenChildForm(new FrmChonThongKe());
            labelTop.Text = btnThongKe.Text;  
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            //Form con nhân viên
            OpenChildForm(new FrmNhanVien());
            labelTop.Text = btnNhanVien.Text;
        }

        private void FrmTraSuaGongMe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnQuanLy_Click_1(object sender, EventArgs e)
        {
            //Form con quản lý bàn
            OpenChildForm(new FrmQuanLyBan(MANHANVIEN));
            labelTop.Text = btnQuanLy.Text;
        }

        //ChildForm
        private Form currentFromChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFromChild != null)
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

        private void linkTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmTaiKhoan f = new FrmTaiKhoan(user);
            f.ShowDialog();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            labelTop.Text = "HOME";
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FrmDangNhap f = new FrmDangNhap();
            f.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuanLyMon_Click(object sender, EventArgs e)
        {
            //Form con quản lý món
            OpenChildForm(new FrmQuanLyMon());
            labelTop.Text = btnQuanLyMon.Text;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            //Form con nhập hàng
            OpenChildForm(new FrmNhapHang());
            labelTop.Text = btnNhapHang.Text;
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            //Form con xuất hàng
            OpenChildForm(new FrmXuatHang());
            labelTop.Text = btnXuatHang.Text;
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            //Form con chấm công
            OpenChildForm(new FrmChamCong(MANHANVIEN,HOTEN));
            labelTop.Text = btnChamCong.Text;
        }

        private void FrmTraSuaGongMe_Load(object sender, EventArgs e)
        {
            //Phân quyền truy cập
            if (MACHUCVU == "NV")
            {
                lbOnlineUser.Text = "[Nhân viên]  " + HOTEN; //Hiển thị chức vụ + tên nhân viên

                btnQuanLy.Visible = true;
                btnHoaDon.Visible = false;
                btnThongKe.Visible = false;
                btnNhanVien.Visible = false;
                btnQuanLyMon.Visible = false;
                btnNhapHang.Visible = false;
                btnXuatHang.Visible = false;
            }
            else
            {
                if (MACHUCVU == "PC")
                {
                    lbOnlineUser.Text = "[Pha chế]  " + HOTEN; //Hiển thị chức vụ + tên pha chế

                    btnQuanLy.Visible = true;
                    btnHoaDon.Visible = false;
                    btnThongKe.Visible = false;
                    btnNhanVien.Visible = false;
                    btnQuanLyMon.Visible = false;
                    btnNhapHang.Visible = false;
                    btnXuatHang.Visible = false;
                }
                else
                {
                    if (MACHUCVU == "TN")
                    {
                        lbOnlineUser.Text = "[Thu ngân]  " + HOTEN; //Hiển thị chức vụ + tên thu ngân

                        btnQuanLy.Visible = true;
                        btnHoaDon.Visible = false;
                        btnThongKe.Visible = false;
                        btnNhanVien.Visible = false;
                        btnQuanLyMon.Visible = false;
                        btnNhapHang.Visible = false;
                        btnXuatHang.Visible = false;
                    }    
                    else
                    {
                        if (MACHUCVU == "KT")
                        {
                            lbOnlineUser.Text = "[Kế toán]  " + HOTEN; //Hiển thị chức vụ + tên kế toán

                            btnQuanLy.Visible = true;
                            btnHoaDon.Visible = true;
                            btnThongKe.Visible = true;
                            btnNhanVien.Visible = false;
                            btnQuanLyMon.Visible = false;
                            btnNhapHang.Visible = true;
                            btnXuatHang.Visible = true;

                            btnNhapHang.Location = new Point(10, 249);
                            btnXuatHang.Location = new Point(10, 309);
                        }
                        else
                        {
                            lbOnlineUser.Text = "[Quản lý]  " + HOTEN; //Hiển thị chức vụ + tên quản lý

                            btnQuanLy.Visible = true;
                            btnHoaDon.Visible = true;
                            btnThongKe.Visible = true;
                            btnNhanVien.Visible = true;
                            btnQuanLyMon.Visible = true;
                            btnNhapHang.Visible = true;
                            btnXuatHang.Visible = true;
                        }
                    }    
                }    
            }
        }
    }
}
