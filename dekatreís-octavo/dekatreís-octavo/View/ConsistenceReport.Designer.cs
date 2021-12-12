
namespace dekatreís_octavo.View
{
    partial class ConsistenceReport
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.rpChart = new LiveCharts.WinForms.CartesianChart();
            this.topPanel = new System.Windows.Forms.Panel();
            this.containedButton1 = new MaterialSurface.ContainedButton();
            this.exportButton = new MaterialSurface.ContainedButton();
            this.yearComboBox = new MaterialSurface.MaterialComboBox();
            this.monthComboBox = new MaterialSurface.MaterialComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rb_Day = new System.Windows.Forms.RadioButton();
            this.rb_Month = new System.Windows.Forms.RadioButton();
            this.mainPanel.SuspendLayout();
            this.chartPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.chartPanel);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(854, 517);
            this.mainPanel.TabIndex = 0;
            // 
            // chartPanel
            // 
            this.chartPanel.Controls.Add(this.rpChart);
            this.chartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPanel.Location = new System.Drawing.Point(0, 100);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(854, 417);
            this.chartPanel.TabIndex = 2;
            // 
            // rpChart
            // 
            this.rpChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpChart.Location = new System.Drawing.Point(0, 0);
            this.rpChart.Name = "rpChart";
            this.rpChart.Size = new System.Drawing.Size(854, 417);
            this.rpChart.TabIndex = 0;
            this.rpChart.Text = "cartesianChart1";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.rb_Month);
            this.topPanel.Controls.Add(this.rb_Day);
            this.topPanel.Controls.Add(this.dateTimePicker1);
            this.topPanel.Controls.Add(this.containedButton1);
            this.topPanel.Controls.Add(this.exportButton);
            this.topPanel.Controls.Add(this.yearComboBox);
            this.topPanel.Controls.Add(this.monthComboBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(854, 100);
            this.topPanel.TabIndex = 0;
            // 
            // containedButton1
            // 
            this.containedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.containedButton1.EffectType = MaterialSurface.ET.Custom;
            this.containedButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.containedButton1.Icon = null;
            this.containedButton1.Location = new System.Drawing.Point(587, 23);
            this.containedButton1.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton1.Name = "containedButton1";
            this.containedButton1.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.containedButton1.Radius = 6;
            this.containedButton1.ShawdowDepth = 3;
            this.containedButton1.ShawdowOpacity = 50;
            this.containedButton1.Size = new System.Drawing.Size(115, 50);
            this.containedButton1.TabIndex = 4;
            this.containedButton1.Text = "Xem";
            this.containedButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton1.UseVisualStyleBackColor = true;
            this.containedButton1.Click += new System.EventHandler(this.containedButton1_Click_1);
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.EffectType = MaterialSurface.ET.Custom;
            this.exportButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exportButton.Icon = null;
            this.exportButton.Location = new System.Drawing.Point(708, 23);
            this.exportButton.MouseState = MaterialSurface.MouseState.OUT;
            this.exportButton.Name = "exportButton";
            this.exportButton.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.exportButton.Radius = 6;
            this.exportButton.ShawdowDepth = 3;
            this.exportButton.ShawdowOpacity = 50;
            this.exportButton.Size = new System.Drawing.Size(128, 50);
            this.exportButton.TabIndex = 0;
            this.exportButton.Text = "Xuất";
            this.exportButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.exportButton.UseVisualStyleBackColor = true;
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
            this.yearComboBox.Location = new System.Drawing.Point(159, 23);
            this.yearComboBox.MaxDropDownItems = 4;
            this.yearComboBox.MouseState = MaterialSurface.MouseState.OUT;
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.yearComboBox.Size = new System.Drawing.Size(121, 53);
            this.yearComboBox.TabIndex = 1;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.yearComboBox_SelectedIndexChanged);
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
            this.monthComboBox.HintText = "Tháng";
            this.monthComboBox.ItemHeight = 47;
            this.monthComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monthComboBox.Location = new System.Drawing.Point(32, 23);
            this.monthComboBox.MaxDropDownItems = 4;
            this.monthComboBox.MouseState = MaterialSurface.MouseState.OUT;
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.monthComboBox.Size = new System.Drawing.Size(121, 53);
            this.monthComboBox.TabIndex = 0;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.monthComboBox_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 27);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // rb_Day
            // 
            this.rb_Day.AutoSize = true;
            this.rb_Day.Location = new System.Drawing.Point(427, 14);
            this.rb_Day.Name = "rb_Day";
            this.rb_Day.Size = new System.Drawing.Size(97, 21);
            this.rb_Day.TabIndex = 6;
            this.rb_Day.Text = "Theo ngày";
            this.rb_Day.UseVisualStyleBackColor = true;
            // 
            // rb_Month
            // 
            this.rb_Month.AutoSize = true;
            this.rb_Month.Checked = true;
            this.rb_Month.Location = new System.Drawing.Point(286, 14);
            this.rb_Month.Name = "rb_Month";
            this.rb_Month.Size = new System.Drawing.Size(102, 21);
            this.rb_Month.TabIndex = 7;
            this.rb_Month.TabStop = true;
            this.rb_Month.Text = "Theo tháng";
            this.rb_Month.UseVisualStyleBackColor = true;
            // 
            // ConsistenceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Name = "ConsistenceReport";
            this.Size = new System.Drawing.Size(854, 517);
            this.mainPanel.ResumeLayout(false);
            this.chartPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel chartPanel;
        private System.Windows.Forms.Panel topPanel;
        private MaterialSurface.MaterialComboBox monthComboBox;
        private MaterialSurface.MaterialComboBox yearComboBox;
        private MaterialSurface.ContainedButton exportButton;
        private LiveCharts.WinForms.CartesianChart rpChart;
        private MaterialSurface.ContainedButton containedButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rb_Month;
        private System.Windows.Forms.RadioButton rb_Day;
    }
}
