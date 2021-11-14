namespace dekatreís_octavo.View
{
    partial class AddStaffView
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
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextfield1 = new MaterialSurface.MaterialTextfield();
            this.materialTextfield2 = new MaterialSurface.MaterialTextfield();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(316, 375);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "OK";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(427, 375);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(77, 36);
            this.materialButton2.TabIndex = 0;
            this.materialButton2.Text = "Cancel";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = true;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Họ và Tên";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(192, 85);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(200, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "Tên Đăng Nhập";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(460, 85);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(200, 50);
            this.materialTextBox2.TabIndex = 2;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialTextfield1
            // 
            this.materialTextfield1.AutoScaleColor = true;
            this.materialTextfield1.BackColor = System.Drawing.SystemColors.Control;
            this.materialTextfield1.CountText = false;
            this.materialTextfield1.FieldType = MaterialSurface.BoxType.Outlined;
            this.materialTextfield1.FloatingLabelText = "FloatingLabel";
            this.materialTextfield1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.materialTextfield1.HandleError = false;
            this.materialTextfield1.HelperText = "";
            this.materialTextfield1.HideSelection = true;
            this.materialTextfield1.HintText = "Mật Khẩu";
            this.materialTextfield1.Location = new System.Drawing.Point(192, 205);
            this.materialTextfield1.MaxLength = 32767;
            this.materialTextfield1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialTextfield1.Multiline = false;
            this.materialTextfield1.Name = "materialTextfield1";
            this.materialTextfield1.PasswordChar = '●';
            this.materialTextfield1.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.materialTextfield1.ReadOnly = false;
            this.materialTextfield1.ShortcutsEnable = true;
            this.materialTextfield1.ShowCaret = true;
            this.materialTextfield1.Size = new System.Drawing.Size(200, 49);
            this.materialTextfield1.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.materialTextfield1.TabIndex = 3;
            this.materialTextfield1.UseSystemPasswordChar = true;
            // 
            // materialTextfield2
            // 
            this.materialTextfield2.AutoScaleColor = true;
            this.materialTextfield2.BackColor = System.Drawing.SystemColors.Control;
            this.materialTextfield2.CountText = false;
            this.materialTextfield2.FieldType = MaterialSurface.BoxType.Outlined;
            this.materialTextfield2.FloatingLabelText = "FloatingLabel";
            this.materialTextfield2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.materialTextfield2.HandleError = false;
            this.materialTextfield2.HelperText = "";
            this.materialTextfield2.HideSelection = true;
            this.materialTextfield2.HintText = "Xác Nhận Mật Khẩu";
            this.materialTextfield2.Location = new System.Drawing.Point(460, 205);
            this.materialTextfield2.MaxLength = 32767;
            this.materialTextfield2.MouseState = MaterialSurface.MouseState.OUT;
            this.materialTextfield2.Multiline = false;
            this.materialTextfield2.Name = "materialTextfield2";
            this.materialTextfield2.PasswordChar = '●';
            this.materialTextfield2.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.materialTextfield2.ReadOnly = false;
            this.materialTextfield2.ShortcutsEnable = true;
            this.materialTextfield2.ShowCaret = true;
            this.materialTextfield2.Size = new System.Drawing.Size(200, 49);
            this.materialTextfield2.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.materialTextfield2.TabIndex = 4;
            this.materialTextfield2.UseSystemPasswordChar = true;
            // 
            // AddStaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTextfield2);
            this.Controls.Add(this.materialTextfield1);
            this.Controls.Add(this.materialTextBox2);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Name = "AddStaffView";
            this.Text = "AddStaffView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSurface.MaterialTextfield materialTextfield1;
        private MaterialSurface.MaterialTextfield materialTextfield2;
    }
}