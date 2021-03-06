// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Request for sending test alert email
    /// </summary>
    public partial class SendTestAlertEmailRequest
    {
        /// <summary>
        /// Initializes a new instance of the SendTestAlertEmailRequest class.
        /// </summary>
        public SendTestAlertEmailRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SendTestAlertEmailRequest class.
        /// </summary>
        /// <param name="emailList">List of emails to send the test
        /// alerts</param>
        public SendTestAlertEmailRequest(IList<string> emailList)
        {
            EmailList = emailList;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of emails to send the test alerts
        /// </summary>
        [JsonProperty(PropertyName = "emailList")]
        public IList<string> EmailList { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EmailList == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EmailList");
            }
        }
    }
}
