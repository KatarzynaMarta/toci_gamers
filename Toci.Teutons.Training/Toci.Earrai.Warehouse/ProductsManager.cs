using System;
using Toci.Earrai.Warehouse.Interfaces;

namespace Toci.Earrai.Warehouse
{
    public class ProductsManager
    {
        protected IWhPRoduct ProductLogic;

        public ProductsManager(IWhPRoduct productLogic)
        {
            ProductLogic = productLogic;
        }

        public void Dupa()
        {
           // ProductLogic.GetProductById
        }
    }
}
