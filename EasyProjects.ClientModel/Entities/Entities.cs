
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
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Runtime.Serialization;
	using System.Xml.Serialization;

    /// <summary>
    /// Generated class for entity ACProjectAggregatedValues
    /// </summary>
	[DataContract(Namespace="")]
	public partial class ACProjectAggregatedValues 

    { 
		public ACProjectAggregatedValues()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.ProjectID;} set { this.ProjectID = value; } }
		[DataMember]
        public int ProjectAggregatedValues_Project_ProjectID { get; set; }
		[DataMember]
        public decimal? ActualHours { get; set; }
		[DataMember]
        public decimal? Budget { get; set; }
		[DataMember]
        public decimal? EstimatedHours { get; set; }
		[DataMember]
        public decimal? ChildsBudget { get; set; }
		[DataMember]
        public decimal? ChildsEstimatedHours { get; set; }
		[DataMember]
        public decimal Cost { get; set; }
		[DataMember]
        public decimal InternalCost { get; set; }
		[DataMember]
        public decimal CostVariance { get; set; }
		[DataMember]
        public decimal BudgetedCost { get; set; }
		[DataMember]
        public decimal Profit { get; set; }
		[DataMember]
        public decimal PlannedExpenses { get; set; }
		[DataMember]
        public int ProfitHealth { get; set; }
		[DataMember]
        public decimal Profitability { get; set; }
		
		[DataMember]
        public int ProjectID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity ACTaskAggregatedValues
    /// </summary>
	[DataContract(Namespace="")]
	public partial class ACTaskAggregatedValues 

    { 
		public ACTaskAggregatedValues()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.TaskID;} set { this.TaskID = value; } }
		[DataMember]
        public int TaskAggregatedValues_Task_TaskID { get; set; }
		[DataMember]
        public decimal? ActualHours { get; set; }
		[DataMember]
        public decimal? Budget { get; set; }
		[DataMember]
        public decimal? EstimatedHours { get; set; }
		[DataMember]
        public decimal? ChildsActualHours { get; set; }
		[DataMember]
        public decimal? ChildsBudget { get; set; }
		[DataMember]
        public decimal? ChildsEstimatedHours { get; set; }
		[DataMember]
        public decimal? OwnEstimatedHours { get; set; }
		[DataMember]
        public decimal? Cost { get; set; }
		[DataMember]
        public decimal? OwnCost { get; set; }
		[DataMember]
        public decimal? InternalCost { get; set; }
		[DataMember]
        public decimal? CostVariance { get; set; }
		[DataMember]
        public decimal? Profit { get; set; }
		[DataMember]
        public int? ProfitHealth { get; set; }
		[DataMember]
        public decimal? OwnEstimatedCost { get; set; }
		[DataMember]
        public decimal? EstimatedCost { get; set; }
		
		[DataMember]
        public int TaskID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity ACTaskHealth
    /// </summary>
	[DataContract(Namespace="")]
	public partial class ACTaskHealth 

    { 
		public ACTaskHealth()
		{
            this.CustomFields = new CustomFieldsCollection();
		}

		[DataMember]
        public int TaskAggregatedValues_Task_TaskID { get; set; }
		[DataMember]
        public int? Health { get; set; }
		
		[DataMember]
        public int TaskID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Attachment
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Attachment 

    { 
		public Attachment()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.AttachmentID;} set { this.AttachmentID = value; } }
		[DataMember]
        public int AttachmentID { get; set; }
		[DataMember]
        public string FileName { get; set; }
		[DataMember]
        public string RelativePath { get; set; }
		[DataMember]
        public string FileType { get; set; }
		[DataMember]
        public int FileLength { get; set; }
		[DataMember]
        public object FileContents { get; set; }
		[DataMember]
        public int Version { get; set; }
		[DataMember]
        public DateTime? CreationDate { get; set; }
		[DataMember]
        public bool CanHaveThumbnail { get; set; }
		[DataMember]
        public bool HasThumbnail { get; set; }
		[DataMember]
        public object ThumbnailContents { get; set; }
		
		[DataMember]
        public int? MessageID { get; set; }
		
		[DataMember]
        public int AttachmentSaveModeID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity CalendarEvent
    /// </summary>
	[DataContract(Namespace="")]
	public partial class CalendarEvent 

    { 
		public CalendarEvent()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.CalendarEventID;} set { this.CalendarEventID = value; } }
		[DataMember]
        public int CalendarEventID { get; set; }
		[DataMember]
        public int? TaskEventID { get; set; }
		[DataMember]
        public int? CreatorID { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public DateTime? StartDate { get; set; }
		[DataMember]
        public DateTime? EndDate { get; set; }
		[DataMember]
        public string CalendarEventType { get; set; }
		[DataMember]
        public string VacationUserName { get; set; }
		[DataMember]
        public int? VacationUserID { get; set; }
		[DataMember]
        public bool? IsHalfDayVacation { get; set; }
		
		[DataMember]
        public int TaskStatusID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Category
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Category 

    { 
		public Category()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.CategoryID;} set { this.CategoryID = value; } }
		[DataMember]
        public int CategoryID { get; set; }
		[DataMember]
        public string Name { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Customer
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Customer 

    { 
		public Customer()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.CustomerID;} set { this.CustomerID = value; } }
		[DataMember]
        public int CustomerID { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public bool Enabled { get; set; }
		[DataMember]
        public string Description { get; set; }
		[DataMember]
        public string Address1 { get; set; }
		[DataMember]
        public string Address2 { get; set; }
		[DataMember]
        public string City { get; set; }
		[DataMember]
        public string State { get; set; }
		[DataMember]
        public string Country { get; set; }
		[DataMember]
        public string PostalCode { get; set; }
		[DataMember]
        public string Phone1 { get; set; }
		[DataMember]
        public string Phone2 { get; set; }
		[DataMember]
        public string Fax { get; set; }
		[DataMember]
        public decimal HourlyRate { get; set; }
		[DataMember]
        public DateTime? LastModificationDate { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity CustomField
    /// </summary>
	[DataContract(Namespace="")]
	public partial class CustomField 

    { 
		public CustomField()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.FieldID;} set { this.FieldID = value; } }
		[DataMember]
        public int FieldID { get; set; }
		[DataMember]
        public string FieldName { get; set; }
		[DataMember]
        public string DisplayName { get; set; }
		[DataMember]
        public string FieldDataTypeName { get; set; }
		[DataMember]
        public int FieldIndex { get; set; }
		[DataMember]
        public bool IsRequired { get; set; }
		[DataMember]
        public bool IsRestricted { get; set; }
		[DataMember]
        public int? Order { get; set; }
		[DataMember]
        public string Description { get; set; }
		[DataMember]
        public bool? IsNumeric { get; set; }
		[DataMember]
        public bool? IsIdentity { get; set; }
		[DataMember]
        public int? CurrentIdentity { get; set; }
		
		[DataMember]
        public int EntityID { get; set; }
		
		[DataMember]
        public int FieldDataTypeID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity CustomFieldDataType
    /// </summary>
	[DataContract(Namespace="")]
	public partial class CustomFieldDataType 

    { 
		public CustomFieldDataType()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.FieldDataTypeID;} set { this.FieldDataTypeID = value; } }
		[DataMember]
        public int FieldDataTypeID { get; set; }
		[DataMember]
        public string DisplayName { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity CustomFieldEntity
    /// </summary>
	[DataContract(Namespace="")]
	public partial class CustomFieldEntity 

    { 
		public CustomFieldEntity()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.EntityID;} set { this.EntityID = value; } }
		[DataMember]
        public int EntityID { get; set; }
		[DataMember]
        public string DisplayName { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity CustomFieldOrder
    /// </summary>
	[DataContract(Namespace="")]
	public partial class CustomFieldOrder 

    { 
		public CustomFieldOrder()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.FieldID;} set { this.FieldID = value; } }
		[DataMember]
        public int FieldID { get; set; }
		[DataMember]
        public int Order { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity CustomFieldRestriction
    /// </summary>
	[DataContract(Namespace="")]
	public partial class CustomFieldRestriction 

    { 
		public CustomFieldRestriction()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.FieldRestrictionID;} set { this.FieldRestrictionID = value; } }
		[DataMember]
        public int FieldRestrictionID { get; set; }
		
		[DataMember]
        public int FieldID { get; set; }
		
		[DataMember]
        public int? PortfolioID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity CustomFieldValue
    /// </summary>
	[DataContract(Namespace="")]
	public partial class CustomFieldValue 

    { 
		public CustomFieldValue()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.FieldValueID;} set { this.FieldValueID = value; } }
		[DataMember]
        public int FieldValueID { get; set; }
		[DataMember]
        public string Value { get; set; }
		[DataMember]
        public int Order { get; set; }
		
		[DataMember]
        public int FieldID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Event
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Event 

    { 
		public Event()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.EventID;} set { this.EventID = value; } }
		[DataMember]
        public int EventID { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public string Description { get; set; }
		[DataMember]
        public DateTime StartDate { get; set; }
		[DataMember]
        public DateTime? EndDate { get; set; }
		
		[DataMember]
        public int CreatorID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity EventAssignee
    /// </summary>
	[DataContract(Namespace="")]
	public partial class EventAssignee 

    { 
		public EventAssignee()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.EventAssigneeID;} set { this.EventAssigneeID = value; } }
		[DataMember]
        public int EventAssigneeID { get; set; }
		
		[DataMember]
        public int EventID { get; set; }
		
		[DataMember]
        public int UserID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity EventUser
    /// </summary>
	[DataContract(Namespace="")]
	public partial class EventUser 

    { 
		public EventUser()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.EventUserID;} set { this.EventUserID = value; } }
		[DataMember]
        public int EventUserID { get; set; }
		
		[DataMember]
        public int UserID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity FilterEntity
    /// </summary>
	[DataContract(Namespace="")]
	public partial class FilterEntity 

    { 
		public FilterEntity()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.FilterID;} set { this.FilterID = value; } }
		[DataMember]
        public int FilterID { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public string FilterXML { get; set; }
		[DataMember]
        public bool? IsShared { get; set; }
		
		[DataMember]
        public int? UserID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity FormAttachment
    /// </summary>
	[DataContract(Namespace="")]
	public partial class FormAttachment 

    { 
		public FormAttachment()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.FormAttachmentID;} set { this.FormAttachmentID = value; } }
		[DataMember]
        public int FormAttachmentID { get; set; }
		[DataMember]
        public int FormRecordID { get; set; }
		[DataMember]
        public string FileName { get; set; }
		[DataMember]
        public string RelativePath { get; set; }
		[DataMember]
        public string FileType { get; set; }
		[DataMember]
        public int FileLength { get; set; }
		[DataMember]
        public object FileContents { get; set; }
		[DataMember]
        public int? FormID { get; set; }
		[DataMember]
        public bool? CanHaveThumbnail { get; set; }
		[DataMember]
        public bool? HasThumbnail { get; set; }
		[DataMember]
        public object ThumbnailContents { get; set; }
		
		[DataMember]
        public int AttachmentSaveModeID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity IssueByEmailOptions
    /// </summary>
	[DataContract(Namespace="")]
	public partial class IssueByEmailOptions 

    { 
		public IssueByEmailOptions()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.OptionsID;} set { this.OptionsID = value; } }
		[DataMember]
        public int OptionsID { get; set; }
		[DataMember]
        public int AccountID { get; set; }
		[DataMember]
        public bool EnableIssueByMail { get; set; }
		[DataMember]
        public string Pop3Server { get; set; }
		[DataMember]
        public int Pop3Port { get; set; }
		[DataMember]
        public string Pop3UserName { get; set; }
		[DataMember]
        public string Pop3Password { get; set; }
		[DataMember]
        public bool DeleteLetters { get; set; }
		[DataMember]
        public bool Pop3EnableSSL { get; set; }
		
		[DataMember]
        public int? ProjectID { get; set; }
		
		[DataMember]
        public int? UserID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity MemberPermission
    /// </summary>
	[DataContract(Namespace="")]
	public partial class MemberPermission 

    { 
		public MemberPermission()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.MemberPermissionID;} set { this.MemberPermissionID = value; } }
		[DataMember]
        public int MemberPermissionID { get; set; }
		[DataMember]
        public bool CanAccessAllTasks { get; set; }
		[DataMember]
        public bool CanAccessAllTimeEntries { get; set; }
		[DataMember]
        public bool CanEditProject { get; set; }
		[DataMember]
        public bool CanEditAllTasks { get; set; }
		[DataMember]
        public bool? CanEditAssignedTasks { get; set; }
		[DataMember]
        public bool CanEditAllTimeEntries { get; set; }
		[DataMember]
        public bool CanCreateTasks { get; set; }
		[DataMember]
        public bool? CanCreateTimeEntries { get; set; }
		[DataMember]
        public bool CanCreateTimeEntriesForOther { get; set; }
		[DataMember]
        public bool CanDeleteProject { get; set; }
		[DataMember]
        public bool CanDeleteAllTasks { get; set; }
		[DataMember]
        public bool CanDeleteAllTimeEntries { get; set; }
		[DataMember]
        public bool? CanManageAssigneesTasks { get; set; }
		[DataMember]
        public bool? CanViewMembersAndAssignees { get; set; }
		[DataMember]
        public bool? CanManageProjectMembers { get; set; }
		[DataMember]
        public bool? CanManage { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Message
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Message 

    { 
		public Message()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.MessageID;} set { this.MessageID = value; } }
		[DataMember]
        public int MessageID { get; set; }
		[DataMember]
        public DateTime PostDate { get; set; }
		[DataMember]
        public string MessageText { get; set; }
		[DataMember]
        public DateTime? EditedAt { get; set; }
		[DataMember]
        public string EditedByName { get; set; }
		[DataMember]
        public int? EditedByUserID { get; set; }
		
		[DataMember]
        public int? TaskID { get; set; }
		
		[DataMember]
        public int? ProjectID { get; set; }
		
		[DataMember]
        public int? UserID { get; set; }

		#region Additional Permissions Fields		
		
		[DataMember]
        public bool CanEditEntity  {get; set;}
		#endregion		
	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity MessageBoardOptions
    /// </summary>
	[DataContract(Namespace="")]
	public partial class MessageBoardOptions 

    { 
		public MessageBoardOptions()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.ID;} set { this.ID = value; } }
		[DataMember]
        public int ID { get; set; }
		[DataMember]
        public DateTime TimeVisit { get; set; }
		[DataMember]
        public bool EventsVisible { get; set; }
		[DataMember]
        public bool MessagesVisible { get; set; }
		[DataMember]
        public bool FilesVisible { get; set; }
		
		[DataMember]
        public int UserID { get; set; }
		
		[DataMember]
        public int? ProjectID { get; set; }
		
		[DataMember]
        public int? TaskID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Options
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Options 

    { 
		public Options()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.OptionsID;} set { this.OptionsID = value; } }
		[DataMember]
        public int OptionsID { get; set; }
		[DataMember]
        public int AccountID { get; set; }
		[DataMember]
        public bool WeekendsAsWorkdays { get; set; }
		[DataMember]
        public bool EnableNotifications { get; set; }
		[DataMember]
        public string MailFromName { get; set; }
		[DataMember]
        public string MailFromAddress { get; set; }
		[DataMember]
        public string SmtpServer { get; set; }
		[DataMember]
        public int SmtpPort { get; set; }
		[DataMember]
        public string SmtpUserName { get; set; }
		[DataMember]
        public string SmtpPassword { get; set; }
		[DataMember]
        public bool EnableIssueByMail { get; set; }
		[DataMember]
        public string Pop3Server { get; set; }
		[DataMember]
        public int Pop3Port { get; set; }
		[DataMember]
        public bool Pop3EnableSSL { get; set; }
		[DataMember]
        public string Pop3UserName { get; set; }
		[DataMember]
        public string Pop3Password { get; set; }
		[DataMember]
        public bool DeleteLetters { get; set; }
		[DataMember]
        public bool EnableSSL { get; set; }
		[DataMember]
        public bool NotifyCreator { get; set; }
		[DataMember]
        public bool NotifyAssignees { get; set; }
		[DataMember]
        public bool NotifyEventEdit { get; set; }
		[DataMember]
        public bool NotifyEventAssign { get; set; }
		[DataMember]
        public bool NotifyEventDelete { get; set; }
		[DataMember]
        public bool NotifyProjectManagersVacationChanged { get; set; }
		[DataMember]
        public bool EnableSmarterTrackIntegration { get; set; }
		[DataMember]
        public string SmarterTrackAgentUserName { get; set; }
		[DataMember]
        public string SmarterTrackAgentPassword { get; set; }
		[DataMember]
        public string SmarterTrackUrl { get; set; }
		[DataMember]
        public bool ShowPortfolios { get; set; }
		[DataMember]
        public bool EnableApproveWorkflow { get; set; }
		[DataMember]
        public bool CreatorAsApprover { get; set; }
		[DataMember]
        public bool PMAsApprover { get; set; }
		[DataMember]
        public decimal NumberOfHoursPerDay { get; set; }
		[DataMember]
        public decimal SPIThreshold { get; set; }
		[DataMember]
        public decimal CPIThreshold { get; set; }
		[DataMember]
        public DateTime VacationYearStartDate { get; set; }
		[DataMember]
        public bool CNRAvailable { get; set; }
		[DataMember]
        public bool EnforceProhibitedWordsPolicy { get; set; }
		[DataMember]
        public bool EnforcePasswordStrength { get; set; }
		[DataMember]
        public int PasswordLength { get; set; }
		[DataMember]
        public int PasswordNumbersCount { get; set; }
		[DataMember]
        public int PasswordSpecSymbolsCount { get; set; }
		[DataMember]
        public bool LockOutUserAfterInvalidPassword { get; set; }
		[DataMember]
        public int InvalidPasswordAttempts { get; set; }
		[DataMember]
        public bool UnblockOnRecovery { get; set; }
		[DataMember]
        public bool UnblockAutomatically { get; set; }
		[DataMember]
        public int UnblockAutomaticallyIn { get; set; }
		[DataMember]
        public bool LockoutUserDueToInactivity { get; set; }
		[DataMember]
        public int MaxUserInactivity { get; set; }
		[DataMember]
        public bool EnablePasswordExpiration { get; set; }
		[DataMember]
        public int PasswordExpiration { get; set; }
		[DataMember]
        public int ReportRowsLimit { get; set; }
		[DataMember]
        public DateTime? LastActivity { get; set; }
		[DataMember]
        public bool? SecondLoginFlag { get; set; }
		[DataMember]
        public object AvatarsVersion { get; set; }
		[DataMember]
        public bool CreatorHasFullAccessToProject { get; set; }
		[DataMember]
        public bool ForceHttps { get; set; }
		[DataMember]
        public int AttachmentsSpace { get; set; }
		[DataMember]
        public bool HasPaymentProblem { get; set; }
		[DataMember]
        public bool UseActualCompletionDateForDependencies { get; set; }
		[DataMember]
        public bool IsSuspended { get; set; }
		[DataMember]
        public bool ProjectMessagesAttachmentsVisibleForLA { get; set; }
		[DataMember]
        public decimal BreakevenRate { get; set; }
		[DataMember]
        public int WorkWeekStartsOn { get; set; }
		[DataMember]
        public decimal WorkOverWeekendRate { get; set; }
		[DataMember]
        public decimal WorkOverWeekendThreshold { get; set; }
		[DataMember]
        public decimal? MaxSickHoursPerYear { get; set; }
		[DataMember]
        public bool ShowWalkMe { get; set; }
		[DataMember]
        public bool CalculateHealthUseBothParams { get; set; }
		[DataMember]
        public bool HideUserLoginField { get; set; }
		[DataMember]
        public bool UseNewDetailsPage { get; set; }
		[DataMember]
        public bool IsUseNewDetailsPageOptionVisible { get; set; }
		[DataMember]
        public bool IsEnableApproveWorkflowOptionVisible { get; set; }
		[DataMember]
        public bool ApprovalWorkflow { get; set; }
		[DataMember]
        public bool IsSSOEnabled { get; set; }
		[DataMember]
        public int? SSORoleId { get; set; }
		[DataMember]
        public string SSODomainForEmails { get; set; }
		[DataMember]
        public int DefaultCurrencyId { get; set; }
		[DataMember]
        public bool IsBaselineEnabled { get; set; }
		[DataMember]
        public bool? EnableWebPushNotifications { get; set; }
		
		[DataMember]
        public int ProjectID { get; set; }
		
		[DataMember]
        public int? UserID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity OvertimeThreshold
    /// </summary>
	[DataContract(Namespace="")]
	public partial class OvertimeThreshold 

    { 
		public OvertimeThreshold()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.OvertimeThresholdID;} set { this.OvertimeThresholdID = value; } }
		[DataMember]
        public int OvertimeThresholdID { get; set; }
		[DataMember]
        public decimal Threshold { get; set; }
		[DataMember]
        public decimal RateMultiplier { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Payment
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Payment 

    { 
		public Payment()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.PaymentID;} set { this.PaymentID = value; } }
		[DataMember]
        public int PaymentID { get; set; }
		[DataMember]
        public DateTime PaymentDate { get; set; }
		[DataMember]
        public decimal Amount { get; set; }
		[DataMember]
        public string Description { get; set; }
		[DataMember]
        public bool? Billable { get; set; }
		[DataMember]
        public bool? Planned { get; set; }
		[DataMember]
        public bool? Billed { get; set; }
		
		[DataMember]
        public int ProjectID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Portfolio
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Portfolio 

    { 
		public Portfolio()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.PortfolioID;} set { this.PortfolioID = value; } }
		[DataMember]
        public int PortfolioID { get; set; }
		[DataMember]
        public DateTime? CreationDate { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public string Description { get; set; }
		[DataMember]
        public string Managers { get; set; }
		[DataMember]
        public string ManagersComma { get; set; }
		[DataMember]
        public string ManagersSeparateLines { get; set; }
		[DataMember]
        public string Members { get; set; }
		[DataMember]
        public int? HasProjects { get; set; }
		
		[DataMember]
        public int CreatorID { get; set; }
		
		[DataMember]
        public int PortfolioStatusID { get; set; }
		
		[DataMember]
        public int? PortfolioCategoryID { get; set; }

		#region Additional Permissions Fields		
		
		[DataMember]
        public bool CanViewPortfolioObjects  {get; set;}
		
		[DataMember]
        public bool CanEditPortfolioObjects  {get; set;}
		
		[DataMember]
        public bool IsPortfolioManager  {get; set;}
		
		[DataMember]
        public bool IsPortfolioMember  {get; set;}
		#endregion		
	
	
		#region Permissions Fields		
		[DataMember]
		public bool CanEdit  {get; set;}

		[DataMember]
		public bool CanDelete  {get; set;}
		#endregion

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity PortfolioCategory
    /// </summary>
	[DataContract(Namespace="")]
	public partial class PortfolioCategory 

    { 
		public PortfolioCategory()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.PortfolioCategoryID;} set { this.PortfolioCategoryID = value; } }
		[DataMember]
        public int PortfolioCategoryID { get; set; }
		[DataMember]
        public string Name { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity PortfolioMember
    /// </summary>
	[DataContract(Namespace="")]
	public partial class PortfolioMember 

    { 
		public PortfolioMember()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.PortfolioMemberID;} set { this.PortfolioMemberID = value; } }
		[DataMember]
        public int PortfolioMemberID { get; set; }
		[DataMember]
        public bool CanEdit { get; set; }
		[DataMember]
        public bool CanView { get; set; }
		[DataMember]
        public bool IsPortfolioManager { get; set; }
		
		[DataMember]
        public int PortfolioID { get; set; }
		
		[DataMember]
        public int UserID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity PortfolioStatus
    /// </summary>
	[DataContract(Namespace="")]
	public partial class PortfolioStatus 

    { 
		public PortfolioStatus()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.PortfolioStatusID;} set { this.PortfolioStatusID = value; } }
		[DataMember]
        public int PortfolioStatusID { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public bool TreatAsCompleted { get; set; }
		[DataMember]
        public int? InternalPortfolioStatusID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity PresetSettings
    /// </summary>
	[DataContract(Namespace="")]
	public partial class PresetSettings 

    { 
		public PresetSettings()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.PresetSettingsID;} set { this.PresetSettingsID = value; } }
		[DataMember]
        public int PresetSettingsID { get; set; }
		[DataMember]
        public bool IsVisible { get; set; }
		
		[DataMember]
        public int? UserID { get; set; }
		
		[DataMember]
        public int? PresetID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Priority
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Priority 

    { 
		public Priority()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.PriorityID;} set { this.PriorityID = value; } }
		[DataMember]
        public int PriorityID { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public int PriorityOrder { get; set; }
		[DataMember]
        public int? InternalPriorityID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Project
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Project 

    { 
		public Project()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.ProjectID;} set { this.ProjectID = value; } }
		[DataMember]
        public int ProjectID { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public string Description { get; set; }
		[DataMember]
        public int Progress { get; set; }
		[DataMember]
        public DateTime? CreationDate { get; set; }
		[DataMember]
        public DateTime? StartDate { get; set; }
		[DataMember]
        public DateTime? EndDate { get; set; }
		[DataMember]
        public DateTime? ActCompletionDate { get; set; }
		[DataMember]
        public decimal? EstimatedHours { get; set; }
		[DataMember]
        public int BillingType { get; set; }
		[DataMember]
        public decimal? BillingAmount { get; set; }
		[DataMember]
        public decimal? Budget { get; set; }
		[DataMember]
        public DateTime? LastModificationDate { get; set; }
		[DataMember]
        public bool? Billed { get; set; }
		[DataMember]
        public int? Duration { get; set; }
		[DataMember]
        public decimal? DurationHours { get; set; }
		[DataMember]
        public bool IsEndDateSelected { get; set; }
		[DataMember]
        public bool HasDescription { get; set; }
		[DataMember]
        public decimal StartDateLag { get; set; }
		[DataMember]
        public decimal EndDateLag { get; set; }
		
		[DataMember]
        public int ProjectStatusID { get; set; }
		
		[DataMember]
        public int PriorityID { get; set; }
		
		[DataMember]
        public int? CustomerID { get; set; }
		
		[DataMember]
        public int CreatorID { get; set; }
		
		[DataMember]
        public int? PortfolioID { get; set; }
		
		[DataMember]
        public int CurrencyID { get; set; }

		#region Additional Permissions Fields		
		
		[DataMember]
        public bool CanCreateTasks  {get; set;}
		
		[DataMember]
        public bool CanViewMembersAndAssignees  {get; set;}
		
		[DataMember]
        public bool CanManageProjectMembers  {get; set;}
		
		[DataMember]
        public bool CanManageAssigneesTasks  {get; set;}
		
		[DataMember]
        public bool CanEditAllTasks  {get; set;}
		
		[DataMember]
        public bool CanEditAssignedTasks  {get; set;}
		
		[DataMember]
        public bool CanDeleteAllTimeEntries  {get; set;}
		
		[DataMember]
        public bool CanDeleteAllTasks  {get; set;}
		#endregion		
	
	
		#region Permissions Fields		
		[DataMember]
		public bool CanEdit  {get; set;}

		[DataMember]
		public bool CanDelete  {get; set;}
		#endregion

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity ProjectAggregatedValues
    /// </summary>
	[DataContract(Namespace="")]
	public partial class ProjectAggregatedValues 

    { 
		public ProjectAggregatedValues()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.ProjectID;} set { this.ProjectID = value; } }
		[DataMember]
        public int ProjectAggregatedValues_Project_ProjectID { get; set; }
		[DataMember]
        public decimal? ActualHours { get; set; }
		[DataMember]
        public decimal? Budget { get; set; }
		[DataMember]
        public decimal? EstimatedHours { get; set; }
		[DataMember]
        public decimal? ChildsBudget { get; set; }
		[DataMember]
        public decimal? ChildsEstimatedHours { get; set; }
		[DataMember]
        public decimal? ChildsHoursLeft { get; set; }
		[DataMember]
        public decimal? InternalCost { get; set; }
		
		[DataMember]
        public int? ProjectID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity ProjectAutoAssign
    /// </summary>
	[DataContract(Namespace="")]
	public partial class ProjectAutoAssign 

    { 
		public ProjectAutoAssign()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.ProjectAutoAssignID;} set { this.ProjectAutoAssignID = value; } }
		[DataMember]
        public int ProjectAutoAssignID { get; set; }
		
		[DataMember]
        public int? ProjectID { get; set; }
		
		[DataMember]
        public int? TaskMemberID { get; set; }
		
		[DataMember]
        public int? IssueMemberID { get; set; }
		
		[DataMember]
        public int? RequestMemberID { get; set; }
		
		[DataMember]
        public int? ApproverMemberID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity ProjectCost
    /// </summary>
	[DataContract(Namespace="")]
	public partial class ProjectCost 

    { 
		public ProjectCost()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.ProjectID;} set { this.ProjectID = value; } }
		[DataMember]
        public int ProjectID { get; set; }
		[DataMember]
        public decimal Project_Cost { get; set; }
		[DataMember]
        public decimal Project_TimeCost { get; set; }
		[DataMember]
        public decimal Project_Expenses { get; set; }
		[DataMember]
        public decimal Project_TotalCost { get; set; }
		[DataMember]
        public bool Project_ExceedByCost { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity ProjectCurrency
    /// </summary>
	[DataContract(Namespace="")]
	public partial class ProjectCurrency 

    { 
		public ProjectCurrency()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.CurrencyID;} set { this.CurrencyID = value; } }
		[DataMember]
        public int CurrencyID { get; set; }
		[DataMember]
        public string CurrencyName { get; set; }
		[DataMember]
        public string CurrencySymbol { get; set; }
		[DataMember]
        public string CurrencyText { get; set; }
		[DataMember]
        public int SortLevel { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity ProjectFinancials
    /// </summary>
	[DataContract(Namespace="")]
	public partial class ProjectFinancials 

    { 
		public ProjectFinancials()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.ProjectID;} set { this.ProjectID = value; } }
		[DataMember]
        public decimal Project_Cost { get; set; }
		[DataMember]
        public decimal Project_InternalCost { get; set; }
		[DataMember]
        public decimal Project_ProjectProfit { get; set; }
		[DataMember]
        public int Project_ProjectProfitHealth { get; set; }
		[DataMember]
        public decimal Project_ProjectProfitability { get; set; }
		[DataMember]
        public decimal Project_ProjectCostVariance { get; set; }
		[DataMember]
        public decimal Project_BudgetedCost { get; set; }
		[DataMember]
        public decimal Project_PlannedExpenses { get; set; }
		[DataMember]
        public decimal Project_TotalPayments { get; set; }
		[DataMember]
        public decimal Project_ProjectExpectedRevenue { get; set; }
		[DataMember]
        public decimal Project_PercentageOfProjectBilled { get; set; }
		[DataMember]
        public decimal Project_WorkInProgress { get; set; }
		[DataMember]
        public decimal Project_TotalBilled { get; set; }
		[DataMember]
        public decimal Project_ProjectTimeUsage { get; set; }
		[DataMember]
        public decimal Project_BillingUtilization { get; set; }
		[DataMember]
        public decimal Project_InternalEstimatedCost { get; set; }
		[DataMember]
        public decimal Project_EstimatedBudgetProfitability { get; set; }
		[DataMember]
        public decimal Project_ActualBudgetProfitability { get; set; }
		
		[DataMember]
        public int ProjectID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity ProjectMember
    /// </summary>
	[DataContract(Namespace="")]
	public partial class ProjectMember 

    { 
		public ProjectMember()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.ProjectMemberID;} set { this.ProjectMemberID = value; } }
		[DataMember]
        public int ProjectMemberID { get; set; }
		
		[DataMember]
        public int ProjectID { get; set; }
		
		[DataMember]
        public int UserID { get; set; }
		
		[DataMember]
        public int MemberPermissionID { get; set; }
		
		[DataMember]
        public int RoleID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity ProjectStatus
    /// </summary>
	[DataContract(Namespace="")]
	public partial class ProjectStatus 

    { 
		public ProjectStatus()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.ProjectStatusID;} set { this.ProjectStatusID = value; } }
		[DataMember]
        public int ProjectStatusID { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public int? InternalProjectStatusID { get; set; }
		[DataMember]
        public bool TreatAsCompleted { get; set; }
		[DataMember]
        public DateTime? LastModificationDate { get; set; }
		[DataMember]
        public bool? IsIconEmpty { get; set; }
		[DataMember]
        public string IconHash { get; set; }
		[DataMember]
        public bool IsTemplateStatus { get; set; }
		[DataMember]
        public bool IsDraftStatus { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity PublicHoliday
    /// </summary>
	[DataContract(Namespace="")]
	public partial class PublicHoliday 

    { 
		public PublicHoliday()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.PublicHolidayID;} set { this.PublicHolidayID = value; } }
		[DataMember]
        public int PublicHolidayID { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public DateTime Date { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Role
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Role 

    { 
		public Role()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.RoleID;} set { this.RoleID = value; } }
		[DataMember]
        public int RoleID { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public string Description { get; set; }
		[DataMember]
        public decimal HourlyRate { get; set; }
		[DataMember]
        public bool CanManage { get; set; }
		[DataMember]
        public bool CanCreateGroupEvents { get; set; }
		[DataMember]
        public bool CanAccessReports { get; set; }
		[DataMember]
        public bool CanAccessReportGenerator { get; set; }
		[DataMember]
        public bool CanCreateProjects { get; set; }
		[DataMember]
        public bool CanAccessProjects { get; set; }
		[DataMember]
        public bool CanAddPortfolios { get; set; }
		[DataMember]
        public bool CanManageAllPortfolios { get; set; }
		[DataMember]
        public bool CanAccessBillingInformation { get; set; }
		[DataMember]
        public bool CanManageOwnVacations { get; set; }
		[DataMember]
        public bool CanManageOtherPeopleVacations { get; set; }
		[DataMember]
        public bool CanManageCustomers { get; set; }
		[DataMember]
        public bool CanAddForms { get; set; }
		[DataMember]
        public bool CanManageForms { get; set; }
		[DataMember]
        public bool CanInviteUsers { get; set; }
		[DataMember]
        public int? InternalRoleID { get; set; }
		[DataMember]
        public bool CanPurchase { get; set; }
		
		[DataMember]
        public int MemberPermissionID { get; set; }
		
		[DataMember]
        public int? DefaultMemberPermissionID { get; set; }
		
		[DataMember]
        public int? PresetID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Skill
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Skill 

    { 
		public Skill()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.SkillID;} set { this.SkillID = value; } }
		[DataMember]
        public int SkillID { get; set; }
		[DataMember]
        public string Name { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Task
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Task 

    { 
		public Task()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.TaskID;} set { this.TaskID = value; } }
		[DataMember]
        public int TaskID { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public string Description { get; set; }
		[DataMember]
        public int? ParentID { get; set; }
		[DataMember]
        public int Progress { get; set; }
		[DataMember]
        public DateTime? ActualCompletionDate { get; set; }
		[DataMember]
        public DateTime? CreationDate { get; set; }
		[DataMember]
        public DateTime? StartDate { get; set; }
		[DataMember]
        public DateTime? EndDate { get; set; }
		[DataMember]
        public int? Duration { get; set; }
		[DataMember]
        public decimal? DurationHours { get; set; }
		[DataMember]
        public decimal StartDateLag { get; set; }
		[DataMember]
        public decimal EndDateLag { get; set; }
		[DataMember]
        public bool? IsEndDateSelected { get; set; }
		[DataMember]
        public decimal? EstimatedHours { get; set; }
		[DataMember]
        public decimal? BaseEstimatedHours { get; set; }
		[DataMember]
        public decimal? HoursLeft { get; set; }
		[DataMember]
        public int BillingType { get; set; }
		[DataMember]
        public decimal? BillingAmount { get; set; }
		[DataMember]
        public decimal? Cost { get; set; }
		[DataMember]
        public bool IsMilestone { get; set; }
		[DataMember]
        public int? HasChild { get; set; }
		[DataMember]
        public decimal? Budget { get; set; }
		[DataMember]
        public DateTime? LastModificationDate { get; set; }
		[DataMember]
        public int WBSNumber { get; set; }
		[DataMember]
        public bool? Approved { get; set; }
		[DataMember]
        public bool? Billed { get; set; }
		[DataMember]
        public bool HasDescription { get; set; }
		[DataMember]
        public DateTime? StartDateForGantt { get; set; }
		[DataMember]
        public DateTime? EndDateForGantt { get; set; }
		[DataMember]
        public decimal? LagForGantt { get; set; }
		
		[DataMember]
        public int ProjectID { get; set; }
		
		[DataMember]
        public int? CategoryID { get; set; }
		
		[DataMember]
        public int TaskTypeID { get; set; }
		
		[DataMember]
        public int TaskStatusID { get; set; }
		
		[DataMember]
        public int PriorityID { get; set; }
		
		[DataMember]
        public int? CreatorID { get; set; }

		#region Additional Permissions Fields		
		
		[DataMember]
        public bool CanCreateTasks  {get; set;}
		
		[DataMember]
        public bool CanCreateTimeEntries  {get; set;}
		
		[DataMember]
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
		[DataMember]
        public bool CanManageAssigneesTasks  {get; set;}
		
		[DataMember]
        public bool CanViewMembersAndAssignees  {get; set;}
		
		[DataMember]
        public bool CanEditAllTasks  {get; set;}
		
		[DataMember]
        public bool CanEditAssignedTasks  {get; set;}
		
		[DataMember]
        public bool IsProjectMember  {get; set;}
		
		[DataMember]
        public bool CanManageProjectMembers  {get; set;}
		
		[DataMember]
        public bool CanAccessAllTimeEntries  {get; set;}
		#endregion		
	
	
		#region Permissions Fields		
		[DataMember]
		public bool CanEdit  {get; set;}

		[DataMember]
		public bool CanDelete  {get; set;}
		#endregion

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity TaskAggregatedValues
    /// </summary>
	[DataContract(Namespace="")]
	public partial class TaskAggregatedValues 

    { 
		public TaskAggregatedValues()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.TaskID;} set { this.TaskID = value; } }
		[DataMember]
        public int TaskAggregatedValues_Task_TaskID { get; set; }
		[DataMember]
        public decimal? ActualHours { get; set; }
		[DataMember]
        public decimal? Budget { get; set; }
		[DataMember]
        public decimal? EstimatedHours { get; set; }
		[DataMember]
        public decimal? ChildsActualHours { get; set; }
		[DataMember]
        public decimal? ChildsBudget { get; set; }
		[DataMember]
        public decimal? ChildsEstimatedHours { get; set; }
		[DataMember]
        public decimal? ChildsHoursLeft { get; set; }
		[DataMember]
        public decimal? OwnEstimatedHours { get; set; }
		[DataMember]
        public decimal? Cost { get; set; }
		[DataMember]
        public decimal? InternalCost { get; set; }
		
		[DataMember]
        public int? TaskID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity TaskAssignee
    /// </summary>
	[DataContract(Namespace="")]
	public partial class TaskAssignee 

    { 
		public TaskAssignee()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.TaskAssigneeID;} set { this.TaskAssigneeID = value; } }
		[DataMember]
        public int TaskAssigneeID { get; set; }
		[DataMember]
        public bool WorkIsDone { get; set; }
		[DataMember]
        public decimal PersonalHoursLeft { get; set; }
		[DataMember]
        public decimal PersonalEstimatedHours { get; set; }
		
		[DataMember]
        public int TaskID { get; set; }
		
		[DataMember]
        public int ProjectMemberID { get; set; }
		
		[DataMember]
        public int UserID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity TaskBillable
    /// </summary>
	[DataContract(Namespace="")]
	public partial class TaskBillable 

    { 
		public TaskBillable()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.TaskID;} set { this.TaskID = value; } }
		[DataMember]
        public int TaskID { get; set; }
		[DataMember]
        public bool? IsBillable { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity TaskCost
    /// </summary>
	[DataContract(Namespace="")]
	public partial class TaskCost 

    { 
		public TaskCost()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.TaskID;} set { this.TaskID = value; } }
		[DataMember]
        public int TaskID { get; set; }
		[DataMember]
        public decimal Task_Cost { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity TaskCriticalPath
    /// </summary>
	[DataContract(Namespace="")]
	public partial class TaskCriticalPath 

    { 
		public TaskCriticalPath()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.TaskID;} set { this.TaskID = value; } }
		[DataMember]
        public int TaskCriticalPath_Task_TaskID { get; set; }
		[DataMember]
        public int ProjectID { get; set; }
		[DataMember]
        public bool IsCriticalPath { get; set; }
		
		[DataMember]
        public int TaskID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity TaskDependency
    /// </summary>
	[DataContract(Namespace="")]
	public partial class TaskDependency 

    { 
		public TaskDependency()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.TaskDependencyID;} set { this.TaskDependencyID = value; } }
		[DataMember]
        public int TaskDependencyID { get; set; }
		[DataMember]
        public int Type { get; set; }
		[DataMember]
        public int Delay { get; set; }
		
		[DataMember]
        public int DependentTaskID { get; set; }
		
		[DataMember]
        public int MasterTaskID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity TaskHoursLeft
    /// </summary>
	[DataContract(Namespace="")]
	public partial class TaskHoursLeft 

    { 
		public TaskHoursLeft()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.TaskID;} set { this.TaskID = value; } }
		[DataMember]
        public int TaskID { get; set; }
		[DataMember]
        public decimal HoursLeft { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity TaskStatus
    /// </summary>
	[DataContract(Namespace="")]
	public partial class TaskStatus 

    { 
		public TaskStatus()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.TaskStatusID;} set { this.TaskStatusID = value; } }
		[DataMember]
        public int TaskStatusID { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public bool TreatAsCompleted { get; set; }
		[DataMember]
        public bool TreatAsHold { get; set; }
		[DataMember]
        public bool RequiresApproval { get; set; }
		[DataMember]
        public int? InternalTaskStatusID { get; set; }
		[DataMember]
        public DateTime? LastModificationDate { get; set; }
		[DataMember]
        public bool? IsIconEmpty { get; set; }
		[DataMember]
        public string IconHash { get; set; }
		
		[DataMember]
        public int TaskTypeID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity TaskType
    /// </summary>
	[DataContract(Namespace="")]
	public partial class TaskType 

    { 
		public TaskType()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.TaskTypeID;} set { this.TaskTypeID = value; } }
		[DataMember]
        public int TaskTypeID { get; set; }
		[DataMember]
        public string Name { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Team
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Team 

    { 
		public Team()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.TeamID;} set { this.TeamID = value; } }
		[DataMember]
        public int TeamID { get; set; }
		[DataMember]
        public string Name { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Threshold
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Threshold 

    { 
		public Threshold()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.ThresholdID;} set { this.ThresholdID = value; } }
		[DataMember]
        public int ThresholdID { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public decimal Value { get; set; }
		[DataMember]
        public string Color { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity TimeEntry
    /// </summary>
	[DataContract(Namespace="")]
	public partial class TimeEntry 

    { 
		public TimeEntry()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.TimeEntryID;} set { this.TimeEntryID = value; } }
		[DataMember]
        public int TimeEntryID { get; set; }
		[DataMember]
        public DateTime EntryDate { get; set; }
		[DataMember]
        public string Description { get; set; }
		[DataMember]
        public bool Billable { get; set; }
		[DataMember]
        public decimal Duration { get; set; }
		[DataMember]
        public DateTime? LastModificationDate { get; set; }
		[DataMember]
        public bool? Billed { get; set; }
		[DataMember]
        public bool? Approved { get; set; }
		[DataMember]
        public string Locked { get; set; }
		[DataMember]
        public decimal? Rate { get; set; }
		[DataMember]
        public decimal? InternalRate { get; set; }
		[DataMember]
        public decimal? Cost { get; set; }
		
		[DataMember]
        public int TaskID { get; set; }
		
		[DataMember]
        public int UserID { get; set; }

		#region Additional Permissions Fields		
		
		[DataMember]
        public bool CanApprove  {get; set;}
		#endregion		
	
	
		#region Permissions Fields		
		[DataMember]
		public bool CanEdit  {get; set;}

		[DataMember]
		public bool CanDelete  {get; set;}
		#endregion

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Timeliness
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Timeliness 

    { 
		public Timeliness()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.TimelinessID;} set { this.TimelinessID = value; } }
		[DataMember]
        public int TimelinessID { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public int? Delay { get; set; }
		[DataMember]
        public string Color { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity User
    /// </summary>
	[DataContract(Namespace="")]
	public partial class User 

    { 
		public User()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.UserID;} set { this.UserID = value; } }
		[DataMember]
        public int UserID { get; set; }
		[DataMember]
        public string Login { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public string EMail { get; set; }
		[DataMember]
        public bool Enabled { get; set; }
		[DataMember]
        public bool CanLogin { get; set; }
		[DataMember]
        public decimal HourlyRate { get; set; }
		[DataMember]
        public decimal HourlyRateInternal { get; set; }
		[DataMember]
        public bool ShowCompletedTasks { get; set; }
		[DataMember]
        public bool ShowCompletedProjects { get; set; }
		[DataMember]
        public bool ShowCompletedPortfolios { get; set; }
		[DataMember]
        public bool ShowAvatars { get; set; }
		[DataMember]
        public bool? IsAvatarEmpty { get; set; }
		[DataMember]
        public string AvatarHash { get; set; }
		[DataMember]
        public string DefaultPage { get; set; }
		[DataMember]
        public DateTime? LastActivityDate { get; set; }
		[DataMember]
        public DateTime? PasswordModifyDate { get; set; }
		[DataMember]
        public int? InvalidPasswordAttemptsCount { get; set; }
		[DataMember]
        public DateTime? LastLockoutDate { get; set; }
		[DataMember]
        public int? PresetID { get; set; }
		[DataMember]
        public int? TimeZoneOffset { get; set; }
		[DataMember]
        public DateTime CreationDate { get; set; }
		
		[DataMember]
        public int? CustomerID { get; set; }
		
		[DataMember]
        public int RoleID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity UserSkill
    /// </summary>
	[DataContract(Namespace="")]
	public partial class UserSkill 

    { 
		public UserSkill()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.UserSkillID;} set { this.UserSkillID = value; } }
		[DataMember]
        public int UserSkillID { get; set; }
		
		[DataMember]
        public int UserID { get; set; }
		
		[DataMember]
        public int SkillID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity UserTeam
    /// </summary>
	[DataContract(Namespace="")]
	public partial class UserTeam 

    { 
		public UserTeam()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.UserTeamID;} set { this.UserTeamID = value; } }
		[DataMember]
        public int UserTeamID { get; set; }
		
		[DataMember]
        public int UserID { get; set; }
		
		[DataMember]
        public int TeamID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity Vacation
    /// </summary>
	[DataContract(Namespace="")]
	public partial class Vacation 

    { 
		public Vacation()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.VacationID;} set { this.VacationID = value; } }
		[DataMember]
        public int VacationID { get; set; }
		[DataMember]
        public DateTime Date { get; set; }
		[DataMember]
        public bool IsHalfDay { get; set; }
		
		[DataMember]
        public int? VacationTypeID { get; set; }
		
		[DataMember]
        public int UserID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity VacationType
    /// </summary>
	[DataContract(Namespace="")]
	public partial class VacationType 

    { 
		public VacationType()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.VacationTypeID;} set { this.VacationTypeID = value; } }
		[DataMember]
        public int VacationTypeID { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public string Color { get; set; }
		[DataMember]
        public string ShortName { get; set; }
		[DataMember]
        public bool IsPaid { get; set; }
		[DataMember]
        public bool IncludeInOvertime { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity WorkflowEvent
    /// </summary>
	[DataContract(Namespace="")]
	public partial class WorkflowEvent 

    { 
		public WorkflowEvent()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.WorkflowEventID;} set { this.WorkflowEventID = value; } }
		[DataMember]
        public int WorkflowEventID { get; set; }
		[DataMember]
        public int WorkflowEventType { get; set; }
		[DataMember]
        public string WorkflowEventText { get; set; }
		[DataMember]
        public DateTime EventDate { get; set; }
		[DataMember]
        public DateTime? CreatedAt { get; set; }
		
		[DataMember]
        public int? TaskID { get; set; }
		
		[DataMember]
        public int? ProjectID { get; set; }
		
		[DataMember]
        public int? UserID { get; set; }
		
		[DataMember]
        public int? AssigneeUserID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
    /// <summary>
    /// Generated class for entity WorkflowEventChanges
    /// </summary>
	[DataContract(Namespace="")]
	public partial class WorkflowEventChanges 

    { 
		public WorkflowEventChanges()
		{
            this.CustomFields = new CustomFieldsCollection();
		}


        [DataMember(Name = "EntityBaseID")]
		public int Id { get { return (int)this.WorkflowEventChangesID;} set { this.WorkflowEventChangesID = value; } }
		[DataMember]
        public int WorkflowEventChangesID { get; set; }
		[DataMember]
        public string PropertyName { get; set; }
		[DataMember]
        public string OldValue { get; set; }
		[DataMember]
        public string NewValue { get; set; }
		[DataMember]
        public bool? IsCustomField { get; set; }
		[DataMember]
        public int? FieldDataType { get; set; }
		
		[DataMember]
        public int? WorkflowEventID { get; set; }

	
	

		[DataMember]
        public CustomFieldsCollection CustomFields { get; set; }

    }
    
}


