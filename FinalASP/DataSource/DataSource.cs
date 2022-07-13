using FinalASP.Models;

namespace FinalASP.DataSource
{
    public class DataSource : IDataSource
    {

        public List<Product> SQLList = new List<Product> {
        new Product { Nombre = "Nvidia RTX 3090 Ti", StockActual = 1, StockMin = 50 },
        new Product { Nombre = "Nvidia RTX 3090", StockActual = 100, StockMin = 50 },
        new Product { Nombre = "AMD Radeon RX 6950 XT", StockActual = 1000, StockMin = 50 },
        new Product { Nombre = "AMD Radeon RX 6900 XT", StockActual = 2, StockMin = 50 },
        new Product { Nombre = "Nvidia RTX 3080 Ti", StockActual = 200, StockMin = 50 },
        new Product { Nombre = "AMD Radeon RX 6800 XT", StockActual = 2000, StockMin = 80 },
        new Product { Nombre = "Nvidia RTX 3070 Ti", StockActual = 3, StockMin = 80 },
        new Product { Nombre = "AMD Radeon RX 6750 XT", StockActual = 30, StockMin = 100 },
        new Product { Nombre = "Nvidia RTX 3060 Ti", StockActual = 300, StockMin = 1000 },
        new Product { Nombre = "Nvidia GTX 1660 Super", StockActual = 300, StockMin = 100 },

        };


        public List<Product> GetAll()
        {
            return SQLList;
        }
    }
}
