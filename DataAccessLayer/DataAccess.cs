using BusinessLogicLayer;
using Infrastructure_Layer.DataTransferObjects;
using Infrastructure_Layer.Interfaces.Data_Access;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace DataAccessLayer
{
    public class DataAccess : IDataAccess, IAddNewEmployee
    {

        private string _connectionString;
        private readonly ILogger<MainBusinessLogic> _log;
        private readonly IConfiguration _config;

        public DataAccess(ILogger<MainBusinessLogic> log, IConfiguration config)
        {
            _log = log;
            _config = config;

            // Get connection string from appsetting.json file
            _connectionString = _config.GetConnectionString("Default");
        }
        public void OpenConnection()
        {
            try
            {
            }
            catch (Exception ex)
            {
                _log.LogError(ex, "");
            }
        }

        public void CloseConnection()
        {
        }

        public void Add(EmployeeDTO employeeDTO)
        {
            try
            {
            }
            catch (Exception ex)
            {
                _log.LogError(ex, "");
            }
        }
    }
}
