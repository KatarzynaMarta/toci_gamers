using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valentyn.CovContra.Interfaces
{
    public interface ISendHandler<in TMessageBody, out TResponse>
    {
        TResponse Send(TMessageBody messageBody);
    }
}
