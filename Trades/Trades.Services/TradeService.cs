using Trades.Model.Interfaces;
using Trades.Services.Interfaces;

namespace Trades.Services
{
    public sealed class TradeService : ITradeService
    {
        private const string lowRiskCategory = "LOWRISK";
        private const string mediumRiskCategory = "MEDIUMRISK";
        private const string highRiskCategory = "HIGHRISK";

        public string GetCategory(ITrade trade)
        {
            if (trade.Value < 1000000 && trade.ClientSector == "Public") return lowRiskCategory;
            if (trade.Value > 1000000 && trade.ClientSector == "Public") return mediumRiskCategory;
            if (trade.Value > 1000000 && trade.ClientSector == "Private") return highRiskCategory;

            return "";
        }
    }
}
