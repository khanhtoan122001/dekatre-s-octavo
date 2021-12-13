
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.Panel();
            this.historyList = new MaterialSkin.Controls.MaterialListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.license = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topPanel = new System.Windows.Forms.Panel();
            this.checkbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.refreshButton = new MaterialSurface.ContainedButton();
            this.searchTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.listPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.listPanel);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(775, 446);
            this.mainPanel.TabIndex = 0;
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.panel2);
            this.listPanel.Controls.Add(this.panel1);
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanel.Location = new System.Drawing.Point(0, 100);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(775, 346);
            this.listPanel.TabIndex = 1;
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
            this.historyList.FullRowSelect = true;
            this.historyList.HideSelection = false;
            this.historyList.Location = new System.Drawing.Point(0, 0);
            this.historyList.MinimumSize = new System.Drawing.Size(200, 100);
            this.historyList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.historyList.MouseState = MaterialSkin.MouseState.OUT;
            this.historyList.Name = "historyList";
            this.historyList.OwnerDraw = true;
            this.historyList.Size = new System.Drawing.Size(775, 346);
            this.historyList.TabIndex = 0;
            this.historyList.UseCompatibleStateImageBehavior = false;
            this.historyList.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // time
            // 
            this.time.Text = "Thời gian";
            this.time.Width = 186;
            // 
            // type
            // 
            this.type.Text = "Hoạt động";
            this.type.Width = 135;
            // 
            // license
            // 
            this.license.Text = "Biển số xe";
            this.license.Width = 208;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.searchTextBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(775, 100);
            this.topPanel.TabIndex = 0;
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Checked = true;
            this.checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox.Depth = 0;
            this.checkbox.Location = new System.Drawing.Point(27, 143);
            this.checkbox.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkbox.Name = "checkbox";
            this.checkbox.ReadOnly = false;
            this.checkbox.Ripple = true;
            this.checkbox.Size = new System.Drawing.Size(110, 37);
            this.checkbox.TabIndex = 3;
            this.checkbox.Text = "Theo ngày";
            this.checkbox.UseVisualStyleBackColor = true;
            this.checkbox.CheckedChanged += new System.EventHandler(this.materialCheckbox1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 27);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.EffectType = MaterialSurface.ET.Custom;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.refreshButton.Icon = null;
            this.refreshButton.Location = new System.Drawing.Point(27, 183);
            this.refreshButton.MouseState = MaterialSurface.MouseState.OUT;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.refreshButton.Radius = 6;
            this.refreshButton.ShawdowDepth = 3;
            this.refreshButton.ShawdowOpacity = 50;
            this.refreshButton.Size = new System.Drawing.Size(140, 50);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.AnimateReadOnly = false;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Depth = 0;
            this.searchTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextBox.Hint = "Tìm kiếm";
            this.searchTextBox.LeadingIcon = null;
            this.searchTextBox.Location = new System.Drawing.Point(27, 23);
            this.searchTextBox.MaxLength = 50;
            this.searchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.searchTextBox.Multiline = false;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(217, 50);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.Text = "";
            this.searchTextBox.TrailingIcon = null;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.historyList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 346);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.refreshButton);
            this.panel2.Controls.Add(this.checkbox);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(575, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 346);
            this.panel2.TabIndex = 2;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "History";
            this.Size = new System.Drawing.Size(775, 446);
            this.mainPanel.ResumeLayout(false);
            this.listPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private MaterialSurface.ContainedButton refreshButton;
        private MaterialSkin.Controls.MaterialTextBox searchTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialCheckbox checkbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
