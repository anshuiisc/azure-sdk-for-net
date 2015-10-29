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
    /// Describes a Virtual Machine.
    /// </summary>
    public partial class VirtualMachine : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachine class.
        /// </summary>
        public VirtualMachine() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachine class.
        /// </summary>
        public VirtualMachine(Plan plan = default(Plan), VirtualMachineProperties properties = default(VirtualMachineProperties), IList<VirtualMachineExtension> resources = default(IList<VirtualMachineExtension>))
        {
            Plan = plan;
            Properties = properties;
            Resources = resources;
        }

        /// <summary>
        /// Gets or sets the purchase plan when deploying virtual machine from
        /// VM Marketplace images.
        /// </summary>
        [JsonProperty(PropertyName = "plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public VirtualMachineProperties Properties { get; set; }

        /// <summary>
        /// Gets the virtual machine child extension resources.
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<VirtualMachineExtension> Resources { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.Resources != null)
            {
                foreach (var element in this.Resources)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
