namespace GLEED2D
{
    partial class CustomPropertyGroupEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomPropertyGroupEditor));
            this.cbxDeleteWithoutConfirm = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbxToAllSelected = new System.Windows.Forms.CheckBox();
            this.numUDR = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbxAddMode = new System.Windows.Forms.CheckBox();
            this.numUDG = new System.Windows.Forms.NumericUpDown();
            this.numUDB = new System.Windows.Forms.NumericUpDown();
            this.btnColor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbY = new System.Windows.Forms.TextBox();
            this.txbX = new System.Windows.Forms.TextBox();
            this.cbbBoolean = new System.Windows.Forms.ComboBox();
            this.txbFreetext = new System.Windows.Forms.TextBox();
            this.rdbItem = new System.Windows.Forms.RadioButton();
            this.rdbColor = new System.Windows.Forms.RadioButton();
            this.rdbVector2 = new System.Windows.Forms.RadioButton();
            this.rdbBoolean = new System.Windows.Forms.RadioButton();
            this.rdbFreeText = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.cbbGroup = new System.Windows.Forms.ComboBox();
            this.contextMenuCbbGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbxProperty = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPropName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUDR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDB)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.contextMenuCbbGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxDeleteWithoutConfirm
            // 
            this.cbxDeleteWithoutConfirm.AutoSize = true;
            this.cbxDeleteWithoutConfirm.Checked = true;
            this.cbxDeleteWithoutConfirm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDeleteWithoutConfirm.Location = new System.Drawing.Point(162, 329);
            this.cbxDeleteWithoutConfirm.Name = "cbxDeleteWithoutConfirm";
            this.cbxDeleteWithoutConfirm.Size = new System.Drawing.Size(156, 16);
            this.cbxDeleteWithoutConfirm.TabIndex = 59;
            this.cbxDeleteWithoutConfirm.Text = "delete without confirm";
            this.cbxDeleteWithoutConfirm.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(477, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 21);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxToAllSelected
            // 
            this.cbxToAllSelected.AutoSize = true;
            this.cbxToAllSelected.Location = new System.Drawing.Point(162, 284);
            this.cbxToAllSelected.Name = "cbxToAllSelected";
            this.cbxToAllSelected.Size = new System.Drawing.Size(102, 16);
            this.cbxToAllSelected.TabIndex = 55;
            this.cbxToAllSelected.Text = "To all groups";
            this.cbxToAllSelected.UseVisualStyleBackColor = true;
            this.cbxToAllSelected.CheckedChanged += new System.EventHandler(this.cbxAddToAllSelected_CheckedChanged);
            // 
            // numUDR
            // 
            this.numUDR.Location = new System.Drawing.Point(278, 242);
            this.numUDR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDR.Name = "numUDR";
            this.numUDR.Size = new System.Drawing.Size(40, 21);
            this.numUDR.TabIndex = 54;
            this.numUDR.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDR.ValueChanged += new System.EventHandler(this.numUD_ValueChanged);
            // 
            // cbxAddMode
            // 
            this.cbxAddMode.AutoSize = true;
            this.cbxAddMode.Enabled = false;
            this.cbxAddMode.Location = new System.Drawing.Point(162, 306);
            this.cbxAddMode.Name = "cbxAddMode";
            this.cbxAddMode.Size = new System.Drawing.Size(132, 16);
            this.cbxAddMode.TabIndex = 56;
            this.cbxAddMode.Text = "overwrite conflict";
            this.cbxAddMode.UseVisualStyleBackColor = true;
            // 
            // numUDG
            // 
            this.numUDG.Location = new System.Drawing.Point(335, 242);
            this.numUDG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDG.Name = "numUDG";
            this.numUDG.Size = new System.Drawing.Size(40, 21);
            this.numUDG.TabIndex = 53;
            this.numUDG.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDG.ValueChanged += new System.EventHandler(this.numUD_ValueChanged);
            // 
            // numUDB
            // 
            this.numUDB.Location = new System.Drawing.Point(394, 242);
            this.numUDB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDB.Name = "numUDB";
            this.numUDB.Size = new System.Drawing.Size(40, 21);
            this.numUDB.TabIndex = 52;
            this.numUDB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDB.ValueChanged += new System.EventHandler(this.numUD_ValueChanged);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(446, 241);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(27, 23);
            this.btnColor.TabIndex = 51;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 50;
            this.label8.Text = "B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 49;
            this.label7.Text = "G";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 48;
            this.label6.Text = "R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 47;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 46;
            this.label4.Text = "X";
            // 
            // txbY
            // 
            this.txbY.Location = new System.Drawing.Point(382, 220);
            this.txbY.Name = "txbY";
            this.txbY.Size = new System.Drawing.Size(88, 21);
            this.txbY.TabIndex = 45;
            this.txbY.Text = "0";
            // 
            // txbX
            // 
            this.txbX.Location = new System.Drawing.Point(273, 221);
            this.txbX.Name = "txbX";
            this.txbX.Size = new System.Drawing.Size(88, 21);
            this.txbX.TabIndex = 44;
            this.txbX.Text = "0";
            // 
            // cbbBoolean
            // 
            this.cbbBoolean.FormattingEnabled = true;
            this.cbbBoolean.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbbBoolean.Location = new System.Drawing.Point(273, 200);
            this.cbbBoolean.Name = "cbbBoolean";
            this.cbbBoolean.Size = new System.Drawing.Size(63, 20);
            this.cbbBoolean.TabIndex = 43;
            this.cbbBoolean.Text = "true";
            // 
            // txbFreetext
            // 
            this.txbFreetext.Location = new System.Drawing.Point(273, 178);
            this.txbFreetext.Name = "txbFreetext";
            this.txbFreetext.Size = new System.Drawing.Size(200, 21);
            this.txbFreetext.TabIndex = 42;
            // 
            // rdbItem
            // 
            this.rdbItem.AutoSize = true;
            this.rdbItem.Location = new System.Drawing.Point(196, 263);
            this.rdbItem.Name = "rdbItem";
            this.rdbItem.Size = new System.Drawing.Size(47, 16);
            this.rdbItem.TabIndex = 39;
            this.rdbItem.Text = "Item";
            this.rdbItem.UseVisualStyleBackColor = true;
            // 
            // rdbColor
            // 
            this.rdbColor.AutoSize = true;
            this.rdbColor.Location = new System.Drawing.Point(196, 242);
            this.rdbColor.Name = "rdbColor";
            this.rdbColor.Size = new System.Drawing.Size(53, 16);
            this.rdbColor.TabIndex = 38;
            this.rdbColor.Text = "Color";
            this.rdbColor.UseVisualStyleBackColor = true;
            // 
            // rdbVector2
            // 
            this.rdbVector2.AutoSize = true;
            this.rdbVector2.Location = new System.Drawing.Point(196, 221);
            this.rdbVector2.Name = "rdbVector2";
            this.rdbVector2.Size = new System.Drawing.Size(65, 16);
            this.rdbVector2.TabIndex = 36;
            this.rdbVector2.Text = "Vector2";
            this.rdbVector2.UseVisualStyleBackColor = true;
            // 
            // rdbBoolean
            // 
            this.rdbBoolean.AutoSize = true;
            this.rdbBoolean.Location = new System.Drawing.Point(196, 200);
            this.rdbBoolean.Name = "rdbBoolean";
            this.rdbBoolean.Size = new System.Drawing.Size(65, 16);
            this.rdbBoolean.TabIndex = 35;
            this.rdbBoolean.Text = "Boolean";
            this.rdbBoolean.UseVisualStyleBackColor = true;
            // 
            // rdbFreeText
            // 
            this.rdbFreeText.AutoSize = true;
            this.rdbFreeText.Checked = true;
            this.rdbFreeText.Location = new System.Drawing.Point(196, 178);
            this.rdbFreeText.Name = "rdbFreeText";
            this.rdbFreeText.Size = new System.Drawing.Size(77, 16);
            this.rdbFreeText.TabIndex = 33;
            this.rdbFreeText.TabStop = true;
            this.rdbFreeText.Text = "Free text";
            this.rdbFreeText.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "Type";
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(245, 108);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(225, 65);
            this.txbDescription.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "Description";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(379, 402);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 21);
            this.buttonOK.TabIndex = 40;
            this.buttonOK.Text = "Set";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(460, 402);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 41;
            this.buttonCancel.Text = "Finish";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(546, 25);
            this.toolStrip1.TabIndex = 60;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "New";
            this.toolStripButton1.Click += new System.EventHandler(this.ActionNewPropertyGroup);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Import";
            this.toolStripButton2.Click += new System.EventHandler(this.ActionOpenPropertyGroup);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Save";
            this.toolStripButton3.Click += new System.EventHandler(this.ActionSavePropertyGroup);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Save as";
            this.toolStripButton4.Click += new System.EventHandler(this.ActionSavePropertyGroupAs);
            // 
            // cbbGroup
            // 
            this.cbbGroup.ContextMenuStrip = this.contextMenuCbbGroup;
            this.cbbGroup.FormattingEnabled = true;
            this.cbbGroup.Location = new System.Drawing.Point(0, 55);
            this.cbbGroup.Name = "cbbGroup";
            this.cbbGroup.Size = new System.Drawing.Size(156, 20);
            this.cbbGroup.TabIndex = 61;
            this.cbbGroup.SelectedIndexChanged += new System.EventHandler(this.cbbGroup_SelectedIndexChanged);
            // 
            // contextMenuCbbGroup
            // 
            this.contextMenuCbbGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuCbbGroup.Name = "contextMenuStrip1";
            this.contextMenuCbbGroup.Size = new System.Drawing.Size(124, 48);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // lbxProperty
            // 
            this.lbxProperty.FormattingEnabled = true;
            this.lbxProperty.ItemHeight = 12;
            this.lbxProperty.Location = new System.Drawing.Point(0, 108);
            this.lbxProperty.Name = "lbxProperty";
            this.lbxProperty.Size = new System.Drawing.Size(156, 256);
            this.lbxProperty.TabIndex = 63;
            this.lbxProperty.SelectedIndexChanged += new System.EventHandler(this.lbxProperty_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 64;
            this.label10.Text = "Properties";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 62;
            this.label9.Text = "Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name";
            // 
            // txbPropName
            // 
            this.txbPropName.Location = new System.Drawing.Point(245, 82);
            this.txbPropName.Name = "txbPropName";
            this.txbPropName.Size = new System.Drawing.Size(225, 21);
            this.txbPropName.TabIndex = 65;
            // 
            // CustomPropertyGroupEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 432);
            this.Controls.Add(this.txbPropName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbxProperty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbbGroup);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cbxDeleteWithoutConfirm);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbxToAllSelected);
            this.Controls.Add(this.numUDR);
            this.Controls.Add(this.cbxAddMode);
            this.Controls.Add(this.numUDG);
            this.Controls.Add(this.numUDB);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbY);
            this.Controls.Add(this.txbX);
            this.Controls.Add(this.cbbBoolean);
            this.Controls.Add(this.txbFreetext);
            this.Controls.Add(this.rdbItem);
            this.Controls.Add(this.rdbColor);
            this.Controls.Add(this.rdbVector2);
            this.Controls.Add(this.rdbBoolean);
            this.Controls.Add(this.rdbFreeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomPropertyGroupEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomPropertyGroupEditor";
            this.Load += new System.EventHandler(this.AddCustomProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDB)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuCbbGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxDeleteWithoutConfirm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox cbxToAllSelected;
        private System.Windows.Forms.NumericUpDown numUDR;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox cbxAddMode;
        private System.Windows.Forms.NumericUpDown numUDG;
        private System.Windows.Forms.NumericUpDown numUDB;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbY;
        private System.Windows.Forms.TextBox txbX;
        private System.Windows.Forms.ComboBox cbbBoolean;
        private System.Windows.Forms.TextBox txbFreetext;
        private System.Windows.Forms.RadioButton rdbItem;
        private System.Windows.Forms.RadioButton rdbColor;
        private System.Windows.Forms.RadioButton rdbVector2;
        private System.Windows.Forms.RadioButton rdbBoolean;
        private System.Windows.Forms.RadioButton rdbFreeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ComboBox cbbGroup;
        private System.Windows.Forms.ListBox lbxProperty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPropName;
        private System.Windows.Forms.ContextMenuStrip contextMenuCbbGroup;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}