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
    public partial class StudentLogin : Form
    {
        Dictionary<string, string> Students = new Dictionary<string, string>();
       

        public StudentLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Students["Lehakoe"] = "TMPass1000";
            Students["Andiswa"] = "TMPass1001";
            Students["Savanna"] = "TMPass1002";
            Students["Kamo"] = "TMPass1003";
            Students["Justin"] = "TMPass1004";
            Students["Neo"] = "TMPass1005";


            Boolean validUsername = false;
            Boolean validPassword = false;
            String user = txtUsername.Text.ToString();

            if (txtUsername.Text.ToString() != "" && txtPassword.Text.ToString() != "")
            {

                if (Students.ContainsKey(user))
                {
                    validUsername = true;
                    String password = txtPassword.Text.ToString();

                    if (Students[user] == password)
                    {
                        validPassword = true;
                        HomePage Home = new HomePage();
                      
                        Home.ShowDialog();
                        this.Visible = false;
                    }
                    else
                    {
                        lblError.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblError.ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("ERROR", "Please insert login details in empty fields");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            StudentRegistration register = new StudentRegistration();
            this.Visible = false;
            register.ShowDialog();
        }
    }
}
