using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace HRMS
{
    class mycontrol_employee
    {
        employee h1;
        Myconn conn = new Myconn();
        String imgfilename;

        public mycontrol_employee(employee emp)
        {
            h1 = emp;
        }


        public void hrm_menu()
        {
            h1.panel3.Show();
            h1.pictureBox14.Visible = true;
            h1.pictureBox15.Visible = true;
            h1.pictureBox16.Visible = true;
            h1.pictureBox20.Visible = false;
            h1.pictureBox21.Visible = false;
            h1.pictureBox17.Visible = false;
            h1.pictureBox18.Visible = false;
            h1.pictureBox19.Visible = false;
            h1.pictureBox22.Visible = false;
            h1.pictureBox23.Visible = false;
            h1.pictureBox24.Visible = false;
            h1.pictureBox25.Visible = false;
            h1.pictureBox26.Visible = false;
            h1.pictureBox27.Visible = false;
            h1.label19.Visible = false;
            h1.label20.Visible = false;
            h1.label21.Visible = false;
            h1.label22.Visible = false;
            h1.label23.Visible = false;
            h1.label16.Visible = true;
            h1.label17.Visible = true;
            h1.label18.Visible = true;
            h1.label24.Visible = false;
            h1.label25.Visible = false;
            h1.label26.Visible = false;
            h1.label27.Visible = false;
            h1.label28.Visible = false;
            h1.label29.Visible = false;
        }

        public void attendance_menu()
        {
            if (h1.panel3.Visible == false)
            {
                h1.panel3.Show();
                h1.pictureBox14.Visible = false;
                h1.pictureBox15.Visible = false;
                h1.pictureBox16.Visible = false;
                h1.pictureBox20.Visible = true;
                h1.pictureBox21.Visible = true;
                h1.pictureBox17.Visible = true;
                h1.pictureBox18.Visible = true;
                h1.pictureBox19.Visible = true;
                h1.pictureBox22.Visible = false;
                h1.pictureBox23.Visible = false;
                h1.pictureBox24.Visible = false;
                h1.pictureBox25.Visible = false;
                h1.pictureBox26.Visible = false;
                h1.pictureBox27.Visible = false;
                h1.label19.Visible = true;
                h1.label20.Visible = true;
                h1.label21.Visible = true;
                h1.label22.Visible = true;
                h1.label23.Visible = true;
                h1.label16.Visible = false;
                h1.label17.Visible = false;
                h1.label18.Visible = false;
                h1.label24.Visible = false;
                h1.label25.Visible = false;
                h1.label26.Visible = false;
                h1.label27.Visible = false;
                h1.label28.Visible = false;
                h1.label29.Visible = false;
            }
            else
            {
                h1.panel3.Visible = false;
            }
        }

        public void terminal_menu()
        {
            if (h1.panel3.Visible == false)
            {
                h1.panel3.Show();
                h1.pictureBox14.Visible = false;
                h1.pictureBox15.Visible = false;
                h1.pictureBox16.Visible = false;
                h1.pictureBox20.Visible = false;
                h1.pictureBox21.Visible = false;
                h1.pictureBox17.Visible = false;
                h1.pictureBox18.Visible = false;
                h1.pictureBox19.Visible = false;
                h1.pictureBox22.Visible = true;
                h1.pictureBox23.Visible = true;
                h1.pictureBox24.Visible = true;
                h1.pictureBox25.Visible = false;
                h1.pictureBox26.Visible = false;
                h1.pictureBox27.Visible = false;
                h1.label19.Visible = false;
                h1.label20.Visible = false;
                h1.label21.Visible = false;
                h1.label22.Visible = false;
                h1.label23.Visible = false;
                h1.label16.Visible = false;
                h1.label17.Visible = false;
                h1.label18.Visible = false;
                h1.label24.Visible = true;
                h1.label25.Visible = true;
                h1.label26.Visible = true;
                h1.label27.Visible = false;
                h1.label28.Visible = false;
                h1.label29.Visible = false;

            }
            else
            {
                h1.panel3.Hide();
            }
        }

        public void report_menu()
        {
            if (h1.panel3.Visible == false)
            {
                h1.panel3.Show();
                h1.pictureBox14.Visible = false;
                h1.pictureBox15.Visible = false;
                h1.pictureBox16.Visible = false;
                h1.pictureBox20.Visible = false;
                h1.pictureBox21.Visible = false;
                h1.pictureBox17.Visible = false;
                h1.pictureBox18.Visible = false;
                h1.pictureBox19.Visible = false;
                h1.pictureBox22.Visible = false;
                h1.pictureBox23.Visible = false;
                h1.pictureBox24.Visible = false;
                h1.pictureBox25.Visible = true;
                h1.pictureBox26.Visible = true;
                h1.pictureBox27.Visible = true;
                h1.label19.Visible = false;
                h1.label20.Visible = false;
                h1.label21.Visible = false;
                h1.label22.Visible = false;
                h1.label23.Visible = false;
                h1.label16.Visible = false;
                h1.label17.Visible = false;
                h1.label18.Visible = false;
                h1.label24.Visible = false;
                h1.label25.Visible = false;
                h1.label26.Visible = false;
                h1.label27.Visible = true;
                h1.label28.Visible = true;
                h1.label29.Visible = true;
            }
            else
            {
                h1.panel3.Hide();
            }
        }

        public void browse_image()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; ) | *.jpg; *.jpeg;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                h1.label33.Hide();
                imgfilename = open.FileName;
                h1.pictureBox2.Image = new Bitmap(imgfilename);
            }
        }

        public void remove_image()
        {
            DialogResult dr = MessageBox.Show("Do you want to remove image ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                h1.pictureBox2.Image = null;
                h1.label33.Show();
            }
        }

        public void insert_employee()
        {
            //  //  conn.sqlConnection1.Open();
            try
            {
                Image img = new Bitmap(imgfilename);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Byte[] ImageByteArray = ms.ToArray();
                SqlCommand cmd = new SqlCommand("INSERT INTO employee (fname, lname, department, hiredate, salarymode, terminalzone, empmail, emppass, empcard, image) values (@fname, @lname, @department, @hiredate, @salarymode, @terminalzone, @empmail, @emppass, @empcard, @image)", conn.sqlConnection1);
                cmd.Parameters.AddWithValue("@image", ImageByteArray);
                cmd.Parameters.AddWithValue("@fname", h1.textBox2.Text);
                cmd.Parameters.AddWithValue("@lname", h1.textBox3.Text);
                cmd.Parameters.AddWithValue("@empmail", h1.textBox4.Text);
                cmd.Parameters.AddWithValue("@emppass", h1.textBox5.Text);
                cmd.Parameters.AddWithValue("@empcard", h1.textBox6.Text);
                cmd.Parameters.AddWithValue("@department", h1.comboBox1.Text);
                cmd.Parameters.AddWithValue("@salarymode", h1.comboBox3.Text);
                cmd.Parameters.AddWithValue("@terminalzone", h1.comboBox4.Text);
                cmd.Parameters.AddWithValue("@hiredate", SqlDbType.Date).Value = h1.dateTimePicker1.Value.Date;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Inserted in Data Base", " Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error: " + ae, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // conn.sqlConnection1.Close();
        }

        public void search_employee()
        {
            try
            {
                //  //  conn.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("Select * from employee where empcard ='" + h1.textBox11.Text + "'", conn.sqlConnection1);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                h1.dataGridView1.DataSource = dt;

            }
            catch (Exception ae)
            {
                MessageBox.Show("Error: " + ae, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // conn.sqlConnection1.Close();
        }

        public void empp_id()
        {
            try
            {
                int c = 0;
                //  //  conn.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("Select count(empid) from employee", conn.sqlConnection1);
                SqlDataReader dr= cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = Convert.ToInt32(dr[0]);
                    c++;
                    h1.textBox1.Text = "emp-00" + c.ToString() + "-" + System.DateTime.Today.Year;
                }
                else
                {
                    MessageBox.Show("Error: EMP-ID not created " , " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error: " + ae, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // conn.sqlConnection1.Close();
        }

    }
}
