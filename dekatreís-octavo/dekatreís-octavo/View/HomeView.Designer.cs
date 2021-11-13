
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.bt_info = new MaterialSurface.TextButton();
            this.bt_ChangePass = new MaterialSurface.TextButton();
            this.bt_LogOut = new MaterialSurface.TextButton();
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.materialTabControl1.SuspendLayout();
            this.materialCard1.SuspendLayout();
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
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(151, 371);
            this.materialDrawer1.TabIndex = 0;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(157, 54);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(955, 563);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(947, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(947, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.materialButton1.Location = new System.Drawing.Point(1072, -1);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(36, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // bt_info
            // 
            this.bt_info.EffectType = MaterialSurface.ET.Custom;
            this.bt_info.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_info.ForeColor = System.Drawing.Color.Black;
            this.bt_info.Icon = null;
            this.bt_info.Location = new System.Drawing.Point(11, 10);
            this.bt_info.MouseState = MaterialSurface.MouseState.OUT;
            this.bt_info.Name = "bt_info";
            this.bt_info.PrimaryColor = System.Drawing.Color.Black;
            this.bt_info.Radius = 6;
            this.bt_info.Size = new System.Drawing.Size(162, 40);
            this.bt_info.TabIndex = 0;
            this.bt_info.Text = "Thông tin";
            this.bt_info.TextAlignment = System.Drawing.StringAlignment.Center;
            this.bt_info.UseVisualStyleBackColor = true;
            this.bt_info.Click += new System.EventHandler(this.bt_info_Click);
            // 
            // bt_ChangePass
            // 
            this.bt_ChangePass.EffectType = MaterialSurface.ET.Custom;
            this.bt_ChangePass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ChangePass.ForeColor = System.Drawing.Color.Black;
            this.bt_ChangePass.Icon = null;
            this.bt_ChangePass.Location = new System.Drawing.Point(11, 56);
            this.bt_ChangePass.MouseState = MaterialSurface.MouseState.OUT;
            this.bt_ChangePass.Name = "bt_ChangePass";
            this.bt_ChangePass.PrimaryColor = System.Drawing.Color.Black;
            this.bt_ChangePass.Radius = 6;
            this.bt_ChangePass.Size = new System.Drawing.Size(162, 40);
            this.bt_ChangePass.TabIndex = 1;
            this.bt_ChangePass.Text = "Đổi mật khẩu";
            this.bt_ChangePass.TextAlignment = System.Drawing.StringAlignment.Center;
            this.bt_ChangePass.UseVisualStyleBackColor = true;
            this.bt_ChangePass.Click += new System.EventHandler(this.bt_ChangePass_Click);
            // 
            // bt_LogOut
            // 
            this.bt_LogOut.EffectType = MaterialSurface.ET.Custom;
            this.bt_LogOut.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LogOut.ForeColor = System.Drawing.Color.Crimson;
            this.bt_LogOut.Icon = null;
            this.bt_LogOut.Location = new System.Drawing.Point(11, 101);
            this.bt_LogOut.MouseState = MaterialSurface.MouseState.OUT;
            this.bt_LogOut.Name = "bt_LogOut";
            this.bt_LogOut.PrimaryColor = System.Drawing.Color.Crimson;
            this.bt_LogOut.Radius = 6;
            this.bt_LogOut.Size = new System.Drawing.Size(162, 40);
            this.bt_LogOut.TabIndex = 2;
            this.bt_LogOut.Text = "Đăng xuất";
            this.bt_LogOut.TextAlignment = System.Drawing.StringAlignment.Center;
            this.bt_LogOut.UseVisualStyleBackColor = true;
            this.bt_LogOut.Click += new System.EventHandler(this.bt_LogOut_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.SystemColors.Control;
            this.materialCard1.CardColor = System.Drawing.Color.White;
            this.materialCard1.Controls.Add(this.bt_LogOut);
            this.materialCard1.Controls.Add(this.bt_ChangePass);
            this.materialCard1.Controls.Add(this.bt_info);
            this.materialCard1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard1.Location = new System.Drawing.Point(932, 34);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard1.MouseInteract = false;
            this.materialCard1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Radius = 8;
            this.materialCard1.ShawdowDepth = 2;
            this.materialCard1.ShawdowOpacity = 50;
            this.materialCard1.Size = new System.Drawing.Size(180, 150);
            this.materialCard1.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard1.TabIndex = 5;
            this.materialCard1.Visible = false;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 615);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDrawer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "HomeView";
            this.Text = "HomeView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeView_FormClosed);
            this.Load += new System.EventHandler(this.HomeView_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSurface.TextButton bt_info;
        private MaterialSurface.TextButton bt_ChangePass;
        private MaterialSurface.TextButton bt_LogOut;
        private MaterialSurface.MaterialCard materialCard1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}