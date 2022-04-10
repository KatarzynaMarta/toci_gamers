using System;
using Toci.Earrai.Warehouse.Models;

namespace Toci.Earrai.Warehouse.Interfaces
{
    public interface IWhPRoduct
    {
        IProduct GetProductById(int id);
    }
}
