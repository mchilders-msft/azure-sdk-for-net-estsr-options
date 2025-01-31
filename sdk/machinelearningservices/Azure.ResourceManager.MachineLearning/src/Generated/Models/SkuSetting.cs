// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> SkuSetting fulfills the need for stripped down SKU info in ARM contract. </summary>
    public partial class SkuSetting
    {
        /// <summary> Initializes a new instance of SkuSetting. </summary>
        /// <param name="name"> [Required] The name of the SKU. Ex - P3. It is typically a letter+number code. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal SkuSetting(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of SkuSetting. </summary>
        /// <param name="name"> [Required] The name of the SKU. Ex - P3. It is typically a letter+number code. </param>
        /// <param name="tier"> This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT. </param>
        internal SkuSetting(string name, MachineLearningSkuTier? tier)
        {
            Name = name;
            Tier = tier;
        }

        /// <summary> [Required] The name of the SKU. Ex - P3. It is typically a letter+number code. </summary>
        public string Name { get; }
        /// <summary> This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT. </summary>
        public MachineLearningSkuTier? Tier { get; }
    }
}
