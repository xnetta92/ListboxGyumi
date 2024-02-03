using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListboxGyumi
{
    public partial class Form_Fruits : Form
    {
        public Form_Fruits()
        {
            InitializeComponent();
        }

        private void Form_FruitsRegister_Load(object sender, EventArgs e)
        {

        }

        private void button_New_Click(object sender, EventArgs e)
        {
            Form_fruitsAdd form_FruitsAdd = new Form_fruitsAdd("add");
            form_FruitsAdd.ShowDialog();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (listBox_Fruits.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a fruit!");
                return;
            }
            Fruits fruits = (Fruits)listBox_Fruits.SelectedItem;
            listBox_Fruits.Items.Remove(fruits);
            Form_fruitsAdd form_FruitsAdd = new Form_fruitsAdd("edit", fruits);
            form_FruitsAdd.ShowDialog();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listBox_Fruits.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a fruit!");
                return;
            }
            Fruits fruits = (Fruits)listBox_Fruits.SelectedItem;
            listBox_Fruits.Items.Remove(fruits);         
        }
    }
}
