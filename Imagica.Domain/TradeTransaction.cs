using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Tralive.Domain
{
    public class TradeTransaction
    {
        [BsonId()]
        public ObjectId _id { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Customername { get; set; }
        public DateTime Date { get; set; }
        public string DealNumber { get; set; }
        public string Department { get; set; }
        public string Entity { get; set; }
        public string ExceededDate { get; set; }
        public string Item { get; set; }
        public string Itemprofile { get; set; }
        public decimal LocalEquivalent { get; set; }
        public string Owner { get; set; }
        public string Response { get; set; }
        public string Section { get; set; }
        public string Sender { get; set; }
        public string Status { get; set; }
        public string StepId { get; set; }
        public DateTime ValueDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int Version { get; set; }
    }
}
