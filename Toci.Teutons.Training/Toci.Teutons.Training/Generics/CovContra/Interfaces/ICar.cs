using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.Training.Generics.CovContra.Interfaces
{                                                      // Dictionary<Engine, Gearbox>
    public interface ICar<out TEngine, in TGearbox> // Porsche<GasEngine, AutoamticGearbox> // Skoda<DieselEngine, ManualGearbox>
    {                                               
    }

   //class DoesNotWork<dziedziczacy> : cos<bazowy>
}
