﻿using FirstWebAPILink.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPILink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private RepositoryEmployee _repositoryEmployee;
        public EmployeeController(RepositoryEmployee repository)
        {
            _repositoryEmployee = repository;
        }
        [HttpGet("/ListAllEmployees")]
        public IEnumerable<EmpViewModel> ListAllEmployees()
        {
            List<Employee> employees = _repositoryEmployee.AllEmployees();
            IEnumerable<EmpViewModel> empList = _repositoryEmployee.Lister(employees);
            return empList;
        }
        [HttpGet("/FindEmployee")]
        public EmpViewModel FindEmployee(int id)
        {
            Employee employeeById = _repositoryEmployee.FindEmpoyeeById(id);
            EmpViewModel empList = _repositoryEmployee.Viewer(employeeById);
            return empList;
        }
        [HttpPost("/AddEmployee")]
        public string AddEmployee(EmpViewModel newEmployeeView)
        {
            Employee newEmployee = new Employee();
            newEmployee.FirstName = newEmployeeView.FirstName;
            newEmployee.LastName = newEmployeeView.LastName;
            newEmployee.BirthDate = newEmployeeView.BirthDate;
            newEmployee.HireDate = newEmployeeView.HireDate;
            newEmployee.Title = newEmployeeView.Title;
            newEmployee.City = newEmployeeView.City;
            newEmployee.ReportsTo = newEmployeeView.ReportsTo;
            int employeestatus = _repositoryEmployee.AddEmployee(newEmployee);
            if(employeestatus == 0)
            {
                return "Employee Not Added To Database Since it already exist";
            }
            else
            {
                return "Employee Added To Database";
            }
        }
        [HttpPut("/ModifyEmployee")]
        public Employee ModifyEmployee(int id, [FromBody] Employee newemployee)
        {
            Employee employee = _repositoryEmployee.FindEmpoyeeById(id);
            _repositoryEmployee.UpdateEmployee(newemployee);
            return newemployee;
        }
        [HttpDelete("/DeleteEmployee")]
        public string DeleteEmployee(int id)
        {
            int employeestatus = _repositoryEmployee.DeleteEmployee(id);
            if (employeestatus == 0)
            {
                return "Employee does not exist in the Database";
            }
            else
            {
                return "Employee Successfully Deleted";
            }
        }
    }
}
