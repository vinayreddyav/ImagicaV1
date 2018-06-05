using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tralive.API.Application.Models;
using Tralive.Domain;
using AutoMapper;
using Tralive.API.Application;
using Microsoft.Extensions.Options;
using Tralive.Persistence;
using System.Globalization;
using Imagica.API.Application.Models;

namespace Tralive.API.Controllers
{
    
    [Route("api/[controller]")]
    
    public class ImagicaController : Controller
    {
        private ConfigSettings _config;
        private IImagicaRepository _repository;
        private Helper _helper;
        TradeConfiguration _tradeConfig;
        public ImagicaController(ConfigSettings config)
        {
            _config = config;
            _repository = new ImagicaRepository(_config.ConnectionString, _config.DatabaseName);
            _helper = new Helper();
            _tradeConfig = _repository.GetTradeConfiguration();
        }
        
        [HttpPost]
        [Route("SaveAlternateTitles")]
        public void SaveTradeTransaction([FromBody] RootObject alternateTitles)
        {
            try
            {
                //var latestVersion = _repository.GetLatestVersion();
                //var destination = new Helper(latestVersion).TradeTransactionDTOToTradeTransaction.Map<List<TradeTransactionDTO>, List<TradeTransaction>>(transactionDTO);
                //var res = _repository.SaveTradeTransaction(destination);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpPost]
        [Route("SaveAlternateValues")]
        public void SaveAlternativeValues([FromBody] RootObjectValues alternateValues)
        {
            try
            {
                //var latestVersion = _repository.GetLatestVersion();
                //var destination = new Helper(latestVersion).TradeTransactionDTOToTradeTransaction.Map<List<TradeTransactionDTO>, List<TradeTransaction>>(transactionDTO);
                //var res = _repository.SaveTradeTransaction(destination);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet("GetCustomers")]       
        public Task<IEnumerable<string>> GetCustomers()
        {
            List<string> cust = new List<string>();
            try
            {
                cust = _repository.GetCustomers();
                foreach (var item in _repository.GetTradeConfiguration().PriorityCustomers)
                {
                    if (!cust.Contains(item))
                        cust.Add(item);
                } 
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Task.FromResult<IEnumerable<string>>(cust);
        }

        
    }
    
}