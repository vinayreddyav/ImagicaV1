using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tralive.API.Application.Models;
using Tralive.Domain;
using System.Globalization;

namespace Tralive.API.Application
{
    public class Helper
    {
        
        private int _latestVersion = 1;
        public Helper(int latestVersion)
        {
            _latestVersion =latestVersion+1;
        }
        public Helper() { }
        //public IMapper TradeTransactionDTOToTradeTransaction
        //{
        //    get {
        //        var config = new MapperConfiguration(cfg =>
        //        {
        //        cfg.CreateMap<TradeTransactionDTO, TradeTransaction>()
        //        .ForMember(d => d.Date, s => s.MapFrom(m => DateTime.ParseExact(($"{m.date} {(m.time != null ? m.time : "00:00")}"),"dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture)))
        //        //.ForMember(d => d.ExceededDate, s => s.MapFrom(m => m.exceededdate !=null ? DateTime.ParseExact(m.exceededdate,"dd/MM/yyyy",CultureInfo.InvariantCulture) : DateTime.MinValue))
        //        .ForMember(d => d.ValueDate, s => s.MapFrom(m => m.valuedate != null ? DateTime.ParseExact(m.valuedate, "dd/MM/yyyy", CultureInfo.InvariantCulture) : DateTime.MinValue))
        //        .ForMember(d => d.Amount, s => s.MapFrom(m => Convert.ToDecimal(m.amount)))
        //        .ForMember(d => d.LocalEquivalent, s => s.MapFrom(m => Convert.ToDecimal(m.localequivalent)))
        //        .ForMember(d => d.CreatedBy, s => s.MapFrom(m => "Test"))//TODO: user who uploads excel )
        //        .ForMember(d => d.CreatedDate, s => s.MapFrom(m => DateTime.Now))
        //        .ForMember(d => d.Version, s => s.MapFrom(m => _latestVersion));
        //        });

        //        IMapper iMapper = config.CreateMapper();
        //        return iMapper;
        //    }
        //}

        //public IMapper TradeTransactionToTradeTransactionDTO
        //{
        //    get
        //    {
        //        var config = new MapperConfiguration(cfg =>
        //        {
        //            cfg.CreateMap<TradeTransaction, TradeTransactionDTO>()
        //            .ForMember(d => d.date, s => s.MapFrom(m => m.Date.ToString("dd/MM/yyyy HH:mm", DateTimeFormatInfo.InvariantInfo)))
        //            //.ForMember(d => d.ExceededDate, s => s.MapFrom(m => m.exceededdate !=null ? DateTime.ParseExact(m.exceededdate,"dd/MM/yyyy",CultureInfo.InvariantCulture) : DateTime.MinValue))
        //            .ForMember(d => d.valuedate, s => s.MapFrom(m => m.ValueDate.ToString("dd/MM/yyyy HH:mm", DateTimeFormatInfo.InvariantInfo)))
        //            .ForMember(d => d.amount, s => s.MapFrom(m => m.Amount.ToString()))
        //            .ForMember(d => d.localequivalent, s => s.MapFrom(m => m.LocalEquivalent.ToString()));
        //            //.ForMember(d => d.CreatedBy, s => s.MapFrom(m => "Test"))//TODO: user who uploads excel )
        //            //.ForMember(d => d.CreatedDate, s => s.MapFrom(m => DateTime.Now))
        //            //.ForMember(d => d.Version, s => s.MapFrom(m => _latestVersion));
        //        });

        //        IMapper iMapper = config.CreateMapper();
        //        return iMapper;
        //    }
        //}

        //public IMapper CustomerToCustomerDTO
        //{
        //    get
        //    {
        //        var config = new MapperConfiguration(cfg =>
        //        {
        //            cfg.CreateMap<Customers, CustomerDTO>()
        //            .ForMember(d => d.Id, s => s.MapFrom(m => m._id.ToString()));
        //        });
        //        IMapper iMapper = config.CreateMapper();
        //        return iMapper;
        //    }
        //}

        //public IMapper ConfigDTOToConfig
        //{
        //    get
        //    {
        //        var config = new MapperConfiguration(cfg =>
        //        {
        //            cfg.CreateMap<TradeConfiguration, TradeConfigurationDTO>();
        //        });
        //        IMapper iMapper = config.CreateMapper();
        //        return iMapper;
        //    }
        //}

        //public IMapper ConfigToConfigDTO
        //{
        //    get
        //    {
        //        var config = new MapperConfiguration(cfg =>
        //        {
        //            cfg.CreateMap<TradeConfigurationDTO, TradeConfiguration>()
        //            .ForMember(d => d._id, s => s.MapFrom(m => m.Id.ToString()));
        //        });
        //        IMapper iMapper = config.CreateMapper();
        //        return iMapper;
        //    }
        //}

        //public string GetCountryName(string countrycode)
        //{
        //    string countryName = String.Empty;
        //    switch (countrycode)
        //    {
        //        case Constants.HKCode:
        //            countryName = Constants.HK;
        //            break;
        //        case Constants.SGCode:
        //            countryName = Constants.SG;
        //            break;
        //        case Constants.TWCode:
        //            countryName = Constants.TW;
        //            break;
        //        case Constants.KRCode:
        //            countryName = Constants.KR;
        //            break;
        //        case Constants.JPCode:
        //            countryName = Constants.JP;
        //            break;
        //        default:
        //            break;
        //    }

        //    return countryName;
        //}


        ////todo: move to model layer
        //public DateTime GetISTDateTimeFormat(DateTime datetime, string zoneId)
        //{
        //    //TimeZoneInfo.GetSystemTimeZones()
        //    var ist = TimeZoneInfo.ConvertTime(Convert.ToDateTime(datetime.ToString()) , TimeZoneInfo.FindSystemTimeZoneById(zoneId), TimeZoneInfo.Local);
        //    return ist;
        //}
    }
}
