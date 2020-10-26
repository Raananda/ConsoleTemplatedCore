using Infrastructure_Layer.Interfaces.Business_Logic;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Services
{
    public class PrintService : IPrintService
    {
        private readonly ILogger<PrintService> _log;

        public PrintService(ILogger<PrintService> log)
        {
            _log = log;
        }
        public void Print(string msg)
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
