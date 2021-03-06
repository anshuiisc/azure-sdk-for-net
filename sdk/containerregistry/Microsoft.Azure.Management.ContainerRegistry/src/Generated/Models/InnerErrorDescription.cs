// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// inner error.
    /// </summary>
    public partial class InnerErrorDescription
    {
        /// <summary>
        /// Initializes a new instance of the InnerErrorDescription class.
        /// </summary>
        public InnerErrorDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InnerErrorDescription class.
        /// </summary>
        /// <param name="code">error code.</param>
        /// <param name="message">error message.</param>
        /// <param name="target">target of the particular error.</param>
        public InnerErrorDescription(string code, string message, string target = default(string))
        {
            Code = code;
            Message = message;
            Target = target;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets target of the particular error.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Code");
            }
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
        }
    }
}
