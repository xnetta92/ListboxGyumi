using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                using (StreamWriter myStream = new StreamWriter(filename))
                {
                    foreach (Fruits item in listBox_Fruits.Items)
                    {
                        myStream.Write(item.toTxt());
                    }
                    myStream.Flush();
                }
            }
            
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string adatFile = openFileDialog.FileName;
                using (StreamReader sr = new StreamReader(adatFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] sor = sr.ReadLine().Split(';');
                        Fruits fruits = new Fruits(ulong.Parse(sor[0]), sor[1], int.Parse(sor[2]));
                        listBox_Fruits.Items.Add(fruits);
                    }
                }
            }
        }
    }
}




