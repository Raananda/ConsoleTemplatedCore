using Infrastructure_Layer.DataTransferObjects;
using Infrastructure_Layer.Interfaces.Business_Logic;
using Infrastructure_Layer.Interfaces.Data_Access;
using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace BusinessLogicLayer
{
    public class MainBusinessLogic : IMainBusinessLogic
    {
        private readonly ILogger _log;
        private readonly IConfiguration _config;
        private readonly IDataAccess _dataAccess;
        private readonly IEmployeeService _employeeService;

        private EmployeeDTO _employeeDTO;

        public MainBusinessLogic(
            ILogger<MainBusinessLogic> log,
            IConfiguration config,
            IDataAccess dataAccess,
            IEmployeeService employeeService
            )
        {
            _log = log;
            _config = config;
            _dataAccess = dataAccess;
            _employeeService = employeeService;

            //// Get value from appsettings.json
            //var Value1 = _config.GetValue<int>("SomeKey");
            //var Value2 = _config.GetValue<int>("SomeSection:Somekey");
        }

        public void Run()
        {
            try
            {
                _log.LogInformation("Run");

                //Run Employee service
            //    _employeeDTO = _employeeService.InsertNames("Raanan", "Dalal");

                _dataAccess.OpenConnection();

             //   throw new Exception("132");

            }

            catch (Exception ex)
            {
                _log.LogError(ex,"");
            }

            finally
            {
                _dataAccess.CloseConnection();
            }
        }
    }
}
