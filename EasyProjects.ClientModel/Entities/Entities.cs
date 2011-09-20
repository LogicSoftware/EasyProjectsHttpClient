
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
	public partial class CalendarEvent
    { 
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
	public partial class Category
    { 
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
	public partial class Customer
    { 
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

	
	
    }
    #endregion
    
    #region IssueType entity
    /// <summary>
    /// Generated class for entity IssueType
    /// </summary>
	[DataContract(Name = "IssueType", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.IssueType")]
	public partial class IssueType
    { 
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
	public partial class MemberPermission
    { 
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
	public partial class Message
    { 
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
		
		[XmlIgnore]
        public bool CanEditEntity  {get; set;}
		#endregion		
	
	
    }
    #endregion
    
    #region Portfolio entity
    /// <summary>
    /// Generated class for entity Portfolio
    /// </summary>
	[DataContract(Name = "Portfolio", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Portfolio")]
	public partial class Portfolio
    { 
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
		
		[XmlIgnore]
        public bool CanViewPortfolioObjects  {get; set;}
		
		[XmlIgnore]
        public bool CanEditPortfolioObjects  {get; set;}
		
		[XmlIgnore]
        public bool IsPortfolioManager  {get; set;}
		
		[XmlIgnore]
        public bool IsPortfolioMember  {get; set;}
		#endregion		
	
	
		#region Permissions Fields		
        public bool CanEdit  {get; set;}
        public bool CanDelete  {get; set;}
		#endregion
    }
    #endregion
    
    #region PortfolioCategory entity
    /// <summary>
    /// Generated class for entity PortfolioCategory
    /// </summary>
	[DataContract(Name = "PortfolioCategory", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.PortfolioCategory")]
	public partial class PortfolioCategory
    { 
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
	public partial class PortfolioMember
    { 
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
	public partial class PortfolioStatus
    { 
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

	
	
    }
    #endregion
    
    #region Priority entity
    /// <summary>
    /// Generated class for entity Priority
    /// </summary>
	[DataContract(Name = "Priority", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Priority")]
	public partial class Priority
    { 
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

	
	
    }
    #endregion
    
    #region Project entity
    /// <summary>
    /// Generated class for entity Project
    /// </summary>
	[DataContract(Name = "Project", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Project")]
	public partial class Project
    { 
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
		
		[XmlIgnore]
        public bool CanCreateTasks  {get; set;}
		
		[XmlIgnore]
        public bool CanCreateIssues  {get; set;}
		
		[XmlIgnore]
        public bool CanCreateRequests  {get; set;}
		
		[XmlIgnore]
        public bool IsProjectMember  {get; set;}
		
		[XmlIgnore]
        public bool CanManage  {get; set;}
		
		[XmlIgnore]
        public bool CanViewMembersAndAssignees  {get; set;}
		
		[XmlIgnore]
        public bool CanManageProjectMembers  {get; set;}
		
		[XmlIgnore]
        public bool CanManageAssigneesTasks  {get; set;}
		
		[XmlIgnore]
        public bool CanManageAssigneesIssues  {get; set;}
		
		[XmlIgnore]
        public bool CanManageAssigneesRequests  {get; set;}
		
		[XmlIgnore]
        public bool CanEditAllTasks  {get; set;}
		
		[XmlIgnore]
        public bool CanEditAllIssues  {get; set;}
		
		[XmlIgnore]
        public bool CanEditAllRequests  {get; set;}
		
		[XmlIgnore]
        public bool CanEditAssignedTasks  {get; set;}
		
		[XmlIgnore]
        public bool CanEditAssignedIssues  {get; set;}
		
		[XmlIgnore]
        public bool CanEditAssignedRequests  {get; set;}
		
		[XmlIgnore]
        public bool IsPortfolioManager  {get; set;}
		#endregion		
	
	
		#region Permissions Fields		
        public bool CanEdit  {get; set;}
        public bool CanDelete  {get; set;}
		#endregion
    }
    #endregion
    
    #region ProjectAttachment entity
    /// <summary>
    /// Generated class for entity ProjectAttachment
    /// </summary>
	[DataContract(Name = "ProjectAttachment", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.ProjectAttachment")]
	public partial class ProjectAttachment
    { 
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
    
    #region ProjectMember entity
    /// <summary>
    /// Generated class for entity ProjectMember
    /// </summary>
	[DataContract(Name = "ProjectMember", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.ProjectMember")]
	public partial class ProjectMember
    { 
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
	public partial class ProjectStatus
    { 
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

	
	
    }
    #endregion
    
    #region Role entity
    /// <summary>
    /// Generated class for entity Role
    /// </summary>
	[DataContract(Name = "Role", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Role")]
	public partial class Role
    { 
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

	
	
    }
    #endregion
    
    #region Task entity
    /// <summary>
    /// Generated class for entity Task
    /// </summary>
	[DataContract(Name = "Activity", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Task")]
	public partial class Task
    { 
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
		
		[XmlIgnore]
        public bool CanCreateTasks  {get; set;}
		
		[XmlIgnore]
        public bool CanCreateIssues  {get; set;}
		
		[XmlIgnore]
        public bool CanCreateRequests  {get; set;}
		
		[XmlIgnore]
        public bool IsProjectMember  {get; set;}
		
		[XmlIgnore]
        public bool CanManage  {get; set;}
		
		[XmlIgnore]
        public bool CanCreateTimeEntries  {get; set;}
		
		[XmlIgnore]
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
		[XmlIgnore]
        public bool CanManageAssigneesTasks  {get; set;}
		
		[XmlIgnore]
        public bool CanManageAssigneesIssues  {get; set;}
		
		[XmlIgnore]
        public bool CanManageAssigneesRequests  {get; set;}
		
		[XmlIgnore]
        public bool CanViewMembersAndAssignees  {get; set;}
		
		[XmlIgnore]
        public bool CanEditAllTasks  {get; set;}
		
		[XmlIgnore]
        public bool CanEditAllIssues  {get; set;}
		
		[XmlIgnore]
        public bool CanEditAllRequests  {get; set;}
		
		[XmlIgnore]
        public bool CanEditAssignedTasks  {get; set;}
		
		[XmlIgnore]
        public bool CanEditAssignedIssues  {get; set;}
		
		[XmlIgnore]
        public bool CanEditAssignedRequests  {get; set;}
		
		[XmlIgnore]
        public bool IsPortfolioManager  {get; set;}
		#endregion		
	
	
		#region Permissions Fields		
        public bool CanEdit  {get; set;}
        public bool CanDelete  {get; set;}
		#endregion
    }
    #endregion
    
    #region TaskAssignee entity
    /// <summary>
    /// Generated class for entity TaskAssignee
    /// </summary>
	[DataContract(Name = "TaskAssignee", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.TaskAssignee")]
	public partial class TaskAssignee
    { 
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
	public partial class TaskAttachment
    { 
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
    
    #region TaskStatus entity
    /// <summary>
    /// Generated class for entity TaskStatus
    /// </summary>
	[DataContract(Name = "TaskStatus", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.TaskStatus")]
	public partial class TaskStatus
    { 
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
    
    #region Threshold entity
    /// <summary>
    /// Generated class for entity Threshold
    /// </summary>
	[DataContract(Name = "Threshold", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.Threshold")]
	public partial class Threshold
    { 
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
	public partial class TimeEntry
    { 
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
	public partial class Timeliness
    { 
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
    
    #region User entity
    /// <summary>
    /// Generated class for entity User
    /// </summary>
	[DataContract(Name = "User", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.User")]
	public partial class User
    { 
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

	
	
    }
    #endregion
    
    #region VacationType entity
    /// <summary>
    /// Generated class for entity VacationType
    /// </summary>
	[DataContract(Name = "VacationType", Namespace = "easyprojects.net/rest/v1")]
	[DebuggerDisplay("Entity.VacationType")]
	public partial class VacationType
    { 
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
    


}


