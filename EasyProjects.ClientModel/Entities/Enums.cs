using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace EasyProjects.ClientModel.Entities.Enums
{
    ///// <summary>
    ///// Type of data for the field
    ///// </summary>
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
