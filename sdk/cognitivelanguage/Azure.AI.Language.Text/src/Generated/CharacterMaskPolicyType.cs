// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> Represents the policy of redacting with a redaction character. </summary>
    public partial class CharacterMaskPolicyType : BaseRedactionPolicy
    {
        /// <summary> Initializes a new instance of <see cref="CharacterMaskPolicyType"/>. </summary>
        public CharacterMaskPolicyType()
        {
            PolicyKind = RedactionPolicyKind.CharacterMask;
        }

        /// <summary> Initializes a new instance of <see cref="CharacterMaskPolicyType"/>. </summary>
        /// <param name="policyKind"> The entity RedactionPolicy object kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="redactionCharacter"> Optional parameter to use a Custom Character to be used for redaction in PII responses. Default character will bce * as before. We allow specific ascii characters for redaction. </param>
        internal CharacterMaskPolicyType(RedactionPolicyKind policyKind, IDictionary<string, BinaryData> serializedAdditionalRawData, RedactionCharacter? redactionCharacter) : base(policyKind, serializedAdditionalRawData)
        {
            RedactionCharacter = redactionCharacter;
        }

        /// <summary> Optional parameter to use a Custom Character to be used for redaction in PII responses. Default character will bce * as before. We allow specific ascii characters for redaction. </summary>
        public RedactionCharacter? RedactionCharacter { get; set; }
    }
}
