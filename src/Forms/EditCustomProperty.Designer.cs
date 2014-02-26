namespace GLEED2D
{
    partial class AddCustomProperty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomProperty));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbFreeText = new System.Windows.Forms.RadioButton();
            this.rdbBoolean = new System.Windows.Forms.RadioButton();
            this.rdbVector2 = new System.Windows.Forms.RadioButton();
            this.rdbColor = new System.Windows.Forms.RadioButton();
            this.rdbItem = new System.Windows.Forms.RadioButton();
            this.txbFreetext = new System.Windows.Forms.TextBox();
            this.cbbBoolean = new System.Windows.Forms.ComboBox();
            this.txbX = new System.Windows.Forms.TextBox();
            this.txbY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.numUDB = new System.Windows.Forms.NumericUpDown();
            this.numUDG = new System.Windows.Forms.NumericUpDown();
            this.numUDR = new System.Windows.Forms.NumericUpDown();
            this.cbxToAllSelected = new System.Windows.Forms.CheckBox();
            this.cbxAddMode = new System.Windows.Forms.CheckBox();
            this.cbbName = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.cbxDeleteWithoutConfirm = new System.Windows.Forms.CheckBox();
            this.btnAddCake = new System.Windows.Forms.Button();
            this.cbbGroup = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPopCake = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(306, 274);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Finish";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 33);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 65);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rdbFreeText
            // 
            this.rdbFreeText.AutoSize = true;
            this.rdbFreeText.Checked = true;
            this.rdbFreeText.Location = new System.Drawing.Point(47, 103);
            this.rdbFreeText.Name = "rdbFreeText";
            this.rdbFreeText.Size = new System.Drawing.Size(77, 16);
            this.rdbFreeText.TabIndex = 3;
            this.rdbFreeText.TabStop = true;
            this.rdbFreeText.Text = "Free text";
            this.rdbFreeText.UseVisualStyleBackColor = true;
            this.rdbFreeText.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbBoolean
            // 
            this.rdbBoolean.AutoSize = true;
            this.rdbBoolean.Location = new System.Drawing.Point(47, 125);
            this.rdbBoolean.Name = "rdbBoolean";
            this.rdbBoolean.Size = new System.Drawing.Size(65, 16);
            this.rdbBoolean.TabIndex = 4;
            this.rdbBoolean.Text = "Boolean";
            this.rdbBoolean.UseVisualStyleBackColor = true;
            this.rdbBoolean.CheckedChanged += new System.EventHandler(this.rdbBoolean_CheckedChanged);
            // 
            // rdbVector2
            // 
            this.rdbVector2.AutoSize = true;
            this.rdbVector2.Location = new System.Drawing.Point(47, 146);
            this.rdbVector2.Name = "rdbVector2";
            this.rdbVector2.Size = new System.Drawing.Size(65, 16);
            this.rdbVector2.TabIndex = 5;
            this.rdbVector2.Text = "Vector2";
            this.rdbVector2.UseVisualStyleBackColor = true;
            this.rdbVector2.CheckedChanged += new System.EventHandler(this.rdbVector2_CheckedChanged);
            // 
            // rdbColor
            // 
            this.rdbColor.AutoSize = true;
            this.rdbColor.Location = new System.Drawing.Point(47, 167);
            this.rdbColor.Name = "rdbColor";
            this.rdbColor.Size = new System.Drawing.Size(53, 16);
            this.rdbColor.TabIndex = 6;
            this.rdbColor.Text = "Color";
            this.rdbColor.UseVisualStyleBackColor = true;
            this.rdbColor.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdbItem
            // 
            this.rdbItem.AutoSize = true;
            this.rdbItem.Location = new System.Drawing.Point(47, 188);
            this.rdbItem.Name = "rdbItem";
            this.rdbItem.Size = new System.Drawing.Size(47, 16);
            this.rdbItem.TabIndex = 7;
            this.rdbItem.Text = "Item";
            this.rdbItem.UseVisualStyleBackColor = true;
            this.rdbItem.CheckedChanged += new System.EventHandler(this.rdbItem_CheckedChanged);
            // 
            // txbFreetext
            // 
            this.txbFreetext.Location = new System.Drawing.Point(124, 103);
            this.txbFreetext.Name = "txbFreetext";
            this.txbFreetext.Size = new System.Drawing.Size(200, 21);
            this.txbFreetext.TabIndex = 10;
            this.txbFreetext.TextChanged += new System.EventHandler(this.txbFreetext_TextChanged);
            // 
            // cbbBoolean
            // 
            this.cbbBoolean.FormattingEnabled = true;
            this.cbbBoolean.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbbBoolean.Location = new System.Drawing.Point(124, 125);
            this.cbbBoolean.Name = "cbbBoolean";
            this.cbbBoolean.Size = new System.Drawing.Size(63, 20);
            this.cbbBoolean.TabIndex = 11;
            this.cbbBoolean.Text = "true";
            this.cbbBoolean.SelectedIndexChanged += new System.EventHandler(this.cbbBoolean_SelectedIndexChanged);
            // 
            // txbX
            // 
            this.txbX.Location = new System.Drawing.Point(124, 146);
            this.txbX.Name = "txbX";
            this.txbX.Size = new System.Drawing.Size(88, 21);
            this.txbX.TabIndex = 12;
            this.txbX.Text = "0";
            this.txbX.TextChanged += new System.EventHandler(this.txbX_TextChanged);
            // 
            // txbY
            // 
            this.txbY.Location = new System.Drawing.Point(233, 145);
            this.txbY.Name = "txbY";
            this.txbY.Size = new System.Drawing.Size(88, 21);
            this.txbY.TabIndex = 13;
            this.txbY.Text = "0";
            this.txbY.TextChanged += new System.EventHandler(this.txbY_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "Y";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "R";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "G";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "B";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(297, 166);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(27, 23);
            this.btnColor.TabIndex = 22;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // numUDB
            // 
            this.numUDB.Location = new System.Drawing.Point(245, 167);
            this.numUDB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDB.Name = "numUDB";
            this.numUDB.Size = new System.Drawing.Size(40, 21);
            this.numUDB.TabIndex = 23;
            this.numUDB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDB.ValueChanged += new System.EventHandler(this.numUDB_ValueChanged);
            // 
            // numUDG
            // 
            this.numUDG.Location = new System.Drawing.Point(186, 167);
            this.numUDG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDG.Name = "numUDG";
            this.numUDG.Size = new System.Drawing.Size(40, 21);
            this.numUDG.TabIndex = 24;
            this.numUDG.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDG.ValueChanged += new System.EventHandler(this.numUDG_ValueChanged);
            // 
            // numUDR
            // 
            this.numUDR.Location = new System.Drawing.Point(129, 167);
            this.numUDR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDR.Name = "numUDR";
            this.numUDR.Size = new System.Drawing.Size(40, 21);
            this.numUDR.TabIndex = 25;
            this.numUDR.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDR.ValueChanged += new System.EventHandler(this.numUD_ValueChanged);
            // 
            // cbxToAllSelected
            // 
            this.cbxToAllSelected.AutoSize = true;
            this.cbxToAllSelected.Location = new System.Drawing.Point(13, 209);
            this.cbxToAllSelected.Name = "cbxToAllSelected";
            this.cbxToAllSelected.Size = new System.Drawing.Size(114, 16);
            this.cbxToAllSelected.TabIndex = 26;
            this.cbxToAllSelected.Text = "To all selected";
            this.cbxToAllSelected.UseVisualStyleBackColor = true;
            this.cbxToAllSelected.CheckedChanged += new System.EventHandler(this.cbxAddToAllSelected_CheckedChanged);
            // 
            // cbxAddMode
            // 
            this.cbxAddMode.AutoSize = true;
            this.cbxAddMode.Location = new System.Drawing.Point(13, 231);
            this.cbxAddMode.Name = "cbxAddMode";
            this.cbxAddMode.Size = new System.Drawing.Size(132, 16);
            this.cbxAddMode.TabIndex = 27;
            this.cbxAddMode.Text = "overwrite conflict";
            this.cbxAddMode.UseVisualStyleBackColor = true;
            this.cbxAddMode.CheckedChanged += new System.EventHandler(this.cbxAddMode_CheckedChanged);
            // 
            // cbbName
            // 
            this.cbbName.FormattingEnabled = true;
            this.cbbName.Location = new System.Drawing.Point(96, 7);
            this.cbbName.Name = "cbbName";
            this.cbbName.Size = new System.Drawing.Size(225, 20);
            this.cbbName.TabIndex = 28;
            this.cbbName.SelectedIndexChanged += new System.EventHandler(this.cbbName_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(327, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 21);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(226, 274);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 21);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "Set";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // cbxDeleteWithoutConfirm
            // 
            this.cbxDeleteWithoutConfirm.AutoSize = true;
            this.cbxDeleteWithoutConfirm.Checked = true;
            this.cbxDeleteWithoutConfirm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDeleteWithoutConfirm.Location = new System.Drawing.Point(13, 254);
            this.cbxDeleteWithoutConfirm.Name = "cbxDeleteWithoutConfirm";
            this.cbxDeleteWithoutConfirm.Size = new System.Drawing.Size(156, 16);
            this.cbxDeleteWithoutConfirm.TabIndex = 30;
            this.cbxDeleteWithoutConfirm.Text = "delete without confirm";
            this.cbxDeleteWithoutConfirm.UseVisualStyleBackColor = true;
            this.cbxDeleteWithoutConfirm.CheckedChanged += new System.EventHandler(this.cbxDeleteWithoutConfirm_CheckedChanged);
            // 
            // btnAddCake
            // 
            this.btnAddCake.Location = new System.Drawing.Point(306, 245);
            this.btnAddCake.Name = "btnAddCake";
            this.btnAddCake.Size = new System.Drawing.Size(75, 23);
            this.btnAddCake.TabIndex = 31;
            this.btnAddCake.Text = "Push Group";
            this.btnAddCake.UseVisualStyleBackColor = true;
            this.btnAddCake.Click += new System.EventHandler(this.btnAddCake_Click);
            // 
            // cbbGroup
            // 
            this.cbbGroup.FormattingEnabled = true;
            this.cbbGroup.Location = new System.Drawing.Point(252, 219);
            this.cbbGroup.Name = "cbbGroup";
            this.cbbGroup.Size = new System.Drawing.Size(121, 20);
            this.cbbGroup.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(228, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnPopCake
            // 
            this.btnPopCake.Location = new System.Drawing.Point(226, 245);
            this.btnPopCake.Name = "btnPopCake";
            this.btnPopCake.Size = new System.Drawing.Size(75, 23);
            this.btnPopCake.TabIndex = 34;
            this.btnPopCake.Text = "Pop Group";
            this.btnPopCake.UseVisualStyleBackColor = true;
            this.btnPopCake.Click += new System.EventHandler(this.btnPopCake_Click);
            // 
            // AddCustomProperty
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(393, 306);
            this.ControlBox = false;
            this.Controls.Add(this.btnPopCake);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbbGroup);
            this.Controls.Add(this.btnAddCake);
            this.Controls.Add(this.cbxDeleteWithoutConfirm);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbbName);
            this.Controls.Add(this.cbxAddMode);
            this.Controls.Add(this.cbxToAllSelected);
            this.Controls.Add(this.numUDR);
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
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddCustomProperty";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Custom Property";
            this.Load += new System.EventHandler(this.AddCustomProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbFreeText;
        private System.Windows.Forms.RadioButton rdbBoolean;
        private System.Windows.Forms.RadioButton rdbVector2;
        private System.Windows.Forms.RadioButton rdbColor;
        private System.Windows.Forms.RadioButton rdbItem;
        private System.Windows.Forms.TextBox txbFreetext;
        private System.Windows.Forms.ComboBox cbbBoolean;
        private System.Windows.Forms.TextBox txbX;
        private System.Windows.Forms.TextBox txbY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numUDB;
        private System.Windows.Forms.NumericUpDown numUDG;
        private System.Windows.Forms.NumericUpDown numUDR;
        private System.Windows.Forms.CheckBox cbxToAllSelected;
        private System.Windows.Forms.CheckBox cbxAddMode;
        private System.Windows.Forms.ComboBox cbbName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.CheckBox cbxDeleteWithoutConfirm;
        private System.Windows.Forms.Button btnAddCake;
        private System.Windows.Forms.ComboBox cbbGroup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPopCake;
    }
}