﻿using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace FirstWebAPILink.Models
{
    public class RepositoryEmployee
    {
        private NorthwindContext _context; 
        public RepositoryEmployee(NorthwindContext context)
        {
            _context = context;
        }
        public List<Employee> AllEmployees()
        {
            return _context.Employees.ToList();
        }
        public Employee FindEmpoyeeById(int id)
        {
            return _context.Employees.Find(id);
        }
        public int AddEmployee(Employee newEmployee)
        {
            _context.Employees.Add(newEmployee);
            return _context.SaveChanges();
        }
        public int ModifyEmployee(int id)
        {
            Employee emp = _context.Employees.Find(id);
            _context.Employees.Update(emp);
            return _context.SaveChanges();
        }
        public int DeleteEmployee(int id)
        {
            Employee emp = _context.Employees.Find(id);
            _context.Employees.Remove(emp);
            return _context.SaveChanges();
        }
    }
}
