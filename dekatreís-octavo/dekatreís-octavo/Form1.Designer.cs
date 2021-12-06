
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
            this.consistenceReport1 = new dekatreís_octavo.View.ConsistenceReport();
            this.SuspendLayout();
            // 
            // consistenceReport1
            // 
            this.consistenceReport1.BackColor = System.Drawing.Color.White;
            this.consistenceReport1.Location = new System.Drawing.Point(114, 85);
            this.consistenceReport1.Name = "consistenceReport1";
            this.consistenceReport1.Size = new System.Drawing.Size(854, 517);
            this.consistenceReport1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 688);
            this.Controls.Add(this.consistenceReport1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private View.ConsistenceReport consistenceReport1;
    }
}

