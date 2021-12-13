
namespace dekatreís_octavo.View
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.historyList = new MaterialSkin.Controls.MaterialListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.license = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topPanel = new System.Windows.Forms.Panel();
            this.checkbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new MaterialSurface.MaterialTextfield();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mainPanel.SuspendLayout();
            this.listPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.listPanel);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1084, 565);
            this.mainPanel.TabIndex = 0;
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.panel1);
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanel.Location = new System.Drawing.Point(0, 145);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(1084, 420);
            this.listPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.historyList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 420);
            this.panel1.TabIndex = 1;
            // 
            // historyList
            // 
            this.historyList.AutoSizeTable = false;
            this.historyList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.historyList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.time,
            this.type,
            this.license});
            this.historyList.Depth = 0;
            this.historyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyList.FullRowSelect = true;
            this.historyList.HideSelection = false;
            this.historyList.Location = new System.Drawing.Point(0, 0);
            this.historyList.MinimumSize = new System.Drawing.Size(200, 100);
            this.historyList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.historyList.MouseState = MaterialSkin.MouseState.OUT;
            this.historyList.Name = "historyList";
            this.historyList.OwnerDraw = true;
            this.historyList.Size = new System.Drawing.Size(1084, 420);
            this.historyList.TabIndex = 0;
            this.historyList.UseCompatibleStateImageBehavior = false;
            this.historyList.View = System.Windows.Forms.View.Details;
            this.historyList.SelectedIndexChanged += new System.EventHandler(this.historyList_SelectedIndexChanged);
            this.historyList.SizeChanged += new System.EventHandler(this.historyList_SizeChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // time
            // 
            this.time.Text = "Thời gian";
            this.time.Width = 478;
            // 
            // type
            // 
            this.type.Text = "Hoạt động";
            this.type.Width = 208;
            // 
            // license
            // 
            this.license.Text = "Biển số xe";
            this.license.Width = 329;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.checkbox);
            this.topPanel.Controls.Add(this.pictureBox6);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.searchTextBox);
            this.topPanel.Controls.Add(this.dateTimePicker1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1084, 145);
            this.topPanel.TabIndex = 0;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Depth = 0;
            this.checkbox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.checkbox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkbox.Location = new System.Drawing.Point(225, 89);
            this.checkbox.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkbox.Name = "checkbox";
            this.checkbox.ReadOnly = false;
            this.checkbox.Ripple = true;
            this.checkbox.Size = new System.Drawing.Size(80, 37);
            this.checkbox.TabIndex = 11;
            this.checkbox.Text = "Tất cả";
            this.checkbox.UseVisualStyleBackColor = true;
            this.checkbox.CheckedChanged += new System.EventHandler(this.materialCheckbox1_CheckedChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1047, 33);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dekatreís_octavo.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(326, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.AutoScaleColor = true;
            this.searchTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.searchTextBox.CountText = false;
            this.searchTextBox.FieldType = MaterialSurface.BoxType.Outlined;
            this.searchTextBox.FloatingLabelText = "FloatingLabel";
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.searchTextBox.HandleError = true;
            this.searchTextBox.HelperText = "";
            this.searchTextBox.HideSelection = true;
            this.searchTextBox.HintText = "Tìm kiếm";
            this.searchTextBox.Location = new System.Drawing.Point(3, 17);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.MouseState = MaterialSurface.MouseState.OUT;
            this.searchTextBox.Multiline = false;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.searchTextBox.ReadOnly = false;
            this.searchTextBox.ShortcutsEnable = true;
            this.searchTextBox.ShowCaret = true;
            this.searchTextBox.Size = new System.Drawing.Size(1078, 65);
            this.searchTextBox.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.UseSystemPasswordChar = false;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 38);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "History";
            this.Size = new System.Drawing.Size(1084, 565);
            this.mainPanel.ResumeLayout(false);
            this.listPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel listPanel;
        private MaterialSkin.Controls.MaterialListView historyList;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader license;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSurface.MaterialTextfield searchTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private MaterialSkin.Controls.MaterialCheckbox checkbox;
    }
}
