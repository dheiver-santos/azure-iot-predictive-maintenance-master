// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace RClient.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class InputParameters
    {
        /// <summary>
        /// Initializes a new instance of the InputParameters class.
        /// </summary>
        public InputParameters() { }

        /// <summary>
        /// Initializes a new instance of the InputParameters class.
        /// </summary>
        public InputParameters(int? cycle = default(int?), double? s9 = default(double?), double? s11 = default(double?), double? s14 = default(double?), double? s15 = default(double?))
        {
            Cycle = cycle;
            S9 = s9;
            S11 = s11;
            S14 = s14;
            S15 = s15;
        }

        /// <summary>
        /// integer
        /// </summary>
        [JsonProperty(PropertyName = "cycle")]
        public int? Cycle { get; set; }

        /// <summary>
        /// numeric
        /// </summary>
        [JsonProperty(PropertyName = "s9")]
        public double? S9 { get; set; }

        /// <summary>
        /// numeric
        /// </summary>
        [JsonProperty(PropertyName = "s11")]
        public double? S11 { get; set; }

        /// <summary>
        /// numeric
        /// </summary>
        [JsonProperty(PropertyName = "s14")]
        public double? S14 { get; set; }

        /// <summary>
        /// numeric
        /// </summary>
        [JsonProperty(PropertyName = "s15")]
        public double? S15 { get; set; }

    }
}
