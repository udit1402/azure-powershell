// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.KeyVault.Models
{

    /// <summary>
    /// Defines values for CreateMode.
    /// </summary>


    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateMode
    {
        [System.Runtime.Serialization.EnumMember(Value = "recover")]
        Recover,
        [System.Runtime.Serialization.EnumMember(Value = "default")]
        Default
    }
    internal static class CreateModeEnumExtension
    {
        internal static string ToSerializedValue(this CreateMode? value)
        {
            return value == null ? null : ((CreateMode)value).ToSerializedValue();
        }
        internal static string ToSerializedValue(this CreateMode value)
        {
            switch( value )
            {
                case CreateMode.Recover:
                    return "recover";
                case CreateMode.Default:
                    return "default";
            }
            return null;
        }
        internal static CreateMode? ParseCreateMode(this string value)
        {
            switch( value )
            {
                case "recover":
                    return CreateMode.Recover;
                case "default":
                    return CreateMode.Default;
            }
            return null;
        }
    }
}