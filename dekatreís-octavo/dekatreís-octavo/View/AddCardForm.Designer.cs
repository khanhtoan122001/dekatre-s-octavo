
namespace dekatreís_octavo.View
{
    partial class AddCardForm
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
            this.bt_Confirm = new MaterialSkin.Controls.MaterialButton();
            this.cb_LoaiThe = new MaterialSurface.MaterialComboBox();
            this.tb_TenChuSoHuu = new MaterialSurface.MaterialTextfield();
            this.tb_TenXe = new MaterialSurface.MaterialTextfield();
            this.tb_BienSo = new MaterialSurface.MaterialTextfield();
            this.SuspendLayout();
            // 
            // bt_Confirm
            // 
            this.bt_Confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_Confirm.Depth = 0;
            this.bt_Confirm.HighEmphasis = true;
            this.bt_Confirm.Icon = null;
            this.bt_Confirm.Location = new System.Drawing.Point(179, 390);
            this.bt_Confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_Confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_Confirm.Name = "bt_Confirm";
            this.bt_Confirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_Confirm.Size = new System.Drawing.Size(95, 36);
            this.bt_Confirm.TabIndex = 2;
            this.bt_Confirm.Text = "Xác nhận";
            this.bt_Confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_Confirm.UseAccentColor = false;
            this.bt_Confirm.UseVisualStyleBackColor = true;
            this.bt_Confirm.Click += new System.EventHandler(this.bt_Confirm_Click);
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
            this.cb_LoaiThe.Location = new System.Drawing.Point(179, 305);
            this.cb_LoaiThe.MaxDropDownItems = 4;
            this.cb_LoaiThe.MouseState = MaterialSurface.MouseState.OUT;
            this.cb_LoaiThe.Name = "cb_LoaiThe";
            this.cb_LoaiThe.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.cb_LoaiThe.Size = new System.Drawing.Size(317, 53);
            this.cb_LoaiThe.TabIndex = 4;
            this.cb_LoaiThe.SelectedIndexChanged += new System.EventHandler(this.cb_LoaiThe_SelectedIndexChanged);
            // 
            // tb_TenChuSoHuu
            // 
            this.tb_TenChuSoHuu.AutoScaleColor = true;
            this.tb_TenChuSoHuu.BackColor = System.Drawing.SystemColors.Control;
            this.tb_TenChuSoHuu.CountText = false;
            this.tb_TenChuSoHuu.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_TenChuSoHuu.FloatingLabelText = "FloatingLabel";
            this.tb_TenChuSoHuu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_TenChuSoHuu.HandleError = false;
            this.tb_TenChuSoHuu.HelperText = "";
            this.tb_TenChuSoHuu.HideSelection = true;
            this.tb_TenChuSoHuu.HintText = "Tên chủ sở hữu";
            this.tb_TenChuSoHuu.Location = new System.Drawing.Point(179, 75);
            this.tb_TenChuSoHuu.MaxLength = 32767;
            this.tb_TenChuSoHuu.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_TenChuSoHuu.Multiline = false;
            this.tb_TenChuSoHuu.Name = "tb_TenChuSoHuu";
            this.tb_TenChuSoHuu.PasswordChar = '\0';
            this.tb_TenChuSoHuu.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.tb_TenChuSoHuu.ReadOnly = false;
            this.tb_TenChuSoHuu.ShortcutsEnable = true;
            this.tb_TenChuSoHuu.ShowCaret = true;
            this.tb_TenChuSoHuu.Size = new System.Drawing.Size(317, 49);
            this.tb_TenChuSoHuu.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_TenChuSoHuu.TabIndex = 6;
            this.tb_TenChuSoHuu.UseSystemPasswordChar = false;
            // 
            // tb_TenXe
            // 
            this.tb_TenXe.AutoScaleColor = true;
            this.tb_TenXe.BackColor = System.Drawing.SystemColors.Control;
            this.tb_TenXe.CountText = false;
            this.tb_TenXe.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_TenXe.FloatingLabelText = "FloatingLabel";
            this.tb_TenXe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_TenXe.HandleError = false;
            this.tb_TenXe.HelperText = "";
            this.tb_TenXe.HideSelection = true;
            this.tb_TenXe.HintText = "Tên xe";
            this.tb_TenXe.Location = new System.Drawing.Point(179, 155);
            this.tb_TenXe.MaxLength = 32767;
            this.tb_TenXe.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_TenXe.Multiline = false;
            this.tb_TenXe.Name = "tb_TenXe";
            this.tb_TenXe.PasswordChar = '\0';
            this.tb_TenXe.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.tb_TenXe.ReadOnly = false;
            this.tb_TenXe.ShortcutsEnable = true;
            this.tb_TenXe.ShowCaret = true;
            this.tb_TenXe.Size = new System.Drawing.Size(317, 49);
            this.tb_TenXe.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_TenXe.TabIndex = 7;
            this.tb_TenXe.UseSystemPasswordChar = false;
            // 
            // tb_BienSo
            // 
            this.tb_BienSo.AutoScaleColor = true;
            this.tb_BienSo.BackColor = System.Drawing.SystemColors.Control;
            this.tb_BienSo.CountText = false;
            this.tb_BienSo.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_BienSo.FloatingLabelText = "FloatingLabel";
            this.tb_BienSo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_BienSo.HandleError = false;
            this.tb_BienSo.HelperText = "";
            this.tb_BienSo.HideSelection = true;
            this.tb_BienSo.HintText = "Biển số";
            this.tb_BienSo.Location = new System.Drawing.Point(179, 230);
            this.tb_BienSo.MaxLength = 32767;
            this.tb_BienSo.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_BienSo.Multiline = false;
            this.tb_BienSo.Name = "tb_BienSo";
            this.tb_BienSo.PasswordChar = '\0';
            this.tb_BienSo.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.tb_BienSo.ReadOnly = false;
            this.tb_BienSo.ShortcutsEnable = true;
            this.tb_BienSo.ShowCaret = true;
            this.tb_BienSo.Size = new System.Drawing.Size(317, 49);
            this.tb_BienSo.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_BienSo.TabIndex = 8;
            this.tb_BienSo.UseSystemPasswordChar = false;
            // 
            // AddCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 482);
            this.Controls.Add(this.tb_BienSo);
            this.Controls.Add(this.tb_TenXe);
            this.Controls.Add(this.tb_TenChuSoHuu);
            this.Controls.Add(this.cb_LoaiThe);
            this.Controls.Add(this.bt_Confirm);
            this.Name = "AddCardForm";
            this.Text = "AddCardForm";
            this.Load += new System.EventHandler(this.AddCardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton bt_Confirm;
        private MaterialSurface.MaterialComboBox cb_LoaiThe;
        private MaterialSurface.MaterialTextfield tb_TenChuSoHuu;
        private MaterialSurface.MaterialTextfield tb_TenXe;
        private MaterialSurface.MaterialTextfield tb_BienSo;
    }
}