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
    public partial class Registration : Form
    {
        public Registration()
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
            Dictionary<string, string> Students = new Dictionary<string, string>();
            Students["1234567"] = "TMPass1000";
            Students["7654321"] = "TMPass1001";
            Students["4812162"] = "TMPass1002";
            Students["3691215"] = "TMPass1003";
            Students["2478923"] = "TMPass1004";
            Students["2437872"] = "TMPass1499";

            String user = lblUser_name.Text.ToString();
            String pass = lblPass.Text.ToString();
            String confirmPass = lblConfirmPass.Text.ToString();
            String email = lblEmail.Text.ToString();
            if (user!="" && pass!="" && confirmPass!= "" && email!="")
            {
                if (Students.ContainsKey(user) == false)
                {
                    if (pass == confirmPass)
                    {
                        if (email.Contains("student.wits.ac.za"))
                        {
                            if (ChkTermsConditions.Checked == true)
                            {
                                if (pass.Length < 8 == false)
                                {
                                    Students[user] = pass;
                                    StudentCourses c = new StudentCourses();
                                    this.Visible = false;
                                    c.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("Password should be at least 8 characters", "ERROR");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tick the box indicating that you agree with our terms and conditions to register", "TERMS OF SERVICE");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid email. Please enter a valid student email", "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match.", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Username already registered, please use your student number. If you forgot your password, please contact the administrative office", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Please fill empty fields");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Visible = false;
            log.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
