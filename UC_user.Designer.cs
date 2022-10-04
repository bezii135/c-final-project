namespace UC_Dashboard1
{
    partial class UC_user
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_user));
            this.adduser = new System.Windows.Forms.Label();
            this.Userrole = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.moblienumber = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup = new Guna.UI2.WinForms.Guna2Button();
            this.Reset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // adduser
            // 
            this.adduser.AutoSize = true;
            this.adduser.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduser.Location = new System.Drawing.Point(-1, 13);
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(188, 44);
            this.adduser.TabIndex = 0;
            this.adduser.Text = "Add user ";
            // 
            // Userrole
            // 
            this.Userrole.AutoSize = true;
            this.Userrole.Location = new System.Drawing.Point(4, 82);
            this.Userrole.Name = "Userrole";
            this.Userrole.Size = new System.Drawing.Size(65, 16);
            this.Userrole.TabIndex = 1;
            this.Userrole.Text = "UserRole";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(4, 170);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 16);
            this.name.TabIndex = 2;
            this.name.Text = "Name";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Location = new System.Drawing.Point(4, 275);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(78, 16);
            this.dob.TabIndex = 3;
            this.dob.Text = "Date of birth";
            // 
            // moblienumber
            // 
            this.moblienumber.AutoSize = true;
            this.moblienumber.Location = new System.Drawing.Point(4, 388);
            this.moblienumber.Name = "moblienumber";
            this.moblienumber.Size = new System.Drawing.Size(99, 16);
            this.moblienumber.TabIndex = 4;
            this.moblienumber.Text = "Mobile Number";
            this.moblienumber.Click += new System.EventHandler(this.label5_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(666, 98);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(91, 16);
            this.email.TabIndex = 5;
            this.email.Text = "Email Addres ";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(666, 233);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(76, 16);
            this.username.TabIndex = 6;
            this.username.Text = "User Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(666, 356);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(70, 16);
            this.password.TabIndex = 7;
            this.password.Text = "Password ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(628, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 30);
            this.textBox1.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(608, 269);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(269, 30);
            this.maskedTextBox1.TabIndex = 9;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Administrator ",
            "pharmacist"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(7, 113);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(257, 36);
            this.guna2ComboBox1.TabIndex = 10;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(628, 406);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(269, 30);
            this.maskedTextBox2.TabIndex = 11;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox3.Location = new System.Drawing.Point(3, 209);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(269, 30);
            this.maskedTextBox3.TabIndex = 12;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox4.Location = new System.Drawing.Point(3, 433);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(269, 30);
            this.maskedTextBox4.TabIndex = 13;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(3, 308);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(200, 36);
            this.guna2DateTimePicker1.TabIndex = 14;
            this.guna2DateTimePicker1.Value = new System.DateTime(2022, 8, 16, 15, 37, 32, 688);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(460, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 600);
            this.panel1.TabIndex = 15;
            // 
            // signup
            // 
            this.signup.BorderRadius = 19;
            this.signup.BorderThickness = 1;
            this.signup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.White;
            this.signup.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.signup.Image = ((System.Drawing.Image)(resources.GetObject("signup.Image")));
            this.signup.ImageSize = new System.Drawing.Size(35, 35);
            this.signup.Location = new System.Drawing.Point(577, 480);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(180, 45);
            this.signup.TabIndex = 16;
            this.signup.Text = "Sign up";
            // 
            // Reset
            // 
            this.Reset.BorderRadius = 19;
            this.Reset.BorderThickness = 1;
            this.Reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Reset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.White;
            this.Reset.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.Reset.Image = ((System.Drawing.Image)(resources.GetObject("Reset.Image")));
            this.Reset.ImageSize = new System.Drawing.Size(30, 30);
            this.Reset.Location = new System.Drawing.Point(827, 480);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(180, 45);
            this.Reset.TabIndex = 17;
            this.Reset.Text = "reset ";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.email);
            this.Controls.Add(this.moblienumber);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Userrole);
            this.Controls.Add(this.adduser);
            this.Name = "UC_user";
            this.Size = new System.Drawing.Size(1140, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adduser;
        private System.Windows.Forms.Label Userrole;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label moblienumber;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button signup;
        private Guna.UI2.WinForms.Guna2Button Reset;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
