namespace Lab2_Home
{
    partial class enrollment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.courseNametxtbox = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.RegNotxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Enrollment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 232);
            this.dataGridView1.TabIndex = 44;
            // 
            // showbtn
            // 
            this.showbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.showbtn.Location = new System.Drawing.Point(538, 455);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(101, 23);
            this.showbtn.TabIndex = 42;
            this.showbtn.Text = "Show";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.delbtn.Location = new System.Drawing.Point(537, 166);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(106, 23);
            this.delbtn.TabIndex = 41;
            this.delbtn.Text = "Del";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Addbtn.Location = new System.Drawing.Point(537, 137);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(106, 23);
            this.Addbtn.TabIndex = 40;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // courseNametxtbox
            // 
            this.courseNametxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseNametxtbox.Location = new System.Drawing.Point(172, 159);
            this.courseNametxtbox.Name = "courseNametxtbox";
            this.courseNametxtbox.Size = new System.Drawing.Size(183, 20);
            this.courseNametxtbox.TabIndex = 39;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(43, 162);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(71, 13);
            this.lab.TabIndex = 38;
            this.lab.Text = "Course Name";
            // 
            // RegNotxtbox
            // 
            this.RegNotxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegNotxtbox.Location = new System.Drawing.Point(172, 130);
            this.RegNotxtbox.Name = "RegNotxtbox";
            this.RegNotxtbox.Size = new System.Drawing.Size(183, 20);
            this.RegNotxtbox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Registeration Number";
            // 
            // back
            // 
            this.back.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.back.Location = new System.Drawing.Point(40, 476);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(106, 23);
            this.back.TabIndex = 46;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // enrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.courseNametxtbox);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.RegNotxtbox);
            this.Controls.Add(this.label4);
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "enrollment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "enrollment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.TextBox courseNametxtbox;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox RegNotxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button back;
    }
}