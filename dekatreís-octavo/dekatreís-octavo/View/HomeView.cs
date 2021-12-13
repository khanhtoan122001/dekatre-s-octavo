using dekatreís_octavo.Bus;
using System;
using MaterialSurface;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dekatreís_octavo.Properties;

namespace dekatreís_octavo.View
{
    public partial class HomeView : Form
    {
        TaiKhoan TaiKhoan = DataProvider.Instance.TaiKhoan;
        public HomeView()
        {
            InitializeComponent();
            if (TaiKhoan != null) initHomeView();
            int succhua = ThamSoBus.Instance.GetByTen("Sức chứa").GiaTri.Value;
            progressBar.Value = DataProvider.Instance.SoXeTrongBai / succhua;
            maxLabel.Text = succhua.ToString();
            SoXe.Top = 483 - progressBar.Value*4;
        }

        public void StartWork()
        {
            timer1.Enabled = true;

            DataProvider.Instance.ThoiGianLamViec = 0;
        }

        public void EndWork()
        {
            if(DataProvider.Instance.TaiKhoan.TongGioLam == null)
                DataProvider.Instance.TaiKhoan.TongGioLam = DataProvider.Instance.ThoiGianLamViec;
            else
                DataProvider.Instance.TaiKhoan.TongGioLam += DataProvider.Instance.ThoiGianLamViec;
            //if(TaiKhoan.LoaiTaiKhoan1.TenLoai != "admin")
            {
                int Luong = DataProvider.Instance.ThoiGianLamViec / 60 * ThamSoBus.Instance.GetByTen("Lương").GiaTri.Value;
                ReportBus.Instance.AddCT_BaoCaoTongChi(Luong, "Lương nhân viên");
            }
            DataProvider.Instance.db.SaveChanges();
            timer1.Enabled = false;
        }

        public void initHomeView(TaiKhoan taiKhoan = null)
        {
            if (taiKhoan != null) TaiKhoan = taiKhoan;
            if (TaiKhoan.Avatar == null)
                LoginViewBus.Instance.ChangeAvatar(Resources.default_avatar_300x300);
            pictureBox2.Image = ImageHelper.byteArrayToImage(TaiKhoan.Avatar);
            AddTab();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (materialCard1.Visible == false)
                materialCard1.Visible = true;
            else materialCard1.Visible = false;
        }

        private void bt_ChangePass_Click(object sender, EventArgs e)
        {
            materialCard1.Visible = false;
            ChangePass changePass = new ChangePass();
            changePass.Show();
        }

        private void bt_LogOut_Click(object sender, EventArgs e)
        {
            EndWork();
            DataProvider.Instance.TaiKhoan = null;
            this.Close();
        }

        private void HomeView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(DataProvider.Instance.TaiKhoan != null)
            {
                EndWork();
                Application.Exit();
            }
        }

        private void HomeView_Load(object sender, EventArgs e)
        {

            if (DataProvider.Instance.TaiKhoan.Avatar == null)
                LoginViewBus.Instance.ChangeAvatar(Resources.default_avatar_300x300);
            cardManagement1.LoadData();
            staffView1.LoadStaffList();
            history1.LoadData();
            ReportBus.Instance.AddCT_TongChiCacPhiKhac();
            pictureBox3.Left = tabNameLabel.Location.X - 40;
            //BaoCaoChamCongNhanVienBus.Instance.ChamCong();
        }

        private void AddTab()
        {
            tabControl.TabPages.Clear();
            if (TaiKhoan.LoaiTaiKhoan1.TenLoai == "admin")
            {
                tabControl.TabPages.Add(homePage);
                tabControl.TabPages.Add(cardPage);
                tabControl.TabPages.Add(staffPage);
                tabControl.TabPages.Add(utility);
                //tabControl.TabPages.Add(statusPage);
                tabControl.TabPages.Add(setting);
                lb_stopwatch.Visible = false;
            }
            else
            {
                tabControl.TabPages.Add(homePage);
                tabControl.TabPages.Add(cardPage);
            }
        }

        private void Refresh(Point e)
        {
            if (!materialCard1.DisplayRectangle.Contains(e))
            {
                if (materialCard1.Visible == true)
                    materialCard1.Visible = false;
            }
        }

        private void LoadThamSo()
        {
            var listTs = ThamSoBus.Instance.GetThamSos();
            tb_Vethuong.Text = DataProvider.Instance.db.LoaiThes.Where(p => p.TenLoai == "Thẻ thường").FirstOrDefault().Gia.Value.ToString();
            tb_Vethang.Text = DataProvider.Instance.db.LoaiThes.Where(p => p.TenLoai == "Thẻ tháng").FirstOrDefault().Gia.Value.ToString();
            tb_Luong.Text = listTs.Where(p => p.TenThamSo == "Lương").FirstOrDefault().GiaTri.Value.ToString();
            tb_TienMatBang.Text = listTs.Where(p => p.TenThamSo == "Tiền mặt bằng").FirstOrDefault().GiaTri.Value.ToString();
            tb_SucChua.Text = listTs.Where(p => p.TenThamSo == "Sức chứa").FirstOrDefault().GiaTri.Value.ToString();
            tb_baotri.Text = listTs.Where(p => p.TenThamSo == "Phí bảo trì").FirstOrDefault().GiaTri.Value.ToString();
        }

        private void materialDrawer1_MouseDown(object sender, MouseEventArgs e)
        {
            Refresh(e.Location);
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            Refresh(Control.MousePosition);
            if (e.TabPage == setting)
                LoadThamSo();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //if (dateTimePicker.Value < DateTime.Today)
            //{
            //    dateTimePicker.Value = DateTime.Today;
            //}
        }

        private void setting_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            revenueMonthlyReport1.Visible = false;
            revenueReport1.Visible = false;
            consistenceReport1.Visible = true;
        }


        private void bt_info_Click_1(object sender, EventArgs e)
        {
            materialCard1.Visible = false;
            DetailView detailView = new DetailView();
            detailView.LoadTaiKhoan(DataProvider.Instance.TaiKhoan);
            detailView.ShowDialog();
            if (TaiKhoan != null)
                pictureBox2.Image = ImageHelper.byteArrayToImage(TaiKhoan.Avatar);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab != null)
            {
                switch (tabControl.SelectedTab.Name)
                {
                    case "homePage":
                    {
                        tabNameLabel.Text = "Trang chính";
                        pictureBox3.Image = Resources.baseline_home_black_36dp;
                        pictureBox3.Left = tabNameLabel.Location.X - 40;
                        break;
                    }
                case "cardPage":
                    {
                        tabNameLabel.Text = "Quản lý thẻ";
                        pictureBox3.Image = Resources.baseline_two_wheeler_black_36dp;
                        pictureBox3.Left = tabNameLabel.Location.X - 40;
                        break;
                    }
                case "staffPage":
                    {
                        tabNameLabel.Text = "Quản lý nhân viên";
                        pictureBox3.Image = Resources.baseline_manage_accounts_black_36dp;
                        pictureBox3.Left = tabNameLabel.Location.X - 40;
                        break;
                    }
                case "utility":
                    {
                        tabNameLabel.Text = "Báo cáo";
                        pictureBox3.Image = Resources.baseline_analytics_black_36dp;
                        pictureBox3.Left = tabNameLabel.Location.X - 40;
                        break;
                    }
                case "statusPage":
                    {
                        tabNameLabel.Text = "Tình trạng bãi";
                        pictureBox3.Image = Resources.baseline_home_black_36dp;
                        pictureBox3.Left = tabNameLabel.Location.X - 40;
                        break;
                    }
                case "setting":
                    {
                        tabNameLabel.Text = "Quản lý quy định";
                        pictureBox3.Image = Resources.baseline_settings_black_36dp;
                        pictureBox3.Left = tabNameLabel.Location.X - 40;
                        break;
                    }
                default:
                    break;
                };
            }
            else
            {
                tabControl.SelectedTab = homePage;
                tabNameLabel.Text = "Trang chính";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataProvider.Instance.ThoiGianLamViec++;
            int i = DataProvider.Instance.ThoiGianLamViec;
            int a, b;

            a = i / 60;
            b = i - a * 60;
            if (a >= 10 && b >= 10)
                lb_stopwatch.Text = string.Format("{0} : {1}", a.ToString(), b.ToString());
            else if (a < 10 && b >= 10)
                lb_stopwatch.Text = string.Format("0{0} : {1}", a.ToString(), b.ToString());
            else if (a < 10 && b < 10)
                lb_stopwatch.Text = string.Format("0{0} : 0{1}", a.ToString(), b.ToString());
            else if (a >= 10 && b < 10)
                lb_stopwatch.Text = string.Format("{0} : 0{1}", a.ToString(), b.ToString());

            SoXe.Text = DataProvider.Instance.SoXeTrongBai.ToString();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int o, vethuong, vethang, luong, succhua, tienmatbang, phibaotri;
            if(int.TryParse( tb_Vethuong.Text, out vethuong) && int.TryParse(tb_Vethang.Text, out vethang) 
                && int.TryParse(tb_TienMatBang.Text, out tienmatbang) && int.TryParse(tb_SucChua.Text, out succhua) 
                && int.TryParse(tb_Luong.Text, out luong) && int.TryParse(tb_baotri.Text, out phibaotri))
            {
                LoaiTheBus.Instance.EditLoaiThe("Thẻ thường", vethuong);
                LoaiTheBus.Instance.EditLoaiThe("Thẻ tháng", vethang);
                ThamSoBus.Instance.EditThamSo("Lương", luong);
                ThamSoBus.Instance.EditThamSo("Tiền mặt bằng",tienmatbang);
                ThamSoBus.Instance.EditThamSo("Sức chứa", succhua);
                ThamSoBus.Instance.EditThamSo("Phí bảo trì", phibaotri);
                DataProvider.Instance.db.SaveChanges();
                timer2.Enabled = true;
                //lb_success.Visible = true;
                Snackbar.MakeSnackbar(this, "Thành công", "OK");
                maxLabel.Text = succhua.ToString();
            }
            else
            {
                MessageBox.Show("Giá trị không đúng định dạng");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            lb_success.Visible = false;
        }

        private void containedButton1_Click(object sender, EventArgs e)
        {
            revenueMonthlyReport1.Visible = false;
            consistenceReport1.Visible = false;
            revenueReport1.Visible = true;
        }

        private void containedButton2_Click(object sender, EventArgs e)
        {
            consistenceReport1.Visible = false;
            revenueReport1.Visible = false;
            revenueMonthlyReport1.Visible = true;
        }
        private void historyButton_Click(object sender, EventArgs e)
        {

        }

        private void SoXe_TextAlignChanged(object sender, EventArgs e)
        {
            float succhua = ThamSoBus.Instance.GetByTen("Sức chứa").GiaTri.Value;
            float soxe = DataProvider.Instance.SoXeTrongBai;
            progressBar.Value = Convert.ToInt32(Math.Round(soxe / succhua * 100));
            maxLabel.Text = succhua.ToString();
            SoXe.Top = 483 - progressBar.Value * 4;
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }
    }
}
