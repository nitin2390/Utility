using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Utility
{
    [XmlRoot(ElementName = "Truck")]
    public class Truck
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "DateTime")]
        public string DateTime { get; set; }
        [XmlElement(ElementName = "FilePath")]
        public string FilePath { get; set; }
        [XmlElement(ElementName = "Weight")]
        public string Weight { get; set; }
        [XmlElement(ElementName = "Deliminator")]
        public string Deliminator { get; set; }
    }
}
