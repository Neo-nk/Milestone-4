using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAcademics_Click(object sender, EventArgs e)
        {
            addAcademic NewAcademics = new addAcademic();
            this.Visible = false;
            NewAcademics.ShowDialog();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Feedback NewFeedback = new Feedback();
            this.Visible = false;
            NewFeedback.ShowDialog();
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            StudentHomePage home = new StudentHomePage();
            this.Visible = false;
            home.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            StudentHomePage home = new StudentHomePage();
            this.Visible = false;
            home.ShowDialog();
        }

        private void btnStudentPage_Click(object sender, EventArgs e)
        {

        }
    }
}
