﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spacetime.Core
{
    public class SpacetimeRequest
    {
        public int Id { get; set; }
        public SpacetimeType Type { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string? RequestBody { get; set; }
        public string? ResponseBody { get; set; } = "No response.";
        public IEnumerable<HeaderDto> Headers { get; set; }
        public string Method { get; set; } = "get";
        public long ElapsedMs { get; set; }
        public SpacetimeStatus Status { get; set; }
        public string StatusCode { get; set; }
        public string ResponseTimeText => $"{ElapsedMs}ms";
        public string GetName()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                return URL;
            }

            return Name;
        }
    }

    public enum SpacetimeType
    {
        NotSet,
        REST,
        gRPC,
        WebSockets
    }
}