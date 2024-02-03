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
            Form_fruitsAdd form_FruitsAdd = new Form_fruitsAdd();
            form_FruitsAdd.ShowDialog();
        }
    }
}
