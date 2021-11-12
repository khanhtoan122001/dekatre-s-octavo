
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
            this.textButton1 = new MaterialSurface.TextButton();
            this.textButton2 = new MaterialSurface.TextButton();
            this.textButton3 = new MaterialSurface.TextButton();
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.materialTabControl1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
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
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(157, 54);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(645, 398);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(762, -1);
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
            // textButton1
            // 
            this.textButton1.EffectType = MaterialSurface.ET.Custom;
            this.textButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textButton1.ForeColor = System.Drawing.Color.Black;
            this.textButton1.Icon = null;
            this.textButton1.Location = new System.Drawing.Point(11, 10);
            this.textButton1.MouseState = MaterialSurface.MouseState.OUT;
            this.textButton1.Name = "textButton1";
            this.textButton1.PrimaryColor = System.Drawing.Color.Black;
            this.textButton1.Radius = 6;
            this.textButton1.Size = new System.Drawing.Size(162, 40);
            this.textButton1.TabIndex = 0;
            this.textButton1.Text = "Thông tin";
            this.textButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.textButton1.UseVisualStyleBackColor = true;
            this.textButton1.Click += new System.EventHandler(this.textButton1_Click);
            // 
            // textButton2
            // 
            this.textButton2.EffectType = MaterialSurface.ET.Custom;
            this.textButton2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textButton2.ForeColor = System.Drawing.Color.Black;
            this.textButton2.Icon = null;
            this.textButton2.Location = new System.Drawing.Point(11, 56);
            this.textButton2.MouseState = MaterialSurface.MouseState.OUT;
            this.textButton2.Name = "textButton2";
            this.textButton2.PrimaryColor = System.Drawing.Color.Black;
            this.textButton2.Radius = 6;
            this.textButton2.Size = new System.Drawing.Size(162, 40);
            this.textButton2.TabIndex = 1;
            this.textButton2.Text = "Đổi mật khẩu";
            this.textButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.textButton2.UseVisualStyleBackColor = true;
            this.textButton2.Click += new System.EventHandler(this.textButton2_Click);
            // 
            // textButton3
            // 
            this.textButton3.EffectType = MaterialSurface.ET.Custom;
            this.textButton3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textButton3.ForeColor = System.Drawing.Color.Crimson;
            this.textButton3.Icon = null;
            this.textButton3.Location = new System.Drawing.Point(11, 101);
            this.textButton3.MouseState = MaterialSurface.MouseState.OUT;
            this.textButton3.Name = "textButton3";
            this.textButton3.PrimaryColor = System.Drawing.Color.Crimson;
            this.textButton3.Radius = 6;
            this.textButton3.Size = new System.Drawing.Size(162, 40);
            this.textButton3.TabIndex = 2;
            this.textButton3.Text = "Đăng xuất";
            this.textButton3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.textButton3.UseVisualStyleBackColor = true;
            this.textButton3.Click += new System.EventHandler(this.textButton3_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.SystemColors.Control;
            this.materialCard1.CardColor = System.Drawing.Color.White;
            this.materialCard1.Controls.Add(this.textButton3);
            this.materialCard1.Controls.Add(this.textButton2);
            this.materialCard1.Controls.Add(this.textButton1);
            this.materialCard1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard1.Location = new System.Drawing.Point(622, 34);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDrawer1);
            this.Name = "HomeView";
            this.Text = "HomeView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeView_FormClosed);
            this.materialTabControl1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSurface.TextButton textButton1;
        private MaterialSurface.TextButton textButton2;
        private MaterialSurface.TextButton textButton3;
        private MaterialSurface.MaterialCard materialCard1;
    }
}