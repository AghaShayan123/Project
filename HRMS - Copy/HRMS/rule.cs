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
    public partial class rule : Form
    {
        mycontrol_rule obj;
        common_control cc = new common_control();

        public rule()
        {
            InitializeComponent();
        }

        private void rule_Load(object sender, EventArgs e)
        {
            obj = new mycontrol_rule(this);
            this.label1.Text = "System";
            this.label2.Text = "HRM";
            this.label3.Text = "Attendance";
            this.label4.Text = "Terminal";
            this.label5.Text = "Reports";
            this.label6.Text = "Wide Dimension";
            this.label7.Text = "Monday";
            this.label8.Text = "Tuesday";
            this.label9.Text = "Wednesday";
            this.label10.Text = "Thursday";
            this.label11.Text = "Friday";
            this.label12.Text = "Saturday";
            this.label13.Text = "Sunday";
            this.label14.Text = "OT Level1 (H)";
            this.label15.Text = "OT Level2 (H)";
            this.label30.Text = "OT Level3 (H)";
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
            this.checkBox1.Text = "Monday";
            this.checkBox2.Text = "Tuesday";
            this.checkBox3.Text = "Wednesday";
            this.checkBox4.Text = "Thursday";
            this.checkBox5.Text = "Friday";
            this.checkBox6.Text = "Saturday";
            this.checkBox7.Text = "Sunday";
            this.checkBox8.Text = "Weekends work as";
            this.radioButton1.Text = "Work";
            this.radioButton2.Text = "OT Level1";
            this.radioButton3.Text = "OT Level2";
            this.radioButton4.Text = "OT Level3";
            this.button1.Text = "X";
            this.button2.Text = "-";
            this.blueButton1.Text = "Save";
            this.pictureBox19.BackgroundImage = Properties.Resources.rule_logo;
            obj.attendance_menu();
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

        private void label5_Click(object sender, EventArgs e)   //reports menu
        {
            obj.report_menu();
        }


        private void pictureBox25_Click(object sender, EventArgs e) //record menu
        {
            cc.record();
            this.Close();
        }

        private void pictureBox19_Click(object sender, EventArgs e) //rule menu
        {
            cc.rule();
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

        private void pictureBox27_Click(object sender, EventArgs e) //report menu
        {
            cc.report();
            this.Close();
        }

        private void pictureBox17_Click(object sender, EventArgs e) //shift menu
        {
            cc.report();
            this.Close();
        }

        private void pictureBox20_Click(object sender, EventArgs e) //schedule menu
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)  //excepetion assign menu
        {
            cc.exception_assign();
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

        private void pictureBox22_Click(object sender, EventArgs e) //datasync menu
        {
            cc.datasync();
            this.Close();
        }

        private void pictureBox16_Click(object sender, EventArgs e) //paycode menu
        {
            cc.paycode();
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

    }
}
