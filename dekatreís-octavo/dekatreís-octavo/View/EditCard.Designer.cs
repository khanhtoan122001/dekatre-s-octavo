
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
            this.tb_BienSo = new MaterialSkin.Controls.MaterialTextBox();
            this.bt_Confirm = new MaterialSkin.Controls.MaterialButton();
            this.tb_TenXe = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_TenChuSoHuu = new MaterialSkin.Controls.MaterialTextBox();
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
            this.cb_LoaiThe.HintText = "";
            this.cb_LoaiThe.ItemHeight = 47;
            this.cb_LoaiThe.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_LoaiThe.Location = new System.Drawing.Point(228, 271);
            this.cb_LoaiThe.MaxDropDownItems = 4;
            this.cb_LoaiThe.MouseState = MaterialSurface.MouseState.OUT;
            this.cb_LoaiThe.Name = "cb_LoaiThe";
            this.cb_LoaiThe.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.cb_LoaiThe.Size = new System.Drawing.Size(121, 53);
            this.cb_LoaiThe.TabIndex = 9;
            // 
            // tb_BienSo
            // 
            this.tb_BienSo.AnimateReadOnly = false;
            this.tb_BienSo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_BienSo.Depth = 0;
            this.tb_BienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_BienSo.LeadingIcon = null;
            this.tb_BienSo.Location = new System.Drawing.Point(228, 205);
            this.tb_BienSo.MaxLength = 50;
            this.tb_BienSo.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_BienSo.Multiline = false;
            this.tb_BienSo.Name = "tb_BienSo";
            this.tb_BienSo.Size = new System.Drawing.Size(258, 50);
            this.tb_BienSo.TabIndex = 8;
            this.tb_BienSo.Text = "";
            this.tb_BienSo.TrailingIcon = null;
            // 
            // bt_Confirm
            // 
            this.bt_Confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_Confirm.Depth = 0;
            this.bt_Confirm.HighEmphasis = true;
            this.bt_Confirm.Icon = null;
            this.bt_Confirm.Location = new System.Drawing.Point(218, 351);
            this.bt_Confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_Confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_Confirm.Name = "bt_Confirm";
            this.bt_Confirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_Confirm.Size = new System.Drawing.Size(95, 36);
            this.bt_Confirm.TabIndex = 7;
            this.bt_Confirm.Text = "Xác nhận";
            this.bt_Confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_Confirm.UseAccentColor = false;
            this.bt_Confirm.UseVisualStyleBackColor = true;
            this.bt_Confirm.Click += new System.EventHandler(this.bt_Confirm_Click);
            // 
            // tb_TenXe
            // 
            this.tb_TenXe.AnimateReadOnly = false;
            this.tb_TenXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TenXe.Depth = 0;
            this.tb_TenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_TenXe.LeadingIcon = null;
            this.tb_TenXe.Location = new System.Drawing.Point(228, 132);
            this.tb_TenXe.MaxLength = 50;
            this.tb_TenXe.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_TenXe.Multiline = false;
            this.tb_TenXe.Name = "tb_TenXe";
            this.tb_TenXe.Size = new System.Drawing.Size(258, 50);
            this.tb_TenXe.TabIndex = 6;
            this.tb_TenXe.Text = "";
            this.tb_TenXe.TrailingIcon = null;
            // 
            // tb_TenChuSoHuu
            // 
            this.tb_TenChuSoHuu.AnimateReadOnly = false;
            this.tb_TenChuSoHuu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TenChuSoHuu.Depth = 0;
            this.tb_TenChuSoHuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_TenChuSoHuu.LeadingIcon = null;
            this.tb_TenChuSoHuu.Location = new System.Drawing.Point(228, 57);
            this.tb_TenChuSoHuu.MaxLength = 50;
            this.tb_TenChuSoHuu.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_TenChuSoHuu.Multiline = false;
            this.tb_TenChuSoHuu.Name = "tb_TenChuSoHuu";
            this.tb_TenChuSoHuu.Size = new System.Drawing.Size(258, 50);
            this.tb_TenChuSoHuu.TabIndex = 5;
            this.tb_TenChuSoHuu.Text = "";
            this.tb_TenChuSoHuu.TrailingIcon = null;
            // 
            // EditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_LoaiThe);
            this.Controls.Add(this.tb_BienSo);
            this.Controls.Add(this.bt_Confirm);
            this.Controls.Add(this.tb_TenXe);
            this.Controls.Add(this.tb_TenChuSoHuu);
            this.Name = "EditCard";
            this.Text = "EditCard";
            this.Load += new System.EventHandler(this.EditCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSurface.MaterialComboBox cb_LoaiThe;
        private MaterialSkin.Controls.MaterialTextBox tb_BienSo;
        private MaterialSkin.Controls.MaterialButton bt_Confirm;
        private MaterialSkin.Controls.MaterialTextBox tb_TenXe;
        private MaterialSkin.Controls.MaterialTextBox tb_TenChuSoHuu;
    }
}