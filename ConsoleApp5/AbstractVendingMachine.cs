using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class AbstractVendingMachine
    {
        public abstract void AddProduct(Product pro);
        public abstract void AddMomeny(double kwota);
        public abstract void AddProduct(char kod, Product pro);

        public abstract void BuyProduct(char kod);

        public abstract void returnCoins();

    }
}
