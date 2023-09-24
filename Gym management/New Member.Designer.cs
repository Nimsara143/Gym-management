namespace Gym_management
{
    partial class New_Member
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Member));
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.mobileno = new System.Windows.Forms.TextBox();
            this.emailA = new System.Windows.Forms.TextBox();
            this.joindate = new System.Windows.Forms.DateTimePicker();
            this.city = new System.Windows.Forms.TextBox();
            this.maddress = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.Button();
            this.rest = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.memtime = new System.Windows.Forms.ComboBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gym_managementDataSet = new Gym_management.gym_managementDataSet();
            this.newmemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newmemberTableAdapter = new Gym_management.gym_managementDataSetTableAdapters.NewmemberTableAdapter();
            this.gym_managementDataSet1 = new Gym_management.gym_managementDataSet1();
            this.newmemberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.newmemberTableAdapter1 = new Gym_management.gym_managementDataSet1TableAdapters.NewmemberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gym_managementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newmemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gym_managementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newmemberBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(82, 59);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(100, 20);
            this.firstname.TabIndex = 0;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(82, 111);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 20);
            this.lastname.TabIndex = 1;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.BackColor = System.Drawing.Color.Transparent;
            this.rad1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad1.ForeColor = System.Drawing.Color.White;
            this.rad1.Location = new System.Drawing.Point(82, 166);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(57, 19);
            this.rad1.TabIndex = 2;
            this.rad1.TabStop = true;
            this.rad1.Text = "Male";
            this.rad1.UseVisualStyleBackColor = false;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.BackColor = System.Drawing.Color.Transparent;
            this.rad2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad2.ForeColor = System.Drawing.Color.White;
            this.rad2.Location = new System.Drawing.Point(156, 166);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(73, 19);
            this.rad2.TabIndex = 3;
            this.rad2.TabStop = true;
            this.rad2.Text = "Female";
            this.rad2.UseVisualStyleBackColor = false;
            // 
            // dateofbirth
            // 
            this.dateofbirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateofbirth.Location = new System.Drawing.Point(97, 216);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(200, 20);
            this.dateofbirth.TabIndex = 4;
            // 
            // mobileno
            // 
            this.mobileno.Location = new System.Drawing.Point(82, 279);
            this.mobileno.Name = "mobileno";
            this.mobileno.Size = new System.Drawing.Size(100, 20);
            this.mobileno.TabIndex = 5;
            // 
            // emailA
            // 
            this.emailA.Location = new System.Drawing.Point(325, 59);
            this.emailA.Name = "emailA";
            this.emailA.Size = new System.Drawing.Size(100, 20);
            this.emailA.TabIndex = 6;
            // 
            // joindate
            // 
            this.joindate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.joindate.Location = new System.Drawing.Point(331, 108);
            this.joindate.Name = "joindate";
            this.joindate.Size = new System.Drawing.Size(200, 20);
            this.joindate.TabIndex = 7;
            this.joindate.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(356, 168);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 8;
            // 
            // maddress
            // 
            this.maddress.Location = new System.Drawing.Point(338, 292);
            this.maddress.Name = "maddress";
            this.maddress.Size = new System.Drawing.Size(100, 96);
            this.maddress.TabIndex = 9;
            this.maddress.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mobile No.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(269, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(269, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Join Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(319, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "City";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(280, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Address";
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sub.Location = new System.Drawing.Point(156, 394);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 23);
            this.sub.TabIndex = 21;
            this.sub.Text = "Submit";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.button1_Click);
            // 
            // rest
            // 
            this.rest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rest.Location = new System.Drawing.Point(272, 394);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(75, 23);
            this.rest.TabIndex = 22;
            this.rest.Text = "Reset";
            this.rest.UseVisualStyleBackColor = false;
            this.rest.Click += new System.EventHandler(this.rest_Click);
            // 
            // time
            // 
            this.time.Cursor = System.Windows.Forms.Cursors.Hand;
            this.time.FormattingEnabled = true;
            this.time.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening",
            "Night"});
            this.time.Location = new System.Drawing.Point(325, 247);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(121, 21);
            this.time.TabIndex = 23;
            this.time.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(280, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(79, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Membership Time";
            // 
            // memtime
            // 
            this.memtime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memtime.FormattingEnabled = true;
            this.memtime.Items.AddRange(new object[] {
            "threemonths",
            "sixmonths",
            "twelmonths",
            "fifteenmonths"});
            this.memtime.Location = new System.Drawing.Point(190, 341);
            this.memtime.Name = "memtime";
            this.memtime.Size = new System.Drawing.Size(121, 21);
            this.memtime.TabIndex = 25;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(356, 209);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(100, 20);
            this.weight.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(303, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Weight";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // gym_managementDataSet
            // 
            this.gym_managementDataSet.DataSetName = "gym_managementDataSet";
            this.gym_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newmemberBindingSource
            // 
            this.newmemberBindingSource.DataMember = "Newmember";
            this.newmemberBindingSource.DataSource = this.gym_managementDataSet;
            // 
            // newmemberTableAdapter
            // 
            this.newmemberTableAdapter.ClearBeforeFill = true;
            // 
            // gym_managementDataSet1
            // 
            this.gym_managementDataSet1.DataSetName = "gym_managementDataSet1";
            this.gym_managementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newmemberBindingSource1
            // 
            this.newmemberBindingSource1.DataMember = "Newmember";
            this.newmemberBindingSource1.DataSource = this.gym_managementDataSet1;
            // 
            // newmemberTableAdapter1
            // 
            this.newmemberTableAdapter1.ClearBeforeFill = true;
            // 
            // New_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 526);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.memtime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.time);
            this.Controls.Add(this.rest);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maddress);
            this.Controls.Add(this.city);
            this.Controls.Add(this.joindate);
            this.Controls.Add(this.emailA);
            this.Controls.Add(this.mobileno);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.rad1);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "New_Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Member";
            this.Load += new System.EventHandler(this.New_Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gym_managementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newmemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gym_managementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newmemberBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.DateTimePicker dateofbirth;
        private System.Windows.Forms.TextBox mobileno;
        private System.Windows.Forms.TextBox emailA;
        private System.Windows.Forms.DateTimePicker joindate;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.RichTextBox maddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button rest;
        private System.Windows.Forms.ComboBox time;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox memtime;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label12;
        private gym_managementDataSet gym_managementDataSet;
        private System.Windows.Forms.BindingSource newmemberBindingSource;
        private gym_managementDataSetTableAdapters.NewmemberTableAdapter newmemberTableAdapter;
        private gym_managementDataSet1 gym_managementDataSet1;
        private System.Windows.Forms.BindingSource newmemberBindingSource1;
        private gym_managementDataSet1TableAdapters.NewmemberTableAdapter newmemberTableAdapter1;
    }
}