
namespace dekatreís_octavo.View
{
    partial class ChangePass
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
            this.bt_Exit = new MaterialSkin.Controls.MaterialButton();
            this.tb_NewPass = new MaterialSurface.MaterialTextfield();
            this.tb_ConfirmPass = new MaterialSurface.MaterialTextfield();
            this.bt_Confirm = new MaterialSkin.Controls.MaterialButton();
            this.tb_OldPass = new MaterialSurface.MaterialTextfield();
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Exit
            // 
            this.bt_Exit.AutoSize = false;
            this.bt_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Exit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_Exit.Depth = 0;
            this.bt_Exit.HighEmphasis = true;
            this.bt_Exit.Icon = null;
            this.bt_Exit.Location = new System.Drawing.Point(111, 296);
            this.bt_Exit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_Exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_Exit.Size = new System.Drawing.Size(200, 36);
            this.bt_Exit.TabIndex = 0;
            this.bt_Exit.Text = "ĐÓNG";
            this.bt_Exit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_Exit.UseAccentColor = false;
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tb_NewPass
            // 
            this.tb_NewPass.AutoScaleColor = true;
            this.tb_NewPass.BackColor = System.Drawing.Color.White;
            this.tb_NewPass.CountText = false;
            this.tb_NewPass.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_NewPass.FloatingLabelText = "FloatingLabel";
            this.tb_NewPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_NewPass.HandleError = false;
            this.tb_NewPass.HelperText = "";
            this.tb_NewPass.HideSelection = true;
            this.tb_NewPass.HintText = "Mật khẩu mới";
            this.tb_NewPass.Location = new System.Drawing.Point(111, 120);
            this.tb_NewPass.MaxLength = 32767;
            this.tb_NewPass.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_NewPass.Multiline = false;
            this.tb_NewPass.Name = "tb_NewPass";
            this.tb_NewPass.PasswordChar = '\0';
            this.tb_NewPass.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.tb_NewPass.ReadOnly = false;
            this.tb_NewPass.ShortcutsEnable = true;
            this.tb_NewPass.ShowCaret = true;
            this.tb_NewPass.Size = new System.Drawing.Size(200, 49);
            this.tb_NewPass.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_NewPass.TabIndex = 2;
            this.tb_NewPass.UseSystemPasswordChar = false;
            // 
            // tb_ConfirmPass
            // 
            this.tb_ConfirmPass.AutoScaleColor = true;
            this.tb_ConfirmPass.BackColor = System.Drawing.Color.White;
            this.tb_ConfirmPass.CountText = false;
            this.tb_ConfirmPass.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_ConfirmPass.FloatingLabelText = "FloatingLabel";
            this.tb_ConfirmPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_ConfirmPass.HandleError = false;
            this.tb_ConfirmPass.HelperText = "";
            this.tb_ConfirmPass.HideSelection = true;
            this.tb_ConfirmPass.HintText = "Xác nhận mật khẩu";
            this.tb_ConfirmPass.Location = new System.Drawing.Point(111, 175);
            this.tb_ConfirmPass.MaxLength = 32767;
            this.tb_ConfirmPass.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_ConfirmPass.Multiline = false;
            this.tb_ConfirmPass.Name = "tb_ConfirmPass";
            this.tb_ConfirmPass.PasswordChar = '\0';
            this.tb_ConfirmPass.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.tb_ConfirmPass.ReadOnly = false;
            this.tb_ConfirmPass.ShortcutsEnable = true;
            this.tb_ConfirmPass.ShowCaret = true;
            this.tb_ConfirmPass.Size = new System.Drawing.Size(200, 49);
            this.tb_ConfirmPass.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_ConfirmPass.TabIndex = 3;
            this.tb_ConfirmPass.UseSystemPasswordChar = false;
            // 
            // bt_Confirm
            // 
            this.bt_Confirm.AutoSize = false;
            this.bt_Confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_Confirm.Depth = 0;
            this.bt_Confirm.HighEmphasis = true;
            this.bt_Confirm.Icon = null;
            this.bt_Confirm.Location = new System.Drawing.Point(111, 248);
            this.bt_Confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_Confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_Confirm.Name = "bt_Confirm";
            this.bt_Confirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_Confirm.Size = new System.Drawing.Size(200, 36);
            this.bt_Confirm.TabIndex = 4;
            this.bt_Confirm.Text = "Xác nhận";
            this.bt_Confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_Confirm.UseAccentColor = false;
            this.bt_Confirm.UseVisualStyleBackColor = true;
            this.bt_Confirm.Click += new System.EventHandler(this.Confirm_Change_Click);
            // 
            // tb_OldPass
            // 
            this.tb_OldPass.AutoScaleColor = true;
            this.tb_OldPass.BackColor = System.Drawing.Color.White;
            this.tb_OldPass.CountText = false;
            this.tb_OldPass.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_OldPass.FloatingLabelText = "FloatingLabel";
            this.tb_OldPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_OldPass.HandleError = false;
            this.tb_OldPass.HelperText = "";
            this.tb_OldPass.HideSelection = true;
            this.tb_OldPass.HintText = "Mật khẩu cũ";
            this.tb_OldPass.Location = new System.Drawing.Point(111, 65);
            this.tb_OldPass.MaxLength = 32767;
            this.tb_OldPass.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_OldPass.Multiline = false;
            this.tb_OldPass.Name = "tb_OldPass";
            this.tb_OldPass.PasswordChar = '\0';
            this.tb_OldPass.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.tb_OldPass.ReadOnly = false;
            this.tb_OldPass.ShortcutsEnable = true;
            this.tb_OldPass.ShowCaret = true;
            this.tb_OldPass.Size = new System.Drawing.Size(200, 49);
            this.tb_OldPass.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_OldPass.TabIndex = 5;
            this.tb_OldPass.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialCard1.CardColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialCard1.Controls.Add(this.tb_OldPass);
            this.materialCard1.Controls.Add(this.bt_Exit);
            this.materialCard1.Controls.Add(this.bt_Confirm);
            this.materialCard1.Controls.Add(this.tb_NewPass);
            this.materialCard1.Controls.Add(this.tb_ConfirmPass);
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
            this.materialCard1.Size = new System.Drawing.Size(425, 384);
            this.materialCard1.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard1.TabIndex = 6;
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(425, 384);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePass";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblMoveForm_MouseDown);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton bt_Exit;
        private MaterialSurface.MaterialTextfield tb_NewPass;
        private MaterialSurface.MaterialTextfield tb_ConfirmPass;
        private MaterialSkin.Controls.MaterialButton bt_Confirm;
        private MaterialSurface.MaterialTextfield tb_OldPass;
        private MaterialSurface.MaterialCard materialCard1;
    }
}