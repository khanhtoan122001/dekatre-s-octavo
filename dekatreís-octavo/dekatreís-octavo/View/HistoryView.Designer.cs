
namespace dekatreís_octavo.View
{
    partial class HistoryView
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.findTextBox = new MaterialSurface.MaterialTextfield();
            this.historyList = new MaterialSkin.Controls.MaterialListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cardID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.licensePlate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bt_refresh = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // findTextBox
            // 
            this.findTextBox.AutoScaleColor = true;
            this.findTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.findTextBox.CountText = false;
            this.findTextBox.FieldType = MaterialSurface.BoxType.Normal;
            this.findTextBox.FloatingLabelText = "FloatingLabel";
            this.findTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.findTextBox.HandleError = false;
            this.findTextBox.HelperText = "";
            this.findTextBox.HideSelection = true;
            this.findTextBox.HintText = "Tìm kiếm";
            this.findTextBox.Location = new System.Drawing.Point(13, 6);
            this.findTextBox.MaxLength = 32767;
            this.findTextBox.MouseState = MaterialSurface.MouseState.OUT;
            this.findTextBox.Multiline = false;
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.PasswordChar = '\0';
            this.findTextBox.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.findTextBox.ReadOnly = false;
            this.findTextBox.ShortcutsEnable = true;
            this.findTextBox.ShowCaret = true;
            this.findTextBox.Size = new System.Drawing.Size(200, 49);
            this.findTextBox.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.findTextBox.TabIndex = 4;
            this.findTextBox.UseSystemPasswordChar = false;
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
            this.cardID,
            this.licensePlate});
            this.historyList.Depth = 0;
            this.historyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyList.FullRowSelect = true;
            this.historyList.HideSelection = false;
            this.historyList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.historyList.Location = new System.Drawing.Point(3, 98);
            this.historyList.MinimumSize = new System.Drawing.Size(200, 100);
            this.historyList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.historyList.MouseState = MaterialSkin.MouseState.OUT;
            this.historyList.Name = "historyList";
            this.historyList.OwnerDraw = true;
            this.historyList.Size = new System.Drawing.Size(794, 346);
            this.historyList.TabIndex = 3;
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
            this.time.Width = 180;
            // 
            // type
            // 
            this.type.Text = "Loại";
            this.type.Width = 120;
            // 
            // cardID
            // 
            this.cardID.Text = "ID thẻ";
            this.cardID.Width = 120;
            // 
            // licensePlate
            // 
            this.licensePlate.Text = "Biển số xe";
            this.licensePlate.Width = 180;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(588, 33);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // bt_refresh
            // 
            this.bt_refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_refresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_refresh.Depth = 0;
            this.bt_refresh.HighEmphasis = true;
            this.bt_refresh.Icon = null;
            this.bt_refresh.Location = new System.Drawing.Point(380, 19);
            this.bt_refresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_refresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_refresh.Size = new System.Drawing.Size(158, 36);
            this.bt_refresh.TabIndex = 6;
            this.bt_refresh.Text = "refresh";
            this.bt_refresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_refresh.UseAccentColor = false;
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // HistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.historyList);
            this.Name = "HistoryView";
            this.Text = "HistoryView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSurface.MaterialTextfield findTextBox;
        private MaterialSkin.Controls.MaterialListView historyList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader cardID;
        private System.Windows.Forms.ColumnHeader licensePlate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private MaterialSkin.Controls.MaterialButton bt_refresh;
    }
}