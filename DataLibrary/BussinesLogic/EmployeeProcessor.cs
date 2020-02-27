using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BussinesLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int EmployeeId,string firstName,string lastName,string email)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = EmployeeId,
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };

            string sql = @"insert into dbo.Employee(EmployeeId,FirstName,LastName,Email) values(@EmployeeId,@FirstName,@LastName,@Email);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = "select EmployeeId,FirstName,LasName,Email from dbo.Employee";
            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
