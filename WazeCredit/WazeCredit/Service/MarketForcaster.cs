using wazeCredit.Models;

namespace wazeCredit.Service
{
    public class MarketForcaster
    {
        public MarketResult GetMarketPrecondition()
        {
            
            return new MarketResult
            {
                MarketCondition = Models.MarketCondition.StableUp

            };
        }

    }

    public class MarketResult
    {
        public MarketCondition MarketCondition { get; set; }

    }
}