namespace Lab2_Home
{
    partial class attendance
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
            this.backbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.showbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.Nametxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RegNotxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backbtn.Location = new System.Drawing.Point(55, 463);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(101, 23);
            this.backbtn.TabIndex = 54;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "Student";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 232);
            this.dataGridView1.TabIndex = 52;
            // 
            // Updatebtn
            // 
            this.Updatebtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Updatebtn.Location = new System.Drawing.Point(546, 146);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(106, 23);
            this.Updatebtn.TabIndex = 51;
            this.Updatebtn.Text = "Mark";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // showbtn
            // 
            this.showbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.showbtn.Location = new System.Drawing.Point(557, 463);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(101, 23);
            this.showbtn.TabIndex = 50;
            this.showbtn.Text = "Show";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.delbtn.Location = new System.Drawing.Point(546, 189);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(106, 23);
            this.delbtn.TabIndex = 49;
            this.delbtn.Text = "Edit";
            this.delbtn.UseVisualStyleBackColor = true;
            // 
            // Nametxtbox
            // 
            this.Nametxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nametxtbox.Location = new System.Drawing.Point(179, 156);
            this.Nametxtbox.Name = "Nametxtbox";
            this.Nametxtbox.Size = new System.Drawing.Size(183, 20);
            this.Nametxtbox.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Course Name";
            // 
            // RegNotxtbox
            // 
            this.RegNotxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegNotxtbox.Location = new System.Drawing.Point(179, 124);
            this.RegNotxtbox.Name = "RegNotxtbox";
            this.RegNotxtbox.Size = new System.Drawing.Size(183, 20);
            this.RegNotxtbox.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Registration Number";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(546, 51);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker.TabIndex = 55;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(179, 195);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 56;
            this.checkBox1.Text = "Present";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.Nametxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegNotxtbox);
            this.Controls.Add(this.label1);
            this.Name = "attendance";
            this.Text = "attendance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.TextBox Nametxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RegNotxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}