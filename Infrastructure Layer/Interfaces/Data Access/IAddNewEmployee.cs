using Infrastructure_Layer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure_Layer.Interfaces.Data_Access
{
    public interface IAddNewEmployee
    {
        void Add(EmployeeDTO employeeDTO);
    }
}
