using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListboxGyumi
{
    internal static class Program
    {
        public static Form_Fruits openForm = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            openForm = new Form_Fruits();
            Application.Run(openForm);
        }
    }
}
