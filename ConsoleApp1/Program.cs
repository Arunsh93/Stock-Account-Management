using System;

namespace StockManagement

{
    class Program
    {
        static void Main(string[] args)
        {
            FetchStocksValue fetchStocksValue = new FetchStocksValue();
            fetchStocksValue.CalculateEachStockValue();
            fetchStocksValue.CalculateTotalStockValue();
            Console.Read();
        }
    }
}
