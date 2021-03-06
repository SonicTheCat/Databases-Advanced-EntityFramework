﻿namespace Stations.DataProcessor.Dto.ImportDtos
{
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [XmlType("Card")]
    public class TicketCardDto
    {
        [Required]
        [MaxLength(128)]
        [XmlAttribute("Name")]
        public string Name { get; set; }
    }
}