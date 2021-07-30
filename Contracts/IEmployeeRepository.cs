﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync(Guid companyId, bool trackChanges);
        Task<Employee> GetEmployeeAsync(Guid companyId, Guid id, bool trackChanges);
        void CreateEmployeeForCompany(Guid companyId, Employee employee); // Not making any changes in the database. All we're doing is changing the state of the entity.
        void DeleteEmployee(Employee employee); // Not making any changes in the database. All we're doing is changing the state of the entity.
    }
}
