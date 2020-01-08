using DatabaseLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer
{
    public class Repository<T> where T : class
    {
        EmployeeDBEntities db = new EmployeeDBEntities();

        public List<T> List()
        {
            return db.Set<T>().ToList();
            //class adı olan Repository eğer kısıtlama yoksa hata verecektir.Biz Repository class ını where ile onun bir class olduğunu belirteceğiz.
        }

        public int Save()
        {
            return db.SaveChanges();
        }

        public int insert(T nesne)
        {
            db.Set<T>().Add(nesne);
            return Save();
        }

        public int Update(T nesne)
        {
            return Save();
        }
        public int Delete(T nesne)
        {
            db.Set<T>().Remove(nesne);
            return Save();
        }

        public List<T> Liste(Expression<Func<T, bool>> queryWhere)
        {
           
            return db.Set<T>().Where(queryWhere).ToList();
        }

        //Orderby,Top,Group by,...
        public IQueryable<T> ListFilter(Expression<Func<T, bool>> queryWhere)
        {
           
            return db.Set<T>().Where(queryWhere);
        }
        public T FindData(Expression<Func<T, bool>> SorguKodu)
        {
            return db.Set<T>().FirstOrDefault(SorguKodu);
            //return  db.Set<T>().Where(SorguKodu).FirstOrDefault();
        }

        public decimal calculateSalary(decimal salary)
        {
            tblContracts cn = new tblContracts();
            tblEmployees emp = new tblEmployees();

            decimal hourlySalary = 120 * salary * 12;
            decimal monthlySalary = salary * 12;
            string conType = cn.ContractType;

            if (conType=="Hourly Salary Contract")
            {
                emp.AnnualSalary = hourlySalary;
            }
            else if (conType == "Monthly Salary Contract")
            {
                emp.AnnualSalary = monthlySalary;
            }

            return salary;
        }
    }
}
