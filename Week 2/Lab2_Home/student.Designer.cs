namespace Lab2_Home
{
    partial class student
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
            this.label1 = new System.Windows.Forms.Label();
            this.RegSt = new System.Windows.Forms.TextBox();
            this.NameSt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddSt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DepSt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SessionSt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StAdd = new System.Windows.Forms.Button();
            this.stdel = new System.Windows.Forms.Button();
            this.stshow = new System.Windows.Forms.Button();
            this.stupdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Number";
            // 
            // RegSt
            // 
            this.RegSt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegSt.Location = new System.Drawing.Point(164, 86);
            this.RegSt.Name = "RegSt";
            this.RegSt.Size = new System.Drawing.Size(183, 20);
            this.RegSt.TabIndex = 1;
            // 
            // NameSt
            // 
            this.NameSt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameSt.Location = new System.Drawing.Point(164, 118);
            this.NameSt.Name = "NameSt";
            this.NameSt.Size = new System.Drawing.Size(183, 20);
            this.NameSt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // AddSt
            // 
            this.AddSt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSt.Location = new System.Drawing.Point(164, 173);
            this.AddSt.Name = "AddSt";
            this.AddSt.Size = new System.Drawing.Size(183, 20);
            this.AddSt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Address";
            // 
            // DepSt
            // 
            this.DepSt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepSt.Location = new System.Drawing.Point(164, 147);
            this.DepSt.Name = "DepSt";
            this.DepSt.Size = new System.Drawing.Size(183, 20);
            this.DepSt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Department";
            // 
            // SessionSt
            // 
            this.SessionSt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SessionSt.Location = new System.Drawing.Point(164, 200);
            this.SessionSt.Name = "SessionSt";
            this.SessionSt.Size = new System.Drawing.Size(183, 20);
            this.SessionSt.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Session";
            // 
            // StAdd
            // 
            this.StAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.StAdd.Location = new System.Drawing.Point(531, 114);
            this.StAdd.Name = "StAdd";
            this.StAdd.Size = new System.Drawing.Size(106, 23);
            this.StAdd.TabIndex = 15;
            this.StAdd.Text = "Add";
            this.StAdd.UseVisualStyleBackColor = true;
            this.StAdd.Click += new System.EventHandler(this.StAdd_Click);
            // 
            // stdel
            // 
            this.stdel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.stdel.Location = new System.Drawing.Point(531, 198);
            this.stdel.Name = "stdel";
            this.stdel.Size = new System.Drawing.Size(106, 23);
            this.stdel.TabIndex = 16;
            this.stdel.Text = "Del";
            this.stdel.UseVisualStyleBackColor = true;
            this.stdel.Click += new System.EventHandler(this.stdel_Click);
            // 
            // stshow
            // 
            this.stshow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.stshow.Location = new System.Drawing.Point(542, 472);
            this.stshow.Name = "stshow";
            this.stshow.Size = new System.Drawing.Size(101, 23);
            this.stshow.TabIndex = 17;
            this.stshow.Text = "Show";
            this.stshow.UseVisualStyleBackColor = true;
            this.stshow.Click += new System.EventHandler(this.stshow_Click);
            // 
            // stupdate
            // 
            this.stupdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.stupdate.Location = new System.Drawing.Point(531, 155);
            this.stupdate.Name = "stupdate";
            this.stupdate.Size = new System.Drawing.Size(106, 23);
            this.stupdate.TabIndex = 18;
            this.stupdate.Text = "Update";
            this.stupdate.UseVisualStyleBackColor = true;
            this.stupdate.Click += new System.EventHandler(this.stupdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 232);
            this.dataGridView1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Student";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(12, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.stupdate);
            this.Controls.Add(this.stshow);
            this.Controls.Add(this.stdel);
            this.Controls.Add(this.StAdd);
            this.Controls.Add(this.SessionSt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddSt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepSt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameSt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegSt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab2_Home";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegSt;
        private System.Windows.Forms.TextBox NameSt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddSt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DepSt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SessionSt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button StAdd;
        private System.Windows.Forms.Button stdel;
        private System.Windows.Forms.Button stshow;
        private System.Windows.Forms.Button stupdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

