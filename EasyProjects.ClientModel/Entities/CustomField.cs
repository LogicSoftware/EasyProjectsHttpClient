using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyProjects.ClientModel.Entities.CustomFields
{
    public class CustomField
    {

        #region FieldID
        private int fieldID;
        /// <summary>
        /// ID of the field
        /// </summary>
        
        public int FieldID
        {
            get { return fieldID; }
            set { fieldID = value; }
        }
        #endregion

        #region FieldType

        /// <summary>
        /// Type of the field
        /// </summary>
        
        public int FieldType { get; set; }

        #endregion

        #region Alias
        /// <summary>
        /// Unique alias for the field.
        /// </summary>
        public string Alias { get; set; }

        #endregion

        public int DataType { get; set; }

        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is restricted.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is restricted; otherwise, <c>false</c>.
        /// </value>
        public bool IsRestricted { get; set; }
    }
}
