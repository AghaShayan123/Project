using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS
{
    class common_control
    {

        public void home()
        {
            home hm = new home();
            hm.Show();
        }

        public void company()
        {
            company cmp = new company();
            cmp.Show();
        }

        public void employe()
        {
            employee emp = new employee();
            emp.Show();
        }

        public void paycode()
        {
            paycode pc = new paycode();
            pc.Show();
        }

        public void rule()
        {
            rule r = new rule();
            r.Show();
        }

        public void timetable()
        {
            timetable tt = new timetable();
            tt.Show();
        }

        public void exception_assign()
        {

        }

        public void device_management()
        {
            device_management dm = new device_management();
            dm.Show();
        }

        public void zone()
        {
            zone z = new zone();
            z.Show();
        }

        public void datasync()
        {
            datasync ds = new datasync();
            ds.Show();
        }

        public void record()
        {
            records r = new records();
            r.Show();
        }

        public void calculate()
        {
            calculate c = new calculate();
            c.Show();
        }

        public void report()
        {
            
        }
    }
}
