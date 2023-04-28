﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateKnxProd.Model
{
    public partial class Parameter_T : INotifyPropertyChanged
    {
        [XmlIgnore]
        public ParameterType_T Type { get; set; }

        [XmlIgnore]
        public ObservableCollection<ParameterType_T> AllTypes { get; set; }
    }
}

