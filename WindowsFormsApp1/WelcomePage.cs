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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentRegistration registration = new StudentRegistration();
            this.Visible = false;
            registration.ShowDialog();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StudentLogin login = new StudentLogin();
            this.Visible = false;
            login.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if ((radStudent.Checked==true || radAdmin.Checked==true) && (radRegister.Checked==true || radLogin.Checked == true))
            {
                if (radStudent.Checked && radRegister.Checked)
                {
                    StudentRegistration Sregister = new StudentRegistration();
                    this.Visible = false;
                    Sregister.ShowDialog();
                }
                else if( radStudent.Checked== true && radLogin.Checked == true)
                {
                    StudentLogin login = new StudentLogin();
                    this.Visible = false;
                    login.ShowDialog();
                }
                else if(radAdmin.Checked == true && radRegister.Checked == true)
                {
                    AdminRegistration register = new AdminRegistration();
                    this.Visible = false;
                    register.ShowDialog();
                }
                else if (radAdmin.Checked == true && radLogin.Checked == true)
                {

                }
            }
            else
            {
                MessageBox.Show("ERROR", "Please select a user type and login/register");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
