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
    /// Describes the properties of a Virtual Machine Image.
    /// </summary>
    public partial class VirtualMachineImageProperties
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineImageProperties
        /// class.
        /// </summary>
        public VirtualMachineImageProperties() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineImageProperties
        /// class.
        /// </summary>
        public VirtualMachineImageProperties(PurchasePlan plan = default(PurchasePlan), OSDiskImage osDiskImage = default(OSDiskImage), IList<DataDiskImage> dataDiskImages = default(IList<DataDiskImage>))
        {
            Plan = plan;
            OsDiskImage = osDiskImage;
            DataDiskImages = dataDiskImages;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "plan")]
        public PurchasePlan Plan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "osDiskImage")]
        public OSDiskImage OsDiskImage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataDiskImages")]
        public IList<DataDiskImage> DataDiskImages { get; set; }

    }
}
