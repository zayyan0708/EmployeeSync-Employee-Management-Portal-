using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmpMng.Models;
using System.Data.SqlClient;
using System.Data;

namespace EmpMng.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account

        SqlCommand com = new SqlCommand();
        //SqlDataReader dr;
        IPTprojectEntities5 ipt = new IPTprojectEntities5();
        public ActionResult Verify(Employee acc)
        {
            ViewBag.LoginStatus = 1;
            SqlConnection con = new SqlConnection(@"Data Source=ALMAS\SQLEXPRESS;Initial Catalog=IPTproject;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            con.Open();
            try
            {
                string querry = "SELECT * From Employees  Where email='" + acc.email + "' AND pass = '" + acc.pass + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                int eid = Convert.ToInt32(dtable.Rows[0]["eid"]);
                ViewBag.empID = eid;
                if (dtable.Rows.Count > 0)
                {
                    con.Close();
                    ViewBag.LoginStatus = 1;
                    TempData["mydata"] = eid;
                    using (var ctx = new IPTprojectEntities5())
                    {
                        var empl = ctx.Designations.SqlQuery("select * from Designations where mid=@id", new SqlParameter("@id", eid)).FirstOrDefault();
                        string emp_mid =Convert.ToString(empl);
                        
                        
                        if(emp_mid!="")
                        {
                            return RedirectToAction("MngView", "Employee");
                        }
                        else
                        {
                            return RedirectToAction("EmpView", "Employee");
                        }   
                    }
                }
                else
                {
                        if(acc.email==null)
                    {
                        con.Close();
                        ViewBag.LoginStatus = 1;
                        return View();
                    }
                        else
                    {
                        con.Close();
                        ViewBag.LoginStatus = 0;
                        return View();
                    }

                }
            }
            catch
            {
                con.Close();
                return View();
            }
            finally
            {
                con.Close();

            }
        }
        public ActionResult EmpDetails()
        {
           
            return View(ipt.Employees.ToList());

        }
        // GET: Account/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Account/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Account/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Account/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Account/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
