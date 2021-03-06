﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace TagProLeague.Models
{
    public class Map
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Games { get; set; }
        public List<string> Statlines { get; set; }
        public string TotalStatline { get; set; }
    }
}
