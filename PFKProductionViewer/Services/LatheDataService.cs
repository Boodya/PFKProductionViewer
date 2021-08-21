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
        private LatheContext _context;
        private IConfiguration _config;
        private Thread _dataFetchThread;
        private bool _isDataFetching;
        private static readonly object _locker = new object();
        private static List<Action<LatheContext>> _subsciptions;

        public LatheDataService(IConfiguration config)
        {
            _dataFetchThread = new Thread(FetchDataThreadCode);
            _dataFetchThread.Start();
            _isDataFetching = true;
            _config = config;
            _subsciptions = new List<Action<LatheContext>>();
        }

        public LatheContext GetContext()
        {
            lock(_locker)
            {
                return _context;
            }
        }

        public List<BinsActual> GetAllBins()
        {
            lock(_locker)
                return _context.BinsActuals.ToList();
        }

        public List<ShiftActual> GetAllShiftsActual()
        {
            lock (_locker)
                return _context.ShiftActuals.ToList();
        }

        public List<ShiftPreviou> GetAllShiftsPrevious()
        {
            lock (_locker)
                return _context.ShiftPrevious.ToList();
        }

        public void SubscribeToDataUpdate(Action<LatheContext> onDataUpdate)
        {
            _subsciptions.Add(onDataUpdate);
        }
        
        public void ProcessSubscribers()
        {
            foreach(var subscriber in _subsciptions)
            {
                subscriber.Invoke(_context);
            }
        }

        private void FetchDataThreadCode()
        {
            while(_isDataFetching)
            {
                lock(_locker)
                {
                    _context = new LatheContext(
                        _config.GetConnectionString("RauteVE"));
                }
                ProcessSubscribers();
                Thread.Sleep(1000);
            }
        }

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
            _isDataFetching = false;
        }
    }
}
