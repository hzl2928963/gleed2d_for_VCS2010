using System;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Text.RegularExpressions;

namespace GLEED2D
{
    public partial class AddCustomProperty : Form
    {
        public CustomProperty cp = new CustomProperty();

        SerializableDictionary customproperties;


        public AddCustomProperty(SerializableDictionary currentproperties)
        {
            InitializeComponent();
            customproperties = currentproperties;
        }
        private void updateControls()
        {
            foreach (string key in customproperties.Keys)
            {
                bool isContain = false;
                foreach (string name in cbbName.Items)
                {
                    if (name.Equals(key))
                    {
                        isContain = true;
                    }
                }
                if (isContain == false)
                { 
                    cbbName.Items.Add(key); 
                }
            }
            if (customproperties.ContainsKey(cbbName.Text))
            {
                CustomProperty prop = customproperties[cbbName.Text];
                if (prop.type == typeof(bool))
                {
                    cbbBoolean.Text = prop.value.ToString().ToLower(); ;
                    rdbBoolean.Checked = true;
                }
                else if (prop.type == typeof(string))
                {
                    txbFreetext.Text = prop.value as string;
                    rdbFreeText.Checked = true;
                }
                else if (prop.type == typeof(Vector2))
                {
                    txbX.Text = ((Vector2)(prop.value)).X.ToString();
                    txbY.Text = ((Vector2)(prop.value)).Y.ToString();
                    rdbVector2.Checked = true;
                }
                else if (prop.type == typeof(Color))
                {
                    Color color = (Color)(prop.value);
                    btnColor.BackColor = System.Drawing.Color.FromArgb(color.R,color.G,color.B);
                    numUDR.Value = btnColor.BackColor.R;
                    numUDG.Value = btnColor.BackColor.G;
                    numUDB.Value = btnColor.BackColor.B;
                    rdbColor.Checked = true;
                }
                else if (prop.type == typeof(Item))
                {
                    rdbItem.Checked = true;
                }
                
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {

            if (cbbName.Text.Length==0)
            {
                MessageBox.Show("Please enter a Property Name.");
                return;
            }

            CustomProperty cp = new CustomProperty();
            cp.name = cbbName.Text;
            cp.description = textBox2.Text;
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
            if (cbxToAllSelected.Checked)//add to all selected items
            {
                foreach (Item item in Editor.Instance.SelectedItems)
                {
                    if (cbxAddMode.Checked)
                    {
                        item.CustomProperties[cp.name] = cp.clone();
                    }
                    else
                    {
                        if (item.CustomProperties.ContainsKey(cp.name)==false)
                        {
                            item.CustomProperties[cp.name] = cp.clone();
                        }
                    }
                }
            }
            else//add to selected
            {
                if (customproperties.ContainsKey(cbbName.Text))
                {
                    MessageBox.Show("A Custom Property with that name already exists.");
                    return;
                }
                customproperties[cp.name] = cp;
            }
            updateControls();
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
            if (customproperties == Editor.Instance.level.CustomProperties)
            {
                cbxToAllSelected.Visible = false;
            }
            else
            {
                foreach (Layer layer in Editor.Instance.level.Layers)
                {
                    if (layer.CustomProperties == customproperties)
                    {
                        cbxToAllSelected.Visible = false;
                        break;
                    }
                }
            }
            foreach(CustomPropertyGroup group in Editor.Instance.CustomPropertyGroups.Values)
            {
                cbbGroup.Items.Add(group.name);
            }
            updateControls();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // 将先中的颜色设置为窗体的背景色
                btnColor.BackColor = colorDialog1.Color;
                numUDR.Value = btnColor.BackColor.R;
                numUDG.Value = btnColor.BackColor.G;
                numUDB.Value = btnColor.BackColor.B;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void numUD_ValueChanged(object sender, EventArgs e)
        {
            cp.type = typeof(Color);
            btnColor.BackColor = System.Drawing.Color.FromArgb(byte.Parse(numUDR.Value.ToString()),byte.Parse(numUDG.Value.ToString()),byte.Parse( numUDB.Value.ToString()));
        }

        private void cbxAddToAllSelected_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cbbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateControls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool isSureToDelete=true;
            if (cbxDeleteWithoutConfirm.Checked == false
                && MessageBox.Show("Are you sure to delete property \""+cbbName.Text+"\" from selected items(s)", "Confirm deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                isSureToDelete = false;
            }
            if (isSureToDelete)
            {
                object delItem = cbbName.SelectedItem;
                if (cbxToAllSelected.Checked)//add to all selected items
                {
                    foreach (Item item in Editor.Instance.SelectedItems)
                    {
                        item.CustomProperties.Remove(cbbName.Text);
                    }
                    cbbName.Items.Remove(delItem);
                }
                else//add to selected
                {
                    if (customproperties.ContainsKey(cbbName.Text)==false)
                    {
                        MessageBox.Show("A Custom Property with that name doesn't exists.");
                        return;
                    }
                    customproperties.Remove(cbbName.Text);
                    cbbName.Items.Remove(delItem);
                }
                updateControls();
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

        private void cbxDeleteWithoutConfirm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCake_Click(object sender, EventArgs e)
        {
            if (Editor.Instance.CustomPropertyGroups.ContainsKey(cbbGroup.Text))
            {
                CustomPropertyGroup group = Editor.Instance.CustomPropertyGroups[cbbGroup.Text];
                foreach(CustomProperty prop in group.customproperties.Values)
                {
                    CustomProperty cp = new CustomProperty();
                    cp.name = (String)prop.name.Clone();
                    cp.description = (String)prop.description.Clone();
                    cp.type = prop.type;
                    if (prop.type == typeof(Vector2))
                    {
                        Regex r = new Regex(@"^\d+(\.)?\d*$");
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
                    if (cbxToAllSelected.Checked)//add to all selected items
                    {
                        foreach (Item item in Editor.Instance.SelectedItems)
                        {
                            if (cbxAddMode.Checked)
                            {
                                item.CustomProperties[cp.name] = cp.clone();
                            }
                            else
                            {
                                if (item.CustomProperties.ContainsKey(cp.name) == false)
                                {
                                    item.CustomProperties[cp.name] = cp.clone();
                                }
                            }
                        }
                    }
                    else//add to selected
                    {
                        if (customproperties.ContainsKey(cp.name) && cbxAddMode.Checked == false)
                        {
                            continue;
                        }
                        customproperties[cp.name] = cp.clone();
                    }
                }
                updateControls();
                MainForm.Instance.propertyGrid1.Refresh();
            }
            else
            {
                MessageBox.Show("A Custom Property Group with name \"" + cbbGroup.Text + "\" doesn't exists.");
            }
            
        }

        private void btnPopCake_Click(object sender, EventArgs e)
        {
            if (Editor.Instance.CustomPropertyGroups.ContainsKey(cbbGroup.Text))
            {
                bool isSureToDelete = true;
                if (cbxDeleteWithoutConfirm.Checked == false
                    && MessageBox.Show("Are you sure to delete property \"" + cbbName.Text + "\" from selected items(s)", "Confirm deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    isSureToDelete = false;
                }
                if (isSureToDelete)
                {
                    CustomPropertyGroup group = Editor.Instance.CustomPropertyGroups[cbbGroup.Text];
                    foreach (CustomProperty prop in group.customproperties.Values)
                    {
                        if (cbxToAllSelected.Checked)//to all selected items
                        {
                            foreach (Item item in Editor.Instance.SelectedItems)
                            {
                                item.CustomProperties.Remove(prop.name);
                            }
                        }
                        else//to selected
                        {
                            customproperties.Remove(prop.name);
                        }
                    }
                    updateControls();
                    MainForm.Instance.propertyGrid1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("A Custom Property Group with name \"" + cbbGroup.Text + "\" doesn't exists.");
            }
        }


    }
}
