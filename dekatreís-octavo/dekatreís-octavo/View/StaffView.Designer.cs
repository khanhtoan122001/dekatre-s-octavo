
namespace dekatreís_octavo.View
{
    partial class StaffView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.staffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.staffCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.staffPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.staffType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.staffUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.containedButton1 = new MaterialSurface.ContainedButton();
            this.containedButton2 = new MaterialSurface.ContainedButton();
            this.containedButton3 = new MaterialSurface.ContainedButton();
            this.materialTextfield1 = new MaterialSurface.MaterialTextfield();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.staffName,
            this.staffCMND,
            this.staffPhoneNumber,
            this.staffType,
            this.staffUsername});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(0, 91);
            this.materialListView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialListView1.MinimumSize = new System.Drawing.Size(150, 81);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(905, 430);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            // 
            // staffName
            // 
            this.staffName.Text = "Tên";
            this.staffName.Width = 209;
            // 
            // staffCMND
            // 
            this.staffCMND.Text = "CMND";
            this.staffCMND.Width = 132;
            // 
            // staffPhoneNumber
            // 
            this.staffPhoneNumber.Text = "SĐT";
            this.staffPhoneNumber.Width = 167;
            // 
            // staffType
            // 
            this.staffType.Text = "Loại Tài Khoản";
            this.staffType.Width = 143;
            // 
            // staffUsername
            // 
            this.staffUsername.Text = "Tên Đăng Nhập";
            this.staffUsername.Width = 130;
            // 
            // containedButton1
            // 
            this.containedButton1.EffectType = MaterialSurface.ET.Custom;
            this.containedButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.containedButton1.Icon = null;
            this.containedButton1.Location = new System.Drawing.Point(0, 47);
            this.containedButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.containedButton1.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton1.Name = "containedButton1";
            this.containedButton1.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.containedButton1.Radius = 6;
            this.containedButton1.ShawdowDepth = 3;
            this.containedButton1.ShawdowOpacity = 50;
            this.containedButton1.Size = new System.Drawing.Size(135, 41);
            this.containedButton1.TabIndex = 1;
            this.containedButton1.Text = "Thêm";
            this.containedButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton1.UseVisualStyleBackColor = true;
            this.containedButton1.Click += new System.EventHandler(this.containedButton1_Click);
            // 
            // containedButton2
            // 
            this.containedButton2.EffectType = MaterialSurface.ET.Custom;
            this.containedButton2.Enabled = false;
            this.containedButton2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.containedButton2.Icon = null;
            this.containedButton2.Location = new System.Drawing.Point(140, 47);
            this.containedButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.containedButton2.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton2.Name = "containedButton2";
            this.containedButton2.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.containedButton2.Radius = 6;
            this.containedButton2.ShawdowDepth = 3;
            this.containedButton2.ShawdowOpacity = 50;
            this.containedButton2.Size = new System.Drawing.Size(135, 41);
            this.containedButton2.TabIndex = 2;
            this.containedButton2.Text = "Sửa";
            this.containedButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton2.UseVisualStyleBackColor = true;
            this.containedButton2.Click += new System.EventHandler(this.containedButton2_Click);
            // 
            // containedButton3
            // 
            this.containedButton3.EffectType = MaterialSurface.ET.Custom;
            this.containedButton3.Enabled = false;
            this.containedButton3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.containedButton3.Icon = null;
            this.containedButton3.Location = new System.Drawing.Point(279, 47);
            this.containedButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.containedButton3.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton3.Name = "containedButton3";
            this.containedButton3.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.containedButton3.Radius = 6;
            this.containedButton3.ShawdowDepth = 3;
            this.containedButton3.ShawdowOpacity = 50;
            this.containedButton3.Size = new System.Drawing.Size(135, 41);
            this.containedButton3.TabIndex = 3;
            this.containedButton3.Text = "Xóa";
            this.containedButton3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton3.UseVisualStyleBackColor = true;
            this.containedButton3.Click += new System.EventHandler(this.containedButton3_Click);
            // 
            // materialTextfield1
            // 
            this.materialTextfield1.AutoScaleColor = true;
            this.materialTextfield1.BackColor = System.Drawing.SystemColors.Control;
            this.materialTextfield1.CountText = false;
            this.materialTextfield1.FieldType = MaterialSurface.BoxType.Normal;
            this.materialTextfield1.FloatingLabelText = "FloatingLabel";
            this.materialTextfield1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.materialTextfield1.HandleError = false;
            this.materialTextfield1.HelperText = "";
            this.materialTextfield1.HideSelection = true;
            this.materialTextfield1.HintText = "Tìm kiếm";
            this.materialTextfield1.Location = new System.Drawing.Point(0, 2);
            this.materialTextfield1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTextfield1.MaxLength = 32767;
            this.materialTextfield1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialTextfield1.Multiline = false;
            this.materialTextfield1.Name = "materialTextfield1";
            this.materialTextfield1.PasswordChar = '\0';
            this.materialTextfield1.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.materialTextfield1.ReadOnly = false;
            this.materialTextfield1.ShortcutsEnable = true;
            this.materialTextfield1.ShowCaret = true;
            this.materialTextfield1.Size = new System.Drawing.Size(256, 44);
            this.materialTextfield1.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.materialTextfield1.TabIndex = 4;
            this.materialTextfield1.UseSystemPasswordChar = false;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Sort by";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(817, 2);
            this.materialComboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(90, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 5;
            // 
            // StaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.materialTextfield1);
            this.Controls.Add(this.containedButton3);
            this.Controls.Add(this.containedButton2);
            this.Controls.Add(this.containedButton1);
            this.Controls.Add(this.materialListView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StaffView";
            this.Size = new System.Drawing.Size(907, 523);
            this.Load += new System.EventHandler(this.StaffView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader staffName;
        private MaterialSurface.ContainedButton containedButton1;
        private MaterialSurface.ContainedButton containedButton2;
        private MaterialSurface.ContainedButton containedButton3;
        private MaterialSurface.MaterialTextfield materialTextfield1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.ColumnHeader staffCMND;
        private System.Windows.Forms.ColumnHeader staffPhoneNumber;
        private System.Windows.Forms.ColumnHeader staffType;
        private System.Windows.Forms.ColumnHeader staffUsername;
    }
}
