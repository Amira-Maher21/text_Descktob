using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test1.Database;

namespace test1.Classes
{
    

    class MainClass
    {

        OptDataContext dataContext = new OptDataContext();



        public object SelectAllEmployeeData()
        {
            var emp = ( from e in dataContext.Employees join j in dataContext.Jobs on e.JobId equals j.JobId
                        select new {e.EmployeeId,e.EmployeeName,e.EmployeePhone,e.EmployeeSalary,j.JobDesc,e.EmployeeIsActive }).ToList();
            return emp;

        }



    }





}
