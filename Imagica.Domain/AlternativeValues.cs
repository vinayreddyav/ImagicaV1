using System;
using System.Collections.Generic;
using System.Text;

namespace Imagica.Domain
{
    public class OPTIONTYPE
    {
        public List<string> C { get; set; }
        public List<string> P { get; set; }
    }

    public class CURRENCY
    {
        public List<string> CHF { get; set; }
        public List<string> GBP { get; set; }
        public List<string> AUD { get; set; }
        public List<string> JPY { get; set; }
        public List<string> DKK { get; set; }
        public List<string> EUR { get; set; }
        public List<string> HKD { get; set; }
        public List<string> ILS { get; set; }
        public List<string> INR { get; set; }
        public List<string> NOK { get; set; }
        public List<string> KRW { get; set; }
        public List<string> SEK { get; set; }
        public List<string> SGD { get; set; }
        public List<string> TRY { get; set; }
        public List<string> TWD { get; set; }
        public List<string> USD { get; set; }
    }

    public class BROKERFEESCCY
    {
        public List<string> CHF { get; set; }
        public List<string> GBP { get; set; }
        public List<string> AUD { get; set; }
        public List<string> JPY { get; set; }
        public List<string> DKK { get; set; }
        public List<string> EUR { get; set; }
        public List<string> HKD { get; set; }
        public List<string> ILS { get; set; }
        public List<string> INR { get; set; }
        public List<string> NOK { get; set; }
        public List<string> KRW { get; set; }
        public List<string> SEK { get; set; }
        public List<string> SGD { get; set; }
        public List<string> TRY { get; set; }
        public List<string> TWD { get; set; }
        public List<string> USD { get; set; }
    }

    public class BUYSELL
    {
        public List<string> BUY { get; set; }
        public List<string> SELL { get; set; }
    }



    public class RootObjectValues
    {
        public OPTIONTYPE OPTION_TYPE { get; set; }
        public CURRENCY CURRENCY { get; set; }
        public BROKERFEESCCY BROKER_FEES_CCY { get; set; }
        public BUYSELL BUY_SELL { get; set; }
        public Object UNDERLYING_NAME { get; set; }
    }

}
