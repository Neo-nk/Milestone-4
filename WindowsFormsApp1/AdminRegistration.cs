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
    public partial class AdminRegistration : Form
    {
        public AdminRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> Admins = new Dictionary<string, string>();
            Admins["1234567"] = "TMPass1000";
            Admins["7654321"] = "TMPass1001";
            Admins["4812162"] = "TMPass1002";
            Admins["3691215"] = "TMPass1003";
            Admins["2478923"] = "TMPass1004";
            Admins["2437872"] = "TMPass1499";

            String name = lblFirstName.Text.ToString();
            String surname = lblLastName.Text.ToString();
            String pass = lblPass.Text.ToString();
            String confirmPass = lblConfirmPass.Text.ToString();
            String email = lblEmail.Text.ToString();

            if (name!="" && pass!="" && confirmPass!= "" && email!="" && surname!="")
            {
                if (Admins.ContainsKey(name) == false)
                {
                    if (pass == confirmPass)
                    {
                        if (email.Contains("@students.wits.ac.za"))
                        {
                            if (ChkTermsConditions.Checked == true)
                            {
                                if (pass.Length < 8 == false)
                                {
                                    Admins[name] = pass;
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

        }
    }
}
