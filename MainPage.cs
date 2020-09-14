using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maths
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Division div = new Division();
            this.Hide();
            div.Show();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            Subtraction sub = new Subtraction();
            this.Hide();
            sub.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Multiplication mul = new Multiplication();
            this.Hide();
            mul.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
    }
}
