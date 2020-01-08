using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLogicLayer;


namespace BuisnessLogicLayer
{
    public class EmployeesManager
    {
        EmployeeDBEntities db = new EmployeeDBEntities();

        Repository<tblEmployees> repEmp = new Repository<tblEmployees>();

        public List<tblEmployees> listEmployees()
        {
            return repEmp.List();
        }

        public tblEmployees findEmployees(int? employeesId)
        {
            return repEmp.ListFilter(e => e.ID == employeesId).FirstOrDefault();

        }

        public void insertEmployees(string name,string surname,DateTime dateofbirth,bool gender,string identityNumber,decimal annualSalary,int contractId)
        {
            int insert = repEmp.insert(new tblEmployees()
            {
                Name = name,
                Surname = surname,
                DateOfBirth = dateofbirth,
                Gender = gender,
                IdentityNumber = identityNumber,
                AnnualSalary = annualSalary,
                ContractID = contractId
            }); 
           
        }

        public int updateEmployees(tblEmployees tblObj)
        {
            tblEmployees update = repEmp.FindData(e => e.ID == tblObj.ID);

            if (update!=null)
            {
                update.Name = tblObj.Name;
                update.Surname = tblObj.Surname;
                update.DateOfBirth = tblObj.DateOfBirth;
                update.Gender = tblObj.Gender;
                update.IdentityNumber = tblObj.IdentityNumber;
                update.AnnualSalary = tblObj.AnnualSalary;
                update.ContractID = tblObj.ContractID;


                if (repEmp.Update(tblObj)>0)
                {
                    return 1;
                }

            }
            return 0;

        }

        public int deleteEmployees(int idEmployees)
        {
            tblEmployees deleteEmployees = repEmp.FindData(e => e.ID == idEmployees);

            if (deleteEmployees!=null)
            {
                if (repEmp.Delete(deleteEmployees)>0)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
