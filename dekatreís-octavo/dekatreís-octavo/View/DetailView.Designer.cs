
namespace dekatreís_octavo.View
{
    partial class DetailView
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
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.accountLabel = new System.Windows.Forms.Label();
            this.editButton = new MaterialSurface.ContainedButton();
            this.closeButton = new MaterialSurface.ContainedButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cirPictureBox2 = new dekatreís_octavo.CirPictureBox();
            this.avatar = new dekatreís_octavo.CirPictureBox();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cirPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialCard1.CardColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialCard1.Controls.Add(this.positionComboBox);
            this.materialCard1.Controls.Add(this.accountLabel);
            this.materialCard1.Controls.Add(this.editButton);
            this.materialCard1.Controls.Add(this.cirPictureBox2);
            this.materialCard1.Controls.Add(this.closeButton);
            this.materialCard1.Controls.Add(this.avatar);
            this.materialCard1.Controls.Add(this.idTextBox);
            this.materialCard1.Controls.Add(this.phoneTextBox);
            this.materialCard1.Controls.Add(this.nameTextBox);
            this.materialCard1.Controls.Add(this.pictureBox4);
            this.materialCard1.Controls.Add(this.pictureBox3);
            this.materialCard1.Controls.Add(this.pictureBox2);
            this.materialCard1.Controls.Add(this.pictureBox1);
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
            this.materialCard1.Size = new System.Drawing.Size(602, 537);
            this.materialCard1.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard1.TabIndex = 3;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(183, 88);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(63, 25);
            this.accountLabel.TabIndex = 11;
            this.accountLabel.Text = "label1";
            // 
            // editButton
            // 
            this.editButton.EffectType = MaterialSurface.ET.Custom;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editButton.Icon = null;
            this.editButton.Location = new System.Drawing.Point(284, 438);
            this.editButton.MouseState = MaterialSurface.MouseState.OUT;
            this.editButton.Name = "editButton";
            this.editButton.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.editButton.Radius = 6;
            this.editButton.ShawdowDepth = 3;
            this.editButton.ShawdowOpacity = 50;
            this.editButton.Size = new System.Drawing.Size(197, 55);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Chỉnh sửa";
            this.editButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.EffectType = MaterialSurface.ET.Custom;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.closeButton.Icon = null;
            this.closeButton.Location = new System.Drawing.Point(81, 438);
            this.closeButton.MouseState = MaterialSurface.MouseState.OUT;
            this.closeButton.Name = "closeButton";
            this.closeButton.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.closeButton.Radius = 6;
            this.closeButton.ShawdowDepth = 3;
            this.closeButton.ShawdowOpacity = 50;
            this.closeButton.Size = new System.Drawing.Size(197, 55);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "OK";
            this.closeButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.containedButton1_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(188, 286);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(232, 31);
            this.idTextBox.TabIndex = 9;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Enabled = false;
            this.phoneTextBox.Location = new System.Drawing.Point(188, 226);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(232, 31);
            this.phoneTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(188, 166);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(232, 31);
            this.nameTextBox.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::dekatreís_octavo.Properties.Resources.arrow_cloud_up_upload_icon_123722;
            this.pictureBox4.Location = new System.Drawing.Point(101, 348);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::dekatreís_octavo.Properties.Resources.person;
            this.pictureBox3.Location = new System.Drawing.Point(101, 165);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::dekatreís_octavo.Properties.Resources.auricular_phone_symbol_in_a_circle_icon_icons_com_56570;
            this.pictureBox2.Location = new System.Drawing.Point(101, 226);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::dekatreís_octavo.Properties.Resources.ic_profile_info_97647;
            this.pictureBox1.Location = new System.Drawing.Point(101, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cirPictureBox2
            // 
            this.cirPictureBox2.Image = global::dekatreís_octavo.Properties.Resources.pencil;
            this.cirPictureBox2.Location = new System.Drawing.Point(113, 89);
            this.cirPictureBox2.Name = "cirPictureBox2";
            this.cirPictureBox2.Size = new System.Drawing.Size(24, 24);
            this.cirPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cirPictureBox2.TabIndex = 2;
            this.cirPictureBox2.TabStop = false;
            this.cirPictureBox2.Click += new System.EventHandler(this.cirPictureBox2_Click);
            // 
            // avatar
            // 
            this.avatar.Image = global::dekatreís_octavo.Properties.Resources.icon;
            this.avatar.Location = new System.Drawing.Point(57, 33);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(80, 80);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 1;
            this.avatar.TabStop = false;
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Items.AddRange(new object[] {
            "admin",
            "staff"});
            this.positionComboBox.Location = new System.Drawing.Point(188, 349);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(232, 31);
            this.positionComboBox.TabIndex = 12;
            // 
            // DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(602, 537);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DetailView_FormClosed);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cirPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CirPictureBox avatar;
        private CirPictureBox cirPictureBox2;
        private MaterialSurface.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSurface.ContainedButton closeButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private MaterialSurface.ContainedButton editButton;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.ComboBox positionComboBox;
    }
}