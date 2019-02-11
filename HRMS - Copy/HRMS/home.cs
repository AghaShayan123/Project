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
    public partial class home : Form
    {
        mycontrol obj;
        common_control cc = new common_control();

        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            obj = new mycontrol(this);
            this.label1.Text = "Departments";
            this.label2.Text = "Employees";
            this.label3.Text = "Vehicles";
            this.label4.Text = "Transactions";
            this.label5.Text = "Reports";
            this.label6.Text = "Bahria University";
            this.label7.Text = "Company";
            this.label8.Text = "Employee";
            this.label9.Text = "Vehicles";
            this.label10.Text = "Reports";
            this.label11.Text = "Exit";
            this.label12.Text = "Transaction";
            this.label13.Text = "Registartion";
            this.label14.Text = "Registration";
            this.label16.Text = "Company";
            this.label17.Text = "Employee";
            this.label18.Text = "Paycode";
            this.label19.Text = "Rule";
            this.label20.Text = "Reports";
            this.label21.Text = "Shift";
            this.label22.Text = "Schedule";
            this.label23.Text = "Exception Assign";
            this.label24.Text = "Device Management";
            this.label25.Text = "Zone";
            this.label26.Text = "Data Sync";
            this.label27.Text = "Records";
            this.label28.Text = "Calculate";
            this.label29.Text = "Report";
            this.button1.Text = "X";
            this.button2.Text = "-";
            this.button3.Enabled = false;
            this.button3.BackgroundImage = Properties.Resources.disablehome;
            obj.attendance_menu();
        }

        private void button1_Click(object sender, EventArgs e)  //exit button
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)  //minimize button
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void pictureBox1_Click(object sender, EventArgs e)  //company homescreen
        {
            cc.company();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)  //employee homescreen
        {
            cc.employe();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)  //devicemanagement homescreen
        {
            cc.device_management();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)  //schedule homescreen
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)  //shift homescreen
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)  //timetable homescreen
        {
            cc.timetable();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)  //exception assign homescreen
        {
            Application.Exit();
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)  //calculate homescreen
        {
            cc.calculate();
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)  //reports homescreen
        {
            cc.report();
            this.Close();
        }

        private void pictureBox21_Click(object sender, EventArgs e) //Exception Assign menu
        {
            cc.exception_assign();
            this.Close();
        }

        private void pictureBox20_Click(object sender, EventArgs e) //schdule menu
        {

        }

        private void pictureBox27_Click(object sender, EventArgs e) //report menu
        {
            cc.report();
            this.Close();
        }

        private void pictureBox17_Click(object sender, EventArgs e) //shift menu
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e) //Datasync menu
        {
            cc.datasync();
            this.Close();
        }

        private void pictureBox15_Click(object sender, EventArgs e) //employee menu
        {
            cc.employe();
            this.Close();
        }

        private void pictureBox26_Click(object sender, EventArgs e) //calculate menu
        {
            cc.calculate();
            this.Close();
        }

        private void pictureBox23_Click(object sender, EventArgs e) //zone menu
        {
            cc.zone();
            this.Close();
        }

        private void pictureBox19_Click(object sender, EventArgs e) //rule menu
        {
            cc.rule();
            this.Close();
        }

        private void pictureBox25_Click(object sender, EventArgs e) //records
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

        private void pictureBox18_Click(object sender, EventArgs e) //timetable menu
        {
            cc.timetable();
            this.Close();
        }

        private void pictureBox16_Click(object sender, EventArgs e) //payroll menu
        {
            cc.paycode();
            this.Close();
        }






    }
}
