using DiGi.Communication.Enums;
using DiGi.Communication.Interfaces;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Communication.Classes
{
    /// <summary>
    /// Represents an antenna within the communication system, specifying its spatial location and the set of functions it supports.
    /// </summary>
    public class Antenna : GuidObject, IAntenna
    {
        [JsonInclude, JsonPropertyName("Functions")]
        private readonly HashSet<Function>? functions;

        [JsonInclude, JsonPropertyName("Location")]
        private readonly Point3D? location;

        /// <summary>
        /// Initializes a new instance of the <see cref="Antenna"/> class with the specified unique identifier, location, and functions.
        /// </summary>
        /// <param name="guid">The unique identifier for the antenna.</param>
        /// <param name="location">The three-dimensional point representing the location of the antenna.</param>
        /// <param name="functions">An optional collection of functions associated with the antenna.</param>
        public Antenna(Guid guid, Point3D? location, params Function[]? functions)
            : base(guid)
        {
            this.location = Core.Query.Clone(location);
            this.functions = functions == null ? null : [.. functions];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Antenna"/> class with the specified location and functions.
        /// </summary>
        /// <param name="location">The three-dimensional coordinates where the antenna is located.</param>
        /// <param name="functions">A variable number of functions associated with the antenna.</param>
        public Antenna(Point3D? location, params Function[]? functions)
            : base()
        {
            this.location = Core.Query.Clone(location);
            this.functions = functions == null ? null : [.. functions];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Antenna"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the antenna instance, or null.</param>
        public Antenna(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Antenna"/> class by copying another antenna instance.
        /// </summary>
        /// <param name="antenna">The source antenna instance to copy from, or <see langword="null"/>.</param>
        public Antenna(Antenna? antenna)
            : base(antenna)
        {
            if (antenna != null)
            {
                location = Core.Query.Clone(antenna.location);
                functions = antenna.functions == null ? null : [.. antenna.functions];
            }
        }

        /// <summary> Gets the set of functions associated with the antenna. </summary>
        /// <value> A <see cref="HashSet{Function}" /> containing the antenna's functions, or <c>null</c> if none are defined. </value>
        [JsonIgnore]
        public HashSet<Function>? Functions
        {
            get
            {
                return functions == null ? null : [.. functions];
            }
        }

        /// <summary> Gets the three-dimensional location of the antenna. </summary>
        [JsonIgnore]
        public Point3D? Location
        {
            get
            {
                return Core.Query.Clone(location);
            }
        }
    }
}
