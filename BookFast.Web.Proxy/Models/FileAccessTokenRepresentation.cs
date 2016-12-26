// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace BookFast.Web.Proxy.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class FileAccessTokenRepresentation
    {
        /// <summary>
        /// Initializes a new instance of the FileAccessTokenRepresentation
        /// class.
        /// </summary>
        public FileAccessTokenRepresentation() { }

        /// <summary>
        /// Initializes a new instance of the FileAccessTokenRepresentation
        /// class.
        /// </summary>
        public FileAccessTokenRepresentation(string accessPermission = default(string), string url = default(string))
        {
            AccessPermission = accessPermission;
            Url = url;
        }

        /// <summary>
        /// Possible values include: 'Read', 'Write', 'Delete'
        /// </summary>
        [JsonProperty(PropertyName = "accessPermission")]
        public string AccessPermission { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }
}