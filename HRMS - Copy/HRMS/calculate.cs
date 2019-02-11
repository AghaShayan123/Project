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
    public partial class calculate : Form
    {
        mycontrol_calculate obj;
        common_control cc= new common_control();

        public calculate()
        {
            InitializeComponent();
        }

        private void calculate_Load(object sender, EventArgs e)
        {
            obj = new mycontrol_calculate(this);
            this.label1.Text = "System";
            this.label2.Text = "HRM";
            this.label3.Text = "Attendance";
            this.label4.Text = "Terminal";
            this.label5.Text = "Reports";
            this.label6.Text = "Wide Dimension";
            this.label7.Text = "From";
            this.label8.Text = "To";
           /* this.label9.Text = "Search by ID or Name ";
                        this.label10.Text = "Timetable";
                        this.label11.Text = "Shift";
                        this.label12.Text = "Schedule";
                        this.label13.Text = "Exception Assign";
                        this.label14.Text = "Calcultae";
                        this.label15.Text = "Reports"; */
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
            this.button1.Text = "X";
            this.button2.Text = "-";
            this.button4.Text = "Calculate";
            this.button5.Text = "View Result";
            this.button6.Text = "Modify Record";
            this.button7.Text = "Export";
            this.pictureBox26.BackgroundImage = Properties.Resources.calculateactive_logo;
            obj.report_menu();
        }

        private void button1_Click(object sender, EventArgs e)  //exit
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cc.home();
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

    }
}
