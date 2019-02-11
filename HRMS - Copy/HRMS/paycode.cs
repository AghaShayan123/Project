using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class paycode : Form
    {
        mycontrol_paycode obj;
        payslip ps = new payslip();
        common_control cc = new common_control();
        Myconn conn = new Myconn();

        public paycode()
        {
             InitializeComponent();
        }

        private void paycode_Load(object sender, EventArgs e)
        {
            obj = new mycontrol_paycode(this);
            ps = new payslip();
            this.label1.Text = "System";
            this.label2.Text = "HRM";
            this.label3.Text = "Attendance";
            this.label4.Text = "Terminal";
            this.label5.Text = "Reports";
            this.label6.Text = "Wide Dimension";
            this.label7.Text = "Emp ID";
            this.label8.Text = "First Name";
            this.label9.Text = "Last Name";
            this.label10.Text = "Department";
            this.label11.Text = "CNIC";
            this.label12.Text = "Present";
            this.label13.Text = "Absent";
            this.label14.Text = "Basic Salary";
            this.label15.Text = "Bonus";
            this.label30.Text = "Increment";
            this.label31.Text = "Decrement";
            this.label16.Text = "Company";
            this.label17.Text = "Employee";
            this.label18.Text = "Paycode";
            this.label19.Text = "Rule";
            this.label20.Text = "Timetable";
            this.label21.Text = "Shift";
            this.label22.Text = "Schedule";
            this.label23.Text = "Exception Assign";
            this.label24.Text = "Device Management";
            this.label25.Text = "Zone";
            this.label26.Text = "Data Sync";
            this.label27.Text = "Records";
            this.label28.Text = "Calculate";
            this.label29.Text = "Report";
            this.label32.Text = "Salary of Month";
            this.button1.Text = "X";
            this.button2.Text = "-";
            this.blueButton1.Text = "Generate Pay Slip";
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.pictureBox16.BackgroundImage = Properties.Resources.paycodeactive_logo;
            obj.hrm_menu();
        }

        private void label1_Click(object sender, EventArgs e)   //system menu
        {

        }

        private void label2_Click(object sender, EventArgs e)   //hrm menu
        {
            obj.hrm_menu();
        }

        private void label3_Click(object sender, EventArgs e)   //attendance menu
        {
            obj.attendance_menu();
        }

        private void label4_Click(object sender, EventArgs e)   //terminal menu
        {
            obj.terminal_menu();
        }

        private void label5_Click(object sender, EventArgs e)   //report menu
        {
            obj.report_menu();
        }

        private void pictureBox19_Click(object sender, EventArgs e) //rule menu
        {
            cc.rule();
            this.Close();
        }

        private void pictureBox25_Click(object sender, EventArgs e) //record menu
        {
            cc.record();
            this.Close();
        }

        private void pictureBox24_Click(object sender, EventArgs e) //device management menu
        {
            cc.device_management();
            this.Close();
        }

        private void pictureBox14_Click(object sender, EventArgs e) //company menu
        {
            cc.company();
            this.Close();
        }

        private void pictureBox26_Click(object sender, EventArgs e) //calculate menu
        {
            cc.calculate();
            this.Close();
        }

        private void pictureBox15_Click(object sender, EventArgs e) //employee menu
        {
            cc.employe();
            this.Close();
        }

        private void pictureBox23_Click(object sender, EventArgs e) //zone menu
        {
            cc.zone();
            this.Close();
        }

        private void pictureBox18_Click(object sender, EventArgs e) //timetable menu
        {
            cc.timetable();
            this.Close();
        }

        private void pictureBox20_Click(object sender, EventArgs e) //schedule menu
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e) //exception assign menu
        {
            cc.exception_assign();
            this.Close();
        }

        private void pictureBox17_Click(object sender, EventArgs e) //shift menu
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e) //paycode menu
        {
            cc.paycode();
            this.Close();
        }

        private void pictureBox27_Click(object sender, EventArgs e) //report menu
        {
            cc.report();
            this.Close();
        }

        private void pictureBox22_Click(object sender, EventArgs e) //datasync menu
        {
            cc.datasync();
            this.Close();
        }

        private void blueButton1_Click(object sender, EventArgs e)  //generate slip
        {
            ps.Show();
            ps.label1.Text = "Emp ID: "+this.comboBox1.Text;
            ps.label2.Text = "First Name: " + this.comboBox2.Text;
            ps.label3.Text = "Last Name: " + this.textBox3.Text;
            ps.label4.Text = "Department: " + this.textBox4.Text;
            ps.label5.Text = "CNIC: " + this.textBox5.Text;
            ps.label6.Text = "Present: " + this.textBox6.Text;
            ps.label7.Text = "Absent: " + this.textBox7.Text;
            ps.label8.Text = "Salary of Month: "+dateTimePicker1.Text;
            ps.label9.Text = "Basic Salary: " + Convert.ToInt32(this.textBox8.Text);
            ps.label10.Text = "Bonus: " + Convert.ToInt32(this.textBox9.Text);
            ps.label11.Text = "Incerement: " + Convert.ToInt32(this.textBox10.Text);
            ps.label12.Text = "Decrement: " + Convert.ToInt32(this.textBox11.Text);
            ps.label13.Text = "Total Salary: " + (Convert.ToInt32(this.textBox8.Text)+Convert.ToInt32(this.textBox9.Text)+Convert.ToInt32(this.textBox10.Text)-Convert.ToInt32(this.textBox11.Text)).ToString();
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back))
            {


            }
            else
            {
                MessageBox.Show("You Can Only Enter A Number!");
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
             char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back))
            {


            }
            else
            {
                MessageBox.Show("You Can Only Enter A Number!");
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
             char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back))
            {


            }
            else
            {
                MessageBox.Show("You Can Only Enter A Number!");
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
             char keypress = e.KeyChar;
             if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back))
             {


             }
             else
             {
                 MessageBox.Show("You Can Only Enter A Number!");
                 e.Handled = true;
             }
        }

        private void button1_Click(object sender, EventArgs e)  //exit
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)  //minized
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)  //home
        {
            cc.home();
            this.Close();
        }

    }
}
