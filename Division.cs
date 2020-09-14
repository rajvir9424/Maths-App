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
    public partial class Division : Form
    {
        public static double total;
        public static  float answer;
        public static int score;

        public Division()
        {
            InitializeComponent();
        }

        private void Division_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            label1.Text = rnd.Next(0, 100).ToString();

            label2.Text = rnd.Next(0, 100).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            total = double.Parse(label1.Text) / double.Parse(label2.Text);
            answer = float.Parse(textBox2.Text);

            if (answer == total)
            {
                MessageBox.Show("Correct ");
                score++;

                label1.Text = "";
                label2.Text = "";
                textBox2.Clear();
                Random rnd = new Random();

                label1.Text = rnd.Next(0, 100).ToString();
                label2.Text = rnd.Next(0, 100).ToString();

            }
            else
            {
                MessageBox.Show("Incorrect" + "" + "Correct answer is " + "" + total);
                label1.Text = "";
                label2.Text = "";
                textBox2.Clear();

                Random rnd = new Random();

                label1.Text = rnd.Next(0, 100).ToString();
                label2.Text = rnd.Next(0, 100).ToString();
            }
            label3.Text = "Score= " + score;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have finished and your score = " + score);
            Application.Exit();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show ();
        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
