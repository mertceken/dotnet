using BuisnessLogicLayer;
using DatabaseLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace UI_Layer.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        EmployeesManager empMan = new EmployeesManager();

        [HttpGet]
        public tblEmployees GetEmployees(int ID)
        {
            return empMan.findEmployees(employeesId: ID);
        }

        public IHttpActionResult PostEmployees(string name, string surname, DateTime dateofbirth, bool gender, string identityNumber, decimal annualSalary, int contractId)
        {
            string text = null;
            if (!string.IsNullOrWhiteSpace(name))
            {
                empMan.insertEmployees(name, surname, Convert.ToDateTime(dateofbirth), Convert.ToBoolean(gender), identityNumber, Convert.ToDecimal(annualSalary), Convert.ToInt32(contractId));
                text = "Insert operation is successful";
            }
            else
            {
                text = "Please fill in the blanks";
            }

            return Ok(text);

        }

        [HttpPut]
        public IHttpActionResult UpdateEmployees(int id)
        {
            tblEmployees employee = db.tblEmployees.FirstOrDefault(e => e.ID == id);
            employee.Name = "- Update";
            db.SaveChanges();

            return Ok<string>("Update Opreation is successful");
        }
    }


}
    

