using System;
using Toci.Earrai.Warehouse.Interfaces;
using Toci.Earrai.Warehouse.Models;

namespace Toci.Earrai.Warehouse.BackYard
{
    public class ByWhProduct : IWhPRoduct
    {
        public IProduct GetProductById(int id)
        {
            return new Product();
        }
    }
}
