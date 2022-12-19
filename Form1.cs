using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WanaCallSaul
{
    public partial class Form1 : Form
    {
        private string sandboxDir = @"C:\WanacallsaulGoodmanSandbox";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Contains("Status")) return;
            MessageBox.Show("YOU ARE NOT ALLOWED TO DO THAT. YOU ARE NO LONGER ALLOWED TO PAY. YOU FILES ARE NOW PERMANETELY INCREPYETRED.");
            button1.Hide();
            button2.Hide();
            var c = GetAll(this, typeof(Label));
            foreach(Label a in c)
            {
                a.Text = "ITS TOO LATE";
                richTextBox1.Text = "ITS TOO LATE FOR YOUR COMPUTER. YOU SHOULD NOT HAVE DONE THAT.";
                textBox1.Text = "ITS TOO LATE";
            }
            pictureBox2.Hide();
            this.Text = "ITS TOO LATE";

        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Decrypt
            richTextBox1.Text = "You should not have done that..";
            button1.Hide();
            button2.Hide();
            var c = GetAll(this, typeof(Label));
            foreach (Label a in c)
            {
                a.Text = "ITS TOO LATE";
                textBox1.Text = "ITS TOO LATE";
            }
            pictureBox2.Hide();
            this.Text = "ITS TOO LATE";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check
            richTextBox1.Text = "Status: payment found. press decrypt";
        }
    }

}
