﻿using System;
using System.Xml.Serialization;

namespace Ies.Logo.DataType.Infrastructure
{
    [Serializable]
    public enum Dbop : byte
    {
        [XmlEnum("INS")]
        INS,
        [XmlEnum("UPD")]
        UPD
    }
}
