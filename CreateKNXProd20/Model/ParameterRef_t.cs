﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateKnxProd.Model
{
    public partial class ParameterRef_T : INotifyPropertyChanged
    {
        [XmlIgnore]
        public Parameter_T Parameter { get; set; }
    }
}

