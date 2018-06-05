using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tralive.Domain
{
    public class TradeConfiguration
    {
        [BsonId()]
        public ObjectId _id { get; set; }
        public decimal HKD { get; set; }

        public decimal SGD { get; set; }

        public decimal TWD { get; set; }

        public decimal KRW { get; set; }

        public decimal JPY { get; set; }
        public decimal TransactionInTime { get; set; }

        public decimal TransactionValue { get; set; }

        public List<string> PriorityCustomers { get; set; }

        public List<string> PriorityStepIds { get; set; }

        public DateTime CreatedDatetime
        {
            get
            {
                return DateTime.Now;
            }
        }
        public string CreatedBy
        {
            get
            {
                return "test";
            }
        }
    }
}
