// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace Gabog.WebChatHost.Models
{
    public class DirectLineTokenRequest
    {
        [JsonProperty("trustedOrigins")]
        public string[] TrustedOrigins { get; set; }

        [JsonProperty("user")]
        public DirectLineUser User { get; set; }
    }
}
