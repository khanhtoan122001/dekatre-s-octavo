
namespace dekatreís_octavo.View
{
    partial class HistoryView
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
            this.findTextBox = new MaterialSurface.MaterialTextfield();
            this.historyList = new MaterialSkin.Controls.MaterialListView();
            this.SuspendLayout();
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
            this.findTextBox.Location = new System.Drawing.Point(13, 6);
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
            this.findTextBox.TabIndex = 4;
            this.findTextBox.UseSystemPasswordChar = false;
            // 
            // historyList
            // 
            this.historyList.AutoSizeTable = false;
            this.historyList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.historyList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyList.Depth = 0;
            this.historyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyList.FullRowSelect = true;
            this.historyList.HideSelection = false;
            this.historyList.Location = new System.Drawing.Point(3, 98);
            this.historyList.MinimumSize = new System.Drawing.Size(200, 100);
            this.historyList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.historyList.MouseState = MaterialSkin.MouseState.OUT;
            this.historyList.Name = "historyList";
            this.historyList.OwnerDraw = true;
            this.historyList.Size = new System.Drawing.Size(794, 346);
            this.historyList.TabIndex = 3;
            this.historyList.UseCompatibleStateImageBehavior = false;
            this.historyList.View = System.Windows.Forms.View.Details;
            // 
            // HistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.historyList);
            this.Name = "HistoryView";
            this.Text = "HistoryView";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSurface.MaterialTextfield findTextBox;
        private MaterialSkin.Controls.MaterialListView historyList;
    }
}