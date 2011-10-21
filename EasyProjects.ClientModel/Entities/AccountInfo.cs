using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EasyProjects.ClientModel.Entities
{
    /// <summary>
    /// AccountInfo
    /// </summary>
    [DataContract(Name = "AccountInfo", Namespace = "easyprojects.net/rest/v1")]
    public class AccountInfo
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is license expired.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is license expired; otherwise, <c>false</c>.
        /// </value>
        [DataMember(Name = "IsLicenseExpired")]
        public bool IsLicenseExpired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is enterprise license.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is enterprise license; otherwise, <c>false</c>.
        /// </value>
        [DataMember(Name = "IsEnterpriseLicense")]
        public bool IsEnterpriseLicense { get; set; }

        /// <summary>
        /// Gets or sets the build version.
        /// </summary>
        /// <value>The build version.</value>
        [DataMember(Name = "Version")]
        public string BuildVersion { get; set; }

        /// <summary>
        /// Gets or sets the company.
        /// </summary>
        /// <value>The company.</value>
        [DataMember(Name = "Company")]
        public string Company { get; set; }


        /// <summary>
        /// Gets or sets the attachments space.
        /// </summary>
        /// <value>The attachments space.</value>
        [DataMember(Name = "AttachmentsAvailableSpace")]
        public int AttachmentsSpace { get; set; }


        /// <summary>
        /// Gets or sets the attachment save mode.
        /// </summary>
        /// <value>The attachment save mode.</value>
        [DataMember(Name = "AttachmentSaveMode")]
        public string AttachmentSaveMode { get; set; }

        /// <summary>
        /// Gets or sets the attachment used space.
        /// </summary>
        /// <value>The attachment used space.</value>
        [DataMember(Name = "AttachmentUsedSpace")]
        public long AttachmentUsedSpace { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is hosted.
        /// </summary>
        /// <value><c>true</c> if this instance is hosted; otherwise, <c>false</c>.</value>
        [DataMember(Name = "IsHosted")]
        public bool IsHosted { get; set; }

        /// <summary>
        /// Gets or sets the application root.
        /// </summary>
        /// <value>The application root.</value>
        [DataMember(Name = "RootUrl")]
        public string ApplicationRoot { get; set; }

        /// <summary>
        /// Gets or sets the current active common users count.
        /// </summary>
        /// <value>The current active common users count.</value>
        [DataMember(Name = "ActiveUsersCount")]
        public int CurrentActiveCommonUsersCount { get; set; }

        /// <summary>
        /// Gets or sets the max users count.
        /// </summary>
        /// <value>The max users count.</value>
        [DataMember(Name = "MaxUsersCount")]
        public int MaxUsersCount { get; set; }


        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        [DataMember(Name = "Email")]
        public string Email { get; set; }

    }
}
