namespace Lab2_Home
{
    partial class main
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
            this.stbutton = new System.Windows.Forms.Button();
            this.crbutton = new System.Windows.Forms.Button();
            this.attbuttom = new System.Windows.Forms.Button();
            this.Enrolbut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stbutton
            // 
            this.stbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stbutton.Location = new System.Drawing.Point(177, 228);
            this.stbutton.Name = "stbutton";
            this.stbutton.Size = new System.Drawing.Size(325, 23);
            this.stbutton.TabIndex = 1;
            this.stbutton.Text = "Student";
            this.stbutton.UseVisualStyleBackColor = true;
            this.stbutton.Click += new System.EventHandler(this.stbutton_Click);
            // 
            // crbutton
            // 
            this.crbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crbutton.Location = new System.Drawing.Point(177, 286);
            this.crbutton.Name = "crbutton";
            this.crbutton.Size = new System.Drawing.Size(325, 23);
            this.crbutton.TabIndex = 2;
            this.crbutton.Text = "Course";
            this.crbutton.UseVisualStyleBackColor = true;
            this.crbutton.Click += new System.EventHandler(this.crbutton_Click);
            // 
            // attbuttom
            // 
            this.attbuttom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attbuttom.Location = new System.Drawing.Point(177, 403);
            this.attbuttom.Name = "attbuttom";
            this.attbuttom.Size = new System.Drawing.Size(325, 23);
            this.attbuttom.TabIndex = 4;
            this.attbuttom.Text = "Attendance";
            this.attbuttom.UseVisualStyleBackColor = true;
            this.attbuttom.Click += new System.EventHandler(this.attbuttom_Click);
            // 
            // Enrolbut
            // 
            this.Enrolbut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Enrolbut.Location = new System.Drawing.Point(177, 345);
            this.Enrolbut.Name = "Enrolbut";
            this.Enrolbut.Size = new System.Drawing.Size(325, 23);
            this.Enrolbut.TabIndex = 3;
            this.Enrolbut.Text = "Enrollment";
            this.Enrolbut.UseVisualStyleBackColor = true;
            this.Enrolbut.Click += new System.EventHandler(this.Enrolbut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 54;
            this.label5.Text = "Main Menu";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.attbuttom);
            this.Controls.Add(this.Enrolbut);
            this.Controls.Add(this.crbutton);
            this.Controls.Add(this.stbutton);
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stbutton;
        private System.Windows.Forms.Button crbutton;
        private System.Windows.Forms.Button attbuttom;
        private System.Windows.Forms.Button Enrolbut;
        private System.Windows.Forms.Label label5;
    }
}