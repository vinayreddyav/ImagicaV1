using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using Imagica.Domain;
using Imagica.Persistence;

namespace Imagica.Persistence
{
    public class ImagicaRepository : IImagicaRepository
    {
        
        private DatabaseContext  _collections;

        public ImagicaRepository() { }
        public ImagicaRepository(string connectionString, string databaseName)
        {
            _collections = new DatabaseContext(connectionString, databaseName);
        }

        public AlternativeTitles FetchAlternativeTitles()
        {
            return _collections.AlternativeTitles
                .Find(Builders<AlternativeTitles>.Filter.Empty)
                .Sort(new BsonDocument { { "CreatedDate", -1 } })
                .ToList().FirstOrDefault();
           
        }

        public AlternativeValues FetchAlternativeValues()
        {
            return _collections.AlternativeValues
                .Find(Builders<AlternativeValues>.Filter.Empty)
                .Sort(new BsonDocument { { "CreatedDate", -1 } })
                .ToList().FirstOrDefault();
        }

        public bool SaveAlternativeTitles(AlternativeTitles alternativeTitles)
        {
            try
            {
                _collections.AlternativeTitles.InsertOneAsync(alternativeTitles);
            }
            catch (Exception)
            {
                throw;                
            }
            
            return true;
        }

        public bool SaveAlternativeValues(AlternativeValues alternativeValues)
        {
            try
            {
                _collections.AlternativeValues.InsertOneAsync(alternativeValues);
            }
            catch (Exception)
            {
                throw;
            }

            return true;
        }


        //public bool SaveTradeTransaction(List<TradeTransaction> tradeTransactions)
        //{
        //    //Save excel data
        //    _collections.Transaction.InsertManyAsync(tradeTransactions);


        //    //Get customers and add in master list
        //    List<Customers> custms = new List<Customers>();
        //    foreach (var item in tradeTransactions)
        //    {
        //        var cust = new Customers();
        //        cust.Name = item.Customername;
        //        custms.Add(cust);
        //    }
        //    SaveNewCustomers(custms);

        //    return false;
        //}

        //private void SaveNewCustomers(List<Customers> custms)
        //{
        //    IEnumerable<Customers> res = new List<Customers>();

        //    var cust = _collections.Customer
        //        .Find(Builders<Customers>.Filter.Empty)
        //        .ToList();

        //    if (cust != null && cust.Count > 0)
        //    {
        //        res = custms.Where(p => !cust.Any(y => y.Name == p.Name ));

        //        _collections.Customer.InsertManyAsync(res);

        //    }
        //    //First time insert - no values in customer collextion - insert with random priority
        //    else
        //    {
        //        _collections.Customer.InsertManyAsync(custms);
        //    }
        //}

        //public bool UpdateCustomers(List<Customers> customers)
        //{
        //    IEnumerable<Customers> res = new List<Customers>();

        //    var cust = _collections.Customer
        //        .Find(Builders<Customers>.Filter.Empty)
        //        .ToList();

        //    if(cust!=null && cust.Count>0)
        //    {
        //        res = customers.Where(p => !cust.Any(y => y.Name == p.Name && y.Priority ==p.Priority ));
        //        foreach (var item in res)
        //        {
        //            var filter = Builders<Customers>.Filter.Eq("Name", item.Name);
        //            var update = Builders<Customers>.Update.Set("Priority", item.Priority);
        //            _collections.Customer.UpdateOneAsync(filter, update);
        //        }
        //    }

        //    return false;
        //}

        //public List<string> GetCustomers()
        //{
        //    return _collections.Transaction
        //          .Find(Builders<TradeTransaction>.Filter.Empty)
        //         .ToList().Select(t => t.Customername).ToList().Distinct().ToList();
        //}

        //public List<string> GetSteps()
        //{
        //    return _collections.Transaction
        //          .Find(Builders<TradeTransaction>.Filter.Empty)
        //         .ToList().Select(t => t.StepId).ToList().Distinct().ToList();
        //}

        //public bool SaveTradeConfiguration(TradeConfiguration config)
        //{
        //     _collections.Configuration.InsertOneAsync(config);
        //    return false;
        //}

        //public TradeConfiguration GetTradeConfiguration()
        //{
        //    return _collections.Configuration
        //         .Find(Builders<TradeConfiguration>.Filter.Empty)
        //         .Sort(new BsonDocument { { "_id", -1 } })
        //         .ToList().FirstOrDefault();
        //}

        //public List<TradeTransaction> GetLatestTransactions(int version)
        //{
        //    var filter_id = Builders<TradeTransaction>.Filter.Eq("Version", version);
        //    return _collections.Transaction
        //        .Find(filter_id)
        //        .ToList();
        //}
    }
}
