namespace dekatreís_octavo.View
{
    partial class EditStaffView
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
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.containedButton1 = new MaterialSurface.ContainedButton();
            this.containedButton2 = new MaterialSurface.ContainedButton();
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.materialTextBox1.Hint = "Họ và tên";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(72, 29);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(267, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "Tên";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.materialTextBox2.Hint = "CMND";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(72, 89);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(267, 50);
            this.materialTextBox2.TabIndex = 2;
            this.materialTextBox2.Text = "CMND";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.materialTextBox3.Hint = "SĐT";
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(72, 156);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(267, 50);
            this.materialTextBox3.TabIndex = 3;
            this.materialTextBox3.Text = "SĐT";
            this.materialTextBox3.TrailingIcon = null;
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.AnimateReadOnly = true;
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Enabled = false;
            this.materialTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.materialTextBox4.Hint = "Tên Đăng Nhập";
            this.materialTextBox4.LeadingIcon = null;
            this.materialTextBox4.Location = new System.Drawing.Point(72, 288);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.ReadOnly = true;
            this.materialTextBox4.Size = new System.Drawing.Size(267, 50);
            this.materialTextBox4.TabIndex = 1;
            this.materialTextBox4.Text = "Tên Đăng Nhập";
            this.materialTextBox4.TrailingIcon = null;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Loại Tài Khoản";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Admin",
            "Nhân Viên"});
            this.materialComboBox1.Location = new System.Drawing.Point(72, 223);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(267, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 4;
            // 
            // containedButton1
            // 
            this.containedButton1.EffectType = MaterialSurface.ET.Custom;
            this.containedButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.containedButton1.Icon = null;
            this.containedButton1.Location = new System.Drawing.Point(72, 351);
            this.containedButton1.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton1.Name = "containedButton1";
            this.containedButton1.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.containedButton1.Radius = 6;
            this.containedButton1.ShawdowDepth = 3;
            this.containedButton1.ShawdowOpacity = 50;
            this.containedButton1.Size = new System.Drawing.Size(119, 50);
            this.containedButton1.TabIndex = 7;
            this.containedButton1.Text = "OK";
            this.containedButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton1.UseVisualStyleBackColor = true;
            this.containedButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // containedButton2
            // 
            this.containedButton2.EffectType = MaterialSurface.ET.Custom;
            this.containedButton2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.containedButton2.Icon = null;
            this.containedButton2.Location = new System.Drawing.Point(220, 351);
            this.containedButton2.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton2.Name = "containedButton2";
            this.containedButton2.PrimaryColor = System.Drawing.Color.DeepPink;
            this.containedButton2.Radius = 6;
            this.containedButton2.ShawdowDepth = 3;
            this.containedButton2.ShawdowOpacity = 50;
            this.containedButton2.Size = new System.Drawing.Size(119, 50);
            this.containedButton2.TabIndex = 8;
            this.containedButton2.Text = "CANCEL";
            this.containedButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton2.UseVisualStyleBackColor = true;
            this.containedButton2.Click += new System.EventHandler(this.containedButton2_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialCard1.CardColor = System.Drawing.Color.White;
            this.materialCard1.Controls.Add(this.materialTextBox1);
            this.materialCard1.Controls.Add(this.containedButton2);
            this.materialCard1.Controls.Add(this.materialTextBox2);
            this.materialCard1.Controls.Add(this.containedButton1);
            this.materialCard1.Controls.Add(this.materialTextBox3);
            this.materialCard1.Controls.Add(this.materialTextBox4);
            this.materialCard1.Controls.Add(this.materialComboBox1);
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
            this.materialCard1.Size = new System.Drawing.Size(407, 439);
            this.materialCard1.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard1.TabIndex = 9;
            // 
            // EditStaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 439);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditStaffView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditStaff";
            this.Load += new System.EventHandler(this.EditStaff_Load);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSurface.ContainedButton containedButton1;
        private MaterialSurface.ContainedButton containedButton2;
        private MaterialSurface.MaterialCard materialCard1;
    }
}