
namespace dekatreís_octavo.View
{
    partial class EditCard
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
            this.cb_LoaiThe = new MaterialSurface.MaterialComboBox();
            this.bt_Confirm = new MaterialSkin.Controls.MaterialButton();
            this.tb_BienSo = new MaterialSurface.MaterialTextfield();
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.editButton = new MaterialSkin.Controls.MaterialButton();
            this.anhXe1 = new System.Windows.Forms.PictureBox();
            this.inTime = new MaterialSurface.MaterialTextfield();
            this.startDate = new MaterialSurface.MaterialTextfield();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhXe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_LoaiThe
            // 
            this.cb_LoaiThe.AutoSizing = false;
            this.cb_LoaiThe.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cb_LoaiThe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_LoaiThe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LoaiThe.DropDownWidth = 121;
            this.cb_LoaiThe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_LoaiThe.FormattingEnabled = true;
            this.cb_LoaiThe.HintText = "Loại thẻ";
            this.cb_LoaiThe.ItemHeight = 47;
            this.cb_LoaiThe.Location = new System.Drawing.Point(40, 268);
            this.cb_LoaiThe.MaxDropDownItems = 4;
            this.cb_LoaiThe.MouseState = MaterialSurface.MouseState.OUT;
            this.cb_LoaiThe.Name = "cb_LoaiThe";
            this.cb_LoaiThe.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.cb_LoaiThe.Size = new System.Drawing.Size(221, 53);
            this.cb_LoaiThe.TabIndex = 9;
            // 
            // bt_Confirm
            // 
            this.bt_Confirm.AutoSize = false;
            this.bt_Confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_Confirm.Depth = 0;
            this.bt_Confirm.HighEmphasis = true;
            this.bt_Confirm.Icon = null;
            this.bt_Confirm.Location = new System.Drawing.Point(151, 385);
            this.bt_Confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_Confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_Confirm.Name = "bt_Confirm";
            this.bt_Confirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_Confirm.Size = new System.Drawing.Size(148, 36);
            this.bt_Confirm.TabIndex = 7;
            this.bt_Confirm.Text = "Xác nhận";
            this.bt_Confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_Confirm.UseAccentColor = false;
            this.bt_Confirm.UseVisualStyleBackColor = true;
            this.bt_Confirm.Click += new System.EventHandler(this.bt_Confirm_Click);
            // 
            // tb_BienSo
            // 
            this.tb_BienSo.AutoScaleColor = true;
            this.tb_BienSo.BackColor = System.Drawing.Color.White;
            this.tb_BienSo.CountText = false;
            this.tb_BienSo.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_BienSo.FloatingLabelText = "FloatingLabel";
            this.tb_BienSo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_BienSo.HandleError = false;
            this.tb_BienSo.HelperText = "";
            this.tb_BienSo.HideSelection = true;
            this.tb_BienSo.HintText = "Biển số";
            this.tb_BienSo.Location = new System.Drawing.Point(40, 98);
            this.tb_BienSo.MaxLength = 32767;
            this.tb_BienSo.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_BienSo.Multiline = false;
            this.tb_BienSo.Name = "tb_BienSo";
            this.tb_BienSo.PasswordChar = '\0';
            this.tb_BienSo.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.tb_BienSo.ReadOnly = false;
            this.tb_BienSo.ShortcutsEnable = true;
            this.tb_BienSo.ShowCaret = true;
            this.tb_BienSo.Size = new System.Drawing.Size(224, 49);
            this.tb_BienSo.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_BienSo.TabIndex = 14;
            this.tb_BienSo.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.SystemColors.Control;
            this.materialCard1.CardColor = System.Drawing.Color.White;
            this.materialCard1.Controls.Add(this.pictureBox3);
            this.materialCard1.Controls.Add(this.pictureBox2);
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Controls.Add(this.editButton);
            this.materialCard1.Controls.Add(this.anhXe1);
            this.materialCard1.Controls.Add(this.inTime);
            this.materialCard1.Controls.Add(this.startDate);
            this.materialCard1.Controls.Add(this.bt_Confirm);
            this.materialCard1.Controls.Add(this.cb_LoaiThe);
            this.materialCard1.Controls.Add(this.tb_BienSo);
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard1.MouseInteract = false;
            this.materialCard1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Radius = 8;
            this.materialCard1.ShawdowDepth = 2;
            this.materialCard1.ShawdowOpacity = 50;
            this.materialCard1.Size = new System.Drawing.Size(669, 459);
            this.materialCard1.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard1.TabIndex = 15;
            // 
            // editButton
            // 
            this.editButton.AutoSize = false;
            this.editButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.editButton.Depth = 0;
            this.editButton.HighEmphasis = true;
            this.editButton.Icon = null;
            this.editButton.Location = new System.Drawing.Point(331, 385);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.editButton.Name = "editButton";
            this.editButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.editButton.Size = new System.Drawing.Size(150, 36);
            this.editButton.TabIndex = 21;
            this.editButton.Text = "Chỉnh sửa";
            this.editButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.editButton.UseAccentColor = false;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // anhXe1
            // 
            this.anhXe1.Location = new System.Drawing.Point(320, 26);
            this.anhXe1.Name = "anhXe1";
            this.anhXe1.Size = new System.Drawing.Size(150, 150);
            this.anhXe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.anhXe1.TabIndex = 17;
            this.anhXe1.TabStop = false;
            // 
            // inTime
            // 
            this.inTime.AutoScaleColor = true;
            this.inTime.BackColor = System.Drawing.Color.White;
            this.inTime.CountText = false;
            this.inTime.FieldType = MaterialSurface.BoxType.Normal;
            this.inTime.FloatingLabelText = "FloatingLabel";
            this.inTime.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.inTime.HandleError = false;
            this.inTime.HelperText = "";
            this.inTime.HideSelection = true;
            this.inTime.HintText = "Thời gian gửi";
            this.inTime.Location = new System.Drawing.Point(40, 185);
            this.inTime.MaxLength = 32767;
            this.inTime.MouseState = MaterialSurface.MouseState.OUT;
            this.inTime.Multiline = false;
            this.inTime.Name = "inTime";
            this.inTime.PasswordChar = '\0';
            this.inTime.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.inTime.ReadOnly = false;
            this.inTime.ShortcutsEnable = true;
            this.inTime.ShowCaret = true;
            this.inTime.Size = new System.Drawing.Size(224, 49);
            this.inTime.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.inTime.TabIndex = 16;
            this.inTime.UseSystemPasswordChar = false;
            // 
            // startDate
            // 
            this.startDate.AutoScaleColor = true;
            this.startDate.BackColor = System.Drawing.Color.White;
            this.startDate.CountText = false;
            this.startDate.FieldType = MaterialSurface.BoxType.Normal;
            this.startDate.FloatingLabelText = "FloatingLabel";
            this.startDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.startDate.HandleError = false;
            this.startDate.HelperText = "";
            this.startDate.HideSelection = true;
            this.startDate.HintText = "Ngày bắt đầu";
            this.startDate.Location = new System.Drawing.Point(40, 26);
            this.startDate.MaxLength = 32767;
            this.startDate.MouseState = MaterialSurface.MouseState.OUT;
            this.startDate.Multiline = false;
            this.startDate.Name = "startDate";
            this.startDate.PasswordChar = '\0';
            this.startDate.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.startDate.ReadOnly = false;
            this.startDate.ShortcutsEnable = true;
            this.startDate.ShowCaret = true;
            this.startDate.Size = new System.Drawing.Size(224, 49);
            this.startDate.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.startDate.TabIndex = 15;
            this.startDate.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(497, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(320, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(497, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // EditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 459);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCard";
            this.Text = "EditCard";
            this.Load += new System.EventHandler(this.EditCard_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anhXe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSurface.MaterialComboBox cb_LoaiThe;
        private MaterialSkin.Controls.MaterialButton bt_Confirm;
        private MaterialSurface.MaterialTextfield tb_BienSo;
        private MaterialSurface.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton editButton;
        private System.Windows.Forms.PictureBox anhXe1;
        private MaterialSurface.MaterialTextfield inTime;
        private MaterialSurface.MaterialTextfield startDate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}