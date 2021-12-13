
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffView));
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.staffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.staffCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.staffPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.staffType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.staffUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_add = new MaterialSurface.ContainedButton();
            this.bt_edit = new MaterialSurface.ContainedButton();
            this.bt_remove = new MaterialSurface.ContainedButton();
            this.materialTextfield1 = new MaterialSurface.MaterialTextfield();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.passResetButton = new MaterialSurface.ContainedButton();
            this.cb_typeSearch = new MaterialSkin.Controls.MaterialComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.materialListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.materialListView1.Location = new System.Drawing.Point(0, 0);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1209, 503);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewSample_ColumnClick);
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            this.materialListView1.DoubleClick += new System.EventHandler(this.materialListView1_DoubleClick);
            this.materialListView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.materialListView1_MouseDoubleClick);
            // 
            // staffName
            // 
            this.staffName.Text = "Tên";
            this.staffName.Width = 280;
            // 
            // staffCMND
            // 
            this.staffCMND.Text = "CMND";
            this.staffCMND.Width = 160;
            // 
            // staffPhoneNumber
            // 
            this.staffPhoneNumber.Text = "SĐT";
            this.staffPhoneNumber.Width = 160;
            // 
            // staffType
            // 
            this.staffType.Text = "Loại Tài Khoản";
            this.staffType.Width = 160;
            // 
            // staffUsername
            // 
            this.staffUsername.Text = "Tên Đăng Nhập";
            this.staffUsername.Width = 160;
            // 
            // bt_add
            // 
            this.bt_add.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_add.EffectType = MaterialSurface.ET.Custom;
            this.bt_add.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_add.Icon = null;
            this.bt_add.Location = new System.Drawing.Point(3, 2);
            this.bt_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_add.MouseState = MaterialSurface.MouseState.OUT;
            this.bt_add.Name = "bt_add";
            this.bt_add.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.bt_add.Radius = 6;
            this.bt_add.ShawdowDepth = 3;
            this.bt_add.ShawdowOpacity = 50;
            this.bt_add.Size = new System.Drawing.Size(150, 64);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "Thêm";
            this.bt_add.TextAlignment = System.Drawing.StringAlignment.Center;
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.containedButton1_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.EffectType = MaterialSurface.ET.Custom;
            this.bt_edit.Enabled = false;
            this.bt_edit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_edit.Icon = null;
            this.bt_edit.Location = new System.Drawing.Point(159, 2);
            this.bt_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_edit.MouseState = MaterialSurface.MouseState.OUT;
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.bt_edit.Radius = 6;
            this.bt_edit.ShawdowDepth = 3;
            this.bt_edit.ShawdowOpacity = 50;
            this.bt_edit.Size = new System.Drawing.Size(150, 64);
            this.bt_edit.TabIndex = 2;
            this.bt_edit.Text = "Sửa";
            this.bt_edit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.containedButton2_Click);
            // 
            // bt_remove
            // 
            this.bt_remove.EffectType = MaterialSurface.ET.Custom;
            this.bt_remove.Enabled = false;
            this.bt_remove.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remove.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_remove.Icon = null;
            this.bt_remove.Location = new System.Drawing.Point(315, 2);
            this.bt_remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_remove.MouseState = MaterialSurface.MouseState.OUT;
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.bt_remove.Radius = 6;
            this.bt_remove.ShawdowDepth = 3;
            this.bt_remove.ShawdowOpacity = 50;
            this.bt_remove.Size = new System.Drawing.Size(150, 64);
            this.bt_remove.TabIndex = 3;
            this.bt_remove.Text = "Xóa";
            this.bt_remove.TextAlignment = System.Drawing.StringAlignment.Center;
            this.bt_remove.UseVisualStyleBackColor = true;
            this.bt_remove.Click += new System.EventHandler(this.containedButton3_Click);
            // 
            // materialTextfield1
            // 
            this.materialTextfield1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTextfield1.AutoScaleColor = true;
            this.materialTextfield1.BackColor = System.Drawing.SystemColors.Control;
            this.materialTextfield1.CountText = false;
            this.materialTextfield1.FieldType = MaterialSurface.BoxType.Outlined;
            this.materialTextfield1.FloatingLabelText = "FloatingLabel";
            this.materialTextfield1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.materialTextfield1.HandleError = false;
            this.materialTextfield1.HelperText = "";
            this.materialTextfield1.HideSelection = true;
            this.materialTextfield1.HintText = "Tìm kiếm";
            this.materialTextfield1.Location = new System.Drawing.Point(21, 14);
            this.materialTextfield1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextfield1.MaxLength = 32767;
            this.materialTextfield1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialTextfield1.Multiline = false;
            this.materialTextfield1.Name = "materialTextfield1";
            this.materialTextfield1.PasswordChar = '\0';
            this.materialTextfield1.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.materialTextfield1.ReadOnly = false;
            this.materialTextfield1.ShortcutsEnable = true;
            this.materialTextfield1.ShowCaret = true;
            this.materialTextfield1.Size = new System.Drawing.Size(936, 49);
            this.materialTextfield1.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.materialTextfield1.TabIndex = 0;
            this.materialTextfield1.UseSystemPasswordChar = false;
            this.materialTextfield1.TextChanged += new System.EventHandler(this.materialTextfield1_TextChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1209, 644);
            this.mainPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialListView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 503);
            this.panel1.TabIndex = 7;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.flowLayoutPanel1);
            this.topPanel.Controls.Add(this.pictureBox6);
            this.topPanel.Controls.Add(this.cb_typeSearch);
            this.topPanel.Controls.Add(this.materialTextfield1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1209, 141);
            this.topPanel.TabIndex = 6;
            // 
            // passResetButton
            // 
            this.passResetButton.EffectType = MaterialSurface.ET.Custom;
            this.passResetButton.Enabled = false;
            this.passResetButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passResetButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passResetButton.Icon = null;
            this.passResetButton.Location = new System.Drawing.Point(471, 2);
            this.passResetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passResetButton.MouseState = MaterialSurface.MouseState.OUT;
            this.passResetButton.Name = "passResetButton";
            this.passResetButton.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.passResetButton.Radius = 6;
            this.passResetButton.ShawdowDepth = 3;
            this.passResetButton.ShawdowOpacity = 50;
            this.passResetButton.Size = new System.Drawing.Size(192, 64);
            this.passResetButton.TabIndex = 5;
            this.passResetButton.Text = "Đặt lại mật khẩu";
            this.passResetButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.passResetButton.UseVisualStyleBackColor = true;
            this.passResetButton.Click += new System.EventHandler(this.passResetButton_Click);
            // 
            // cb_typeSearch
            // 
            this.cb_typeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_typeSearch.AutoResize = false;
            this.cb_typeSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_typeSearch.Depth = 0;
            this.cb_typeSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_typeSearch.DropDownHeight = 174;
            this.cb_typeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typeSearch.DropDownWidth = 121;
            this.cb_typeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_typeSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_typeSearch.FormattingEnabled = true;
            this.cb_typeSearch.Hint = "Tìm kiếm theo...";
            this.cb_typeSearch.IntegralHeight = false;
            this.cb_typeSearch.ItemHeight = 43;
            this.cb_typeSearch.Items.AddRange(new object[] {
            "All",
            "Tên đăng nhập",
            "Tên thật",
            "Số điện thoại",
            "CMND"});
            this.cb_typeSearch.Location = new System.Drawing.Point(981, 14);
            this.cb_typeSearch.MaxDropDownItems = 4;
            this.cb_typeSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_typeSearch.Name = "cb_typeSearch";
            this.cb_typeSearch.Size = new System.Drawing.Size(193, 49);
            this.cb_typeSearch.StartIndex = 0;
            this.cb_typeSearch.TabIndex = 5;
            this.cb_typeSearch.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(920, 29);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bt_add);
            this.flowLayoutPanel1.Controls.Add(this.bt_edit);
            this.flowLayoutPanel1.Controls.Add(this.bt_remove);
            this.flowLayoutPanel1.Controls.Add(this.passResetButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(675, 73);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // StaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StaffView";
            this.Size = new System.Drawing.Size(1209, 644);
            this.Load += new System.EventHandler(this.StaffView_Load);
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader staffName;
        private MaterialSurface.ContainedButton bt_add;
        private MaterialSurface.ContainedButton bt_edit;
        private MaterialSurface.ContainedButton bt_remove;
        private MaterialSurface.MaterialTextfield materialTextfield1;
        private System.Windows.Forms.ColumnHeader staffCMND;
        private System.Windows.Forms.ColumnHeader staffPhoneNumber;
        private System.Windows.Forms.ColumnHeader staffType;
        private System.Windows.Forms.ColumnHeader staffUsername;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel topPanel;
        private MaterialSurface.ContainedButton passResetButton;
        private MaterialSkin.Controls.MaterialComboBox cb_typeSearch;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
