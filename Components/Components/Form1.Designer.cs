namespace Components
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxAgree = new System.Windows.Forms.CheckBox();
            this.LblAgree = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBTitle = new System.Windows.Forms.ComboBox();
            this.LbxList = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RbNotSingle = new System.Windows.Forms.RadioButton();
            this.RbSingle = new System.Windows.Forms.RadioButton();
            this.GbxGender = new System.Windows.Forms.GroupBox();
            this.RdFemale = new System.Windows.Forms.RadioButton();
            this.RdMale = new System.Windows.Forms.RadioButton();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.BtnGoTo2 = new System.Windows.Forms.Button();
            this.GbxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(308, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(164, 32);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Admissions";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(237, 98);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(150, 20);
            this.TxtFirstName.TabIndex = 1;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(237, 140);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(150, 20);
            this.TxtLastName.TabIndex = 2;
            this.TxtLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(237, 222);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(150, 20);
            this.TxtPhone.TabIndex = 4;
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(237, 180);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(150, 20);
            this.TxtAge.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(237, 263);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(150, 20);
            this.TxtEmail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // CbxAgree
            // 
            this.CbxAgree.AutoSize = true;
            this.CbxAgree.Checked = true;
            this.CbxAgree.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxAgree.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxAgree.Location = new System.Drawing.Point(237, 309);
            this.CbxAgree.Name = "CbxAgree";
            this.CbxAgree.Size = new System.Drawing.Size(15, 14);
            this.CbxAgree.TabIndex = 8;
            this.CbxAgree.UseVisualStyleBackColor = true;
            // 
            // LblAgree
            // 
            this.LblAgree.AutoSize = true;
            this.LblAgree.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgree.Location = new System.Drawing.Point(127, 305);
            this.LblAgree.Name = "LblAgree";
            this.LblAgree.Size = new System.Drawing.Size(62, 18);
            this.LblAgree.TabIndex = 9;
            this.LblAgree.Text = "Agree:";
            this.LblAgree.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Title:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CBTitle
            // 
            this.CBTitle.FormattingEnabled = true;
            this.CBTitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Miss.",
            "Ms.",
            "Dr.",
            "Prof."});
            this.CBTitle.Location = new System.Drawing.Point(237, 60);
            this.CBTitle.Name = "CBTitle";
            this.CBTitle.Size = new System.Drawing.Size(150, 21);
            this.CBTitle.TabIndex = 11;
            this.CBTitle.Text = "Mr.";
            this.CBTitle.SelectedIndexChanged += new System.EventHandler(this.CBTitle_SelectedIndexChanged);
            // 
            // LbxList
            // 
            this.LbxList.FormattingEnabled = true;
            this.LbxList.Items.AddRange(new object[] {
            "First Item in the list",
            "Second Item in the list",
            "etc."});
            this.LbxList.Location = new System.Drawing.Point(405, 60);
            this.LbxList.Name = "LbxList";
            this.LbxList.Size = new System.Drawing.Size(237, 56);
            this.LbxList.TabIndex = 12;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "First Item",
            "Second Item",
            "Third Item",
            "Etc.",
            "First Item",
            "Second Item",
            "Third Item",
            "Etc.",
            "First Item",
            "Second Item",
            "Third Item",
            "Etc.",
            "First Item",
            "Second Item",
            "Third Item",
            "Etc.",
            "First Item",
            "Second Item",
            "Third Item",
            "Etc.",
            "First Item",
            "Second Item",
            "Third Item",
            "Etc.",
            "First Item",
            "Second Item",
            "Third Item",
            "Etc.",
            "First Item",
            "Second Item",
            "Third Item",
            "Etc."});
            this.checkedListBox1.Location = new System.Drawing.Point(405, 122);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(237, 94);
            this.checkedListBox1.TabIndex = 13;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(405, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(304, 27);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // RbNotSingle
            // 
            this.RbNotSingle.AutoSize = true;
            this.RbNotSingle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbNotSingle.Location = new System.Drawing.Point(534, 301);
            this.RbNotSingle.Name = "RbNotSingle";
            this.RbNotSingle.Size = new System.Drawing.Size(111, 22);
            this.RbNotSingle.TabIndex = 18;
            this.RbNotSingle.Text = "Not Single";
            this.RbNotSingle.UseVisualStyleBackColor = true;
            // 
            // RbSingle
            // 
            this.RbSingle.AutoSize = true;
            this.RbSingle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbSingle.Location = new System.Drawing.Point(452, 301);
            this.RbSingle.Name = "RbSingle";
            this.RbSingle.Size = new System.Drawing.Size(76, 22);
            this.RbSingle.TabIndex = 17;
            this.RbSingle.Text = "Single";
            this.RbSingle.UseVisualStyleBackColor = true;
            // 
            // GbxGender
            // 
            this.GbxGender.Controls.Add(this.RdFemale);
            this.GbxGender.Controls.Add(this.RdMale);
            this.GbxGender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxGender.Location = new System.Drawing.Point(131, 338);
            this.GbxGender.Name = "GbxGender";
            this.GbxGender.Size = new System.Drawing.Size(200, 100);
            this.GbxGender.TabIndex = 19;
            this.GbxGender.TabStop = false;
            this.GbxGender.Text = "Select a Gender";
            // 
            // RdFemale
            // 
            this.RdFemale.AutoSize = true;
            this.RdFemale.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdFemale.Location = new System.Drawing.Point(106, 42);
            this.RdFemale.Name = "RdFemale";
            this.RdFemale.Size = new System.Drawing.Size(85, 22);
            this.RdFemale.TabIndex = 18;
            this.RdFemale.Text = "Female";
            this.RdFemale.UseVisualStyleBackColor = true;
            // 
            // RdMale
            // 
            this.RdMale.AutoSize = true;
            this.RdMale.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdMale.Location = new System.Drawing.Point(24, 42);
            this.RdMale.Name = "RdMale";
            this.RdMale.Size = new System.Drawing.Size(64, 22);
            this.RdMale.TabIndex = 17;
            this.RdMale.Text = "Male";
            this.RdMale.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "First Item",
            "Second Item",
            "Third Item",
            "Etc.",
            "First Item",
            "Second Item",
            "Third Item",
            "Etc.",
            "First Item",
            "Second Item",
            "Third Item",
            "Etc.",
            "First Item",
            "Second Item",
            "Third Item",
            "Etc.",
            "First Item",
            "Second Item",
            "Third Item",
            "Etc.",
            "First Item",
            "Second Item",
            "Third Item",
            "Etc.",
            "First Item",
            "Second Item",
            "Third Item",
            "Etc.",
            "First Item",
            "Second Item",
            "Third Item",
            "Etc."});
            this.checkedListBox2.Location = new System.Drawing.Point(408, 329);
            this.checkedListBox2.MultiColumn = true;
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(237, 94);
            this.checkedListBox2.TabIndex = 21;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // BtnGoTo2
            // 
            this.BtnGoTo2.Location = new System.Drawing.Point(684, 424);
            this.BtnGoTo2.Name = "BtnGoTo2";
            this.BtnGoTo2.Size = new System.Drawing.Size(75, 23);
            this.BtnGoTo2.TabIndex = 22;
            this.BtnGoTo2.Text = "Form 2";
            this.BtnGoTo2.UseVisualStyleBackColor = true;
            this.BtnGoTo2.Click += new System.EventHandler(this.BtnGoTo2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 459);
            this.Controls.Add(this.BtnGoTo2);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.GbxGender);
            this.Controls.Add(this.RbNotSingle);
            this.Controls.Add(this.RbSingle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.LbxList);
            this.Controls.Add(this.CBTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblAgree);
            this.Controls.Add(this.CbxAgree);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbxGender.ResumeLayout(false);
            this.GbxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CbxAgree;
        private System.Windows.Forms.Label LblAgree;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBTitle;
        private System.Windows.Forms.ListBox LbxList;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton RbNotSingle;
        private System.Windows.Forms.RadioButton RbSingle;
        private System.Windows.Forms.GroupBox GbxGender;
        private System.Windows.Forms.RadioButton RdFemale;
        private System.Windows.Forms.RadioButton RdMale;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button BtnGoTo2;
    }
}

