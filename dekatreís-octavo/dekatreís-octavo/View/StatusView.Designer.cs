
namespace dekatreís_octavo.View
{
    partial class StatusView
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
            this.statusList = new MaterialSkin.Controls.MaterialListView();
            this.findTextBox = new MaterialSurface.MaterialTextfield();
            this.orderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cardID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.licensePlate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // statusList
            // 
            this.statusList.AutoSizeTable = false;
            this.statusList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.statusList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderNumber,
            this.cardID,
            this.licensePlate});
            this.statusList.Depth = 0;
            this.statusList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusList.FullRowSelect = true;
            this.statusList.HideSelection = false;
            this.statusList.Location = new System.Drawing.Point(2, 104);
            this.statusList.MinimumSize = new System.Drawing.Size(200, 100);
            this.statusList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.statusList.MouseState = MaterialSkin.MouseState.OUT;
            this.statusList.Name = "statusList";
            this.statusList.OwnerDraw = true;
            this.statusList.Size = new System.Drawing.Size(794, 346);
            this.statusList.TabIndex = 0;
            this.statusList.UseCompatibleStateImageBehavior = false;
            this.statusList.View = System.Windows.Forms.View.Details;
            // 
            // findTextBox
            // 
            this.findTextBox.AutoScaleColor = true;
            this.findTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.findTextBox.CountText = false;
            this.findTextBox.FieldType = MaterialSurface.BoxType.Normal;
            this.findTextBox.FloatingLabelText = "FloatingLabel";
            this.findTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.findTextBox.HandleError = false;
            this.findTextBox.HelperText = "";
            this.findTextBox.HideSelection = true;
            this.findTextBox.HintText = "Tìm kiếm";
            this.findTextBox.Location = new System.Drawing.Point(12, 12);
            this.findTextBox.MaxLength = 32767;
            this.findTextBox.MouseState = MaterialSurface.MouseState.OUT;
            this.findTextBox.Multiline = false;
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.PasswordChar = '\0';
            this.findTextBox.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.findTextBox.ReadOnly = false;
            this.findTextBox.ShortcutsEnable = true;
            this.findTextBox.ShowCaret = true;
            this.findTextBox.Size = new System.Drawing.Size(200, 49);
            this.findTextBox.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.findTextBox.TabIndex = 2;
            this.findTextBox.UseSystemPasswordChar = false;
            // 
            // orderNumber
            // 
            this.orderNumber.Text = "STT";
            // 
            // cardID
            // 
            this.cardID.Text = "ID thẻ";
            this.cardID.Width = 120;
            // 
            // licensePlate
            // 
            this.licensePlate.Text = "Biển số xe";
            this.licensePlate.Width = 180;
            // 
            // StatusView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.statusList);
            this.Name = "StatusView";
            this.Text = "StatusView";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView statusList;
        private MaterialSurface.MaterialTextfield findTextBox;
        private System.Windows.Forms.ColumnHeader orderNumber;
        private System.Windows.Forms.ColumnHeader cardID;
        private System.Windows.Forms.ColumnHeader licensePlate;
    }
}