using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            othersLabel.Visible = false;
            othersBox.Visible = false;
            othersBox.Multiline = true;
        }

        private void others_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string str = " ";

            //Japan
            if (japan.Checked == true)
            {
                str = str + japan.Text;
                str += " ";

            }

            if (philippines.Checked == true)
            {
                str = str + philippines.Text;
                str += " ";

            }

            if (thailand.Checked == true)
            {
                str = str + thailand.Text;
                str += " ";

            }

            if (australlia.Checked == true)
            {
                str = str + australlia.Text;
                str += " ";

            }

            if (others.Checked == true)
            {
                str = str + othersBox.Text;
                str += " ";

            }

            if (str != null)
            {
                MessageBox.Show("You Selected : \n" + str + "\nThank you!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void others_CheckedChanged(object sender, EventArgs e)
        {
            if (others.Checked == false)
            {
                othersLabel.Visible = false;
                othersBox.Visible = false;
            }
            else
            {
                othersLabel.Visible = true;
                othersBox.Visible = true;
            }
        }

        private void othersLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
