
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Entities.cs" company="Logic Software">
//   (c) Logic Software
// </copyright>
// <summary>
//   Generated class for entities.
//   !!!DO NOT CHANGE IT DIRECTLY!!!
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EasyProjects.ClientModel.Entities
{
    using System;
	using System.Diagnostics;
	using System.Collections.Generic;
	using System.Runtime.Serialization;
	using System.Xml.Serialization;
    #region CalendarEvent entity
    /// <summary>
    /// Generated class for entity CalendarEvent
    /// </summary>
	[DataContract(Name = "CalendarEvent", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.CalendarEvent")]
	public partial class CalendarEvent     { 
		public int EntityBaseID { get { return Convert.ToInt32(CalendarEventID);} set { CalendarEventID = value; } }
		
		#region CalendarEventID
		private int _calendarEventID; 

		[DataMember(Name = "CalendarEventID", IsRequired = false, EmitDefaultValue = true)]			
        public int CalendarEventID 
		{ 
			get
			{
				return _calendarEventID;
			}
			set
			{
				if(_calendarEventID != value)
				{
					_calendarEventID = value;
				} 
			}
		}
		#endregion
		
		#region TaskEventID
		private int? _taskEventID; 

		[DataMember(Name = "TaskEventID", IsRequired = false, EmitDefaultValue = true)]			
        public int? TaskEventID 
		{ 
			get
			{
				return _taskEventID;
			}
			set
			{
				if(_taskEventID != value)
				{
					_taskEventID = value;
				} 
			}
		}
		#endregion
		
		#region CreatorID
		private int? _creatorID; 

		[DataMember(Name = "CreatorID", IsRequired = false, EmitDefaultValue = true)]			
        public int? CreatorID 
		{ 
			get
			{
				return _creatorID;
			}
			set
			{
				if(_creatorID != value)
				{
					_creatorID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region StartDate
		private DateTime? _startDate; 

		[DataMember(Name = "StartDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? StartDate 
		{ 
			get
			{
				return _startDate;
			}
			set
			{
				if(_startDate != value)
				{
					_startDate = value;
				} 
			}
		}
		#endregion
		
		#region EndDate
		private DateTime? _endDate; 

		[DataMember(Name = "EndDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? EndDate 
		{ 
			get
			{
				return _endDate;
			}
			set
			{
				if(_endDate != value)
				{
					_endDate = value;
				} 
			}
		}
		#endregion
		
		#region CalendarEventType
		private string _calendarEventType; 

		[DataMember(Name = "CalendarEventType", IsRequired = false, EmitDefaultValue = true)]			
        public string CalendarEventType 
		{ 
			get
			{
				return _calendarEventType;
			}
			set
			{
				if(_calendarEventType != value)
				{
					_calendarEventType = value;
				} 
			}
		}
		#endregion
		
		#region TaskStatus
		private int _taskStatusID;
		[DataMember(Name = "TaskStatusID")]
        public int TaskStatusID 
		{ 
			get
			{
				return _taskStatusID;
			}
			set
			{
				if(_taskStatusID != value)
				{
					_taskStatusID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region Category entity
    /// <summary>
    /// Generated class for entity Category
    /// </summary>
	[DataContract(Name = "Category", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Category")]
	public partial class Category     { 
		public int EntityBaseID { get { return Convert.ToInt32(CategoryID);} set { CategoryID = value; } }
		
		#region CategoryID
		private int _categoryID; 

		[DataMember(Name = "CategoryID", IsRequired = false, EmitDefaultValue = true)]			
        public int CategoryID 
		{ 
			get
			{
				return _categoryID;
			}
			set
			{
				if(_categoryID != value)
				{
					_categoryID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region Customer entity
    /// <summary>
    /// Generated class for entity Customer
    /// </summary>
	[DataContract(Name = "Customer", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Customer")]
	public partial class Customer  : ICustomFieldsContainer     { 
		public int EntityBaseID { get { return Convert.ToInt32(CustomerID);} set { CustomerID = value; } }
		
		#region CustomerID
		private int _customerID; 

		[DataMember(Name = "CustomerID", IsRequired = false, EmitDefaultValue = true)]			
        public int CustomerID 
		{ 
			get
			{
				return _customerID;
			}
			set
			{
				if(_customerID != value)
				{
					_customerID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region Enabled
		private bool _enabled; 

		[DataMember(Name = "Enabled", IsRequired = false, EmitDefaultValue = true)]			
        public bool Enabled 
		{ 
			get
			{
				return _enabled;
			}
			set
			{
				if(_enabled != value)
				{
					_enabled = value;
				} 
			}
		}
		#endregion
		
		#region Description
		private string _description; 

		[DataMember(Name = "Description", IsRequired = false, EmitDefaultValue = true)]			
        public string Description 
		{ 
			get
			{
				return _description;
			}
			set
			{
				if(_description != value)
				{
					_description = value;
				} 
			}
		}
		#endregion
		
		#region Address1
		private string _address1; 

		[DataMember(Name = "Address1", IsRequired = false, EmitDefaultValue = true)]			
        public string Address1 
		{ 
			get
			{
				return _address1;
			}
			set
			{
				if(_address1 != value)
				{
					_address1 = value;
				} 
			}
		}
		#endregion
		
		#region Address2
		private string _address2; 

		[DataMember(Name = "Address2", IsRequired = false, EmitDefaultValue = true)]			
        public string Address2 
		{ 
			get
			{
				return _address2;
			}
			set
			{
				if(_address2 != value)
				{
					_address2 = value;
				} 
			}
		}
		#endregion
		
		#region City
		private string _city; 

		[DataMember(Name = "City", IsRequired = false, EmitDefaultValue = true)]			
        public string City 
		{ 
			get
			{
				return _city;
			}
			set
			{
				if(_city != value)
				{
					_city = value;
				} 
			}
		}
		#endregion
		
		#region State
		private string _state; 

		[DataMember(Name = "State", IsRequired = false, EmitDefaultValue = true)]			
        public string State 
		{ 
			get
			{
				return _state;
			}
			set
			{
				if(_state != value)
				{
					_state = value;
				} 
			}
		}
		#endregion
		
		#region Country
		private string _country; 

		[DataMember(Name = "Country", IsRequired = false, EmitDefaultValue = true)]			
        public string Country 
		{ 
			get
			{
				return _country;
			}
			set
			{
				if(_country != value)
				{
					_country = value;
				} 
			}
		}
		#endregion
		
		#region PostalCode
		private string _postalCode; 

		[DataMember(Name = "PostalCode", IsRequired = false, EmitDefaultValue = true)]			
        public string PostalCode 
		{ 
			get
			{
				return _postalCode;
			}
			set
			{
				if(_postalCode != value)
				{
					_postalCode = value;
				} 
			}
		}
		#endregion
		
		#region Phone1
		private string _phone1; 

		[DataMember(Name = "Phone1", IsRequired = false, EmitDefaultValue = true)]			
        public string Phone1 
		{ 
			get
			{
				return _phone1;
			}
			set
			{
				if(_phone1 != value)
				{
					_phone1 = value;
				} 
			}
		}
		#endregion
		
		#region Phone2
		private string _phone2; 

		[DataMember(Name = "Phone2", IsRequired = false, EmitDefaultValue = true)]			
        public string Phone2 
		{ 
			get
			{
				return _phone2;
			}
			set
			{
				if(_phone2 != value)
				{
					_phone2 = value;
				} 
			}
		}
		#endregion
		
		#region Fax
		private string _fax; 

		[DataMember(Name = "Fax", IsRequired = false, EmitDefaultValue = true)]			
        public string Fax 
		{ 
			get
			{
				return _fax;
			}
			set
			{
				if(_fax != value)
				{
					_fax = value;
				} 
			}
		}
		#endregion
		
		#region HourlyRate
		private decimal _hourlyRate; 

		[DataMember(Name = "HourlyRate", IsRequired = false, EmitDefaultValue = true)]			
        public decimal HourlyRate 
		{ 
			get
			{
				return _hourlyRate;
			}
			set
			{
				if(_hourlyRate != value)
				{
					_hourlyRate = value;
				} 
			}
		}
		#endregion
		
		#region LastModificationDate
		private DateTime? _lastModificationDate; 

		[DataMember(Name = "LastModificationDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? LastModificationDate 
		{ 
			get
			{
				return _lastModificationDate;
			}
			set
			{
				if(_lastModificationDate != value)
				{
					_lastModificationDate = value;
				} 
			}
		}
		#endregion

	
	

		#region Custom fields
        private CustomFieldsCollection customFields;
		[DataMember(Name = "CustomFields")]
		public CustomFieldsCollection CustomFields 
		{
			get 
			{
				if (customFields == null) { customFields = new CustomFieldsCollection();}
				return customFields;
			}
			set{
				customFields = value;
			}
		}
		#endregion


    }
    #endregion
    
    #region CustomField entity
    /// <summary>
    /// Generated class for entity CustomField
    /// </summary>
	[DataContract(Name = "CustomField", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.CustomField")]
	public partial class CustomField     { 
		public int EntityBaseID { get { return Convert.ToInt32(FieldID);} set { FieldID = value; } }
		
		#region FieldID
		private int _fieldID; 

		[DataMember(Name = "FieldID", IsRequired = false, EmitDefaultValue = true)]			
        public int FieldID 
		{ 
			get
			{
				return _fieldID;
			}
			set
			{
				if(_fieldID != value)
				{
					_fieldID = value;
				} 
			}
		}
		#endregion
		
		#region FieldName
		private string _fieldName; 

		[DataMember(Name = "FieldName", IsRequired = false, EmitDefaultValue = true)]			
        public string FieldName 
		{ 
			get
			{
				return _fieldName;
			}
			set
			{
				if(_fieldName != value)
				{
					_fieldName = value;
				} 
			}
		}
		#endregion
		
		#region DisplayName
		private string _displayName; 

		[DataMember(Name = "DisplayName", IsRequired = false, EmitDefaultValue = true)]			
        public string DisplayName 
		{ 
			get
			{
				return _displayName;
			}
			set
			{
				if(_displayName != value)
				{
					_displayName = value;
				} 
			}
		}
		#endregion
		
		#region IsRequired
		private bool _isRequired; 

		[DataMember(Name = "IsRequired", IsRequired = false, EmitDefaultValue = true)]			
        public bool IsRequired 
		{ 
			get
			{
				return _isRequired;
			}
			set
			{
				if(_isRequired != value)
				{
					_isRequired = value;
				} 
			}
		}
		#endregion
		
		#region IsRestricted
		private bool _isRestricted; 

		[DataMember(Name = "IsRestricted", IsRequired = false, EmitDefaultValue = true)]			
        public bool IsRestricted 
		{ 
			get
			{
				return _isRestricted;
			}
			set
			{
				if(_isRestricted != value)
				{
					_isRestricted = value;
				} 
			}
		}
		#endregion
		
		#region Order
		private int? _order; 

		[DataMember(Name = "Order", IsRequired = false, EmitDefaultValue = true)]			
        public int? Order 
		{ 
			get
			{
				return _order;
			}
			set
			{
				if(_order != value)
				{
					_order = value;
				} 
			}
		}
		#endregion
		
		#region Description
		private string _description; 

		[DataMember(Name = "Description", IsRequired = false, EmitDefaultValue = true)]			
        public string Description 
		{ 
			get
			{
				return _description;
			}
			set
			{
				if(_description != value)
				{
					_description = value;
				} 
			}
		}
		#endregion
		
		#region Entity
		private int _entityID;
		[DataMember(Name = "EntityID")]
        public int EntityID 
		{ 
			get
			{
				return _entityID;
			}
			set
			{
				if(_entityID != value)
				{
					_entityID = value;
				} 
			}
		}
		
		#endregion
		
		#region FieldDataType
		private int _fieldDataTypeID;
		[DataMember(Name = "FieldDataTypeID")]
        public int FieldDataTypeID 
		{ 
			get
			{
				return _fieldDataTypeID;
			}
			set
			{
				if(_fieldDataTypeID != value)
				{
					_fieldDataTypeID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region CustomFieldDataType entity
    /// <summary>
    /// Generated class for entity CustomFieldDataType
    /// </summary>
	[DataContract(Name = "CustomFieldDataType", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.CustomFieldDataType")]
	public partial class CustomFieldDataType     { 
		public int EntityBaseID { get { return Convert.ToInt32(FieldDataTypeID);} set { FieldDataTypeID = value; } }
		
		#region FieldDataTypeID
		private int _fieldDataTypeID; 

		[DataMember(Name = "FieldDataTypeID", IsRequired = false, EmitDefaultValue = true)]			
        public int FieldDataTypeID 
		{ 
			get
			{
				return _fieldDataTypeID;
			}
			set
			{
				if(_fieldDataTypeID != value)
				{
					_fieldDataTypeID = value;
				} 
			}
		}
		#endregion
		
		#region DisplayName
		private string _displayName; 

		[DataMember(Name = "DisplayName", IsRequired = false, EmitDefaultValue = true)]			
        public string DisplayName 
		{ 
			get
			{
				return _displayName;
			}
			set
			{
				if(_displayName != value)
				{
					_displayName = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region CustomFieldEntity entity
    /// <summary>
    /// Generated class for entity CustomFieldEntity
    /// </summary>
	[DataContract(Name = "CustomFieldEntity", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.CustomFieldEntity")]
	public partial class CustomFieldEntity     { 
		public int EntityBaseID { get { return Convert.ToInt32(EntityID);} set { EntityID = value; } }
		
		#region EntityID
		private int _entityID; 

		[DataMember(Name = "EntityID", IsRequired = false, EmitDefaultValue = true)]			
        public int EntityID 
		{ 
			get
			{
				return _entityID;
			}
			set
			{
				if(_entityID != value)
				{
					_entityID = value;
				} 
			}
		}
		#endregion
		
		#region DisplayName
		private string _displayName; 

		[DataMember(Name = "DisplayName", IsRequired = false, EmitDefaultValue = true)]			
        public string DisplayName 
		{ 
			get
			{
				return _displayName;
			}
			set
			{
				if(_displayName != value)
				{
					_displayName = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region CustomFieldOrder entity
    /// <summary>
    /// Generated class for entity CustomFieldOrder
    /// </summary>
	[DataContract(Name = "CustomFieldOrder", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.CustomFieldOrder")]
	public partial class CustomFieldOrder     { 
		public int EntityBaseID { get { return Convert.ToInt32(FieldID);} set { FieldID = value; } }
		
		#region FieldID
		private int _fieldID; 

		[DataMember(Name = "FieldID", IsRequired = false, EmitDefaultValue = true)]			
        public int FieldID 
		{ 
			get
			{
				return _fieldID;
			}
			set
			{
				if(_fieldID != value)
				{
					_fieldID = value;
				} 
			}
		}
		#endregion
		
		#region Order
		private int _order; 

		[DataMember(Name = "Order", IsRequired = false, EmitDefaultValue = true)]			
        public int Order 
		{ 
			get
			{
				return _order;
			}
			set
			{
				if(_order != value)
				{
					_order = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region CustomFieldRestriction entity
    /// <summary>
    /// Generated class for entity CustomFieldRestriction
    /// </summary>
	[DataContract(Name = "CustomFieldRestriction", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.CustomFieldRestriction")]
	public partial class CustomFieldRestriction     { 
		public int EntityBaseID { get { return Convert.ToInt32(FieldRestrictionID);} set { FieldRestrictionID = value; } }
		
		#region FieldRestrictionID
		private int _fieldRestrictionID; 

		[DataMember(Name = "FieldRestrictionID", IsRequired = false, EmitDefaultValue = true)]			
        public int FieldRestrictionID 
		{ 
			get
			{
				return _fieldRestrictionID;
			}
			set
			{
				if(_fieldRestrictionID != value)
				{
					_fieldRestrictionID = value;
				} 
			}
		}
		#endregion
		
		#region Field
		private int _fieldID;
		[DataMember(Name = "FieldID")]
        public int FieldID 
		{ 
			get
			{
				return _fieldID;
			}
			set
			{
				if(_fieldID != value)
				{
					_fieldID = value;
				} 
			}
		}
		
		#endregion
		
		#region Portfolio
		private int _portfolioID;
		[DataMember(Name = "PortfolioID")]
        public int PortfolioID 
		{ 
			get
			{
				return _portfolioID;
			}
			set
			{
				if(_portfolioID != value)
				{
					_portfolioID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region CustomFieldValue entity
    /// <summary>
    /// Generated class for entity CustomFieldValue
    /// </summary>
	[DataContract(Name = "CustomFieldValue", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.CustomFieldValue")]
	public partial class CustomFieldValue     { 
		public int EntityBaseID { get { return Convert.ToInt32(FieldValueID);} set { FieldValueID = value; } }
		
		#region FieldValueID
		private int _fieldValueID; 

		[DataMember(Name = "FieldValueID", IsRequired = false, EmitDefaultValue = true)]			
        public int FieldValueID 
		{ 
			get
			{
				return _fieldValueID;
			}
			set
			{
				if(_fieldValueID != value)
				{
					_fieldValueID = value;
				} 
			}
		}
		#endregion
		
		#region Value
		private string _value; 

		[DataMember(Name = "Value", IsRequired = false, EmitDefaultValue = true)]			
        public string Value 
		{ 
			get
			{
				return _value;
			}
			set
			{
				if(_value != value)
				{
					_value = value;
				} 
			}
		}
		#endregion
		
		#region Field
		private int _fieldID;
		[DataMember(Name = "FieldID")]
        public int FieldID 
		{ 
			get
			{
				return _fieldID;
			}
			set
			{
				if(_fieldID != value)
				{
					_fieldID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region Event entity
    /// <summary>
    /// Generated class for entity Event
    /// </summary>
	[DataContract(Name = "Event", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Event")]
	public partial class Event     { 
		public int EntityBaseID { get { return Convert.ToInt32(EventID);} set { EventID = value; } }
		
		#region EventID
		private int _eventID; 

		[DataMember(Name = "EventID", IsRequired = false, EmitDefaultValue = true)]			
        public int EventID 
		{ 
			get
			{
				return _eventID;
			}
			set
			{
				if(_eventID != value)
				{
					_eventID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region Description
		private string _description; 

		[DataMember(Name = "Description", IsRequired = false, EmitDefaultValue = true)]			
        public string Description 
		{ 
			get
			{
				return _description;
			}
			set
			{
				if(_description != value)
				{
					_description = value;
				} 
			}
		}
		#endregion
		
		#region StartDate
		private DateTime _startDate; 

		[DataMember(Name = "StartDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime StartDate 
		{ 
			get
			{
				return _startDate;
			}
			set
			{
				if(_startDate != value)
				{
					_startDate = value;
				} 
			}
		}
		#endregion
		
		#region EndDate
		private DateTime? _endDate; 

		[DataMember(Name = "EndDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? EndDate 
		{ 
			get
			{
				return _endDate;
			}
			set
			{
				if(_endDate != value)
				{
					_endDate = value;
				} 
			}
		}
		#endregion
		
		#region Creator
		private int _creatorID;
		[DataMember(Name = "CreatorID")]
        public int CreatorID 
		{ 
			get
			{
				return _creatorID;
			}
			set
			{
				if(_creatorID != value)
				{
					_creatorID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region EventAssignee entity
    /// <summary>
    /// Generated class for entity EventAssignee
    /// </summary>
	[DataContract(Name = "EventAssignee", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.EventAssignee")]
	public partial class EventAssignee     { 
		public int EntityBaseID { get { return Convert.ToInt32(EventAssigneeID);} set { EventAssigneeID = value; } }
		
		#region EventAssigneeID
		private int _eventAssigneeID; 

		[DataMember(Name = "EventAssigneeID", IsRequired = false, EmitDefaultValue = true)]			
        public int EventAssigneeID 
		{ 
			get
			{
				return _eventAssigneeID;
			}
			set
			{
				if(_eventAssigneeID != value)
				{
					_eventAssigneeID = value;
				} 
			}
		}
		#endregion
		
		#region Event
		private int _eventID;
		[DataMember(Name = "EventID")]
        public int EventID 
		{ 
			get
			{
				return _eventID;
			}
			set
			{
				if(_eventID != value)
				{
					_eventID = value;
				} 
			}
		}
		
		#endregion
		
		#region User
		private int _userID;
		[DataMember(Name = "UserID")]
        public int UserID 
		{ 
			get
			{
				return _userID;
			}
			set
			{
				if(_userID != value)
				{
					_userID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region EventLog entity
    /// <summary>
    /// Generated class for entity EventLog
    /// </summary>
	[DataContract(Name = "EventLog", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.EventLog")]
	public partial class EventLog     { 
		public int EntityBaseID { get { return Convert.ToInt32(EntryID);} set { EntryID = value; } }
		
		#region EntryID
		private int _entryID; 

		[DataMember(Name = "EntryID", IsRequired = false, EmitDefaultValue = true)]			
        public int EntryID 
		{ 
			get
			{
				return _entryID;
			}
			set
			{
				if(_entryID != value)
				{
					_entryID = value;
				} 
			}
		}
		#endregion
		
		#region EntryDate
		private DateTime? _entryDate; 

		[DataMember(Name = "EntryDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? EntryDate 
		{ 
			get
			{
				return _entryDate;
			}
			set
			{
				if(_entryDate != value)
				{
					_entryDate = value;
				} 
			}
		}
		#endregion
		
		#region Category
		private string _category; 

		[DataMember(Name = "Category", IsRequired = false, EmitDefaultValue = true)]			
        public string Category 
		{ 
			get
			{
				return _category;
			}
			set
			{
				if(_category != value)
				{
					_category = value;
				} 
			}
		}
		#endregion
		
		#region EventType
		private string _eventType; 

		[DataMember(Name = "EventType", IsRequired = false, EmitDefaultValue = true)]			
        public string EventType 
		{ 
			get
			{
				return _eventType;
			}
			set
			{
				if(_eventType != value)
				{
					_eventType = value;
				} 
			}
		}
		#endregion
		
		#region Title
		private string _title; 

		[DataMember(Name = "Title", IsRequired = false, EmitDefaultValue = true)]			
        public string Title 
		{ 
			get
			{
				return _title;
			}
			set
			{
				if(_title != value)
				{
					_title = value;
				} 
			}
		}
		#endregion
		
		#region Message
		private string _message; 

		[DataMember(Name = "Message", IsRequired = false, EmitDefaultValue = true)]			
        public string Message 
		{ 
			get
			{
				return _message;
			}
			set
			{
				if(_message != value)
				{
					_message = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region EventUser entity
    /// <summary>
    /// Generated class for entity EventUser
    /// </summary>
	[DataContract(Name = "EventUser", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.EventUser")]
	public partial class EventUser     { 
		public int EntityBaseID { get { return Convert.ToInt32(EventUserID);} set { EventUserID = value; } }
		
		#region EventUserID
		private int _eventUserID; 

		[DataMember(Name = "EventUserID", IsRequired = false, EmitDefaultValue = true)]			
        public int EventUserID 
		{ 
			get
			{
				return _eventUserID;
			}
			set
			{
				if(_eventUserID != value)
				{
					_eventUserID = value;
				} 
			}
		}
		#endregion
		
		#region User
		private int _userID;
		[DataMember(Name = "UserID")]
        public int UserID 
		{ 
			get
			{
				return _userID;
			}
			set
			{
				if(_userID != value)
				{
					_userID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region FilterEntity entity
    /// <summary>
    /// Generated class for entity FilterEntity
    /// </summary>
	[DataContract(Name = "FilterEntity", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.FilterEntity")]
	public partial class FilterEntity     { 
		public int EntityBaseID { get { return Convert.ToInt32(FilterID);} set { FilterID = value; } }
		
		#region FilterID
		private int _filterID; 

		[DataMember(Name = "FilterID", IsRequired = false, EmitDefaultValue = true)]			
        public int FilterID 
		{ 
			get
			{
				return _filterID;
			}
			set
			{
				if(_filterID != value)
				{
					_filterID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region FilterXML
		private string _filterXML; 

		[DataMember(Name = "FilterXML", IsRequired = false, EmitDefaultValue = true)]			
        public string FilterXML 
		{ 
			get
			{
				return _filterXML;
			}
			set
			{
				if(_filterXML != value)
				{
					_filterXML = value;
				} 
			}
		}
		#endregion
		
		#region IsShared
		private bool? _isShared; 

		[DataMember(Name = "IsShared", IsRequired = false, EmitDefaultValue = true)]			
        public bool? IsShared 
		{ 
			get
			{
				return _isShared;
			}
			set
			{
				if(_isShared != value)
				{
					_isShared = value;
				} 
			}
		}
		#endregion
		
		#region User
		private int _userID;
		[DataMember(Name = "UserID")]
        public int UserID 
		{ 
			get
			{
				return _userID;
			}
			set
			{
				if(_userID != value)
				{
					_userID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region IssueType entity
    /// <summary>
    /// Generated class for entity IssueType
    /// </summary>
	[DataContract(Name = "IssueType", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.IssueType")]
	public partial class IssueType     { 
		public int EntityBaseID { get { return Convert.ToInt32(IssueTypeID);} set { IssueTypeID = value; } }
		
		#region IssueTypeID
		private int _issueTypeID; 

		[DataMember(Name = "IssueTypeID", IsRequired = false, EmitDefaultValue = true)]			
        public int IssueTypeID 
		{ 
			get
			{
				return _issueTypeID;
			}
			set
			{
				if(_issueTypeID != value)
				{
					_issueTypeID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region MemberPermission entity
    /// <summary>
    /// Generated class for entity MemberPermission
    /// </summary>
	[DataContract(Name = "MemberPermission", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.MemberPermission")]
	public partial class MemberPermission     { 
		public int EntityBaseID { get { return Convert.ToInt32(MemberPermissionID);} set { MemberPermissionID = value; } }
		
		#region MemberPermissionID
		private int _memberPermissionID; 

		[DataMember(Name = "MemberPermissionID", IsRequired = false, EmitDefaultValue = true)]			
        public int MemberPermissionID 
		{ 
			get
			{
				return _memberPermissionID;
			}
			set
			{
				if(_memberPermissionID != value)
				{
					_memberPermissionID = value;
				} 
			}
		}
		#endregion
		
		#region CanAccessAllTasks
		private bool _canAccessAllTasks; 

		[DataMember(Name = "CanAccessAllTasks", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanAccessAllTasks 
		{ 
			get
			{
				return _canAccessAllTasks;
			}
			set
			{
				if(_canAccessAllTasks != value)
				{
					_canAccessAllTasks = value;
				} 
			}
		}
		#endregion
		
		#region CanAccessAllIssues
		private bool _canAccessAllIssues; 

		[DataMember(Name = "CanAccessAllIssues", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanAccessAllIssues 
		{ 
			get
			{
				return _canAccessAllIssues;
			}
			set
			{
				if(_canAccessAllIssues != value)
				{
					_canAccessAllIssues = value;
				} 
			}
		}
		#endregion
		
		#region CanAccessAllRequests
		private bool _canAccessAllRequests; 

		[DataMember(Name = "CanAccessAllRequests", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanAccessAllRequests 
		{ 
			get
			{
				return _canAccessAllRequests;
			}
			set
			{
				if(_canAccessAllRequests != value)
				{
					_canAccessAllRequests = value;
				} 
			}
		}
		#endregion
		
		#region CanAccessAllTimeEntries
		private bool _canAccessAllTimeEntries; 

		[DataMember(Name = "CanAccessAllTimeEntries", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanAccessAllTimeEntries 
		{ 
			get
			{
				return _canAccessAllTimeEntries;
			}
			set
			{
				if(_canAccessAllTimeEntries != value)
				{
					_canAccessAllTimeEntries = value;
				} 
			}
		}
		#endregion
		
		#region CanEditProject
		private bool _canEditProject; 

		[DataMember(Name = "CanEditProject", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanEditProject 
		{ 
			get
			{
				return _canEditProject;
			}
			set
			{
				if(_canEditProject != value)
				{
					_canEditProject = value;
				} 
			}
		}
		#endregion
		
		#region CanEditAllTasks
		private bool _canEditAllTasks; 

		[DataMember(Name = "CanEditAllTasks", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanEditAllTasks 
		{ 
			get
			{
				return _canEditAllTasks;
			}
			set
			{
				if(_canEditAllTasks != value)
				{
					_canEditAllTasks = value;
				} 
			}
		}
		#endregion
		
		#region CanEditAllIssues
		private bool _canEditAllIssues; 

		[DataMember(Name = "CanEditAllIssues", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanEditAllIssues 
		{ 
			get
			{
				return _canEditAllIssues;
			}
			set
			{
				if(_canEditAllIssues != value)
				{
					_canEditAllIssues = value;
				} 
			}
		}
		#endregion
		
		#region CanEditAllRequests
		private bool _canEditAllRequests; 

		[DataMember(Name = "CanEditAllRequests", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanEditAllRequests 
		{ 
			get
			{
				return _canEditAllRequests;
			}
			set
			{
				if(_canEditAllRequests != value)
				{
					_canEditAllRequests = value;
				} 
			}
		}
		#endregion
		
		#region CanEditAssignedTasks
		private bool? _canEditAssignedTasks; 

		[DataMember(Name = "CanEditAssignedTasks", IsRequired = false, EmitDefaultValue = true)]			
        public bool? CanEditAssignedTasks 
		{ 
			get
			{
				return _canEditAssignedTasks;
			}
			set
			{
				if(_canEditAssignedTasks != value)
				{
					_canEditAssignedTasks = value;
				} 
			}
		}
		#endregion
		
		#region CanEditAssignedIssues
		private bool? _canEditAssignedIssues; 

		[DataMember(Name = "CanEditAssignedIssues", IsRequired = false, EmitDefaultValue = true)]			
        public bool? CanEditAssignedIssues 
		{ 
			get
			{
				return _canEditAssignedIssues;
			}
			set
			{
				if(_canEditAssignedIssues != value)
				{
					_canEditAssignedIssues = value;
				} 
			}
		}
		#endregion
		
		#region CanEditAssignedRequests
		private bool? _canEditAssignedRequests; 

		[DataMember(Name = "CanEditAssignedRequests", IsRequired = false, EmitDefaultValue = true)]			
        public bool? CanEditAssignedRequests 
		{ 
			get
			{
				return _canEditAssignedRequests;
			}
			set
			{
				if(_canEditAssignedRequests != value)
				{
					_canEditAssignedRequests = value;
				} 
			}
		}
		#endregion
		
		#region CanEditAllTimeEntries
		private bool _canEditAllTimeEntries; 

		[DataMember(Name = "CanEditAllTimeEntries", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanEditAllTimeEntries 
		{ 
			get
			{
				return _canEditAllTimeEntries;
			}
			set
			{
				if(_canEditAllTimeEntries != value)
				{
					_canEditAllTimeEntries = value;
				} 
			}
		}
		#endregion
		
		#region CanCreateTasks
		private bool _canCreateTasks; 

		[DataMember(Name = "CanCreateTasks", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanCreateTasks 
		{ 
			get
			{
				return _canCreateTasks;
			}
			set
			{
				if(_canCreateTasks != value)
				{
					_canCreateTasks = value;
				} 
			}
		}
		#endregion
		
		#region CanCreateIssues
		private bool _canCreateIssues; 

		[DataMember(Name = "CanCreateIssues", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanCreateIssues 
		{ 
			get
			{
				return _canCreateIssues;
			}
			set
			{
				if(_canCreateIssues != value)
				{
					_canCreateIssues = value;
				} 
			}
		}
		#endregion
		
		#region CanCreateRequests
		private bool _canCreateRequests; 

		[DataMember(Name = "CanCreateRequests", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanCreateRequests 
		{ 
			get
			{
				return _canCreateRequests;
			}
			set
			{
				if(_canCreateRequests != value)
				{
					_canCreateRequests = value;
				} 
			}
		}
		#endregion
		
		#region CanCreateTimeEntries
		private bool? _canCreateTimeEntries; 

		[DataMember(Name = "CanCreateTimeEntries", IsRequired = false, EmitDefaultValue = true)]			
        public bool? CanCreateTimeEntries 
		{ 
			get
			{
				return _canCreateTimeEntries;
			}
			set
			{
				if(_canCreateTimeEntries != value)
				{
					_canCreateTimeEntries = value;
				} 
			}
		}
		#endregion
		
		#region CanCreateTimeEntriesForOther
		private bool _canCreateTimeEntriesForOther; 

		[DataMember(Name = "CanCreateTimeEntriesForOther", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanCreateTimeEntriesForOther 
		{ 
			get
			{
				return _canCreateTimeEntriesForOther;
			}
			set
			{
				if(_canCreateTimeEntriesForOther != value)
				{
					_canCreateTimeEntriesForOther = value;
				} 
			}
		}
		#endregion
		
		#region CanDeleteProject
		private bool _canDeleteProject; 

		[DataMember(Name = "CanDeleteProject", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanDeleteProject 
		{ 
			get
			{
				return _canDeleteProject;
			}
			set
			{
				if(_canDeleteProject != value)
				{
					_canDeleteProject = value;
				} 
			}
		}
		#endregion
		
		#region CanDeleteAllTasks
		private bool _canDeleteAllTasks; 

		[DataMember(Name = "CanDeleteAllTasks", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanDeleteAllTasks 
		{ 
			get
			{
				return _canDeleteAllTasks;
			}
			set
			{
				if(_canDeleteAllTasks != value)
				{
					_canDeleteAllTasks = value;
				} 
			}
		}
		#endregion
		
		#region CanDeleteAllIssues
		private bool _canDeleteAllIssues; 

		[DataMember(Name = "CanDeleteAllIssues", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanDeleteAllIssues 
		{ 
			get
			{
				return _canDeleteAllIssues;
			}
			set
			{
				if(_canDeleteAllIssues != value)
				{
					_canDeleteAllIssues = value;
				} 
			}
		}
		#endregion
		
		#region CanDeleteAllRequests
		private bool _canDeleteAllRequests; 

		[DataMember(Name = "CanDeleteAllRequests", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanDeleteAllRequests 
		{ 
			get
			{
				return _canDeleteAllRequests;
			}
			set
			{
				if(_canDeleteAllRequests != value)
				{
					_canDeleteAllRequests = value;
				} 
			}
		}
		#endregion
		
		#region CanDeleteAssignedTasks
		private bool? _canDeleteAssignedTasks; 

		[DataMember(Name = "CanDeleteAssignedTasks", IsRequired = false, EmitDefaultValue = true)]			
        public bool? CanDeleteAssignedTasks 
		{ 
			get
			{
				return _canDeleteAssignedTasks;
			}
			set
			{
				if(_canDeleteAssignedTasks != value)
				{
					_canDeleteAssignedTasks = value;
				} 
			}
		}
		#endregion
		
		#region CanDeleteAssignedIssues
		private bool? _canDeleteAssignedIssues; 

		[DataMember(Name = "CanDeleteAssignedIssues", IsRequired = false, EmitDefaultValue = true)]			
        public bool? CanDeleteAssignedIssues 
		{ 
			get
			{
				return _canDeleteAssignedIssues;
			}
			set
			{
				if(_canDeleteAssignedIssues != value)
				{
					_canDeleteAssignedIssues = value;
				} 
			}
		}
		#endregion
		
		#region CanDeleteAssignedRequests
		private bool? _canDeleteAssignedRequests; 

		[DataMember(Name = "CanDeleteAssignedRequests", IsRequired = false, EmitDefaultValue = true)]			
        public bool? CanDeleteAssignedRequests 
		{ 
			get
			{
				return _canDeleteAssignedRequests;
			}
			set
			{
				if(_canDeleteAssignedRequests != value)
				{
					_canDeleteAssignedRequests = value;
				} 
			}
		}
		#endregion
		
		#region CanDeleteAllTimeEntries
		private bool _canDeleteAllTimeEntries; 

		[DataMember(Name = "CanDeleteAllTimeEntries", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanDeleteAllTimeEntries 
		{ 
			get
			{
				return _canDeleteAllTimeEntries;
			}
			set
			{
				if(_canDeleteAllTimeEntries != value)
				{
					_canDeleteAllTimeEntries = value;
				} 
			}
		}
		#endregion
		
		#region CanManageAssigneesTasks
		private bool? _canManageAssigneesTasks; 

		[DataMember(Name = "CanManageAssigneesTasks", IsRequired = false, EmitDefaultValue = true)]			
        public bool? CanManageAssigneesTasks 
		{ 
			get
			{
				return _canManageAssigneesTasks;
			}
			set
			{
				if(_canManageAssigneesTasks != value)
				{
					_canManageAssigneesTasks = value;
				} 
			}
		}
		#endregion
		
		#region CanManageAssigneesIssues
		private bool? _canManageAssigneesIssues; 

		[DataMember(Name = "CanManageAssigneesIssues", IsRequired = false, EmitDefaultValue = true)]			
        public bool? CanManageAssigneesIssues 
		{ 
			get
			{
				return _canManageAssigneesIssues;
			}
			set
			{
				if(_canManageAssigneesIssues != value)
				{
					_canManageAssigneesIssues = value;
				} 
			}
		}
		#endregion
		
		#region CanManageAssigneesRequests
		private bool? _canManageAssigneesRequests; 

		[DataMember(Name = "CanManageAssigneesRequests", IsRequired = false, EmitDefaultValue = true)]			
        public bool? CanManageAssigneesRequests 
		{ 
			get
			{
				return _canManageAssigneesRequests;
			}
			set
			{
				if(_canManageAssigneesRequests != value)
				{
					_canManageAssigneesRequests = value;
				} 
			}
		}
		#endregion
		
		#region CanViewMembersAndAssignees
		private bool? _canViewMembersAndAssignees; 

		[DataMember(Name = "CanViewMembersAndAssignees", IsRequired = false, EmitDefaultValue = true)]			
        public bool? CanViewMembersAndAssignees 
		{ 
			get
			{
				return _canViewMembersAndAssignees;
			}
			set
			{
				if(_canViewMembersAndAssignees != value)
				{
					_canViewMembersAndAssignees = value;
				} 
			}
		}
		#endregion
		
		#region CanManageProjectMembers
		private bool? _canManageProjectMembers; 

		[DataMember(Name = "CanManageProjectMembers", IsRequired = false, EmitDefaultValue = true)]			
        public bool? CanManageProjectMembers 
		{ 
			get
			{
				return _canManageProjectMembers;
			}
			set
			{
				if(_canManageProjectMembers != value)
				{
					_canManageProjectMembers = value;
				} 
			}
		}
		#endregion
		
		#region CanManage
		private bool? _canManage; 

		[DataMember(Name = "CanManage", IsRequired = false, EmitDefaultValue = true)]			
        public bool? CanManage 
		{ 
			get
			{
				return _canManage;
			}
			set
			{
				if(_canManage != value)
				{
					_canManage = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region Message entity
    /// <summary>
    /// Generated class for entity Message
    /// </summary>
	[DataContract(Name = "Message", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Message")]
	public partial class Message     { 
		public int EntityBaseID { get { return Convert.ToInt32(MessageID);} set { MessageID = value; } }
		
		#region MessageID
		private int _messageID; 

		[DataMember(Name = "MessageID", IsRequired = false, EmitDefaultValue = true)]			
        public int MessageID 
		{ 
			get
			{
				return _messageID;
			}
			set
			{
				if(_messageID != value)
				{
					_messageID = value;
				} 
			}
		}
		#endregion
		
		#region PostDate
		private DateTime _postDate; 

		[DataMember(Name = "PostDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime PostDate 
		{ 
			get
			{
				return _postDate;
			}
			set
			{
				if(_postDate != value)
				{
					_postDate = value;
				} 
			}
		}
		#endregion
		
		#region MessageText
		private string _messageText; 

		[DataMember(Name = "MessageText", IsRequired = false, EmitDefaultValue = true)]			
        public string MessageText 
		{ 
			get
			{
				return _messageText;
			}
			set
			{
				if(_messageText != value)
				{
					_messageText = value;
				} 
			}
		}
		#endregion
		
		#region Task
		private int _taskID;
		[DataMember(Name = "TaskID")]
        public int TaskID 
		{ 
			get
			{
				return _taskID;
			}
			set
			{
				if(_taskID != value)
				{
					_taskID = value;
				} 
			}
		}
		
		#endregion
		
		#region Project
		private int _projectID;
		[DataMember(Name = "ProjectID")]
        public int ProjectID 
		{ 
			get
			{
				return _projectID;
			}
			set
			{
				if(_projectID != value)
				{
					_projectID = value;
				} 
			}
		}
		
		#endregion
		
		#region User
		private int _userID;
		[DataMember(Name = "UserID")]
        public int UserID 
		{ 
			get
			{
				return _userID;
			}
			set
			{
				if(_userID != value)
				{
					_userID = value;
				} 
			}
		}
		
		#endregion

		#region Additional Permissions Fields		
		
		[DataMember(Name = "CanEditEntity")]
        public bool CanEditEntity  {get; set;}
		#endregion		
	
	


    }
    #endregion
    
    #region Options entity
    /// <summary>
    /// Generated class for entity Options
    /// </summary>
	[DataContract(Name = "Options", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Options")]
	public partial class Options     { 
		public int EntityBaseID { get { return Convert.ToInt32(OptionsID);} set { OptionsID = value; } }
		
		#region OptionsID
		private int _optionsID; 

		[DataMember(Name = "OptionsID", IsRequired = false, EmitDefaultValue = true)]			
        public int OptionsID 
		{ 
			get
			{
				return _optionsID;
			}
			set
			{
				if(_optionsID != value)
				{
					_optionsID = value;
				} 
			}
		}
		#endregion
		
		#region ApplicationRoot
		private string _applicationRoot; 

		[DataMember(Name = "ApplicationRoot", IsRequired = false, EmitDefaultValue = true)]			
        public string ApplicationRoot 
		{ 
			get
			{
				return _applicationRoot;
			}
			set
			{
				if(_applicationRoot != value)
				{
					_applicationRoot = value;
				} 
			}
		}
		#endregion
		
		#region CompanyLogo
		private string _companyLogo; 

		[DataMember(Name = "CompanyLogo", IsRequired = false, EmitDefaultValue = true)]			
        public string CompanyLogo 
		{ 
			get
			{
				return _companyLogo;
			}
			set
			{
				if(_companyLogo != value)
				{
					_companyLogo = value;
				} 
			}
		}
		#endregion
		
		#region WeekendsAsWorkdays
		private bool _weekendsAsWorkdays; 

		[DataMember(Name = "WeekendsAsWorkdays", IsRequired = false, EmitDefaultValue = true)]			
        public bool WeekendsAsWorkdays 
		{ 
			get
			{
				return _weekendsAsWorkdays;
			}
			set
			{
				if(_weekendsAsWorkdays != value)
				{
					_weekendsAsWorkdays = value;
				} 
			}
		}
		#endregion
		
		#region EnableNotifications
		private bool _enableNotifications; 

		[DataMember(Name = "EnableNotifications", IsRequired = false, EmitDefaultValue = true)]			
        public bool EnableNotifications 
		{ 
			get
			{
				return _enableNotifications;
			}
			set
			{
				if(_enableNotifications != value)
				{
					_enableNotifications = value;
				} 
			}
		}
		#endregion
		
		#region ShowStatusSymbols
		private bool _showStatusSymbols; 

		[DataMember(Name = "ShowStatusSymbols", IsRequired = false, EmitDefaultValue = true)]			
        public bool ShowStatusSymbols 
		{ 
			get
			{
				return _showStatusSymbols;
			}
			set
			{
				if(_showStatusSymbols != value)
				{
					_showStatusSymbols = value;
				} 
			}
		}
		#endregion
		
		#region ShowGraphPercentage
		private bool _showGraphPercentage; 

		[DataMember(Name = "ShowGraphPercentage", IsRequired = false, EmitDefaultValue = true)]			
        public bool ShowGraphPercentage 
		{ 
			get
			{
				return _showGraphPercentage;
			}
			set
			{
				if(_showGraphPercentage != value)
				{
					_showGraphPercentage = value;
				} 
			}
		}
		#endregion
		
		#region MailFromName
		private string _mailFromName; 

		[DataMember(Name = "MailFromName", IsRequired = false, EmitDefaultValue = true)]			
        public string MailFromName 
		{ 
			get
			{
				return _mailFromName;
			}
			set
			{
				if(_mailFromName != value)
				{
					_mailFromName = value;
				} 
			}
		}
		#endregion
		
		#region MailFromAddress
		private string _mailFromAddress; 

		[DataMember(Name = "MailFromAddress", IsRequired = false, EmitDefaultValue = true)]			
        public string MailFromAddress 
		{ 
			get
			{
				return _mailFromAddress;
			}
			set
			{
				if(_mailFromAddress != value)
				{
					_mailFromAddress = value;
				} 
			}
		}
		#endregion
		
		#region SmtpServer
		private string _smtpServer; 

		[DataMember(Name = "SmtpServer", IsRequired = false, EmitDefaultValue = true)]			
        public string SmtpServer 
		{ 
			get
			{
				return _smtpServer;
			}
			set
			{
				if(_smtpServer != value)
				{
					_smtpServer = value;
				} 
			}
		}
		#endregion
		
		#region SmtpPort
		private int _smtpPort; 

		[DataMember(Name = "SmtpPort", IsRequired = false, EmitDefaultValue = true)]			
        public int SmtpPort 
		{ 
			get
			{
				return _smtpPort;
			}
			set
			{
				if(_smtpPort != value)
				{
					_smtpPort = value;
				} 
			}
		}
		#endregion
		
		#region SmtpUserName
		private string _smtpUserName; 

		[DataMember(Name = "SmtpUserName", IsRequired = false, EmitDefaultValue = true)]			
        public string SmtpUserName 
		{ 
			get
			{
				return _smtpUserName;
			}
			set
			{
				if(_smtpUserName != value)
				{
					_smtpUserName = value;
				} 
			}
		}
		#endregion
		
		#region SmtpPassword
		private string _smtpPassword; 

		[DataMember(Name = "SmtpPassword", IsRequired = false, EmitDefaultValue = true)]			
        public string SmtpPassword 
		{ 
			get
			{
				return _smtpPassword;
			}
			set
			{
				if(_smtpPassword != value)
				{
					_smtpPassword = value;
				} 
			}
		}
		#endregion
		
		#region EnableIssueByMail
		private bool _enableIssueByMail; 

		[DataMember(Name = "EnableIssueByMail", IsRequired = false, EmitDefaultValue = true)]			
        public bool EnableIssueByMail 
		{ 
			get
			{
				return _enableIssueByMail;
			}
			set
			{
				if(_enableIssueByMail != value)
				{
					_enableIssueByMail = value;
				} 
			}
		}
		#endregion
		
		#region Pop3Server
		private string _pop3Server; 

		[DataMember(Name = "Pop3Server", IsRequired = false, EmitDefaultValue = true)]			
        public string Pop3Server 
		{ 
			get
			{
				return _pop3Server;
			}
			set
			{
				if(_pop3Server != value)
				{
					_pop3Server = value;
				} 
			}
		}
		#endregion
		
		#region Pop3Port
		private int _pop3Port; 

		[DataMember(Name = "Pop3Port", IsRequired = false, EmitDefaultValue = true)]			
        public int Pop3Port 
		{ 
			get
			{
				return _pop3Port;
			}
			set
			{
				if(_pop3Port != value)
				{
					_pop3Port = value;
				} 
			}
		}
		#endregion
		
		#region Pop3UserName
		private string _pop3UserName; 

		[DataMember(Name = "Pop3UserName", IsRequired = false, EmitDefaultValue = true)]			
        public string Pop3UserName 
		{ 
			get
			{
				return _pop3UserName;
			}
			set
			{
				if(_pop3UserName != value)
				{
					_pop3UserName = value;
				} 
			}
		}
		#endregion
		
		#region Pop3Password
		private string _pop3Password; 

		[DataMember(Name = "Pop3Password", IsRequired = false, EmitDefaultValue = true)]			
        public string Pop3Password 
		{ 
			get
			{
				return _pop3Password;
			}
			set
			{
				if(_pop3Password != value)
				{
					_pop3Password = value;
				} 
			}
		}
		#endregion
		
		#region DeleteLetters
		private bool _deleteLetters; 

		[DataMember(Name = "DeleteLetters", IsRequired = false, EmitDefaultValue = true)]			
        public bool DeleteLetters 
		{ 
			get
			{
				return _deleteLetters;
			}
			set
			{
				if(_deleteLetters != value)
				{
					_deleteLetters = value;
				} 
			}
		}
		#endregion
		
		#region EnableSSL
		private bool _enableSSL; 

		[DataMember(Name = "EnableSSL", IsRequired = false, EmitDefaultValue = true)]			
        public bool EnableSSL 
		{ 
			get
			{
				return _enableSSL;
			}
			set
			{
				if(_enableSSL != value)
				{
					_enableSSL = value;
				} 
			}
		}
		#endregion
		
		#region CheckupInterval
		private int _checkupInterval; 

		[DataMember(Name = "CheckupInterval", IsRequired = false, EmitDefaultValue = true)]			
        public int CheckupInterval 
		{ 
			get
			{
				return _checkupInterval;
			}
			set
			{
				if(_checkupInterval != value)
				{
					_checkupInterval = value;
				} 
			}
		}
		#endregion
		
		#region NotifyCreator
		private bool _notifyCreator; 

		[DataMember(Name = "NotifyCreator", IsRequired = false, EmitDefaultValue = true)]			
        public bool NotifyCreator 
		{ 
			get
			{
				return _notifyCreator;
			}
			set
			{
				if(_notifyCreator != value)
				{
					_notifyCreator = value;
				} 
			}
		}
		#endregion
		
		#region NotifyWhoMadeChange
		private bool _notifyWhoMadeChange; 

		[DataMember(Name = "NotifyWhoMadeChange", IsRequired = false, EmitDefaultValue = true)]			
        public bool NotifyWhoMadeChange 
		{ 
			get
			{
				return _notifyWhoMadeChange;
			}
			set
			{
				if(_notifyWhoMadeChange != value)
				{
					_notifyWhoMadeChange = value;
				} 
			}
		}
		#endregion
		
		#region NotifyAssignees
		private bool _notifyAssignees; 

		[DataMember(Name = "NotifyAssignees", IsRequired = false, EmitDefaultValue = true)]			
        public bool NotifyAssignees 
		{ 
			get
			{
				return _notifyAssignees;
			}
			set
			{
				if(_notifyAssignees != value)
				{
					_notifyAssignees = value;
				} 
			}
		}
		#endregion
		
		#region NotifyEventEdit
		private bool _notifyEventEdit; 

		[DataMember(Name = "NotifyEventEdit", IsRequired = false, EmitDefaultValue = true)]			
        public bool NotifyEventEdit 
		{ 
			get
			{
				return _notifyEventEdit;
			}
			set
			{
				if(_notifyEventEdit != value)
				{
					_notifyEventEdit = value;
				} 
			}
		}
		#endregion
		
		#region NotifyEventAssign
		private bool _notifyEventAssign; 

		[DataMember(Name = "NotifyEventAssign", IsRequired = false, EmitDefaultValue = true)]			
        public bool NotifyEventAssign 
		{ 
			get
			{
				return _notifyEventAssign;
			}
			set
			{
				if(_notifyEventAssign != value)
				{
					_notifyEventAssign = value;
				} 
			}
		}
		#endregion
		
		#region NotifyEventDelete
		private bool _notifyEventDelete; 

		[DataMember(Name = "NotifyEventDelete", IsRequired = false, EmitDefaultValue = true)]			
        public bool NotifyEventDelete 
		{ 
			get
			{
				return _notifyEventDelete;
			}
			set
			{
				if(_notifyEventDelete != value)
				{
					_notifyEventDelete = value;
				} 
			}
		}
		#endregion
		
		#region NotifyProjectManagersVacationChanged
		private bool _notifyProjectManagersVacationChanged; 

		[DataMember(Name = "NotifyProjectManagersVacationChanged", IsRequired = false, EmitDefaultValue = true)]			
        public bool NotifyProjectManagersVacationChanged 
		{ 
			get
			{
				return _notifyProjectManagersVacationChanged;
			}
			set
			{
				if(_notifyProjectManagersVacationChanged != value)
				{
					_notifyProjectManagersVacationChanged = value;
				} 
			}
		}
		#endregion
		
		#region PasswordHashKey
		private string _passwordHashKey; 

		[DataMember(Name = "PasswordHashKey", IsRequired = false, EmitDefaultValue = true)]			
        public string PasswordHashKey 
		{ 
			get
			{
				return _passwordHashKey;
			}
			set
			{
				if(_passwordHashKey != value)
				{
					_passwordHashKey = value;
				} 
			}
		}
		#endregion
		
		#region EnableSmarterTrackIntegration
		private bool _enableSmarterTrackIntegration; 

		[DataMember(Name = "EnableSmarterTrackIntegration", IsRequired = false, EmitDefaultValue = true)]			
        public bool EnableSmarterTrackIntegration 
		{ 
			get
			{
				return _enableSmarterTrackIntegration;
			}
			set
			{
				if(_enableSmarterTrackIntegration != value)
				{
					_enableSmarterTrackIntegration = value;
				} 
			}
		}
		#endregion
		
		#region SmarterTrackAgentUserName
		private string _smarterTrackAgentUserName; 

		[DataMember(Name = "SmarterTrackAgentUserName", IsRequired = false, EmitDefaultValue = true)]			
        public string SmarterTrackAgentUserName 
		{ 
			get
			{
				return _smarterTrackAgentUserName;
			}
			set
			{
				if(_smarterTrackAgentUserName != value)
				{
					_smarterTrackAgentUserName = value;
				} 
			}
		}
		#endregion
		
		#region SmarterTrackAgentPassword
		private string _smarterTrackAgentPassword; 

		[DataMember(Name = "SmarterTrackAgentPassword", IsRequired = false, EmitDefaultValue = true)]			
        public string SmarterTrackAgentPassword 
		{ 
			get
			{
				return _smarterTrackAgentPassword;
			}
			set
			{
				if(_smarterTrackAgentPassword != value)
				{
					_smarterTrackAgentPassword = value;
				} 
			}
		}
		#endregion
		
		#region SmarterTrackUrl
		private string _smarterTrackUrl; 

		[DataMember(Name = "SmarterTrackUrl", IsRequired = false, EmitDefaultValue = true)]			
        public string SmarterTrackUrl 
		{ 
			get
			{
				return _smarterTrackUrl;
			}
			set
			{
				if(_smarterTrackUrl != value)
				{
					_smarterTrackUrl = value;
				} 
			}
		}
		#endregion
		
		#region ShowPortfolios
		private bool _showPortfolios; 

		[DataMember(Name = "ShowPortfolios", IsRequired = false, EmitDefaultValue = true)]			
        public bool ShowPortfolios 
		{ 
			get
			{
				return _showPortfolios;
			}
			set
			{
				if(_showPortfolios != value)
				{
					_showPortfolios = value;
				} 
			}
		}
		#endregion
		
		#region EnableApproveWorkflow
		private bool _enableApproveWorkflow; 

		[DataMember(Name = "EnableApproveWorkflow", IsRequired = false, EmitDefaultValue = true)]			
        public bool EnableApproveWorkflow 
		{ 
			get
			{
				return _enableApproveWorkflow;
			}
			set
			{
				if(_enableApproveWorkflow != value)
				{
					_enableApproveWorkflow = value;
				} 
			}
		}
		#endregion
		
		#region CreatorAsApprover
		private bool _creatorAsApprover; 

		[DataMember(Name = "CreatorAsApprover", IsRequired = false, EmitDefaultValue = true)]			
        public bool CreatorAsApprover 
		{ 
			get
			{
				return _creatorAsApprover;
			}
			set
			{
				if(_creatorAsApprover != value)
				{
					_creatorAsApprover = value;
				} 
			}
		}
		#endregion
		
		#region PMAsApprover
		private bool _pMAsApprover; 

		[DataMember(Name = "PMAsApprover", IsRequired = false, EmitDefaultValue = true)]			
        public bool PMAsApprover 
		{ 
			get
			{
				return _pMAsApprover;
			}
			set
			{
				if(_pMAsApprover != value)
				{
					_pMAsApprover = value;
				} 
			}
		}
		#endregion
		
		#region NumberOfHoursPerDay
		private decimal _numberOfHoursPerDay; 

		[DataMember(Name = "NumberOfHoursPerDay", IsRequired = false, EmitDefaultValue = true)]			
        public decimal NumberOfHoursPerDay 
		{ 
			get
			{
				return _numberOfHoursPerDay;
			}
			set
			{
				if(_numberOfHoursPerDay != value)
				{
					_numberOfHoursPerDay = value;
				} 
			}
		}
		#endregion
		
		#region SPIThreshold
		private decimal _sPIThreshold; 

		[DataMember(Name = "SPIThreshold", IsRequired = false, EmitDefaultValue = true)]			
        public decimal SPIThreshold 
		{ 
			get
			{
				return _sPIThreshold;
			}
			set
			{
				if(_sPIThreshold != value)
				{
					_sPIThreshold = value;
				} 
			}
		}
		#endregion
		
		#region CPIThreshold
		private decimal _cPIThreshold; 

		[DataMember(Name = "CPIThreshold", IsRequired = false, EmitDefaultValue = true)]			
        public decimal CPIThreshold 
		{ 
			get
			{
				return _cPIThreshold;
			}
			set
			{
				if(_cPIThreshold != value)
				{
					_cPIThreshold = value;
				} 
			}
		}
		#endregion
		
		#region VacationYearStartDate
		private DateTime _vacationYearStartDate; 

		[DataMember(Name = "VacationYearStartDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime VacationYearStartDate 
		{ 
			get
			{
				return _vacationYearStartDate;
			}
			set
			{
				if(_vacationYearStartDate != value)
				{
					_vacationYearStartDate = value;
				} 
			}
		}
		#endregion
		
		#region TrackHoursLeft
		private bool _trackHoursLeft; 

		[DataMember(Name = "TrackHoursLeft", IsRequired = false, EmitDefaultValue = true)]			
        public bool TrackHoursLeft 
		{ 
			get
			{
				return _trackHoursLeft;
			}
			set
			{
				if(_trackHoursLeft != value)
				{
					_trackHoursLeft = value;
				} 
			}
		}
		#endregion
		
		#region CNRAvailable
		private bool _cNRAvailable; 

		[DataMember(Name = "CNRAvailable", IsRequired = false, EmitDefaultValue = true)]			
        public bool CNRAvailable 
		{ 
			get
			{
				return _cNRAvailable;
			}
			set
			{
				if(_cNRAvailable != value)
				{
					_cNRAvailable = value;
				} 
			}
		}
		#endregion
		
		#region EnforceProhibitedWordsPolicy
		private bool _enforceProhibitedWordsPolicy; 

		[DataMember(Name = "EnforceProhibitedWordsPolicy", IsRequired = false, EmitDefaultValue = true)]			
        public bool EnforceProhibitedWordsPolicy 
		{ 
			get
			{
				return _enforceProhibitedWordsPolicy;
			}
			set
			{
				if(_enforceProhibitedWordsPolicy != value)
				{
					_enforceProhibitedWordsPolicy = value;
				} 
			}
		}
		#endregion
		
		#region EnforcePasswordStrength
		private bool _enforcePasswordStrength; 

		[DataMember(Name = "EnforcePasswordStrength", IsRequired = false, EmitDefaultValue = true)]			
        public bool EnforcePasswordStrength 
		{ 
			get
			{
				return _enforcePasswordStrength;
			}
			set
			{
				if(_enforcePasswordStrength != value)
				{
					_enforcePasswordStrength = value;
				} 
			}
		}
		#endregion
		
		#region PasswordLength
		private int _passwordLength; 

		[DataMember(Name = "PasswordLength", IsRequired = false, EmitDefaultValue = true)]			
        public int PasswordLength 
		{ 
			get
			{
				return _passwordLength;
			}
			set
			{
				if(_passwordLength != value)
				{
					_passwordLength = value;
				} 
			}
		}
		#endregion
		
		#region PasswordNumbersCount
		private int _passwordNumbersCount; 

		[DataMember(Name = "PasswordNumbersCount", IsRequired = false, EmitDefaultValue = true)]			
        public int PasswordNumbersCount 
		{ 
			get
			{
				return _passwordNumbersCount;
			}
			set
			{
				if(_passwordNumbersCount != value)
				{
					_passwordNumbersCount = value;
				} 
			}
		}
		#endregion
		
		#region PasswordSpecSymbolsCount
		private int _passwordSpecSymbolsCount; 

		[DataMember(Name = "PasswordSpecSymbolsCount", IsRequired = false, EmitDefaultValue = true)]			
        public int PasswordSpecSymbolsCount 
		{ 
			get
			{
				return _passwordSpecSymbolsCount;
			}
			set
			{
				if(_passwordSpecSymbolsCount != value)
				{
					_passwordSpecSymbolsCount = value;
				} 
			}
		}
		#endregion
		
		#region LockOutUserAfterInvalidPassword
		private bool _lockOutUserAfterInvalidPassword; 

		[DataMember(Name = "LockOutUserAfterInvalidPassword", IsRequired = false, EmitDefaultValue = true)]			
        public bool LockOutUserAfterInvalidPassword 
		{ 
			get
			{
				return _lockOutUserAfterInvalidPassword;
			}
			set
			{
				if(_lockOutUserAfterInvalidPassword != value)
				{
					_lockOutUserAfterInvalidPassword = value;
				} 
			}
		}
		#endregion
		
		#region InvalidPasswordAttempts
		private int _invalidPasswordAttempts; 

		[DataMember(Name = "InvalidPasswordAttempts", IsRequired = false, EmitDefaultValue = true)]			
        public int InvalidPasswordAttempts 
		{ 
			get
			{
				return _invalidPasswordAttempts;
			}
			set
			{
				if(_invalidPasswordAttempts != value)
				{
					_invalidPasswordAttempts = value;
				} 
			}
		}
		#endregion
		
		#region UnblockOnRecovery
		private bool _unblockOnRecovery; 

		[DataMember(Name = "UnblockOnRecovery", IsRequired = false, EmitDefaultValue = true)]			
        public bool UnblockOnRecovery 
		{ 
			get
			{
				return _unblockOnRecovery;
			}
			set
			{
				if(_unblockOnRecovery != value)
				{
					_unblockOnRecovery = value;
				} 
			}
		}
		#endregion
		
		#region UnblockAutomatically
		private bool _unblockAutomatically; 

		[DataMember(Name = "UnblockAutomatically", IsRequired = false, EmitDefaultValue = true)]			
        public bool UnblockAutomatically 
		{ 
			get
			{
				return _unblockAutomatically;
			}
			set
			{
				if(_unblockAutomatically != value)
				{
					_unblockAutomatically = value;
				} 
			}
		}
		#endregion
		
		#region UnblockAutomaticallyIn
		private int _unblockAutomaticallyIn; 

		[DataMember(Name = "UnblockAutomaticallyIn", IsRequired = false, EmitDefaultValue = true)]			
        public int UnblockAutomaticallyIn 
		{ 
			get
			{
				return _unblockAutomaticallyIn;
			}
			set
			{
				if(_unblockAutomaticallyIn != value)
				{
					_unblockAutomaticallyIn = value;
				} 
			}
		}
		#endregion
		
		#region LockoutUserDueToInactivity
		private bool _lockoutUserDueToInactivity; 

		[DataMember(Name = "LockoutUserDueToInactivity", IsRequired = false, EmitDefaultValue = true)]			
        public bool LockoutUserDueToInactivity 
		{ 
			get
			{
				return _lockoutUserDueToInactivity;
			}
			set
			{
				if(_lockoutUserDueToInactivity != value)
				{
					_lockoutUserDueToInactivity = value;
				} 
			}
		}
		#endregion
		
		#region MaxUserInactivity
		private int _maxUserInactivity; 

		[DataMember(Name = "MaxUserInactivity", IsRequired = false, EmitDefaultValue = true)]			
        public int MaxUserInactivity 
		{ 
			get
			{
				return _maxUserInactivity;
			}
			set
			{
				if(_maxUserInactivity != value)
				{
					_maxUserInactivity = value;
				} 
			}
		}
		#endregion
		
		#region EnablePasswordExpiration
		private bool _enablePasswordExpiration; 

		[DataMember(Name = "EnablePasswordExpiration", IsRequired = false, EmitDefaultValue = true)]			
        public bool EnablePasswordExpiration 
		{ 
			get
			{
				return _enablePasswordExpiration;
			}
			set
			{
				if(_enablePasswordExpiration != value)
				{
					_enablePasswordExpiration = value;
				} 
			}
		}
		#endregion
		
		#region PasswordExpiration
		private int _passwordExpiration; 

		[DataMember(Name = "PasswordExpiration", IsRequired = false, EmitDefaultValue = true)]			
        public int PasswordExpiration 
		{ 
			get
			{
				return _passwordExpiration;
			}
			set
			{
				if(_passwordExpiration != value)
				{
					_passwordExpiration = value;
				} 
			}
		}
		#endregion
		
		#region Project
		private int _projectID;
		[DataMember(Name = "ProjectID")]
        public int ProjectID 
		{ 
			get
			{
				return _projectID;
			}
			set
			{
				if(_projectID != value)
				{
					_projectID = value;
				} 
			}
		}
		
		#endregion
		
		#region User
		private int _userID;
		[DataMember(Name = "UserID")]
        public int UserID 
		{ 
			get
			{
				return _userID;
			}
			set
			{
				if(_userID != value)
				{
					_userID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region Payment entity
    /// <summary>
    /// Generated class for entity Payment
    /// </summary>
	[DataContract(Name = "Payment", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Payment")]
	public partial class Payment     { 
		public int EntityBaseID { get { return Convert.ToInt32(PaymentID);} set { PaymentID = value; } }
		
		#region PaymentID
		private int _paymentID; 

		[DataMember(Name = "PaymentID", IsRequired = false, EmitDefaultValue = true)]			
        public int PaymentID 
		{ 
			get
			{
				return _paymentID;
			}
			set
			{
				if(_paymentID != value)
				{
					_paymentID = value;
				} 
			}
		}
		#endregion
		
		#region PaymentDate
		private DateTime _paymentDate; 

		[DataMember(Name = "PaymentDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime PaymentDate 
		{ 
			get
			{
				return _paymentDate;
			}
			set
			{
				if(_paymentDate != value)
				{
					_paymentDate = value;
				} 
			}
		}
		#endregion
		
		#region Amount
		private decimal _amount; 

		[DataMember(Name = "Amount", IsRequired = false, EmitDefaultValue = true)]			
        public decimal Amount 
		{ 
			get
			{
				return _amount;
			}
			set
			{
				if(_amount != value)
				{
					_amount = value;
				} 
			}
		}
		#endregion
		
		#region Description
		private string _description; 

		[DataMember(Name = "Description", IsRequired = false, EmitDefaultValue = true)]			
        public string Description 
		{ 
			get
			{
				return _description;
			}
			set
			{
				if(_description != value)
				{
					_description = value;
				} 
			}
		}
		#endregion
		
		#region Project
		private int _projectID;
		[DataMember(Name = "ProjectID")]
        public int ProjectID 
		{ 
			get
			{
				return _projectID;
			}
			set
			{
				if(_projectID != value)
				{
					_projectID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region Portfolio entity
    /// <summary>
    /// Generated class for entity Portfolio
    /// </summary>
	[DataContract(Name = "Portfolio", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Portfolio")]
	public partial class Portfolio  : ICustomFieldsContainer     { 
		public int EntityBaseID { get { return Convert.ToInt32(PortfolioID);} set { PortfolioID = value; } }
		
		#region PortfolioID
		private int _portfolioID; 

		[DataMember(Name = "PortfolioID", IsRequired = false, EmitDefaultValue = true)]			
        public int PortfolioID 
		{ 
			get
			{
				return _portfolioID;
			}
			set
			{
				if(_portfolioID != value)
				{
					_portfolioID = value;
				} 
			}
		}
		#endregion
		
		#region CreationDate
		private DateTime? _creationDate; 

		[DataMember(Name = "CreationDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? CreationDate 
		{ 
			get
			{
				return _creationDate;
			}
			set
			{
				if(_creationDate != value)
				{
					_creationDate = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region Description
		private string _description; 

		[DataMember(Name = "Description", IsRequired = false, EmitDefaultValue = true)]			
        public string Description 
		{ 
			get
			{
				return _description;
			}
			set
			{
				if(_description != value)
				{
					_description = value;
				} 
			}
		}
		#endregion
		
		#region Managers
		private string _managers; 

		[DataMember(Name = "Managers", IsRequired = false, EmitDefaultValue = true)]			
        public string Managers 
		{ 
			get
			{
				return _managers;
			}
			set
			{
				if(_managers != value)
				{
					_managers = value;
				} 
			}
		}
		#endregion
		
		#region ManagersComma
		private string _managersComma; 

		[DataMember(Name = "ManagersComma", IsRequired = false, EmitDefaultValue = true)]			
        public string ManagersComma 
		{ 
			get
			{
				return _managersComma;
			}
			set
			{
				if(_managersComma != value)
				{
					_managersComma = value;
				} 
			}
		}
		#endregion
		
		#region ManagersSeparateLines
		private string _managersSeparateLines; 

		[DataMember(Name = "ManagersSeparateLines", IsRequired = false, EmitDefaultValue = true)]			
        public string ManagersSeparateLines 
		{ 
			get
			{
				return _managersSeparateLines;
			}
			set
			{
				if(_managersSeparateLines != value)
				{
					_managersSeparateLines = value;
				} 
			}
		}
		#endregion
		
		#region Members
		private string _members; 

		[DataMember(Name = "Members", IsRequired = false, EmitDefaultValue = true)]			
        public string Members 
		{ 
			get
			{
				return _members;
			}
			set
			{
				if(_members != value)
				{
					_members = value;
				} 
			}
		}
		#endregion
		
		#region HasProjects
		private int? _hasProjects; 

		[DataMember(Name = "HasProjects", IsRequired = false, EmitDefaultValue = true)]			
        public int? HasProjects 
		{ 
			get
			{
				return _hasProjects;
			}
			set
			{
				if(_hasProjects != value)
				{
					_hasProjects = value;
				} 
			}
		}
		#endregion
		
		#region Creator
		private int _creatorID;
		[DataMember(Name = "CreatorID")]
        public int CreatorID 
		{ 
			get
			{
				return _creatorID;
			}
			set
			{
				if(_creatorID != value)
				{
					_creatorID = value;
				} 
			}
		}
		
		#endregion
		
		#region PortfolioStatus
		private int _portfolioStatusID;
		[DataMember(Name = "PortfolioStatusID")]
        public int PortfolioStatusID 
		{ 
			get
			{
				return _portfolioStatusID;
			}
			set
			{
				if(_portfolioStatusID != value)
				{
					_portfolioStatusID = value;
				} 
			}
		}
		
		#endregion
		
		#region PortfolioCategory
		private int _portfolioCategoryID;
		[DataMember(Name = "PortfolioCategoryID")]
        public int PortfolioCategoryID 
		{ 
			get
			{
				return _portfolioCategoryID;
			}
			set
			{
				if(_portfolioCategoryID != value)
				{
					_portfolioCategoryID = value;
				} 
			}
		}
		
		#endregion

		#region Additional Permissions Fields		
		
		[DataMember(Name = "CanViewPortfolioObjects")]
        public bool CanViewPortfolioObjects  {get; set;}
		
		[DataMember(Name = "CanEditPortfolioObjects")]
        public bool CanEditPortfolioObjects  {get; set;}
		
		[DataMember(Name = "IsPortfolioManager")]
        public bool IsPortfolioManager  {get; set;}
		
		[DataMember(Name = "IsPortfolioMember")]
        public bool IsPortfolioMember  {get; set;}
		#endregion		
	
	
		#region Permissions Fields		
        public bool CanEdit  {get; set;}
        public bool CanDelete  {get; set;}
		#endregion

		#region Custom fields
        private CustomFieldsCollection customFields;
		[DataMember(Name = "CustomFields")]
		public CustomFieldsCollection CustomFields 
		{
			get 
			{
				if (customFields == null) { customFields = new CustomFieldsCollection();}
				return customFields;
			}
			set{
				customFields = value;
			}
		}
		#endregion


    }
    #endregion
    
    #region PortfolioCategory entity
    /// <summary>
    /// Generated class for entity PortfolioCategory
    /// </summary>
	[DataContract(Name = "PortfolioCategory", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.PortfolioCategory")]
	public partial class PortfolioCategory     { 
		public int EntityBaseID { get { return Convert.ToInt32(PortfolioCategoryID);} set { PortfolioCategoryID = value; } }
		
		#region PortfolioCategoryID
		private int _portfolioCategoryID; 

		[DataMember(Name = "PortfolioCategoryID", IsRequired = false, EmitDefaultValue = true)]			
        public int PortfolioCategoryID 
		{ 
			get
			{
				return _portfolioCategoryID;
			}
			set
			{
				if(_portfolioCategoryID != value)
				{
					_portfolioCategoryID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region PortfolioMember entity
    /// <summary>
    /// Generated class for entity PortfolioMember
    /// </summary>
	[DataContract(Name = "PortfolioMember", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.PortfolioMember")]
	public partial class PortfolioMember     { 
		public int EntityBaseID { get { return Convert.ToInt32(PortfolioMemberID);} set { PortfolioMemberID = value; } }
		
		#region PortfolioMemberID
		private int _portfolioMemberID; 

		[DataMember(Name = "PortfolioMemberID", IsRequired = false, EmitDefaultValue = true)]			
        public int PortfolioMemberID 
		{ 
			get
			{
				return _portfolioMemberID;
			}
			set
			{
				if(_portfolioMemberID != value)
				{
					_portfolioMemberID = value;
				} 
			}
		}
		#endregion
		
		#region CanEdit
		private bool _canEdit; 

		[DataMember(Name = "CanEdit", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanEdit 
		{ 
			get
			{
				return _canEdit;
			}
			set
			{
				if(_canEdit != value)
				{
					_canEdit = value;
				} 
			}
		}
		#endregion
		
		#region CanView
		private bool _canView; 

		[DataMember(Name = "CanView", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanView 
		{ 
			get
			{
				return _canView;
			}
			set
			{
				if(_canView != value)
				{
					_canView = value;
				} 
			}
		}
		#endregion
		
		#region IsPortfolioManager
		private bool _isPortfolioManager; 

		[DataMember(Name = "IsPortfolioManager", IsRequired = false, EmitDefaultValue = true)]			
        public bool IsPortfolioManager 
		{ 
			get
			{
				return _isPortfolioManager;
			}
			set
			{
				if(_isPortfolioManager != value)
				{
					_isPortfolioManager = value;
				} 
			}
		}
		#endregion
		
		#region Portfolio
		private int _portfolioID;
		[DataMember(Name = "PortfolioID")]
        public int PortfolioID 
		{ 
			get
			{
				return _portfolioID;
			}
			set
			{
				if(_portfolioID != value)
				{
					_portfolioID = value;
				} 
			}
		}
		
		#endregion
		
		#region User
		private int _userID;
		[DataMember(Name = "UserID")]
        public int UserID 
		{ 
			get
			{
				return _userID;
			}
			set
			{
				if(_userID != value)
				{
					_userID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region PortfolioStatus entity
    /// <summary>
    /// Generated class for entity PortfolioStatus
    /// </summary>
	[DataContract(Name = "PortfolioStatus", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.PortfolioStatus")]
	public partial class PortfolioStatus     { 
		public int EntityBaseID { get { return Convert.ToInt32(PortfolioStatusID);} set { PortfolioStatusID = value; } }
		
		#region PortfolioStatusID
		private int _portfolioStatusID; 

		[DataMember(Name = "PortfolioStatusID", IsRequired = false, EmitDefaultValue = true)]			
        public int PortfolioStatusID 
		{ 
			get
			{
				return _portfolioStatusID;
			}
			set
			{
				if(_portfolioStatusID != value)
				{
					_portfolioStatusID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region TreatAsCompleted
		private bool _treatAsCompleted; 

		[DataMember(Name = "TreatAsCompleted", IsRequired = false, EmitDefaultValue = true)]			
        public bool TreatAsCompleted 
		{ 
			get
			{
				return _treatAsCompleted;
			}
			set
			{
				if(_treatAsCompleted != value)
				{
					_treatAsCompleted = value;
				} 
			}
		}
		#endregion
		
		#region Icon
		private string _icon; 

		[DataMember(Name = "Icon", IsRequired = false, EmitDefaultValue = true)]			
        public string Icon 
		{ 
			get
			{
				return _icon;
			}
			set
			{
				if(_icon != value)
				{
					_icon = value;
				} 
			}
		}
		#endregion
		
		#region InternalPortfolioStatusID
		private int? _internalPortfolioStatusID; 

		[DataMember(Name = "InternalPortfolioStatusID", IsRequired = false, EmitDefaultValue = true)]			
        public int? InternalPortfolioStatusID 
		{ 
			get
			{
				return _internalPortfolioStatusID;
			}
			set
			{
				if(_internalPortfolioStatusID != value)
				{
					_internalPortfolioStatusID = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region Priority entity
    /// <summary>
    /// Generated class for entity Priority
    /// </summary>
	[DataContract(Name = "Priority", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Priority")]
	public partial class Priority     { 
		public int EntityBaseID { get { return Convert.ToInt32(PriorityID);} set { PriorityID = value; } }
		
		#region PriorityID
		private int _priorityID; 

		[DataMember(Name = "PriorityID", IsRequired = false, EmitDefaultValue = true)]			
        public int PriorityID 
		{ 
			get
			{
				return _priorityID;
			}
			set
			{
				if(_priorityID != value)
				{
					_priorityID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region PriorityOrder
		private int _priorityOrder; 

		[DataMember(Name = "PriorityOrder", IsRequired = false, EmitDefaultValue = true)]			
        public int PriorityOrder 
		{ 
			get
			{
				return _priorityOrder;
			}
			set
			{
				if(_priorityOrder != value)
				{
					_priorityOrder = value;
				} 
			}
		}
		#endregion
		
		#region InternalPriorityID
		private int? _internalPriorityID; 

		[DataMember(Name = "InternalPriorityID", IsRequired = false, EmitDefaultValue = true)]			
        public int? InternalPriorityID 
		{ 
			get
			{
				return _internalPriorityID;
			}
			set
			{
				if(_internalPriorityID != value)
				{
					_internalPriorityID = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region Project entity
    /// <summary>
    /// Generated class for entity Project
    /// </summary>
	[DataContract(Name = "Project", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Project")]
	public partial class Project  : ICustomFieldsContainer     { 
		public int EntityBaseID { get { return Convert.ToInt32(ProjectID);} set { ProjectID = value; } }
		
		#region ProjectID
		private int _projectID; 

		[DataMember(Name = "ProjectID", IsRequired = false, EmitDefaultValue = true)]			
        public int ProjectID 
		{ 
			get
			{
				return _projectID;
			}
			set
			{
				if(_projectID != value)
				{
					_projectID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region Description
		private string _description; 

		[DataMember(Name = "Description", IsRequired = false, EmitDefaultValue = true)]			
        public string Description 
		{ 
			get
			{
				return _description;
			}
			set
			{
				if(_description != value)
				{
					_description = value;
				} 
			}
		}
		#endregion
		
		#region Progress
		private int _progress; 

		[DataMember(Name = "Progress", IsRequired = false, EmitDefaultValue = true)]			
        public int Progress 
		{ 
			get
			{
				return _progress;
			}
			set
			{
				if(_progress != value)
				{
					_progress = value;
				} 
			}
		}
		#endregion
		
		#region CreationDate
		private DateTime? _creationDate; 

		[DataMember(Name = "CreationDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? CreationDate 
		{ 
			get
			{
				return _creationDate;
			}
			set
			{
				if(_creationDate != value)
				{
					_creationDate = value;
				} 
			}
		}
		#endregion
		
		#region StartDate
		private DateTime? _startDate; 

		[DataMember(Name = "StartDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? StartDate 
		{ 
			get
			{
				return _startDate;
			}
			set
			{
				if(_startDate != value)
				{
					_startDate = value;
				} 
			}
		}
		#endregion
		
		#region EndDate
		private DateTime? _endDate; 

		[DataMember(Name = "EndDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? EndDate 
		{ 
			get
			{
				return _endDate;
			}
			set
			{
				if(_endDate != value)
				{
					_endDate = value;
				} 
			}
		}
		#endregion
		
		#region ActCompletionDate
		private DateTime? _actCompletionDate; 

		[DataMember(Name = "ActCompletionDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? ActCompletionDate 
		{ 
			get
			{
				return _actCompletionDate;
			}
			set
			{
				if(_actCompletionDate != value)
				{
					_actCompletionDate = value;
				} 
			}
		}
		#endregion
		
		#region EstimatedHours
		private decimal? _estimatedHours; 

		[DataMember(Name = "EstimatedHours", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? EstimatedHours 
		{ 
			get
			{
				return _estimatedHours;
			}
			set
			{
				if(_estimatedHours != value)
				{
					_estimatedHours = value;
				} 
			}
		}
		#endregion
		
		#region Members
		private string _members; 

		[DataMember(Name = "Members", IsRequired = false, EmitDefaultValue = true)]			
        public string Members 
		{ 
			get
			{
				return _members;
			}
			set
			{
				if(_members != value)
				{
					_members = value;
				} 
			}
		}
		#endregion
		
		#region Managers
		private string _managers; 

		[DataMember(Name = "Managers", IsRequired = false, EmitDefaultValue = true)]			
        public string Managers 
		{ 
			get
			{
				return _managers;
			}
			set
			{
				if(_managers != value)
				{
					_managers = value;
				} 
			}
		}
		#endregion
		
		#region BillingType
		private int _billingType; 

		[DataMember(Name = "BillingType", IsRequired = false, EmitDefaultValue = true)]			
        public int BillingType 
		{ 
			get
			{
				return _billingType;
			}
			set
			{
				if(_billingType != value)
				{
					_billingType = value;
				} 
			}
		}
		#endregion
		
		#region BillingAmount
		private decimal? _billingAmount; 

		[DataMember(Name = "BillingAmount", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? BillingAmount 
		{ 
			get
			{
				return _billingAmount;
			}
			set
			{
				if(_billingAmount != value)
				{
					_billingAmount = value;
				} 
			}
		}
		#endregion
		
		#region Budget
		private decimal? _budget; 

		[DataMember(Name = "Budget", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? Budget 
		{ 
			get
			{
				return _budget;
			}
			set
			{
				if(_budget != value)
				{
					_budget = value;
				} 
			}
		}
		#endregion
		
		#region LastModificationDate
		private DateTime? _lastModificationDate; 

		[DataMember(Name = "LastModificationDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? LastModificationDate 
		{ 
			get
			{
				return _lastModificationDate;
			}
			set
			{
				if(_lastModificationDate != value)
				{
					_lastModificationDate = value;
				} 
			}
		}
		#endregion
		
		#region ProjectStatus
		private int _projectStatusID;
		[DataMember(Name = "ProjectStatusID")]
        public int ProjectStatusID 
		{ 
			get
			{
				return _projectStatusID;
			}
			set
			{
				if(_projectStatusID != value)
				{
					_projectStatusID = value;
				} 
			}
		}
		
		#endregion
		
		#region Priority
		private int _priorityID;
		[DataMember(Name = "PriorityID")]
        public int PriorityID 
		{ 
			get
			{
				return _priorityID;
			}
			set
			{
				if(_priorityID != value)
				{
					_priorityID = value;
				} 
			}
		}
		
		#endregion
		
		#region Customer
		private int _customerID;
		[DataMember(Name = "CustomerID")]
        public int CustomerID 
		{ 
			get
			{
				return _customerID;
			}
			set
			{
				if(_customerID != value)
				{
					_customerID = value;
				} 
			}
		}
		
		#endregion
		
		#region Creator
		private int _creatorID;
		[DataMember(Name = "CreatorID")]
        public int CreatorID 
		{ 
			get
			{
				return _creatorID;
			}
			set
			{
				if(_creatorID != value)
				{
					_creatorID = value;
				} 
			}
		}
		
		#endregion
		
		#region Portfolio
		private int _portfolioID;
		[DataMember(Name = "PortfolioID")]
        public int PortfolioID 
		{ 
			get
			{
				return _portfolioID;
			}
			set
			{
				if(_portfolioID != value)
				{
					_portfolioID = value;
				} 
			}
		}
		
		#endregion

		#region Additional Permissions Fields		
		
		[DataMember(Name = "CanCreateTasks")]
        public bool CanCreateTasks  {get; set;}
		
		[DataMember(Name = "CanCreateIssues")]
        public bool CanCreateIssues  {get; set;}
		
		[DataMember(Name = "CanCreateRequests")]
        public bool CanCreateRequests  {get; set;}
		
		[DataMember(Name = "IsProjectMember")]
        public bool IsProjectMember  {get; set;}
		
		[DataMember(Name = "CanManage")]
        public bool CanManage  {get; set;}
		
		[DataMember(Name = "CanViewMembersAndAssignees")]
        public bool CanViewMembersAndAssignees  {get; set;}
		
		[DataMember(Name = "CanManageProjectMembers")]
        public bool CanManageProjectMembers  {get; set;}
		
		[DataMember(Name = "CanManageAssigneesTasks")]
        public bool CanManageAssigneesTasks  {get; set;}
		
		[DataMember(Name = "CanManageAssigneesIssues")]
        public bool CanManageAssigneesIssues  {get; set;}
		
		[DataMember(Name = "CanManageAssigneesRequests")]
        public bool CanManageAssigneesRequests  {get; set;}
		
		[DataMember(Name = "CanEditAllTasks")]
        public bool CanEditAllTasks  {get; set;}
		
		[DataMember(Name = "CanEditAllIssues")]
        public bool CanEditAllIssues  {get; set;}
		
		[DataMember(Name = "CanEditAllRequests")]
        public bool CanEditAllRequests  {get; set;}
		
		[DataMember(Name = "CanEditAssignedTasks")]
        public bool CanEditAssignedTasks  {get; set;}
		
		[DataMember(Name = "CanEditAssignedIssues")]
        public bool CanEditAssignedIssues  {get; set;}
		
		[DataMember(Name = "CanEditAssignedRequests")]
        public bool CanEditAssignedRequests  {get; set;}
		
		[DataMember(Name = "IsPortfolioManager")]
        public bool IsPortfolioManager  {get; set;}
		#endregion		
	
	
		#region Permissions Fields		
        public bool CanEdit  {get; set;}
        public bool CanDelete  {get; set;}
		#endregion

		#region Custom fields
        private CustomFieldsCollection customFields;
		[DataMember(Name = "CustomFields")]
		public CustomFieldsCollection CustomFields 
		{
			get 
			{
				if (customFields == null) { customFields = new CustomFieldsCollection();}
				return customFields;
			}
			set{
				customFields = value;
			}
		}
		#endregion


    }
    #endregion
    
    #region ProjectAggregatedValues entity
    /// <summary>
    /// Generated class for entity ProjectAggregatedValues
    /// </summary>
	[DataContract(Name = "ProjectAggregatedValues", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.ProjectAggregatedValues")]
	public partial class ProjectAggregatedValues     { 
		public int EntityBaseID { get { return Convert.ToInt32(ProjectID);} set { ProjectID = value; } }
		
		#region ProjectID
		private int _projectID; 

		[DataMember(Name = "ProjectID", IsRequired = false, EmitDefaultValue = true)]			
        public int ProjectID 
		{ 
			get
			{
				return _projectID;
			}
			set
			{
				if(_projectID != value)
				{
					_projectID = value;
				} 
			}
		}
		#endregion
		
		#region ActualHours
		private decimal? _actualHours; 

		[DataMember(Name = "ActualHours", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? ActualHours 
		{ 
			get
			{
				return _actualHours;
			}
			set
			{
				if(_actualHours != value)
				{
					_actualHours = value;
				} 
			}
		}
		#endregion
		
		#region Budget
		private decimal? _budget; 

		[DataMember(Name = "Budget", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? Budget 
		{ 
			get
			{
				return _budget;
			}
			set
			{
				if(_budget != value)
				{
					_budget = value;
				} 
			}
		}
		#endregion
		
		#region EstimatedHours
		private decimal? _estimatedHours; 

		[DataMember(Name = "EstimatedHours", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? EstimatedHours 
		{ 
			get
			{
				return _estimatedHours;
			}
			set
			{
				if(_estimatedHours != value)
				{
					_estimatedHours = value;
				} 
			}
		}
		#endregion
		
		#region ChildsBudget
		private decimal? _childsBudget; 

		[DataMember(Name = "ChildsBudget", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? ChildsBudget 
		{ 
			get
			{
				return _childsBudget;
			}
			set
			{
				if(_childsBudget != value)
				{
					_childsBudget = value;
				} 
			}
		}
		#endregion
		
		#region ChildsEstimatedHours
		private decimal? _childsEstimatedHours; 

		[DataMember(Name = "ChildsEstimatedHours", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? ChildsEstimatedHours 
		{ 
			get
			{
				return _childsEstimatedHours;
			}
			set
			{
				if(_childsEstimatedHours != value)
				{
					_childsEstimatedHours = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region ProjectAttachment entity
    /// <summary>
    /// Generated class for entity ProjectAttachment
    /// </summary>
	[DataContract(Name = "ProjectAttachment", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.ProjectAttachment")]
	public partial class ProjectAttachment     { 
		public int EntityBaseID { get { return Convert.ToInt32(ProjectAttachmentID);} set { ProjectAttachmentID = value; } }
		
		#region ProjectAttachmentID
		private int _projectAttachmentID; 

		[DataMember(Name = "ProjectAttachmentID", IsRequired = false, EmitDefaultValue = true)]			
        public int ProjectAttachmentID 
		{ 
			get
			{
				return _projectAttachmentID;
			}
			set
			{
				if(_projectAttachmentID != value)
				{
					_projectAttachmentID = value;
				} 
			}
		}
		#endregion
		
		#region FileName
		private string _fileName; 

		[DataMember(Name = "FileName", IsRequired = false, EmitDefaultValue = true)]			
        public string FileName 
		{ 
			get
			{
				return _fileName;
			}
			set
			{
				if(_fileName != value)
				{
					_fileName = value;
				} 
			}
		}
		#endregion
		
		#region FileType
		private string _fileType; 

		[DataMember(Name = "FileType", IsRequired = false, EmitDefaultValue = true)]			
        public string FileType 
		{ 
			get
			{
				return _fileType;
			}
			set
			{
				if(_fileType != value)
				{
					_fileType = value;
				} 
			}
		}
		#endregion
		
		#region FileLength
		private int _fileLength; 

		[DataMember(Name = "FileLength", IsRequired = false, EmitDefaultValue = true)]			
        public int FileLength 
		{ 
			get
			{
				return _fileLength;
			}
			set
			{
				if(_fileLength != value)
				{
					_fileLength = value;
				} 
			}
		}
		#endregion
		
		#region FileContents
		private object _fileContents; 

		[DataMember(Name = "FileContents", IsRequired = false, EmitDefaultValue = true)]			
        public object FileContents 
		{ 
			get
			{
				return _fileContents;
			}
			set
			{
				if(_fileContents != value)
				{
					_fileContents = value;
				} 
			}
		}
		#endregion
		
		#region Description
		private string _description; 

		[DataMember(Name = "Description", IsRequired = false, EmitDefaultValue = true)]			
        public string Description 
		{ 
			get
			{
				return _description;
			}
			set
			{
				if(_description != value)
				{
					_description = value;
				} 
			}
		}
		#endregion
		
		#region UploadDate
		private DateTime _uploadDate; 

		[DataMember(Name = "UploadDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime UploadDate 
		{ 
			get
			{
				return _uploadDate;
			}
			set
			{
				if(_uploadDate != value)
				{
					_uploadDate = value;
				} 
			}
		}
		#endregion
		
		#region Project
		private int _projectID;
		[DataMember(Name = "ProjectID")]
        public int ProjectID 
		{ 
			get
			{
				return _projectID;
			}
			set
			{
				if(_projectID != value)
				{
					_projectID = value;
				} 
			}
		}
		
		#endregion
		
		#region User
		private int _userID;
		[DataMember(Name = "UserID")]
        public int UserID 
		{ 
			get
			{
				return _userID;
			}
			set
			{
				if(_userID != value)
				{
					_userID = value;
				} 
			}
		}
		
		#endregion
		
		#region AttachmentSaveMode
		private int _attachmentSaveModeID;
		[DataMember(Name = "AttachmentSaveModeID")]
        public int AttachmentSaveModeID 
		{ 
			get
			{
				return _attachmentSaveModeID;
			}
			set
			{
				if(_attachmentSaveModeID != value)
				{
					_attachmentSaveModeID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region ProjectAutoAssign entity
    /// <summary>
    /// Generated class for entity ProjectAutoAssign
    /// </summary>
	[DataContract(Name = "ProjectAutoAssign", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.ProjectAutoAssign")]
	public partial class ProjectAutoAssign     { 
		public int EntityBaseID { get { return Convert.ToInt32(ProjectAutoAssignID);} set { ProjectAutoAssignID = value; } }
		
		#region ProjectAutoAssignID
		private int _projectAutoAssignID; 

		[DataMember(Name = "ProjectAutoAssignID", IsRequired = false, EmitDefaultValue = true)]			
        public int ProjectAutoAssignID 
		{ 
			get
			{
				return _projectAutoAssignID;
			}
			set
			{
				if(_projectAutoAssignID != value)
				{
					_projectAutoAssignID = value;
				} 
			}
		}
		#endregion
		
		#region Project
		private int _projectID;
		[DataMember(Name = "ProjectID")]
        public int ProjectID 
		{ 
			get
			{
				return _projectID;
			}
			set
			{
				if(_projectID != value)
				{
					_projectID = value;
				} 
			}
		}
		
		#endregion
		
		#region TaskMember
		private int _taskMemberID;
		[DataMember(Name = "TaskMemberID")]
        public int TaskMemberID 
		{ 
			get
			{
				return _taskMemberID;
			}
			set
			{
				if(_taskMemberID != value)
				{
					_taskMemberID = value;
				} 
			}
		}
		
		#endregion
		
		#region IssueMember
		private int _issueMemberID;
		[DataMember(Name = "IssueMemberID")]
        public int IssueMemberID 
		{ 
			get
			{
				return _issueMemberID;
			}
			set
			{
				if(_issueMemberID != value)
				{
					_issueMemberID = value;
				} 
			}
		}
		
		#endregion
		
		#region RequestMember
		private int _requestMemberID;
		[DataMember(Name = "RequestMemberID")]
        public int RequestMemberID 
		{ 
			get
			{
				return _requestMemberID;
			}
			set
			{
				if(_requestMemberID != value)
				{
					_requestMemberID = value;
				} 
			}
		}
		
		#endregion
		
		#region ApproverMember
		private int _approverMemberID;
		[DataMember(Name = "ApproverMemberID")]
        public int ApproverMemberID 
		{ 
			get
			{
				return _approverMemberID;
			}
			set
			{
				if(_approverMemberID != value)
				{
					_approverMemberID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region ProjectCost entity
    /// <summary>
    /// Generated class for entity ProjectCost
    /// </summary>
	[DataContract(Name = "ProjectCost", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.ProjectCost")]
	public partial class ProjectCost     { 
		public int EntityBaseID { get { return Convert.ToInt32(ProjectID);} set { ProjectID = value; } }
		
		#region ProjectID
		private int _projectID; 

		[DataMember(Name = "ProjectID", IsRequired = false, EmitDefaultValue = true)]			
        public int ProjectID 
		{ 
			get
			{
				return _projectID;
			}
			set
			{
				if(_projectID != value)
				{
					_projectID = value;
				} 
			}
		}
		#endregion
		
		#region Project_Cost
		private decimal _project_Cost; 

		[DataMember(Name = "Project_Cost", IsRequired = false, EmitDefaultValue = true)]			
        public decimal Project_Cost 
		{ 
			get
			{
				return _project_Cost;
			}
			set
			{
				if(_project_Cost != value)
				{
					_project_Cost = value;
				} 
			}
		}
		#endregion
		
		#region Project_TimeCost
		private decimal _project_TimeCost; 

		[DataMember(Name = "Project_TimeCost", IsRequired = false, EmitDefaultValue = true)]			
        public decimal Project_TimeCost 
		{ 
			get
			{
				return _project_TimeCost;
			}
			set
			{
				if(_project_TimeCost != value)
				{
					_project_TimeCost = value;
				} 
			}
		}
		#endregion
		
		#region Project_Expenses
		private decimal _project_Expenses; 

		[DataMember(Name = "Project_Expenses", IsRequired = false, EmitDefaultValue = true)]			
        public decimal Project_Expenses 
		{ 
			get
			{
				return _project_Expenses;
			}
			set
			{
				if(_project_Expenses != value)
				{
					_project_Expenses = value;
				} 
			}
		}
		#endregion
		
		#region Project_TotalCost
		private decimal _project_TotalCost; 

		[DataMember(Name = "Project_TotalCost", IsRequired = false, EmitDefaultValue = true)]			
        public decimal Project_TotalCost 
		{ 
			get
			{
				return _project_TotalCost;
			}
			set
			{
				if(_project_TotalCost != value)
				{
					_project_TotalCost = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region ProjectEVA entity
    /// <summary>
    /// Generated class for entity ProjectEVA
    /// </summary>
	[DataContract(Name = "ProjectEVA", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.ProjectEVA")]
	public partial class ProjectEVA     { 
		public int EntityBaseID { get { return Convert.ToInt32(ProjectID);} set { ProjectID = value; } }
		
		#region ProjectID
		private int _projectID; 

		[DataMember(Name = "ProjectID", IsRequired = false, EmitDefaultValue = true)]			
        public int ProjectID 
		{ 
			get
			{
				return _projectID;
			}
			set
			{
				if(_projectID != value)
				{
					_projectID = value;
				} 
			}
		}
		#endregion
		
		#region Health
		private int? _health; 

		[DataMember(Name = "Health", IsRequired = false, EmitDefaultValue = true)]			
        public int? Health 
		{ 
			get
			{
				return _health;
			}
			set
			{
				if(_health != value)
				{
					_health = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region ProjectMember entity
    /// <summary>
    /// Generated class for entity ProjectMember
    /// </summary>
	[DataContract(Name = "ProjectMember", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.ProjectMember")]
	public partial class ProjectMember     { 
		public int EntityBaseID { get { return Convert.ToInt32(ProjectMemberID);} set { ProjectMemberID = value; } }
		
		#region ProjectMemberID
		private int _projectMemberID; 

		[DataMember(Name = "ProjectMemberID", IsRequired = false, EmitDefaultValue = true)]			
        public int ProjectMemberID 
		{ 
			get
			{
				return _projectMemberID;
			}
			set
			{
				if(_projectMemberID != value)
				{
					_projectMemberID = value;
				} 
			}
		}
		#endregion
		
		#region Project
		private int _projectID;
		[DataMember(Name = "ProjectID")]
        public int ProjectID 
		{ 
			get
			{
				return _projectID;
			}
			set
			{
				if(_projectID != value)
				{
					_projectID = value;
				} 
			}
		}
		
		#endregion
		
		#region User
		private int _userID;
		[DataMember(Name = "UserID")]
        public int UserID 
		{ 
			get
			{
				return _userID;
			}
			set
			{
				if(_userID != value)
				{
					_userID = value;
				} 
			}
		}
		
		#endregion
		
		#region MemberPermission
		private int _memberPermissionID;
		[DataMember(Name = "MemberPermissionID")]
        public int MemberPermissionID 
		{ 
			get
			{
				return _memberPermissionID;
			}
			set
			{
				if(_memberPermissionID != value)
				{
					_memberPermissionID = value;
				} 
			}
		}
		
		#endregion
		
		#region Role
		private int _roleID;
		[DataMember(Name = "RoleID")]
        public int RoleID 
		{ 
			get
			{
				return _roleID;
			}
			set
			{
				if(_roleID != value)
				{
					_roleID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region ProjectStatus entity
    /// <summary>
    /// Generated class for entity ProjectStatus
    /// </summary>
	[DataContract(Name = "ProjectStatus", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.ProjectStatus")]
	public partial class ProjectStatus     { 
		public int EntityBaseID { get { return Convert.ToInt32(ProjectStatusID);} set { ProjectStatusID = value; } }
		
		#region ProjectStatusID
		private int _projectStatusID; 

		[DataMember(Name = "ProjectStatusID", IsRequired = false, EmitDefaultValue = true)]			
        public int ProjectStatusID 
		{ 
			get
			{
				return _projectStatusID;
			}
			set
			{
				if(_projectStatusID != value)
				{
					_projectStatusID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region InternalProjectStatusID
		private int? _internalProjectStatusID; 

		[DataMember(Name = "InternalProjectStatusID", IsRequired = false, EmitDefaultValue = true)]			
        public int? InternalProjectStatusID 
		{ 
			get
			{
				return _internalProjectStatusID;
			}
			set
			{
				if(_internalProjectStatusID != value)
				{
					_internalProjectStatusID = value;
				} 
			}
		}
		#endregion
		
		#region TreatAsCompleted
		private bool _treatAsCompleted; 

		[DataMember(Name = "TreatAsCompleted", IsRequired = false, EmitDefaultValue = true)]			
        public bool TreatAsCompleted 
		{ 
			get
			{
				return _treatAsCompleted;
			}
			set
			{
				if(_treatAsCompleted != value)
				{
					_treatAsCompleted = value;
				} 
			}
		}
		#endregion
		
		#region Icon
		private string _icon; 

		[DataMember(Name = "Icon", IsRequired = false, EmitDefaultValue = true)]			
        public string Icon 
		{ 
			get
			{
				return _icon;
			}
			set
			{
				if(_icon != value)
				{
					_icon = value;
				} 
			}
		}
		#endregion
		
		#region LastModificationDate
		private DateTime? _lastModificationDate; 

		[DataMember(Name = "LastModificationDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? LastModificationDate 
		{ 
			get
			{
				return _lastModificationDate;
			}
			set
			{
				if(_lastModificationDate != value)
				{
					_lastModificationDate = value;
				} 
			}
		}
		#endregion
		
		#region IsIconEmpty
		private bool? _isIconEmpty; 

		[DataMember(Name = "IsIconEmpty", IsRequired = false, EmitDefaultValue = true)]			
        public bool? IsIconEmpty 
		{ 
			get
			{
				return _isIconEmpty;
			}
			set
			{
				if(_isIconEmpty != value)
				{
					_isIconEmpty = value;
				} 
			}
		}
		#endregion
		
		#region IconHash
		private string _iconHash; 

		[DataMember(Name = "IconHash", IsRequired = false, EmitDefaultValue = true)]			
        public string IconHash 
		{ 
			get
			{
				return _iconHash;
			}
			set
			{
				if(_iconHash != value)
				{
					_iconHash = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region PublicHoliday entity
    /// <summary>
    /// Generated class for entity PublicHoliday
    /// </summary>
	[DataContract(Name = "PublicHoliday", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.PublicHoliday")]
	public partial class PublicHoliday     { 
		public int EntityBaseID { get { return Convert.ToInt32(PublicHolidayID);} set { PublicHolidayID = value; } }
		
		#region PublicHolidayID
		private int _publicHolidayID; 

		[DataMember(Name = "PublicHolidayID", IsRequired = false, EmitDefaultValue = true)]			
        public int PublicHolidayID 
		{ 
			get
			{
				return _publicHolidayID;
			}
			set
			{
				if(_publicHolidayID != value)
				{
					_publicHolidayID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region Date
		private DateTime _date; 

		[DataMember(Name = "Date", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime Date 
		{ 
			get
			{
				return _date;
			}
			set
			{
				if(_date != value)
				{
					_date = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region Role entity
    /// <summary>
    /// Generated class for entity Role
    /// </summary>
	[DataContract(Name = "Role", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Role")]
	public partial class Role  : ICustomFieldsContainer     { 
		public int EntityBaseID { get { return Convert.ToInt32(RoleID);} set { RoleID = value; } }
		
		#region RoleID
		private int _roleID; 

		[DataMember(Name = "RoleID", IsRequired = false, EmitDefaultValue = true)]			
        public int RoleID 
		{ 
			get
			{
				return _roleID;
			}
			set
			{
				if(_roleID != value)
				{
					_roleID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region Description
		private string _description; 

		[DataMember(Name = "Description", IsRequired = false, EmitDefaultValue = true)]			
        public string Description 
		{ 
			get
			{
				return _description;
			}
			set
			{
				if(_description != value)
				{
					_description = value;
				} 
			}
		}
		#endregion
		
		#region HourlyRate
		private decimal _hourlyRate; 

		[DataMember(Name = "HourlyRate", IsRequired = false, EmitDefaultValue = true)]			
        public decimal HourlyRate 
		{ 
			get
			{
				return _hourlyRate;
			}
			set
			{
				if(_hourlyRate != value)
				{
					_hourlyRate = value;
				} 
			}
		}
		#endregion
		
		#region CanManage
		private bool _canManage; 

		[DataMember(Name = "CanManage", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanManage 
		{ 
			get
			{
				return _canManage;
			}
			set
			{
				if(_canManage != value)
				{
					_canManage = value;
				} 
			}
		}
		#endregion
		
		#region CanCreateGroupEvents
		private bool _canCreateGroupEvents; 

		[DataMember(Name = "CanCreateGroupEvents", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanCreateGroupEvents 
		{ 
			get
			{
				return _canCreateGroupEvents;
			}
			set
			{
				if(_canCreateGroupEvents != value)
				{
					_canCreateGroupEvents = value;
				} 
			}
		}
		#endregion
		
		#region CanAccessReports
		private bool _canAccessReports; 

		[DataMember(Name = "CanAccessReports", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanAccessReports 
		{ 
			get
			{
				return _canAccessReports;
			}
			set
			{
				if(_canAccessReports != value)
				{
					_canAccessReports = value;
				} 
			}
		}
		#endregion
		
		#region CanAccessCustomerReports
		private bool _canAccessCustomerReports; 

		[DataMember(Name = "CanAccessCustomerReports", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanAccessCustomerReports 
		{ 
			get
			{
				return _canAccessCustomerReports;
			}
			set
			{
				if(_canAccessCustomerReports != value)
				{
					_canAccessCustomerReports = value;
				} 
			}
		}
		#endregion
		
		#region CanAccessReportGenerator
		private bool _canAccessReportGenerator; 

		[DataMember(Name = "CanAccessReportGenerator", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanAccessReportGenerator 
		{ 
			get
			{
				return _canAccessReportGenerator;
			}
			set
			{
				if(_canAccessReportGenerator != value)
				{
					_canAccessReportGenerator = value;
				} 
			}
		}
		#endregion
		
		#region CanCreateProjects
		private bool _canCreateProjects; 

		[DataMember(Name = "CanCreateProjects", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanCreateProjects 
		{ 
			get
			{
				return _canCreateProjects;
			}
			set
			{
				if(_canCreateProjects != value)
				{
					_canCreateProjects = value;
				} 
			}
		}
		#endregion
		
		#region CanAccessProjects
		private bool _canAccessProjects; 

		[DataMember(Name = "CanAccessProjects", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanAccessProjects 
		{ 
			get
			{
				return _canAccessProjects;
			}
			set
			{
				if(_canAccessProjects != value)
				{
					_canAccessProjects = value;
				} 
			}
		}
		#endregion
		
		#region CanAddPortfolios
		private bool _canAddPortfolios; 

		[DataMember(Name = "CanAddPortfolios", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanAddPortfolios 
		{ 
			get
			{
				return _canAddPortfolios;
			}
			set
			{
				if(_canAddPortfolios != value)
				{
					_canAddPortfolios = value;
				} 
			}
		}
		#endregion
		
		#region CanManageAllPortfolios
		private bool _canManageAllPortfolios; 

		[DataMember(Name = "CanManageAllPortfolios", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanManageAllPortfolios 
		{ 
			get
			{
				return _canManageAllPortfolios;
			}
			set
			{
				if(_canManageAllPortfolios != value)
				{
					_canManageAllPortfolios = value;
				} 
			}
		}
		#endregion
		
		#region CanAccessBillingInformation
		private bool _canAccessBillingInformation; 

		[DataMember(Name = "CanAccessBillingInformation", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanAccessBillingInformation 
		{ 
			get
			{
				return _canAccessBillingInformation;
			}
			set
			{
				if(_canAccessBillingInformation != value)
				{
					_canAccessBillingInformation = value;
				} 
			}
		}
		#endregion
		
		#region CanManageOwnVacations
		private bool _canManageOwnVacations; 

		[DataMember(Name = "CanManageOwnVacations", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanManageOwnVacations 
		{ 
			get
			{
				return _canManageOwnVacations;
			}
			set
			{
				if(_canManageOwnVacations != value)
				{
					_canManageOwnVacations = value;
				} 
			}
		}
		#endregion
		
		#region CanManageOtherPeopleVacations
		private bool _canManageOtherPeopleVacations; 

		[DataMember(Name = "CanManageOtherPeopleVacations", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanManageOtherPeopleVacations 
		{ 
			get
			{
				return _canManageOtherPeopleVacations;
			}
			set
			{
				if(_canManageOtherPeopleVacations != value)
				{
					_canManageOtherPeopleVacations = value;
				} 
			}
		}
		#endregion
		
		#region CanManageCustomers
		private bool _canManageCustomers; 

		[DataMember(Name = "CanManageCustomers", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanManageCustomers 
		{ 
			get
			{
				return _canManageCustomers;
			}
			set
			{
				if(_canManageCustomers != value)
				{
					_canManageCustomers = value;
				} 
			}
		}
		#endregion
		
		#region InternalRoleID
		private int? _internalRoleID; 

		[DataMember(Name = "InternalRoleID", IsRequired = false, EmitDefaultValue = true)]			
        public int? InternalRoleID 
		{ 
			get
			{
				return _internalRoleID;
			}
			set
			{
				if(_internalRoleID != value)
				{
					_internalRoleID = value;
				} 
			}
		}
		#endregion
		
		#region MemberPermission
		private int _memberPermissionID;
		[DataMember(Name = "MemberPermissionID")]
        public int MemberPermissionID 
		{ 
			get
			{
				return _memberPermissionID;
			}
			set
			{
				if(_memberPermissionID != value)
				{
					_memberPermissionID = value;
				} 
			}
		}
		
		#endregion
		
		#region DefaultMemberPermission
		private int _defaultMemberPermissionID;
		[DataMember(Name = "DefaultMemberPermissionID")]
        public int DefaultMemberPermissionID 
		{ 
			get
			{
				return _defaultMemberPermissionID;
			}
			set
			{
				if(_defaultMemberPermissionID != value)
				{
					_defaultMemberPermissionID = value;
				} 
			}
		}
		
		#endregion

	
	

		#region Custom fields
        private CustomFieldsCollection customFields;
		[DataMember(Name = "CustomFields")]
		public CustomFieldsCollection CustomFields 
		{
			get 
			{
				if (customFields == null) { customFields = new CustomFieldsCollection();}
				return customFields;
			}
			set{
				customFields = value;
			}
		}
		#endregion


    }
    #endregion
    
    #region SecurityLog entity
    /// <summary>
    /// Generated class for entity SecurityLog
    /// </summary>
	[DataContract(Name = "SecurityLog", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.SecurityLog")]
	public partial class SecurityLog     { 
		public int EntityBaseID { get { return Convert.ToInt32(EntryID);} set { EntryID = value; } }
		
		#region EntryID
		private int _entryID; 

		[DataMember(Name = "EntryID", IsRequired = false, EmitDefaultValue = true)]			
        public int EntryID 
		{ 
			get
			{
				return _entryID;
			}
			set
			{
				if(_entryID != value)
				{
					_entryID = value;
				} 
			}
		}
		#endregion
		
		#region EntryDate
		private DateTime? _entryDate; 

		[DataMember(Name = "EntryDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? EntryDate 
		{ 
			get
			{
				return _entryDate;
			}
			set
			{
				if(_entryDate != value)
				{
					_entryDate = value;
				} 
			}
		}
		#endregion
		
		#region MessageType
		private string _messageType; 

		[DataMember(Name = "MessageType", IsRequired = false, EmitDefaultValue = true)]			
        public string MessageType 
		{ 
			get
			{
				return _messageType;
			}
			set
			{
				if(_messageType != value)
				{
					_messageType = value;
				} 
			}
		}
		#endregion
		
		#region ActorUserName
		private string _actorUserName; 

		[DataMember(Name = "ActorUserName", IsRequired = false, EmitDefaultValue = true)]			
        public string ActorUserName 
		{ 
			get
			{
				return _actorUserName;
			}
			set
			{
				if(_actorUserName != value)
				{
					_actorUserName = value;
				} 
			}
		}
		#endregion
		
		#region User
		private int _userID;
		[DataMember(Name = "UserID")]
        public int UserID 
		{ 
			get
			{
				return _userID;
			}
			set
			{
				if(_userID != value)
				{
					_userID = value;
				} 
			}
		}
		
		#endregion
		
		#region ActorUser
		private int _actorUserID;
		[DataMember(Name = "ActorUserID")]
        public int ActorUserID 
		{ 
			get
			{
				return _actorUserID;
			}
			set
			{
				if(_actorUserID != value)
				{
					_actorUserID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region Task entity
    /// <summary>
    /// Generated class for entity Task
    /// </summary>
	[DataContract(Name = "Activity", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Task")]
	public partial class Task  : ICustomFieldsContainer     { 
		public int EntityBaseID { get { return Convert.ToInt32(TaskID);} set { TaskID = value; } }
		
		#region TaskID
		private int _taskID; 

		[DataMember(Name = "TaskID", IsRequired = false, EmitDefaultValue = true)]			
        public int TaskID 
		{ 
			get
			{
				return _taskID;
			}
			set
			{
				if(_taskID != value)
				{
					_taskID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region NameStyle
		private string _nameStyle; 

		[DataMember(Name = "NameStyle", IsRequired = false, EmitDefaultValue = true)]			
        public string NameStyle 
		{ 
			get
			{
				return _nameStyle;
			}
			set
			{
				if(_nameStyle != value)
				{
					_nameStyle = value;
				} 
			}
		}
		#endregion
		
		#region Description
		private string _description; 

		[DataMember(Name = "Description", IsRequired = false, EmitDefaultValue = true)]			
        public string Description 
		{ 
			get
			{
				return _description;
			}
			set
			{
				if(_description != value)
				{
					_description = value;
				} 
			}
		}
		#endregion
		
		#region ParentID
		private int? _parentID; 

		[DataMember(Name = "ParentID", IsRequired = false, EmitDefaultValue = true)]			
        public int? ParentID 
		{ 
			get
			{
				return _parentID;
			}
			set
			{
				if(_parentID != value)
				{
					_parentID = value;
				} 
			}
		}
		#endregion
		
		#region Progress
		private int _progress; 

		[DataMember(Name = "Progress", IsRequired = false, EmitDefaultValue = true)]			
        public int Progress 
		{ 
			get
			{
				return _progress;
			}
			set
			{
				if(_progress != value)
				{
					_progress = value;
				} 
			}
		}
		#endregion
		
		#region ActualCompletionDate
		private DateTime? _actualCompletionDate; 

		[DataMember(Name = "ActualCompletionDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? ActualCompletionDate 
		{ 
			get
			{
				return _actualCompletionDate;
			}
			set
			{
				if(_actualCompletionDate != value)
				{
					_actualCompletionDate = value;
				} 
			}
		}
		#endregion
		
		#region CreationDate
		private DateTime? _creationDate; 

		[DataMember(Name = "CreationDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? CreationDate 
		{ 
			get
			{
				return _creationDate;
			}
			set
			{
				if(_creationDate != value)
				{
					_creationDate = value;
				} 
			}
		}
		#endregion
		
		#region StartDate
		private DateTime? _startDate; 

		[DataMember(Name = "StartDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? StartDate 
		{ 
			get
			{
				return _startDate;
			}
			set
			{
				if(_startDate != value)
				{
					_startDate = value;
				} 
			}
		}
		#endregion
		
		#region EndDate
		private DateTime? _endDate; 

		[DataMember(Name = "EndDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? EndDate 
		{ 
			get
			{
				return _endDate;
			}
			set
			{
				if(_endDate != value)
				{
					_endDate = value;
				} 
			}
		}
		#endregion
		
		#region Duration
		private int? _duration; 

		[DataMember(Name = "Duration", IsRequired = false, EmitDefaultValue = true)]			
        public int? Duration 
		{ 
			get
			{
				return _duration;
			}
			set
			{
				if(_duration != value)
				{
					_duration = value;
				} 
			}
		}
		#endregion
		
		#region IsEndDateSelected
		private bool? _isEndDateSelected; 

		[DataMember(Name = "IsEndDateSelected", IsRequired = false, EmitDefaultValue = true)]			
        public bool? IsEndDateSelected 
		{ 
			get
			{
				return _isEndDateSelected;
			}
			set
			{
				if(_isEndDateSelected != value)
				{
					_isEndDateSelected = value;
				} 
			}
		}
		#endregion
		
		#region EstimatedHours
		private decimal? _estimatedHours; 

		[DataMember(Name = "EstimatedHours", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? EstimatedHours 
		{ 
			get
			{
				return _estimatedHours;
			}
			set
			{
				if(_estimatedHours != value)
				{
					_estimatedHours = value;
				} 
			}
		}
		#endregion
		
		#region BaseEstimatedHours
		private decimal? _baseEstimatedHours; 

		[DataMember(Name = "BaseEstimatedHours", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? BaseEstimatedHours 
		{ 
			get
			{
				return _baseEstimatedHours;
			}
			set
			{
				if(_baseEstimatedHours != value)
				{
					_baseEstimatedHours = value;
				} 
			}
		}
		#endregion
		
		#region HoursLeft
		private decimal? _hoursLeft; 

		[DataMember(Name = "HoursLeft", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? HoursLeft 
		{ 
			get
			{
				return _hoursLeft;
			}
			set
			{
				if(_hoursLeft != value)
				{
					_hoursLeft = value;
				} 
			}
		}
		#endregion
		
		#region FixedDate
		private DateTime? _fixedDate; 

		[DataMember(Name = "FixedDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? FixedDate 
		{ 
			get
			{
				return _fixedDate;
			}
			set
			{
				if(_fixedDate != value)
				{
					_fixedDate = value;
				} 
			}
		}
		#endregion
		
		#region BillingType
		private int? _billingType; 

		[DataMember(Name = "BillingType", IsRequired = false, EmitDefaultValue = true)]			
        public int? BillingType 
		{ 
			get
			{
				return _billingType;
			}
			set
			{
				if(_billingType != value)
				{
					_billingType = value;
				} 
			}
		}
		#endregion
		
		#region BillingAmount
		private decimal? _billingAmount; 

		[DataMember(Name = "BillingAmount", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? BillingAmount 
		{ 
			get
			{
				return _billingAmount;
			}
			set
			{
				if(_billingAmount != value)
				{
					_billingAmount = value;
				} 
			}
		}
		#endregion
		
		#region Cost
		private decimal? _cost; 

		[DataMember(Name = "Cost", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? Cost 
		{ 
			get
			{
				return _cost;
			}
			set
			{
				if(_cost != value)
				{
					_cost = value;
				} 
			}
		}
		#endregion
		
		#region IsMilestone
		private bool _isMilestone; 

		[DataMember(Name = "IsMilestone", IsRequired = false, EmitDefaultValue = true)]			
        public bool IsMilestone 
		{ 
			get
			{
				return _isMilestone;
			}
			set
			{
				if(_isMilestone != value)
				{
					_isMilestone = value;
				} 
			}
		}
		#endregion
		
		#region HasChild
		private int? _hasChild; 

		[DataMember(Name = "HasChild", IsRequired = false, EmitDefaultValue = true)]			
        public int? HasChild 
		{ 
			get
			{
				return _hasChild;
			}
			set
			{
				if(_hasChild != value)
				{
					_hasChild = value;
				} 
			}
		}
		#endregion
		
		#region Budget
		private decimal? _budget; 

		[DataMember(Name = "Budget", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? Budget 
		{ 
			get
			{
				return _budget;
			}
			set
			{
				if(_budget != value)
				{
					_budget = value;
				} 
			}
		}
		#endregion
		
		#region LastModificationDate
		private DateTime? _lastModificationDate; 

		[DataMember(Name = "LastModificationDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? LastModificationDate 
		{ 
			get
			{
				return _lastModificationDate;
			}
			set
			{
				if(_lastModificationDate != value)
				{
					_lastModificationDate = value;
				} 
			}
		}
		#endregion
		
		#region WBSNumber
		private int _wBSNumber; 

		[DataMember(Name = "WBSNumber", IsRequired = false, EmitDefaultValue = true)]			
        public int WBSNumber 
		{ 
			get
			{
				return _wBSNumber;
			}
			set
			{
				if(_wBSNumber != value)
				{
					_wBSNumber = value;
				} 
			}
		}
		#endregion
		
		#region Approved
		private bool? _approved; 

		[DataMember(Name = "Approved", IsRequired = false, EmitDefaultValue = true)]			
        public bool? Approved 
		{ 
			get
			{
				return _approved;
			}
			set
			{
				if(_approved != value)
				{
					_approved = value;
				} 
			}
		}
		#endregion
		
		#region Project
		private int _projectID;
		[DataMember(Name = "ProjectID")]
        public int ProjectID 
		{ 
			get
			{
				return _projectID;
			}
			set
			{
				if(_projectID != value)
				{
					_projectID = value;
				} 
			}
		}
		
		#endregion
		
		#region Category
		private int _categoryID;
		[DataMember(Name = "CategoryID")]
        public int CategoryID 
		{ 
			get
			{
				return _categoryID;
			}
			set
			{
				if(_categoryID != value)
				{
					_categoryID = value;
				} 
			}
		}
		
		#endregion
		
		#region TaskType
		private int _taskTypeID;
		[DataMember(Name = "TaskTypeID")]
        public int TaskTypeID 
		{ 
			get
			{
				return _taskTypeID;
			}
			set
			{
				if(_taskTypeID != value)
				{
					_taskTypeID = value;
				} 
			}
		}
		
		#endregion
		
		#region TaskStatus
		private int _taskStatusID;
		[DataMember(Name = "TaskStatusID")]
        public int TaskStatusID 
		{ 
			get
			{
				return _taskStatusID;
			}
			set
			{
				if(_taskStatusID != value)
				{
					_taskStatusID = value;
				} 
			}
		}
		
		#endregion
		
		#region Priority
		private int _priorityID;
		[DataMember(Name = "PriorityID")]
        public int PriorityID 
		{ 
			get
			{
				return _priorityID;
			}
			set
			{
				if(_priorityID != value)
				{
					_priorityID = value;
				} 
			}
		}
		
		#endregion
		
		#region Creator
		private int _creatorID;
		[DataMember(Name = "CreatorID")]
        public int CreatorID 
		{ 
			get
			{
				return _creatorID;
			}
			set
			{
				if(_creatorID != value)
				{
					_creatorID = value;
				} 
			}
		}
		
		#endregion
		
		#region IssueType
		private int _issueTypeID;
		[DataMember(Name = "IssueTypeID")]
        public int IssueTypeID 
		{ 
			get
			{
				return _issueTypeID;
			}
			set
			{
				if(_issueTypeID != value)
				{
					_issueTypeID = value;
				} 
			}
		}
		
		#endregion

		#region Additional Permissions Fields		
		
		[DataMember(Name = "CanCreateTasks")]
        public bool CanCreateTasks  {get; set;}
		
		[DataMember(Name = "CanCreateIssues")]
        public bool CanCreateIssues  {get; set;}
		
		[DataMember(Name = "CanCreateRequests")]
        public bool CanCreateRequests  {get; set;}
		
		[DataMember(Name = "IsProjectMember")]
        public bool IsProjectMember  {get; set;}
		
		[DataMember(Name = "CanManage")]
        public bool CanManage  {get; set;}
		
		[DataMember(Name = "CanCreateTimeEntries")]
        public bool CanCreateTimeEntries  {get; set;}
		
		[DataMember(Name = "CanCreateTimeEntriesForOther")]
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
		[DataMember(Name = "CanManageAssigneesTasks")]
        public bool CanManageAssigneesTasks  {get; set;}
		
		[DataMember(Name = "CanManageAssigneesIssues")]
        public bool CanManageAssigneesIssues  {get; set;}
		
		[DataMember(Name = "CanManageAssigneesRequests")]
        public bool CanManageAssigneesRequests  {get; set;}
		
		[DataMember(Name = "CanViewMembersAndAssignees")]
        public bool CanViewMembersAndAssignees  {get; set;}
		
		[DataMember(Name = "CanEditAllTasks")]
        public bool CanEditAllTasks  {get; set;}
		
		[DataMember(Name = "CanEditAllIssues")]
        public bool CanEditAllIssues  {get; set;}
		
		[DataMember(Name = "CanEditAllRequests")]
        public bool CanEditAllRequests  {get; set;}
		
		[DataMember(Name = "CanEditAssignedTasks")]
        public bool CanEditAssignedTasks  {get; set;}
		
		[DataMember(Name = "CanEditAssignedIssues")]
        public bool CanEditAssignedIssues  {get; set;}
		
		[DataMember(Name = "CanEditAssignedRequests")]
        public bool CanEditAssignedRequests  {get; set;}
		
		[DataMember(Name = "IsPortfolioManager")]
        public bool IsPortfolioManager  {get; set;}
		#endregion		
	
	
		#region Permissions Fields		
        public bool CanEdit  {get; set;}
        public bool CanDelete  {get; set;}
		#endregion

		#region Custom fields
        private CustomFieldsCollection customFields;
		[DataMember(Name = "CustomFields")]
		public CustomFieldsCollection CustomFields 
		{
			get 
			{
				if (customFields == null) { customFields = new CustomFieldsCollection();}
				return customFields;
			}
			set{
				customFields = value;
			}
		}
		#endregion


    }
    #endregion
    
    #region TaskAggregatedValues entity
    /// <summary>
    /// Generated class for entity TaskAggregatedValues
    /// </summary>
	[DataContract(Name = "TaskAggregatedValues", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.TaskAggregatedValues")]
	public partial class TaskAggregatedValues     { 
		public int EntityBaseID { get { return Convert.ToInt32(TaskID);} set { TaskID = value; } }
		
		#region TaskID
		private int _taskID; 

		[DataMember(Name = "TaskID", IsRequired = false, EmitDefaultValue = true)]			
        public int TaskID 
		{ 
			get
			{
				return _taskID;
			}
			set
			{
				if(_taskID != value)
				{
					_taskID = value;
				} 
			}
		}
		#endregion
		
		#region ActualHours
		private decimal? _actualHours; 

		[DataMember(Name = "ActualHours", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? ActualHours 
		{ 
			get
			{
				return _actualHours;
			}
			set
			{
				if(_actualHours != value)
				{
					_actualHours = value;
				} 
			}
		}
		#endregion
		
		#region Budget
		private decimal? _budget; 

		[DataMember(Name = "Budget", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? Budget 
		{ 
			get
			{
				return _budget;
			}
			set
			{
				if(_budget != value)
				{
					_budget = value;
				} 
			}
		}
		#endregion
		
		#region EstimatedHours
		private decimal? _estimatedHours; 

		[DataMember(Name = "EstimatedHours", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? EstimatedHours 
		{ 
			get
			{
				return _estimatedHours;
			}
			set
			{
				if(_estimatedHours != value)
				{
					_estimatedHours = value;
				} 
			}
		}
		#endregion
		
		#region ChildsActualHours
		private decimal? _childsActualHours; 

		[DataMember(Name = "ChildsActualHours", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? ChildsActualHours 
		{ 
			get
			{
				return _childsActualHours;
			}
			set
			{
				if(_childsActualHours != value)
				{
					_childsActualHours = value;
				} 
			}
		}
		#endregion
		
		#region ChildsBudget
		private decimal? _childsBudget; 

		[DataMember(Name = "ChildsBudget", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? ChildsBudget 
		{ 
			get
			{
				return _childsBudget;
			}
			set
			{
				if(_childsBudget != value)
				{
					_childsBudget = value;
				} 
			}
		}
		#endregion
		
		#region ChildsEstimatedHours
		private decimal? _childsEstimatedHours; 

		[DataMember(Name = "ChildsEstimatedHours", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? ChildsEstimatedHours 
		{ 
			get
			{
				return _childsEstimatedHours;
			}
			set
			{
				if(_childsEstimatedHours != value)
				{
					_childsEstimatedHours = value;
				} 
			}
		}
		#endregion
		
		#region OwnEstimatedHours
		private decimal? _ownEstimatedHours; 

		[DataMember(Name = "OwnEstimatedHours", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? OwnEstimatedHours 
		{ 
			get
			{
				return _ownEstimatedHours;
			}
			set
			{
				if(_ownEstimatedHours != value)
				{
					_ownEstimatedHours = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region TaskAssignee entity
    /// <summary>
    /// Generated class for entity TaskAssignee
    /// </summary>
	[DataContract(Name = "TaskAssignee", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.TaskAssignee")]
	public partial class TaskAssignee     { 
		public int EntityBaseID { get { return Convert.ToInt32(TaskAssigneeID);} set { TaskAssigneeID = value; } }
		
		#region TaskAssigneeID
		private int _taskAssigneeID; 

		[DataMember(Name = "TaskAssigneeID", IsRequired = false, EmitDefaultValue = true)]			
        public int TaskAssigneeID 
		{ 
			get
			{
				return _taskAssigneeID;
			}
			set
			{
				if(_taskAssigneeID != value)
				{
					_taskAssigneeID = value;
				} 
			}
		}
		#endregion
		
		#region WorkIsDone
		private bool? _workIsDone; 

		[DataMember(Name = "WorkIsDone", IsRequired = false, EmitDefaultValue = true)]			
        public bool? WorkIsDone 
		{ 
			get
			{
				return _workIsDone;
			}
			set
			{
				if(_workIsDone != value)
				{
					_workIsDone = value;
				} 
			}
		}
		#endregion
		
		#region Task
		private int _taskID;
		[DataMember(Name = "TaskID")]
        public int TaskID 
		{ 
			get
			{
				return _taskID;
			}
			set
			{
				if(_taskID != value)
				{
					_taskID = value;
				} 
			}
		}
		
		#endregion
		
		#region ProjectMember
		private int _projectMemberID;
		[DataMember(Name = "ProjectMemberID")]
        public int ProjectMemberID 
		{ 
			get
			{
				return _projectMemberID;
			}
			set
			{
				if(_projectMemberID != value)
				{
					_projectMemberID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region TaskAttachment entity
    /// <summary>
    /// Generated class for entity TaskAttachment
    /// </summary>
	[DataContract(Name = "TaskAttachment", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.TaskAttachment")]
	public partial class TaskAttachment     { 
		public int EntityBaseID { get { return Convert.ToInt32(TaskAttachmentID);} set { TaskAttachmentID = value; } }
		
		#region TaskAttachmentID
		private int _taskAttachmentID; 

		[DataMember(Name = "TaskAttachmentID", IsRequired = false, EmitDefaultValue = true)]			
        public int TaskAttachmentID 
		{ 
			get
			{
				return _taskAttachmentID;
			}
			set
			{
				if(_taskAttachmentID != value)
				{
					_taskAttachmentID = value;
				} 
			}
		}
		#endregion
		
		#region FileName
		private string _fileName; 

		[DataMember(Name = "FileName", IsRequired = false, EmitDefaultValue = true)]			
        public string FileName 
		{ 
			get
			{
				return _fileName;
			}
			set
			{
				if(_fileName != value)
				{
					_fileName = value;
				} 
			}
		}
		#endregion
		
		#region FileType
		private string _fileType; 

		[DataMember(Name = "FileType", IsRequired = false, EmitDefaultValue = true)]			
        public string FileType 
		{ 
			get
			{
				return _fileType;
			}
			set
			{
				if(_fileType != value)
				{
					_fileType = value;
				} 
			}
		}
		#endregion
		
		#region FileLength
		private int _fileLength; 

		[DataMember(Name = "FileLength", IsRequired = false, EmitDefaultValue = true)]			
        public int FileLength 
		{ 
			get
			{
				return _fileLength;
			}
			set
			{
				if(_fileLength != value)
				{
					_fileLength = value;
				} 
			}
		}
		#endregion
		
		#region FileContents
		private object _fileContents; 

		[DataMember(Name = "FileContents", IsRequired = false, EmitDefaultValue = true)]			
        public object FileContents 
		{ 
			get
			{
				return _fileContents;
			}
			set
			{
				if(_fileContents != value)
				{
					_fileContents = value;
				} 
			}
		}
		#endregion
		
		#region Description
		private string _description; 

		[DataMember(Name = "Description", IsRequired = false, EmitDefaultValue = true)]			
        public string Description 
		{ 
			get
			{
				return _description;
			}
			set
			{
				if(_description != value)
				{
					_description = value;
				} 
			}
		}
		#endregion
		
		#region UploadDate
		private DateTime _uploadDate; 

		[DataMember(Name = "UploadDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime UploadDate 
		{ 
			get
			{
				return _uploadDate;
			}
			set
			{
				if(_uploadDate != value)
				{
					_uploadDate = value;
				} 
			}
		}
		#endregion
		
		#region ProjectID
		private string _projectID; 

		[DataMember(Name = "ProjectID", IsRequired = false, EmitDefaultValue = true)]			
        public string ProjectID 
		{ 
			get
			{
				return _projectID;
			}
			set
			{
				if(_projectID != value)
				{
					_projectID = value;
				} 
			}
		}
		#endregion
		
		#region AttachmentSaveMode
		private int _attachmentSaveModeID;
		[DataMember(Name = "AttachmentSaveModeID")]
        public int AttachmentSaveModeID 
		{ 
			get
			{
				return _attachmentSaveModeID;
			}
			set
			{
				if(_attachmentSaveModeID != value)
				{
					_attachmentSaveModeID = value;
				} 
			}
		}
		
		#endregion
		
		#region Task
		private int _taskID;
		[DataMember(Name = "TaskID")]
        public int TaskID 
		{ 
			get
			{
				return _taskID;
			}
			set
			{
				if(_taskID != value)
				{
					_taskID = value;
				} 
			}
		}
		
		#endregion
		
		#region User
		private int _userID;
		[DataMember(Name = "UserID")]
        public int UserID 
		{ 
			get
			{
				return _userID;
			}
			set
			{
				if(_userID != value)
				{
					_userID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region TaskBillable entity
    /// <summary>
    /// Generated class for entity TaskBillable
    /// </summary>
	[DataContract(Name = "TaskBillable", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.TaskBillable")]
	public partial class TaskBillable  : ICustomFieldsContainer     { 
		public int EntityBaseID { get { return Convert.ToInt32(TaskID);} set { TaskID = value; } }
		
		#region TaskID
		private int _taskID; 

		[DataMember(Name = "TaskID", IsRequired = false, EmitDefaultValue = true)]			
        public int TaskID 
		{ 
			get
			{
				return _taskID;
			}
			set
			{
				if(_taskID != value)
				{
					_taskID = value;
				} 
			}
		}
		#endregion
		
		#region IsBillable
		private bool? _isBillable; 

		[DataMember(Name = "IsBillable", IsRequired = false, EmitDefaultValue = true)]			
        public bool? IsBillable 
		{ 
			get
			{
				return _isBillable;
			}
			set
			{
				if(_isBillable != value)
				{
					_isBillable = value;
				} 
			}
		}
		#endregion

	
	

		#region Custom fields
        private CustomFieldsCollection customFields;
		[DataMember(Name = "CustomFields")]
		public CustomFieldsCollection CustomFields 
		{
			get 
			{
				if (customFields == null) { customFields = new CustomFieldsCollection();}
				return customFields;
			}
			set{
				customFields = value;
			}
		}
		#endregion


    }
    #endregion
    
    #region TaskCriticalPath entity
    /// <summary>
    /// Generated class for entity TaskCriticalPath
    /// </summary>
	[DataContract(Name = "TaskCriticalPath", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.TaskCriticalPath")]
	public partial class TaskCriticalPath  : ICustomFieldsContainer     { 
		public int EntityBaseID { get { return Convert.ToInt32(PKID);} set { PKID = value; } }
		
		#region PKID
		private int _pKID; 

		[DataMember(Name = "PKID", IsRequired = false, EmitDefaultValue = true)]			
        public int PKID 
		{ 
			get
			{
				return _pKID;
			}
			set
			{
				if(_pKID != value)
				{
					_pKID = value;
				} 
			}
		}
		#endregion
		
		#region ProjectID
		private int? _projectID; 

		[DataMember(Name = "ProjectID", IsRequired = false, EmitDefaultValue = true)]			
        public int? ProjectID 
		{ 
			get
			{
				return _projectID;
			}
			set
			{
				if(_projectID != value)
				{
					_projectID = value;
				} 
			}
		}
		#endregion
		
		#region IsCriticalPath
		private bool? _isCriticalPath; 

		[DataMember(Name = "IsCriticalPath", IsRequired = false, EmitDefaultValue = true)]			
        public bool? IsCriticalPath 
		{ 
			get
			{
				return _isCriticalPath;
			}
			set
			{
				if(_isCriticalPath != value)
				{
					_isCriticalPath = value;
				} 
			}
		}
		#endregion
		
		#region Task
		private int _taskID;
		[DataMember(Name = "TaskID")]
        public int TaskID 
		{ 
			get
			{
				return _taskID;
			}
			set
			{
				if(_taskID != value)
				{
					_taskID = value;
				} 
			}
		}
		
		#endregion

	
	

		#region Custom fields
        private CustomFieldsCollection customFields;
		[DataMember(Name = "CustomFields")]
		public CustomFieldsCollection CustomFields 
		{
			get 
			{
				if (customFields == null) { customFields = new CustomFieldsCollection();}
				return customFields;
			}
			set{
				customFields = value;
			}
		}
		#endregion


    }
    #endregion
    
    #region TaskDependency entity
    /// <summary>
    /// Generated class for entity TaskDependency
    /// </summary>
	[DataContract(Name = "TaskDependency", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.TaskDependency")]
	public partial class TaskDependency     { 
		public int EntityBaseID { get { return Convert.ToInt32(TaskDependencyID);} set { TaskDependencyID = value; } }
		
		#region TaskDependencyID
		private int _taskDependencyID; 

		[DataMember(Name = "TaskDependencyID", IsRequired = false, EmitDefaultValue = true)]			
        public int TaskDependencyID 
		{ 
			get
			{
				return _taskDependencyID;
			}
			set
			{
				if(_taskDependencyID != value)
				{
					_taskDependencyID = value;
				} 
			}
		}
		#endregion
		
		#region Type
		private int _type; 

		[DataMember(Name = "Type", IsRequired = false, EmitDefaultValue = true)]			
        public int Type 
		{ 
			get
			{
				return _type;
			}
			set
			{
				if(_type != value)
				{
					_type = value;
				} 
			}
		}
		#endregion
		
		#region Delay
		private int _delay; 

		[DataMember(Name = "Delay", IsRequired = false, EmitDefaultValue = true)]			
        public int Delay 
		{ 
			get
			{
				return _delay;
			}
			set
			{
				if(_delay != value)
				{
					_delay = value;
				} 
			}
		}
		#endregion
		
		#region DependentTask
		private int _dependentTaskID;
		[DataMember(Name = "DependentTaskID")]
        public int DependentTaskID 
		{ 
			get
			{
				return _dependentTaskID;
			}
			set
			{
				if(_dependentTaskID != value)
				{
					_dependentTaskID = value;
				} 
			}
		}
		
		#endregion
		
		#region MasterTask
		private int _masterTaskID;
		[DataMember(Name = "MasterTaskID")]
        public int MasterTaskID 
		{ 
			get
			{
				return _masterTaskID;
			}
			set
			{
				if(_masterTaskID != value)
				{
					_masterTaskID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region TaskEVA entity
    /// <summary>
    /// Generated class for entity TaskEVA
    /// </summary>
	[DataContract(Name = "TaskEVA", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.TaskEVA")]
	public partial class TaskEVA     { 
		public int EntityBaseID { get { return Convert.ToInt32(0);} set { TaskID = value; } }
		
		#region TaskID
		private int _taskID; 

		[DataMember(Name = "TaskID", IsRequired = false, EmitDefaultValue = true)]			
        public int TaskID 
		{ 
			get
			{
				return _taskID;
			}
			set
			{
				if(_taskID != value)
				{
					_taskID = value;
				} 
			}
		}
		#endregion
		
		#region Health
		private int? _health; 

		[DataMember(Name = "Health", IsRequired = false, EmitDefaultValue = true)]			
        public int? Health 
		{ 
			get
			{
				return _health;
			}
			set
			{
				if(_health != value)
				{
					_health = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region TaskHoursLeft entity
    /// <summary>
    /// Generated class for entity TaskHoursLeft
    /// </summary>
	[DataContract(Name = "TaskHoursLeft", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.TaskHoursLeft")]
	public partial class TaskHoursLeft     { 
		public int EntityBaseID { get { return Convert.ToInt32(TaskID);} set { TaskID = value; } }
		
		#region TaskID
		private int _taskID; 

		[DataMember(Name = "TaskID", IsRequired = false, EmitDefaultValue = true)]			
        public int TaskID 
		{ 
			get
			{
				return _taskID;
			}
			set
			{
				if(_taskID != value)
				{
					_taskID = value;
				} 
			}
		}
		#endregion
		
		#region HoursLeft
		private decimal _hoursLeft; 

		[DataMember(Name = "HoursLeft", IsRequired = false, EmitDefaultValue = true)]			
        public decimal HoursLeft 
		{ 
			get
			{
				return _hoursLeft;
			}
			set
			{
				if(_hoursLeft != value)
				{
					_hoursLeft = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region TaskStatus entity
    /// <summary>
    /// Generated class for entity TaskStatus
    /// </summary>
	[DataContract(Name = "TaskStatus", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.TaskStatus")]
	public partial class TaskStatus     { 
		public int EntityBaseID { get { return Convert.ToInt32(TaskStatusID);} set { TaskStatusID = value; } }
		
		#region TaskStatusID
		private int _taskStatusID; 

		[DataMember(Name = "TaskStatusID", IsRequired = false, EmitDefaultValue = true)]			
        public int TaskStatusID 
		{ 
			get
			{
				return _taskStatusID;
			}
			set
			{
				if(_taskStatusID != value)
				{
					_taskStatusID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region TreatAsCompleted
		private bool _treatAsCompleted; 

		[DataMember(Name = "TreatAsCompleted", IsRequired = false, EmitDefaultValue = true)]			
        public bool TreatAsCompleted 
		{ 
			get
			{
				return _treatAsCompleted;
			}
			set
			{
				if(_treatAsCompleted != value)
				{
					_treatAsCompleted = value;
				} 
			}
		}
		#endregion
		
		#region TreatAsHold
		private bool _treatAsHold; 

		[DataMember(Name = "TreatAsHold", IsRequired = false, EmitDefaultValue = true)]			
        public bool TreatAsHold 
		{ 
			get
			{
				return _treatAsHold;
			}
			set
			{
				if(_treatAsHold != value)
				{
					_treatAsHold = value;
				} 
			}
		}
		#endregion
		
		#region RequiresApproval
		private bool _requiresApproval; 

		[DataMember(Name = "RequiresApproval", IsRequired = false, EmitDefaultValue = true)]			
        public bool RequiresApproval 
		{ 
			get
			{
				return _requiresApproval;
			}
			set
			{
				if(_requiresApproval != value)
				{
					_requiresApproval = value;
				} 
			}
		}
		#endregion
		
		#region InternalTaskStatusID
		private int? _internalTaskStatusID; 

		[DataMember(Name = "InternalTaskStatusID", IsRequired = false, EmitDefaultValue = true)]			
        public int? InternalTaskStatusID 
		{ 
			get
			{
				return _internalTaskStatusID;
			}
			set
			{
				if(_internalTaskStatusID != value)
				{
					_internalTaskStatusID = value;
				} 
			}
		}
		#endregion
		
		#region Icon
		private string _icon; 

		[DataMember(Name = "Icon", IsRequired = false, EmitDefaultValue = true)]			
        public string Icon 
		{ 
			get
			{
				return _icon;
			}
			set
			{
				if(_icon != value)
				{
					_icon = value;
				} 
			}
		}
		#endregion
		
		#region LastModificationDate
		private DateTime? _lastModificationDate; 

		[DataMember(Name = "LastModificationDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? LastModificationDate 
		{ 
			get
			{
				return _lastModificationDate;
			}
			set
			{
				if(_lastModificationDate != value)
				{
					_lastModificationDate = value;
				} 
			}
		}
		#endregion
		
		#region IsIconEmpty
		private bool? _isIconEmpty; 

		[DataMember(Name = "IsIconEmpty", IsRequired = false, EmitDefaultValue = true)]			
        public bool? IsIconEmpty 
		{ 
			get
			{
				return _isIconEmpty;
			}
			set
			{
				if(_isIconEmpty != value)
				{
					_isIconEmpty = value;
				} 
			}
		}
		#endregion
		
		#region IconHash
		private string _iconHash; 

		[DataMember(Name = "IconHash", IsRequired = false, EmitDefaultValue = true)]			
        public string IconHash 
		{ 
			get
			{
				return _iconHash;
			}
			set
			{
				if(_iconHash != value)
				{
					_iconHash = value;
				} 
			}
		}
		#endregion
		
		#region TaskType
		private int _taskTypeID;
		[DataMember(Name = "TaskTypeID")]
        public int TaskTypeID 
		{ 
			get
			{
				return _taskTypeID;
			}
			set
			{
				if(_taskTypeID != value)
				{
					_taskTypeID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region TaskType entity
    /// <summary>
    /// Generated class for entity TaskType
    /// </summary>
	[DataContract(Name = "TaskType", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.TaskType")]
	public partial class TaskType     { 
		public int EntityBaseID { get { return Convert.ToInt32(TaskTypeID);} set { TaskTypeID = value; } }
		
		#region TaskTypeID
		private int _taskTypeID; 

		[DataMember(Name = "TaskTypeID", IsRequired = false, EmitDefaultValue = true)]			
        public int TaskTypeID 
		{ 
			get
			{
				return _taskTypeID;
			}
			set
			{
				if(_taskTypeID != value)
				{
					_taskTypeID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region TaskWBS entity
    /// <summary>
    /// Generated class for entity TaskWBS
    /// </summary>
	[DataContract(Name = "TaskWBS", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.TaskWBS")]
	public partial class TaskWBS     { 
		public int EntityBaseID { get { return Convert.ToInt32(TaskID);} set { TaskID = value; } }
		
		#region TaskID
		private int _taskID; 

		[DataMember(Name = "TaskID", IsRequired = false, EmitDefaultValue = true)]			
        public int TaskID 
		{ 
			get
			{
				return _taskID;
			}
			set
			{
				if(_taskID != value)
				{
					_taskID = value;
				} 
			}
		}
		#endregion
		
		#region WBSNumber
		private int _wBSNumber; 

		[DataMember(Name = "WBSNumber", IsRequired = false, EmitDefaultValue = true)]			
        public int WBSNumber 
		{ 
			get
			{
				return _wBSNumber;
			}
			set
			{
				if(_wBSNumber != value)
				{
					_wBSNumber = value;
				} 
			}
		}
		#endregion
		
		#region LastModificationDate
		private DateTime _lastModificationDate; 

		[DataMember(Name = "LastModificationDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime LastModificationDate 
		{ 
			get
			{
				return _lastModificationDate;
			}
			set
			{
				if(_lastModificationDate != value)
				{
					_lastModificationDate = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region Threshold entity
    /// <summary>
    /// Generated class for entity Threshold
    /// </summary>
	[DataContract(Name = "Threshold", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Threshold")]
	public partial class Threshold     { 
		public int EntityBaseID { get { return Convert.ToInt32(ThresholdID);} set { ThresholdID = value; } }
		
		#region ThresholdID
		private int _thresholdID; 

		[DataMember(Name = "ThresholdID", IsRequired = false, EmitDefaultValue = true)]			
        public int ThresholdID 
		{ 
			get
			{
				return _thresholdID;
			}
			set
			{
				if(_thresholdID != value)
				{
					_thresholdID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region Value
		private decimal _value; 

		[DataMember(Name = "Value", IsRequired = false, EmitDefaultValue = true)]			
        public decimal Value 
		{ 
			get
			{
				return _value;
			}
			set
			{
				if(_value != value)
				{
					_value = value;
				} 
			}
		}
		#endregion
		
		#region Color
		private string _color; 

		[DataMember(Name = "Color", IsRequired = false, EmitDefaultValue = true)]			
        public string Color 
		{ 
			get
			{
				return _color;
			}
			set
			{
				if(_color != value)
				{
					_color = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region TimeEntry entity
    /// <summary>
    /// Generated class for entity TimeEntry
    /// </summary>
	[DataContract(Name = "TimeEntry", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.TimeEntry")]
	public partial class TimeEntry     { 
		public int EntityBaseID { get { return Convert.ToInt32(TimeEntryID);} set { TimeEntryID = value; } }
		
		#region TimeEntryID
		private int _timeEntryID; 

		[DataMember(Name = "TimeEntryID", IsRequired = false, EmitDefaultValue = true)]			
        public int TimeEntryID 
		{ 
			get
			{
				return _timeEntryID;
			}
			set
			{
				if(_timeEntryID != value)
				{
					_timeEntryID = value;
				} 
			}
		}
		#endregion
		
		#region EntryDate
		private DateTime _entryDate; 

		[DataMember(Name = "EntryDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime EntryDate 
		{ 
			get
			{
				return _entryDate;
			}
			set
			{
				if(_entryDate != value)
				{
					_entryDate = value;
				} 
			}
		}
		#endregion
		
		#region Description
		private string _description; 

		[DataMember(Name = "Description", IsRequired = false, EmitDefaultValue = true)]			
        public string Description 
		{ 
			get
			{
				return _description;
			}
			set
			{
				if(_description != value)
				{
					_description = value;
				} 
			}
		}
		#endregion
		
		#region Billable
		private bool _billable; 

		[DataMember(Name = "Billable", IsRequired = false, EmitDefaultValue = true)]			
        public bool Billable 
		{ 
			get
			{
				return _billable;
			}
			set
			{
				if(_billable != value)
				{
					_billable = value;
				} 
			}
		}
		#endregion
		
		#region Duration
		private decimal _duration; 

		[DataMember(Name = "Duration", IsRequired = false, EmitDefaultValue = true)]			
        public decimal Duration 
		{ 
			get
			{
				return _duration;
			}
			set
			{
				if(_duration != value)
				{
					_duration = value;
				} 
			}
		}
		#endregion
		
		#region LastModificationDate
		private DateTime? _lastModificationDate; 

		[DataMember(Name = "LastModificationDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? LastModificationDate 
		{ 
			get
			{
				return _lastModificationDate;
			}
			set
			{
				if(_lastModificationDate != value)
				{
					_lastModificationDate = value;
				} 
			}
		}
		#endregion
		
		#region Task
		private int _taskID;
		[DataMember(Name = "TaskID")]
        public int TaskID 
		{ 
			get
			{
				return _taskID;
			}
			set
			{
				if(_taskID != value)
				{
					_taskID = value;
				} 
			}
		}
		
		#endregion
		
		#region User
		private int _userID;
		[DataMember(Name = "UserID")]
        public int UserID 
		{ 
			get
			{
				return _userID;
			}
			set
			{
				if(_userID != value)
				{
					_userID = value;
				} 
			}
		}
		
		#endregion

	
	
		#region Permissions Fields		
        public bool CanEdit  {get; set;}
        public bool CanDelete  {get; set;}
		#endregion


    }
    #endregion
    
    #region Timeliness entity
    /// <summary>
    /// Generated class for entity Timeliness
    /// </summary>
	[DataContract(Name = "Timeliness", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Timeliness")]
	public partial class Timeliness     { 
		public int EntityBaseID { get { return Convert.ToInt32(TimelinessID);} set { TimelinessID = value; } }
		
		#region TimelinessID
		private int _timelinessID; 

		[DataMember(Name = "TimelinessID", IsRequired = false, EmitDefaultValue = true)]			
        public int TimelinessID 
		{ 
			get
			{
				return _timelinessID;
			}
			set
			{
				if(_timelinessID != value)
				{
					_timelinessID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region Delay
		private int _delay; 

		[DataMember(Name = "Delay", IsRequired = false, EmitDefaultValue = true)]			
        public int Delay 
		{ 
			get
			{
				return _delay;
			}
			set
			{
				if(_delay != value)
				{
					_delay = value;
				} 
			}
		}
		#endregion
		
		#region Icon
		private string _icon; 

		[DataMember(Name = "Icon", IsRequired = false, EmitDefaultValue = true)]			
        public string Icon 
		{ 
			get
			{
				return _icon;
			}
			set
			{
				if(_icon != value)
				{
					_icon = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region TimeLogWeeklyViewEntity entity
    /// <summary>
    /// Generated class for entity TimeLogWeeklyViewEntity
    /// </summary>
	[DataContract(Name = "TimeLogWeeklyViewEntity", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.TimeLogWeeklyViewEntity")]
	public partial class TimeLogWeeklyViewEntity     { 
		public int EntityBaseID { get { return Convert.ToInt32(0);} set { TaskID = value; } }
		
		#region TaskID
		private int _taskID; 

		[DataMember(Name = "TaskID", IsRequired = false, EmitDefaultValue = true)]			
        public int TaskID 
		{ 
			get
			{
				return _taskID;
			}
			set
			{
				if(_taskID != value)
				{
					_taskID = value;
				} 
			}
		}
		#endregion
		
		#region HoursOnDay0
		private decimal? _hoursOnDay0; 

		[DataMember(Name = "HoursOnDay0", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? HoursOnDay0 
		{ 
			get
			{
				return _hoursOnDay0;
			}
			set
			{
				if(_hoursOnDay0 != value)
				{
					_hoursOnDay0 = value;
				} 
			}
		}
		#endregion
		
		#region HoursOnDay1
		private decimal? _hoursOnDay1; 

		[DataMember(Name = "HoursOnDay1", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? HoursOnDay1 
		{ 
			get
			{
				return _hoursOnDay1;
			}
			set
			{
				if(_hoursOnDay1 != value)
				{
					_hoursOnDay1 = value;
				} 
			}
		}
		#endregion
		
		#region HoursOnDay2
		private decimal? _hoursOnDay2; 

		[DataMember(Name = "HoursOnDay2", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? HoursOnDay2 
		{ 
			get
			{
				return _hoursOnDay2;
			}
			set
			{
				if(_hoursOnDay2 != value)
				{
					_hoursOnDay2 = value;
				} 
			}
		}
		#endregion
		
		#region HoursOnDay3
		private decimal? _hoursOnDay3; 

		[DataMember(Name = "HoursOnDay3", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? HoursOnDay3 
		{ 
			get
			{
				return _hoursOnDay3;
			}
			set
			{
				if(_hoursOnDay3 != value)
				{
					_hoursOnDay3 = value;
				} 
			}
		}
		#endregion
		
		#region HoursOnDay4
		private decimal? _hoursOnDay4; 

		[DataMember(Name = "HoursOnDay4", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? HoursOnDay4 
		{ 
			get
			{
				return _hoursOnDay4;
			}
			set
			{
				if(_hoursOnDay4 != value)
				{
					_hoursOnDay4 = value;
				} 
			}
		}
		#endregion
		
		#region HoursOnDay5
		private decimal? _hoursOnDay5; 

		[DataMember(Name = "HoursOnDay5", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? HoursOnDay5 
		{ 
			get
			{
				return _hoursOnDay5;
			}
			set
			{
				if(_hoursOnDay5 != value)
				{
					_hoursOnDay5 = value;
				} 
			}
		}
		#endregion
		
		#region HoursOnDay6
		private decimal? _hoursOnDay6; 

		[DataMember(Name = "HoursOnDay6", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? HoursOnDay6 
		{ 
			get
			{
				return _hoursOnDay6;
			}
			set
			{
				if(_hoursOnDay6 != value)
				{
					_hoursOnDay6 = value;
				} 
			}
		}
		#endregion
		
		#region HoursTotal
		private decimal? _hoursTotal; 

		[DataMember(Name = "HoursTotal", IsRequired = false, EmitDefaultValue = true)]			
        public decimal? HoursTotal 
		{ 
			get
			{
				return _hoursTotal;
			}
			set
			{
				if(_hoursTotal != value)
				{
					_hoursTotal = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region User entity
    /// <summary>
    /// Generated class for entity User
    /// </summary>
	[DataContract(Name = "User", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.User")]
	public partial class User  : ICustomFieldsContainer     { 
		public int EntityBaseID { get { return Convert.ToInt32(UserID);} set { UserID = value; } }
		
		#region UserID
		private int _userID; 

		[DataMember(Name = "UserID", IsRequired = false, EmitDefaultValue = true)]			
        public int UserID 
		{ 
			get
			{
				return _userID;
			}
			set
			{
				if(_userID != value)
				{
					_userID = value;
				} 
			}
		}
		#endregion
		
		#region Login
		private string _login; 

		[DataMember(Name = "Login", IsRequired = false, EmitDefaultValue = true)]			
        public string Login 
		{ 
			get
			{
				return _login;
			}
			set
			{
				if(_login != value)
				{
					_login = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region Password
		private string _password; 

		[DataMember(Name = "Password", IsRequired = false, EmitDefaultValue = true)]			
        public string Password 
		{ 
			get
			{
				return _password;
			}
			set
			{
				if(_password != value)
				{
					_password = value;
				} 
			}
		}
		#endregion
		
		#region EMail
		private string _eMail; 

		[DataMember(Name = "EMail", IsRequired = false, EmitDefaultValue = true)]			
        public string EMail 
		{ 
			get
			{
				return _eMail;
			}
			set
			{
				if(_eMail != value)
				{
					_eMail = value;
				} 
			}
		}
		#endregion
		
		#region RecoverConfirmCode
		private string _recoverConfirmCode; 

		[DataMember(Name = "RecoverConfirmCode", IsRequired = false, EmitDefaultValue = true)]			
        public string RecoverConfirmCode 
		{ 
			get
			{
				return _recoverConfirmCode;
			}
			set
			{
				if(_recoverConfirmCode != value)
				{
					_recoverConfirmCode = value;
				} 
			}
		}
		#endregion
		
		#region Enabled
		private bool _enabled; 

		[DataMember(Name = "Enabled", IsRequired = false, EmitDefaultValue = true)]			
        public bool Enabled 
		{ 
			get
			{
				return _enabled;
			}
			set
			{
				if(_enabled != value)
				{
					_enabled = value;
				} 
			}
		}
		#endregion
		
		#region CanLogin
		private bool _canLogin; 

		[DataMember(Name = "CanLogin", IsRequired = false, EmitDefaultValue = true)]			
        public bool CanLogin 
		{ 
			get
			{
				return _canLogin;
			}
			set
			{
				if(_canLogin != value)
				{
					_canLogin = value;
				} 
			}
		}
		#endregion
		
		#region HourlyRate
		private decimal _hourlyRate; 

		[DataMember(Name = "HourlyRate", IsRequired = false, EmitDefaultValue = true)]			
        public decimal HourlyRate 
		{ 
			get
			{
				return _hourlyRate;
			}
			set
			{
				if(_hourlyRate != value)
				{
					_hourlyRate = value;
				} 
			}
		}
		#endregion
		
		#region ShowCompletedTasks
		private bool _showCompletedTasks; 

		[DataMember(Name = "ShowCompletedTasks", IsRequired = false, EmitDefaultValue = true)]			
        public bool ShowCompletedTasks 
		{ 
			get
			{
				return _showCompletedTasks;
			}
			set
			{
				if(_showCompletedTasks != value)
				{
					_showCompletedTasks = value;
				} 
			}
		}
		#endregion
		
		#region ShowCompletedProjects
		private bool _showCompletedProjects; 

		[DataMember(Name = "ShowCompletedProjects", IsRequired = false, EmitDefaultValue = true)]			
        public bool ShowCompletedProjects 
		{ 
			get
			{
				return _showCompletedProjects;
			}
			set
			{
				if(_showCompletedProjects != value)
				{
					_showCompletedProjects = value;
				} 
			}
		}
		#endregion
		
		#region ShowCompletedPortfolios
		private bool _showCompletedPortfolios; 

		[DataMember(Name = "ShowCompletedPortfolios", IsRequired = false, EmitDefaultValue = true)]			
        public bool ShowCompletedPortfolios 
		{ 
			get
			{
				return _showCompletedPortfolios;
			}
			set
			{
				if(_showCompletedPortfolios != value)
				{
					_showCompletedPortfolios = value;
				} 
			}
		}
		#endregion
		
		#region ShowAvatars
		private bool _showAvatars; 

		[DataMember(Name = "ShowAvatars", IsRequired = false, EmitDefaultValue = true)]			
        public bool ShowAvatars 
		{ 
			get
			{
				return _showAvatars;
			}
			set
			{
				if(_showAvatars != value)
				{
					_showAvatars = value;
				} 
			}
		}
		#endregion
		
		#region Avatar
		private string _avatar; 

		[DataMember(Name = "Avatar", IsRequired = false, EmitDefaultValue = true)]			
        public string Avatar 
		{ 
			get
			{
				return _avatar;
			}
			set
			{
				if(_avatar != value)
				{
					_avatar = value;
				} 
			}
		}
		#endregion
		
		#region IsAvatarEmpty
		private bool? _isAvatarEmpty; 

		[DataMember(Name = "IsAvatarEmpty", IsRequired = false, EmitDefaultValue = true)]			
        public bool? IsAvatarEmpty 
		{ 
			get
			{
				return _isAvatarEmpty;
			}
			set
			{
				if(_isAvatarEmpty != value)
				{
					_isAvatarEmpty = value;
				} 
			}
		}
		#endregion
		
		#region AvatarHash
		private string _avatarHash; 

		[DataMember(Name = "AvatarHash", IsRequired = false, EmitDefaultValue = true)]			
        public string AvatarHash 
		{ 
			get
			{
				return _avatarHash;
			}
			set
			{
				if(_avatarHash != value)
				{
					_avatarHash = value;
				} 
			}
		}
		#endregion
		
		#region DefaultPage
		private string _defaultPage; 

		[DataMember(Name = "DefaultPage", IsRequired = false, EmitDefaultValue = true)]			
        public string DefaultPage 
		{ 
			get
			{
				return _defaultPage;
			}
			set
			{
				if(_defaultPage != value)
				{
					_defaultPage = value;
				} 
			}
		}
		#endregion
		
		#region OpenId
		private string _openId; 

		[DataMember(Name = "OpenId", IsRequired = false, EmitDefaultValue = true)]			
        public string OpenId 
		{ 
			get
			{
				return _openId;
			}
			set
			{
				if(_openId != value)
				{
					_openId = value;
				} 
			}
		}
		#endregion
		
		#region LastActivityDate
		private DateTime? _lastActivityDate; 

		[DataMember(Name = "LastActivityDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? LastActivityDate 
		{ 
			get
			{
				return _lastActivityDate;
			}
			set
			{
				if(_lastActivityDate != value)
				{
					_lastActivityDate = value;
				} 
			}
		}
		#endregion
		
		#region PasswordModifyDate
		private DateTime? _passwordModifyDate; 

		[DataMember(Name = "PasswordModifyDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? PasswordModifyDate 
		{ 
			get
			{
				return _passwordModifyDate;
			}
			set
			{
				if(_passwordModifyDate != value)
				{
					_passwordModifyDate = value;
				} 
			}
		}
		#endregion
		
		#region InvalidPasswordAttemptsCount
		private int? _invalidPasswordAttemptsCount; 

		[DataMember(Name = "InvalidPasswordAttemptsCount", IsRequired = false, EmitDefaultValue = true)]			
        public int? InvalidPasswordAttemptsCount 
		{ 
			get
			{
				return _invalidPasswordAttemptsCount;
			}
			set
			{
				if(_invalidPasswordAttemptsCount != value)
				{
					_invalidPasswordAttemptsCount = value;
				} 
			}
		}
		#endregion
		
		#region LastLockoutDate
		private DateTime? _lastLockoutDate; 

		[DataMember(Name = "LastLockoutDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime? LastLockoutDate 
		{ 
			get
			{
				return _lastLockoutDate;
			}
			set
			{
				if(_lastLockoutDate != value)
				{
					_lastLockoutDate = value;
				} 
			}
		}
		#endregion
		
		#region Customer
		private int _customerID;
		[DataMember(Name = "CustomerID")]
        public int CustomerID 
		{ 
			get
			{
				return _customerID;
			}
			set
			{
				if(_customerID != value)
				{
					_customerID = value;
				} 
			}
		}
		
		#endregion
		
		#region Role
		private int _roleID;
		[DataMember(Name = "RoleID")]
        public int RoleID 
		{ 
			get
			{
				return _roleID;
			}
			set
			{
				if(_roleID != value)
				{
					_roleID = value;
				} 
			}
		}
		
		#endregion
		
		#region UserType
		private int _userTypeID;
		[DataMember(Name = "UserTypeID")]
        public int UserTypeID 
		{ 
			get
			{
				return _userTypeID;
			}
			set
			{
				if(_userTypeID != value)
				{
					_userTypeID = value;
				} 
			}
		}
		
		#endregion

	
	

		#region Custom fields
        private CustomFieldsCollection customFields;
		[DataMember(Name = "CustomFields")]
		public CustomFieldsCollection CustomFields 
		{
			get 
			{
				if (customFields == null) { customFields = new CustomFieldsCollection();}
				return customFields;
			}
			set{
				customFields = value;
			}
		}
		#endregion


    }
    #endregion
    
    #region UserGroup entity
    /// <summary>
    /// Generated class for entity UserGroup
    /// </summary>
	[DataContract(Name = "UserGroup", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.UserGroup")]
	public partial class UserGroup     { 
		public int EntityBaseID { get { return Convert.ToInt32(UserGroupID);} set { UserGroupID = value; } }
		
		#region UserGroupID
		private int _userGroupID; 

		[DataMember(Name = "UserGroupID", IsRequired = false, EmitDefaultValue = true)]			
        public int UserGroupID 
		{ 
			get
			{
				return _userGroupID;
			}
			set
			{
				if(_userGroupID != value)
				{
					_userGroupID = value;
				} 
			}
		}
		#endregion
		
		#region User
		private int _userID;
		[DataMember(Name = "UserID")]
        public int UserID 
		{ 
			get
			{
				return _userID;
			}
			set
			{
				if(_userID != value)
				{
					_userID = value;
				} 
			}
		}
		
		#endregion
		
		#region Group
		private int _groupID;
		[DataMember(Name = "GroupID")]
        public int GroupID 
		{ 
			get
			{
				return _groupID;
			}
			set
			{
				if(_groupID != value)
				{
					_groupID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region UserType entity
    /// <summary>
    /// Generated class for entity UserType
    /// </summary>
	[DataContract(Name = "UserType", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.UserType")]
	public partial class UserType     { 
		public int EntityBaseID { get { return Convert.ToInt32(UserTypeID);} set { UserTypeID = value; } }
		
		#region UserTypeID
		private int _userTypeID; 

		[DataMember(Name = "UserTypeID", IsRequired = false, EmitDefaultValue = true)]			
        public int UserTypeID 
		{ 
			get
			{
				return _userTypeID;
			}
			set
			{
				if(_userTypeID != value)
				{
					_userTypeID = value;
				} 
			}
		}
		#endregion
		
		#region UserTypeName
		private string _userTypeName; 

		[DataMember(Name = "UserTypeName", IsRequired = false, EmitDefaultValue = true)]			
        public string UserTypeName 
		{ 
			get
			{
				return _userTypeName;
			}
			set
			{
				if(_userTypeName != value)
				{
					_userTypeName = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region Vacation entity
    /// <summary>
    /// Generated class for entity Vacation
    /// </summary>
	[DataContract(Name = "Vacation", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Vacation")]
	public partial class Vacation     { 
		public int EntityBaseID { get { return Convert.ToInt32(VacationID);} set { VacationID = value; } }
		
		#region VacationID
		private int _vacationID; 

		[DataMember(Name = "VacationID", IsRequired = false, EmitDefaultValue = true)]			
        public int VacationID 
		{ 
			get
			{
				return _vacationID;
			}
			set
			{
				if(_vacationID != value)
				{
					_vacationID = value;
				} 
			}
		}
		#endregion
		
		#region Date
		private DateTime _date; 

		[DataMember(Name = "Date", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime Date 
		{ 
			get
			{
				return _date;
			}
			set
			{
				if(_date != value)
				{
					_date = value;
				} 
			}
		}
		#endregion
		
		#region VacationType
		private int _vacationTypeID;
		[DataMember(Name = "VacationTypeID")]
        public int VacationTypeID 
		{ 
			get
			{
				return _vacationTypeID;
			}
			set
			{
				if(_vacationTypeID != value)
				{
					_vacationTypeID = value;
				} 
			}
		}
		
		#endregion
		
		#region User
		private int _userID;
		[DataMember(Name = "UserID")]
        public int UserID 
		{ 
			get
			{
				return _userID;
			}
			set
			{
				if(_userID != value)
				{
					_userID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    
    #region VacationType entity
    /// <summary>
    /// Generated class for entity VacationType
    /// </summary>
	[DataContract(Name = "VacationType", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.VacationType")]
	public partial class VacationType     { 
		public int EntityBaseID { get { return Convert.ToInt32(VacationTypeID);} set { VacationTypeID = value; } }
		
		#region VacationTypeID
		private int _vacationTypeID; 

		[DataMember(Name = "VacationTypeID", IsRequired = false, EmitDefaultValue = true)]			
        public int VacationTypeID 
		{ 
			get
			{
				return _vacationTypeID;
			}
			set
			{
				if(_vacationTypeID != value)
				{
					_vacationTypeID = value;
				} 
			}
		}
		#endregion
		
		#region Name
		private string _name; 

		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]			
        public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					_name = value;
				} 
			}
		}
		#endregion
		
		#region Color
		private string _color; 

		[DataMember(Name = "Color", IsRequired = false, EmitDefaultValue = true)]			
        public string Color 
		{ 
			get
			{
				return _color;
			}
			set
			{
				if(_color != value)
				{
					_color = value;
				} 
			}
		}
		#endregion

	
	


    }
    #endregion
    
    #region WorkflowEvent entity
    /// <summary>
    /// Generated class for entity WorkflowEvent
    /// </summary>
	[DataContract(Name = "WorkflowEvent", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.WorkflowEvent")]
	public partial class WorkflowEvent     { 
		public int EntityBaseID { get { return Convert.ToInt32(WorkflowEventID);} set { WorkflowEventID = value; } }
		
		#region WorkflowEventID
		private int _workflowEventID; 

		[DataMember(Name = "WorkflowEventID", IsRequired = false, EmitDefaultValue = true)]			
        public int WorkflowEventID 
		{ 
			get
			{
				return _workflowEventID;
			}
			set
			{
				if(_workflowEventID != value)
				{
					_workflowEventID = value;
				} 
			}
		}
		#endregion
		
		#region WorkflowEventType
		private int _workflowEventType; 

		[DataMember(Name = "WorkflowEventType", IsRequired = false, EmitDefaultValue = true)]			
        public int WorkflowEventType 
		{ 
			get
			{
				return _workflowEventType;
			}
			set
			{
				if(_workflowEventType != value)
				{
					_workflowEventType = value;
				} 
			}
		}
		#endregion
		
		#region EventDate
		private DateTime _eventDate; 

		[DataMember(Name = "EventDate", IsRequired = false, EmitDefaultValue = true)]			
        public DateTime EventDate 
		{ 
			get
			{
				return _eventDate;
			}
			set
			{
				if(_eventDate != value)
				{
					_eventDate = value;
				} 
			}
		}
		#endregion
		
		#region Task
		private int _taskID;
		[DataMember(Name = "TaskID")]
        public int TaskID 
		{ 
			get
			{
				return _taskID;
			}
			set
			{
				if(_taskID != value)
				{
					_taskID = value;
				} 
			}
		}
		
		#endregion
		
		#region Project
		private int _projectID;
		[DataMember(Name = "ProjectID")]
        public int ProjectID 
		{ 
			get
			{
				return _projectID;
			}
			set
			{
				if(_projectID != value)
				{
					_projectID = value;
				} 
			}
		}
		
		#endregion
		
		#region User
		private int _userID;
		[DataMember(Name = "UserID")]
        public int UserID 
		{ 
			get
			{
				return _userID;
			}
			set
			{
				if(_userID != value)
				{
					_userID = value;
				} 
			}
		}
		
		#endregion
		
		#region AssigneeUser
		private int _assigneeUserID;
		[DataMember(Name = "AssigneeUserID")]
        public int AssigneeUserID 
		{ 
			get
			{
				return _assigneeUserID;
			}
			set
			{
				if(_assigneeUserID != value)
				{
					_assigneeUserID = value;
				} 
			}
		}
		
		#endregion

	
	


    }
    #endregion
    


}


