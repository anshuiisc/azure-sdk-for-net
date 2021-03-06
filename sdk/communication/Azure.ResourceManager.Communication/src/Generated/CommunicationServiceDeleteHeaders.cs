// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Communication
{
    internal class CommunicationServiceDeleteHeaders
    {
        private readonly Response _response;
        public CommunicationServiceDeleteHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> URL to query for status of the operation. </summary>
        public string Location => _response.Headers.TryGetValue("location", out string value) ? value : null;
    }
}
