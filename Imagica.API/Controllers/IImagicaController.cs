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
        public Task<bool> SaveTradeTransaction([FromBody] AlternativeTitles alternateTitles)
        {
            bool res = false;
            try
            {
                //Save the user TODO: Get login userid
                alternateTitles.CreatedBy = "Admin";
                alternateTitles.CreatedDate = DateTime.Now;
                res = _repository.SaveAlternativeTitles(alternateTitles);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Task.FromResult<bool>(res);
        }


        [HttpPost]
        [Route("SaveAlternateValues")]
        public Task<bool> SaveAlternativeValues([FromBody] AlternativeValues alternateValues)
        {
            bool res = false;
            try
            {
                //Save the user TODO: Get login userid
                alternateValues.CreatedBy = "Admin";
                alternateValues.CreatedDate = DateTime.Now;
                res = _repository.SaveAlternativeValues(alternateValues);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Task.FromResult<bool>(res);
        }


        [HttpGet("FetchAlternativeTitles")]
        public Task<AlternativeTitles> FetchAlternativeTitles()
        {
            AlternativeTitles res = new AlternativeTitles();
            try
            {
               res = _repository.FetchAlternativeTitles();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Task.FromResult<AlternativeTitles>(res);
        }


        [HttpGet("FetchAlternativeValues")]
        public Task<AlternativeValues> FetchAlternativeValues()
        {
            AlternativeValues res = new AlternativeValues();
            try
            {
                res = _repository.FetchAlternativeValues();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Task.FromResult<AlternativeValues>(res);
        }





    }
    
}