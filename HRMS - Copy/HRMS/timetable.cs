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
    public partial class timetable : Form
    {
        mycontrol_timetable obj;
        common_control cc = new common_control();
        public timetable()
        {
            InitializeComponent();
        }

        private void timetable_Load(object sender, EventArgs e)
        {
            obj = new mycontrol_timetable(this);
            this.dateTimePicker1.Format = DateTimePickerFormat.Time;
            this.dateTimePicker2.Format = DateTimePickerFormat.Time;
            this.dateTimePicker3.Format = DateTimePickerFormat.Time;
            this.dateTimePicker4.Format = DateTimePickerFormat.Time;
            this.dateTimePicker5.Format = DateTimePickerFormat.Time;
            this.dateTimePicker6.Format = DateTimePickerFormat.Time;
            this.checkBox2.Text = "First Punch In / Last Punch OUT Function";
            this.checkBox3.Text = "Early Out";
            this.checkBox4.Text = "Late Arrival";
            this.label1.Text = "System";
            this.label2.Text = "HRM";
            this.label3.Text = "Attendance";
            this.label4.Text = "Terminal";
            this.label5.Text = "Reports";
            this.label6.Text = "Wide Dimension";
            this.label7.Text = "Check-In Time";
            this.label8.Text = "Check-Out Time";
            this.label9.Text = "Check-Out Start at ";
            this.label10.Text = "Check-Out End at";
            this.label11.Text = "Timetable Name";
            this.label12.Text = "Timetable Type";
            this.label13.Text = "Check-In Start at";
            this.label14.Text = "Check-In End at";
            this.label15.Text = "Calculate as"; 
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
            this.radioButton1.Text = "Present";
            this.radioButton2.Text = "Absent";
            this.button1.Text = "X";
            this.button2.Text = "-";
            this.blueButton2.Text = "Add";
            this.blueButton3.Text = "Save";
            this.blueButton4.Text = "Delete";
            this.blueButton1.Text = "Management";
            this.pictureBox18.BackgroundImage = Properties.Resources.timetableactive_logo;
            obj.attendance_menu();
            if (checkBox1.Checked == false)
            {
                dateTimePicker3.Enabled = false;
                dateTimePicker4.Enabled = false;
                dateTimePicker5.Enabled = false;
                dateTimePicker6.Enabled = false;
                this.numericUpDown1.Enabled = false;
                this.numericUpDown2.Enabled = false;
                this.numericUpDown3.Enabled = false;
                this.checkBox2.Enabled = false;
                this.checkBox3.Enabled = false;
                this.checkBox4.Enabled = false;
            }
            else
            {
                dateTimePicker3.Enabled = true;
                dateTimePicker4.Enabled = true;
                dateTimePicker5.Enabled = true;
                dateTimePicker6.Enabled = true;
                this.numericUpDown1.Enabled = true;
                this.numericUpDown2.Enabled = true;
                this.numericUpDown3.Enabled = true;
                this.checkBox2.Enabled = true;
                this.checkBox3.Enabled = true;
                this.checkBox4.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)   //system menu
        {

        }

        private void label2_Click(object sender, EventArgs e)  //hrm menu
        {
            obj.hrm_menu();
        }

        private void label3_Click(object sender, EventArgs e)   //aattendance menu
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

        private void pictureBox18_Click(object sender, EventArgs e) ///time table menu
        {
            cc.timetable();
            this.Close();
        }

        private void pictureBox15_Click(object sender, EventArgs e) ///employee menu
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

        private void pictureBox22_Click(object sender, EventArgs e) //data sync menu
        {
            cc.datasync();
            this.Close();
        }

        private void pictureBox16_Click(object sender, EventArgs e) //paycode menu
        {
            cc.paycode();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                dateTimePicker3.Enabled = false;
                dateTimePicker4.Enabled = false;
                dateTimePicker5.Enabled = false;
                dateTimePicker6.Enabled = false;
                this.numericUpDown1.Enabled = false;
                this.numericUpDown2.Enabled = false;
                this.numericUpDown3.Enabled = false;
                this.checkBox2.Enabled = false;
                this.checkBox3.Enabled = false;
                this.checkBox4.Enabled = false;
            }
            else
            {
                dateTimePicker3.Enabled = true;
                dateTimePicker4.Enabled = true;
                dateTimePicker5.Enabled = true;
                dateTimePicker6.Enabled = true;
                this.numericUpDown1.Enabled = true;
                this.numericUpDown2.Enabled = true;
                this.numericUpDown3.Enabled = true;
                this.checkBox2.Enabled = true;
                this.checkBox3.Enabled = true;
                this.checkBox4.Enabled = true;
            }
        }


    }
}
