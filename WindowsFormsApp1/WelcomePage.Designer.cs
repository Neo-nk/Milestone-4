
namespace WindowsFormsApp1
{
    partial class WelcomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbStudAdmin = new System.Windows.Forms.GroupBox();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.gbRegLog = new System.Windows.Forms.GroupBox();
            this.radLogin = new System.Windows.Forms.RadioButton();
            this.radRegister = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbStudAdmin.SuspendLayout();
            this.gbRegLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(105)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1300, 900);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 53);
            this.button2.TabIndex = 26;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Tutmate;
            this.pictureBox1.Location = new System.Drawing.Point(3, -672);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1284, 1617);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gbStudAdmin
            // 
            this.gbStudAdmin.Controls.Add(this.radAdmin);
            this.gbStudAdmin.Controls.Add(this.radStudent);
            this.gbStudAdmin.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.gbStudAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbStudAdmin.Location = new System.Drawing.Point(205, 456);
            this.gbStudAdmin.Name = "gbStudAdmin";
            this.gbStudAdmin.Size = new System.Drawing.Size(380, 200);
            this.gbStudAdmin.TabIndex = 27;
            this.gbStudAdmin.TabStop = false;
            this.gbStudAdmin.Text = "User Type:";
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.radAdmin.Location = new System.Drawing.Point(28, 122);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(188, 34);
            this.radAdmin.TabIndex = 31;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "Administrator";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.radStudent.Location = new System.Drawing.Point(28, 57);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(128, 34);
            this.radStudent.TabIndex = 32;
            this.radStudent.TabStop = true;
            this.radStudent.Text = "Student";
            this.radStudent.UseVisualStyleBackColor = true;
            // 
            // gbRegLog
            // 
            this.gbRegLog.Controls.Add(this.radLogin);
            this.gbRegLog.Controls.Add(this.radRegister);
            this.gbRegLog.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.gbRegLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbRegLog.Location = new System.Drawing.Point(739, 467);
            this.gbRegLog.Name = "gbRegLog";
            this.gbRegLog.Size = new System.Drawing.Size(387, 189);
            this.gbRegLog.TabIndex = 28;
            this.gbRegLog.TabStop = false;
            this.gbRegLog.Text = "Register/Login:";
            // 
            // radLogin
            // 
            this.radLogin.AutoSize = true;
            this.radLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.radLogin.Location = new System.Drawing.Point(32, 120);
            this.radLogin.Name = "radLogin";
            this.radLogin.Size = new System.Drawing.Size(103, 34);
            this.radLogin.TabIndex = 29;
            this.radLogin.TabStop = true;
            this.radLogin.Text = "Login";
            this.radLogin.UseVisualStyleBackColor = true;
            // 
            // radRegister
            // 
            this.radRegister.AutoSize = true;
            this.radRegister.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.radRegister.Location = new System.Drawing.Point(32, 56);
            this.radRegister.Name = "radRegister";
            this.radRegister.Size = new System.Drawing.Size(130, 34);
            this.radRegister.TabIndex = 30;
            this.radRegister.TabStop = true;
            this.radRegister.Text = "Register";
            this.radRegister.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(524, 733);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 80);
            this.button1.TabIndex = 29;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(105)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(530, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 55);
            this.label1.TabIndex = 30;
            this.label1.Text = "Welcome!";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Location = new System.Drawing.Point(1233, -2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 58);
            this.btnExit.TabIndex = 87;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbRegLog);
            this.Controls.Add(this.gbStudAdmin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbStudAdmin.ResumeLayout(false);
            this.gbStudAdmin.PerformLayout();
            this.gbRegLog.ResumeLayout(false);
            this.gbRegLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbStudAdmin;
        private System.Windows.Forms.GroupBox gbRegLog;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.RadioButton radStudent;
        private System.Windows.Forms.RadioButton radLogin;
        private System.Windows.Forms.RadioButton radRegister;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}