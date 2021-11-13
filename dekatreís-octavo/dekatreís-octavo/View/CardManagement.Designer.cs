
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
            this.statusComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.addButton = new MaterialSurface.ContainedButton();
            this.delButton = new MaterialSurface.ContainedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cardList = new MaterialSkin.Controls.MaterialListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Chusohuu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusComboBox.AutoResize = false;
            this.statusComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.statusComboBox.Location = new System.Drawing.Point(799, 47);
            this.statusComboBox.MaxDropDownItems = 4;
            this.statusComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(140, 49);
            this.statusComboBox.StartIndex = 0;
            this.statusComboBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.EffectType = MaterialSurface.ET.Custom;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(132, 47);
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
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delButton
            // 
            this.delButton.EffectType = MaterialSurface.ET.Custom;
            this.delButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.delButton.Icon = null;
            this.delButton.Location = new System.Drawing.Point(0, 47);
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
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cardList);
            this.panel1.Location = new System.Drawing.Point(3, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 399);
            this.panel1.TabIndex = 4;
            // 
            // cardList
            // 
            this.cardList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardList.AutoSizeTable = false;
            this.cardList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Chusohuu,
            this.Type,
            this.Status});
            this.cardList.Depth = 0;
            this.cardList.FullRowSelect = true;
            this.cardList.HideSelection = false;
            this.cardList.Location = new System.Drawing.Point(-3, 0);
            this.cardList.MinimumSize = new System.Drawing.Size(200, 100);
            this.cardList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cardList.MouseState = MaterialSkin.MouseState.OUT;
            this.cardList.Name = "cardList";
            this.cardList.OwnerDraw = true;
            this.cardList.Size = new System.Drawing.Size(939, 399);
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
            // Chusohuu
            // 
            this.Chusohuu.DisplayIndex = 3;
            this.Chusohuu.Text = "Chủ sở hữu";
            this.Chusohuu.Width = 185;
            // 
            // Type
            // 
            this.Type.DisplayIndex = 1;
            this.Type.Text = "Loại";
            // 
            // Status
            // 
            this.Status.DisplayIndex = 2;
            this.Status.Text = "Trạng thái";
            this.Status.Width = 252;
            // 
            // CardManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.statusComboBox);
            this.Name = "CardManagement";
            this.Size = new System.Drawing.Size(942, 536);
            this.Load += new System.EventHandler(this.CardManagement_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox statusComboBox;
        private MaterialSurface.ContainedButton addButton;
        private MaterialSurface.ContainedButton delButton;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialListView cardList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Chusohuu;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Status;
    }
}
