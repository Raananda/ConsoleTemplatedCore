﻿using Infrastructure_Layer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure_Layer.Interfaces.Business_Logic
{
    public interface IEmployeeService
    {
        EmployeeDTO InsertNames(string Firstname, string LastName);
    }
}
