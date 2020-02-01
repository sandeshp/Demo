﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace eip.dl.util
{
    public class RSAKeyValueElement : ConfigurationElement
    {
        public string InnerText { get; private set; }
        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
        {
            InnerText = reader.ReadElementContentAsString();
        }
    }
}
