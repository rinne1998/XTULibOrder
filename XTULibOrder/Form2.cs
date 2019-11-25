using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XTULibOrder
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void OpenUrl(string link)
        {
            //调用系统默认的浏览器
            System.Diagnostics.Process.Start(link);
        }
        private void Label2_Click(object sender, EventArgs e)
        {
            OpenUrl("https://github.com/rinne1998/XTULibOder");
        }
    }
}
