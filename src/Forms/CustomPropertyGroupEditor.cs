using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using System.Xml;
using System.Xml.Serialization;

namespace GLEED2D
{
    public partial class CustomPropertyGroupEditor : Form
    {
        public CustomPropertyGroupEditor()
        {
            InitializeComponent();
            custompropertyGroup=null;
            customproperties=null;
        }
        public CustomProperty cp = new CustomProperty();

        CustomPropertyGroup custompropertyGroup;
        SerializableDictionary customproperties;
        private void updateGroupEditControls()
        {
            if (custompropertyGroup == null)
            {
                cbbGroup.Text = null;
                return;
            }
            lbxProperty.Items.Clear();
            foreach (string key in customproperties.Keys)
            {
                lbxProperty.Items.Add(key);
            }
        }
        private void resetInputControls()
        {
            txbPropName.Text=txbFreetext.Text = txbDescription.Text = "";
            cbbBoolean.Text = "";
            txbX.Text = txbY.Text = "";
            numUDR.Value = numUDG.Value = numUDB.Value = 255;
            btnColor.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
        }
        private void updatePropertyEditControls()
        {
            resetInputControls();
            if (customproperties == null)
            {
                lbxProperty.Items.Clear();
                return;
            }
            foreach (string key in customproperties.Keys)
            {
                bool isContain = false;
                foreach (string name in lbxProperty.Items)
                {
                    if (name.Equals(key))
                    {
                        isContain = true;
                    }
                }
                if (isContain == false)
                {
                    lbxProperty.Items.Add(key);
                }
            }
            if (lbxProperty.SelectedItem!=null&&customproperties.ContainsKey(lbxProperty.SelectedItem.ToString()))
            {
                CustomProperty prop = customproperties[lbxProperty.SelectedItem.ToString()];
                txbPropName.Text = lbxProperty.SelectedItem.ToString();
                txbDescription.Text = prop.description;
                if (prop.type == typeof(bool))
                {
                    cbbBoolean.Text = prop.value.ToString().ToLower(); ;
                    cbbBoolean.Enabled = rdbBoolean.Checked = true;
                }
                else if (prop.type == typeof(string))
                {
                    txbFreetext.Text = prop.value as string;
                    txbFreetext.Enabled = rdbFreeText.Checked = true; 
                }
                else if (prop.type == typeof(Vector2))
                {
                    txbX.Text = ((Vector2)(prop.value)).X.ToString();
                    txbY.Text = ((Vector2)(prop.value)).Y.ToString();
                    txbX.Enabled = txbY.Enabled = rdbVector2.Checked = true;
                }
                else if (prop.type == typeof(Color))
                {
                    Color color = (Color)(prop.value);
                    numUDR.Value = color.R;
                    numUDG.Value = color.G;
                    numUDB.Value = color.B;
                    btnColor.BackColor = System.Drawing.Color.FromArgb(color.R, color.G, color.B);
                    btnColor.Enabled = numUDR.Enabled = numUDG.Enabled = numUDB.Enabled = rdbColor.Checked = true;
                }
                else if (prop.type == typeof(Item))
                {
                    rdbItem.Checked = true;
                }
            }
        }
        private CustomProperty cloneCustomProperty(CustomProperty prop)
        {
            CustomProperty cp = new CustomProperty();
            cp.name = (String)prop.name.Clone();
            cp.description = (String)prop.description.Clone();
            cp.type = prop.type;
            if (prop.type == typeof(Vector2))
            {
                float x = ((Vector2)(prop.value)).X;
                float y = ((Vector2)(prop.value)).Y;
                cp.value = new Vector2(x, y);
            }
            else if (prop.type == typeof(Color))
            {
                byte R = ((Color)(prop.value)).R;
                byte G = ((Color)(prop.value)).G;
                byte B = ((Color)(prop.value)).B;
                cp.value = new Color(R, G, B);
            }
            else
            {
                cp.value = prop.value;
            }
            return cp;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {

            if (txbPropName.Text.Length==0)
            {
                MessageBox.Show("Please enter a Property Name.");
                return;
            }

            CustomProperty cp = new CustomProperty();
            cp.name = (String)txbPropName.Text.Clone();
            cp.description = (String)txbDescription.Text.Clone();
            if (rdbFreeText.Checked)
            {
                cp.type = typeof(string);
                cp.value = txbFreetext.Text;
            }
            if (rdbBoolean.Checked)
            { 
                cp.type = typeof(bool);
                cp.value = cbbBoolean.SelectedItem.ToString().Equals("true");
            }
            if (rdbVector2.Checked)
            {
                cp.type = typeof(Vector2);
                Regex r=new Regex(@"^\d+(\.)?\d*$");
                if(r.IsMatch(txbX.Text)&&r.IsMatch(txbY.Text))
                {
                    float x=float.Parse(txbX.Text); 
                    float y=float.Parse(txbY.Text);
                    cp.value = new Vector2(x,y);
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric value.");
                    return;
                }
                
            }
            if (rdbColor.Checked)
            {
                cp.type = typeof(Color);
                byte R = byte.Parse(numUDR.Value.ToString());
                byte G = byte.Parse(numUDG.Value.ToString());
                byte B = byte.Parse(numUDB.Value.ToString());
                cp.value =new Color(R,G,B);
            }
            if (rdbItem.Checked)
            {
                cp.type = typeof(Item);
                cp.value = null;
            }
            if (cbxToAllSelected.Checked)//to all selected items
            {
                foreach (CustomPropertyGroup group in Editor.Instance.CustomPropertyGroups.Values)
                {
                    if (cbxAddMode.Checked)
                    {
                        group.customproperties[cp.name] = cp.clone();
                    }
                    else
                    {
                        if (group.customproperties.ContainsKey(cp.name) == false)
                        {
                            group.customproperties[cp.name] = cp.clone();
                        }
                    }
                }
            }
            else//to selected
            {
                if (customproperties.ContainsKey(txbPropName.Text)
                    && MessageBox.Show("A Custom Property with that name already exists.\nAre you sure to overwrite property \"" + txbPropName.Text + "\" from selected items(s)", "Confirm overwrite", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    return;
                }
                customproperties[cp.name] = cp.clone();
            }
            updatePropertyEditControls();
            MainForm.Instance.propertyGrid1.Refresh();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddCustomProperty_Load(object sender, EventArgs e)
        {
            foreach (CustomPropertyGroup group in Editor.Instance.CustomPropertyGroups.Values)
            {
                cbbGroup.Items.Add(group.name);
            }
            updatePropertyEditControls();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // 将先中的颜色设置为窗体的背景色
                byte R =colorDialog1.Color.R;
                byte G=colorDialog1.Color.G;
                byte B = colorDialog1.Color.B;
                btnColor.BackColor = System.Drawing.Color.FromArgb(R,G,B);
                numUDR.Value = R;
                numUDG.Value = G;
                numUDB.Value = B;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void numUD_ValueChanged(object sender, EventArgs e)
        {
            btnColor.BackColor = System.Drawing.Color.FromArgb(byte.Parse(numUDR.Value.ToString()),byte.Parse(numUDG.Value.ToString()),byte.Parse( numUDB.Value.ToString()));
        }

        private void cbxAddToAllSelected_CheckedChanged(object sender, EventArgs e)
        {
            cbxAddMode.Enabled = cbxToAllSelected.Checked;
        }

        private void cbbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePropertyEditControls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool isSureToDelete=true;
            if (cbxDeleteWithoutConfirm.Checked == false
                && MessageBox.Show("Are you sure to delete property \""+txbPropName.Text+"\" from selected items(s)", "Confirm deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                isSureToDelete = false;
            }
            if (isSureToDelete)
            {
                object delItem = lbxProperty.SelectedItem;
                if (cbxToAllSelected.Checked)//add to all selected items
                {
                    foreach (CustomPropertyGroup group in Editor.Instance.CustomPropertyGroups.Values)
                    {
                        group.customproperties.Remove(txbPropName.Text);
                    }
                    
                    lbxProperty.Items.Remove(delItem);
                }
                else//add to selected
                {
                    if (customproperties.ContainsKey(txbPropName.Text)==false)
                    {
                        MessageBox.Show("A Custom Property with that name doesn't exists.");
                        return;
                    }
                    customproperties.Remove(txbPropName.Text);
                    lbxProperty.Items.Remove(delItem);
                }
                updatePropertyEditControls();
                MainForm.Instance.propertyGrid1.Refresh();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdbBoolean_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbVector2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbItem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txbFreetext_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbBoolean_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbY_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numUDB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numUDG_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxAddMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ActionNewPropertyGroup(object sender, EventArgs e)
        {
            System.Drawing.Rectangle rect = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            String name = Interaction.InputBox("Please input a group name", "Input group name", "", rect.Width / 2 - MainForm.Instance.Location.X, rect.Height / 2-MainForm.Instance.Location.Y);
            if (name.Equals(""))
            {
                return;
            }
            foreach(object item in cbbGroup.Items)
            {
                String strName = item.ToString();
                if (strName.Equals(name))
                {
                    MessageBox.Show("A Custom Property Group with that name already exists.");
                    return;
                }
            }
            Editor.Instance.CustomPropertyGroups[name] = new CustomPropertyGroup(name,null);
            cbbGroup.Items.Add(name);
        }

        private void ActionOpenPropertyGroup(object sender, EventArgs e)
        {
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.Multiselect = true;
            opendialog.Filter = "XML Files (*.xml)|*.xml";
            if (opendialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String filename in opendialog.FileNames)
                {
                    FileStream stream = File.Open(filename, FileMode.Open);
                    XmlSerializer serializer = new XmlSerializer(typeof(SerializableDictionary));
                    int start=filename.LastIndexOf("\\");
                    start = start == -1 ? 0 : (start+1);
                    String name=filename.Substring(start,filename.LastIndexOf(".")-start);
                    Editor.Instance.CustomPropertyGroups[name] = new CustomPropertyGroup(name, filename);
                    Editor.Instance.CustomPropertyGroups[name].customproperties = (SerializableDictionary)serializer.Deserialize(stream);
                    stream.Close();
                    cbbGroup.Items.Add(name);
                    Editor.fixNullItems(Editor.Instance.CustomPropertyGroups[name].customproperties);
                }
            } 
        }

        private void ActionSavePropertyGroup(object sender, EventArgs e)
        {
            if (custompropertyGroup == null)
            {
                return;
            }
            if (custompropertyGroup.filepath == null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "XML Files (*.xml)|*.xml";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    custompropertyGroup.filepath = (String)dialog.FileName.Clone();
                }
            }
            if (custompropertyGroup.filepath != null)
            {
                XmlTextWriter writer = new XmlTextWriter(custompropertyGroup.filepath, null);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 4;
                XmlSerializer serializer = new XmlSerializer(typeof(SerializableDictionary));
                serializer.Serialize(writer, custompropertyGroup.customproperties);
                writer.Close();
            }
        }

        private void ActionSavePropertyGroupAs(object sender, EventArgs e)
        {
            if (custompropertyGroup == null)
            {
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML Files (*.xml)|*.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                XmlTextWriter writer = new XmlTextWriter(dialog.FileName, null);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 4;
                XmlSerializer serializer = new XmlSerializer(typeof(SerializableDictionary));
                serializer.Serialize(writer, custompropertyGroup.customproperties);
                writer.Close();
            }
        }

        private void cbbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            custompropertyGroup = Editor.Instance.CustomPropertyGroups[cbbGroup.Text];
            customproperties = custompropertyGroup.customproperties;
            updateGroupEditControls();
        }

        private void lbxProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePropertyEditControls();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBoxFind(cbbGroup,cbbGroup.Text))
            {
                 bool isSureToDelete=true;
                if (cbxDeleteWithoutConfirm.Checked == false
                    && MessageBox.Show("Are you sure to delete Custom Property Group \""+txbPropName.Text+"\" from selected items(s)", "Confirm deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    isSureToDelete = false;
                }
                if (isSureToDelete)
                {
                    Editor.Instance.CustomPropertyGroups.Remove(cbbGroup.Text);
                    comboBoxRemove(cbbGroup,cbbGroup.Text);
                    cbbGroup.Text = "";
                    custompropertyGroup = null;
                    customproperties = null;
                    updateGroupEditControls();
                }
            }
            else
            {
                MessageBox.Show("A Custom Property Group with that name doesn't exist.");
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBoxFind(cbbGroup, cbbGroup.Text))
            {
                System.Drawing.Rectangle rect = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                String name = Interaction.InputBox("Please input a group name", "Input group name", "", rect.Width / 2 - MainForm.Instance.Location.X, rect.Height / 2 - MainForm.Instance.Location.Y);
                Editor.Instance.CustomPropertyGroups[name] = Editor.Instance.CustomPropertyGroups[cbbGroup.Text];
                Editor.Instance.CustomPropertyGroups.Remove(cbbGroup.Text);
                comboBoxRemove(cbbGroup, cbbGroup.Text);
                cbbGroup.Items.Add(name);
                cbbGroup.Text = name;
                custompropertyGroup = Editor.Instance.CustomPropertyGroups[cbbGroup.Text];
                customproperties = custompropertyGroup.customproperties;
                updateGroupEditControls();
            }
            else
            {
                MessageBox.Show("A Custom Property Group with that name doesn't exist.");
            }
        }
        private bool comboBoxFind(ComboBox cbb, String value)
        {
            foreach (object item in cbb.Items)
            {
                if (item.ToString().Equals(value))
                {
                    return true;
                }
            }
            return false;
        }
        private void comboBoxRemove(ComboBox cbb, String value)
        {
            foreach (object item in cbb.Items)
            {
                if (item.ToString().Equals(value))
                {
                    cbbGroup.Items.Remove(item);
                    return;
                }
            }
        }
    }
}
