using System;

namespace Valentyn.CovContra
{
    public class Class1
    {
        // list of string
        // list of int

        // classofcourse
        // classofsubject

        IMessageBody body = new MessageBodyPrg();
        IResponse response = new ResponsePrg();
        SendManagerV manager = new SendManagerV(body, response);
    }
}
