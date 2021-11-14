
namespace dekatreís_octavo
{
    partial class Form1
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
            this.parkingView1 = new dekatreís_octavo.View.ParkingView();
            this.SuspendLayout();
            // 
            // parkingView1
            // 
            this.parkingView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.parkingView1.Location = new System.Drawing.Point(115, 118);
            this.parkingView1.Name = "parkingView1";
            this.parkingView1.Size = new System.Drawing.Size(791, 483);
            this.parkingView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 688);
            this.Controls.Add(this.parkingView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private View.ParkingView parkingView1;
    }
}

