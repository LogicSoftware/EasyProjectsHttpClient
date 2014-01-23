using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EasyProjects.ClientModel.Entities
{
    /// <summary>
    /// CustomFieldKeyValuePair
    /// </summary>
    [Serializable]
    public class CustomFieldValuePair
    {
        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>The field.</value>
        [DataMember]
        public EasyProjects.ClientModel.Entities.CustomFields.CustomField Field { get; set; }
        
        object _value = null;

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [DataMember]
        public object Value { 
            get {

                if (_value is DBNull)
                    return null;

                return _value;
            }
            set {
                _value = value;
            }
        }
    
    }

    /// <summary>
    /// CustomFieldsCollection
    /// </summary>
    [Serializable]
    public class CustomFieldsCollection : List<CustomFieldValuePair>
    {
       
    }

    /// <summary>
    /// ICustomFieldsContainer
    /// </summary>
    public interface ICustomFieldsContainer
    {
        /// <summary>
        /// Gets or sets the custom fields.
        /// </summary>
        /// <value>The custom fields.</value>
        CustomFieldsCollection CustomFields { get; set; }
    }
}
