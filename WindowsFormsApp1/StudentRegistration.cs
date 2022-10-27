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

namespace WindowsFormsApp1
{
    public partial class StudentRegistration : Form
    {
        //database connection initialization;
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblStudMail_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           

            String fName = lblFirstName.Text.ToString();
            String surname = lblLastName.Text.ToString();
            String pass = lblPass.Text.ToString();
            String confirmPass = lblConfirmPass.Text.ToString();
            String email = lblEmail.Text.ToString();
            String studentNo = txtStudentNumber.Text;

            // more readable validation steps :)

            if (fName == "" || pass == "" || confirmPass == "" || email == "" || surname == "" || studentNo == "")
            {
                MessageBox.Show("Please fill in all empty fields", "ERROR");
            }

            else if (pass != confirmPass)
            {
                MessageBox.Show("Passwords do not match.", "ERROR");
            }

            else if (email.Contains("@students.wits.ac.za") == false)
            {
                MessageBox.Show("Invalid email. Please enter a valid student email", "ERROR");
            }

            else if (ChkTermsConditions.Checked == false)
            {
                MessageBox.Show("Tick the box indicating that you agree with our terms and conditions to register", "TERMS OF SERVICE");
            }

            else if (txtStudentNumber.Text == "")
            {
                MessageBox.Show("Tick the box indicating that you agree with our terms and conditions to register", "TERMS OF SERVICE");
            }

            else if (pass.Length < 8 == true)
            {
                MessageBox.Show("Password should be at least 8 characters", "ERROR");
            }


            else // all form-related validation is passed if this code runs
            { 
                con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\neonkosi\source\repos\Milestone-4\TutMate.accdb");
                con.Open();
                bool inDB = false;
                cmd = new OleDbCommand("select * from Student where StudentNo=" +studentNo, con);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Student number already registered");
                }
                else
                {
                    cmd = new OleDbCommand("insert into Student([StudentNo], [FName], [Surname], [Password], [StudentEmail]) " +
                        "values ('"+ studentNo +"','" + fName + "','" + surname + "', '"+ pass + "', '" +email + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    StudentCourses courses = new StudentCourses();

                    courses.studentNo = this.txtStudentNumber.Text;
                    //this is how we pass data from one form to another
                    //super important for ensuring student is always accessing their content
                    //no alternatives here, ask for explanation and I'll happily explain

                    this.Visible = false;
                    courses.ShowDialog();
                    
                }

            }
        }

            private void label9_Click(object sender, EventArgs e)
        {
            StudentLogin log = new StudentLogin();
            this.Visible = false;
            log.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
