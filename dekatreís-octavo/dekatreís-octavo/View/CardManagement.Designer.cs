
namespace dekatreís_octavo.View
{
    partial class CardManagement
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.statusComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.addButton = new MaterialSurface.ContainedButton();
            this.delButton = new MaterialSurface.ContainedButton();
            this.cardList = new MaterialSkin.Controls.MaterialListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Owner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inOutButton = new MaterialSurface.ContainedButton();
            this.typeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusComboBox
            // 
            this.statusComboBox.AutoResize = false;
            this.statusComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.statusComboBox.Depth = 0;
            this.statusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.statusComboBox.DropDownHeight = 174;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.DropDownWidth = 121;
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.statusComboBox.ForeColor = System.Drawing.Color.White;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Hint = "Status";
            this.statusComboBox.IntegralHeight = false;
            this.statusComboBox.ItemHeight = 43;
            this.statusComboBox.Items.AddRange(new object[] {
            "Bận",
            "Rảnh"});
            this.statusComboBox.Location = new System.Drawing.Point(154, 27);
            this.statusComboBox.MaxDropDownItems = 4;
            this.statusComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(140, 49);
            this.statusComboBox.StartIndex = -1;
            this.statusComboBox.TabIndex = 1;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.EffectType = MaterialSurface.ET.Custom;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(3, 27);
            this.addButton.MouseState = MaterialSurface.MouseState.OUT;
            this.addButton.Name = "addButton";
            this.addButton.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.addButton.Radius = 6;
            this.addButton.ShawdowDepth = 3;
            this.addButton.ShawdowOpacity = 50;
            this.addButton.Size = new System.Drawing.Size(126, 50);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Thêm";
            this.addButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.White;
            this.delButton.EffectType = MaterialSurface.ET.Custom;
            this.delButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.delButton.Icon = null;
            this.delButton.Location = new System.Drawing.Point(135, 27);
            this.delButton.MouseState = MaterialSurface.MouseState.OUT;
            this.delButton.Name = "delButton";
            this.delButton.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.delButton.Radius = 6;
            this.delButton.ShawdowDepth = 3;
            this.delButton.ShawdowOpacity = 50;
            this.delButton.Size = new System.Drawing.Size(126, 50);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "Xóa";
            this.delButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // cardList
            // 
            this.cardList.AutoSizeTable = false;
            this.cardList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardList.CheckBoxes = true;
            this.cardList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Owner,
            this.Type,
            this.Status,
            this.Start_date});
            this.cardList.Depth = 0;
            this.cardList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardList.FullRowSelect = true;
            this.cardList.HideSelection = false;
            listViewItem4.StateImageIndex = 0;
            this.cardList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.cardList.Location = new System.Drawing.Point(0, 0);
            this.cardList.MinimumSize = new System.Drawing.Size(200, 100);
            this.cardList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cardList.MouseState = MaterialSkin.MouseState.OUT;
            this.cardList.Name = "cardList";
            this.cardList.OwnerDraw = true;
            this.cardList.Size = new System.Drawing.Size(1078, 537);
            this.cardList.TabIndex = 1;
            this.cardList.UseCompatibleStateImageBehavior = false;
            this.cardList.View = System.Windows.Forms.View.Details;
            this.cardList.SelectedIndexChanged += new System.EventHandler(this.cardList_SelectedIndexChanged);
            this.cardList.DoubleClick += new System.EventHandler(this.cardList_DoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 67;
            // 
            // Owner
            // 
            this.Owner.Text = "Chủ sở hữu";
            this.Owner.Width = 228;
            // 
            // Type
            // 
            this.Type.Text = "Loại";
            this.Type.Width = 153;
            // 
            // Status
            // 
            this.Status.Text = "Trạng thái";
            this.Status.Width = 168;
            // 
            // Start_date
            // 
            this.Start_date.Text = "Ngày bắt đầu";
            this.Start_date.Width = 448;
            // 
            // inOutButton
            // 
            this.inOutButton.EffectType = MaterialSurface.ET.Custom;
            this.inOutButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inOutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inOutButton.Icon = null;
            this.inOutButton.Location = new System.Drawing.Point(267, 27);
            this.inOutButton.MouseState = MaterialSurface.MouseState.OUT;
            this.inOutButton.Name = "inOutButton";
            this.inOutButton.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.inOutButton.Radius = 6;
            this.inOutButton.ShawdowDepth = 3;
            this.inOutButton.ShawdowOpacity = 50;
            this.inOutButton.Size = new System.Drawing.Size(119, 50);
            this.inOutButton.TabIndex = 2;
            this.inOutButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.inOutButton.UseVisualStyleBackColor = true;
            // 
            // typeComboBox
            // 
            this.typeComboBox.AutoResize = false;
            this.typeComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.typeComboBox.Depth = 0;
            this.typeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.typeComboBox.DropDownHeight = 174;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.DropDownWidth = 121;
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.typeComboBox.ForeColor = System.Drawing.Color.White;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Hint = "Type";
            this.typeComboBox.IntegralHeight = false;
            this.typeComboBox.ItemHeight = 43;
            this.typeComboBox.Location = new System.Drawing.Point(300, 27);
            this.typeComboBox.MaxDropDownItems = 4;
            this.typeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(140, 49);
            this.typeComboBox.StartIndex = 0;
            this.typeComboBox.TabIndex = 5;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.splitContainer1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1078, 100);
            this.topPanel.TabIndex = 6;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1078, 637);
            this.mainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cardList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 537);
            this.panel1.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.addButton);
            this.splitContainer1.Panel1.Controls.Add(this.delButton);
            this.splitContainer1.Panel1.Controls.Add(this.inOutButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.typeComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.statusComboBox);
            this.splitContainer1.Size = new System.Drawing.Size(1078, 100);
            this.splitContainer1.SplitterDistance = 530;
            this.splitContainer1.TabIndex = 0;
            // 
            // CardManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Name = "CardManagement";
            this.Size = new System.Drawing.Size(1078, 637);
            this.Load += new System.EventHandler(this.CardManagement_Load);
            this.topPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox statusComboBox;
        private MaterialSurface.ContainedButton addButton;
        private MaterialSurface.ContainedButton delButton;
        private MaterialSkin.Controls.MaterialListView cardList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Owner;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Start_date;
        private MaterialSkin.Controls.MaterialComboBox typeComboBox;
        private MaterialSurface.ContainedButton inOutButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
