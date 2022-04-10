using System;
using Toci.Earrai.Warehouse.Interfaces;
using Toci.Earrai.Warehouse.Models;

namespace Toci.Earrai.Warehouse.Porch
{
    public class PorchWhProduct : IWhPRoduct
    {
        public IProduct GetProductById(int id)
        {
            return new Product();
        }
    }
}
