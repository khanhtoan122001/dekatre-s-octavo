
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.addButton = new MaterialSurface.ContainedButton();
            this.delButton = new MaterialSurface.ContainedButton();
            this.cardList = new MaterialSkin.Controls.MaterialListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Owner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.In_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inOutButton = new MaterialSurface.ContainedButton();
            this.topPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.createButton = new MaterialSurface.ContainedButton();
            this.tb_search = new MaterialSurface.MaterialTextfield();
            this.typeComboBox = new MaterialSurface.MaterialComboBox();
            this.statusComboBox = new MaterialSurface.MaterialComboBox();
            this.inputCard = new MaterialSurface.MaterialCard();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inputTextBox = new MaterialSurface.MaterialTextfield();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addCard = new MaterialSurface.MaterialCard();
            this.materialComboBox1 = new MaterialSurface.MaterialComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.inputCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.addCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.EffectType = MaterialSurface.ET.Custom;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(3, 11);
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
            this.delButton.Location = new System.Drawing.Point(135, 11);
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
            this.In_date,
            this.Start_date});
            this.cardList.Depth = 0;
            this.cardList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardList.FullRowSelect = true;
            this.cardList.HideSelection = false;
            listViewItem2.StateImageIndex = 0;
            this.cardList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.cardList.Location = new System.Drawing.Point(0, 0);
            this.cardList.MinimumSize = new System.Drawing.Size(200, 100);
            this.cardList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cardList.MouseState = MaterialSkin.MouseState.OUT;
            this.cardList.Name = "cardList";
            this.cardList.OwnerDraw = true;
            this.cardList.Size = new System.Drawing.Size(1269, 486);
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
            this.Owner.Text = "Biển số";
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
            this.Status.Width = 115;
            // 
            // In_date
            // 
            this.In_date.Text = "Ngày gửi";
            this.In_date.Width = 240;
            // 
            // Start_date
            // 
            this.Start_date.Text = "Ngày bắt đầu";
            this.Start_date.Width = 240;
            // 
            // inOutButton
            // 
            this.inOutButton.EffectType = MaterialSurface.ET.Custom;
            this.inOutButton.Enabled = false;
            this.inOutButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inOutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inOutButton.Icon = null;
            this.inOutButton.Location = new System.Drawing.Point(267, 11);
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
            this.inOutButton.Click += new System.EventHandler(this.inOutButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.splitContainer1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1269, 151);
            this.topPanel.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.addCard);
            this.splitContainer1.Panel1.Controls.Add(this.createButton);
            this.splitContainer1.Panel1.Controls.Add(this.addButton);
            this.splitContainer1.Panel1.Controls.Add(this.delButton);
            this.splitContainer1.Panel1.Controls.Add(this.inOutButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tb_search);
            this.splitContainer1.Panel2.Controls.Add(this.typeComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.statusComboBox);
            this.splitContainer1.Size = new System.Drawing.Size(1269, 151);
            this.splitContainer1.SplitterDistance = 659;
            this.splitContainer1.TabIndex = 0;
            // 
            // createButton
            // 
            this.createButton.EffectType = MaterialSurface.ET.Custom;
            this.createButton.Enabled = false;
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.createButton.Icon = null;
            this.createButton.Location = new System.Drawing.Point(392, 11);
            this.createButton.MouseState = MaterialSurface.MouseState.OUT;
            this.createButton.Name = "createButton";
            this.createButton.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.createButton.Radius = 6;
            this.createButton.ShawdowDepth = 3;
            this.createButton.ShawdowOpacity = 50;
            this.createButton.Size = new System.Drawing.Size(119, 50);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Tạo";
            this.createButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // tb_search
            // 
            this.tb_search.AutoScaleColor = true;
            this.tb_search.BackColor = System.Drawing.Color.White;
            this.tb_search.CountText = false;
            this.tb_search.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_search.FloatingLabelText = "FloatingLabel";
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_search.HandleError = false;
            this.tb_search.HelperText = "";
            this.tb_search.HideSelection = true;
            this.tb_search.HintText = "Tìm kiếm";
            this.tb_search.Location = new System.Drawing.Point(16, 13);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_search.MaxLength = 32767;
            this.tb_search.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_search.Multiline = false;
            this.tb_search.Name = "tb_search";
            this.tb_search.PasswordChar = '\0';
            this.tb_search.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.tb_search.ReadOnly = false;
            this.tb_search.ShortcutsEnable = true;
            this.tb_search.ShowCaret = true;
            this.tb_search.Size = new System.Drawing.Size(341, 49);
            this.tb_search.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_search.TabIndex = 8;
            this.tb_search.UseSystemPasswordChar = false;
            this.tb_search.TextChanged += new System.EventHandler(this.materialTextfield1_TextChanged);
            // 
            // typeComboBox
            // 
            this.typeComboBox.AutoSizing = false;
            this.typeComboBox.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.typeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.DropDownWidth = 121;
            this.typeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.HintText = "Loại thẻ";
            this.typeComboBox.ItemHeight = 47;
            this.typeComboBox.Items.AddRange(new object[] {
            "All",
            "Thẻ thường",
            "Thẻ tháng"});
            this.typeComboBox.Location = new System.Drawing.Point(162, 66);
            this.typeComboBox.MaxDropDownItems = 4;
            this.typeComboBox.MouseState = MaterialSurface.MouseState.OUT;
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.typeComboBox.Size = new System.Drawing.Size(140, 53);
            this.typeComboBox.TabIndex = 7;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // statusComboBox
            // 
            this.statusComboBox.AutoSizing = false;
            this.statusComboBox.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.statusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.DropDownWidth = 121;
            this.statusComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.HintText = "Trạng thái";
            this.statusComboBox.ItemHeight = 47;
            this.statusComboBox.Items.AddRange(new object[] {
            "All",
            "Rảnh",
            "Bận"});
            this.statusComboBox.Location = new System.Drawing.Point(16, 67);
            this.statusComboBox.MaxDropDownItems = 4;
            this.statusComboBox.MouseState = MaterialSurface.MouseState.OUT;
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.statusComboBox.Size = new System.Drawing.Size(140, 53);
            this.statusComboBox.TabIndex = 6;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // inputCard
            // 
            this.inputCard.BackColor = System.Drawing.Color.White;
            this.inputCard.CardColor = System.Drawing.Color.White;
            this.inputCard.Controls.Add(this.pictureBox3);
            this.inputCard.Controls.Add(this.pictureBox2);
            this.inputCard.Controls.Add(this.pictureBox1);
            this.inputCard.Controls.Add(this.inputTextBox);
            this.inputCard.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCard.Location = new System.Drawing.Point(267, 67);
            this.inputCard.Margin = new System.Windows.Forms.Padding(5);
            this.inputCard.MouseInteract = false;
            this.inputCard.MouseState = MaterialSurface.MouseState.OUT;
            this.inputCard.Name = "inputCard";
            this.inputCard.Radius = 8;
            this.inputCard.ShawdowDepth = 2;
            this.inputCard.ShawdowOpacity = 50;
            this.inputCard.Size = new System.Drawing.Size(378, 79);
            this.inputCard.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.inputCard.TabIndex = 4;
            this.inputCard.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::dekatreís_octavo.Properties.Resources.photo;
            this.pictureBox3.Location = new System.Drawing.Point(242, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::dekatreís_octavo.Properties.Resources._62025;
            this.pictureBox2.Location = new System.Drawing.Point(287, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dekatreís_octavo.Properties.Resources.x_button_icon_20;
            this.pictureBox1.Location = new System.Drawing.Point(331, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.AutoScaleColor = true;
            this.inputTextBox.BackColor = System.Drawing.Color.White;
            this.inputTextBox.CountText = false;
            this.inputTextBox.FieldType = MaterialSurface.BoxType.Normal;
            this.inputTextBox.FloatingLabelText = "FloatingLabel";
            this.inputTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.inputTextBox.HandleError = false;
            this.inputTextBox.HelperText = "";
            this.inputTextBox.HideSelection = true;
            this.inputTextBox.HintText = "Biển số xe";
            this.inputTextBox.Location = new System.Drawing.Point(15, 15);
            this.inputTextBox.MaxLength = 32767;
            this.inputTextBox.MouseState = MaterialSurface.MouseState.OUT;
            this.inputTextBox.Multiline = false;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.PasswordChar = '\0';
            this.inputTextBox.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.inputTextBox.ReadOnly = false;
            this.inputTextBox.ShortcutsEnable = true;
            this.inputTextBox.ShowCaret = true;
            this.inputTextBox.Size = new System.Drawing.Size(211, 49);
            this.inputTextBox.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.UseSystemPasswordChar = false;
            this.inputTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyUp);
            this.inputTextBox.Leave += new System.EventHandler(this.inputTextBox_Leave);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.inputCard);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1269, 637);
            this.mainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cardList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 486);
            this.panel1.TabIndex = 7;
            // 
            // addCard
            // 
            this.addCard.BackColor = System.Drawing.Color.White;
            this.addCard.CardColor = System.Drawing.Color.White;
            this.addCard.Controls.Add(this.pictureBox5);
            this.addCard.Controls.Add(this.pictureBox4);
            this.addCard.Controls.Add(this.materialComboBox1);
            this.addCard.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCard.Location = new System.Drawing.Point(5, 66);
            this.addCard.Margin = new System.Windows.Forms.Padding(5);
            this.addCard.MouseInteract = false;
            this.addCard.MouseState = MaterialSurface.MouseState.OUT;
            this.addCard.Name = "addCard";
            this.addCard.Radius = 8;
            this.addCard.ShawdowDepth = 2;
            this.addCard.ShawdowOpacity = 50;
            this.addCard.Size = new System.Drawing.Size(252, 80);
            this.addCard.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.addCard.TabIndex = 6;
            this.addCard.Visible = false;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoSizing = false;
            this.materialComboBox1.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.HintText = "Loại thẻ";
            this.materialComboBox1.ItemHeight = 47;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Thẻ thường",
            "Thẻ tháng"});
            this.materialComboBox1.Location = new System.Drawing.Point(16, 12);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.materialComboBox1.Size = new System.Drawing.Size(121, 53);
            this.materialComboBox1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::dekatreís_octavo.Properties.Resources._62025;
            this.pictureBox4.Location = new System.Drawing.Point(164, 27);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::dekatreís_octavo.Properties.Resources.x_button_icon_20;
            this.pictureBox5.Location = new System.Drawing.Point(203, 27);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // CardManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Name = "CardManagement";
            this.Size = new System.Drawing.Size(1269, 637);
            this.Load += new System.EventHandler(this.CardManagement_Load);
            this.topPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.inputCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.addCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSurface.ContainedButton addButton;
        private MaterialSurface.ContainedButton delButton;
        private MaterialSkin.Controls.MaterialListView cardList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Owner;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Start_date;
        private MaterialSurface.ContainedButton inOutButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MaterialSurface.MaterialCard inputCard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSurface.MaterialTextfield inputTextBox;
        private System.Windows.Forms.ColumnHeader In_date;
        private MaterialSurface.MaterialComboBox typeComboBox;
        private MaterialSurface.MaterialComboBox statusComboBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSurface.ContainedButton createButton;
        private MaterialSurface.MaterialTextfield tb_search;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSurface.MaterialCard addCard;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSurface.MaterialComboBox materialComboBox1;
    }
}
