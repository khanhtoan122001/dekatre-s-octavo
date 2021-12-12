
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.Panel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cardID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.license = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.refreshButton = new MaterialSurface.ContainedButton();
            this.mainPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.listPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.listPanel);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(660, 401);
            this.mainPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.refreshButton);
            this.topPanel.Controls.Add(this.searchTextBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(660, 100);
            this.topPanel.TabIndex = 0;
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.materialListView1);
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanel.Location = new System.Drawing.Point(0, 100);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(660, 301);
            this.listPanel.TabIndex = 1;
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.time,
            this.type,
            this.cardID,
            this.license});
            this.materialListView1.Depth = 0;
            this.materialListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(0, 0);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(660, 301);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // time
            // 
            this.time.Text = "Thời gian";
            this.time.Width = 131;
            // 
            // type
            // 
            this.type.Text = "Loại";
            this.type.Width = 148;
            // 
            // cardID
            // 
            this.cardID.Text = "ID thẻ";
            this.cardID.Width = 98;
            // 
            // license
            // 
            this.license.Text = "Biển số xe";
            this.license.Width = 208;
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
            // 
            // refreshButton
            // 
            this.refreshButton.EffectType = MaterialSurface.ET.Custom;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.refreshButton.Icon = null;
            this.refreshButton.Location = new System.Drawing.Point(339, 23);
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
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "History";
            this.Size = new System.Drawing.Size(660, 401);
            this.mainPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.listPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel listPanel;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader cardID;
        private System.Windows.Forms.ColumnHeader license;
        private MaterialSurface.ContainedButton refreshButton;
        private MaterialSkin.Controls.MaterialTextBox searchTextBox;
    }
}
