﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KuzeyYeli.WCF
{
    using Repository;
    using DTO;
    using Entity;
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UrunlerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UrunlerService.svc or UrunlerService.svc.cs at the Solution Explorer and start debugging.
    public class UrunlerService :ServiceBase<UrunRepository,Urunler,UrunDTO>
    {
        public void DoWork()
        {
        }
    }
}
