﻿// <copyright>
// Copyright 2019 by Luther Pierce Hendon, III
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using ClearstreamDotNetFramework.v1.Model.Webhook;

namespace ClearstreamDotNetFramework.v1.Model.Object
{
    /// <summary>
    /// The optional response text message to send after the <see cref="KeywordUsedPayload"/> webhook event is received.
    /// </summary>
    public class WebhookResponse
    {
        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        /// <value>
        /// The response.
        /// </value>
        public Text Response { get; set; }
    }
}
