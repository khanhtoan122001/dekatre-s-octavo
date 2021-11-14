
namespace dekatreís_octavo.View
{
    partial class UserControl_Test
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
            this.containedButton1 = new MaterialSurface.ContainedButton();
            this.containedButton2 = new MaterialSurface.ContainedButton();
            this.materialComboBox1 = new MaterialSurface.MaterialComboBox();
            this.SuspendLayout();
            // 
            // containedButton1
            // 
            this.containedButton1.EffectType = MaterialSurface.ET.Custom;
            this.containedButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.containedButton1.Icon = null;
            this.containedButton1.Location = new System.Drawing.Point(19, 23);
            this.containedButton1.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton1.Name = "containedButton1";
            this.containedButton1.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.containedButton1.Radius = 6;
            this.containedButton1.ShawdowDepth = 3;
            this.containedButton1.ShawdowOpacity = 50;
            this.containedButton1.Size = new System.Drawing.Size(180, 50);
            this.containedButton1.TabIndex = 0;
            this.containedButton1.Text = "containedButton1";
            this.containedButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton1.UseVisualStyleBackColor = true;
            // 
            // containedButton2
            // 
            this.containedButton2.EffectType = MaterialSurface.ET.Custom;
            this.containedButton2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.containedButton2.Icon = null;
            this.containedButton2.Location = new System.Drawing.Point(19, 101);
            this.containedButton2.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton2.Name = "containedButton2";
            this.containedButton2.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.containedButton2.Radius = 6;
            this.containedButton2.ShawdowDepth = 3;
            this.containedButton2.ShawdowOpacity = 50;
            this.containedButton2.Size = new System.Drawing.Size(180, 50);
            this.containedButton2.TabIndex = 1;
            this.containedButton2.Text = "containedButton2";
            this.containedButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton2.UseVisualStyleBackColor = true;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoSizing = false;
            this.materialComboBox1.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.HintText = "";
            this.materialComboBox1.ItemHeight = 47;
            this.materialComboBox1.Location = new System.Drawing.Point(315, 82);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.materialComboBox1.Size = new System.Drawing.Size(121, 53);
            this.materialComboBox1.TabIndex = 2;
            // 
            // UserControl_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.containedButton2);
            this.Controls.Add(this.containedButton1);
            this.Name = "UserControl_Test";
            this.Size = new System.Drawing.Size(522, 297);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSurface.ContainedButton containedButton1;
        private MaterialSurface.ContainedButton containedButton2;
        private MaterialSurface.MaterialComboBox materialComboBox1;
    }
}
