using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdminLogin
{
   public partial class AdminPanel : Form
    {
        public static string radio_opt = "ALL";
        public static int dept_radio = 0;
        public AdminPanel()
        {
            
            InitializeComponent();
            radioButton4.Checked = true;
            radioButton3.Checked = false;
            radioButton2.Checked = false;
            radioButton1.Checked = false;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ALMAS\SQLEXPRESS;Initial Catalog=IPTproject;Integrated Security=True");
        private void Displayuser(int dept_id)
        {
            string sqltext;
            if(dept_id==0)
            {sqltext = "select * from Employees";}
            else if(dept_id==4)
            {sqltext = "select * from Employees E where e.eid IN(select managerid from Employees)";}
            else
            {sqltext = "select * from Employees where did= '"+dept_id+"'";}
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqltext, conn);
            adapter.Fill(tbl);
            lbEmployee.DisplayMember = "name";
            lbEmployee.ValueMember = "eid";
            lbEmployee.DataSource = tbl;
        }
        private void lbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true ;
            if(radio_opt=="ALL")
            {
                
                IPTprojectEntities2 ctx = new IPTprojectEntities2();
                int m_eid;
                int d_did;
                int emp_eid = Convert.ToInt32(lbEmployee.SelectedValue);
                foreach (var sm in ctx.Employees.Where(p1 => p1.eid.Equals(emp_eid)))
                {
                    txtEmpName.Text = sm.name;
                    txtEmpSalary.Text = Convert.ToString(sm.salary);
                    txtEmpEmail.Text=sm.email;
                    m_eid = Convert.ToInt32(sm.managerid);
                    d_did = Convert.ToInt32(sm.did);
                    foreach (var sm2 in ctx.Employees.Where(p1 => p1.eid.Equals(m_eid)))
                    {
                        txtEmpManager.Text = sm2.name;

                    }
                    foreach (var sm3 in ctx.Designations.Where(p1 => p1.did.Equals(d_did)))
                    {
                        txtEmpDepartment.Text = sm3.DeptName;

                    }
                    txtEmpDepartment.ReadOnly = true;
                    txtEmpManager.ReadOnly = true;
                }
            }
            else if (radio_opt=="F" || radio_opt=="IT")
            {
                if(radio_opt=="IT")
                {Displayuser(2);}
                if (radio_opt == "F")
                {Displayuser(3);}
            }   
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {Displayuser(2);}

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {Displayuser(3);}

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {Displayuser(0);}

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {Displayuser(4);}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            IPTprojectEntities2 ctx = new IPTprojectEntities2();

            int emp_eid = Convert.ToInt32(lbEmployee.SelectedValue);
            decimal salary = Convert.ToDecimal(txtEmpSalary.Text);
            foreach (var sm in ctx.Employees.Where(p1 => p1.eid.Equals(emp_eid)))
            {
                sm.name = txtEmpName.Text;
                sm.salary = salary;
                sm.email = txtEmpEmail.Text;
            }
            ctx.SaveChanges();
            if (radio_opt == "F" || radio_opt == "IT" || radio_opt == "ALL")
            {
                if (radio_opt == "IT")
                { Displayuser(2); }
                if (radio_opt == "F")
                { Displayuser(3); }
                if (radio_opt == "ALL")
                { Displayuser(0); }
            }
            else
            {
                Displayuser(0);
            }
            MessageBox.Show("Employee Updated Successfully");
        }
        //DELETION USING LINQ OPERATION
        private void btnDelete_Click(object sender, EventArgs e)
        {

            IPTprojectEntities2 ctx = new IPTprojectEntities2();
            
                int emp_eid = Convert.ToInt32(lbEmployee.SelectedValue);
                
                foreach (var sm in ctx.Employees.Where(p1=>p1.eid.Equals(emp_eid)))
                {
                ctx.Employees.Remove(sm);
                }
                ctx.SaveChanges();
                if (radio_opt == "F" || radio_opt == "IT" || radio_opt == "ALL")
                {
                    if (radio_opt == "IT")
                    { Displayuser(2); }
                    if (radio_opt == "F")
                    { Displayuser(3); }
                    if (radio_opt == "ALL")
                    { Displayuser(0); }
                }
                else
                {
                    Displayuser(0);
                }
                panel1.Visible = false;
                MessageBox.Show("Employee Deleted Successfully");
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iPTprojectDataSet1.Designations' table. You can move, or remove it, as needed.
            //this.designationsTableAdapter1.Fill(this.iPTprojectDataSet1.Designations);
            // TODO: This line of code loads data into the 'iPTprojectDataSet.Designations' table. You can move, or remove it, as needed.
            //this.designationsTableAdapter.Fill(this.iPTprojectDataSet.Designations);
            // TODO: This line of code loads data into the 'iPTprojectDataSet.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this.iPTprojectDataSet.Employees);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using(IPTprojectEntities2 ctx = new IPTprojectEntities2())
            {
                Employee emp = new Employee
                {
                    name = AddName.Text,
                    email = AddEmail.Text,
                    did = dept_radio,
                    managerid = dept_radio,
                    pass = txtPass.Text,
                    salary = Convert.ToDecimal(AddSalary.Text)
                };
                ctx.Employees.Add(emp);
                ctx.SaveChanges();
                MessageBox.Show("Employee Inserted");
                if (radio_opt == "F" || radio_opt == "IT" || radio_opt == "ALL")
                {
                    if (radio_opt == "IT")
                    { Displayuser(2); }
                    if (radio_opt == "F")
                    { Displayuser(3); }
                    if (radio_opt == "ALL")
                    { Displayuser(0); }
                }
                else
                {
                    Displayuser(0);
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            dept_radio = 2;
            radioButton6.Checked = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            dept_radio = 3;
            radioButton5.Checked = false;
        }
    }
}
