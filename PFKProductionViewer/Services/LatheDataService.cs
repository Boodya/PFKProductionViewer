using Microsoft.Extensions.Configuration;
using PFKProductionViewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PFKProductionViewer.Services
{
    public class LatheDataService : IDisposable
    {
        public LatheContext LatheContext { get; private set; }

        public LatheDataService(IConfiguration config)
        {
            LatheContext = new LatheContext(
                config.GetConnectionString("RauteVE"));
        }

        public void Dispose()
        {
            if (LatheContext != null)
                LatheContext.Dispose();
        }
    }
}
