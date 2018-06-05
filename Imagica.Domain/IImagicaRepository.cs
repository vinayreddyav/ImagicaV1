using System;
using System.Collections.Generic;
using System.Text;

namespace Tralive.Domain
{
    public interface IImagicaRepository
    {
        bool SaveTradeTransaction(List<TradeTransaction> tradeTransactions);

        int GetLatestVersion();

        bool UpdateCustomers(List<Customers> customers);

        List<string> GetCustomers();

        List<string> GetSteps();

        bool SaveTradeConfiguration(TradeConfiguration tradeTransactions);

        TradeConfiguration GetTradeConfiguration();

        List<TradeTransaction> GetLatestTransactions(int version);

    }
}
