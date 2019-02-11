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
    public partial class splash_form : Form

    {
        Myconn conn = new Myconn();
        public splash_form()
        {
            InitializeComponent();
        }

        private void splash_form_Load(object sender, EventArgs e)
        {
            //  //  conn.sqlConnection1.Open();
            timer1.Start();
            this.label1.Text = "Welcome to Vehicle System of Bahria University";
            this.label34.ForeColor = Color.White;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#1, 124, 253");
            metroLabel1.Text = "Loading.....";
            // conn.sqlConnection1.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                metroProgressSpinner1.Value += 5;
            }
            catch
            {

            }
        }
    }
}
