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
    /// Generated class for view APIPortfolioList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class APIPortfolioList 
    { 
        public int Portfolio_PortfolioID {get; set;}
        public string Portfolio_Name {get; set;}
        public string Portfolio_ManagersSeparateLines {get; set;}
        public string Portfolio_Description {get; set;}
        public string Portfolio_Members {get; set;}
        public int? Portfolio_HasProjects {get; set;}
        public int? HasOpenProjects {get; set;}
        public string PortfolioCategory_Name {get; set;}
        public string PortfolioStatus_Name {get; set;}
        public byte[] Icon {get; set;}

		
        public bool CanViewPortfolioObjects  {get; set;}
		
        public bool CanEditPortfolioObjects  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
		
        public bool IsPortfolioMember  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view APIProjectList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class APIProjectList 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Managers {get; set;}
        public string Customer_Name {get; set;}
        public string Priority_Name {get; set;}
        public int Project_Progress {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool? ProjectStatus_IsIconEmpty {get; set;}
        public string ProjectStatus_IconHash {get; set;}
        public string Members {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public decimal Project_Cost {get; set;}
        public string CreatorUser_Name {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public int? Project_PortfolioID {get; set;}
        public string Portfolio_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public decimal? ProjectAggregatedValues_Budget {get; set;}
        public int? ProjectEVA_Health {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanDeleteAllTimeEntries  {get; set;}
		
        public bool CanDeleteAllTasks  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view APIProjectNamesList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class APIProjectNamesList 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanDeleteAllTimeEntries  {get; set;}
		
        public bool CanDeleteAllTasks  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view APITaskFlatList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class APITaskFlatList 
    { 
        public int Task_TaskID {get; set;}
        public int Task_WBSNumber {get; set;}
        public string Task_Name {get; set;}
        public int Task_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public int? Project_CustomerID {get; set;}
        public string Customer_Name {get; set;}
        public string Task_Assignees {get; set;}
        public int? Task_IsCurrentUserAssignee {get; set;}
        public int Task_Progress {get; set;}
        public int Task_TaskTypeID {get; set;}
        public string TaskType_Name {get; set;}
        public int Task_TaskStatusID {get; set;}
        public string TaskStatus_Name {get; set;}
        public int? Task_CategoryID {get; set;}
        public string Category_Name {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public int? Task_Duration {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ChildsEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public decimal? Task_HoursLeft {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public string TaskPriority_Name {get; set;}
        public int Task_PriorityID {get; set;}
        public decimal? Task_Cost {get; set;}
        public decimal? TaskAggregatedValues_Budget {get; set;}
        public int TaskCreatorUser_UserID {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public bool? Task_IsMilestone {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public int? Task_ParentID {get; set;}
        public string ParentTaskName {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public int Project_ProjectStatusID {get; set;}
        public string ProjectStatus_Name {get; set;}
        public int? Project_PortfolioID {get; set;}
        public string Portfolio_Name {get; set;}
        public bool? Task_Approved {get; set;}
        public DateTime? Task_LastModificationDate {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanAccessAllTimeEntries  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view APITaskList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class APITaskList 
    { 
        public int Task_TaskID {get; set;}
        public bool IsCriticalPath {get; set;}
        public string Task_Name {get; set;}
        public int Task_ProjectID {get; set;}
        public string Task_Assignees {get; set;}
        public string Task_AssigneesID {get; set;}
        public int? Task_IsCurrentUserAssignee {get; set;}
        public int Task_Progress {get; set;}
        public int Task_TaskTypeID {get; set;}
        public string TaskType_Name {get; set;}
        public int Task_TaskStatusID {get; set;}
        public string TaskStatus_Name {get; set;}
        public bool? TaskStatus_IsIconEmpty {get; set;}
        public string TaskStatus_IconHash {get; set;}
        public int? Task_CategoryID {get; set;}
        public string Category_Name {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public int? Task_MasterTaskCount {get; set;}
        public int? Task_Duration {get; set;}
        public bool? Task_IsEndDateSelected {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ChildsEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public decimal? Task_HoursLeft {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public int TaskPriority_PriorityID {get; set;}
        public string TaskPriority_Name {get; set;}
        public int Task_PriorityID {get; set;}
        public decimal? Task_Cost {get; set;}
        public decimal? TaskAggregatedValues_Budget {get; set;}
        public int TaskCreatorUser_UserID {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public bool? Task_IsMilestone {get; set;}
        public DateTime? Task_LastModificationDate {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public int? Task_ParentID {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public int Project_ProjectStatusID {get; set;}
        public bool? CanCompleteParent {get; set;}
        public bool? Task_HasChild {get; set;}
        public bool? TaskExpand_IsExpanded {get; set;}
        public bool? Task_Approved {get; set;}
        public int? TaskEVA_Health {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanAccessAllTimeEntries  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view APITaskNamesList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class APITaskNamesList 
    { 
        public int Task_TaskID {get; set;}
        public int? Task_ParentID {get; set;}
        public string Task_Name {get; set;}
        public int Task_ProjectID {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public int Task_TaskTypeID {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public decimal? UserActualHours {get; set;}
        public bool? HasChildren {get; set;}
        public int Task_WBSNumber {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanAccessAllTimeEntries  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view HomePageTaskList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class HomePageTaskList 
    { 
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public string Description {get; set;}
        public int Task_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public int? Project_CustomerID {get; set;}
        public string Customer_Name {get; set;}
        public decimal? TodayHours {get; set;}
        public decimal? UserActualHours {get; set;}
        public string LatestMessage {get; set;}
        public DateTime? LatestMessagePostDate {get; set;}
        public string LatestMessageUserName {get; set;}
        public int Task_Progress {get; set;}
        public int Task_TaskTypeID {get; set;}
        public string TaskType_Name {get; set;}
        public int Task_TaskStatusID {get; set;}
        public string TaskStatus_Name {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public int TaskPriority_PriorityID {get; set;}
        public string TaskPriority_Name {get; set;}
        public int Task_PriorityID {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public bool TaskStatus_TreatAsHold {get; set;}
        public int? Task_ParentID {get; set;}
        public bool? Task_Approved {get; set;}
        public string Task_MasterTasks {get; set;}
        public int? ParentTaskHasOneMoreParent {get; set;}
        public string ParentTaskName {get; set;}
        public int? Task_AttachmentsCount {get; set;}
        public int? Task_MessagesCount {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanAccessAllTimeEntries  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectAttachment
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectAttachment 
    { 
        public int AttachmentID {get; set;}
        public string FileName {get; set;}
        public string Attachment_FileName {get; set;}
        public string RelativePath {get; set;}
        public string FileType {get; set;}
        public int FileLength {get; set;}
        public DateTime UploadDate {get; set;}
        public string Description {get; set;}
        public int Version {get; set;}
        public int AttachmentSaveModeID {get; set;}
        public int ProjectID {get; set;}
        public int? MessageID {get; set;}
        public int UserID {get; set;}
        public string UserName {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view TaskAttachment
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskAttachment 
    { 
        public int AttachmentID {get; set;}
        public string FileName {get; set;}
        public string Attachment_FileName {get; set;}
        public string RelativePath {get; set;}
        public string FileType {get; set;}
        public int FileLength {get; set;}
        public DateTime UploadDate {get; set;}
        public string Description {get; set;}
        public int Version {get; set;}
        public int AttachmentSaveModeID {get; set;}
        public int? MessageID {get; set;}
        public int TaskID {get; set;}
        public int UserID {get; set;}
        public string UserName {get; set;}

	
	
    }
    
}


