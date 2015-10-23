// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The image reference.
    /// </summary>
    public partial class ImageReference
    {
        /// <summary>
        /// Initializes a new instance of the ImageReference class.
        /// </summary>
        public ImageReference() { }

        /// <summary>
        /// Initializes a new instance of the ImageReference class.
        /// </summary>
        public ImageReference(string publisher = default(string), string offer = default(string), string sku = default(string), string version = default(string))
        {
            Publisher = publisher;
            Offer = offer;
            Sku = sku;
            Version = version;
        }

        /// <summary>
        /// Gets or sets the image publisher.
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the image offer.
        /// </summary>
        [JsonProperty(PropertyName = "offer")]
        public string Offer { get; set; }

        /// <summary>
        /// Gets or sets the image sku.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or sets the image version. The allowed formats are
        /// Major.Minor.Build or 'latest'. Major, Minor and Build being
        /// decimal numbers. Specify 'latest' to use the latest version of
        /// image.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

    }
}
