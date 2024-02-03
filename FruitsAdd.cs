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
        string action;
        public Form_fruitsAdd(string action, Object param = null)
        {
            InitializeComponent();
            this.action = action;
            switch (action)
            {
                case "add":
                    button1.Text = "Submit";
                    this.Text = "Add new fruit";
                    break;
                case "edit":
                    button1.Text = "Edit";
                    this.Text = "Edit fruit";
                    //Fruits fruits = (Fruits)Program.openForm.listBox_Fruits.SelectedItem;
                    Fruits fruits = (Fruits)param;
                    textBox_productCode.Text = fruits.ProductC.ToString();
                    textBox_name.Text = fruits.Name;
                    numericUpDown_amount.Value = fruits.Amount;
                    break;
                default:
                    break;
            }
        }

        private void Form_fruitsAdd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 switch (action)
            {
                case "add":
                    newFruit();
                    break;
                case "edit":
                    editFruit();
                    break;
                default:
                    break;
            }
        }

        private void editFruit()
        {
            ulong productC = ulong.Parse(textBox_productCode.Text);
            if (String.IsNullOrEmpty(textBox_name.Text))
            {
                MessageBox.Show("Missing name!");
                textBox_name.Focus();
                return;
            }
            string name = textBox_name.Text;
            if (numericUpDown_amount.Value == 0)
            {
                MessageBox.Show("Can't add zero!");
                return;
            }
            //-- The data is acceptable.
            Fruits fruits = new Fruits(productC, name, (int)numericUpDown_amount.Value);
            Program.openForm.listBox_Fruits.Items.Add(fruits);
            this.Close();

        } 

        void newFruit()
        {
            ulong productC = (ulong)(Program.openForm.listBox_Fruits.Items.Count + 1);
            if (String.IsNullOrEmpty(textBox_name.Text))
            {
                MessageBox.Show("Missing name!");
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
