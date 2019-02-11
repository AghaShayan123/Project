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
    public partial class device_management : Form
    {
        mycontrol_devicemanagement obj;
        common_control cc = new common_control();

        public device_management()
        {
            InitializeComponent();
        }

        private void device_management_Load(object sender, EventArgs e)
        {
            obj = new mycontrol_devicemanagement(this);
            this.label1.Text = "System";
            this.label2.Text = "HRM";
            this.label3.Text = "Attendance";
            this.label4.Text = "Terminal";
            this.label5.Text = "Reports";
            this.label6.Text = "Wide Dimension";
            this.label7.Text = "Terminal Type";
            this.label8.Text = "Status";
            this.label9.Text = "Connection Mode";
            this.label10.Text = "Name";
            this.label11.Text = "IP Address";
            this.label12.Text = "SN";
            this.label13.Text = "Password";
            this.label14.Text = "Record Setting";
            this.label15.Text = "Terminal Number";
            this.label30.Text = "Port";
            this.label31.Text = "Terminal Zone";
            this.label32.Text = "Terminal Type";
            this.label33.Text = "Algorithm Version";
            this.label34.Text = "Admins";
            this.label35.Text = "FP Quantity";
            this.label36.Text = "Records";
            this.label37.Text = "Date Fromat";
            this.label38.Text = "Coreboard Type";
            this.label39.Text = "Users";
            this.label40.Text = "Face Quantity";
            this.label41.Text = "Palm Quantity";
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
            this.radioButton1.Text = "Disable";
            this.radioButton2.Text = "Enable";
            this.radioButton3.Text = "USB";
            this.radioButton4.Text = "TCP / IP";
            this.radioButton5.Text = "P2P";
            this.radioButton6.Text = "Reset";
            this.radioButton7.Text = "Merge";
            this.button1.Text = "X";
            this.button2.Text = "-";
            this.button4.Text = "Add";
            this.button5.Text = "Save";
            this.button6.Text = "Delete";
            this.button7.Text = "Search";
            this.button8.Text = "Download Records";
            this.blueButton1.Text = "Test Connection";
            this.pictureBox24.BackgroundImage = Properties.Resources.devicemanagement_logo;
            obj.terminal_menu();
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

        private void label1_Click(object sender, EventArgs e)
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

        private void pictureBox27_Click(object sender, EventArgs e) //report menu
        {
            cc.report();
            this.Close();
        }

        private void pictureBox17_Click(object sender, EventArgs e) //shift menu
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e) //schedule menu
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e) //exception assign menu
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

        private void pictureBox18_Click(object sender, EventArgs e) //timetable menu
        {
            cc.timetable();
            this.Close();
        }

        private void pictureBox16_Click(object sender, EventArgs e) //paycode menu
        {
            cc.paycode();
            this.Close();
        }
    }
}
