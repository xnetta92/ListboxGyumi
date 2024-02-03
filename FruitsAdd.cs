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
    public partial class Form_fruitsAdd : Form
    {
        
        public Form_fruitsAdd()
        {
            InitializeComponent();
        }

        private void Form_fruitsAdd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong productC = (ulong)(Program.openForm.listBox_Fruits.Items.Count + 1);
            if (String.IsNullOrEmpty(textBox_name.Text))
            {
                MessageBox.Show("Please fill it!");
                textBox_name.Focus();
                return;
            }
            string name = textBox_name.Text;
            if (numericUpDown_amount.Value == 0)
            {
                MessageBox.Show("Can't add zero!");
                return;
            }

            Fruits newFrutis = new Fruits(productC, name, (int)numericUpDown_amount.Value);
            Program.openForm.listBox_Fruits.Items.Add(newFrutis);
            this.Close();
        }
    }
}
