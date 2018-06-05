using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tralive.API.Application.Models;
using Imagica.Domain;
using AutoMapper;
using Tralive.API.Application;
using Microsoft.Extensions.Options;
using Imagica.Persistence;
using System.Globalization;


namespace Imagica.API.Controllers
{
    
    [Route("api/[controller]")]
    
    public class ImagicaController : Controller
    {
        private ConfigSettings _config;
        private IImagicaRepository _repository;
       
        public ImagicaController(ConfigSettings config)
        {
            _config = config;
            _repository = new ImagicaRepository(_config.ConnectionString, _config.DatabaseName);
         
        }
        
        [HttpPost]
        [Route("SaveAlternateTitles")]
        public Task<bool> SaveTradeTransaction([FromBody] RootObject alternateTitles)
        {
            bool res = false;
            try
            {
                //var res = _repository.SaveTradeTransaction(destination);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Task.FromResult<bool>(res);
        }


        [HttpPost]
        [Route("SaveAlternateValues")]
        public Task<bool> SaveAlternativeValues([FromBody] RootObjectValues alternateValues)
        {
            bool res = false;
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
            return Task.FromResult<bool>(res);
        }


        

        
    }
    
}