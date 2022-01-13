﻿using Shered.Modeli;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shered.BiznisInterfejsi
{
    public interface IBazneStaniceBusiness
    {
        List<BaznaStanica> SveBazneStanice();
        bool DodajBaznaStanica(BaznaStanica bs);
        bool IzmeniBaznaStanica(BaznaStanica bs);
        bool ObrišiBaznaStanica(string id_stanice);
    }
}
