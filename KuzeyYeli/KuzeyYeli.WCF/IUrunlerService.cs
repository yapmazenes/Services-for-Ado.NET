﻿using KuzeyYeli.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KuzeyYeli.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUrunlerService" in both code and config file together.
    [ServiceContract]
    public interface IUrunlerService:IService<UrunDTO>
    {
       
        
    }
}
