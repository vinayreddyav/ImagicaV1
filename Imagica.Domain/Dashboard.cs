using System;
using System.Collections.Generic;
using System.Text;

namespace Tralive.Domain
{
    public class DashboardTable
    {
        public string Country { get; set; }

        public Priority PriorityCount { get; set; }

        public Priority NonPriorityCount { get; set; }

        public PriorityTransaction PriorityTran { get; set; }

        public PriorityTransaction NonPriorityTran { get; set; }
    }

    public class PriorityTransaction
    {
        public List<TradeTransaction> High { get; set; }

        public List<TradeTransaction> Standard { get; set; }
    }

    public class Priority
    {
        public int High { get; set; }

        public int Standard { get; set; }
    }

    public class FilterCriteria
    {
        public List<string> StepIds { get; set; }

        public List<string> CustomerName { get; set; }

        public List<string> UserName { get; set; }
    }

    public class Aging
    {
        public bool Customer { get; set; }

        public bool TransactionValue { get; set; }

        public bool Time { get; set; }

        public bool Step { get; set; }

        public bool Red { get; set; }
    }
}
