﻿namespace CarDealer.Dtos.ExerciseTwoDto
{
    using System.Xml.Serialization;

    [XmlType("car")]
    public class FerrariCarDto
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("model")]
        public string Model { get; set; }

        [XmlAttribute("travelled-distance")]
        public long TravelledDistance{ get; set; }
    }
}