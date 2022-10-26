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
    public partial class addAcademic : Form
    {
        public addAcademic()
        {
            InitializeComponent();
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Academics_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Main_Menu NewMain_Menu = new Main_Menu();
            this.Visible = false;
            NewMain_Menu.ShowDialog();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtCode.Text = "";
            txtFirstName.Focus();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            messages Newmessages = new messages();
            this.Visible = false;
            Newmessages.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_Menu NewMain_Menu = new Main_Menu();
            this.Visible = false;
            NewMain_Menu.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAcademc_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDropdown1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
