using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations.Model;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GongMe.PresentionTier
{
    public partial class FrmChamCong : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DANGKHOABACH;Initial Catalog=QLTiemTraSua;Integrated Security=True");

        int month, year;

        string MaNhanVien = "", HoTen = "";

        public FrmChamCong()
        {
            InitializeComponent();
        }
        public FrmChamCong(string MaNhanVien, string HoTen)
        {
            InitializeComponent();
            this.MaNhanVien = MaNhanVien;
            this.HoTen = HoTen;
        }

        private void FrmChamCong_Load(object sender, EventArgs e)
        {
            displayDays(); //Lịch

            timer1.Start();

            lbOnlineUser.Text = HoTen; //Đang hoạt động

            userstatus(); //Trạng thái chấm công
        }

        //Hiển thị trạng thái chấm công
        private void userstatus()
        {
            String querryTrangThai = "SELECT *FROM ChamCong WHERE (MaNhanVien = '" + MaNhanVien + "' AND NgayChamCong = '" + DateTime.Now.ToString("MM/dd/yyyy") + "' )";
            SqlDataAdapter sdaTrangThai = new SqlDataAdapter(querryTrangThai, conn);

            DataTable dtableTrangThai = new DataTable();
            sdaTrangThai.Fill(dtableTrangThai);

            try
            {

                if (dtableTrangThai.Rows[0][4].ToString().Trim() == null)
                {
                    lbUserStatus.Text = "Chưa chấm công"; //Trạng thái
                }
                else
                {
                    lbUserStatus.Text = dtableTrangThai.Rows[0][4].ToString().Trim(); //Trạng thái
                }
            }
            catch (Exception ex)
            {
                /*MessageBox.Show(ex.Message);*/
            }
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDate.Text = monthname + " " + year;

            //Lấy ngày bắt đầu của tháng
            DateTime batdauthang = new DateTime(year,month,1);

            //Lấy số ngày trong tháng
            int days = DateTime.DaysInMonth(year,month);

            //Convert batdauthang thành int
            int ngaytrongtuan = Convert.ToInt32(batdauthang.DayOfWeek.ToString("d"));

            //user control trống
            for (int i = 1; i < ngaytrongtuan; i++)
            {
                UCBlank ucblank = new UCBlank();
                flpnlCalendar.Controls.Add(ucblank);
            }

            //user control ngày
            for (int i = 1; i <= days; i++)
            {
                UCCalendar uccalendar = new UCCalendar();
                uccalendar.days(i);
                flpnlCalendar.Controls.Add(uccalendar);

                //Hiển thị trạng thái theo ngày
                String querrystatus = "SELECT *FROM ChamCong WHERE (MaNhanVien = '" + MaNhanVien + "' AND NgayChamCong = '" + year + "/" + month + "/" + i + "')";
                SqlDataAdapter sdastatus = new SqlDataAdapter(querrystatus, conn);

                DataTable dtablestatus = new DataTable();
                sdastatus.Fill(dtablestatus);

                try
                {
                    uccalendar.trangthai(dtablestatus.Rows[0][4].ToString().Trim());
                }
                catch
                {
                    uccalendar.trangthai("");
                }
            }
        }

        //Hiển thị ngày giờ hôm nay
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            lbtoday.Text = DateTime.Now.ToShortDateString();
        }

        //Check In
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmdcheckin = new SqlCommand("INSERT INTO [dbo].[ChamCong] ([MaNhanVien], [NgayChamCong], [CheckIn], [TrangThai]) VALUES('" + MaNhanVien + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + DateTime.Now.ToLongTimeString() + "', '" + "Đã check in" + "')", conn);
            cmdcheckin.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Check in thành công lúc " + DateTime.Now.ToLongTimeString() + " ngày " + DateTime.Now.ToShortDateString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            userstatus(); //Load lại trạng thái
        }

        //Check Out
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            SqlCommand cmdcheckout = new SqlCommand("UPDATE [dbo].[ChamCong] SET [CheckOut] = '" + DateTime.Now.ToLongTimeString() + "', [TrangThai] = '" + "Hoàn thành" + "' WHERE [NgayChamCong] = '"+ DateTime.Now.ToString("MM/dd/yyyy") + "'", conn);
            conn.Open();
            cmdcheckout.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Check out thành công lúc " + DateTime.Now.ToLongTimeString() + " ngày " + DateTime.Now.ToShortDateString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            userstatus(); //Load lại trạng thái
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //Clear flpnl
            flpnlCalendar.Controls.Clear();

            //Giảm tháng
            month--;

            //Giảm năm
            if (month == 0)
            {
                month = 12;
                year--;
            }

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDate.Text = monthname + " " + year;

            //Lấy ngày bắt đầu của tháng
            DateTime batdauthang = new DateTime(year, month, 1);

            //Lấy số ngày trong tháng
            int days = DateTime.DaysInMonth(year, month);

            //Convert batdauthang thành int
            int ngaytrongtuan = Convert.ToInt32(batdauthang.DayOfWeek.ToString("d"));

            //user control trống
            for (int i = 1; i < ngaytrongtuan; i++)
            {
                UCBlank ucblank = new UCBlank();
                flpnlCalendar.Controls.Add(ucblank);
            }

            //user control ngày
            for (int i = 1; i <= days; i++)
            {
                UCCalendar uccalendar = new UCCalendar();
                uccalendar.days(i);
                flpnlCalendar.Controls.Add(uccalendar);

                //Hiển thị trạng thái theo ngày
                String querrystatus = "SELECT *FROM ChamCong WHERE (MaNhanVien = '" + MaNhanVien + "' AND NgayChamCong = '" + year + "/" + month + "/" + i + "')";
                SqlDataAdapter sdastatus = new SqlDataAdapter(querrystatus, conn);

                DataTable dtablestatus = new DataTable();
                sdastatus.Fill(dtablestatus);

                try
                {
                    uccalendar.trangthai(dtablestatus.Rows[0][4].ToString().Trim());
                }
                catch
                {
                    uccalendar.trangthai("");
                }
            }
        }

        //Button tháng sau
        private void btnNext_Click(object sender, EventArgs e)
        {
            //Clear flpnl
            flpnlCalendar.Controls.Clear();

            //Tăng tháng
            month++;

            //Tăng năm
            if (month == 13)
            {
                month = 1;
                year++;
            }

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDate.Text = monthname + " " + year;

            //Lấy ngày bắt đầu của tháng
            DateTime batdauthang = new DateTime(year, month, 1);

            //Lấy số ngày trong tháng
            int days = DateTime.DaysInMonth(year, month);

            //Convert batdauthang thành int
            int ngaytrongtuan = Convert.ToInt32(batdauthang.DayOfWeek.ToString("d"));

            //user control trống
            for (int i = 1; i < ngaytrongtuan; i++)
            {
                UCBlank ucblank = new UCBlank();
                flpnlCalendar.Controls.Add(ucblank);
            }

            //user control ngày
            for (int i = 1; i <= days; i++)
            {
                UCCalendar uccalendar = new UCCalendar();
                uccalendar.days(i);
                flpnlCalendar.Controls.Add(uccalendar);

                //Hiển thị trạng thái theo ngày
                String querrystatus = "SELECT *FROM ChamCong WHERE (MaNhanVien = '" + MaNhanVien + "' AND NgayChamCong = '" + year + "/" + month + "/" + i + "')";
                SqlDataAdapter sdastatus = new SqlDataAdapter(querrystatus, conn);

                DataTable dtablestatus = new DataTable();
                sdastatus.Fill(dtablestatus);

                try
                {
                    uccalendar.trangthai(dtablestatus.Rows[0][4].ToString().Trim());
                }
                catch
                {
                    uccalendar.trangthai("");
                }
            }
        }
    }
}