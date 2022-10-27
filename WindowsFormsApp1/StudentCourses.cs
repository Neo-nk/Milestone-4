using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class StudentCourses : Form
    {

        public string studentNo { get; set; }

        //database connection initialization;
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public StudentCourses()
        {
            InitializeComponent();
            
        }

        string[] selectedCourses = new string[2];
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void courses_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnContinue_Click(object sender, EventArgs e)
        { 
            //Student was added to database in registration but course attributes were left empty
            //we will now update the student record with their chosen courses

            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\neonkosi\source\repos\Milestone-4\TutMate.accdb");
            con.Open();
            cmd = new OleDbCommand("Update Student set [Module1]='INFO2001A', [Module2]='PSYCH2003' where [StudentNo]="+studentNo, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //moving to homepage
            StudentHomePage home = new StudentHomePage();
            this.Visible = false;
            home.ShowDialog(); 


        }

        Boolean INFO2001Aselect = false;
        private void btnSelected_Click(object sender, EventArgs e)
        {
                lblModule1.Text = "INFO2001A";
                selectedCourses[0]=("INFO2001A");
                btnINFO2001A.Text = "selected";
                btnINFO2001A.BackColor = Color.LightSkyBlue;
                INFO2001Aselect = true;
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        Boolean BIO2002Aselect=false;
        private void btnBIO2002A_Click(object sender, EventArgs e)
        {
            //we not clicking this in the demonstration:)
        }

        Boolean PSYCH2003select = false;
        private void btnPSYCH2003_Click(object sender, EventArgs e)
        {
            lblModule2.Text = "PSYCH2003";
            btnPSYCH2003.Text = "selected";
            btnPSYCH2003.BackColor = Color.LightSkyBlue;
            INFO2001Aselect = true;
        }

        Boolean HIS201Aselect = false;
        private void btnHIS201A_Click(object sender, EventArgs e)
        {
            //we not clicking this in the demonstration :)
        }
    }
}
