﻿
namespace dekatreís_octavo.View
{
    partial class HomeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.tabPanel = new System.Windows.Forms.Panel();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.utility = new System.Windows.Forms.TabPage();
            this.statusButton = new MaterialSurface.ContainedButton();
            this.historyButton = new MaterialSurface.ContainedButton();
            this.schedule = new System.Windows.Forms.TabPage();
            this.uperPanel = new System.Windows.Forms.Panel();
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.bt_ChangePass = new MaterialSurface.TextButton();
            this.bt_info = new MaterialSurface.TextButton();
            this.bt_LogOut = new MaterialSurface.TextButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabDrawer = new MaterialSkin.Controls.MaterialDrawer();
            this.iconPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardManagement1 = new dekatreís_octavo.View.CardManagement();
            this.staffView1 = new dekatreís_octavo.View.StaffView();
            this.parkingView1 = new dekatreís_octavo.View.ParkingView();
            this.panel1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.utility.SuspendLayout();
            this.uperPanel.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-151, 81);
            this.materialDrawer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(151, 370);
            this.materialDrawer1.TabIndex = 0;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            this.materialDrawer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialDrawer1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.leftPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1379, 758);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialDrawer1_MouseDown);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.tabPanel);
            this.leftPanel.Controls.Add(this.uperPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(228, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(1151, 758);
            this.leftPanel.TabIndex = 11;
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.tabControl);
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel.Location = new System.Drawing.Point(0, 100);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(1151, 658);
            this.tabPanel.TabIndex = 11;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.utility);
            this.tabControl.Controls.Add(this.schedule);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1151, 658);
            this.tabControl.TabIndex = 7;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            this.tabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialDrawer1_MouseDown);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1143, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trang chính";
            this.tabPage1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialDrawer1_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cardManagement1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1143, 629);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thẻ";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialDrawer1_MouseDown);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.staffView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1143, 629);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nhân viên";
            this.tabPage3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialDrawer1_MouseDown);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.parkingView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1143, 629);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Parking";
            this.tabPage4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialDrawer1_MouseDown);
            // 
            // utility
            // 
            this.utility.BackColor = System.Drawing.Color.White;
            this.utility.Controls.Add(this.statusButton);
            this.utility.Controls.Add(this.historyButton);
            this.utility.Location = new System.Drawing.Point(4, 25);
            this.utility.Name = "utility";
            this.utility.Padding = new System.Windows.Forms.Padding(3);
            this.utility.Size = new System.Drawing.Size(1143, 629);
            this.utility.TabIndex = 4;
            this.utility.Text = "Báo cáo";
            // 
            // statusButton
            // 
            this.statusButton.EffectType = MaterialSurface.ET.Custom;
            this.statusButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.statusButton.Icon = null;
            this.statusButton.Location = new System.Drawing.Point(364, 296);
            this.statusButton.MouseState = MaterialSurface.MouseState.OUT;
            this.statusButton.Name = "statusButton";
            this.statusButton.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.statusButton.Radius = 6;
            this.statusButton.ShawdowDepth = 3;
            this.statusButton.ShawdowOpacity = 50;
            this.statusButton.Size = new System.Drawing.Size(180, 50);
            this.statusButton.TabIndex = 1;
            this.statusButton.Text = "Trạng thái";
            this.statusButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.statusButton.UseVisualStyleBackColor = true;
            // 
            // historyButton
            // 
            this.historyButton.EffectType = MaterialSurface.ET.Custom;
            this.historyButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.historyButton.Icon = null;
            this.historyButton.Location = new System.Drawing.Point(178, 296);
            this.historyButton.MouseState = MaterialSurface.MouseState.OUT;
            this.historyButton.Name = "historyButton";
            this.historyButton.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.historyButton.Radius = 6;
            this.historyButton.ShawdowDepth = 3;
            this.historyButton.ShawdowOpacity = 50;
            this.historyButton.Size = new System.Drawing.Size(180, 50);
            this.historyButton.TabIndex = 0;
            this.historyButton.Text = "Lịch sử";
            this.historyButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.historyButton.UseVisualStyleBackColor = true;
            // 
            // schedule
            // 
            this.schedule.Location = new System.Drawing.Point(4, 25);
            this.schedule.Name = "schedule";
            this.schedule.Padding = new System.Windows.Forms.Padding(3);
            this.schedule.Size = new System.Drawing.Size(1143, 629);
            this.schedule.TabIndex = 5;
            this.schedule.Text = "Lịch làm việc";
            this.schedule.UseVisualStyleBackColor = true;
            // 
            // uperPanel
            // 
            this.uperPanel.Controls.Add(this.pictureBox1);
            this.uperPanel.Controls.Add(this.materialCard1);
            this.uperPanel.Controls.Add(this.materialButton1);
            this.uperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uperPanel.Location = new System.Drawing.Point(0, 0);
            this.uperPanel.Name = "uperPanel";
            this.uperPanel.Size = new System.Drawing.Size(1151, 100);
            this.uperPanel.TabIndex = 1;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.SystemColors.Control;
            this.materialCard1.CardColor = System.Drawing.Color.White;
            this.materialCard1.Controls.Add(this.bt_ChangePass);
            this.materialCard1.Controls.Add(this.bt_info);
            this.materialCard1.Controls.Add(this.bt_LogOut);
            this.materialCard1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard1.Location = new System.Drawing.Point(966, 53);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard1.MouseInteract = false;
            this.materialCard1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Radius = 8;
            this.materialCard1.ShawdowDepth = 2;
            this.materialCard1.ShawdowOpacity = 50;
            this.materialCard1.Size = new System.Drawing.Size(180, 150);
            this.materialCard1.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard1.TabIndex = 1;
            this.materialCard1.Visible = false;
            this.materialCard1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialDrawer1_MouseDown);
            // 
            // bt_ChangePass
            // 
            this.bt_ChangePass.EffectType = MaterialSurface.ET.Custom;
            this.bt_ChangePass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ChangePass.ForeColor = System.Drawing.Color.Black;
            this.bt_ChangePass.Icon = null;
            this.bt_ChangePass.Location = new System.Drawing.Point(11, 57);
            this.bt_ChangePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_ChangePass.MouseState = MaterialSurface.MouseState.OUT;
            this.bt_ChangePass.Name = "bt_ChangePass";
            this.bt_ChangePass.PrimaryColor = System.Drawing.Color.Black;
            this.bt_ChangePass.Radius = 6;
            this.bt_ChangePass.Size = new System.Drawing.Size(163, 39);
            this.bt_ChangePass.TabIndex = 1;
            this.bt_ChangePass.Text = "Đổi mật khẩu";
            this.bt_ChangePass.TextAlignment = System.Drawing.StringAlignment.Center;
            this.bt_ChangePass.UseVisualStyleBackColor = true;
            this.bt_ChangePass.Click += new System.EventHandler(this.bt_ChangePass_Click);
            this.bt_ChangePass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialDrawer1_MouseDown);
            // 
            // bt_info
            // 
            this.bt_info.EffectType = MaterialSurface.ET.Custom;
            this.bt_info.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_info.ForeColor = System.Drawing.Color.Black;
            this.bt_info.Icon = null;
            this.bt_info.Location = new System.Drawing.Point(11, 10);
            this.bt_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_info.MouseState = MaterialSurface.MouseState.OUT;
            this.bt_info.Name = "bt_info";
            this.bt_info.PrimaryColor = System.Drawing.Color.Black;
            this.bt_info.Radius = 6;
            this.bt_info.Size = new System.Drawing.Size(163, 39);
            this.bt_info.TabIndex = 0;
            this.bt_info.Text = "Thông tin";
            this.bt_info.TextAlignment = System.Drawing.StringAlignment.Center;
            this.bt_info.UseVisualStyleBackColor = true;
            this.bt_info.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialDrawer1_MouseDown);
            // 
            // bt_LogOut
            // 
            this.bt_LogOut.EffectType = MaterialSurface.ET.Custom;
            this.bt_LogOut.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LogOut.ForeColor = System.Drawing.Color.Crimson;
            this.bt_LogOut.Icon = null;
            this.bt_LogOut.Location = new System.Drawing.Point(11, 101);
            this.bt_LogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_LogOut.MouseState = MaterialSurface.MouseState.OUT;
            this.bt_LogOut.Name = "bt_LogOut";
            this.bt_LogOut.PrimaryColor = System.Drawing.Color.Crimson;
            this.bt_LogOut.Radius = 6;
            this.bt_LogOut.Size = new System.Drawing.Size(163, 39);
            this.bt_LogOut.TabIndex = 2;
            this.bt_LogOut.Text = "Đăng xuất";
            this.bt_LogOut.TextAlignment = System.Drawing.StringAlignment.Center;
            this.bt_LogOut.UseVisualStyleBackColor = true;
            this.bt_LogOut.Click += new System.EventHandler(this.bt_LogOut_Click);
            this.bt_LogOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialDrawer1_MouseDown);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1111, 6);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(36, 36);
            this.materialButton1.TabIndex = 8;
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            this.materialButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialDrawer1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.iconPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 758);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabDrawer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 658);
            this.panel3.TabIndex = 1;
            // 
            // tabDrawer
            // 
            this.tabDrawer.AutoHide = false;
            this.tabDrawer.AutoShow = false;
            this.tabDrawer.BackgroundWithAccent = false;
            this.tabDrawer.BaseTabControl = this.tabControl;
            this.tabDrawer.Depth = 0;
            this.tabDrawer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDrawer.HighlightWithAccent = true;
            this.tabDrawer.IndicatorWidth = 0;
            this.tabDrawer.IsOpen = true;
            this.tabDrawer.Location = new System.Drawing.Point(0, 0);
            this.tabDrawer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDrawer.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabDrawer.Name = "tabDrawer";
            this.tabDrawer.ShowIconsWhenHidden = false;
            this.tabDrawer.Size = new System.Drawing.Size(228, 658);
            this.tabDrawer.TabIndex = 6;
            this.tabDrawer.UseColors = false;
            this.tabDrawer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialDrawer1_MouseDown);
            // 
            // iconPanel
            // 
            this.iconPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPanel.Location = new System.Drawing.Point(0, 0);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(228, 100);
            this.iconPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(374, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // cardManagement1
            // 
            this.cardManagement1.AutoSize = true;
            this.cardManagement1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cardManagement1.BackColor = System.Drawing.Color.White;
            this.cardManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardManagement1.Location = new System.Drawing.Point(3, 2);
            this.cardManagement1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardManagement1.Name = "cardManagement1";
            this.cardManagement1.Size = new System.Drawing.Size(1137, 625);
            this.cardManagement1.TabIndex = 0;
            this.cardManagement1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialDrawer1_MouseDown);
            // 
            // staffView1
            // 
            this.staffView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.staffView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffView1.Location = new System.Drawing.Point(0, 0);
            this.staffView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staffView1.Name = "staffView1";
            this.staffView1.Size = new System.Drawing.Size(1143, 629);
            this.staffView1.TabIndex = 0;
            this.staffView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialDrawer1_MouseDown);
            // 
            // parkingView1
            // 
            this.parkingView1.BackColor = System.Drawing.Color.White;
            this.parkingView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parkingView1.Location = new System.Drawing.Point(0, 0);
            this.parkingView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkingView1.Name = "parkingView1";
            this.parkingView1.Size = new System.Drawing.Size(1143, 629);
            this.parkingView1.TabIndex = 0;
            this.parkingView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialDrawer1_MouseDown);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 758);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialDrawer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeView_FormClosed);
            this.Load += new System.EventHandler(this.HomeView_Load);
            this.panel1.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.tabPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.utility.ResumeLayout(false);
            this.uperPanel.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialDrawer tabDrawer;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSurface.MaterialCard materialCard1;
        private MaterialSurface.TextButton bt_LogOut;
        private MaterialSurface.TextButton bt_ChangePass;
        private MaterialSurface.TextButton bt_info;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private CardManagement cardManagement1;
        private StaffView staffView1;
        private ParkingView parkingView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage utility;
        private MaterialSurface.ContainedButton statusButton;
        private MaterialSurface.ContainedButton historyButton;
        private System.Windows.Forms.TabPage schedule;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel iconPanel;
        private System.Windows.Forms.Panel tabPanel;
        private System.Windows.Forms.Panel uperPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}