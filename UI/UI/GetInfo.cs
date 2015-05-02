using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using ENTITY;
namespace UI
{
    public partial class GetInfo : Form
    {
        Student[] s = new Student[4];
        int i = 0;
        public GetInfo()
        {
            InitializeComponent();
        }

        private void GetInfo_Load(object sender, EventArgs e)
        {

        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.setstudentinfo(s);
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            s[i] = new Student();
            if (i < 4)
            {
                label5.Text = "Information of student " + (i + 2) + ":";
                s[i].name = textBox1.Text;
                s[i].roll = textBox2.Text;
                s[i].disipline = textBox3.Text;
                s[i].gpa = textBox4.Text;
                i++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }
            if(i==4)
            {
                label5.Text = "Next page-";
            }

                
        }
    }
}
