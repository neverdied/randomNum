using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 随机数生成
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Random rd = new Random();
                int num = rd.Next(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                label3.Text = "随机数是：" + num;
            }
            catch (Exception)
            {
                MessageBox.Show("请输入数字");
            }
            
        }
    }
}