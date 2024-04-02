namespace CRUD
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.registerationtxtBox = new System.Windows.Forms.TextBox();
            this.nametxtBox = new System.Windows.Forms.TextBox();
            this.DepttxtBox = new System.Windows.Forms.TextBox();
            this.sessiontxtBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CGPAtxtBox = new System.Windows.Forms.TextBox();
            this.adresstxtBox = new System.Windows.Forms.TextBox();
            this.showbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registeration Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Session";
            // 
            // registerationtxtBox
            // 
            this.registerationtxtBox.Location = new System.Drawing.Point(135, 54);
            this.registerationtxtBox.Name = "registerationtxtBox";
            this.registerationtxtBox.Size = new System.Drawing.Size(127, 20);
            this.registerationtxtBox.TabIndex = 5;
            // 
            // nametxtBox
            // 
            this.nametxtBox.Location = new System.Drawing.Point(135, 93);
            this.nametxtBox.Name = "nametxtBox";
            this.nametxtBox.Size = new System.Drawing.Size(127, 20);
            this.nametxtBox.TabIndex = 7;
            // 
            // DepttxtBox
            // 
            this.DepttxtBox.Location = new System.Drawing.Point(135, 132);
            this.DepttxtBox.Name = "DepttxtBox";
            this.DepttxtBox.Size = new System.Drawing.Size(127, 20);
            this.DepttxtBox.TabIndex = 8;
            // 
            // sessiontxtBox
            // 
            this.sessiontxtBox.Location = new System.Drawing.Point(135, 171);
            this.sessiontxtBox.Name = "sessiontxtBox";
            this.sessiontxtBox.Size = new System.Drawing.Size(127, 20);
            this.sessiontxtBox.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 159);
            this.dataGridView1.TabIndex = 10;
            // 
            // insertbtn
            // 
            this.insertbtn.Location = new System.Drawing.Point(475, 54);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(75, 23);
            this.insertbtn.TabIndex = 11;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Adress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "CGPA";
            // 
            // CGPAtxtBox
            // 
            this.CGPAtxtBox.Location = new System.Drawing.Point(135, 210);
            this.CGPAtxtBox.Name = "CGPAtxtBox";
            this.CGPAtxtBox.Size = new System.Drawing.Size(127, 20);
            this.CGPAtxtBox.TabIndex = 14;
            // 
            // adresstxtBox
            // 
            this.adresstxtBox.Location = new System.Drawing.Point(135, 253);
            this.adresstxtBox.Name = "adresstxtBox";
            this.adresstxtBox.Size = new System.Drawing.Size(127, 20);
            this.adresstxtBox.TabIndex = 15;
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(475, 251);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(75, 23);
            this.showbtn.TabIndex = 16;
            this.showbtn.Text = "Show";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(475, 207);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 17;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(475, 106);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(75, 23);
            this.editbtn.TabIndex = 18;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(475, 150);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 19;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.adresstxtBox);
            this.Controls.Add(this.CGPAtxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sessiontxtBox);
            this.Controls.Add(this.DepttxtBox);
            this.Controls.Add(this.nametxtBox);
            this.Controls.Add(this.registerationtxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox registerationtxtBox;
        private System.Windows.Forms.TextBox nametxtBox;
        private System.Windows.Forms.TextBox DepttxtBox;
        private System.Windows.Forms.TextBox sessiontxtBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CGPAtxtBox;
        private System.Windows.Forms.TextBox adresstxtBox;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button searchbtn;
    }
}

