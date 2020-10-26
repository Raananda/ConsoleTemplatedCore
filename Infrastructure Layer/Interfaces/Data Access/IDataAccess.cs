using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure_Layer.Interfaces.Data_Access
{
    public interface IDataAccess
    {
        void OpenConnection();
        void CloseConnection();       
    }
}
