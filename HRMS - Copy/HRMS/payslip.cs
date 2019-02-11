using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace HRMS
{
    public partial class payslip : Form
    {
        Myconn conn = new Myconn();

        public payslip()
        {
            InitializeComponent();
        }

        private void payslip_Load(object sender, EventArgs e)
        {
            this.blueButton1.Text = "Print Pay Slip";
            this.blueButton2.Text = "Save Pay Slip";
            this.button1.Text = "X";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void blueButton1_Click(object sender, EventArgs e)  //printer
        {
            MessageBox.Show("Printer is not connected");
        }

        private void blueButton2_Click(object sender, EventArgs e)
        {
            try
            {
                //  //  conn.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("insert into paycode (empid, firstname, lastname, cnic, present, absent, salarymonth, basicsalary, bonus, increment, decrement, total) values (@empid, @firstname, @lastname, @cnic, @present, @absent, @salarymonth, @basicsalary, @bonus, @increment, @decrement, @total)", conn.sqlConnection1);
                cmd.Parameters.AddWithValue("@empid",this.label1.Text);
                cmd.Parameters.AddWithValue("@firstname",this.label2.Text);
                cmd.Parameters.AddWithValue("@lastname",this.label3.Text);
                cmd.Parameters.AddWithValue("@cnic",this.label5.Text);
                cmd.Parameters.AddWithValue("@present",this.label6.Text);
                cmd.Parameters.AddWithValue("@absent",this.label7.Text);
                cmd.Parameters.AddWithValue("@salarymonth", this.label8.Text);
                cmd.Parameters.AddWithValue("@basicsalary",this.label9.Text);
                cmd.Parameters.AddWithValue("@bonus",this.label10.Text);
                cmd.Parameters.AddWithValue("@increment",this.label11.Text);
                cmd.Parameters.AddWithValue("@decrement",this.label12.Text);
                cmd.Parameters.AddWithValue("@total",this.label13.Text);
                cmd.Parameters.AddWithValue("@department",this.label4.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salary has been inserted");
            }
            catch(Exception ae)
            {
                MessageBox.Show("Error: " + ae, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // conn.sqlConnection1.Close();
        }
    }
}
