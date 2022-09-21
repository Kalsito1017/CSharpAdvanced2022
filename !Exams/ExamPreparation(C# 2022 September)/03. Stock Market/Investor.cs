using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        
        public List<Stock> Portfolio { get; set; }
        public string Fullname { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        public Investor(string fullname, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            Portfolio = new List<Stock>();  
            Fullname = fullname;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
        }
        public int Count => Portfolio.Count;
        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && this.MoneyToInvest >= stock.PricePerShare)
            {
                this.Portfolio.Add(stock);
                this.MoneyToInvest -= stock.PricePerShare;
            }
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            if (Portfolio.Any(s => s.CompanyName == companyName) == false)
            {
                return $"{companyName} does not exist.";

            }
            if (sellPrice < Portfolio.First(s => s.CompanyName == companyName).PricePerShare)
            {
                return $"Cannot sell {companyName}.";
            }
            Portfolio.Remove(Portfolio.First(s => s.CompanyName == companyName));
            this.MoneyToInvest += sellPrice;
            return $"{companyName} was sold.";

        }
        public Stock FindStock(string companyName)
        {
            return Portfolio.FirstOrDefault(s => s.CompanyName == companyName);
        }
        public Stock FindBiggestCompany()
        {
            return Portfolio.OrderByDescending(s => s.MarketCapitalization).FirstOrDefault();

        }
        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The investor {Fullname} with a broker {BrokerName} has stocks:");
            foreach (var stock in Portfolio)
            {
                sb.AppendLine(stock.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
