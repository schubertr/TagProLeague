﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace TagProLeague.Models
{
    public class Series
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? Date { get; set; }
        public string Result { get; set; }
        public string Season { get; set; }
        public string Format { get; set; }
        public string Video { get; set; }
        public List<string> SubSeries { get; set; }
        public List<string> Games { get; set; }
        public List<string> Players { get; set; }
        public List<string> Teams { get; set; }
        public List<string> Statlines { get; set; }
        public string TotalStatline { get; set; }
    }
}
