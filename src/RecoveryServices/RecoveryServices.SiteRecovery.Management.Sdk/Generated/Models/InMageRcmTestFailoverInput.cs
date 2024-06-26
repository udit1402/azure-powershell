// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// InMageRcm provider specific input for test failover.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMageRcm")]
    public partial class InMageRcmTestFailoverInput : TestFailoverProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the InMageRcmTestFailoverInput class.
        /// </summary>
        public InMageRcmTestFailoverInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageRcmTestFailoverInput class.
        /// </summary>

        /// <param name="networkId">The test network Id.
        /// </param>

        /// <param name="recoveryPointId">The recovery point id to be passed to test failover to a particular
        /// recovery point. In case of latest recovery point, null should be passed.
        /// </param>
        public InMageRcmTestFailoverInput(string networkId = default(string), string recoveryPointId = default(string))

        {
            this.NetworkId = networkId;
            this.RecoveryPointId = recoveryPointId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the test network Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "networkId")]
        public string NetworkId {get; set; }

        /// <summary>
        /// Gets or sets the recovery point id to be passed to test failover to a
        /// particular recovery point. In case of latest recovery point, null should be
        /// passed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryPointId")]
        public string RecoveryPointId {get; set; }
    }
}