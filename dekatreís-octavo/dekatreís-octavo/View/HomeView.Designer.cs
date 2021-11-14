
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
            this.tabDrawer = new MaterialSkin.Controls.MaterialDrawer();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.bt_LogOut = new MaterialSurface.TextButton();
            this.bt_ChangePass = new MaterialSurface.TextButton();
            this.bt_info = new MaterialSurface.TextButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.cardManagement1 = new dekatreís_octavo.View.CardManagement();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tabDrawer);
            this.panel1.Controls.Add(this.materialCard1);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 615);
            this.panel1.TabIndex = 1;
            // 
            // tabDrawer
            // 
            this.tabDrawer.AutoHide = false;
            this.tabDrawer.AutoShow = false;
            this.tabDrawer.BackgroundWithAccent = false;
            this.tabDrawer.BaseTabControl = this.tabControl;
            this.tabDrawer.Depth = 0;
            this.tabDrawer.HighlightWithAccent = true;
            this.tabDrawer.IndicatorWidth = 0;
            this.tabDrawer.IsOpen = true;
            this.tabDrawer.Location = new System.Drawing.Point(0, 148);
            this.tabDrawer.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabDrawer.Name = "tabDrawer";
            this.tabDrawer.ShowIconsWhenHidden = false;
            this.tabDrawer.Size = new System.Drawing.Size(153, 464);
            this.tabDrawer.TabIndex = 6;
            this.tabDrawer.Text = "materialDrawer2";
            this.tabDrawer.UseColors = false;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(156, 123);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(955, 493);
            this.tabControl.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cardManagement1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(947, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(947, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.materialCard1.Location = new System.Drawing.Point(931, 33);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard1.MouseInteract = false;
            this.materialCard1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Radius = 8;
            this.materialCard1.ShawdowDepth = 2;
            this.materialCard1.ShawdowOpacity = 50;
            this.materialCard1.Size = new System.Drawing.Size(180, 150);
            this.materialCard1.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard1.TabIndex = 9;
            this.materialCard1.Visible = false;
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
            this.materialButton1.Location = new System.Drawing.Point(1071, -2);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(36, 36);
            this.materialButton1.TabIndex = 8;
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // cardManagement1
            // 
            this.cardManagement1.AutoSize = true;
            this.cardManagement1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cardManagement1.BackColor = System.Drawing.Color.White;
            this.cardManagement1.Location = new System.Drawing.Point(48, 33);
            this.cardManagement1.Name = "cardManagement1";
            this.cardManagement1.Size = new System.Drawing.Size(733, 368);
            this.cardManagement1.TabIndex = 0;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialDrawer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "HomeView";
            this.Text = "HomeView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeView_FormClosed);
            this.Load += new System.EventHandler(this.HomeView_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
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
        private CardManagement cardManagement1;
    }
}