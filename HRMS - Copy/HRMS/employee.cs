using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace HRMS
{
    public partial class employee : Form
    {
        mycontrol_employee obj;
        Myconn conn = new Myconn();
        common_control cc = new common_control();
        String imgfilename;

        public employee()
        {
            InitializeComponent();
        }

        private void employee_Load(object sender, EventArgs e)
        {
            obj = new mycontrol_employee(this);
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
            this.label11.Text = "Hire Date";
            this.label12.Text = "Salary Mode";
            this.label13.Text = "Terminal Zone";
            this.label14.Text = "Password";
            this.label15.Text = "Email Address";
            this.label30.Text = "Card Number";
            this.label31.Text = "Size(200 * 200)";
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
            this.label33.Text = "No image data";
            this.button1.Text = "X";
            this.button2.Text = "-";
            this.blueButton1.Text = "Save Employee";
            this.blueButton3.Text = "Add Employee";
            this.blueButton4.Text = "Search Employee";
            this.blueButton2.Text = "Search";
            this.textBox5.UseSystemPasswordChar= true;
            this.dataGridView1.Visible = false;
            this.label35.Visible = false;
            this.textBox11.Visible = false;
            this.blueButton2.Visible = false;
            this.pictureBox15.BackgroundImage = Properties.Resources.empactive_logo;
            obj.hrm_menu();
            obj.empp_id();
        }

        private void label1_Click(object sender, EventArgs e)   //system menu
        {
            
        }

        private void label2_Click(object sender, EventArgs e)   //hrm menu
        {
            obj.hrm_menu();
        }

        private void label3_Click(object sender, EventArgs e)   //terminal menu
        {
            obj.terminal_menu();
        }

        private void label4_Click(object sender, EventArgs e)   //attendance menu
        {
            obj.attendance_menu();
        }

        private void label5_Click(object sender, EventArgs e)   //report menu
        {
            obj.report_menu();
        }

        private void pictureBox21_Click(object sender, EventArgs e) //Exception assign
        {
            cc.exception_assign();
            this.Close();
        }

        private void pictureBox26_Click(object sender, EventArgs e) //calculate menu
        {
            cc.calculate();
            this.Close();
        }

        private void pictureBox25_Click(object sender, EventArgs e) //records menu
        {
            cc.record();
            this.Close();
        }

        private void pictureBox22_Click(object sender, EventArgs e) //datasunc menu
        {
            cc.datasync();
            this.Close();
        }

        private void pictureBox23_Click(object sender, EventArgs e) //zone
        {
            cc.zone();
            this.Close();
        }

        private void pictureBox24_Click(object sender, EventArgs e) //device managemnet menu
        {
            cc.device_management();
            this.Close();
        }

        private void pictureBox27_Click(object sender, EventArgs e) //report menu
        {
            cc.report();
            this.Close();
        }

        private void pictureBox20_Click(object sender, EventArgs e) //schedule
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e) //shift menu
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e) //timetable menu
        {
            cc.timetable();
            this.Close();
        }

        private void pictureBox19_Click(object sender, EventArgs e) //rule menu
        {
            cc.rule();
            this.Close();
        }

        private void pictureBox16_Click(object sender, EventArgs e) //paycode menu
        {
            cc.paycode();
            this.Close();
        }

        private void pictureBox15_Click(object sender, EventArgs e) //employee menu
        {
            cc.employe();
            this.Close();
        }

        private void pictureBox14_Click(object sender, EventArgs e) //company menu
        {
            cc.company();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)  //exit
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)  //minimize
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)  //home
        {
            cc.home();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)  //browse image
        {
            obj.browse_image();
        }

        private void button8_Click(object sender, EventArgs e)  //remove image
        {
            obj.remove_image();
        }

        private void button9_Click(object sender, EventArgs e)  //camera
        {
          MessageBox.Show("Camera is not ready","Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }


        private void grayButton1_Click(object sender, EventArgs e)  //add employee
        {
            this.dataGridView1.Visible = false;
            this.groupBox1.Visible = true;
            this.label35.Visible = false;
            this.textBox11.Visible = false;
            this.blueButton2.Visible = false;
            this.blueButton1.Visible = true;
        }

        private void grayButton2_Click(object sender, EventArgs e)  //search employee
        {
            this.dataGridView1.Visible = true;  
            this.groupBox1.Visible = false;
            this.label35.Visible = true;
            this.textBox11.Visible = true;
            this.blueButton2.Visible = true;
            this.blueButton1.Visible = false;
        }

        private void blueButton1_Click(object sender, EventArgs e)  //save employee
        {
            obj.insert_employee();
        }

        private void blueButton3_Click(object sender, EventArgs e)//add employee
        {
            this.dataGridView1.Visible = false;
            this.groupBox1.Visible = true;
            this.label35.Visible = false;
            this.textBox11.Visible = false;
            this.blueButton2.Visible = false;
            this.blueButton1.Visible = true;
        }

        private void blueButton4_Click(object sender, EventArgs e)//search employee
        {
            this.dataGridView1.Visible = true;
            this.groupBox1.Visible = false;
            this.label35.Visible = true;
            this.textBox11.Visible = true;
            this.blueButton2.Visible = true;
            this.blueButton1.Visible = false;
        }

        private void blueButton2_Click(object sender, EventArgs e)  //search employee
        {
            obj.search_employee();
        }



    }
}
