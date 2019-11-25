using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Noesis.Javascript;
using Ivony.Html;
using Ivony.Html.Parser;

namespace XTULibOrder
{
    public partial class Form1 : Form
    {
        Thread t1,t2,t3,t4,t5,t6,t7,t8,t9,t10,t11,t12,t13,t14,t15;

        string cookiesA= "";
        string Code;
        string[] L10837 = { "10,15", "10,16", "12,15", "14,16", "14,17", "14,18", "16,14", "16,15", "18,14", "18,18", "20,17", "24,16", "26,16", "28,18", "30,15", "30,18", "32,17", "34,16", "34,18", "36,15", "36,16", "36,18", "38,15", "38,16", "38,18", "40,15", "12,16", "14,14", "14,15", "16,16", "16,17", "16,18", "18,15", "18,16", "18,17", "20,15", "20,16", "20,18", "22,15", "22,16", "22,17", "22,18", "24,15", "24,17", "24,18", "26,15", "26,17", "26,18", "28,15", "28,16", "28,17", "30,16", "30,17", "32,15", "32,16", "32,18", "34,15", "34,17", "36,17", "38,14", "38,17", "40,14", "40,16", "40,17", "40,18" };
        string[] L11403 ={"10,15", "10,16", "12,15", "12,16", "14,14", "14,15", "14,16", "14,17", "14,18", "16,14", "16,15", "16,16", "16,17", "16,18", "18,14", "18,15", "18,16", "18,17", "18,18", "20,14", "20,15", "20,16", "20,17", "20,18", "22,14", "22,15", "22,16", "22,17", "22,18", "24,14", "24,15", "24,16", "24,17", "24,18", "26,14", "26,15", "26,16", "26,17", "26,18", "28,14", "28,15", "28,16", "28,17", "28,18", "30,14", "30,15", "30,16", "30,17", "30,18", "32,14", "32,15", "32,16", "32,17", "32,18", "34,14", "34,15", "34,16", "34,17", "34,18", "36,14", "36,15", "36,16", "36,17", "36,18", "38,14", "38,15", "38,16", "38,17", "38,18", "40,14", "40,15", "40,16", "40,17", "40,18" };
        string[] L10550 = { "9,14", "9,15", "11,14", "11,15", "13,14", "13,15", "15,14", "15,15", "17,14", "17,15", "19,14", "19,15", "21,14", "21,15", "23,14", "23,15", "25,14", "25,15", "27,14", "27,15", "29,14", "29,15", "31,14", "31,15", "33,14", "33,15", "35,14", "35,15", "37,14", "37,15", "39,14", "39,15", "41,14", "41,15", "43,14", "43,15", "45,14", "45,15", "47,14", "47,15" };
        string[] L10557 ={"8,14", "8,15", "8,16", "10,14", "10,15", "10,16", "12,14", "12,15", "12,16", "14,14", "14,15", "14,16", "16,14", "16,15", "16,16", "18,14", "18,15", "18,16", "20,14", "20,15", "20,16", "22,14", "22,15", "22,16", "24,14", "24,15", "24,16", "26,14", "26,15", "26,16", "28,14", "28,15", "28,16", "30,14", "30,15", "30,16", "32,14", "32,15", "32,16", "34,14", "34,15", "34,16", "36,14", "36,15", "36,16", "38,14", "38,15", "38,16", "40,14", "40,15", "40,16", "42,14", "42,15", "42,16", "44,14", "44,15", "44,16", "46,14", "46,15", "46,16", "48,14", "48,15", "48,16", "50,14", "50,15", "50,16", "52,14", "52,15", "52,16", "54,14", "54,15", "54,16" };
        string[] L10564 ={"8,13", "8,14", "8,15", "10,13", "10,14", "10,15", "12,13", "12,14", "12,15", "14,13", "14,14", "14,15", "16,13", "16,14", "16,15", "18,13", "18,14", "18,15", "20,13", "20,14", "20,15", "22,13", "22,14", "22,15", "24,13", "24,14", "24,15", "26,13", "26,14", "26,15", "28,13", "28,14", "28,15", "30,13", "30,14", "30,15", "32,13", "32,14", "32,15", "34,13", "34,14", "34,15", "36,13", "36,14", "36,15", "38,13", "38,14", "38,15", "40,13", "40,14", "40,15", "42,13", "42,14", "42,15", "44,13", "44,14", "44,15", "46,13", "46,14", "46,15", "48,13", "48,14", "48,15", "50,13", "50,14", "50,15", "52,13", "52,14", "52,15", "54,13", "54,14", "54,15" };
        string[] L10487 ={"8,14", "8,15", "8,16", "10,14", "10,15", "10,16", "12,14", "12,15", "12,16", "14,14", "14,15", "14,16", "16,14", "16,15", "16,16", "18,14", "18,15", "18,16", "20,14", "20,15", "20,16", "22,14", "22,16", "24,14", "24,15", "24,16", "26,15", "26,16", "28,14", "28,15", "28,16", "30,14", "30,15", "30,16", "32,14", "32,16", "34,14", "34,15", "34,16", "36,14", "36,15", "36,16", "38,14", "38,15", "38,16" };
        string[] L10634 ={"8,13", "8,14", "8,15", "10,13", "10,14", "10,15", "12,13", "12,14", "12,15", "14,13", "14,14", "14,15", "16,13", "16,14", "16,15", "18,13", "18,14", "18,15", "20,13", "20,14", "20,15", "22,13", "22,14", "22,15", "24,13", "24,14", "24,15", "26,13", "26,14", "26,15", "28,13", "28,14", "28,15", "30,13", "30,14", "30,15", "32,13", "32,14", "32,15", "34,13", "34,14", "34,15", "36,13", "36,14", "36,15", "38,13", "38,14", "38,15", "40,13", "40,14", "40,15", "42,13", "42,14", "42,15", "44,13", "44,14", "44,15", "46,13", "46,14", "46,15", "48,13", "48,14", "48,15", "50,13", "50,14", "50,15", "52,13", "52,14", "52,15", "54,13", "54,14", "54,15"};
        string[] L10655 ={"8,14", "8,15", "8,16", "10,14", "10,15", "10,16", "12,14", "12,15", "12,16", "14,14", "14,15", "14,16", "16,14", "16,15", "16,16", "18,14", "18,15", "18,16", "20,14", "20,15", "20,16", "22,14", "22,15", "22,16", "24,14", "24,15", "24,16", "26,14", "26,15", "26,16", "28,14", "28,15", "28,16", "30,14", "30,15", "30,16", "32,14", "32,15", "32,16", "34,14", "34,15", "34,16", "36,14", "36,15", "36,16", "38,14", "38,15", "38,16", "40,14", "40,15", "40,16", "42,14", "42,15", "42,16", "44,14", "44,15", "44,16", "46,14", "46,15", "46,16", "48,14", "48,15", "48,16", "50,14", "50,15", "50,16", "52,14", "52,15", "52,16", "54,14", "54,15", "54,16" };
        string[] L10494 ={"6,8", "6,10", "6,13", "6,15", "6,18", "6,20", "6,23", "6,25", "6,28", "6,30", "7,8", "7,10", "7,13", "7,15", "7,18", "7,20", "7,23", "7,25", "7,28", "7,30", "8,8", "8,10", "8,13", "8,15", "8,18", "8,20", "8,23", "8,25", "8,28", "8,30", "9,8", "9,10", "9,13", "9,15", "9,18", "9,20", "9,23", "9,25", "9,28", "9,30", "10,8", "10,10", "10,13", "10,15", "10,18", "10,20", "10,23", "10,25", "10,28", "10,30", "11,8", "11,10", "11,13", "11,15", "11,18", "11,20", "11,23", "11,25", "11,28", "11,30", "12,8", "12,10", "12,13", "12,15", "12,18", "12,20", "12,23", "12,25", "12,28", "12,30", "13,8", "13,10", "13,13", "13,15", "13,18", "13,20", "13,23", "13,25", "13,28", "13,30", "14,8", "14,10", "14,13", "14,15", "14,18", "14,20", "14,23", "14,25", "14,28", "14,30" };
        string[] L10641 ={"9,14", "9,15", "11,14", "11,15", "13,14", "13,15", "15,14", "15,15", "17,14", "17,15", "19,14", "19,15", "21,14", "21,15", "23,14", "23,15", "25,14", "25,15", "27,14", "27,15", "29,14", "29,15", "31,14", "31,15", "33,14", "33,15", "35,14", "35,15", "37,14", "37,15", "39,14", "39,15", "41,14", "41,15", "43,14", "43,15", "45,14", "45,15", "47,14", "47,15", "49,14", "49,15", "51,14", "51,15", "53,14", "53,15", "55,14", "55,15" };
        string[] L10501 ={"5,7", "5,8", "5,9", "5,10", "5,23", "5,25", "5,28", "5,30", "5,43", "5,44", "5,45", "5,46", "6,18", "6,20", "6,23", "6,25", "6,28", "6,30", "6,33", "6,35", "7,7", "7,8", "7,9", "7,10", "7,18", "7,20", "7,23", "7,25", "7,28", "7,30", "7,33", "7,35", "7,43", "7,44", "7,45", "7,46", "8,13", "8,15", "8,18", "8,20", "8,23", "8,25", "8,28", "8,30", "8,33", "8,35", "8,38", "8,40", "9,13", "9,15", "9,18", "9,20", "9,23", "9,25", "9,28", "9,30", "9,33", "9,35", "9,38", "9,40", "10,7", "10,8", "10,9", "10,10", "10,13", "10,15", "10,18", "10,20", "10,23", "10,25", "10,28", "10,30", "10,33", "10,35", "10,38", "10,40", "10,43", "10,44", "10,45", "10,46", "11,18", "11,20", "11,23", "11,25", "11,28", "11,30", "11,33", "11,35", "12,7", "12,8", "12,9", "12,10", "12,23", "12,25", "12,28", "12,30", "12,43", "12,44", "12,45", "12,46" };
        string[] L10669 ={"8,14", "8,15", "8,16", "10,14", "10,15", "10,16", "12,14", "12,15", "12,16", "14,14", "14,15", "14,16", "16,14", "16,15", "16,16", "18,14", "18,15", "18,16", "20,14", "20,15", "20,16", "22,14", "22,15", "22,16", "24,14", "24,15", "24,16", "26,14", "26,15", "26,16", "28,14", "28,15", "28,16", "30,14", "30,15", "30,16", "32,14", "32,15", "32,16", "34,14", "34,15", "34,16", "36,14", "36,15", "36,16", "38,14", "38,15", "38,16", "40,14", "40,15", "40,16", "42,14", "42,15", "42,16", "44,14", "44,15", "44,16", "46,14", "46,15", "46,16", "48,14", "48,15", "48,16", "50,14", "50,15", "50,16", "52,14", "52,15", "52,16", "54,14", "54,15", "54,16", "56,14", "56,15", "56,16", "58,14", "58,15", "58,16", "60,14", "60,15", "60,16", "62,14", "62,15", "62,16"};
        string[] L10662 ={"8,14", "8,15", "8,16", "10,14", "10,15", "10,16", "12,14", "12,15", "12,16", "14,14", "14,15", "14,16", "16,14", "16,15", "16,16", "18,14", "18,15", "18,16", "20,14", "20,15", "20,16", "22,14", "22,15", "22,16", "24,14", "24,15", "24,16", "26,14", "26,15", "26,16", "28,14", "28,15", "28,16", "30,14", "30,15", "30,16", "32,14", "32,15", "32,16", "34,14", "34,15", "34,16", "36,14", "36,15", "36,16", "38,14", "38,15", "38,16", "40,14", "40,15", "40,16", "42,14", "42,15", "42,16", "44,14", "44,15", "44,16", "46,14", "46,15", "46,16", "48,14", "48,15", "48,16", "50,14", "50,15", "50,16", "52,14", "52,15", "52,16", "54,14", "54,15", "54,16", "56,14", "56,15", "56,16", "58,14", "58,15", "58,16", "60,14", "60,15", "60,16", "62,14", "62,15", "62,16", "64,14", "64,15", "64,16", "66,14", "66,15", "66,16" };
        string[] L10648 ={"9,14", "9,15", "11,14", "11,15", "13,14", "13,15", "15,14", "15,15", "17,14", "17,15", "19,14", "19,15", "21,14", "21,15", "23,14", "23,15", "25,14", "25,15", "27,14", "27,15", "29,14", "29,15", "31,14", "31,15", "33,14", "33,15", "35,14", "35,15", "37,14", "37,15", "39,14", "39,15", "41,14", "41,15", "43,14", "43,15", "45,14", "45,15", "47,14", "47,15", "49,14", "49,15", "51,14", "51,15", "53,14", "53,15", "55,14", "55,15"};
        string[] L10508 ={"5,5", "5,6", "5,7", "5,8", "5,41", "5,42", "5,43", "5,44", "6,16", "6,18", "6,21", "6,23", "6,26", "6,28", "6,31", "6,33", "7,5", "7,6", "7,7", "7,8", "7,16", "7,18", "7,21", "7,23", "7,26", "7,28", "7,31", "7,33", "7,41", "7,42", "7,43", "7,44", "8,11", "8,13", "8,16", "8,18", "8,21", "8,23", "8,26", "8,28", "8,31", "8,33", "8,36", "8,38", "9,11", "9,13", "9,16", "9,18", "9,21", "9,23", "9,26", "9,28", "9,31", "9,33", "9,36", "9,38", "10,11", "10,13", "10,16", "10,18", "10,21", "10,23", "10,26", "10,28", "10,31", "10,33", "10,36", "10,38", "11,5", "11,6", "11,7", "11,8", "11,16", "11,18", "11,21", "11,23", "11,26", "11,28", "11,31", "11,33", "11,41", "11,42", "11,43", "11,44", "13,5", "13,6", "13,7", "13,8", "13,41", "13,42", "13,43", "13,44" };

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        private void QL10564()
        {
            foreach (string item in L10564)
            {
                try
                {
                    textBox5.AppendText(Get("https://wechat.laixuanzuo.com/index.php/reserve/get/libid=10564&" + GetCode() + "=" + item + "&yzm=", cookiesA));
                }
                catch
                {
                }
            }

        }
        private void QL10837()
        {
            foreach (string item in L10837)
            {
                try
                {
                    textBox5.AppendText(Get("https://wechat.laixuanzuo.com/index.php/reserve/get/libid=10837&" + GetCode() + "=" + item + "&yzm=", cookiesA));
                }
                catch
                {
                }
            }

        }
        private void QL10557()
        {
            foreach (string item in L10557)
            {
                try
                {
                    textBox5.AppendText(Get("https://wechat.laixuanzuo.com/index.php/reserve/get/libid=10557&" + GetCode() + "=" + item + "&yzm=", cookiesA));
                }
                catch
                {
                }
            }
        }
        private void QL10550()
        {
            foreach (string item in L10550)
            {
                try
                {
                    textBox5.AppendText(Get("https://wechat.laixuanzuo.com/index.php/reserve/get/libid=10550&" + GetCode() + "=" + item + "&yzm=", cookiesA));
                }
                catch
                {
                }
            }
        }
        private void QL10487()
        {
            foreach (string item in L10487)
            {
                try
                {
                    textBox5.AppendText(Get("https://wechat.laixuanzuo.com/index.php/reserve/get/libid=10487&" + GetCode() + "=" + item + "&yzm=", cookiesA));
                }
                catch
                {
                }
            }
        }
        private void QL10634()
        {
            foreach (string item in L10634)
            {
                try
                {
                    textBox5.AppendText(Get("https://wechat.laixuanzuo.com/index.php/reserve/get/libid=10634&" + GetCode() + "=" + item + "&yzm=", cookiesA));
                }
                catch
                {
                }
            }
        }
        private void QL10662()
        {
            foreach (string item in L10662)
            {
                try
                {
                    textBox5.AppendText(Get("https://wechat.laixuanzuo.com/index.php/reserve/get/libid=10662&" + GetCode() + "=" + item + "&yzm=", cookiesA));
                }
                catch
                {
                }
            }
        }
        private void QL10501()
        {
            foreach (string item in L10501)
            {
                try
                {
                    textBox5.AppendText(Get("https://wechat.laixuanzuo.com/index.php/reserve/get/libid=10501&" + GetCode() + "=" + item + "&yzm=", cookiesA));
                }
                catch
                {
                }
            }
        }
        private void QL10669()
        {
            foreach (string item in L10669)
            {
                try
                {
                    textBox5.AppendText(Get("https://wechat.laixuanzuo.com/index.php/reserve/get/libid=10669&" + GetCode() + "=" + item + "&yzm=", cookiesA));
                }
                catch
                {
                }
            }
        }
        private void QL10641()
        {
            foreach (string item in L10641)
            {
                try
                {
                    textBox5.AppendText(Get("https://wechat.laixuanzuo.com/index.php/reserve/get/libid=10641&" + GetCode() + "=" + item + "&yzm=", cookiesA));
                }
                catch
                {
                }
            }
        }
        private void QL10494()
        {
            foreach (string item in L10494)
            {
                try
                {
                    textBox5.AppendText(Get("https://wechat.laixuanzuo.com/index.php/reserve/get/libid=10494&" + GetCode() + "=" + item + "&yzm=", cookiesA));
                }
                catch
                {
                }
            }
        }
        private void QL10655()
        {
            foreach (string item in L10655)
            {
                try
                {
                    textBox5.AppendText(Get("https://wechat.laixuanzuo.com/index.php/reserve/get/libid=10655&" + GetCode() + "=" + item + "&yzm=", cookiesA));
                }
                catch
                {
                }
            }
        }
        private void QL11403()
        {
            foreach (string item in L11403)
            {
                try
                {
                    textBox5.AppendText(Get("https://wechat.laixuanzuo.com/index.php/reserve/get/libid=11403&" + GetCode() + "=" + item + "&yzm=", cookiesA));                    
                }
                catch
                {
                }
            }
        }
        private void QL10648()
        {
            foreach (string item in L10648)
            {
                try
                {
                    textBox5.AppendText(Get("https://wechat.laixuanzuo.com/index.php/reserve/get/libid=10648&" + GetCode() + "=" + item + "&yzm=", cookiesA));
                }
                catch
                {
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "")
            {
                cookiesA = "Hm_lpvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + "; Hm_lvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + ";FROM_TYPE=weixin;wechatSESS_ID=" + textBox1.Text;
                label7.Text = "Cookie已生成";
                label7.ForeColor = System.Drawing.Color.Black;
                MessageBox.Show("Success！");
                checkBox2.Enabled = true;
                checkBox2.Checked = true;
            }
            else {
                MessageBox.Show("请填入ID！");
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString("HH:mm:ss");
            label9.Text = now;
            //设置固定时间要执行的事件
            switch (now)
            {
                case "7:29:58":
                    Start();
                    break;
                case "13:59:59":
                    QL10837();
                    break;
            }
        }

        private void QL10508()
        {
            foreach (string item in L10508)
            {
                try
                {
                    Get("https://wechat.laixuanzuo.com/index.php/reserve/get/libid=10508&" + GetCode() + "=" + item + "&yzm=", cookiesA);

                }
                catch
                { }
            }
            //Get( "https://wechat.laixuanzuo.com/index.php/reserve/get/libid=10508&"+ GetCode() + "=" + "5,5" + "&yzm=",cookiesA);
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Form2 Form = new Form2();
            Form.StartPosition = FormStartPosition.CenterParent;
            Form.ShowDialog();

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            if (cookiesA != "")
            {
                Index();
            }
            else
            {
                MessageBox.Show("请先生成Cookie！");
            }
        }

        public void Index()
        {
            try
            {

                string now = Convert.ToDateTime(GetNetDateTime()).ToString("HH:mm:ss");
                textBox3.Clear();
                string text1;
                //需要给utf-8的编码，否则html是乱码。
                IHtmlDocument source = new JumonyParser().Parse(Get("http://wechat.laixuanzuo.com/index.php/reserve/index.html?f=wechat", "Hm_lpvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + "; Hm_lvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + ";FROM_TYPE=weixin;wechatSESS_ID=" + textBox1.Text));
                //IHtmlDocument source = new JumonyParser().LoadDocument("http://127.0.0.1:5500/a.html", System.Text.Encoding.GetEncoding("utf-8"));
                var A = source.Find(".list-group-item-heading");
                foreach (var i in A)
                {
                    text1 = i.InnerText().ToString();
                    text1 = text1.Replace("\n", "   ");
                    textBox3.AppendText(text1 + System.Environment.NewLine);
                    //MessageBox.Show(i.InnerText().ToString());
                }
                textBox3.AppendText("刷新时间" + now + System.Environment.NewLine);
            }
            catch
            {
            }

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                timer2.Enabled = true;
            }
            else
            {
                timer2.Enabled = false;
            }

        }
        public string GetNetDateTime()
        {
            WebRequest request = null;
            WebResponse response = null;
            WebHeaderCollection headerCollection = null;
            string datetime = string.Empty;
            try
            {
                request = WebRequest.Create("https://www.baidu.com");
                request.Timeout = 3000;
                request.Credentials = CredentialCache.DefaultCredentials;
                response = (WebResponse)request.GetResponse();
                headerCollection = response.Headers;
                foreach (var h in headerCollection.AllKeys)
                { if (h == "Date") { datetime = headerCollection[h]; } }
                return datetime;
            }
            catch (Exception) { return datetime; }
            finally
            {
                if (request != null)
                { request.Abort(); }
                if (response != null)
                { response.Close(); }
                if (headerCollection != null)
                { headerCollection.Clear(); }
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                Index();
            }
            catch {
            }
        }

        private string GetCode()
        {
            string exjs;
            string exjs2;
            string exjs3;
            string js3;
            string Code;
            //MessageBox.Show(Get("http://wechat.laixuanzuo.com/index.php/reserve/index.html?f=wechat", "Hm_lpvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + "; Hm_lvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + ";FROM_TYPE=weixin;wechatSESS_ID=" + textBox1.Text));
            string rs = Get("http://wechat.laixuanzuo.com/index.php/reserve/index.html?f=wechat", "Hm_lpvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + "; Hm_lvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + ";FROM_TYPE=weixin;wechatSESS_ID=" + textBox1.Text);
            string pattern = textBox7.Text;
            Match match = Regex.Match(rs, @pattern);
            exjs = Get("https://static.wechat.laixuanzuo.com/template/theme2/cache/layout/" + match.Groups[1].Value + ".js", "");
            //textBox5.Text = exjs;
            Match match2 = Regex.Match(exjs, @textBox8.Text);
            exjs2 = match2.Groups[1].Value;
            //textBox5.Text = exjs2;
            Match match3 = Regex.Match(exjs, @textBox9.Text);
            exjs3 = match3.Groups[1].Value;
            js3 = exjs + exjs2 + exjs3;
            Code = VCode(js3);

            return Code;
        }

        private void OrderSeat(string url)
        {
            Get(url, "Hm_lpvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + "; Hm_lvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + ";FROM_TYPE=weixin;wechatSESS_ID=" + textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // textBox5.AppendText(Get("http://wechat.laixuanzuo.com/index.php/reserve/index.html?f=wechat", "Hm_lpvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + "; Hm_lvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + ";FROM_TYPE=weixin;wechatSESS_ID="+ textBox1.Text));
            // cookiesA = "Hm_lpvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + "; Hm_lvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + ";FROM_TYPE=weixin;wechatSESS_ID=" + textBox1.Text;
            ActiveControl = textBox1;
        }

        public static string GetTimeStamp(bool bflag)
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            string ret = string.Empty;
            if (bflag)
                ret = Convert.ToInt64(ts.TotalSeconds).ToString();
            else
                ret = Convert.ToInt64(ts.TotalMilliseconds).ToString();

            return ret;
        }


        public static void SetHeaderValue(WebHeaderCollection header, string name, string value)
        {
            var property = typeof(WebHeaderCollection).GetProperty("InnerCollection", BindingFlags.Instance | BindingFlags.NonPublic);
            if (property != null)
            {
                var collection = property.GetValue(header, null) as NameValueCollection;
                collection[name] = value;
            }
        }


        public static string Get(string Url, string cookies)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
            if (cookies != null)
                request.Headers.Add("Cookie", cookies);
            SetHeaderValue(request.Headers, "Host", "wechat.laixuanzuo.com");
            SetHeaderValue(request.Headers, "Connection", "keep-alive");
            SetHeaderValue(request.Headers, "Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
            SetHeaderValue(request.Headers, "User-Agent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_4) AppleWebKit/605.1.15 (KHTML, like Gecko) MicroMessenger/2.3.24(0x12031810) MacWechat NetType/WIFI WindowsWechat");
            SetHeaderValue(request.Headers, "Referer", "https://wechat.laixuanzuo.com/index.php/prereserve/index.html");
            SetHeaderValue(request.Headers, "Accept-Language", "zh-cn");
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            //SetHeaderValue(request.Headers, "Cookie", "Hm_lpvt_7838cef374eb966ae9ff502c68d6f098 = "+ "" +"; Hm_lvt_7838cef374eb966ae9ff502c68d6f098 = "+ "" + "; FROM_TYPE = weixin; wechatSESS_ID = "+ textb);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string encoding = response.ContentEncoding;
            if (encoding == null || encoding.Length < 1)
            {
                encoding = "UTF-8"; //默认编码  
            }
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
            string retString = reader.ReadToEnd();
            
            return retString;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string exjs;
            string exjs2;
            string exjs3;
            string js3;
            //MessageBox.Show(Get("http://wechat.laixuanzuo.com/index.php/reserve/index.html?f=wechat", "Hm_lpvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + "; Hm_lvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + ";FROM_TYPE=weixin;wechatSESS_ID=" + textBox1.Text));
            string rs = Get("http://wechat.laixuanzuo.com/index.php/reserve/index.html?f=wechat", "Hm_lpvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + "; Hm_lvt_7838cef374eb966ae9ff502c68d6f098=" + GetTimeStamp(true) + ";FROM_TYPE=weixin;wechatSESS_ID=" + textBox1.Text);
            string pattern = textBox7.Text;
            Match match = Regex.Match(rs, @pattern);
            exjs = Get("https://static.wechat.laixuanzuo.com/template/theme2/cache/layout/" + match.Groups[1].Value + ".js", "");
            //textBox5.Text = exjs;
            Match match2 = Regex.Match(exjs, @textBox8.Text);
            exjs2 = match2.Groups[1].Value;
            //textBox5.Text = exjs2;
            Match match3 = Regex.Match(exjs, @textBox9.Text);
            exjs3 = match3.Groups[1].Value;
            js3 = exjs + exjs2 + exjs3;
            label4.Text = VCode(js3);
        }

        private string VCode(string js1)
        {
            string code;
            code = "XXXX";
            try
            {
                using (JavascriptContext ctx = new JavascriptContext())
                {
                    var j = ctx.Run(js1);
                    code = j.ToString();
                }
                
            }
            catch {

            }
            label4.Text = code;
            return code;
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void Button4_Click(object sender, EventArgs e)
        {
            //QL10508();
            //QL10648();
            //Get( "https://wechat.laixuanzuo.com/index.php/reserve/get/libid=10508&"+ GetCode() + " = " + i + '&yzm='",);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Start();


        }

        private void Start()
        {
            if (cookiesA != "")
            {

                if (checkBox1.Checked == true)
                {
                    t1.Start();
                    t2.Start();
                    t3.Start();
                    t4.Start();
                    t5.Start();
                    t6.Start();
                    t7.Start();
                    t8.Start();
                    t9.Start();
                    t10.Start();
                    t12.Start();
                    t13.Start();
                    t11.Start();
                    t14.Start();
                    t15.Start();


                }
                else
                {
                    if (radioButton1.Checked == true)
                    {
                        //QL10501();
                        QL10662();
                        QL10669();
                        
                        //QL10508();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }


                    if (radioButton2.Checked == true)
                    {
                        QL10655();
                        QL10634();

                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }


                    if (radioButton3.Checked == true)
                    {
                        QL10564();
                        QL10557();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }


                    if (radioButton4.Checked == true)
                    {
                        QL10550();
                        QL10487();
                        QL10837();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }


                    if (radioButton5.Checked == true)
                    {
                        QL10641();
                        QL11403();
                        QL10648();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }



                    if (radioButton15.Checked == true)
                    {
                        QL10837();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }

                    if (radioButton12.Checked == true)
                    {
                        QL10550();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }
                    if (radioButton8.Checked == true)
                    {
                        QL10557();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }
                    if (radioButton14.Checked == true)
                    {
                        QL10564();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }
                    if (radioButton9.Checked == true)
                    {
                        QL10487();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }
                    if (radioButton11.Checked == true)
                    {
                        QL10634();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }
                    if (radioButton16.Checked == true)
                    {
                        QL10655();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }
                    if (radioButton10.Checked == true)
                    {
                        QL10494();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }
                    if (radioButton13.Checked == true)
                    {
                        QL10641();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }
                    if (radioButton6.Checked == true)
                    {
                        QL10501();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }
                    if (radioButton7.Checked == true)
                    {
                        QL10669();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }
                    if (radioButton17.Checked == true)
                    {
                        QL10662();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }
                    if (radioButton18.Checked == true)
                    {
                        QL10648();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }
                    if (radioButton19.Checked == true)
                    {
                        QL10508();
                        if (Regex.Matches(textBox5.Text, "成功").Count > 0)
                        {
                            MessageBox.Show("抢到啦!!");
                        }
                        else
                        {
                            MessageBox.Show("糟糕，没有抢到座位！换一组再试试吧!");
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("请先生成Cookie！");
            }

            //task.Start();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                try
                {
                    t1.Abort();
                    t2.Abort();
                    t3.Abort();
                    t4.Abort();
                    t5.Abort();
                    t6.Abort();
                    t7.Abort();
                    t8.Abort();
                    t9.Abort();
                    t10.Abort();
                    t12.Abort();
                    t13.Abort();
                    t11.Abort();
                    t14.Abort();
                    t15.Abort();
                }
                catch
                {
                }
             }
        }
        private void CheckStatus()
        {
            while (Regex.Matches(textBox5.Text, "成功").Count > 0 || Regex.Matches(textBox5.Text, "503").Count > 0) {
                if (checkBox1.Checked == true)
                {
                    try
                    {
                        //t1.Abort();
                        //t2.Abort();
                        //t3.Abort();
                        //t4.Abort();
                        //t5.Abort();
                        //t6.Abort();
                        //t7.Abort();
                        //t8.Abort();
                        //t9.Abort();
                        //t10.Abort();
                        //t12.Abort();
                        //t13.Abort();
                        //t11.Abort();
                        //t14.Abort();
                        //t15.Abort();
                    }
                    catch
                    {
                    }
                }
               // t1.Abort();
            }
            //MessageBox.Show("已抢到。");

        }
    }
}
