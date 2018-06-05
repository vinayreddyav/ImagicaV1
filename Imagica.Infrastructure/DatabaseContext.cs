using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using Imagica.Domain;


namespace Imagica.Persistence
{
    public class DatabaseContext
    {
        private readonly IMongoDatabase database;
        
        public DatabaseContext(string connectionString, string databaseName)
        {
            database = new MongoClient(connectionString).GetDatabase(databaseName);
        }

        //public IMongoCollection<TradeTransaction> Transaction
        //{
        //    get
        //    {
        //        return database.GetCollection<TradeTransaction>(MonogdbCollectionName.Transaction);
        //    }
        //}

        //public IMongoCollection<Customers> Customer
        //{
        //    get
        //    {
        //        return database.GetCollection<Customers>(MonogdbCollectionName.Customer);
        //    }
        //}

        //public IMongoCollection<TradeConfiguration> Configuration
        //{
        //    get
        //    {
        //        return database.GetCollection<TradeConfiguration>(MonogdbCollectionName.Configuration);
        //    }
        //}
    }
}
