
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
            this.tb_NewPass = new MaterialSurface.MaterialTextfield();
            this.tb_ConfirmPass = new MaterialSurface.MaterialTextfield();
            this.tb_OldPass = new MaterialSurface.MaterialTextfield();
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.containedButton1 = new MaterialSurface.ContainedButton();
            this.containedButton2 = new MaterialSurface.ContainedButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_NewPass
            // 
            this.tb_NewPass.AutoScaleColor = true;
            this.tb_NewPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_NewPass.CountText = false;
            this.tb_NewPass.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_NewPass.FloatingLabelText = "FloatingLabel";
            this.tb_NewPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_NewPass.HandleError = false;
            this.tb_NewPass.HelperText = "";
            this.tb_NewPass.HideSelection = true;
            this.tb_NewPass.HintText = "Mật khẩu mới";
            this.tb_NewPass.Location = new System.Drawing.Point(147, 155);
            this.tb_NewPass.MaxLength = 32767;
            this.tb_NewPass.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_NewPass.Multiline = false;
            this.tb_NewPass.Name = "tb_NewPass";
            this.tb_NewPass.PasswordChar = '●';
            this.tb_NewPass.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.tb_NewPass.ReadOnly = false;
            this.tb_NewPass.ShortcutsEnable = true;
            this.tb_NewPass.ShowCaret = true;
            this.tb_NewPass.Size = new System.Drawing.Size(235, 49);
            this.tb_NewPass.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_NewPass.TabIndex = 1;
            this.tb_NewPass.UseSystemPasswordChar = true;
            this.tb_NewPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_NewPass_KeyDown);
            // 
            // tb_ConfirmPass
            // 
            this.tb_ConfirmPass.AutoScaleColor = true;
            this.tb_ConfirmPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_ConfirmPass.CountText = false;
            this.tb_ConfirmPass.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_ConfirmPass.FloatingLabelText = "FloatingLabel";
            this.tb_ConfirmPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_ConfirmPass.HandleError = false;
            this.tb_ConfirmPass.HelperText = "";
            this.tb_ConfirmPass.HideSelection = true;
            this.tb_ConfirmPass.HintText = "Xác nhận mật khẩu";
            this.tb_ConfirmPass.Location = new System.Drawing.Point(147, 229);
            this.tb_ConfirmPass.MaxLength = 32767;
            this.tb_ConfirmPass.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_ConfirmPass.Multiline = false;
            this.tb_ConfirmPass.Name = "tb_ConfirmPass";
            this.tb_ConfirmPass.PasswordChar = '●';
            this.tb_ConfirmPass.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.tb_ConfirmPass.ReadOnly = false;
            this.tb_ConfirmPass.ShortcutsEnable = true;
            this.tb_ConfirmPass.ShowCaret = true;
            this.tb_ConfirmPass.Size = new System.Drawing.Size(235, 49);
            this.tb_ConfirmPass.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_ConfirmPass.TabIndex = 2;
            this.tb_ConfirmPass.UseSystemPasswordChar = true;
            this.tb_ConfirmPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ConfirmPass_KeyDown);
            // 
            // tb_OldPass
            // 
            this.tb_OldPass.AutoScaleColor = true;
            this.tb_OldPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_OldPass.CountText = false;
            this.tb_OldPass.FieldType = MaterialSurface.BoxType.Normal;
            this.tb_OldPass.FloatingLabelText = "FloatingLabel";
            this.tb_OldPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_OldPass.HandleError = false;
            this.tb_OldPass.HelperText = "";
            this.tb_OldPass.HideSelection = true;
            this.tb_OldPass.HintText = "Mật khẩu cũ";
            this.tb_OldPass.Location = new System.Drawing.Point(147, 80);
            this.tb_OldPass.MaxLength = 32767;
            this.tb_OldPass.MouseState = MaterialSurface.MouseState.OUT;
            this.tb_OldPass.Multiline = false;
            this.tb_OldPass.Name = "tb_OldPass";
            this.tb_OldPass.PasswordChar = '●';
            this.tb_OldPass.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.tb_OldPass.ReadOnly = false;
            this.tb_OldPass.ShortcutsEnable = true;
            this.tb_OldPass.ShowCaret = true;
            this.tb_OldPass.Size = new System.Drawing.Size(235, 49);
            this.tb_OldPass.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.tb_OldPass.TabIndex = 0;
            this.tb_OldPass.UseSystemPasswordChar = true;
            this.tb_OldPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_OldPass_KeyDown);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialCard1.CardColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialCard1.Controls.Add(this.containedButton2);
            this.materialCard1.Controls.Add(this.containedButton1);
            this.materialCard1.Controls.Add(this.tb_OldPass);
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
            this.materialCard1.Size = new System.Drawing.Size(522, 469);
            this.materialCard1.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard1.TabIndex = 6;
            // 
            // containedButton1
            // 
            this.containedButton1.EffectType = MaterialSurface.ET.Custom;
            this.containedButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.containedButton1.Icon = null;
            this.containedButton1.Location = new System.Drawing.Point(176, 306);
            this.containedButton1.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton1.Name = "containedButton1";
            this.containedButton1.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.containedButton1.Radius = 6;
            this.containedButton1.ShawdowDepth = 3;
            this.containedButton1.ShawdowOpacity = 50;
            this.containedButton1.Size = new System.Drawing.Size(180, 50);
            this.containedButton1.TabIndex = 5;
            this.containedButton1.Text = "Xác nhận";
            this.containedButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton1.UseVisualStyleBackColor = true;
            this.containedButton1.Click += new System.EventHandler(this.Confirm_Change_Click);
            // 
            // containedButton2
            // 
            this.containedButton2.EffectType = MaterialSurface.ET.Custom;
            this.containedButton2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.containedButton2.Icon = null;
            this.containedButton2.Location = new System.Drawing.Point(176, 371);
            this.containedButton2.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton2.Name = "containedButton2";
            this.containedButton2.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.containedButton2.Radius = 6;
            this.containedButton2.ShawdowDepth = 3;
            this.containedButton2.ShawdowOpacity = 50;
            this.containedButton2.Size = new System.Drawing.Size(180, 50);
            this.containedButton2.TabIndex = 6;
            this.containedButton2.Text = "Đóng";
            this.containedButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton2.UseVisualStyleBackColor = true;
            this.containedButton2.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(522, 469);
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
        private MaterialSurface.MaterialTextfield tb_NewPass;
        private MaterialSurface.MaterialTextfield tb_ConfirmPass;
        private MaterialSurface.MaterialTextfield tb_OldPass;
        private MaterialSurface.MaterialCard materialCard1;
        private MaterialSurface.ContainedButton containedButton2;
        private MaterialSurface.ContainedButton containedButton1;
    }
}