using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFIPT
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(string email,string pass)
        {
            string flag = "false";
            //return string.Format("You entered: {0}", value);
            IPTprojectEntities1 ctx = new IPTprojectEntities1();
            var result = (from e in ctx.Employees
                          where e.email == email && e.pass == pass && e.did == 1
                          select e).FirstOrDefault();
            if (result != null)
            {
                flag = "true";
                return string.Format(flag);
            }
            return string.Format(flag);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
