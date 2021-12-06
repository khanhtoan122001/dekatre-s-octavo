
namespace dekatreís_octavo.View
{
    partial class InView
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
            this.licenseTextBox = new MaterialSurface.MaterialTextfield();
            this.containedButton1 = new MaterialSurface.ContainedButton();
            this.containedButton2 = new MaterialSurface.ContainedButton();
            this.SuspendLayout();
            // 
            // licenseTextBox
            // 
            this.licenseTextBox.AutoScaleColor = true;
            this.licenseTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.licenseTextBox.CountText = false;
            this.licenseTextBox.FieldType = MaterialSurface.BoxType.Normal;
            this.licenseTextBox.FloatingLabelText = "FloatingLabel";
            this.licenseTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.licenseTextBox.HandleError = false;
            this.licenseTextBox.HelperText = "";
            this.licenseTextBox.HideSelection = true;
            this.licenseTextBox.HintText = "Biển số xe";
            this.licenseTextBox.Location = new System.Drawing.Point(72, 38);
            this.licenseTextBox.MaxLength = 32767;
            this.licenseTextBox.MouseState = MaterialSurface.MouseState.OUT;
            this.licenseTextBox.Multiline = false;
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.PasswordChar = '\0';
            this.licenseTextBox.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.licenseTextBox.ReadOnly = false;
            this.licenseTextBox.ShortcutsEnable = true;
            this.licenseTextBox.ShowCaret = true;
            this.licenseTextBox.Size = new System.Drawing.Size(200, 49);
            this.licenseTextBox.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.licenseTextBox.TabIndex = 1;
            this.licenseTextBox.UseSystemPasswordChar = false;
            // 
            // containedButton1
            // 
            this.containedButton1.EffectType = MaterialSurface.ET.Custom;
            this.containedButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.containedButton1.Icon = null;
            this.containedButton1.Location = new System.Drawing.Point(132, 111);
            this.containedButton1.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton1.Name = "containedButton1";
            this.containedButton1.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.containedButton1.Radius = 6;
            this.containedButton1.ShawdowDepth = 3;
            this.containedButton1.ShawdowOpacity = 50;
            this.containedButton1.Size = new System.Drawing.Size(94, 50);
            this.containedButton1.TabIndex = 2;
            this.containedButton1.Text = "OK";
            this.containedButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton1.UseVisualStyleBackColor = true;
            // 
            // containedButton2
            // 
            this.containedButton2.EffectType = MaterialSurface.ET.Custom;
            this.containedButton2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.containedButton2.Icon = null;
            this.containedButton2.Location = new System.Drawing.Point(262, 111);
            this.containedButton2.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton2.Name = "containedButton2";
            this.containedButton2.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.containedButton2.Radius = 6;
            this.containedButton2.ShawdowDepth = 3;
            this.containedButton2.ShawdowOpacity = 50;
            this.containedButton2.Size = new System.Drawing.Size(97, 50);
            this.containedButton2.TabIndex = 3;
            this.containedButton2.Text = "Cancel";
            this.containedButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton2.UseVisualStyleBackColor = true;
            // 
            // InView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 194);
            this.Controls.Add(this.containedButton2);
            this.Controls.Add(this.containedButton1);
            this.Controls.Add(this.licenseTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InView";
            this.Text = "InView";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSurface.MaterialTextfield licenseTextBox;
        private MaterialSurface.ContainedButton containedButton1;
        private MaterialSurface.ContainedButton containedButton2;
    }
}