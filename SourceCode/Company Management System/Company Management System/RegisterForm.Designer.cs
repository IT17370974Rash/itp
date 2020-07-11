namespace Company_Management_System
{
    partial class RegisterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.nic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.MonthCalendar();
            this.contact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "You\'re using the applicaion for the first time. Please fill the registration form" +
    " for the admin";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.registerBtn);
            this.groupBox1.Controls.Add(this.nic);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dob);
            this.groupBox1.Controls.Add(this.contact);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.lname);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.Location = new System.Drawing.Point(88, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 540);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Registration";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(81, 216);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(227, 20);
            this.username.TabIndex = 5;
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Username:";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(113, 483);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(111, 38);
            this.registerBtn.TabIndex = 8;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.button1_Click);
            this.registerBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // nic
            // 
            this.nic.Location = new System.Drawing.Point(81, 179);
            this.nic.Name = "nic";
            this.nic.Size = new System.Drawing.Size(227, 20);
            this.nic.TabIndex = 4;
            this.nic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "NIC:";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(81, 287);
            this.dob.MaxSelectionCount = 1;
            this.dob.Name = "dob";
            this.dob.TabIndex = 7;
            this.dob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(81, 144);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(227, 20);
            this.contact.TabIndex = 3;
            this.contact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date of birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name:";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(81, 107);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(227, 20);
            this.address.TabIndex = 2;
            this.address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(81, 70);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(227, 20);
            this.lname.TabIndex = 1;
            this.lname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(81, 37);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(227, 20);
            this.fname.TabIndex = 0;
            this.fname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(81, 255);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(227, 20);
            this.password.TabIndex = 6;
            this.password.UseSystemPasswordChar = true;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Password:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar dob;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox nic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label9;
    }
}