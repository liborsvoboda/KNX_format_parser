﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateKnxProd.Model
{
    public partial class ParameterType_TTypeNumber : INotifyPropertyChanged, IGetByteSize
    {
        [XmlIgnore]
        public uint SizeInByte
        {
            get
            {
                return 4;
            }
        }
    }
}

