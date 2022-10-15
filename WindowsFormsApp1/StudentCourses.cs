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
    public partial class StudentCourses : Form
    {

        
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
            

                if (selectedCourses[0] != selectedCourses[1])
                {
                    HomePage home = new HomePage();
                    home.ShowDialog();
                    home.course1= selectedCourses[0];
                    home.course2 = selectedCourses[1];
                this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please select two different modules", "ERROR");
                }
            
           
            
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
            /*string temp = lblModule2.Text.ToString();
            if (temp != "*N/A")
            {
                selectedCourses.Remove(temp);
                lblModule1.Text = "*N/A";

                string module;
                if (selectedCourses.Count == 2)
                {
                    module= selectedCourses[1];

                }
                else
                {
                    module= selectedCourses[0];
                }
                switch (selectedCourses[1])
                {
                    case "INFO2001A":
                        INFO2001Aselect = false;
                        btnINFO2001A.Text = "Select";
                        btnINFO2001A.BackColor = Color.White;
                        break;

                    case "BIO2002A":
                        BIO2002Aselect = false;
                        btnBIO2002A.Text = "Select";
                        btnBIO2002A.BackColor = Color.White;
                        break;

                    case "PSYCH2003":
                        PSYCH2003select = false;
                        btnPSYCH2003.Text = "Select";
                        btnPSYCH2003.BackColor = Color.White;
                        break;
                    case "HIS201A":
                        HIS201Aselect = false;
                        btnHIS201A.Text = "Select";
                        btnHIS201A.BackColor = Color.White;
                        break;

                }
            }*/
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        Boolean BIO2002Aselect=false;
        private void btnBIO2002A_Click(object sender, EventArgs e)
        {
            if (BIO2002Aselect == false)
            {
                string mod = "BIO2002A";
                Button b = btnBIO2002A;
               
                if (lblModule1.Text == "*N/A")
                {
                    lblModule1.Text = mod;
                    selectedCourses[1]=(mod);
                    b.Text = "selected";
                    b.BackColor = Color.LightSkyBlue;
                    BIO2002Aselect = true;
                }
                else
                {
                    lblModule2.Text = mod;
                    selectedCourses.Append(mod);
                    b.Text = "selected";
                    b.BackColor = Color.LightSkyBlue;
                    BIO2002Aselect = true;
                }
                

            }
            else if (BIO2002Aselect == true)
            {
                MessageBox.Show("Module already selected");
            }
        }

        Boolean PSYCH2003select = false;
        private void btnPSYCH2003_Click(object sender, EventArgs e)
        {
            if (PSYCH2003select == false)
            {
                string mod = "PSYCH2003";
                Button b = btnPSYCH2003;

                if (lblModule1.Text == "*N/A")
                {
                    lblModule1.Text = mod;
                    b.Text = "selected";
                    b.BackColor = Color.LightSkyBlue;
                    PSYCH2003select = true;
                }
                else
                {
                    lblModule2.Text = mod;
                    selectedCourses.Append(mod);
                    b.Text = "selected";
                    b.BackColor = Color.LightSkyBlue;
                    PSYCH2003select = true;
                }


            }
            else if (PSYCH2003select == true)
            {
                MessageBox.Show("Module already selected");
            }
        }

        Boolean HIS201Aselect = false;
        private void btnHIS201A_Click(object sender, EventArgs e)
        {
           /* if (HIS201Aselect == false && selectedCourses.Count < 2)
            {
                string mod = "HIS201A";
                Button b = btnHIS201A;

                if (lblModule1.Text == "*N/A")
                {
                    lblModule1.Text = mod;
                    selectedCourses.Insert(mod);
                    b.Text = "selected";
                    b.BackColor = Color.LightSkyBlue;
                    HIS201Aselect = true;
                }
                else
                {
                    lblModule2.Text = mod;
                    selectedCourses.Append(mod);
                    b.Text = "selected";
                    b.BackColor = Color.LightSkyBlue;
                    HIS201Aselect = true;
                }


            }
            else if (HIS201Aselect == true)
            {
                MessageBox.Show("Module already selected");
            }*/
        }
    }
}
