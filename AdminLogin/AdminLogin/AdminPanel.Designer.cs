
namespace AdminLogin
{
    partial class AdminPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lbEmployee = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmpSalary = new System.Windows.Forms.TextBox();
            this.txtEmpManager = new System.Windows.Forms.TextBox();
            this.txtEmpDepartment = new System.Windows.Forms.TextBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddSalary = new System.Windows.Forms.TextBox();
            this.AddEmail = new System.Windows.Forms.TextBox();
            this.AddName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iPTprojectDataSet1 = new AdminLogin.IPTprojectDataSet1();
            this.designationsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.designationsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.iPTprojectDataSet = new AdminLogin.IPTprojectDataSet();
            this.designationsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iPTprojectDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iPTprojectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new AdminLogin.IPTprojectDataSetTableAdapters.EmployeesTableAdapter();
            this.designationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.designationsTableAdapter = new AdminLogin.IPTprojectDataSetTableAdapters.DesignationsTableAdapter();
            this.desEmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desEmpBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.designationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iPTprojectDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.designationsTableAdapter1 = new AdminLogin.IPTprojectDataSet1TableAdapters.DesignationsTableAdapter();
            this.iPTprojectDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPTprojectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPTprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPTprojectDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPTprojectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desEmpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desEmpBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPTprojectDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPTprojectDataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Employee";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(52, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "IT";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(93, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Finance";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(162, 55);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "Manager";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lbEmployee
            // 
            this.lbEmployee.BackColor = System.Drawing.Color.MistyRose;
            this.lbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployee.FormattingEnabled = true;
            this.lbEmployee.ItemHeight = 16;
            this.lbEmployee.Location = new System.Drawing.Point(7, 78);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(222, 276);
            this.lbEmployee.TabIndex = 4;
            this.lbEmployee.SelectedIndexChanged += new System.EventHandler(this.lbEmployee_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtEmpSalary);
            this.panel1.Controls.Add(this.txtEmpManager);
            this.panel1.Controls.Add(this.txtEmpDepartment);
            this.panel1.Controls.Add(this.txtEmpEmail);
            this.panel1.Controls.Add(this.txtEmpName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(249, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 275);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(170, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lime;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(17, 225);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEmpSalary
            // 
            this.txtEmpSalary.Location = new System.Drawing.Point(149, 169);
            this.txtEmpSalary.Name = "txtEmpSalary";
            this.txtEmpSalary.Size = new System.Drawing.Size(100, 20);
            this.txtEmpSalary.TabIndex = 9;
            // 
            // txtEmpManager
            // 
            this.txtEmpManager.Location = new System.Drawing.Point(149, 133);
            this.txtEmpManager.Name = "txtEmpManager";
            this.txtEmpManager.Size = new System.Drawing.Size(100, 20);
            this.txtEmpManager.TabIndex = 8;
            // 
            // txtEmpDepartment
            // 
            this.txtEmpDepartment.Location = new System.Drawing.Point(149, 90);
            this.txtEmpDepartment.Name = "txtEmpDepartment";
            this.txtEmpDepartment.Size = new System.Drawing.Size(100, 20);
            this.txtEmpDepartment.TabIndex = 7;
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(149, 57);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmpEmail.TabIndex = 6;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(149, 33);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "manager";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Yellow;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 5;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(249, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(10, 55);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(36, 17);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "All";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.radioButton6);
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.AddSalary);
            this.panel2.Controls.Add(this.AddEmail);
            this.panel2.Controls.Add(this.AddName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(519, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 275);
            this.panel2.TabIndex = 8;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(163, 120);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(63, 17);
            this.radioButton6.TabIndex = 21;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Finance";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(122, 120);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(35, 17);
            this.radioButton5.TabIndex = 20;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "IT";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(24, 225);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(218, 23);
            this.btnInsert.TabIndex = 19;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "salary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "department";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "email";
            // 
            // AddSalary
            // 
            this.AddSalary.Location = new System.Drawing.Point(122, 169);
            this.AddSalary.Name = "AddSalary";
            this.AddSalary.Size = new System.Drawing.Size(100, 20);
            this.AddSalary.TabIndex = 16;
            // 
            // AddEmail
            // 
            this.AddEmail.Location = new System.Drawing.Point(122, 57);
            this.AddEmail.Name = "AddEmail";
            this.AddEmail.Size = new System.Drawing.Size(100, 20);
            this.AddEmail.TabIndex = 13;
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(122, 33);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(100, 20);
            this.AddName.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Add Employee";
            // 
            // iPTprojectDataSet1
            // 
            this.iPTprojectDataSet1.DataSetName = "IPTprojectDataSet1";
            this.iPTprojectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // designationsBindingSource4
            // 
            this.designationsBindingSource4.DataMember = "Designations";
            this.designationsBindingSource4.DataSource = this.iPTprojectDataSet1;
            // 
            // designationsBindingSource3
            // 
            this.designationsBindingSource3.DataMember = "Designations";
            this.designationsBindingSource3.DataSource = this.iPTprojectDataSet1;
            // 
            // iPTprojectDataSet
            // 
            this.iPTprojectDataSet.DataSetName = "IPTprojectDataSet";
            this.iPTprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // designationsBindingSource2
            // 
            this.designationsBindingSource2.DataMember = "Designations";
            this.designationsBindingSource2.DataSource = this.iPTprojectDataSetBindingSource1;
            // 
            // iPTprojectDataSetBindingSource1
            // 
            this.iPTprojectDataSetBindingSource1.DataSource = this.iPTprojectDataSet;
            this.iPTprojectDataSetBindingSource1.Position = 0;
            // 
            // iPTprojectDataSetBindingSource
            // 
            this.iPTprojectDataSetBindingSource.DataSource = this.iPTprojectDataSet;
            this.iPTprojectDataSetBindingSource.Position = 0;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.iPTprojectDataSetBindingSource1;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // designationsBindingSource
            // 
            this.designationsBindingSource.DataMember = "Designations";
            this.designationsBindingSource.DataSource = this.iPTprojectDataSet;
            // 
            // designationsTableAdapter
            // 
            this.designationsTableAdapter.ClearBeforeFill = true;
            // 
            // desEmpBindingSource
            // 
            this.desEmpBindingSource.DataMember = "Des_Emp";
            this.desEmpBindingSource.DataSource = this.designationsBindingSource;
            // 
            // desEmpBindingSource1
            // 
            this.desEmpBindingSource1.DataMember = "Des_Emp";
            this.desEmpBindingSource1.DataSource = this.designationsBindingSource;
            // 
            // designationsBindingSource1
            // 
            this.designationsBindingSource1.DataMember = "Designations";
            this.designationsBindingSource1.DataSource = this.iPTprojectDataSetBindingSource1;
            // 
            // iPTprojectDataSet1BindingSource
            // 
            this.iPTprojectDataSet1BindingSource.DataSource = this.iPTprojectDataSet1;
            this.iPTprojectDataSet1BindingSource.Position = 0;
            // 
            // designationsTableAdapter1
            // 
            this.designationsTableAdapter1.ClearBeforeFill = true;
            // 
            // iPTprojectDataSet1BindingSource1
            // 
            this.iPTprojectDataSet1BindingSource1.DataSource = this.iPTprojectDataSet1;
            this.iPTprojectDataSet1BindingSource1.Position = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(122, 83);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 23;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbEmployee);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPTprojectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPTprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPTprojectDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPTprojectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desEmpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desEmpBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPTprojectDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPTprojectDataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ListBox lbEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEmpSalary;
        private System.Windows.Forms.TextBox txtEmpManager;
        private System.Windows.Forms.TextBox txtEmpDepartment;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AddSalary;
        private System.Windows.Forms.TextBox AddEmail;
        private System.Windows.Forms.TextBox AddName;
        private System.Windows.Forms.Label label8;
        private IPTprojectDataSet iPTprojectDataSet;
        private System.Windows.Forms.BindingSource iPTprojectDataSetBindingSource;
        private System.Windows.Forms.BindingSource iPTprojectDataSetBindingSource1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private IPTprojectDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource designationsBindingSource;
        private IPTprojectDataSetTableAdapters.DesignationsTableAdapter designationsTableAdapter;
        private System.Windows.Forms.BindingSource desEmpBindingSource;
        private System.Windows.Forms.BindingSource designationsBindingSource2;
        private System.Windows.Forms.BindingSource desEmpBindingSource1;
        private System.Windows.Forms.BindingSource designationsBindingSource1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.BindingSource iPTprojectDataSet1BindingSource;
        private IPTprojectDataSet1 iPTprojectDataSet1;
        private System.Windows.Forms.BindingSource designationsBindingSource3;
        private IPTprojectDataSet1TableAdapters.DesignationsTableAdapter designationsTableAdapter1;
        private System.Windows.Forms.BindingSource designationsBindingSource4;
        private System.Windows.Forms.BindingSource iPTprojectDataSet1BindingSource1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label11;
    }
}