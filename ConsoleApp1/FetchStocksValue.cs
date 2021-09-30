using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StockManagement
{
    class FetchStocksValue
    {
        Stocks stockDetails = JsonConvert.DeserializeObject<Stocks>(File.ReadAllText(@"D:/Json/Stocks.json"));

        public void CalculateEachStockValue()
        {
            int price = 0, noOfShares = 0, eachStockValue = 0;
            foreach (var stockItem in stockDetails.StockPortfolio)
            {
                Console.WriteLine("-----------------------Calulation Of Each Stock Value------------------");
                price = stockDetails.SharePrice;
                noOfShares = stockDetails.Valume;
                Console.WriteLine($"Name : {stockItem.Name}\nVolume : {stockItem.Valume}\nSharePrice: {stockItem.SharePrice}");
                eachStockValue = price * noOfShares;
                Console.WriteLine("The Total Value of Stock for " + stockDetails.Name + " is " + eachStockValue);
            }
        }

        public void CalculateTotalStockValue()
        {
            int price = 0, noOfShares = 0, eachStockValue = 0, totalStockValue = 0;
            foreach (var stockItem in stockDetails.StockPortfolio)
            {
                Console.WriteLine("-----------------------Calulation Of Total Stock Value------------------");
                price = stockDetails.SharePrice;
                noOfShares = stockDetails.Valume;
                eachStockValue = price * noOfShares;
                totalStockValue += eachStockValue;
            }
            Console.WriteLine("Value of the Total Stock Value is: " + totalStockValue);
        }
    }
}
