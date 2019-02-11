using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS
{
    class mycontrol
    {
        home h1;

        public mycontrol(home hh1)
        {
            h1 = hh1;
        }

        public void hrm_menu()
        {
            if (h1.panel3.Visible == false)
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
            else
            {
                h1.panel3.Hide();
            }
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

    }
}
