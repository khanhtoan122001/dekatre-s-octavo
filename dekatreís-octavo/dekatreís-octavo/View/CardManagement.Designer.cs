﻿
namespace dekatreís_octavo.View
{
    partial class CardManagement
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
            this.cardList = new MaterialSkin.Controls.MaterialListView();
            this.statusComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.addButton = new MaterialSurface.ContainedButton();
            this.delButton = new MaterialSurface.ContainedButton();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cardList
            // 
            this.cardList.AutoSizeTable = false;
            this.cardList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Type,
            this.Status});
            this.cardList.Depth = 0;
            this.cardList.FullRowSelect = true;
            this.cardList.HideSelection = false;
            this.cardList.Location = new System.Drawing.Point(0, 134);
            this.cardList.MinimumSize = new System.Drawing.Size(200, 100);
            this.cardList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cardList.MouseState = MaterialSkin.MouseState.OUT;
            this.cardList.Name = "cardList";
            this.cardList.OwnerDraw = true;
            this.cardList.Size = new System.Drawing.Size(936, 399);
            this.cardList.TabIndex = 0;
            this.cardList.UseCompatibleStateImageBehavior = false;
            this.cardList.View = System.Windows.Forms.View.Details;
            // 
            // statusComboBox
            // 
            this.statusComboBox.AutoResize = false;
            this.statusComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.statusComboBox.Depth = 0;
            this.statusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.statusComboBox.DropDownHeight = 174;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.DropDownWidth = 121;
            this.statusComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.statusComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Hint = "Status";
            this.statusComboBox.IntegralHeight = false;
            this.statusComboBox.ItemHeight = 43;
            this.statusComboBox.Location = new System.Drawing.Point(796, 79);
            this.statusComboBox.MaxDropDownItems = 4;
            this.statusComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(140, 49);
            this.statusComboBox.StartIndex = 0;
            this.statusComboBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.EffectType = MaterialSurface.ET.Custom;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(3, 78);
            this.addButton.MouseState = MaterialSurface.MouseState.OUT;
            this.addButton.Name = "addButton";
            this.addButton.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.addButton.Radius = 6;
            this.addButton.ShawdowDepth = 3;
            this.addButton.ShawdowOpacity = 50;
            this.addButton.Size = new System.Drawing.Size(126, 50);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Thêm";
            this.addButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // delButton
            // 
            this.delButton.EffectType = MaterialSurface.ET.Custom;
            this.delButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.delButton.Icon = null;
            this.delButton.Location = new System.Drawing.Point(135, 79);
            this.delButton.MouseState = MaterialSurface.MouseState.OUT;
            this.delButton.Name = "delButton";
            this.delButton.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.delButton.Radius = 6;
            this.delButton.ShawdowDepth = 3;
            this.delButton.ShawdowOpacity = 50;
            this.delButton.Size = new System.Drawing.Size(126, 50);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "Xóa";
            this.delButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.delButton.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Type
            // 
            this.Type.Text = "Loại";
            // 
            // Status
            // 
            this.Status.Text = "Trạng thái";
            this.Status.Width = 129;
            // 
            // CardManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.cardList);
            this.Name = "CardManagement";
            this.Size = new System.Drawing.Size(939, 536);
            this.Load += new System.EventHandler(this.CardManagement_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView cardList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Status;
        private MaterialSkin.Controls.MaterialComboBox statusComboBox;
        private MaterialSurface.ContainedButton addButton;
        private MaterialSurface.ContainedButton delButton;
    }
}
