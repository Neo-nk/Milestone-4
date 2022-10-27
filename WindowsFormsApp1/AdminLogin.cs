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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class AdminLogin : Form
    {

        //database connection initialization;
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            AdminRegistration register = new AdminRegistration();
            this.Visible = false;
            register.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String AdminID = txtAdminID.Text;
            String password = txtPassword.Text;

            if (AdminID == "" || password == "")
            {
                MessageBox.Show("Please fill in all empty fields", "ERROR");
            }
            else
            {
                con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\neonkosi\source\repos\Milestone-4\TutMate.accdb");
                con.Open();
                cmd = new OleDbCommand("select * from Administrator where [Admin_ID]=" + AdminID 
                    + "and [password]=" +password, con);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Login successful");
                    Admin
                }
                else
                {
                    MessageBox.Show("Invalid login details, please try again", "LOGIN ERROR");
                }
            }


        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
