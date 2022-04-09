using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Teutons.Training.Generics.CovContra.Interfaces;

namespace Toci.Teutons.Training.Generics.CovContra.Implementations
{
    public class Car<TEngine, TGearbox>  : ICar<TEngine, TGearbox>
    {
    }

    public class Porsche : Car<GasEngine, Gearbox>
    {
        
    }

    public class Showdown
    {
        ICar<Engine, AutomaticGearbox> p = new Porsche();

        //Dictionary<>
    }
}
