
namespace dekatreís_octavo.View
{
    partial class LoginView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_Username = new MaterialSurface.MaterialTextfield();
            this.tb_Password = new MaterialSurface.MaterialTextfield();
            this.bt_Login = new MaterialSurface.ContainedButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tb_Username
            // 
            this.tb_Username.AutoScaleColor = true;
            this.tb_Username.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Username.CountText = false;
            this.tb_Username.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_Username.FloatingLabelText = "FloatingLabel";
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_Username.HandleError = false;
            this.tb_Username.HelperText = "";
            this.tb_Username.HideSelection = true;
            this.tb_Username.HintText = "TĐN";
            this.tb_Username.Location = new System.Drawing.Point(488, 141);
            this.tb_Username.MaxLength = 32767;
            this.tb_Username.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_Username.Multiline = false;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.PasswordChar = '\0';
            this.tb_Username.PrimaryColor = System.Drawing.Color.SteelBlue;
            this.tb_Username.ReadOnly = false;
            this.tb_Username.ShortcutsEnable = true;
            this.tb_Username.ShowCaret = true;
            this.tb_Username.Size = new System.Drawing.Size(216, 49);
            this.tb_Username.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_Username.TabIndex = 1;
            this.tb_Username.UseSystemPasswordChar = false;
            // 
            // tb_Password
            // 
            this.tb_Password.AutoScaleColor = true;
            this.tb_Password.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Password.CountText = false;
            this.tb_Password.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_Password.FloatingLabelText = "FloatingLabel";
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_Password.HandleError = false;
            this.tb_Password.HelperText = "";
            this.tb_Password.HideSelection = true;
            this.tb_Password.HintText = "MK";
            this.tb_Password.Location = new System.Drawing.Point(488, 209);
            this.tb_Password.MaxLength = 32767;
            this.tb_Password.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_Password.Multiline = false;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '●';
            this.tb_Password.PrimaryColor = System.Drawing.Color.SteelBlue;
            this.tb_Password.ReadOnly = false;
            this.tb_Password.ShortcutsEnable = true;
            this.tb_Password.ShowCaret = true;
            this.tb_Password.Size = new System.Drawing.Size(216, 49);
            this.tb_Password.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_Password.TabIndex = 2;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // bt_Login
            // 
            this.bt_Login.EffectType = MaterialSurface.ET.Custom;
            this.bt_Login.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_Login.Icon = null;
            this.bt_Login.Location = new System.Drawing.Point(488, 293);
            this.bt_Login.MouseState = MaterialSurface.MouseState.OUT;
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.PrimaryColor = System.Drawing.Color.SteelBlue;
            this.bt_Login.Radius = 6;
            this.bt_Login.ShawdowDepth = 3;
            this.bt_Login.ShawdowOpacity = 50;
            this.bt_Login.Size = new System.Drawing.Size(216, 51);
            this.bt_Login.TabIndex = 3;
            this.bt_Login.Text = "Đăng nhập";
            this.bt_Login.TextAlignment = System.Drawing.StringAlignment.Center;
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.containedButton1_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.SystemColors.Control;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = false;
            this.materialButton1.HighEmphasis = false;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(752, 0);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(50, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "X";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginView";
            this.Text = "LoginView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSurface.MaterialTextfield tb_Username;
        private MaterialSurface.MaterialTextfield tb_Password;
        private MaterialSurface.ContainedButton bt_Login;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}