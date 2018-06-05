using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tralive.Domain
{
    public class Customers
    {
        [BsonId()]
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public bool Priority { get; set; }
    }
}
