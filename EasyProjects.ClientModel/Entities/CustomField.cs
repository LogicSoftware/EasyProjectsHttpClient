using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace EasyProjects.ClientModel.Entities
{
    /// <summary>
    /// CustomField
    /// </summary>
    [Serializable]
    public class CustomField
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomField"/> class.
        /// </summary>
        public CustomField()
        { }


        #region Alias

        /// <summary>
        /// Gets or sets the alias.
        /// </summary>
        /// <value>The alias.</value>
        [DataMember]
        public string Alias { get; set; }
        #endregion

        #region DataType

        /// <summary>
        /// Gets or sets the type of the data.
        /// </summary>
        /// <value>The type of the data.</value>
        [DataMember]
        public DataType DataType { get; set; }
        #endregion

        #region FieldID
        /// <summary>
        /// ID of the field
        /// </summary>
        [DataMember(Name = "FieldID")]
        public int FieldID
        {
            get;
            set;
        }
        #endregion

        #region FieldType
        /// <summary>
        /// Type of the field
        /// </summary>
        [DataMember]
        public CustomFieldDataType FieldType
        {
            get;
            set;
        }
        #endregion

        #region AccessType
        /// <summary>
        /// Gets or sets the type of the access.
        /// </summary>
        /// <value>The type of the access.</value>
        [DataMember]
        public FieldAccessType AccessType
        {
            get;
            set;
        }
        #endregion

        #region Title
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        [DataMember]
        public string Title
        {
            get;
            set;
        }
        #endregion

    }

    
    /// <summary>
    /// Type of data for the field
    /// </summary>
    public enum DataType
    {
        /// <summary>
        /// Int32 field
        /// </summary>
        [EnumMember]
        Integer = 0,

        /// <summary>
        /// Simple string field
        /// </summary>
        [EnumMember]
        String,

        /// <summary>
        /// XHTML Text filed
        /// </summary>
        [EnumMember]
        HtmlText,

        /// <summary>
        /// Date/Time field
        /// </summary>
        [EnumMember]
        Date,

        /// <summary>
        /// Boolean/Bit field
        /// </summary>
        [EnumMember]
        Bool,

        /// <summary>
        /// Decimal/Double value
        /// </summary>
        [EnumMember]
        Decimal,

        /// <summary>
        /// Multiline text
        /// </summary>
        [EnumMember]
        MultilineText,

        /// <summary>
        /// Password Text
        /// </summary>
        [EnumMember]
        Password,

        /// <summary>
        /// Field for BLOB data - supports streaming
        /// </summary>
        [EnumMember]
        Stream,

        /// <summary>
        /// Hyperlink field
        /// </summary>
        [EnumMember]
        Hyperlink
    }


    /// <summary>
    /// Supported custom fields data types.
    /// </summary>
    public enum CustomFieldDataType
    {
        /// <summary>
        /// String data type.
        /// </summary>
        String = 0,

        /// <summary>
        /// Numeric data type.
        /// </summary>
        Numeric = 1,

        /// <summary>
        /// Date data type.
        /// </summary>
        Date = 2,

        /// <summary>
        /// Boolean data type.
        /// </summary>
        Boolean = 3,

        /// <summary>
        /// Listed data type
        /// </summary>
        List = 4,

        /// <summary>
        /// Text data type.
        /// </summary>
        TextArea = 5,

        /// <summary>
        /// Text(Rich UI formating) data type same as TextArea.
        /// </summary>
        TextAreaRich = 6,

        /// <summary>
        /// Hyperlink data type
        /// </summary>
        Hyperlink = 7
    }

    /// <summary>
    /// Defines available field access types
    /// </summary>
    public enum FieldAccessType
    {
        /// <summary>
        /// Field cannot be changed
        /// </summary>
        ReadOnly = 0,
        /// <summary>
        /// Field is editable and its value must be specified (can't be null/empty)
        /// </summary>
        Mandatory,
        /// <summary>
        /// Field is editable and its value must can be null/empty
        /// </summary>
        Optional,
        ///<summary>
        ///Field can't be visible
        ///</summary>
        Hidden

    }
}
