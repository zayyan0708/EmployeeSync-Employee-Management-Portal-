using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using EmpMng.Models;

namespace EmpMng.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        SqlCommand com = new SqlCommand();
        //SqlDataReader dr;
        public static int global_eid;
        public static int global_mid;
        public static int global_did;
        IPTprojectEntities5 ipt = new IPTprojectEntities5();
        public ActionResult MngView()
        {
            if (global_eid == 0)
            {
                ViewBag.empID = Convert.ToInt32(TempData["mydata"]);
                global_eid = ViewBag.empID;
            }
            else
            {
                ViewBag.empID = global_eid;
            }
        
            return View(ipt.Employees.ToList());
        }
        public ActionResult EmpView()
        {
            if (global_eid == 0)
            {
                ViewBag.empID = Convert.ToInt32(TempData["mydata"]);
                global_eid = ViewBag.empID;
            }
            else
            {
                ViewBag.empID = global_eid;
            }
            return View(ipt.Employees.Where(x => x.eid == global_eid).FirstOrDefault());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var data = ipt.Employees.Where(x => x.eid == id).FirstOrDefault();
            return View(data);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ALMAS\SQLEXPRESS;Initial Catalog=IPTproject;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            con.Open();
            try
            {
                using (var ctx = new IPTprojectEntities5())
                {
                    var des = ctx.Designations.SqlQuery("select * from Designations where mid=@id", new SqlParameter("@id", global_eid)).FirstOrDefault();
                    ViewBag.mid = Convert.ToInt32(des.mid);
                    global_mid = ViewBag.mid;
                    ViewBag.did = Convert.ToInt32(des.did);
                    global_did = ViewBag.did;
                    ViewBag.DeptName = Convert.ToString(des.DeptName);
                }
            }
            catch
            {

            }
            return View();
        }
        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee Model)
        {
       
            try
            {
                ViewBag.mid = global_mid;
                string name = Model.name;
                Model.managerid = global_mid;
                Model.did = global_did;

                ipt.Employees.Add(Model);
                ipt.SaveChanges();
                ViewBag.Message = "Data Insert Successfully";
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EditEmp(int id)
        {
            var data = ipt.Employees.Where(x => x.eid == id).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult EditEmp(Employee Model)
        {

            var data = ipt.Employees.Where(x => x.eid == Model.eid).FirstOrDefault();
            if (data != null)
            {
                data.email = Model.email;
                data.name = Model.name;
                data.pass = Model.pass;
                ipt.SaveChanges();
            }
            return View();
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {

            var data = ipt.Employees.Where(x => x.eid == id).FirstOrDefault();
            return View(data);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(Employee Model)
        {

            var data = ipt.Employees.Where(x => x.eid == Model.eid).FirstOrDefault();
            if (data != null)
            {
                data.email = Model.email;
                data.name = Model.name;
                data.pass = Model.pass;
                data.salary = Model.salary;
                ipt.SaveChanges();
            }
            return View();
        }

        // GET: Employee/Delete/5
       
            // POST: Employee/Delete/5
            public ActionResult Delete(int id)
            {
            var data = ipt.Employees.Where(x => x.eid == id).FirstOrDefault();
            localhost1.DeleteService test = new localhost1.DeleteService();
            test.DeleteSer(id);
            return View(data);
        }
    }
}
