using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DeleteWebService.Models;

namespace DeleteWebService
{
    /// <summary>
    /// Summary description for DeleteService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DeleteService : System.Web.Services.WebService
    {

        [WebMethod]
        public void DeleteSer(int id)
        {
            using (var ctx = new IPTprojectEntities())
            {
                ctx.Database.ExecuteSqlCommand("delete from Employees where eid='" + id + "'");
            }
        }
    }
}
