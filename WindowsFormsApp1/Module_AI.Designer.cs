namespace WindowsFormsApp1
{
    partial class Module_AI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Module = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Module
            // 
            this.Module.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Module.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Module.Location = new System.Drawing.Point(0, 216);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(338, 100);
            this.Module.TabIndex = 1;
            this.Module.Text = "(Module name)";
            this.Module.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::WindowsFormsApp1.Properties.Resources.Courses;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(334, 219);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Module_AI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Module);
            this.Controls.Add(this.button2);
            this.Name = "Module_AI";
            this.Size = new System.Drawing.Size(336, 314);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Module;
        private System.Windows.Forms.Button button2;
    }
}
