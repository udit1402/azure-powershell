// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support
{

    /// <summary>
    /// Add a second layer of encryption for your data using new encryption algorithm which gives additional data protection.
    /// Value is optional but if passed in, must be 'Disabled' or 'Enabled'.
    /// </summary>
    public partial struct InfrastructureEncryption :
        System.IEquatable<InfrastructureEncryption>
    {
        /// <summary>Additional (2nd) layer of encryption for data at rest</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.InfrastructureEncryption Disabled = @"Disabled";

        /// <summary>Default value for single layer of encryption for data at rest.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.InfrastructureEncryption Enabled = @"Enabled";

        /// <summary>the value for an instance of the <see cref="InfrastructureEncryption" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to InfrastructureEncryption</summary>
        /// <param name="value">the value to convert to an instance of <see cref="InfrastructureEncryption" />.</param>
        internal static object CreateFrom(object value)
        {
            return new InfrastructureEncryption(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type InfrastructureEncryption</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.InfrastructureEncryption e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type InfrastructureEncryption (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is InfrastructureEncryption && Equals((InfrastructureEncryption)obj);
        }

        /// <summary>Returns hashCode for enum InfrastructureEncryption</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="InfrastructureEncryption"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private InfrastructureEncryption(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for InfrastructureEncryption</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to InfrastructureEncryption</summary>
        /// <param name="value">the value to convert to an instance of <see cref="InfrastructureEncryption" />.</param>

        public static implicit operator InfrastructureEncryption(string value)
        {
            return new InfrastructureEncryption(value);
        }

        /// <summary>Implicit operator to convert InfrastructureEncryption to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="InfrastructureEncryption" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.InfrastructureEncryption e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum InfrastructureEncryption</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.InfrastructureEncryption e1, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.InfrastructureEncryption e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum InfrastructureEncryption</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.InfrastructureEncryption e1, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.InfrastructureEncryption e2)
        {
            return e2.Equals(e1);
        }
    }
}