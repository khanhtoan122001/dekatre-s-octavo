
namespace dekatreís_octavo.View
{
    partial class ParkingView
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
            this.cb_ListTheXe = new MaterialSurface.MaterialComboBox();
            this.tb_BienSo = new MaterialSurface.MaterialTextfield();
            this.containedButton1 = new MaterialSurface.ContainedButton();
            this.SuspendLayout();
            // 
            // cb_ListTheXe
            // 
            this.cb_ListTheXe.AutoSizing = false;
            this.cb_ListTheXe.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cb_ListTheXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_ListTheXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ListTheXe.DropDownWidth = 121;
            this.cb_ListTheXe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_ListTheXe.FormattingEnabled = true;
            this.cb_ListTheXe.HintText = "";
            this.cb_ListTheXe.ItemHeight = 47;
            this.cb_ListTheXe.Location = new System.Drawing.Point(234, 97);
            this.cb_ListTheXe.MaxDropDownItems = 4;
            this.cb_ListTheXe.MouseState = MaterialSurface.MouseState.OUT;
            this.cb_ListTheXe.Name = "cb_ListTheXe";
            this.cb_ListTheXe.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.cb_ListTheXe.Size = new System.Drawing.Size(121, 53);
            this.cb_ListTheXe.TabIndex = 0;
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
            this.tb_BienSo.HintText = "Biển số xe";
            this.tb_BienSo.Location = new System.Drawing.Point(234, 172);
            this.tb_BienSo.MaxLength = 32767;
            this.tb_BienSo.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_BienSo.Multiline = false;
            this.tb_BienSo.Name = "tb_BienSo";
            this.tb_BienSo.PasswordChar = '\0';
            this.tb_BienSo.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.tb_BienSo.ReadOnly = false;
            this.tb_BienSo.ShortcutsEnable = true;
            this.tb_BienSo.ShowCaret = true;
            this.tb_BienSo.Size = new System.Drawing.Size(200, 49);
            this.tb_BienSo.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_BienSo.TabIndex = 1;
            this.tb_BienSo.UseSystemPasswordChar = false;
            this.tb_BienSo.TextChanged += new System.EventHandler(this.materialTextfield1_TextChanged);
            // 
            // containedButton1
            // 
            this.containedButton1.EffectType = MaterialSurface.ET.Custom;
            this.containedButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.containedButton1.Icon = null;
            this.containedButton1.Location = new System.Drawing.Point(234, 279);
            this.containedButton1.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton1.Name = "containedButton1";
            this.containedButton1.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.containedButton1.Radius = 6;
            this.containedButton1.ShawdowDepth = 3;
            this.containedButton1.ShawdowOpacity = 50;
            this.containedButton1.Size = new System.Drawing.Size(165, 65);
            this.containedButton1.TabIndex = 2;
            this.containedButton1.Text = "Xác nhận";
            this.containedButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton1.UseVisualStyleBackColor = true;
            this.containedButton1.Click += new System.EventHandler(this.containedButton1_Click);
            // 
            // ParkingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.containedButton1);
            this.Controls.Add(this.tb_BienSo);
            this.Controls.Add(this.cb_ListTheXe);
            this.Name = "ParkingView";
            this.Size = new System.Drawing.Size(791, 483);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSurface.MaterialComboBox cb_ListTheXe;
        private MaterialSurface.MaterialTextfield tb_BienSo;
        private MaterialSurface.ContainedButton containedButton1;
    }
}
