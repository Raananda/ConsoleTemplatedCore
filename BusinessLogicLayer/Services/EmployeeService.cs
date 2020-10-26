using Infrastructure_Layer.DataTransferObjects;
using Infrastructure_Layer.Interfaces.Business_Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeDTO InsertNames(string Firstname, string LastName)
        {
            EmployeeDTO Response = new EmployeeDTO
            {
                FirstName = Firstname,
                LastName = LastName
            };

            return Response;
        }
    }
}
