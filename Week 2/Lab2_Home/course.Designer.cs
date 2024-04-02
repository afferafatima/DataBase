namespace Lab2_Home
{
    partial class course
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updatebtn = new System.Windows.Forms.Button();
            this.showbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.codetxtbox = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.Nametxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 232);
            this.dataGridView1.TabIndex = 34;
            // 
            // updatebtn
            // 
            this.updatebtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.updatebtn.Location = new System.Drawing.Point(539, 139);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(106, 23);
            this.updatebtn.TabIndex = 33;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // showbtn
            // 
            this.showbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.showbtn.Location = new System.Drawing.Point(539, 458);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(101, 23);
            this.showbtn.TabIndex = 32;
            this.showbtn.Text = "Show";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.delbtn.Location = new System.Drawing.Point(538, 177);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(106, 23);
            this.delbtn.TabIndex = 31;
            this.delbtn.Text = "Del";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Addbtn.Location = new System.Drawing.Point(539, 102);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(106, 23);
            this.Addbtn.TabIndex = 30;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // codetxtbox
            // 
            this.codetxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codetxtbox.Location = new System.Drawing.Point(173, 162);
            this.codetxtbox.Name = "codetxtbox";
            this.codetxtbox.Size = new System.Drawing.Size(183, 20);
            this.codetxtbox.TabIndex = 25;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(44, 165);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(32, 13);
            this.lab.TabIndex = 24;
            this.lab.Text = "Code";
            // 
            // Nametxtbox
            // 
            this.Nametxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nametxtbox.Location = new System.Drawing.Point(173, 133);
            this.Nametxtbox.Name = "Nametxtbox";
            this.Nametxtbox.Size = new System.Drawing.Size(183, 20);
            this.Nametxtbox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Courses";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(47, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.codetxtbox);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.Nametxtbox);
            this.Controls.Add(this.label4);
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "course";
            this.Text = "course";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.TextBox codetxtbox;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox Nametxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}