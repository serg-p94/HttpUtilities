using System.Threading.Tasks;
using System.Linq;
using static System.Console;

namespace Finance.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                var apiService = new CurrencyApiService();

                var allCurrencies = await apiService.GetAllCurrencies();
                var usd = allCurrencies.Find(c =>
                    string.Equals(c.Abbreviation, "USD", System.StringComparison.OrdinalIgnoreCase));
                var usdInfo = await apiService.GetCurrencyRate(usd.CurrencyId);
                WriteLine(usdInfo);
            }).Wait();
        }
    }
}
