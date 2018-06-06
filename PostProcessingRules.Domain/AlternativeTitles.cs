using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostProcessingRules.Domain
{
    public class Alternate
    {
        public List<string> ALL { get; set; }
        public List<string> EquityListedOption { get; set; }
        public List<string> EquityFuture { get; set; }
        public List<string> EquitySecurity { get; set; }
    }

    public class SinglePerDBEntry
    {
        public string EquityListedOption { get; set; }
        public string EquityFuture { get; set; }
        public string EquitySecurity { get; set; }
    }



    public class Base
    {
        public Alternate Alternate { get; set; }
        public string Type { get; set; }
        public string SinglePerDocument { get; set; }
        public string SinglePerInstrument { get; set; }
        public SinglePerDBEntry SinglePerDBEntry { get; set; }
        public string InScope { get; set; }
    }


    public class AlternativeTitles
    {
        [BsonId()]
        public ObjectId _id { get; set; }
        public Base TRADE_DATE { get; set; }
        public Base UNDERLYING_NAME { get; set; }
        public Base CURRENCY { get; set; }
        public Base PRODUCT_QUANTITY { get; set; }
        public Base PRODUCT_PRICE { get; set; }
        public Base MATURITY_DATE { get; set; }
        public Base OPTION_TYPE { get; set; }
        public Base STRIKE { get; set; }
        public Base EXERCISE_TYPE { get; set; }
        public Base BROKER_FEES { get; set; }
        public Base BROKER_FEES_CCY { get; set; }
        public Base AMOUNT { get; set; }
        public Base LOT_SIZE { get; set; }
        public Base BUY_SELL { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
