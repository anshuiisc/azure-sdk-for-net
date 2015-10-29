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
    /// Describes a data disk.
    /// </summary>
    public partial class DataDisk
    {
        /// <summary>
        /// Initializes a new instance of the DataDisk class.
        /// </summary>
        public DataDisk() { }

        /// <summary>
        /// Initializes a new instance of the DataDisk class.
        /// </summary>
        public DataDisk(int? lun = default(int?), string name = default(string), VirtualHardDisk vhd = default(VirtualHardDisk), VirtualHardDisk image = default(VirtualHardDisk), CachingTypes? caching = default(CachingTypes?), DiskCreateOptionTypes? createOption = default(DiskCreateOptionTypes?), int? diskSizeGB = default(int?))
        {
            Lun = lun;
            Name = name;
            Vhd = vhd;
            Image = image;
            Caching = caching;
            CreateOption = createOption;
            DiskSizeGB = diskSizeGB;
        }

        /// <summary>
        /// Gets or sets the logical unit number.
        /// </summary>
        [JsonProperty(PropertyName = "lun")]
        public int? Lun { get; set; }

        /// <summary>
        /// Gets or sets the disk name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Virtual Hard Disk.
        /// </summary>
        [JsonProperty(PropertyName = "vhd")]
        public VirtualHardDisk Vhd { get; set; }

        /// <summary>
        /// Gets or sets the Source User Image VirtualHardDisk. This
        /// VirtualHardDisk will be copied before using it to attach to the
        /// Virtual Machine.If SourceImage is provided, the destination
        /// VirtualHardDisk should not exist.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public VirtualHardDisk Image { get; set; }

        /// <summary>
        /// Gets or sets the caching type. Possible values for this property
        /// include: 'None', 'ReadOnly', 'ReadWrite'.
        /// </summary>
        [JsonProperty(PropertyName = "caching")]
        public CachingTypes? Caching { get; set; }

        /// <summary>
        /// Gets or sets the create option. Possible values for this property
        /// include: 'fromImage', 'empty', 'attach'.
        /// </summary>
        [JsonProperty(PropertyName = "createOption")]
        public DiskCreateOptionTypes? CreateOption { get; set; }

        /// <summary>
        /// Gets or sets the initial disk size in GB for blank data disks, and
        /// the new desired size for existing OS and Data disks.
        /// </summary>
        [JsonProperty(PropertyName = "diskSizeGB")]
        public int? DiskSizeGB { get; set; }

    }
}
