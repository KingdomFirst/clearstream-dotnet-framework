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

namespace ClearstreamDotNetFramework.v1.Model.Object
{
    /// <summary>
    /// The <see cref="Account"/> statistics.
    /// </summary>
    public class Stats
    {
        /// <summary>
        /// Gets or sets the timezone.
        /// </summary>
        /// <value>
        /// The timezone.
        /// </value>
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or sets the opt ins.
        /// </summary>
        /// <value>
        /// The opt ins.
        /// </value>
        public OptIns OptIns { get; set; }

        /// <summary>
        /// Gets or sets the opt outs.
        /// </summary>
        /// <value>
        /// The opt outs.
        /// </value>
        public StatTotal OptOuts { get; set; }

        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        /// <value>
        /// The messages.
        /// </value>
        public Messages Messages { get; set; }
    }
}
