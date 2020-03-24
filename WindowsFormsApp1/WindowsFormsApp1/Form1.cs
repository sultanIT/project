using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    { 
        Class1 a = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            a.name = name.Text;
            a.work = work.Text;
            a.exam = Convert.ToInt32(exam.Text);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              DataGrid1.DataSource = a;
        }
    }
}
