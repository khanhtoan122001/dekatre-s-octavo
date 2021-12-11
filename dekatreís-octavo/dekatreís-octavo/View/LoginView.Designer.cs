
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
            this.tb_Username = new MaterialSurface.MaterialTextfield();
            this.tb_Password = new MaterialSurface.MaterialTextfield();
            this.bt_Login = new MaterialSurface.ContainedButton();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Username
            // 
            this.tb_Username.AutoScaleColor = true;
            this.tb_Username.BackColor = System.Drawing.Color.White;
            this.tb_Username.CountText = false;
            this.tb_Username.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_Username.FloatingLabelText = "FloatingLabel";
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_Username.HandleError = false;
            this.tb_Username.HelperText = "";
            this.tb_Username.HideSelection = true;
            this.tb_Username.HintText = "Tài khoản";
            this.tb_Username.Location = new System.Drawing.Point(98, 250);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Username.MaxLength = 32767;
            this.tb_Username.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_Username.Multiline = false;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.PasswordChar = '\0';
            this.tb_Username.PrimaryColor = System.Drawing.Color.SteelBlue;
            this.tb_Username.ReadOnly = false;
            this.tb_Username.ShortcutsEnable = true;
            this.tb_Username.ShowCaret = true;
            this.tb_Username.Size = new System.Drawing.Size(277, 49);
            this.tb_Username.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_Username.TabIndex = 1;
            this.tb_Username.UseSystemPasswordChar = false;
            this.tb_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Username_KeyDown);
            // 
            // tb_Password
            // 
            this.tb_Password.AutoScaleColor = true;
            this.tb_Password.BackColor = System.Drawing.Color.White;
            this.tb_Password.CountText = false;
            this.tb_Password.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_Password.FloatingLabelText = "FloatingLabel";
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_Password.HandleError = false;
            this.tb_Password.HelperText = "";
            this.tb_Password.HideSelection = true;
            this.tb_Password.HintText = "Mật khẩu";
            this.tb_Password.Location = new System.Drawing.Point(98, 315);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Password.MaxLength = 32767;
            this.tb_Password.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_Password.Multiline = false;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '●';
            this.tb_Password.PrimaryColor = System.Drawing.Color.SteelBlue;
            this.tb_Password.ReadOnly = false;
            this.tb_Password.ShortcutsEnable = true;
            this.tb_Password.ShowCaret = true;
            this.tb_Password.Size = new System.Drawing.Size(277, 49);
            this.tb_Password.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_Password.TabIndex = 2;
            this.tb_Password.UseSystemPasswordChar = true;
            this.tb_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Password_KeyDown);
            // 
            // bt_Login
            // 
            this.bt_Login.EffectType = MaterialSurface.ET.Custom;
            this.bt_Login.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_Login.Icon = null;
            this.bt_Login.Location = new System.Drawing.Point(134, 409);
            this.bt_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Login.MouseState = MaterialSurface.MouseState.OUT;
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.PrimaryColor = System.Drawing.Color.SteelBlue;
            this.bt_Login.Radius = 6;
            this.bt_Login.ShawdowDepth = 3;
            this.bt_Login.ShawdowOpacity = 50;
            this.bt_Login.Size = new System.Drawing.Size(216, 50);
            this.bt_Login.TabIndex = 3;
            this.bt_Login.Text = "Đăng nhập";
            this.bt_Login.TextAlignment = System.Drawing.StringAlignment.Center;
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.containedButton1_Click);
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.Image = global::dekatreís_octavo.Properties.Resources.close__3_;
            this.CloseBox.Location = new System.Drawing.Point(403, 2);
            this.CloseBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(53, 49);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBox.TabIndex = 6;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPictureBox.Image = global::dekatreís_octavo.Properties.Resources._59c80c4b45d2a027e83b578f;
            this.MainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MainPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(496, 552);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Xin Chào";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(93, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vui lòng đăng nhập để tiếp tục";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MainPictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.CloseBox);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.bt_Login);
            this.splitContainer1.Panel2.Controls.Add(this.tb_Username);
            this.splitContainer1.Panel2.Controls.Add(this.tb_Password);
            this.splitContainer1.Size = new System.Drawing.Size(956, 552);
            this.splitContainer1.SplitterDistance = 496;
            this.splitContainer1.TabIndex = 9;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 552);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginView";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblMoveForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPictureBox;
        private MaterialSurface.MaterialTextfield tb_Username;
        private MaterialSurface.MaterialTextfield tb_Password;
        private MaterialSurface.ContainedButton bt_Login;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}