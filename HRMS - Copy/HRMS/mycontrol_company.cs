using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Data;

namespace HRMS
{
    class mycontrol_company
    {
        Myconn conn = new Myconn();
        company h1;
        String imgfilename;

        public mycontrol_company(company cmp1)
        {
            h1 = cmp1;
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
                h1.pictureBox1.Image = new Bitmap(imgfilename);
            }
        }

        public void insert_company()
        {
            //  //  conn.sqlConnection1.Open();
            try
            {
                Image img = new Bitmap(imgfilename);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Byte[] ImageByteArray = ms.ToArray();
                SqlCommand cmd = new SqlCommand("INSERT INTO company (cname, ccity, ccountry, cfax, cemail, cstate, cphone, cweb, cpostal, caddress1, caddress2, cimage) values (@cname, @ccity, @ccountry, @cfax, @cemail, @cstate, @cphone, @cweb, @cpostal, @caddress1, @caddress2, @cimage)", conn.sqlConnection1);
                cmd.Parameters.AddWithValue("@cimage",ImageByteArray);
                cmd.Parameters.AddWithValue("@cname", h1.textBox1.Text);
                cmd.Parameters.AddWithValue("@ccountry", h1.comboBox1.Text);
                cmd.Parameters.AddWithValue("@ccity", h1.textBox2.Text);
                cmd.Parameters.AddWithValue("@cfax", h1.textBox3.Text);
                cmd.Parameters.AddWithValue("@cemail", h1.textBox4.Text);
                cmd.Parameters.AddWithValue("@cstate", h1.textBox5.Text);
                cmd.Parameters.AddWithValue("@cphone", h1.textBox6.Text);
                cmd.Parameters.AddWithValue("@cweb", h1.textBox7.Text);
                cmd.Parameters.AddWithValue("@cpostal", h1.textBox8.Text);
                cmd.Parameters.AddWithValue("@caddress1", h1.textBox9.Text);
                cmd.Parameters.AddWithValue("@caddress2", h1.textBox10.Text);      
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company Inserted in Data Base", " Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error: " + ae, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // conn.sqlConnection1.Close();
        }

        public void remove_image()
        {
            DialogResult dr = MessageBox.Show("Do you want to remove image ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                h1.pictureBox1.Image = null;
                h1.label33.Show();
            }
        }

        public void country_combo()
        {
//            //  //  conn.sqlConnection1.Open();
            //SqlCommand cmd = new SqlCommand("SELECT countryname from country", conn.sqlConnection1);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
              //  h1.comboBox1.Items.Add(dr["countryname"]);
            //}

  //          // conn.sqlConnection1.Close();
        }

        public void search_company()
        {
            try
            {
    //            //  //  conn.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("Select * from company where cname ='" + h1.textBox11.Text + "'", conn.sqlConnection1);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                h1.dataGridView1.DataSource = dt;

            }
            catch (Exception ae)
            {
                MessageBox.Show("Error: " + ae, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      //      // conn.sqlConnection1.Close();
        }



    }
}
