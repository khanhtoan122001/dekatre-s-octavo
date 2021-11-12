
namespace dekatreís_octavo.View
{
    partial class LoginView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_TenDangNhap = new MaterialSurface.MaterialTextfield();
            this.tb_MatKhau = new MaterialSurface.MaterialTextfield();
            this.bt_DangNhap = new MaterialSurface.ContainedButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tb_TenDangNhap
            // 
            this.tb_TenDangNhap.AutoScaleColor = true;
            this.tb_TenDangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.tb_TenDangNhap.CountText = false;
            this.tb_TenDangNhap.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_TenDangNhap.FloatingLabelText = "FloatingLabel";
            this.tb_TenDangNhap.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_TenDangNhap.HandleError = false;
            this.tb_TenDangNhap.HelperText = "";
            this.tb_TenDangNhap.HideSelection = true;
            this.tb_TenDangNhap.HintText = "TĐNNNN";
            this.tb_TenDangNhap.Location = new System.Drawing.Point(488, 141);
            this.tb_TenDangNhap.MaxLength = 32767;
            this.tb_TenDangNhap.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_TenDangNhap.Multiline = false;
            this.tb_TenDangNhap.Name = "tb_TenDangNhap";
            this.tb_TenDangNhap.PasswordChar = '\0';
            this.tb_TenDangNhap.PrimaryColor = System.Drawing.Color.SteelBlue;
            this.tb_TenDangNhap.ReadOnly = false;
            this.tb_TenDangNhap.ShortcutsEnable = true;
            this.tb_TenDangNhap.ShowCaret = true;
            this.tb_TenDangNhap.Size = new System.Drawing.Size(216, 49);
            this.tb_TenDangNhap.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_TenDangNhap.TabIndex = 1;
            this.tb_TenDangNhap.UseSystemPasswordChar = false;
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.AutoScaleColor = true;
            this.tb_MatKhau.BackColor = System.Drawing.SystemColors.Control;
            this.tb_MatKhau.CountText = false;
            this.tb_MatKhau.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_MatKhau.FloatingLabelText = "FloatingLabel";
            this.tb_MatKhau.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_MatKhau.HandleError = false;
            this.tb_MatKhau.HelperText = "";
            this.tb_MatKhau.HideSelection = true;
            this.tb_MatKhau.HintText = "MKKKK";
            this.tb_MatKhau.Location = new System.Drawing.Point(488, 209);
            this.tb_MatKhau.MaxLength = 32767;
            this.tb_MatKhau.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_MatKhau.Multiline = false;
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.PasswordChar = '●';
            this.tb_MatKhau.PrimaryColor = System.Drawing.Color.SteelBlue;
            this.tb_MatKhau.ReadOnly = false;
            this.tb_MatKhau.ShortcutsEnable = true;
            this.tb_MatKhau.ShowCaret = true;
            this.tb_MatKhau.Size = new System.Drawing.Size(216, 49);
            this.tb_MatKhau.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_MatKhau.TabIndex = 2;
            this.tb_MatKhau.UseSystemPasswordChar = true;
            // 
            // bt_DangNhap
            // 
            this.bt_DangNhap.EffectType = MaterialSurface.ET.Custom;
            this.bt_DangNhap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangNhap.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_DangNhap.Icon = null;
            this.bt_DangNhap.Location = new System.Drawing.Point(488, 293);
            this.bt_DangNhap.MouseState = MaterialSurface.MouseState.OUT;
            this.bt_DangNhap.Name = "bt_DangNhap";
            this.bt_DangNhap.PrimaryColor = System.Drawing.Color.SteelBlue;
            this.bt_DangNhap.Radius = 6;
            this.bt_DangNhap.ShawdowDepth = 3;
            this.bt_DangNhap.ShawdowOpacity = 50;
            this.bt_DangNhap.Size = new System.Drawing.Size(216, 51);
            this.bt_DangNhap.TabIndex = 3;
            this.bt_DangNhap.Text = "Đăng nhập";
            this.bt_DangNhap.TextAlignment = System.Drawing.StringAlignment.Center;
            this.bt_DangNhap.UseVisualStyleBackColor = true;
            this.bt_DangNhap.Click += new System.EventHandler(this.bt_DangNhap_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.SystemColors.Control;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = false;
            this.materialButton1.HighEmphasis = false;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(752, 0);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(50, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "X";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.bt_DangNhap);
            this.Controls.Add(this.tb_MatKhau);
            this.Controls.Add(this.tb_TenDangNhap);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginView";
            this.Text = "LoginView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSurface.MaterialTextfield tb_TenDangNhap;
        private MaterialSurface.MaterialTextfield tb_MatKhau;
        private MaterialSurface.ContainedButton bt_DangNhap;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}