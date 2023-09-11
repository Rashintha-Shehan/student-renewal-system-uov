using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renewacademic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
           
            textBox6.Text += "----------------------------------------------------------------------------------\n";
            textBox6.Text += "                       Registering for New Academic Year\n";
            textBox6.Text += "----------------------------------------------------------------------------------\n";
            textBox6.Text += "Date :"+ DateTime.Now+"\n\n";
            
            textBox6.Text += "Student Name : " + textBox1.Text+"\n\n";
            textBox6.Text += "Enrollment No : " + comboBox3.Text +comboBox4.Text+textBox2.Text+ "\n\n";
            textBox6.Text += "Renewal Academic year : " + comboBox2.Text + "\n\n";
            textBox6.Text += "Mobile number : " + textBox4.Text + "\n\n";
            textBox6.Text += "fees : " + textBox5.Text + "\n\n";

            textBox6.Text += "Faculty : " + comboBox1.Text + "\n\n";
            textBox6.Text += "වව්නියා    විශ්වවිද්‍යා  ලය, ශ්‍රී ලංකා  ව\n";
           
            textBox6.Text += "University of vavuniya,Srilanka\n";

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text += textBox1.Text = "";
            textBox6.Text += comboBox3.Text = "";
            textBox6.Text += textBox2.Text = "";
            textBox6.Text += comboBox4.Text = "";
            textBox6.Text += comboBox2.Text = "";
            textBox6.Text += textBox4.Text = "";
            textBox6.Text += textBox5.Text = "";
            textBox6.Text += comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox6.Text, new Font("Arial", 18, FontStyle.Bold),Brushes.Black,new Point(10,10)) ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
