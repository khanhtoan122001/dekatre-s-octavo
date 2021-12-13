namespace dekatreís_octavo.View
{
    partial class RevenueMonthlyReport
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
            this.yearComboBox = new MaterialSurface.MaterialComboBox();
            this.containedButton1 = new MaterialSurface.ContainedButton();
            this.monthComboBox = new MaterialSurface.MaterialComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tongThuChart = new LiveCharts.WinForms.PieChart();
            this.tongChiChart = new LiveCharts.WinForms.PieChart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yearComboBox);
            this.panel1.Controls.Add(this.containedButton1);
            this.panel1.Controls.Add(this.monthComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 100);
            this.panel1.TabIndex = 1;
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
            "2018",
            "2019",
            "2020",
            "2021"});
            this.yearComboBox.Location = new System.Drawing.Point(171, 28);
            this.yearComboBox.MaxDropDownItems = 4;
            this.yearComboBox.MouseState = MaterialSurface.MouseState.OUT;
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.yearComboBox.Size = new System.Drawing.Size(121, 53);
            this.yearComboBox.TabIndex = 4;
            // 
            // containedButton1
            // 
            this.containedButton1.EffectType = MaterialSurface.ET.Custom;
            this.containedButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.containedButton1.Icon = null;
            this.containedButton1.Location = new System.Drawing.Point(335, 28);
            this.containedButton1.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton1.Name = "containedButton1";
            this.containedButton1.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.containedButton1.Radius = 6;
            this.containedButton1.ShawdowDepth = 3;
            this.containedButton1.ShawdowOpacity = 50;
            this.containedButton1.Size = new System.Drawing.Size(115, 50);
            this.containedButton1.TabIndex = 3;
            this.containedButton1.Text = "Xem";
            this.containedButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton1.UseVisualStyleBackColor = true;
            this.containedButton1.Click += new System.EventHandler(this.containedButton1_Click);
            // 
            // monthComboBox
            // 
            this.monthComboBox.AutoSizing = false;
            this.monthComboBox.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.monthComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.DropDownWidth = 121;
            this.monthComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.HintText = "Tháng";
            this.monthComboBox.ItemHeight = 47;
            this.monthComboBox.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.monthComboBox.Location = new System.Drawing.Point(34, 28);
            this.monthComboBox.MaxDropDownItems = 4;
            this.monthComboBox.MouseState = MaterialSurface.MouseState.OUT;
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.monthComboBox.Size = new System.Drawing.Size(121, 53);
            this.monthComboBox.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 137);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tongThuChart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tongChiChart);
            this.splitContainer1.Size = new System.Drawing.Size(854, 380);
            this.splitContainer1.SplitterDistance = 425;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // tongThuChart
            // 
            this.tongThuChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tongThuChart.Location = new System.Drawing.Point(0, 0);
            this.tongThuChart.Name = "tongThuChart";
            this.tongThuChart.Size = new System.Drawing.Size(425, 380);
            this.tongThuChart.TabIndex = 0;
            this.tongThuChart.Text = "pieChart1";
            // 
            // tongChiChart
            // 
            this.tongChiChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tongChiChart.Location = new System.Drawing.Point(0, 0);
            this.tongChiChart.Name = "tongChiChart";
            this.tongChiChart.Size = new System.Drawing.Size(428, 380);
            this.tongChiChart.TabIndex = 0;
            this.tongChiChart.Text = "pieChart3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 37);
            this.panel2.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.materialLabel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.materialLabel2);
            this.splitContainer2.Size = new System.Drawing.Size(854, 37);
            this.splitContainer2.SplitterDistance = 418;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(0, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(418, 37);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Biểu đồ tỷ lệ tổng thu";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(0, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(435, 37);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Biểu đồ tỷ lệ tổng chi";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RevenueMonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RevenueMonthlyReport";
            this.Size = new System.Drawing.Size(854, 517);
            this.Load += new System.EventHandler(this.RevenueMonthlyReport_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSurface.ContainedButton containedButton1;
        private MaterialSurface.MaterialComboBox monthComboBox;
        private MaterialSurface.MaterialComboBox yearComboBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private LiveCharts.WinForms.PieChart tongThuChart;
        private LiveCharts.WinForms.PieChart tongChiChart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
