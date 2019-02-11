using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class Form1 : Form
    {
        common_control cc = new common_control();

        public Form1()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(6000);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new splash_form());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Wide Dimension";
            this.metroTextBox1.Text = "Username";
            this.metroTextBox2.Text = "Password";
            this.metroTextBox2.UseSystemPasswordChar = true;
            this.blueButton1.Cursor = Cursors.Hand;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            this.metroTextBox1.Text = "";
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            this.metroTextBox2.Text = "";
        }

        private void blueButton1_Click(object sender, EventArgs e)
        {
            if (this.metroTextBox1.Text == "admin" && this.metroTextBox2.Text == "admin")
            {
                cc.home();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
