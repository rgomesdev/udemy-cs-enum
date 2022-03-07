using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Entities.Enums
{
    enum OrderStatus : int
        //O :int se trata de uma derivação de tipos, o orderstatus é uma derivação do tipo Int
    {
        //se não for informado um número, será considerado sequencial
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}
