// #region License
// 
//                         ######
//                         ######
//   ############    ####( ######  #####. ######  ############   ############
//   #############  #####( ######  #####. ######  #############  #############
//          ######  #####( ######  #####. ######  #####  ######  #####  ######
//   ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//   ###### ######  #####( ######  #####. ######  #####          #####  ######
//   #############  #############  #############  #############  #####  ######
//    ############   ############  #############   ############  #####  ######
//                                        ######
//                                 #############
//                                 ############
// 
//   Adyen Dotnet API Library
// 
//   Copyright (c) 2022 Adyen N.V.
//   This file is open source and available under the MIT license.
//   See the LICENSE file for more info.
// 
// #endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
/// <summary>
    /// ThreeDSRequestorAuthenticationInfo
    /// </summary>
    [DataContract]
        public partial class ThreeDSRequestorAuthenticationInfo :  IEquatable<ThreeDSRequestorAuthenticationInfo>, IValidatableObject
    {
        /// <summary>
        /// Mechanism used by the Cardholder to authenticate to the 3DS Requestor. Allowed values: * **01** — No 3DS Requestor authentication occurred (for example, cardholder “logged in” as guest). * **02** — Login to the cardholder account at the 3DS Requestor system using 3DS Requestor’s own credentials. * **03** — Login to the cardholder account at the 3DS Requestor system using federated ID. * **04** — Login to the cardholder account at the 3DS Requestor system using issuer credentials. * **05** — Login to the cardholder account at the 3DS Requestor system using third-party authentication. * **06** — Login to the cardholder account at the 3DS Requestor system using FIDO Authenticator.
        /// </summary>
        /// <value>Mechanism used by the Cardholder to authenticate to the 3DS Requestor. Allowed values: * **01** — No 3DS Requestor authentication occurred (for example, cardholder “logged in” as guest). * **02** — Login to the cardholder account at the 3DS Requestor system using 3DS Requestor’s own credentials. * **03** — Login to the cardholder account at the 3DS Requestor system using federated ID. * **04** — Login to the cardholder account at the 3DS Requestor system using issuer credentials. * **05** — Login to the cardholder account at the 3DS Requestor system using third-party authentication. * **06** — Login to the cardholder account at the 3DS Requestor system using FIDO Authenticator.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ThreeDSReqAuthMethodEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01 = 1,
            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")]
            _02 = 2,
            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")]
            _03 = 3,
            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")]
            _04 = 4,
            /// <summary>
            /// Enum _05 for value: 05
            /// </summary>
            [EnumMember(Value = "05")]
            _05 = 5,
            /// <summary>
            /// Enum _06 for value: 06
            /// </summary>
            [EnumMember(Value = "06")]
            _06 = 6        }
        /// <summary>
        /// Mechanism used by the Cardholder to authenticate to the 3DS Requestor. Allowed values: * **01** — No 3DS Requestor authentication occurred (for example, cardholder “logged in” as guest). * **02** — Login to the cardholder account at the 3DS Requestor system using 3DS Requestor’s own credentials. * **03** — Login to the cardholder account at the 3DS Requestor system using federated ID. * **04** — Login to the cardholder account at the 3DS Requestor system using issuer credentials. * **05** — Login to the cardholder account at the 3DS Requestor system using third-party authentication. * **06** — Login to the cardholder account at the 3DS Requestor system using FIDO Authenticator.
        /// </summary>
        /// <value>Mechanism used by the Cardholder to authenticate to the 3DS Requestor. Allowed values: * **01** — No 3DS Requestor authentication occurred (for example, cardholder “logged in” as guest). * **02** — Login to the cardholder account at the 3DS Requestor system using 3DS Requestor’s own credentials. * **03** — Login to the cardholder account at the 3DS Requestor system using federated ID. * **04** — Login to the cardholder account at the 3DS Requestor system using issuer credentials. * **05** — Login to the cardholder account at the 3DS Requestor system using third-party authentication. * **06** — Login to the cardholder account at the 3DS Requestor system using FIDO Authenticator.</value>
        [DataMember(Name="threeDSReqAuthMethod", EmitDefaultValue=false)]
        public ThreeDSReqAuthMethodEnum? ThreeDSReqAuthMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSRequestorAuthenticationInfo" /> class.
        /// </summary>
        /// <param name="threeDSReqAuthData">Data that documents and supports a specific authentication process. Maximum length: 2048 bytes..</param>
        /// <param name="threeDSReqAuthMethod">Mechanism used by the Cardholder to authenticate to the 3DS Requestor. Allowed values: * **01** — No 3DS Requestor authentication occurred (for example, cardholder “logged in” as guest). * **02** — Login to the cardholder account at the 3DS Requestor system using 3DS Requestor’s own credentials. * **03** — Login to the cardholder account at the 3DS Requestor system using federated ID. * **04** — Login to the cardholder account at the 3DS Requestor system using issuer credentials. * **05** — Login to the cardholder account at the 3DS Requestor system using third-party authentication. * **06** — Login to the cardholder account at the 3DS Requestor system using FIDO Authenticator..</param>
        /// <param name="threeDSReqAuthTimestamp">Date and time in UTC of the cardholder authentication. Format: YYYYMMDDHHMM.</param>
        public ThreeDSRequestorAuthenticationInfo(string threeDSReqAuthData = default(string), ThreeDSReqAuthMethodEnum? threeDSReqAuthMethod = default(ThreeDSReqAuthMethodEnum?), string threeDSReqAuthTimestamp = default(string))
        {
            this.ThreeDSReqAuthData = threeDSReqAuthData;
            this.ThreeDSReqAuthMethod = threeDSReqAuthMethod;
            this.ThreeDSReqAuthTimestamp = threeDSReqAuthTimestamp;
        }
        
        /// <summary>
        /// Data that documents and supports a specific authentication process. Maximum length: 2048 bytes.
        /// </summary>
        /// <value>Data that documents and supports a specific authentication process. Maximum length: 2048 bytes.</value>
        [DataMember(Name="threeDSReqAuthData", EmitDefaultValue=false)]
        public string ThreeDSReqAuthData { get; set; }


        /// <summary>
        /// Date and time in UTC of the cardholder authentication. Format: YYYYMMDDHHMM
        /// </summary>
        /// <value>Date and time in UTC of the cardholder authentication. Format: YYYYMMDDHHMM</value>
        [DataMember(Name="threeDSReqAuthTimestamp", EmitDefaultValue=false)]
        public string ThreeDSReqAuthTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThreeDSRequestorAuthenticationInfo {\n");
            sb.Append("  ThreeDSReqAuthData: ").Append(ThreeDSReqAuthData).Append("\n");
            sb.Append("  ThreeDSReqAuthMethod: ").Append(ThreeDSReqAuthMethod).Append("\n");
            sb.Append("  ThreeDSReqAuthTimestamp: ").Append(ThreeDSReqAuthTimestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ThreeDSRequestorAuthenticationInfo);
        }

        /// <summary>
        /// Returns true if ThreeDSRequestorAuthenticationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDSRequestorAuthenticationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDSRequestorAuthenticationInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ThreeDSReqAuthData == input.ThreeDSReqAuthData ||
                    (this.ThreeDSReqAuthData != null &&
                    this.ThreeDSReqAuthData.Equals(input.ThreeDSReqAuthData))
                ) && 
                (
                    this.ThreeDSReqAuthMethod == input.ThreeDSReqAuthMethod ||
                    (this.ThreeDSReqAuthMethod != null &&
                    this.ThreeDSReqAuthMethod.Equals(input.ThreeDSReqAuthMethod))
                ) && 
                (
                    this.ThreeDSReqAuthTimestamp == input.ThreeDSReqAuthTimestamp ||
                    (this.ThreeDSReqAuthTimestamp != null &&
                    this.ThreeDSReqAuthTimestamp.Equals(input.ThreeDSReqAuthTimestamp))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ThreeDSReqAuthData != null)
                    hashCode = hashCode * 59 + this.ThreeDSReqAuthData.GetHashCode();
                if (this.ThreeDSReqAuthMethod != null)
                    hashCode = hashCode * 59 + this.ThreeDSReqAuthMethod.GetHashCode();
                if (this.ThreeDSReqAuthTimestamp != null)
                    hashCode = hashCode * 59 + this.ThreeDSReqAuthTimestamp.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}