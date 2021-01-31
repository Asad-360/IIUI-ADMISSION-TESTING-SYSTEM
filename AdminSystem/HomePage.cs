

using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

namespace AdminSystem
{

    public partial class HomePage : Form
    {



        public static Panel _Dashboard;
        public static Panel Instance
        {
            get
            {
                if (_Dashboard == null)
                    _Dashboard = new Panel();
                return _Dashboard;
            }
        }

        public HomePage()
        {
            InitializeComponent();

          
        }

        private void bunifuFlatButton2_Click(object sender, System.EventArgs e)
        {
            if (!panel3.Controls.Contains(StudentRegistration.Instance))
            {
                panel3.Controls.Add(StudentRegistration.Instance);
                StudentRegistration.Instance.Dock = DockStyle.Fill;
                StudentRegistration.Instance.BringToFront();
            }
            StudentRegistration.Instance.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, System.EventArgs e)
        {
            if (!panel3.Controls.Contains(CourseRegistration.Instance))
            {
                panel3.Controls.Add(CourseRegistration.Instance);
                CourseRegistration.Instance.Dock = DockStyle.Fill;
                CourseRegistration.Instance.BringToFront();
            }
            CourseRegistration.Instance.BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, System.EventArgs e)
        {
            if (!panel3.Controls.Contains(PaperPool.Instance))
            {
                panel3.Controls.Add(PaperPool.Instance);
                PaperPool.Instance.Dock = DockStyle.Fill;
                PaperPool.Instance.BringToFront();
            }
            PaperPool.Instance.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, System.EventArgs e)
        {
            if (!panel3.Controls.Contains(Dashboard.Instance))
            {
                panel3.Controls.Add(Dashboard.Instance);
                Dashboard.Instance.Dock = DockStyle.Fill;
                Dashboard.Instance.BringToFront();
            }
            Dashboard.Instance.BringToFront();

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
