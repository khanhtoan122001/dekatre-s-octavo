namespace dekatreís_octavo.View
{
    partial class RevenueReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.containedButton1 = new MaterialSurface.ContainedButton();
            this.yearComboBox = new MaterialSurface.MaterialComboBox();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialComboBox1);
            this.panel1.Controls.Add(this.containedButton1);
            this.panel1.Controls.Add(this.yearComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 76);
            this.panel1.TabIndex = 0;
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
            this.materialComboBox1.Hint = "Loại Thẻ";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Thẻ Thường",
            "Thẻ Tháng"});
            this.materialComboBox1.Location = new System.Drawing.Point(247, 19);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(196, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 4;
            // 
            // containedButton1
            // 
            this.containedButton1.EffectType = MaterialSurface.ET.Custom;
            this.containedButton1.Enabled = false;
            this.containedButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.containedButton1.Icon = null;
            this.containedButton1.Location = new System.Drawing.Point(476, 15);
            this.containedButton1.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton1.Name = "containedButton1";
            this.containedButton1.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.containedButton1.Radius = 6;
            this.containedButton1.ShawdowDepth = 3;
            this.containedButton1.ShawdowOpacity = 50;
            this.containedButton1.Size = new System.Drawing.Size(127, 53);
            this.containedButton1.TabIndex = 3;
            this.containedButton1.Text = "Xem";
            this.containedButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton1.UseVisualStyleBackColor = true;
            this.containedButton1.Click += new System.EventHandler(this.containedButton1_Click);
            // 
            // yearComboBox
            // 
            this.yearComboBox.AutoSizing = false;
            this.yearComboBox.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.yearComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.DropDownWidth = 121;
            this.yearComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.HintText = "Năm";
            this.yearComboBox.ItemHeight = 47;
            this.yearComboBox.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021"});
            this.yearComboBox.Location = new System.Drawing.Point(28, 15);
            this.yearComboBox.MaxDropDownItems = 4;
            this.yearComboBox.MouseState = MaterialSurface.MouseState.OUT;
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.yearComboBox.Size = new System.Drawing.Size(159, 53);
            this.yearComboBox.TabIndex = 2;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.yearComboBox_SelectedIndexChanged);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(0, 76);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(854, 441);
            this.cartesianChart1.TabIndex = 1;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // RevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.panel1);
            this.Name = "RevenueReport";
            this.Size = new System.Drawing.Size(854, 517);
            this.Load += new System.EventHandler(this.RevenueReport_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private MaterialSurface.MaterialComboBox yearComboBox;
        private MaterialSurface.ContainedButton containedButton1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
    }
}
