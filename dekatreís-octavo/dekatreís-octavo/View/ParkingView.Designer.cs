
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
            this.materialComboBox1 = new MaterialSurface.MaterialComboBox();
            this.materialTextfield1 = new MaterialSurface.MaterialTextfield();
            this.containedButton1 = new MaterialSurface.ContainedButton();
            this.SuspendLayout();
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
            this.materialComboBox1.HintText = "";
            this.materialComboBox1.ItemHeight = 47;
            this.materialComboBox1.Location = new System.Drawing.Point(234, 97);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.materialComboBox1.Size = new System.Drawing.Size(121, 53);
            this.materialComboBox1.TabIndex = 0;
            // 
            // materialTextfield1
            // 
            this.materialTextfield1.AutoScaleColor = true;
            this.materialTextfield1.BackColor = System.Drawing.SystemColors.Control;
            this.materialTextfield1.CountText = false;
            this.materialTextfield1.FieldType = MaterialSurface.BoxType.Normal;
            this.materialTextfield1.FloatingLabelText = "FloatingLabel";
            this.materialTextfield1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.materialTextfield1.HandleError = false;
            this.materialTextfield1.HelperText = "";
            this.materialTextfield1.HideSelection = true;
            this.materialTextfield1.HintText = "Biển số xe";
            this.materialTextfield1.Location = new System.Drawing.Point(234, 172);
            this.materialTextfield1.MaxLength = 32767;
            this.materialTextfield1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialTextfield1.Multiline = false;
            this.materialTextfield1.Name = "materialTextfield1";
            this.materialTextfield1.PasswordChar = '\0';
            this.materialTextfield1.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.materialTextfield1.ReadOnly = false;
            this.materialTextfield1.ShortcutsEnable = true;
            this.materialTextfield1.ShowCaret = true;
            this.materialTextfield1.Size = new System.Drawing.Size(200, 46);
            this.materialTextfield1.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.materialTextfield1.TabIndex = 1;
            this.materialTextfield1.UseSystemPasswordChar = false;
            this.materialTextfield1.TextChanged += new System.EventHandler(this.materialTextfield1_TextChanged);
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
            // 
            // ParkingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.containedButton1);
            this.Controls.Add(this.materialTextfield1);
            this.Controls.Add(this.materialComboBox1);
            this.Name = "ParkingView";
            this.Size = new System.Drawing.Size(791, 483);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSurface.MaterialComboBox materialComboBox1;
        private MaterialSurface.MaterialTextfield materialTextfield1;
        private MaterialSurface.ContainedButton containedButton1;
    }
}
