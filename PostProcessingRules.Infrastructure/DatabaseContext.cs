using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using PostProcessingRules.Domain;


namespace PostProcessingRules.Persistence
{
    public class DatabaseContext
    {
        private readonly IMongoDatabase database;
        
        public DatabaseContext(string connectionString, string databaseName)
        {
            database = new MongoClient(connectionString).GetDatabase(databaseName);
        }



        public IMongoCollection<AlternativeTitles> AlternativeTitles
        {
            get
            {
                return database.GetCollection<AlternativeTitles>(MonogdbCollectionName.AlternativeTitles);
            }
        }

        public IMongoCollection<AlternativeValues> AlternativeValues
        {
            get
            {
                return database.GetCollection<AlternativeValues>(MonogdbCollectionName.AlternativeValues);
            }
        }

       
    }
}
