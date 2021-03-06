// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The SKU capacity
    /// </summary>
    public partial class SkuCapacity
    {
        /// <summary>
        /// Initializes a new instance of the SkuCapacity class.
        /// </summary>
        public SkuCapacity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SkuCapacity class.
        /// </summary>
        /// <param name="minimum">Gets or sets the minimum.</param>
        /// <param name="maximum">Gets or sets the maximum.</param>
        /// <param name="defaultProperty">Gets or sets the default.</param>
        /// <param name="scaleType">Gets or sets the type of the scale.
        /// Possible values include: 'None', 'Manual', 'Automatic'</param>
        public SkuCapacity(int minimum, int? maximum = default(int?), int? defaultProperty = default(int?), string scaleType = default(string))
        {
            Minimum = minimum;
            Maximum = maximum;
            DefaultProperty = defaultProperty;
            ScaleType = scaleType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the minimum.
        /// </summary>
        [JsonProperty(PropertyName = "minimum")]
        public int Minimum { get; set; }

        /// <summary>
        /// Gets or sets the maximum.
        /// </summary>
        [JsonProperty(PropertyName = "maximum")]
        public int? Maximum { get; set; }

        /// <summary>
        /// Gets or sets the default.
        /// </summary>
        [JsonProperty(PropertyName = "default")]
        public int? DefaultProperty { get; set; }

        /// <summary>
        /// Gets or sets the type of the scale. Possible values include:
        /// 'None', 'Manual', 'Automatic'
        /// </summary>
        [JsonProperty(PropertyName = "scaleType")]
        public string ScaleType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
