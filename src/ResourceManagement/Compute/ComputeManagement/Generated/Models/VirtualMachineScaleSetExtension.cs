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
    /// Describes a Virtual Machine Scale Set Extension.
    /// </summary>
    public partial class VirtualMachineScaleSetExtension : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetExtension
        /// class.
        /// </summary>
        public VirtualMachineScaleSetExtension() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetExtension
        /// class.
        /// </summary>
        public VirtualMachineScaleSetExtension(VirtualMachineScaleSetExtensionProperties properties = default(VirtualMachineScaleSetExtensionProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public VirtualMachineScaleSetExtensionProperties Properties { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
