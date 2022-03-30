using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valentyn.CovContra.Interfaces;

namespace Valentyn.CovContra.Implementations
{
    public class SendManager
    {
        protected Dictionary<string, ISendHandler<string, string>> map;
        //
    }
}
