using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valentyn.CovContra.Interfaces
{
    public interface ISendHandler<TMessageBody, TResponse>
    {
        TResponse Send(TMessageBody messageBody);
    }
}
