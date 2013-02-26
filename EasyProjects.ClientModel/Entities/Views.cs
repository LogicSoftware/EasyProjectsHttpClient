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
    /// Generated class for view ActivityHealth
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ActivityHealth 
    { 
        public string Name {get; set;}
        public int TaskID {get; set;}
        public int? Health {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ActivityHierarchyItem
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ActivityHierarchyItem 
    { 
        public int TaskID {get; set;}
        public string Name {get; set;}
        public int TaskTypeID {get; set;}
        public int? ParentID {get; set;}
        public int ProjectID {get; set;}
        public DateTime? LastModificationDate {get; set;}
        public bool IsExpanded {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ActivityName
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ActivityName 
    { 
        public int TaskID {get; set;}
        public string Name {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ActivityView
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ActivityView 
    { 
        public int TaskID {get; set;}
        public int CreatorId {get; set;}
        public int? ParentID {get; set;}
        public int ProjectID {get; set;}
        public int? PortfolioID {get; set;}
        public DateTime? LastModificationDate {get; set;}
        public int TaskTypeID {get; set;}
        public bool IsExpanded {get; set;}
        public string Category {get; set;}
        public bool? IsCriticalPath {get; set;}
        public string Name {get; set;}
        public int Progress {get; set;}
        public decimal? HoursLeft {get; set;}
        public bool IsMilestone {get; set;}
        public string TaskType {get; set;}
        public string Status {get; set;}
        public bool TreatAsCompleted {get; set;}
        public string Priority {get; set;}
        public DateTime? StartDate {get; set;}
        public DateTime? EndDate {get; set;}
        public DateTime? ActualCompletionDate {get; set;}
        public int? Duration {get; set;}
        public bool? IsEndDateSelected {get; set;}
        public decimal? EstimatedHours {get; set;}
        public decimal? ActualHours {get; set;}
        public decimal OwnCost {get; set;}
        public decimal? Cost {get; set;}
        public decimal? OwnBudget {get; set;}
        public decimal? Budget {get; set;}
        public int? Health {get; set;}
        public int? MasterTaskCount {get; set;}
        public string MasterTasksIds {get; set;}
        public int? Timeliness {get; set;}
        public int? Attachments {get; set;}
        public int? Messages {get; set;}
        public string Assignees {get; set;}
        public string IssueType {get; set;}
        public bool? Task_Approved {get; set;}
        public int Task_TaskStatusID {get; set;}
        public int? Task_CategoryID {get; set;}
        public int Task_PriorityID {get; set;}
        public int? Task_HasChild {get; set;}
        public int? IsCurrentUserAssignee {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ActivityWBSStructure
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ActivityWBSStructure 
    { 
        public int Task_TaskID {get; set;}
        public int Task_WBSNumber {get; set;}
        public int? Task_ParentID {get; set;}
        public int Task_ProjectID {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_LastModificationDate {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view AllPortfolioReportGeneratorSource
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class AllPortfolioReportGeneratorSource 
    { 
        public int Portfolio_PortfolioID {get; set;}
        public string Portfolio_Name {get; set;}
        public string Portfolio_ManagersComma {get; set;}

		
        public bool CanViewPortfolioObjects  {get; set;}
		
        public bool CanEditPortfolioObjects  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
		
        public bool IsPortfolioMember  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view AllPortfolioReportSource
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class AllPortfolioReportSource 
    { 
        public int Portfolio_PortfolioID {get; set;}
        public string Portfolio_Name {get; set;}
        public string Portfolio_ManagersComma {get; set;}
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public string ProjectStatus_Name {get; set;}

		
        public bool CanViewPortfolioObjects  {get; set;}
		
        public bool CanEditPortfolioObjects  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
		
        public bool IsPortfolioMember  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view AllProjectNamesList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class AllProjectNamesList 
    { 
        public int ProjectID {get; set;}
        public string Name {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view AllTasksHierarchicalReportSource
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class AllTasksHierarchicalReportSource 
    { 
        public int Task_TaskID {get; set;}
        public bool? TaskCriticalPath_IsCriticalPath {get; set;}
        public int? Task_ParentID {get; set;}
        public string Task_Name {get; set;}
        public string Task_Description {get; set;}
        public string TaskType_Name {get; set;}
        public string TaskStatus_Name {get; set;}
        public string Assignees {get; set;}
        public string AssigneesH {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public decimal? TaskAggregatedValues_OwnEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public decimal? Task_HoursLeft {get; set;}
        public string Category_Name {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_Cost {get; set;}
        public bool Task_IsMilestone {get; set;}
        public decimal? ProjectAggregatedValues_Budget {get; set;}
        public decimal? TaskAggregatedValues_Budget {get; set;}
        public string TaskPriority_Name {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Description {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_EstimatedHours {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public int Project_Progress {get; set;}
        public string Priority_Name {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public decimal Project_Cost {get; set;}
        public string Customer_Name {get; set;}
        public int? IsShowActualHoursIconWarning {get; set;}
        public int? ProjectDueIn {get; set;}
        public int? DueIn {get; set;}
        public int? DelayedFor {get; set;}
        public string Highlighted {get; set;}
        public string ProjectHighlighted {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view AllTasksReportSource
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class AllTasksReportSource 
    { 
        public int Task_TaskID {get; set;}
        public bool? TaskCriticalPath_IsCriticalPath {get; set;}
        public string Task_Name {get; set;}
        public string Task_Description {get; set;}
        public string TaskType_Name {get; set;}
        public string TaskStatus_Name {get; set;}
        public string Assignees {get; set;}
        public string AssigneesH {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public decimal? TaskAggregatedValues_OwnEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public decimal? Task_HoursLeft {get; set;}
        public string Category_Name {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_Cost {get; set;}
        public bool Task_IsMilestone {get; set;}
        public string TaskPriority_Name {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Description {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_EstimatedHours {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public int Project_Progress {get; set;}
        public decimal Project_Cost {get; set;}
        public string Priority_Name {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public decimal? ProjectAggregatedValues_Budget {get; set;}
        public decimal? TaskAggregatedValues_Budget {get; set;}
        public string Customer_Name {get; set;}
        public int? IsShowActualHoursIconWarning {get; set;}
        public int? ProjectDueIn {get; set;}
        public int? DueIn {get; set;}
        public int? DelayedFor {get; set;}
        public string Highlighted {get; set;}
        public string ProjectHighlighted {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
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
        public string Project_Managers {get; set;}
        public string Customer_Name {get; set;}
        public string Priority_Name {get; set;}
        public int Project_Progress {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool? ProjectStatus_IsIconEmpty {get; set;}
        public string ProjectStatus_IconHash {get; set;}
        public string Project_Members {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public decimal Project_Cost {get; set;}
        public string CreatorUser_Name {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public int? HasMessages {get; set;}
        public int? HasAttachments {get; set;}
        public int? Project_PortfolioID {get; set;}
        public string Portfolio_Name {get; set;}
        public string Flags {get; set;}
        public string Timeliness {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public decimal? ProjectAggregatedValues_Budget {get; set;}
        public int? ProjectEVA_Health {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
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

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
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
        public bool? IsCriticalPath {get; set;}
        public string Task_Name {get; set;}
        public string Task_NameStyle {get; set;}
        public int Task_ProjectID {get; set;}
        public string Assignees {get; set;}
        public string AssigneesID {get; set;}
        public int? IsCurrentUserAssignee {get; set;}
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
        public int? MasterTaskCount {get; set;}
        public int? FirstMasterTaskID {get; set;}
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
        public int? Task_IssueTypeID {get; set;}
        public bool? Task_IsMilestone {get; set;}
        public string IssueType_Name {get; set;}
        public DateTime? Task_FixedDate {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public int? Task_ParentID {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? ParentTaskStartDate {get; set;}
        public int Project_ProjectStatusID {get; set;}
        public bool? CanCompleteParent {get; set;}
        public bool? IsParentCompleted {get; set;}
        public bool? Task_HasChild {get; set;}
        public int? HasMessages {get; set;}
        public int? HasAttachments {get; set;}
        public string Flags {get; set;}
        public int? CanDelete_TaskMaster {get; set;}
        public string Timeliness {get; set;}
        public bool? TaskExpand_IsExpanded {get; set;}
        public bool? Task_Approved {get; set;}
        public int? TaskEVA_Health {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
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

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view AssigneesList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class AssigneesList 
    { 
        public int ProjectMember_ProjectMemberID {get; set;}
        public string User_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view BillingReport
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class BillingReport 
    { 
        public DateTime? TimeEntry_EntryDate {get; set;}
        public int Task_TaskID {get; set;}
        public int Project_ProjectID {get; set;}
        public int Customer_CustomerID {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view CalendarEventsList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class CalendarEventsList 
    { 
        public int CalendarEvent_CalendarEventID {get; set;}
        public int? CalendarEvent_TaskEventID {get; set;}
        public string CalendarEvent_Name {get; set;}
        public DateTime? CalendarEvent_StartDate {get; set;}
        public DateTime? CalendarEvent_EndDate {get; set;}
        public string CalendarEvent_CalendarEventType {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view CategoryList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class CategoryList 
    { 
        public int Category_CategoryID {get; set;}
        public string Category_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view CategoryNames
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class CategoryNames 
    { 
        public int CategoryID {get; set;}
        public string Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ClientsPortalActivities
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ClientsPortalActivities 
    { 
        public int Task_TaskID {get; set;}
        public int Task_ProjectID {get; set;}
        public string Task_Name {get; set;}
        public int Task_Progress {get; set;}
        public int Task_TaskTypeID {get; set;}
        public int Task_TaskStatusID {get; set;}
        public string Status {get; set;}
        public bool? WorkIsDone {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public int? MessagesCount {get; set;}
        public int? AttachmentsCount {get; set;}
        public DateTime? LastMessagePostDate {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ClientsPortalActivityDetails
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ClientsPortalActivityDetails 
    { 
        public int Task_TaskID {get; set;}
        public int Task_ProjectID {get; set;}
        public string Task_Name {get; set;}
        public int Task_Progress {get; set;}
        public int Task_TaskTypeID {get; set;}
        public int? Task_CategoryID {get; set;}
        public int Task_TaskStatusID {get; set;}
        public int? Task_IssueTypeID {get; set;}
        public string TaskStatus_Name {get; set;}
        public bool? WorkIsDone {get; set;}
        public string Task_Description {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public int? Project_PortfolioID {get; set;}
        public int? MessagesCount {get; set;}
        public int? AttachmentsCount {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ClientsPortalProjectMember
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ClientsPortalProjectMember 
    { 
        public int ProjectMember_ProjectMemberID {get; set;}
        public int Project_ProjectID {get; set;}
        public int User_UserID {get; set;}
        public string User_Name {get; set;}
        public string User_EMail {get; set;}
        public string User_AvatarHash {get; set;}
        public int Role_RoleID {get; set;}
        public int? Role_InternalRoleID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ClientsPortalProjectsExt
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ClientsPortalProjectsExt 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Description {get; set;}
        public int Project_Progress {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public int Project_ProjectStatusID {get; set;}
        public int? Project_PortfolioID {get; set;}
        public string Status {get; set;}
        public int? MessagesCount {get; set;}
        public int? AttachmentsCount {get; set;}
        public int? ActivitiesCount {get; set;}
        public DateTime? LastMessagePostDate {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view CNRDetail
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class CNRDetail 
    { 
        public int Notification_NotificationID {get; set;}
        public string Notification_Name {get; set;}
        public bool? Notification_IsSystem {get; set;}
        public int Notification_Recipients {get; set;}
        public bool Notification_NotifyCreator {get; set;}
        public bool Notification_NotifyWhoMadeChange {get; set;}
        public bool Notification_EventTaskAdd {get; set;}
        public bool Notification_EventTaskEdit {get; set;}
        public bool Notification_EventTaskAssign {get; set;}
        public bool Notification_EventTaskComplete {get; set;}
        public bool Notification_EventTaskDelete {get; set;}
        public bool Notification_EventTaskLate {get; set;}
        public bool Notification_EventIssueAdd {get; set;}
        public bool Notification_EventIssueEdit {get; set;}
        public bool Notification_EventIssueAssign {get; set;}
        public bool Notification_EventIssueComplete {get; set;}
        public bool Notification_EventIssueDelete {get; set;}
        public bool Notification_EventIssueLate {get; set;}
        public bool Notification_EventRequestAdd {get; set;}
        public bool Notification_EventRequestEdit {get; set;}
        public bool Notification_EventRequestAssign {get; set;}
        public bool Notification_EventRequestComplete {get; set;}
        public bool Notification_EventRequestDelete {get; set;}
        public bool Notification_EventRequestLate {get; set;}
        public bool Notification_EventMessageAdd {get; set;}
        public bool Notification_EventMessageEdit {get; set;}
        public bool Notification_EventMessageDelete {get; set;}
        public bool Notification_EventAttachmentAdd {get; set;}
        public bool Notification_EventAttachmentDelete {get; set;}
        public bool Notification_EventTaskCanStart {get; set;}
        public bool Notification_EventIssueCanStart {get; set;}
        public bool Notification_EventRequestCanStart {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view CopyProjects
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class CopyProjects 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Description {get; set;}
        public int Project_Progress {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? Project_EstimatedHours {get; set;}
        public int Project_ProjectStatusID {get; set;}
        public int Project_PriorityID {get; set;}
        public int Project_BillingType {get; set;}
        public decimal? Project_BillingAmount {get; set;}
        public int? Project_CustomerID {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public int? Project_PortfolioID {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view CopyTasks
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class CopyTasks 
    { 
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public string Task_Description {get; set;}
        public int? Task_ParentID {get; set;}
        public int Task_Progress {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public int? Task_Duration {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public int Task_ProjectID {get; set;}
        public bool? Task_IsMilestone {get; set;}
        public int? Task_CategoryID {get; set;}
        public int Task_TaskTypeID {get; set;}
        public int Task_TaskStatusID {get; set;}
        public int Task_PriorityID {get; set;}
        public int? Task_IssueTypeID {get; set;}
        public DateTime? Task_FixedDate {get; set;}
        public int? Task_BillingType {get; set;}
        public decimal? Task_BillingAmount {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view CustomerDetail
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class CustomerDetail 
    { 
        public int Customer_CustomerID {get; set;}
        public string Customer_Name {get; set;}
        public string Customer_Address1 {get; set;}
        public string Customer_Address2 {get; set;}
        public string Customer_City {get; set;}
        public string Customer_State {get; set;}
        public string Customer_Country {get; set;}
        public bool Customer_Enabled {get; set;}
        public string Customer_PostalCode {get; set;}
        public string Customer_Phone1 {get; set;}
        public string Customer_Phone2 {get; set;}
        public string Customer_Fax {get; set;}
        public decimal Customer_HourlyRate {get; set;}
        public string Customer_Description {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view CustomerFilterList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class CustomerFilterList 
    { 
        public int Customer_CustomerID {get; set;}
        public string Customer_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view CustomerList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class CustomerList 
    { 
        public int Customer_CustomerID {get; set;}
        public string Customer_Name {get; set;}
        public bool Customer_Enabled {get; set;}
        public string Customer_Description {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view CustomerListDependenceProject
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class CustomerListDependenceProject 
    { 
        public int Customer_CustomerID {get; set;}
        public string Customer_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view CustomerNames
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class CustomerNames 
    { 
        public int CustomerID {get; set;}
        public string Name {get; set;}
        public bool Enabled {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view CustomerRepReport
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class CustomerRepReport 
    { 
        public int TimeEntry_TimeEntryID {get; set;}
        public DateTime TimeEntry_EntryDate {get; set;}
        public decimal TimeEntry_Duration {get; set;}
        public string TimeEntry_Description {get; set;}
        public int Task_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public int TimeEntry_TaskID {get; set;}
        public string Task_Name {get; set;}
        public int Task_TaskTypeID {get; set;}
        public string TaskType_Name {get; set;}
        public int? Task_CategoryID {get; set;}
        public string Category_Name {get; set;}
        public int TimeEntry_UserID {get; set;}
        public int User_UserID {get; set;}
        public string User_Name {get; set;}
        public int Customer_CustomerID {get; set;}
        public string Customer_Name {get; set;}

	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view CustomersImport
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class CustomersImport 
    { 
        public int Customer_CustomerID {get; set;}
        public string Customer_Name {get; set;}
        public bool? Customer_Enabled {get; set;}
        public string Customer_Description {get; set;}
        public string Customer_Address1 {get; set;}
        public string Customer_Address2 {get; set;}
        public string Customer_City {get; set;}
        public string Customer_State {get; set;}
        public string Customer_Country {get; set;}
        public string Customer_PostalCode {get; set;}
        public string Customer_Phone1 {get; set;}
        public string Customer_Phone2 {get; set;}
        public string Customer_Fax {get; set;}
        public decimal? Customer_HourlyRate {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view CustomFieldConditionList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class CustomFieldConditionList 
    { 
        public int FieldID {get; set;}
        public string FieldName {get; set;}
        public string DisplayName {get; set;}
        public bool CustomFieldCondition_IsRequired {get; set;}
        public bool IsRestricted {get; set;}
        public int FieldDataTypeID {get; set;}
        public int EntityID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view CustomFieldsList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class CustomFieldsList 
    { 
        public int CustomField_FieldID {get; set;}
        public int? CustomField_Order {get; set;}
        public string CustomField_DisplayName {get; set;}
        public string CustomFieldDataType_DisplayName {get; set;}
        public bool CustomField_IsRequired {get; set;}
        public bool CustomField_IsRestricted {get; set;}
        public int CustomField_FieldDataTypeID {get; set;}
        public int CustomField_EntityID {get; set;}
        public string CustomField_Description {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view CustomFieldValueList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class CustomFieldValueList 
    { 
        public int CustomFieldValue_FieldValueID {get; set;}
        public string CustomFieldValue_Value {get; set;}
        public string CustomField_FieldName {get; set;}
        public bool CustomField_IsRequired {get; set;}
        public int CustomField_EntityID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view DelayedTasksList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class DelayedTasksList 
    { 
        public int Task_TaskID {get; set;}
        public string Project_Name {get; set;}
        public string Customer_Name {get; set;}
        public int Project_ProjectID {get; set;}
        public int Customer_CustomerID {get; set;}
        public string Task_Name {get; set;}
        public string TaskType_Name {get; set;}
        public string Assignees {get; set;}
        public string TaskStatus_Name {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public string Category_Name {get; set;}
        public int Task_Progress {get; set;}
        public string TaskPriority_Name {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public decimal? Task_Cost {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? Project_EstimatedHours {get; set;}
        public string ProjectStatus_Name {get; set;}
        public int Project_Progress {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public decimal Project_Cost {get; set;}
        public string DelayedFor {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view DependencyDetail
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class DependencyDetail 
    { 
        public int TaskDependency_TaskDependencyID {get; set;}
        public int TaskDependency_Type {get; set;}
        public int TaskDependency_Delay {get; set;}
        public int TaskDependency_DependentTaskID {get; set;}
        public int? TaskDependency_MasterTaskID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view DispatcherReport
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class DispatcherReport 
    { 
        public DateTime? DispatcherReportEntity_DateEntry {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view DispatcherVacationsReport
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class DispatcherVacationsReport 
    { 
        public DateTime? DispatcherVacationsReportEntity_DateEntry {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view EarnedValueAnalysis
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class EarnedValueAnalysis 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public int Project_Progress {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view EPMembershipUser
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class EPMembershipUser 
    { 
        public int User_UserID {get; set;}
        public string User_Login {get; set;}
        public string User_Name {get; set;}
        public string User_Password {get; set;}
        public string User_EMail {get; set;}
        public string User_RecoverConfirmCode {get; set;}
        public bool User_Enabled {get; set;}
        public bool User_CanLogin {get; set;}
        public decimal User_HourlyRate {get; set;}
        public bool User_ShowCompletedTasks {get; set;}
        public bool User_ShowCompletedProjects {get; set;}
        public bool User_ShowCompletedPortfolios {get; set;}
        public bool User_ShowAvatars {get; set;}
        public byte[] User_Avatar {get; set;}
        public bool? User_IsAvatarEmpty {get; set;}
        public string User_AvatarHash {get; set;}
        public string User_DefaultPage {get; set;}
        public string User_OpenId {get; set;}
        public DateTime? User_LastActivityDate {get; set;}
        public DateTime? User_PasswordModifyDate {get; set;}
        public int? User_InvalidPasswordAttemptsCount {get; set;}
        public DateTime? User_LastLockoutDate {get; set;}
        public int? User_CustomerID {get; set;}
        public int User_RoleID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view EstimatedVsActual
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class EstimatedVsActual 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view EventDetail
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class EventDetail 
    { 
        public int Event_EventID {get; set;}
        public string Event_Description {get; set;}
        public string Event_Name {get; set;}
        public DateTime Event_StartDate {get; set;}
        public DateTime? Event_EndDate {get; set;}
        public int Event_CreatorID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view EventForNotification
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class EventForNotification 
    { 
        public int Event_EventID {get; set;}
        public string Event_Name {get; set;}
        public string Event_Description {get; set;}
        public DateTime Event_StartDate {get; set;}
        public DateTime? Event_EndDate {get; set;}
        public int Event_CreatorID {get; set;}
        public string CreatorUser_Name {get; set;}
        public string Assignees {get; set;}
        public string AssigneesId {get; set;}
        public string LoggedUserName {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view EventList_Calendar
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class EventList_Calendar 
    { 
        public int Event_EventID {get; set;}
        public string Event_Name {get; set;}
        public DateTime Event_StartDate {get; set;}
        public DateTime? Event_EndDate {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view EventLogList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class EventLogList 
    { 
        public int EventLog_EntryID {get; set;}
        public DateTime? EventLog_EntryDate {get; set;}
        public string EventLog_EventType {get; set;}
        public string EventLog_Category {get; set;}
        public string EventLog_Title {get; set;}
        public string EventLog_Message {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view EventMembers
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class EventMembers 
    { 
        public int EventAssignee_EventAssigneeID {get; set;}
        public string User_Name {get; set;}
        public int User_UserID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view EventUserList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class EventUserList 
    { 
        public int EventUser_EventUserID {get; set;}
        public int EventUser_UserID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view FieldRestrictions
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class FieldRestrictions 
    { 
        public int CustomFieldRestriction_FieldRestrictionID {get; set;}
        public int? CustomFieldRestriction_PortfolioID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view FieldRestrictionsForValuesCleanup
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class FieldRestrictionsForValuesCleanup 
    { 
        public int CustomFieldRestriction_FieldRestrictionID {get; set;}
        public int CustomField_FieldID {get; set;}
        public string CustomField_FieldName {get; set;}
        public int CustomField_EntityID {get; set;}
        public int? CustomFieldRestriction_PortfolioID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view FormWithItemsCount
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class FormWithItemsCount 
    { 
        public int Form_FormID {get; set;}
        public LogicSoftware.EasyProjects.Model.Enums.FormStatus Form_Status {get; set;}
        public string Form_Title {get; set;}
        public string Form_Description {get; set;}
        public DateTime? Form_DateCreated {get; set;}
        public DateTime? Form_DateEdited {get; set;}
        public int? ItemsCount {get; set;}
        public string User_Name {get; set;}
        public int User_UserID {get; set;}
        public string EditedBy_Name {get; set;}

		
        public bool CanAddRecords  {get; set;}
		
        public bool CanViewRecords  {get; set;}
		
        public bool CanManageRecords  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view FreeUserList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class FreeUserList 
    { 
        public string User_Login {get; set;}
        public int User_UserID {get; set;}
        public string User_Name {get; set;}
        public string Role_Name {get; set;}
        public string User_EMail {get; set;}
        public string UserCustomer_Name {get; set;}
        public bool User_CanLogin {get; set;}
        public bool User_Enabled {get; set;}
        public int? CanDelete_LastAdministrator {get; set;}
        public int? CanDelete_LastProjectManager {get; set;}
        public int? CanDelete_ProjectMember {get; set;}
        public int? CanDelete_PortfolioMember {get; set;}
        public int? CanDelete_HasTimeEntries {get; set;}
        public int? CanDelete_ProjectCreator {get; set;}
        public int? CanDelete_TaskCreator {get; set;}
        public int? CanDelete_EventCreator {get; set;}
        public int? CanDelete_MessageCreator {get; set;}
        public int? CanDelete_User_DeleteHasWorkflow {get; set;}
        public int? CanDelete_EventAssigner {get; set;}
        public int? IsTaskAssignee {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view GanttActivityData
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class GanttActivityData 
    { 
        public int Task_TaskID {get; set;}
        public int Task_WBSNumber {get; set;}
        public string Task_Name {get; set;}
        public int Task_ProjectID {get; set;}
        public int Task_Progress {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public int? Task_Duration {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ChildsEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public bool? Task_IsMilestone {get; set;}
        public int Task_TaskTypeID {get; set;}
        public int Task_TaskStatusID {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public int? Task_ParentID {get; set;}
        public bool? IsCriticalPath {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view GanttProjectData
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class GanttProjectData 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public int Project_Progress {get; set;}
        public int Project_ProjectStatusID {get; set;}
        public int Project_PriorityID {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public decimal? Project_EstimatedHours {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view HomePageProjectMembers
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class HomePageProjectMembers 
    { 
        public int ProjectMember_ProjectMemberID {get; set;}
        public int User_UserID {get; set;}
        public int ProjectMember_ProjectID {get; set;}
        public string User_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view HomePageTaskAssignees
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class HomePageTaskAssignees 
    { 
        public int TaskAssignee_TaskID {get; set;}
        public int TaskAssignee_TaskAssigneeID {get; set;}
        public int ProjectMember_UserID {get; set;}
        public int ProjectMember_ProjectMemberID {get; set;}
        public string User_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view HomePageTaskAttachmentList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class HomePageTaskAttachmentList 
    { 
        public int TaskAttachment_TaskAttachmentID {get; set;}
        public int TaskAttachment_TaskID {get; set;}
        public string UploadedFileName {get; set;}
        public string TaskAttachment_FileName {get; set;}
        public string TaskAttachment_FileType {get; set;}
        public int TaskAttachment_FileLength {get; set;}
        public string TaskAttachment_Description {get; set;}
        public string UploaderUser_Name {get; set;}
        public DateTime TaskAttachment_UploadDate {get; set;}
        public string OldDescription {get; set;}
        public int? TaskAttachment_AttachmentSaveModeID {get; set;}
        public int Task_ProjectID {get; set;}

	
	
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
        public string Task_NameStyle {get; set;}
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
        public int? Task_Duration {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public int TaskPriority_PriorityID {get; set;}
        public string TaskPriority_Name {get; set;}
        public int Task_PriorityID {get; set;}
        public decimal? Task_Cost {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public int? Task_IssueTypeID {get; set;}
        public bool? Task_IsMilestone {get; set;}
        public DateTime? Task_FixedDate {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public bool TaskStatus_TreatAsHold {get; set;}
        public int? Task_ParentID {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public int Project_ProjectStatusID {get; set;}
        public bool? Task_Approved {get; set;}
        public string MasterTasks {get; set;}
        public int? ParentTaskHasOneMoreParent {get; set;}
        public string ParentTaskName {get; set;}
        public int? AttachmentsCount {get; set;}
        public int? MessagesCount {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public bool HasUnfinishedMasterTasks {get; set;}
        public string UnfinishedMasterTasks {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view HoursByProjects
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class HoursByProjects 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public int Task_TaskID {get; set;}
        public int TimeEntry_TimeEntryID {get; set;}
        public DateTime TimeEntry_EntryDate {get; set;}
        public decimal TimeEntry_Duration {get; set;}

	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view HoursForToday
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class HoursForToday 
    { 
        public int Task_TaskID {get; set;}
        public decimal? TodayHours {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view HoursForWeek
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class HoursForWeek 
    { 
        public int Task_TaskID {get; set;}
        public decimal? HoursForDay0 {get; set;}
        public decimal? HoursForDay1 {get; set;}
        public decimal? HoursForDay2 {get; set;}
        public decimal? HoursForDay3 {get; set;}
        public decimal? HoursForDay4 {get; set;}
        public decimal? HoursForDay5 {get; set;}
        public decimal? HoursForDay6 {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view IALMasterTasksList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class IALMasterTasksList 
    { 
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public int? Task_ParentID {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_StartDate {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view InteractiveActivityData
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class InteractiveActivityData 
    { 
        public int Task_TaskID {get; set;}
        public bool? IsCriticalPath {get; set;}
        public int Task_WBSNumber {get; set;}
        public string Task_Name {get; set;}
        public int Task_ProjectID {get; set;}
        public string AssigneesID {get; set;}
        public int? IsCurrentUserAssignee {get; set;}
        public int Task_Progress {get; set;}
        public int Task_TaskTypeID {get; set;}
        public int TaskType_TaskTypeID {get; set;}
        public int Task_TaskStatusID {get; set;}
        public int? Task_CategoryID {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public int? Task_Duration {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ChildsEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public int Task_PriorityID {get; set;}
        public decimal? Task_Cost {get; set;}
        public decimal? TaskAggregatedValuesSingle_Budget {get; set;}
        public int TaskCreatorUser_UserID {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public int? Task_IssueTypeID {get; set;}
        public bool? Task_IsMilestone {get; set;}
        public int? SiblingsCount {get; set;}
        public DateTime? Task_FixedDate {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public string MasterTasks {get; set;}
        public int? Task_ParentID {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? ParentTaskStartDate {get; set;}
        public int Project_ProjectStatusID {get; set;}
        public bool? Task_HasChild {get; set;}
        public int? CanDelete_TaskMaster {get; set;}
        public bool? TaskExpand_IsExpanded {get; set;}
        public bool? Task_Approved {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view InteractiveListActivityAssignee
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class InteractiveListActivityAssignee 
    { 
        public int TaskAssignee_TaskAssigneeID {get; set;}
        public int TaskAssignee_TaskID {get; set;}
        public int ProjectMember_UserID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view IssuesHierarchicalReportSource
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class IssuesHierarchicalReportSource 
    { 
        public int Task_TaskID {get; set;}
        public bool? TaskCriticalPath_IsCriticalPath {get; set;}
        public int? Task_ParentID {get; set;}
        public string Task_Name {get; set;}
        public string Task_Description {get; set;}
        public string TaskStatus_Name {get; set;}
        public string Assignees {get; set;}
        public string AssigneesH {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public decimal? TaskAggregatedValues_OwnEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public decimal? Task_HoursLeft {get; set;}
        public string Category_Name {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_Cost {get; set;}
        public bool Task_IsMilestone {get; set;}
        public decimal? ProjectAggregatedValues_Budget {get; set;}
        public decimal? TaskAggregatedValues_Budget {get; set;}
        public string TaskPriority_Name {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public string IssueType_Name {get; set;}
        public DateTime? Task_FixedDate {get; set;}
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Description {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public int Project_Progress {get; set;}
        public string Priority_Name {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public decimal Project_Cost {get; set;}
        public string Customer_Name {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view IssuesReportSource
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class IssuesReportSource 
    { 
        public int Task_TaskID {get; set;}
        public bool? TaskCriticalPath_IsCriticalPath {get; set;}
        public string Task_Name {get; set;}
        public string Task_Description {get; set;}
        public string TaskStatus_Name {get; set;}
        public string Assignees {get; set;}
        public string AssigneesH {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public decimal? TaskAggregatedValues_OwnEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public decimal? Task_HoursLeft {get; set;}
        public string Category_Name {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_Cost {get; set;}
        public bool Task_IsMilestone {get; set;}
        public decimal? ProjectAggregatedValues_Budget {get; set;}
        public decimal? TaskAggregatedValues_Budget {get; set;}
        public string TaskPriority_Name {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public string IssueType_Name {get; set;}
        public DateTime? Task_FixedDate {get; set;}
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Description {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public int Project_Progress {get; set;}
        public string Priority_Name {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public decimal Project_Cost {get; set;}
        public string Customer_Name {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view IssueTypeList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class IssueTypeList 
    { 
        public int IssueType_IssueTypeID {get; set;}
        public string IssueType_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view LinkedVyewBooksList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class LinkedVyewBooksList 
    { 
        public int VyewBook_VyewBookID {get; set;}
        public string VyewBook_Name {get; set;}
        public string VyewBook_MeetingUrl {get; set;}
        public string ActionsColumn {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view MasterTaskDetailedList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class MasterTaskDetailedList 
    { 
        public int TaskDependency_TaskDependencyID {get; set;}
        public int TaskDependency_DependentTaskID {get; set;}
        public int MasterTask_TaskID {get; set;}
        public string MasterTask_Name {get; set;}
        public int TaskDependency_Delay {get; set;}
        public int TaskDependency_Type {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view MasterTasksList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class MasterTasksList 
    { 
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public int? Task_ParentID {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_StartDate {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view MasterTasksListPlain
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class MasterTasksListPlain 
    { 
        public int TaskDependency_TaskDependencyID {get; set;}
        public int Task_TaskID {get; set;}
        public int MasterTask_TaskID {get; set;}
        public string Task_Name {get; set;}
        public string MasterTask_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view MemberPermissionForNotification
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class MemberPermissionForNotification 
    { 
        public int MemberPermission_MemberPermissionID {get; set;}
        public int ProjectMember_MemberPermissionID {get; set;}
        public bool MemberPermission_CanAccessAllTasks {get; set;}
        public bool MemberPermission_CanAccessAllIssues {get; set;}
        public bool MemberPermission_CanAccessAllRequests {get; set;}
        public bool MemberPermission_CanAccessAllTimeEntries {get; set;}
        public bool MemberPermission_CanEditProject {get; set;}
        public bool MemberPermission_CanEditAllTasks {get; set;}
        public bool MemberPermission_CanEditAllIssues {get; set;}
        public bool MemberPermission_CanEditAllRequests {get; set;}
        public bool? MemberPermission_CanEditAssignedTasks {get; set;}
        public bool? MemberPermission_CanEditAssignedIssues {get; set;}
        public bool? MemberPermission_CanEditAssignedRequests {get; set;}
        public bool MemberPermission_CanEditAllTimeEntries {get; set;}
        public bool? MemberPermission_CanManageAssigneesTasks {get; set;}
        public bool? MemberPermission_CanManageAssigneesIssues {get; set;}
        public bool? MemberPermission_CanManageAssigneesRequests {get; set;}
        public bool? MemberPermission_CanViewMembersAndAssignees {get; set;}
        public bool? MemberPermission_CanManageProjectMembers {get; set;}
        public bool MemberPermission_CanCreateTasks {get; set;}
        public bool MemberPermission_CanCreateIssues {get; set;}
        public bool MemberPermission_CanCreateRequests {get; set;}
        public bool? MemberPermission_CanCreateTimeEntries {get; set;}
        public bool MemberPermission_CanCreateTimeEntriesForOther {get; set;}
        public bool MemberPermission_CanDeleteProject {get; set;}
        public bool MemberPermission_CanDeleteAllTasks {get; set;}
        public bool MemberPermission_CanDeleteAllIssues {get; set;}
        public bool MemberPermission_CanDeleteAllRequests {get; set;}
        public bool? MemberPermission_CanDeleteAssignedTasks {get; set;}
        public bool? MemberPermission_CanDeleteAssignedIssues {get; set;}
        public bool? MemberPermission_CanDeleteAssignedRequests {get; set;}
        public bool MemberPermission_CanDeleteAllTimeEntries {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view MemberPermissions
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class MemberPermissions 
    { 
        public int MemberPermission_MemberPermissionID {get; set;}
        public bool MemberPermission_CanAccessAllTasks {get; set;}
        public bool MemberPermission_CanAccessAllIssues {get; set;}
        public bool MemberPermission_CanAccessAllRequests {get; set;}
        public bool MemberPermission_CanAccessAllTimeEntries {get; set;}
        public bool MemberPermission_CanEditProject {get; set;}
        public bool MemberPermission_CanEditAllTasks {get; set;}
        public bool MemberPermission_CanEditAllIssues {get; set;}
        public bool MemberPermission_CanEditAllRequests {get; set;}
        public bool? MemberPermission_CanEditAssignedTasks {get; set;}
        public bool? MemberPermission_CanEditAssignedIssues {get; set;}
        public bool? MemberPermission_CanEditAssignedRequests {get; set;}
        public bool MemberPermission_CanEditAllTimeEntries {get; set;}
        public bool MemberPermission_CanCreateTasks {get; set;}
        public bool MemberPermission_CanCreateIssues {get; set;}
        public bool MemberPermission_CanCreateRequests {get; set;}
        public bool? MemberPermission_CanCreateTimeEntries {get; set;}
        public bool MemberPermission_CanCreateTimeEntriesForOther {get; set;}
        public bool MemberPermission_CanDeleteProject {get; set;}
        public bool MemberPermission_CanDeleteAllTasks {get; set;}
        public bool MemberPermission_CanDeleteAllIssues {get; set;}
        public bool MemberPermission_CanDeleteAllRequests {get; set;}
        public bool? MemberPermission_CanDeleteAssignedTasks {get; set;}
        public bool? MemberPermission_CanDeleteAssignedIssues {get; set;}
        public bool? MemberPermission_CanDeleteAssignedRequests {get; set;}
        public bool MemberPermission_CanDeleteAllTimeEntries {get; set;}
        public bool? MemberPermission_CanManageAssigneesTasks {get; set;}
        public bool? MemberPermission_CanManageAssigneesIssues {get; set;}
        public bool? MemberPermission_CanManageAssigneesRequests {get; set;}
        public bool? MemberPermission_CanViewMembersAndAssignees {get; set;}
        public bool? MemberPermission_CanManageProjectMembers {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view MessageboardTaskNamesList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class MessageboardTaskNamesList 
    { 
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public int? Task_ParentID {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view MessageForNotification
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class MessageForNotification 
    { 
        public int Message_MessageID {get; set;}
        public DateTime Message_PostDate {get; set;}
        public string Message_MessageText {get; set;}
        public int? Message_TaskID {get; set;}
        public string Task_Name {get; set;}
        public int Task_ProjectID {get; set;}
        public int Task_TaskTypeID {get; set;}
        public string TaskType_Name {get; set;}
        public int Message_UserID {get; set;}
        public string User_Name {get; set;}
        public string AssigneesId {get; set;}
        public string LoggedUserName {get; set;}

		
        public bool CanEditEntity  {get; set;}
	
	
    }
    
    /// <summary>
    /// Generated class for view MessageList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class MessageList 
    { 
        public int Message_MessageID {get; set;}
        public DateTime Message_PostDate {get; set;}
        public string Task_Name {get; set;}
        public string User_Name {get; set;}
        public string Message_MessageText {get; set;}
        public string Message {get; set;}

		
        public bool CanEditEntity  {get; set;}
	
	
    }
    
    /// <summary>
    /// Generated class for view MessagesReportSource
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class MessagesReportSource 
    { 
        public int Message_MessageID {get; set;}
        public DateTime Message_PostDate {get; set;}
        public string Message_MessageText {get; set;}
        public string User_Name {get; set;}
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public string Task_Description {get; set;}
        public string TaskType_Name {get; set;}
        public string TaskStatus_Name {get; set;}
        public string Assignees {get; set;}
        public string AssigneesH {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public decimal? TaskAggregatedValues_OwnEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public string Category_Name {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_Cost {get; set;}
        public decimal? ProjectAggregatedValues_Budget {get; set;}
        public decimal? TaskAggregatedValues_Budget {get; set;}
        public string TaskPriority_Name {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Description {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public int Project_Progress {get; set;}
        public string Priority_Name {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public decimal Project_Cost {get; set;}
        public string Customer_Name {get; set;}

		
        public bool CanEditEntity  {get; set;}
	
	
    }
    
    /// <summary>
    /// Generated class for view MilestoneCalendarList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class MilestoneCalendarList 
    { 
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public string Task_NameStyle {get; set;}
        public string Task_Description {get; set;}
        public int? Task_ParentID {get; set;}
        public int Task_Progress {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public int Task_ProjectID {get; set;}
        public bool Task_IsMilestone {get; set;}
        public DateTime? Task_FixedDate {get; set;}
        public string Project_Name {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public int Project_ProjectStatusID {get; set;}
        public string Assignees {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view MilestoneForOverview
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class MilestoneForOverview 
    { 
        public int Task_TaskID {get; set;}
        public int Task_ProjectID {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public string Task_Name {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view MilestonesView
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class MilestonesView 
    { 
        public DateTime? MilestoneReportEntity_MilestoneEndDate {get; set;}
        public DateTime? MilestoneReportEntity_TaskEnd {get; set;}
        public int Project_ProjectID {get; set;}
        public int Task_TaskID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view NotificationDetail
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class NotificationDetail 
    { 
        public int Notification_NotificationID {get; set;}
        public string Notification_Name {get; set;}
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public bool ProjectNotification_Enabled {get; set;}
        public bool? Notification_IsSystem {get; set;}
        public int Notification_Recipients {get; set;}
        public bool Notification_NotifyCreator {get; set;}
        public bool Notification_NotifyWhoMadeChange {get; set;}
        public bool Notification_EventTaskAdd {get; set;}
        public bool Notification_EventTaskEdit {get; set;}
        public bool Notification_EventTaskAssign {get; set;}
        public bool Notification_EventTaskComplete {get; set;}
        public bool Notification_EventTaskDelete {get; set;}
        public bool Notification_EventTaskLate {get; set;}
        public bool Notification_EventIssueAdd {get; set;}
        public bool Notification_EventIssueEdit {get; set;}
        public bool Notification_EventIssueAssign {get; set;}
        public bool Notification_EventIssueComplete {get; set;}
        public bool Notification_EventIssueDelete {get; set;}
        public bool Notification_EventIssueLate {get; set;}
        public bool Notification_EventRequestAdd {get; set;}
        public bool Notification_EventRequestEdit {get; set;}
        public bool Notification_EventRequestAssign {get; set;}
        public bool Notification_EventRequestComplete {get; set;}
        public bool Notification_EventRequestDelete {get; set;}
        public bool Notification_EventRequestLate {get; set;}
        public bool Notification_EventMessageAdd {get; set;}
        public bool Notification_EventMessageEdit {get; set;}
        public bool Notification_EventMessageDelete {get; set;}
        public bool Notification_EventAttachmentAdd {get; set;}
        public bool Notification_EventAttachmentDelete {get; set;}
        public bool Notification_EventTaskCanStart {get; set;}
        public bool Notification_EventIssueCanStart {get; set;}
        public bool Notification_EventRequestCanStart {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view NotificationTemplateList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class NotificationTemplateList 
    { 
        public int NotificationTemplate_TemplateID {get; set;}
        public string NotificationTemplate_Name {get; set;}
        public string NotificationTemplate_DisplayName {get; set;}
        public string NotificationTemplate_Transformation {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view NotificationUserList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class NotificationUserList 
    { 
        public int NotificationUser_NotificationUserID {get; set;}
        public int NotificationUser_UserID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view NotificationUserOptionsView
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class NotificationUserOptionsView 
    { 
        public int NotificationUserOptions_NotificationUserOptionID {get; set;}
        public bool NotificationUserOptions_CombineNotificationsEnabled {get; set;}
        public int NotificationUserOptions_SendInterval {get; set;}
        public bool NotificationUserOptions_DueSendEnabled {get; set;}
        public int NotificationUserOptions_DueSendInterval {get; set;}
        public bool NotificationUserOptions_ActivityListSendEnabled {get; set;}
        public int NotificationUserOptions_ActivityListSendDay {get; set;}
        public int NotificationUserOptions_ActivityListSendTime {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view NotMemberPermissions
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class NotMemberPermissions 
    { 
        public int MemberPermission_MemberPermissionID {get; set;}
        public bool? MemberPermission_CanManage {get; set;}
        public bool MemberPermission_CanAccessAllTasks {get; set;}
        public bool MemberPermission_CanAccessAllIssues {get; set;}
        public bool MemberPermission_CanAccessAllRequests {get; set;}
        public bool MemberPermission_CanAccessAllTimeEntries {get; set;}
        public bool MemberPermission_CanEditProject {get; set;}
        public bool MemberPermission_CanEditAllTasks {get; set;}
        public bool MemberPermission_CanEditAllIssues {get; set;}
        public bool MemberPermission_CanEditAllRequests {get; set;}
        public bool MemberPermission_CanEditAllTimeEntries {get; set;}
        public bool MemberPermission_CanCreateTasks {get; set;}
        public bool MemberPermission_CanCreateIssues {get; set;}
        public bool MemberPermission_CanCreateRequests {get; set;}
        public bool MemberPermission_CanCreateTimeEntriesForOther {get; set;}
        public bool MemberPermission_CanDeleteProject {get; set;}
        public bool MemberPermission_CanDeleteAllTasks {get; set;}
        public bool MemberPermission_CanDeleteAllIssues {get; set;}
        public bool MemberPermission_CanDeleteAllRequests {get; set;}
        public bool MemberPermission_CanDeleteAllTimeEntries {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view OpenIssueWidgetList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class OpenIssueWidgetList 
    { 
        public int Task_TaskID {get; set;}
        public string Project_Name {get; set;}
        public string Customer_Name {get; set;}
        public string Task_Name {get; set;}
        public int Project_ProjectID {get; set;}
        public int Customer_CustomerID {get; set;}
        public string Assignees {get; set;}
        public string TaskStatus_Name {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public string Category_Name {get; set;}
        public int Task_Progress {get; set;}
        public string TaskPriority_Name {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public decimal? Task_Cost {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? Project_EstimatedHours {get; set;}
        public string ProjectStatus_Name {get; set;}
        public int Project_Progress {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public decimal Project_Cost {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public string IssueType_Name {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view OpenRequestWidgetList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class OpenRequestWidgetList 
    { 
        public int Task_TaskID {get; set;}
        public string Project_Name {get; set;}
        public string Customer_Name {get; set;}
        public string Task_Name {get; set;}
        public int Project_ProjectID {get; set;}
        public int Customer_CustomerID {get; set;}
        public string Assignees {get; set;}
        public string TaskStatus_Name {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public string Category_Name {get; set;}
        public int Task_Progress {get; set;}
        public string TaskPriority_Name {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public decimal? Task_Cost {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? Project_EstimatedHours {get; set;}
        public string ProjectStatus_Name {get; set;}
        public int Project_Progress {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public decimal Project_Cost {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view OptionsDetails
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class OptionsDetails 
    { 
        public int Options_OptionsID {get; set;}
        public bool Options_WeekendsAsWorkdays {get; set;}
        public bool Options_EnableNotifications {get; set;}
        public bool Options_ShowStatusSymbols {get; set;}
        public bool Options_ShowGraphPercentage {get; set;}
        public string Options_MailFromName {get; set;}
        public string Options_MailFromAddress {get; set;}
        public string Options_SmtpServer {get; set;}
        public int Options_SmtpPort {get; set;}
        public string Options_SmtpUserName {get; set;}
        public string Options_SmtpPassword {get; set;}
        public bool Options_EnableIssueByMail {get; set;}
        public string Options_Pop3Server {get; set;}
        public int Options_Pop3Port {get; set;}
        public string Options_Pop3UserName {get; set;}
        public string Options_Pop3Password {get; set;}
        public bool Options_EnableSSL {get; set;}
        public bool Options_DeleteLetters {get; set;}
        public int Options_CheckupInterval {get; set;}
        public int Options_ProjectID {get; set;}
        public int Options_UserID {get; set;}
        public bool Options_NotifyCreator {get; set;}
        public bool Options_NotifyWhoMadeChange {get; set;}
        public bool Options_NotifyAssignees {get; set;}
        public bool Options_NotifyEventEdit {get; set;}
        public bool Options_NotifyEventAssign {get; set;}
        public bool Options_NotifyEventDelete {get; set;}
        public bool Options_NotifyProjectManagersVacationChanged {get; set;}
        public bool Options_EnableSmarterTrackIntegration {get; set;}
        public string Options_SmarterTrackAgentUserName {get; set;}
        public string Options_SmarterTrackAgentPassword {get; set;}
        public string Options_SmarterTrackUrl {get; set;}
        public bool Options_ShowPortfolios {get; set;}
        public bool Options_ShowLiveChat {get; set;}
        public bool Options_EnableApproveWorkflow {get; set;}
        public bool Options_CreatorAsApprover {get; set;}
        public bool Options_PMAsApprover {get; set;}
        public decimal Options_NumberOfHoursPerDay {get; set;}
        public decimal Options_SPIThreshold {get; set;}
        public decimal Options_CPIThreshold {get; set;}
        public DateTime Options_VacationYearStartDate {get; set;}
        public bool Options_TrackHoursLeft {get; set;}
        public bool Options_EnforceProhibitedWordsPolicy {get; set;}
        public bool Options_EnforcePasswordStrength {get; set;}
        public int Options_PasswordLength {get; set;}
        public int Options_PasswordNumbersCount {get; set;}
        public int Options_PasswordSpecSymbolsCount {get; set;}
        public bool Options_LockOutUserAfterInvalidPassword {get; set;}
        public int Options_InvalidPasswordAttempts {get; set;}
        public bool Options_UnblockOnRecovery {get; set;}
        public bool Options_UnblockAutomatically {get; set;}
        public int Options_UnblockAutomaticallyIn {get; set;}
        public bool Options_LockoutUserDueToInactivity {get; set;}
        public int Options_MaxUserInactivity {get; set;}
        public bool Options_EnablePasswordExpiration {get; set;}
        public int Options_PasswordExpiration {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view OptionsEnableNotifications
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class OptionsEnableNotifications 
    { 
        public int Options_OptionsID {get; set;}
        public bool Options_EnableNotifications {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view OverbudgetTasksList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class OverbudgetTasksList 
    { 
        public int Task_TaskID {get; set;}
        public string Project_Name {get; set;}
        public string Customer_Name {get; set;}
        public string Task_Name {get; set;}
        public string TaskType_Name {get; set;}
        public int Project_ProjectID {get; set;}
        public int Customer_CustomerID {get; set;}
        public string Assignees {get; set;}
        public string TaskStatus_Name {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public string Category_Name {get; set;}
        public int Task_Progress {get; set;}
        public string TaskPriority_Name {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public decimal? Task_Cost {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? Project_EstimatedHours {get; set;}
        public string ProjectStatus_Name {get; set;}
        public int Project_Progress {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public decimal Project_Cost {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ParentTaskForParametersUpdate
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ParentTaskForParametersUpdate 
    { 
        public int Task_TaskID {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public int? Task_Duration {get; set;}
        public int? SWFDependencyCount {get; set;}
        public int? SWSDependencyCount {get; set;}
        public int Task_ProjectID {get; set;}
        public int? Task_ParentID {get; set;}
        public int Task_TaskTypeID {get; set;}
        public decimal? Task_Budget {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ParentTaskList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ParentTaskList 
    { 
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public int? Task_ParentID {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view PaymentList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PaymentList 
    { 
        public int Payment_PaymentID {get; set;}
        public int Project_ProjectID {get; set;}
        public DateTime Payment_PaymentDate {get; set;}
        public string PaymentType {get; set;}
        public decimal Payment_Amount {get; set;}
        public string Payment_Description {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view PortfolioCategoryList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PortfolioCategoryList 
    { 
        public int PortfolioCategory_PortfolioCategoryID {get; set;}
        public string PortfolioCategory_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view PortfolioDetail
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PortfolioDetail 
    { 
        public int Portfolio_PortfolioID {get; set;}
        public DateTime? Portfolio_CreationDate {get; set;}
        public string Portfolio_Name {get; set;}
        public string Portfolio_Description {get; set;}
        public int Portfolio_PortfolioStatusID {get; set;}
        public int? Portfolio_PortfolioCategoryID {get; set;}
        public string CreatorUser_Name {get; set;}

		
        public bool CanViewPortfolioObjects  {get; set;}
		
        public bool CanEditPortfolioObjects  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
		
        public bool IsPortfolioMember  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view PortfolioDetailForStatusReport
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PortfolioDetailForStatusReport 
    { 
        public int Portfolio_PortfolioID {get; set;}
        public DateTime? Portfolio_CreationDate {get; set;}
        public string Portfolio_Name {get; set;}

		
        public bool CanViewPortfolioObjects  {get; set;}
		
        public bool CanEditPortfolioObjects  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
		
        public bool IsPortfolioMember  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view PortfolioFiltertList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PortfolioFiltertList 
    { 
        public int Portfolio_PortfolioID {get; set;}
        public string Portfolio_Name {get; set;}

		
        public bool CanViewPortfolioObjects  {get; set;}
		
        public bool CanEditPortfolioObjects  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
		
        public bool IsPortfolioMember  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view PortfolioList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PortfolioList 
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
        public byte[] PortfolioStatus_Icon {get; set;}
        public bool? IsIconEmpty {get; set;}

		
        public bool CanViewPortfolioObjects  {get; set;}
		
        public bool CanEditPortfolioObjects  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
		
        public bool IsPortfolioMember  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view PortfolioListForRestrictionsEditor
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PortfolioListForRestrictionsEditor 
    { 
        public int Portfolio_PortfolioID {get; set;}
        public string Portfolio_Name {get; set;}
        public string ActionsColumn {get; set;}

		
        public bool CanViewPortfolioObjects  {get; set;}
		
        public bool CanEditPortfolioObjects  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
		
        public bool IsPortfolioMember  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view PortfolioMemberList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PortfolioMemberList 
    { 
        public int PortfolioMember_PortfolioMemberID {get; set;}
        public string AvatarImage {get; set;}
        public byte[] Avatar {get; set;}
        public int? User_Name {get; set;}
        public int User_UserID {get; set;}
        public bool? PortfolioMember_CanEdit {get; set;}
        public bool? PortfolioMember_CanView {get; set;}
        public bool? PortfolioMember_IsPortfolioManager {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view PortfolioMembersLite
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PortfolioMembersLite 
    { 
        public int PortfolioMember_PortfolioMemberID {get; set;}
        public int User_UserID {get; set;}
        public bool PortfolioMember_IsPortfolioManager {get; set;}
        public bool PortfolioMember_CanView {get; set;}
        public bool PortfolioMember_CanEdit {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view PortfolioName
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PortfolioName 
    { 
        public int PortfolioID {get; set;}
        public string Name {get; set;}
        public int PortfolioStatusID {get; set;}

		
        public bool CanViewPortfolioObjects  {get; set;}
		
        public bool CanEditPortfolioObjects  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
		
        public bool IsPortfolioMember  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view PortfolioNotAssignMemberList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PortfolioNotAssignMemberList 
    { 
        public string AvatarImage {get; set;}
        public byte[] Avatar {get; set;}
        public int? User_Name {get; set;}
        public int User_UserID {get; set;}
        public bool Role_CanManageAllPortfolios {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view PortfolioStatusList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PortfolioStatusList 
    { 
        public int PortfolioStatus_PortfolioStatusID {get; set;}
        public string PortfolioStatus_Name {get; set;}
        public bool PortfolioStatus_TreatAsCompleted {get; set;}
        public int? PortfolioStatus_InternalPortfolioStatusID {get; set;}
        public byte[] PortfolioStatus_Icon {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view PreLoadActivityList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PreLoadActivityList 
    { 
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public bool? TaskExpand_IsExpanded {get; set;}
        public int? Task_ParentID {get; set;}
        public int Task_ProjectID {get; set;}
        public DateTime? Task_LastModificationDate {get; set;}
        public int Task_WBSNumber {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view PreLoadProjectList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PreLoadProjectList 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public bool? ProjectExpand_IsExpanded {get; set;}
        public DateTime? Project_LastModificationDate {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view PriorityDetails
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PriorityDetails 
    { 
        public int Priority_PriorityID {get; set;}
        public string Priority_Name {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public int? Priority_InternalPriorityID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view PriorityList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PriorityList 
    { 
        public int Priority_PriorityID {get; set;}
        public string Priority_Name {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public int? Priority_InternalPriorityID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ProgressReportSource
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProgressReportSource 
    { 
        public int WorkflowEvent_WorkflowEventID {get; set;}
        public int? WorkflowEvent_TaskID {get; set;}
        public int? Task_ParentID {get; set;}
        public string Task_Name {get; set;}
        public string Assignees {get; set;}
        public string Category_Name {get; set;}
        public string User_Name {get; set;}
        public DateTime WorkflowEvent_EventDate {get; set;}
        public string WorkflowEvent_WorkflowEvent {get; set;}
        public int WorkflowEvent_WorkflowEventType {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ProjectApprover
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectApprover 
    { 
        public int Project_ProjectID {get; set;}
        public int? ProjectAutoAssign_ApproverMemberID {get; set;}
        public int? ApproverUserID {get; set;}
        public int? IsCurrentUserApprover {get; set;}
        public int? IsCurrentUserProjectManager {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectAttachmentForNotification
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectAttachmentForNotification 
    { 
        public int ProjectAttachment_ProjectAttachmentID {get; set;}
        public string ProjectAttachment_FileName {get; set;}
        public string ProjectAttachment_FileType {get; set;}
        public int ProjectAttachment_FileLength {get; set;}
        public string ProjectAttachment_Description {get; set;}
        public DateTime ProjectAttachment_UploadDate {get; set;}
        public int ProjectAttachment_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public int ProjectAttachment_UserID {get; set;}
        public string UploaderUser_Name {get; set;}
        public string AssigneesId {get; set;}
        public string LoggedUserName {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ProjectAttachmentList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectAttachmentList 
    { 
        public int ProjectAttachment_ProjectAttachmentID {get; set;}
        public string UploadedFileName {get; set;}
        public string ProjectAttachment_FileName {get; set;}
        public string ProjectAttachment_FileType {get; set;}
        public int ProjectAttachment_FileLength {get; set;}
        public string ProjectAttachment_Description {get; set;}
        public string UploaderUser_Name {get; set;}
        public int? ProjectAttachment_ProjectID {get; set;}
        public DateTime ProjectAttachment_UploadDate {get; set;}
        public string OldDescription {get; set;}
        public int? ProjectAttachment_AttachmentSaveModeID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ProjectDetail
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectDetail 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Description {get; set;}
        public int Project_Progress {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_ChildsEstimatedHours {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public decimal? Project_EstimatedHours {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public int Project_ProjectStatusID {get; set;}
        public int Project_PriorityID {get; set;}
        public int Project_BillingType {get; set;}
        public decimal? Project_BillingAmount {get; set;}
        public int? Project_PortfolioID {get; set;}
        public string Portfolio_Name {get; set;}
        public int? Project_CustomerID {get; set;}
        public int? ProjectAutoAssign_TaskMemberID {get; set;}
        public int? ProjectAutoAssign_IssueMemberID {get; set;}
        public int? ProjectAutoAssign_RequestMemberID {get; set;}
        public int? ProjectAutoAssign_ApproverMemberID {get; set;}
        public string CreatorUser_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public int? Task_ProjectID {get; set;}
        public DateTime? Task_StartDateMax {get; set;}
        public decimal? ProjectAggregatedValues_ChildsBudget {get; set;}
        public decimal? Project_Budget {get; set;}
        public bool? IsPortfolioManager {get; set;}
        public int? IsHasOnePortfolioManager {get; set;}
        public bool? IsTaskAssigneesMPXFileValid {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectForNotification
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectForNotification 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Description {get; set;}
        public int Project_Progress {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? Project_EstimatedHours {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public decimal Project_Cost {get; set;}
        public int Project_BillingType {get; set;}
        public decimal? Project_BillingAmount {get; set;}
        public int Project_ProjectStatusID {get; set;}
        public string ProjectStatus_Name {get; set;}
        public int Project_PriorityID {get; set;}
        public string Priority_Name {get; set;}
        public int Project_CreatorID {get; set;}
        public string CreatorUser_Name {get; set;}
        public int? Project_CustomerID {get; set;}
        public string Customer_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public string LoggedUserName {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectForOverview
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectForOverview 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public int Project_Progress {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public int? ProjectEVA_Health {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectGanttCharts
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectGanttCharts 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Chart {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectHealth
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectHealth 
    { 
        public string Name {get; set;}
        public int ProjectID {get; set;}
        public int? Health {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectHealthList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectHealthList 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public int? ProjectEVA_Health {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectHierarchyItem
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectHierarchyItem 
    { 
        public int ProjectID {get; set;}
        public bool IsExpanded {get; set;}
        public string Name {get; set;}
        public DateTime? LastModificationDate {get; set;}
        public bool? IsExpandable {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectList 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Managers {get; set;}
        public string Customer_Name {get; set;}
        public string Priority_Name {get; set;}
        public int Project_Progress {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool? ProjectStatus_IsIconEmpty {get; set;}
        public string ProjectStatus_IconHash {get; set;}
        public string Project_Members {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public decimal Project_Cost {get; set;}
        public string CreatorUser_Name {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public int? HasMessages {get; set;}
        public int? HasAttachments {get; set;}
        public int? Project_PortfolioID {get; set;}
        public string Portfolio_Name {get; set;}
        public string Flags {get; set;}
        public string Timeliness {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public decimal? ProjectAggregatedValues_Budget {get; set;}
        public int? ProjectEVA_Health {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectListForInteractiveActivity
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectListForInteractiveActivity 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public int Project_Progress {get; set;}
        public int ProjectStatus_ProjectStatusID {get; set;}
        public int Project_PriorityID {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public int? Project_CustomerID {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectListForNotification
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectListForNotification 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public int ProjectNotificationUserOptions_NotificationType {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectListForTasks
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectListForTasks 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public int Project_Progress {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool? ProjectStatus_IsIconEmpty {get; set;}
        public string ProjectStatus_IconHash {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public bool? ProjectExpand_IsExpanded {get; set;}
        public int? Project_PortfolioID {get; set;}
        public string Portfolio_Name {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectListLite
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectListLite 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string ActionsColumn {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectMemberDetails
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectMemberDetails 
    { 
        public int ProjectMember_ProjectMemberID {get; set;}
        public int ProjectMember_ProjectID {get; set;}
        public int ProjectMember_UserID {get; set;}
        public int ProjectMember_RoleID {get; set;}
        public int ProjectMember_MemberPermissionID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ProjectMemberForNotification
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectMemberForNotification 
    { 
        public int ProjectMember_ProjectMemberID {get; set;}
        public int ProjectMember_ProjectID {get; set;}
        public int ProjectMember_UserID {get; set;}
        public string User_Name {get; set;}
        public bool? MemberPermission_CanManageProjectMembers {get; set;}
        public int ProjectMember_RoleID {get; set;}
        public string Role_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ProjectMemberForProjectExport
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectMemberForProjectExport 
    { 
        public int ProjectMember_ProjectMemberID {get; set;}
        public int User_UserID {get; set;}
        public string User_Name {get; set;}
        public decimal User_HourlyRate {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ProjectMemberForTimeEntryProject
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectMemberForTimeEntryProject 
    { 
        public int ProjectMember_ProjectMemberID {get; set;}
        public bool MemberPermission_CanCreateTimeEntriesForOther {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ProjectMembersView
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectMembersView 
    { 
        public int ProjectMember_ProjectMemberID {get; set;}
        public int User_UserID {get; set;}
        public int ProjectMember_MemberPermissionID {get; set;}
        public string User_Name {get; set;}
        public string Role_Name {get; set;}
        public byte[] User_Avatar {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ProjectMembersList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectMembersList 
    { 
        public int Project_ProjectID {get; set;}
        public string Assignees {get; set;}
        public string AssigneesId {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectMembersLite
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectMembersLite 
    { 
        public int ProjectMember_ProjectMemberID {get; set;}
        public int ProjectMember_UserID {get; set;}
        public int ProjectMember_RoleID {get; set;}
        public string Role_Name {get; set;}
        public bool User_Enabled {get; set;}
        public int Project_ProjectID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ProjectNamesList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectNamesList 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectNamesListCustomerDependence
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectNamesListCustomerDependence 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public int? Project_CustomerID {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectNotificationExcludedUsers
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectNotificationExcludedUsers 
    { 
        public int ProjectNotificationUser_ProjectNotificationUserID {get; set;}
        public int ProjectNotificationUser_UserID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ProjectNotificationList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectNotificationList 
    { 
        public int ProjectNotification_ProjectNotificationID {get; set;}
        public int ProjectNotification_NotificationID {get; set;}
        public string Notification_Name {get; set;}
        public bool ProjectNotification_Enabled {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ProjectNotificationUserOptionsDetail
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectNotificationUserOptionsDetail 
    { 
        public int ProjectNotificationUserOptions_ProjectNotificationsUserOptionsID {get; set;}
        public int ProjectNotificationUserOptions_NotificationType {get; set;}
        public string Project_Name {get; set;}
        public bool? ProjectNotificationUserOptions_EventTaskAdd {get; set;}
        public bool? ProjectNotificationUserOptions_EventTaskEdit {get; set;}
        public bool? ProjectNotificationUserOptions_EventTaskAssign {get; set;}
        public bool? ProjectNotificationUserOptions_EventTaskCanStart {get; set;}
        public bool? ProjectNotificationUserOptions_EventTaskComplete {get; set;}
        public bool? ProjectNotificationUserOptions_EventTaskDelete {get; set;}
        public bool? ProjectNotificationUserOptions_EventTaskLate {get; set;}
        public bool? ProjectNotificationUserOptions_EventIssueAdd {get; set;}
        public bool? ProjectNotificationUserOptions_EventIssueEdit {get; set;}
        public bool? ProjectNotificationUserOptions_EventIssueAssign {get; set;}
        public bool? ProjectNotificationUserOptions_EventIssueCanStart {get; set;}
        public bool? ProjectNotificationUserOptions_EventIssueComplete {get; set;}
        public bool? ProjectNotificationUserOptions_EventIssueDelete {get; set;}
        public bool? ProjectNotificationUserOptions_EventIssueLate {get; set;}
        public bool? ProjectNotificationUserOptions_EventRequestAdd {get; set;}
        public bool? ProjectNotificationUserOptions_EventRequestEdit {get; set;}
        public bool? ProjectNotificationUserOptions_EventRequestAssign {get; set;}
        public bool? ProjectNotificationUserOptions_EventRequestCanStart {get; set;}
        public bool? ProjectNotificationUserOptions_EventRequestComplete {get; set;}
        public bool? ProjectNotificationUserOptions_EventRequestDelete {get; set;}
        public bool? ProjectNotificationUserOptions_EventRequestLate {get; set;}
        public bool? ProjectNotificationUserOptions_EventMessageAdd {get; set;}
        public bool? ProjectNotificationUserOptions_EventMessageEdit {get; set;}
        public bool? ProjectNotificationUserOptions_EventMessageDelete {get; set;}
        public bool? ProjectNotificationUserOptions_EventAttachmentAdd {get; set;}
        public bool? ProjectNotificationUserOptions_EventAttachmentDelete {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ProjectsImport
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectsImport 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public int Project_Progress {get; set;}
        public string Project_Description {get; set;}
        public string ProjectStatus_Name {get; set;}
        public string Priority_Name {get; set;}
        public string Portfolio_Name {get; set;}
        public string Customer_Name {get; set;}
        public decimal? Project_EstimatedHours {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectsReportSource
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectsReportSource 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Description {get; set;}
        public string Managers {get; set;}
        public string Project_ManagersH {get; set;}
        public string Members {get; set;}
        public string Project_MembersH {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public string Priority_Name {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public int Project_Progress {get; set;}
        public decimal Project_Cost {get; set;}
        public decimal Project_TimeCost {get; set;}
        public decimal Project_Expenses {get; set;}
        public decimal Project_TotalCost {get; set;}
        public string Customer_Name {get; set;}
        public string CreatorUser_Name {get; set;}
        public decimal? ProjectAggregatedValues_Budget {get; set;}
        public int? ProjectDueIn {get; set;}
        public int Portfolio_PortfolioID {get; set;}
        public string Portfolio_Name {get; set;}
        public string Portfolio_Description {get; set;}
        public string PortfolioStatus {get; set;}
        public string PortfolioCategory_Name {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectsReportSourceByPeriod
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectsReportSourceByPeriod 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Description {get; set;}
        public string Managers {get; set;}
        public string Project_ManagersH {get; set;}
        public string Members {get; set;}
        public string Project_MembersH {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public string Priority_Name {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public int Project_Progress {get; set;}
        public decimal Project_Cost {get; set;}
        public decimal Project_TimeCost {get; set;}
        public decimal Project_Expenses {get; set;}
        public decimal Project_TotalCost {get; set;}
        public DateTime Project_CostDate {get; set;}
        public string Customer_Name {get; set;}
        public string CreatorUser_Name {get; set;}
        public decimal? ProjectAggregatedValues_Budget {get; set;}
        public int? ProjectDueIn {get; set;}
        public int Portfolio_PortfolioID {get; set;}
        public string Portfolio_Name {get; set;}
        public string Portfolio_Description {get; set;}
        public string PortfolioStatus {get; set;}
        public string PortfolioCategory_Name {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectStatusList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectStatusList 
    { 
        public int ProjectStatus_ProjectStatusID {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public int? ProjectStatus_InternalProjectStatusID {get; set;}
        public byte[] ProjectStatus_Icon {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ProjectTasks
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectTasks 
    { 
        public int Task_TaskID {get; set;}
        public int Task_ProjectID {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ProjectView
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ProjectView 
    { 
        public int ProjectID {get; set;}
        public bool IsExpanded {get; set;}
        public DateTime? LastModificationDate {get; set;}
        public string Name {get; set;}
        public string Customer {get; set;}
        public string Portfolio {get; set;}
        public string Priority {get; set;}
        public int Progress {get; set;}
        public DateTime? StartDate {get; set;}
        public DateTime? EndDate {get; set;}
        public DateTime? ActualCompletionDate {get; set;}
        public decimal? EstimatedHours {get; set;}
        public string Status {get; set;}
        public bool TreatAsCompleted {get; set;}
        public decimal? ActualHours {get; set;}
        public decimal Cost {get; set;}
        public int? Attachments {get; set;}
        public bool? IsExpandable {get; set;}
        public int? Messages {get; set;}
        public int? Timeliness {get; set;}
        public decimal? Budget {get; set;}
        public decimal? OwnBudget {get; set;}
        public int? Health {get; set;}
        public string ProjectMembers {get; set;}
        public string ProjectManagers {get; set;}
        public int? PortfolioID {get; set;}
        public int? CustomerID {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view PublicHolidays
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class PublicHolidays 
    { 
        public int PublicHoliday_PublicHolidayID {get; set;}
        public string PublicHoliday_Name {get; set;}
        public DateTime PublicHoliday_Date {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view RecentMessagesList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class RecentMessagesList 
    { 
        public int Message_MessageID {get; set;}
        public string Project_Name {get; set;}
        public string Task_Name {get; set;}
        public string PostedTo {get; set;}
        public string Message_MessageText {get; set;}
        public int Project_ProjectID {get; set;}
        public int Customer_CustomerID {get; set;}
        public string User_Name {get; set;}
        public string PostedBy {get; set;}
        public DateTime Message_PostDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public string Category_Name {get; set;}
        public string TaskPriority_Name {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public string ProjectStatus_Name {get; set;}

		
        public bool CanEditEntity  {get; set;}
	
	
    }
    
    /// <summary>
    /// Generated class for view ReportDetails
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ReportDetails 
    { 
        public int Report_ReportID {get; set;}
        public string Report_Name {get; set;}
        public string Report_FontName {get; set;}
        public string Report_FontSize {get; set;}
        public bool Report_IsFontBold {get; set;}
        public bool Report_IsFontItalic {get; set;}
        public bool Report_IsFontUnderline {get; set;}
        public string Report_ColumnsInformation {get; set;}
        public string ReportDataSource_ViewName {get; set;}
        public string ReportDataSource_DisplayName {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ReportsList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ReportsList 
    { 
        public int Report_ReportID {get; set;}
        public string Report_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view RequestsHierarchicalReportSource
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class RequestsHierarchicalReportSource 
    { 
        public int Task_TaskID {get; set;}
        public bool? TaskCriticalPath_IsCriticalPath {get; set;}
        public int? Task_ParentID {get; set;}
        public string Task_Name {get; set;}
        public string Task_Description {get; set;}
        public string TaskStatus_Name {get; set;}
        public string Assignees {get; set;}
        public string AssigneesH {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public decimal? TaskAggregatedValues_OwnEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public decimal? Task_HoursLeft {get; set;}
        public string Category_Name {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_Cost {get; set;}
        public bool Task_IsMilestone {get; set;}
        public decimal? ProjectAggregatedValues_Budget {get; set;}
        public decimal? TaskAggregatedValues_Budget {get; set;}
        public string TaskPriority_Name {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Description {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public int Project_Progress {get; set;}
        public string Priority_Name {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public decimal Project_Cost {get; set;}
        public string Customer_Name {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view RequestsReportSource
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class RequestsReportSource 
    { 
        public int Task_TaskID {get; set;}
        public bool? TaskCriticalPath_IsCriticalPath {get; set;}
        public string Task_Name {get; set;}
        public string Task_Description {get; set;}
        public string TaskStatus_Name {get; set;}
        public string Assignees {get; set;}
        public string AssigneesH {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public decimal? TaskAggregatedValues_OwnEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public decimal? Task_HoursLeft {get; set;}
        public string Category_Name {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_Cost {get; set;}
        public bool Task_IsMilestone {get; set;}
        public decimal? ProjectAggregatedValues_Budget {get; set;}
        public decimal? TaskAggregatedValues_Budget {get; set;}
        public string TaskPriority_Name {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Description {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public int Project_Progress {get; set;}
        public string Priority_Name {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public decimal Project_Cost {get; set;}
        public string Customer_Name {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ResourceLoadingPerPerson
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ResourceLoadingPerPerson 
    { 
        public int ResourceLoadingPerPersonEntity_UserID {get; set;}
        public string ResourceLoadingPerPersonEntity_UserName {get; set;}
        public string ResourceLoadingPerPersonEntity_Sum {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view ResourceLoadingReportData
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ResourceLoadingReportData 
    { 
        public int UserID {get; set;}
        public string UserName {get; set;}
        public int TaskID {get; set;}
        public string TaskName {get; set;}
        public int ProjectID {get; set;}
        public string ProjectName {get; set;}
        public decimal ActualHours {get; set;}
        public decimal PlannedHours {get; set;}
        public DateTime DateEntry {get; set;}
        public bool EndDay {get; set;}
        public bool Unknown {get; set;}
        public bool Plus {get; set;}
        public bool Blank {get; set;}
        public bool Achtung {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view RoleDetail
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class RoleDetail 
    { 
        public int Role_RoleID {get; set;}
        public string Role_Name {get; set;}
        public string Role_Description {get; set;}
        public decimal Role_HourlyRate {get; set;}
        public bool Role_CanManage {get; set;}
        public bool Role_CanCreateGroupEvents {get; set;}
        public bool Role_CanAccessReports {get; set;}
        public bool Role_CanAccessReportGenerator {get; set;}
        public bool Role_CanCreateProjects {get; set;}
        public bool Role_CanAccessProjects {get; set;}
        public bool Role_CanAddPortfolios {get; set;}
        public bool Role_CanManageAllPortfolios {get; set;}
        public bool Role_CanAccessBillingInformation {get; set;}
        public bool Role_CanManageOwnVacations {get; set;}
        public bool Role_CanManageOtherPeopleVacations {get; set;}
        public bool Role_CanManageCustomers {get; set;}
        public bool Role_CanAddForms {get; set;}
        public bool Role_CanManageForms {get; set;}
        public int? Role_InternalRoleID {get; set;}
        public int Role_MemberPermissionID {get; set;}
        public int? Role_DefaultMemberPermissionID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view RoleList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class RoleList 
    { 
        public int Role_RoleID {get; set;}
        public string Role_Name {get; set;}
        public string Role_Description {get; set;}
        public int? Role_InternalRoleID {get; set;}
        public int Role_MemberPermissionID {get; set;}
        public int? Role_DefaultMemberPermissionID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view RoleWithItsPermissions
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class RoleWithItsPermissions 
    { 
        public string Role_Name {get; set;}
        public int Role_RoleID {get; set;}
        public int? Role_InternalRoleID {get; set;}
        public int Role_MemberPermissionID {get; set;}
        public bool Role_CanManage {get; set;}
        public bool Role_CanCreateGroupEvents {get; set;}
        public bool Role_CanAccessReports {get; set;}
        public bool Role_CanAccessReportGenerator {get; set;}
        public bool Role_CanAccessProjects {get; set;}
        public bool Role_CanCreateProjects {get; set;}
        public bool Role_CanAddPortfolios {get; set;}
        public bool Role_CanAddForms {get; set;}
        public bool Role_CanManageAllPortfolios {get; set;}
        public bool Role_CanAccessBillingInformation {get; set;}
        public bool Role_CanManageOwnVacations {get; set;}
        public bool Role_CanManageOtherPeopleVacations {get; set;}
        public bool Role_CanManageCustomers {get; set;}
        public bool Role_CanManageForms {get; set;}
        public bool DefaultPermissionsForRole_CanAccessAllTasks {get; set;}
        public bool DefaultPermissionsForRole_CanAccessAllIssues {get; set;}
        public bool DefaultPermissionsForRole_CanAccessAllRequests {get; set;}
        public bool DefaultPermissionsForRole_CanAccessAllTimeEntries {get; set;}
        public bool DefaultPermissionsForRole_CanEditProject {get; set;}
        public bool DefaultPermissionsForRole_CanEditAllTasks {get; set;}
        public bool DefaultPermissionsForRole_CanEditAllIssues {get; set;}
        public bool DefaultPermissionsForRole_CanEditAllRequests {get; set;}
        public bool? DefaultPermissionsForRole_CanEditAssignedTasks {get; set;}
        public bool? DefaultPermissionsForRole_CanEditAssignedIssues {get; set;}
        public bool? DefaultPermissionsForRole_CanEditAssignedRequests {get; set;}
        public bool DefaultPermissionsForRole_CanEditAllTimeEntries {get; set;}
        public bool DefaultPermissionsForRole_CanCreateTasks {get; set;}
        public bool DefaultPermissionsForRole_CanCreateIssues {get; set;}
        public bool DefaultPermissionsForRole_CanCreateRequests {get; set;}
        public bool? DefaultPermissionsForRole_CanCreateTimeEntries {get; set;}
        public bool DefaultPermissionsForRole_CanCreateTimeEntriesForOther {get; set;}
        public bool DefaultPermissionsForRole_CanDeleteProject {get; set;}
        public bool DefaultPermissionsForRole_CanDeleteAllTasks {get; set;}
        public bool DefaultPermissionsForRole_CanDeleteAllIssues {get; set;}
        public bool DefaultPermissionsForRole_CanDeleteAllRequests {get; set;}
        public bool? DefaultPermissionsForRole_CanDeleteAssignedTasks {get; set;}
        public bool? DefaultPermissionsForRole_CanDeleteAssignedIssues {get; set;}
        public bool? DefaultPermissionsForRole_CanDeleteAssignedRequests {get; set;}
        public bool DefaultPermissionsForRole_CanDeleteAllTimeEntries {get; set;}
        public bool? DefaultPermissionsForRole_CanManageAssigneesTasks {get; set;}
        public bool? DefaultPermissionsForRole_CanManageAssigneesIssues {get; set;}
        public bool? DefaultPermissionsForRole_CanManageAssigneesRequests {get; set;}
        public bool? DefaultPermissionsForRole_CanViewMembersAndAssignees {get; set;}
        public bool? DefaultPermissionsForRole_CanManageProjectMembers {get; set;}
        public bool MemberPermission_CanAccessAllTasks {get; set;}
        public bool MemberPermission_CanAccessAllIssues {get; set;}
        public bool MemberPermission_CanAccessAllRequests {get; set;}
        public bool MemberPermission_CanAccessAllTimeEntries {get; set;}
        public bool MemberPermission_CanEditProject {get; set;}
        public bool MemberPermission_CanEditAllTasks {get; set;}
        public bool MemberPermission_CanEditAllIssues {get; set;}
        public bool MemberPermission_CanEditAllRequests {get; set;}
        public bool MemberPermission_CanEditAllTimeEntries {get; set;}
        public bool MemberPermission_CanCreateTasks {get; set;}
        public bool MemberPermission_CanCreateIssues {get; set;}
        public bool MemberPermission_CanCreateRequests {get; set;}
        public bool MemberPermission_CanCreateTimeEntriesForOther {get; set;}
        public bool MemberPermission_CanDeleteProject {get; set;}
        public bool MemberPermission_CanDeleteAllTasks {get; set;}
        public bool MemberPermission_CanDeleteAllIssues {get; set;}
        public bool MemberPermission_CanDeleteAllRequests {get; set;}
        public bool MemberPermission_CanDeleteAllTimeEntries {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view SecurityLogList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class SecurityLogList 
    { 
        public int SecurityLog_EntryID {get; set;}
        public DateTime? SecurityLog_EntryDate {get; set;}
        public string SecurityLog_MessageType {get; set;}
        public string User_Name {get; set;}
        public string SecurityLog_ActorUserName {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view StatusReportDetails
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class StatusReportDetails 
    { 
        public int StatusReport_StatusReportID {get; set;}
        public DateTime StatusReport_CreationDate {get; set;}
        public string User_Name {get; set;}
        public DateTime StatusReport_LastModificationDate {get; set;}
        public DateTime? StatusReport_ProjectEndDate {get; set;}
        public string CreatorUser_Name {get; set;}
        public string Project_Name {get; set;}
        public string StatusReport_ScopeDescription {get; set;}
        public string StatusReport_ScheduleDescription {get; set;}
        public string StatusReport_CostDescription {get; set;}
        public string StatusReport_ResourcesDescription {get; set;}
        public int StatusReport_ScopeValue {get; set;}
        public int StatusReport_ScheduleValue {get; set;}
        public int StatusReport_CostValue {get; set;}
        public int StatusReport_ResourcesValue {get; set;}
        public string StatusReport_Progress {get; set;}
        public string StatusReport_Plans {get; set;}
        public string StatusReport_Problems {get; set;}
        public string Portfolio_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view StatusReportsList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class StatusReportsList 
    { 
        public int StatusReport_StatusReportID {get; set;}
        public DateTime StatusReport_CreationDate {get; set;}
        public string User_Name {get; set;}
        public DateTime StatusReport_LastModificationDate {get; set;}
        public string CreatorUser_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view TaskAssigneeForBatchOperation
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskAssigneeForBatchOperation 
    { 
        public int TaskAssignee_TaskAssigneeID {get; set;}
        public int TaskAssignee_TaskID {get; set;}
        public int ProjectMember_UserID {get; set;}
        public int ProjectMember_ProjectMemberID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view TaskAssigneeForNotification
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskAssigneeForNotification 
    { 
        public int TaskAssignee_TaskAssigneeID {get; set;}
        public int TaskAssignee_TaskID {get; set;}
        public string Task_Name {get; set;}
        public int User_UserID {get; set;}
        public int AssigneeUser_UserID {get; set;}
        public string User_Name {get; set;}
        public int Task_TaskTypeID {get; set;}
        public string LoggedUserName {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view TaskAssignees
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskAssignees 
    { 
        public int TaskAssignee_TaskID {get; set;}
        public int TaskAssignee_TaskAssigneeID {get; set;}
        public bool? TaskAssignee_WorkIsDone {get; set;}
        public int ProjectMember_UserID {get; set;}
        public int ProjectMember_ProjectMemberID {get; set;}
        public int ProjectMember_RoleID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view TaskAttachmentForNotification
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskAttachmentForNotification 
    { 
        public int TaskAttachment_TaskAttachmentID {get; set;}
        public string TaskAttachment_FileName {get; set;}
        public string TaskAttachment_FileType {get; set;}
        public int TaskAttachment_FileLength {get; set;}
        public string TaskAttachment_Description {get; set;}
        public DateTime TaskAttachment_UploadDate {get; set;}
        public int TaskAttachment_TaskID {get; set;}
        public string Task_Name {get; set;}
        public int Task_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public int Task_TaskTypeID {get; set;}
        public string TaskType_Name {get; set;}
        public int TaskAttachment_UserID {get; set;}
        public string UploaderUser_Name {get; set;}
        public string AssigneesId {get; set;}
        public string LoggedUserName {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view TaskAttachmentList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskAttachmentList 
    { 
        public int TaskAttachment_TaskAttachmentID {get; set;}
        public string UploadedFileName {get; set;}
        public string TaskAttachment_FileName {get; set;}
        public string TaskAttachment_FileType {get; set;}
        public int TaskAttachment_FileLength {get; set;}
        public string TaskAttachment_Description {get; set;}
        public string UploaderUser_Name {get; set;}
        public DateTime TaskAttachment_UploadDate {get; set;}
        public string OldDescription {get; set;}
        public int? TaskAttachment_AttachmentSaveModeID {get; set;}
        public int? Task_ProjectID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view TaskDependencyForNotification
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskDependencyForNotification 
    { 
        public int TaskDependency_TaskDependencyID {get; set;}
        public int TaskDependency_Type {get; set;}
        public int TaskDependency_Delay {get; set;}
        public int TaskDependency_DependentTaskID {get; set;}
        public string Task_Name {get; set;}
        public int? TaskDependency_MasterTaskID {get; set;}
        public string MasterTask_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view TaskDetail
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskDetail 
    { 
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public string Task_NameStyle {get; set;}
        public int TaskType_TaskTypeID {get; set;}
        public string Task_Description {get; set;}
        public int? Task_ParentID {get; set;}
        public int Task_Progress {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public int? Task_Duration {get; set;}
        public bool? Task_IsEndDateSelected {get; set;}
        public decimal? TaskAggregatedValues_ChildsEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_EstimatedHours {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? Task_BaseEstimatedHours {get; set;}
        public decimal? Task_HoursLeft {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public int Task_ProjectID {get; set;}
        public bool Task_IsMilestone {get; set;}
        public bool? Task_Approved {get; set;}
        public int? Task_CategoryID {get; set;}
        public int Task_TaskTypeID {get; set;}
        public int Task_TaskStatusID {get; set;}
        public int Task_PriorityID {get; set;}
        public int? Task_IssueTypeID {get; set;}
        public DateTime? Task_FixedDate {get; set;}
        public int? Task_BillingType {get; set;}
        public decimal? TaskFixedCost {get; set;}
        public decimal? TaskHourlyRate {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public string MasterTasks {get; set;}
        public int? Task_HasChild {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? ParentTaskStartDate {get; set;}
        public bool? CanCompleteParent {get; set;}
        public bool? IsParentCompleted {get; set;}
        public int? CanDelete_TaskMaster {get; set;}
        public int Project_ProjectStatusID {get; set;}
        public string Assignees {get; set;}
        public int? IsCurrentUserAssignee {get; set;}
        public int? IsWorkDone {get; set;}
        public decimal? TaskAggregatedValues_ChildsBudget {get; set;}
        public decimal? Task_Budget {get; set;}
        public int? Project_PortfolioID {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TaskDetailForParametersUpdate
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskDetailForParametersUpdate 
    { 
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public int? Task_ParentID {get; set;}
        public int Task_Progress {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public int? Task_Duration {get; set;}
        public decimal? TaskAggregatedValues_ChildsEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_EstimatedHours {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? Task_BaseEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ChildsActualHours {get; set;}
        public int Task_ProjectID {get; set;}
        public bool Task_IsMilestone {get; set;}
        public int Task_TaskTypeID {get; set;}
        public int Task_TaskStatusID {get; set;}
        public int? Task_IssueTypeID {get; set;}
        public DateTime? Task_FixedDate {get; set;}
        public int? Task_HasChild {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TaskForNotification
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskForNotification 
    { 
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public string Task_Description {get; set;}
        public int? Task_ParentID {get; set;}
        public string ParentTaskName {get; set;}
        public int Task_Progress {get; set;}
        public bool? Task_Approved {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public int? Task_Duration {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public DateTime? Task_FixedDate {get; set;}
        public int? Task_BillingType {get; set;}
        public decimal? Task_BillingAmount {get; set;}
        public int Task_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public int? Task_CategoryID {get; set;}
        public string Category_Name {get; set;}
        public int Task_TaskTypeID {get; set;}
        public string TaskType_Name {get; set;}
        public int Task_TaskStatusID {get; set;}
        public string TaskStatus_Name {get; set;}
        public int Task_PriorityID {get; set;}
        public string TaskPriority_Name {get; set;}
        public int Task_CreatorID {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public int? Task_IssueTypeID {get; set;}
        public string IssueType_Name {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public int? TaskStatus_InternalTaskStatusID {get; set;}
        public string Assignees {get; set;}
        public string AssigneesComma {get; set;}
        public string AssigneesId {get; set;}
        public string LoggedUserName {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TaskInfoForTimeEntry
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskInfoForTimeEntry 
    { 
        public int Task_TaskID {get; set;}
        public int Task_Progress {get; set;}
        public int? Task_ParentID {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public decimal? Task_HoursLeft {get; set;}
        public string Task_Name {get; set;}
        public int Task_TaskTypeID {get; set;}
        public int? Task_BillingType {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public string UserName {get; set;}
        public decimal? UserActualHours {get; set;}
        public bool? HasChildren {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TaskList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskList 
    { 
        public int Task_TaskID {get; set;}
        public bool? IsCriticalPath {get; set;}
        public string Task_Name {get; set;}
        public int Task_ProjectID {get; set;}
        public string Task_NameStyle {get; set;}
        public string Assignees {get; set;}
        public string AssigneesID {get; set;}
        public int? IsCurrentUserAssignee {get; set;}
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
        public int? MasterTaskCount {get; set;}
        public int? FirstMasterTaskID {get; set;}
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
        public int? Task_IssueTypeID {get; set;}
        public bool? Task_IsMilestone {get; set;}
        public string IssueType_Name {get; set;}
        public DateTime? Task_FixedDate {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public int? Task_ParentID {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? ParentTaskStartDate {get; set;}
        public int Project_ProjectStatusID {get; set;}
        public bool? CanCompleteParent {get; set;}
        public bool? IsParentCompleted {get; set;}
        public bool? Task_HasChild {get; set;}
        public int? HasMessages {get; set;}
        public int? HasAttachments {get; set;}
        public string Flags {get; set;}
        public int? CanDelete_TaskMaster {get; set;}
        public string Timeliness {get; set;}
        public bool? TaskExpand_IsExpanded {get; set;}
        public bool? Task_Approved {get; set;}
        public int? TaskEVA_Health {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TaskList_Calendar
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskList_Calendar 
    { 
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public bool Task_IsMilestone {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TaskListPlain
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskListPlain 
    { 
        public int Task_TaskID {get; set;}
        public bool? IsCriticalPath {get; set;}
        public string Task_Name {get; set;}
        public string Task_NameStyle {get; set;}
        public int Task_ProjectID {get; set;}
        public string Assignees {get; set;}
        public string AssigneesID {get; set;}
        public int? IsCurrentUserAssignee {get; set;}
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
        public int? MasterTaskCount {get; set;}
        public int? FirstMasterTaskID {get; set;}
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
        public int? Task_IssueTypeID {get; set;}
        public bool? Task_IsMilestone {get; set;}
        public string IssueType_Name {get; set;}
        public DateTime? Task_FixedDate {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public int? Task_ParentID {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? ParentTaskStartDate {get; set;}
        public int Project_ProjectStatusID {get; set;}
        public bool? CanCompleteParent {get; set;}
        public bool? IsParentCompleted {get; set;}
        public bool? Task_HasChild {get; set;}
        public int? HasMessages {get; set;}
        public int? HasAttachments {get; set;}
        public string Flags {get; set;}
        public int? CanDelete_TaskMaster {get; set;}
        public string Timeliness {get; set;}
        public bool? TaskExpand_IsExpanded {get; set;}
        public bool? Task_Approved {get; set;}
        public int? TaskEVA_Health {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TaskNamesList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskNamesList 
    { 
        public int Task_TaskID {get; set;}
        public int? Task_ParentID {get; set;}
        public string Task_Name {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public int Task_TaskTypeID {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public decimal? UserActualHours {get; set;}
        public bool? HasChildren {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TaskNamesListForTimeLogger
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskNamesListForTimeLogger 
    { 
        public int Task_TaskID {get; set;}
        public int? Task_ParentID {get; set;}
        public string Task_Name {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public int Task_TaskTypeID {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TaskNamesListForTimeLogs
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskNamesListForTimeLogs 
    { 
        public int Task_TaskID {get; set;}
        public int? Task_ParentID {get; set;}
        public string Task_Name {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? Task_HoursLeft {get; set;}
        public int? Task_CategoryID {get; set;}
        public string Category_Name {get; set;}
        public int Task_TaskTypeID {get; set;}
        public string TaskType_Name {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TaskNamesListForTimeLogsHistory
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskNamesListForTimeLogsHistory 
    { 
        public int Task_TaskID {get; set;}
        public int? Task_ParentID {get; set;}
        public string Task_Name {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? Task_HoursLeft {get; set;}
        public int? Task_CategoryID {get; set;}
        public string Category_Name {get; set;}
        public int Task_TaskTypeID {get; set;}
        public string TaskType_Name {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TasksDueList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TasksDueList 
    { 
        public int Task_TaskID {get; set;}
        public string Project_Name {get; set;}
        public int Project_ProjectID {get; set;}
        public int Customer_CustomerID {get; set;}
        public string Customer_Name {get; set;}
        public string Task_Name {get; set;}
        public string TaskType_Name {get; set;}
        public string Assignees {get; set;}
        public string TaskStatus_Name {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public decimal? TaskAggregatedValues_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public string Category_Name {get; set;}
        public int Task_Progress {get; set;}
        public string TaskPriority_Name {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public decimal? Task_Cost {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public string ProjectStatus_Name {get; set;}
        public int Project_Progress {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public decimal Project_Cost {get; set;}
        public string DueOn {get; set;}
        public string PersonLoad {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TasksDueListNL
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TasksDueListNL 
    { 
        public int Task_TaskID {get; set;}
        public string Project_Name {get; set;}
        public int Project_ProjectID {get; set;}
        public int Customer_CustomerID {get; set;}
        public string Customer_Name {get; set;}
        public string Task_Name {get; set;}
        public string TaskType_Name {get; set;}
        public string Assignees {get; set;}
        public string TaskStatus_Name {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public decimal? TaskAggregatedValues_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public string Category_Name {get; set;}
        public int Task_Progress {get; set;}
        public string TaskPriority_Name {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public decimal? Task_Cost {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public string ProjectStatus_Name {get; set;}
        public int Project_Progress {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public decimal Project_Cost {get; set;}
        public string DueOn {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TaskService_AllProjectTasks
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskService_AllProjectTasks 
    { 
        public int Task_TaskID {get; set;}
        public int Task_ProjectID {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public int? Task_Duration {get; set;}
        public int Task_Progress {get; set;}
        public decimal? TaskAggregatedValues_EstimatedHours {get; set;}
        public int? Task_ParentID {get; set;}
        public int? Task_HasChild {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public string MasterTasks {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TaskService_AllTasks
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskService_AllTasks 
    { 
        public int Task_TaskID {get; set;}
        public int Task_ProjectID {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public int? Task_Duration {get; set;}
        public int Task_Progress {get; set;}
        public decimal? TaskAggregatedValues_EstimatedHours {get; set;}
        public string MasterTasks {get; set;}
        public int? Task_ParentID {get; set;}
        public int? Task_HasChild {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TaskService_ProjectTasksLight
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskService_ProjectTasksLight 
    { 
        public int Task_TaskID {get; set;}
        public int Task_ProjectID {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TasksForExportProject
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TasksForExportProject 
    { 
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public int Task_Progress {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public int? Task_Duration {get; set;}
        public int Task_ProjectID {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public int? Task_HasChild {get; set;}
        public int? Task_ParentID {get; set;}
        public string Task_Description {get; set;}
        public bool Task_IsMilestone {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TasksHierarchicalReportSource
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TasksHierarchicalReportSource 
    { 
        public int Task_TaskID {get; set;}
        public bool? TaskCriticalPath_IsCriticalPath {get; set;}
        public int? Task_ParentID {get; set;}
        public string Task_Name {get; set;}
        public string Task_Description {get; set;}
        public string TaskStatus_Name {get; set;}
        public string Assignees {get; set;}
        public string AssigneesH {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public decimal? TaskAggregatedValues_OwnEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public decimal? Task_HoursLeft {get; set;}
        public string Category_Name {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_Cost {get; set;}
        public bool Task_IsMilestone {get; set;}
        public decimal? ProjectAggregatedValues_Budget {get; set;}
        public decimal? TaskAggregatedValues_Budget {get; set;}
        public string TaskPriority_Name {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Description {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public int Project_Progress {get; set;}
        public string Priority_Name {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public decimal Project_Cost {get; set;}
        public string Customer_Name {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TasksImport
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TasksImport 
    { 
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public string Task_Description {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public int? Task_ParentID {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_EstimatedHours {get; set;}
        public decimal? Task_HoursLeft {get; set;}
        public bool? Task_IsMilestone {get; set;}
        public string Priority_Name {get; set;}
        public string TaskStatus_Name {get; set;}
        public string Category_Name {get; set;}
        public string Assignees {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TasksReportSource
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TasksReportSource 
    { 
        public int Task_TaskID {get; set;}
        public bool? TaskCriticalPath_IsCriticalPath {get; set;}
        public string Task_Name {get; set;}
        public string Task_Description {get; set;}
        public string TaskStatus_Name {get; set;}
        public string Assignees {get; set;}
        public string AssigneesH {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public decimal? TaskAggregatedValues_OwnEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public decimal? Task_HoursLeft {get; set;}
        public string Category_Name {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_Cost {get; set;}
        public bool Task_IsMilestone {get; set;}
        public decimal? ProjectAggregatedValues_Budget {get; set;}
        public decimal? TaskAggregatedValues_Budget {get; set;}
        public string TaskPriority_Name {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public string TaskCreatorUser_Name {get; set;}
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Description {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public int Project_Progress {get; set;}
        public string Priority_Name {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public decimal Project_Cost {get; set;}
        public string Customer_Name {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TaskStatusList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskStatusList 
    { 
        public int TaskStatus_TaskStatusID {get; set;}
        public string TaskStatus_Name {get; set;}
        public int TaskStatus_TaskTypeID {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public bool TaskStatus_TreatAsHold {get; set;}
        public bool TaskStatus_RequiresApproval {get; set;}
        public int? TaskStatus_InternalTaskStatusID {get; set;}
        public string TaskType_Name {get; set;}
        public byte[] TaskStatus_Icon {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view TaskTypeAndStatus
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TaskTypeAndStatus 
    { 
        public int Task_TaskID {get; set;}
        public int Task_TaskTypeID {get; set;}
        public int Task_TaskStatusID {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TestView
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TestView 
    { 
        public int Test_TestID {get; set;}
        public string Test_Name {get; set;}
        public string TestChild_Name {get; set;}
        public DateTime TestChild_Date {get; set;}
        public decimal? TestChild_Amount {get; set;}

	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TestView2
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TestView2 
    { 
        public int TestExpr_TestID {get; set;}
        public string TestExpr_Expr1 {get; set;}
        public int? Expr2 {get; set;}

	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view ThresholdList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class ThresholdList 
    { 
        public int Threshold_ThresholdID {get; set;}
        public string Threshold_Name {get; set;}
        public decimal Threshold_Value {get; set;}
        public string Threshold_Color {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view TimeEntriesImport
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TimeEntriesImport 
    { 
        public int TimeEntry_TimeEntryID {get; set;}
        public DateTime TimeEntry_EntryDate {get; set;}
        public decimal TimeEntry_Duration {get; set;}
        public string TimeEntry_Description {get; set;}
        public bool? TimeEntry_Billable {get; set;}
        public int TimeEntry_UserID {get; set;}
        public DateTime? TimeEntry_LastModificationDate {get; set;}

	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TimeEntriesReportSource
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TimeEntriesReportSource 
    { 
        public int TimeEntry_TimeEntryID {get; set;}
        public DateTime TimeEntry_EntryDate {get; set;}
        public decimal TimeEntry_Duration {get; set;}
        public string TimeEntry_Description {get; set;}
        public bool TimeEntry_Billable {get; set;}
        public bool? TaskBillable_IsBillable {get; set;}
        public string User_Name {get; set;}
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public string Task_Description {get; set;}
        public string TaskType_Name {get; set;}
        public string TaskStatus_Name {get; set;}
        public string Assignees {get; set;}
        public string AssigneesH {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}
        public DateTime? Task_CreationDate {get; set;}
        public DateTime? Task_StartDate {get; set;}
        public int? Task_Duration {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public DateTime? Task_ActualCompletionDate {get; set;}
        public decimal? TaskAggregatedValues_OwnEstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_EstimatedHours {get; set;}
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
        public string Category_Name {get; set;}
        public int Task_Progress {get; set;}
        public decimal? Task_Cost {get; set;}
        public decimal? ProjectAggregatedValues_Budget {get; set;}
        public decimal? TaskAggregatedValues_Budget {get; set;}
        public string TaskPriority_Name {get; set;}
        public int TaskPriority_PriorityOrder {get; set;}
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public string Project_Description {get; set;}
        public DateTime? Project_StartDate {get; set;}
        public DateTime? Project_EndDate {get; set;}
        public DateTime? Project_ActCompletionDate {get; set;}
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
        public DateTime? Project_CreationDate {get; set;}
        public string ProjectStatus_Name {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public int Project_Progress {get; set;}
        public string Priority_Name {get; set;}
        public int Priority_PriorityOrder {get; set;}
        public decimal Project_Cost {get; set;}
        public string Customer_Name {get; set;}
        public int? DueIn {get; set;}
        public int? ProjectDueIn {get; set;}
        public string Highlighted {get; set;}
        public string ProjectHighlighted {get; set;}

	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TimeEntryDetail
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TimeEntryDetail 
    { 
        public int TimeEntry_TimeEntryID {get; set;}
        public DateTime TimeEntry_EntryDate {get; set;}
        public int TimeEntry_UserID {get; set;}
        public int TimeEntry_TaskID {get; set;}
        public decimal TimeEntry_Duration {get; set;}
        public string TimeEntry_Description {get; set;}
        public bool TimeEntry_Billable {get; set;}

	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TimeEntryList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TimeEntryList 
    { 
        public int TimeEntry_TimeEntryID {get; set;}
        public DateTime TimeEntry_EntryDate {get; set;}
        public int TimeEntry_UserID {get; set;}
        public string EnteredBy {get; set;}
        public string User_Name {get; set;}
        public int Task_ProjectID {get; set;}
        public int TimeEntry_TaskID {get; set;}
        public string ProjectTaskName {get; set;}
        public string Project_Name {get; set;}
        public string Task_Name {get; set;}
        public decimal TimeEntry_Duration {get; set;}
        public string TimeEntry_Description {get; set;}
        public bool TimeEntry_Billable {get; set;}

	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TimeEntryReports
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TimeEntryReports 
    { 
        public int TimeEntry_TimeEntryID {get; set;}
        public DateTime TimeEntry_EntryDate {get; set;}
        public decimal TimeEntry_Duration {get; set;}
        public string TimeEntry_Description {get; set;}
        public int Task_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public int TimeEntry_TaskID {get; set;}
        public string Task_Name {get; set;}
        public int Task_TaskTypeID {get; set;}
        public string TaskType_Name {get; set;}
        public int? Task_CategoryID {get; set;}
        public string Category_Name {get; set;}
        public int TimeEntry_UserID {get; set;}
        public int User_UserID {get; set;}
        public string User_Name {get; set;}
        public int? Project_CustomerID {get; set;}
        public int Customer_CustomerID {get; set;}
        public string Customer_Name {get; set;}
        public DateTime? Task_EndDate {get; set;}
        public int? DueIn {get; set;}
        public int? ProjectDueIn {get; set;}
        public string Highlighted {get; set;}
        public string ProjectHighlighted {get; set;}
        public bool ProjectStatus_TreatAsCompleted {get; set;}
        public bool TaskStatus_TreatAsCompleted {get; set;}

	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view TimelinessDetails
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TimelinessDetails 
    { 
        public int Timeliness_TimelinessID {get; set;}
        public string Timeliness_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view TimelinessList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TimelinessList 
    { 
        public int Timeliness_TimelinessID {get; set;}
        public string Timeliness_Name {get; set;}
        public int? Timeliness_Delay {get; set;}
        public string Timeliness_Color {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view TimeLogWeeklyViewData
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class TimeLogWeeklyViewData 
    { 
        public int TimeLogWeeklyViewEntity_TaskID {get; set;}
        public int Task_TaskID {get; set;}
        public string Task_Name {get; set;}
        public int Project_ProjectID {get; set;}
        public int Task_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public decimal? TimeLogWeeklyViewEntity_HoursOnDay0 {get; set;}
        public decimal? TimeLogWeeklyViewEntity_HoursOnDay1 {get; set;}
        public decimal? TimeLogWeeklyViewEntity_HoursOnDay2 {get; set;}
        public decimal? TimeLogWeeklyViewEntity_HoursOnDay3 {get; set;}
        public decimal? TimeLogWeeklyViewEntity_HoursOnDay4 {get; set;}
        public decimal? TimeLogWeeklyViewEntity_HoursOnDay5 {get; set;}
        public decimal? TimeLogWeeklyViewEntity_HoursOnDay6 {get; set;}
        public decimal? TimeLogWeeklyViewEntity_HoursTotal {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view UserDetail
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class UserDetail 
    { 
        public int User_UserID {get; set;}
        public string User_Login {get; set;}
        public string User_Name {get; set;}
        public string User_EMail {get; set;}
        public decimal User_HourlyRate {get; set;}
        public bool User_Enabled {get; set;}
        public bool User_CanLogin {get; set;}
        public byte[] User_Avatar {get; set;}
        public int? User_CustomerID {get; set;}
        public int User_RoleID {get; set;}
        public int? CanDelete_LastAdministrator {get; set;}
        public int? CanDelete_EventAssigner {get; set;}
        public int? CanDelete_LastProjectManager {get; set;}
        public int? CanDelete_ProjectMember {get; set;}
        public int? CanDelete_HasTimeEntries {get; set;}
        public int? CanDelete_ProjectCreator {get; set;}
        public int? CanDelete_TaskCreator {get; set;}
        public int? CanDelete_EventCreator {get; set;}
        public int? CanDelete_MessageCreator {get; set;}
        public int? CanDelete_User_DeleteHasWorkflow {get; set;}
        public int? IsTaskAssignee {get; set;}
        public DateTime? User_LastLockoutDate {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view UserFilterForTimeEntry
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class UserFilterForTimeEntry 
    { 
        public int User_UserID {get; set;}
        public string User_Name {get; set;}
        public bool User_Enabled {get; set;}
        public bool User_CanLogin {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view UserForFilters
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class UserForFilters 
    { 
        public int UserID {get; set;}
        public string Name {get; set;}
        public int RoleID {get; set;}
        public string RoleName {get; set;}
        public string EMail {get; set;}
        public bool Enabled {get; set;}
        public bool CanLogin {get; set;}
        public bool ShowCompletedTasks {get; set;}
        public bool ShowCompletedProjects {get; set;}
        public bool ShowCompletedPortfolios {get; set;}
        public bool ShowAvatars {get; set;}
        public bool? IsAvatarEmpty {get; set;}
        public string AvatarHash {get; set;}
        public bool? IsMe {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view UserForNotification
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class UserForNotification 
    { 
        public int User_UserID {get; set;}
        public string User_Name {get; set;}
        public string Vacations {get; set;}
        public string ManagersId {get; set;}
        public string LoggedUserName {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view UserGanttCharts
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class UserGanttCharts 
    { 
        public int User_UserID {get; set;}
        public string User_Name {get; set;}
        public string Chart {get; set;}
        public int? Project_ProjectID {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view UserHourlyRatesList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class UserHourlyRatesList 
    { 
        public decimal? UserHourlyRates_Date {get; set;}
        public DateTime? UserHourlyRates_HourlyRate {get; set;}
        public DateTime? DateEnd {get; set;}
        public DateTime? IsOneDate {get; set;}
        public string ActionsColumn {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view UserList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class UserList 
    { 
        public string User_Login {get; set;}
        public int User_UserID {get; set;}
        public string User_Name {get; set;}
        public int Role_RoleID {get; set;}
        public string Role_Name {get; set;}
        public string Teams {get; set;}
        public string User_EMail {get; set;}
        public string UserCustomer_Name {get; set;}
        public bool User_CanLogin {get; set;}
        public bool User_Enabled {get; set;}
        public int? CanDelete_LastAdministrator {get; set;}
        public int? CanDelete_LastProjectManager {get; set;}
        public int? CanDelete_ProjectMember {get; set;}
        public int? CanDelete_PortfolioMember {get; set;}
        public int? CanDelete_HasTimeEntries {get; set;}
        public int? CanDelete_ProjectCreator {get; set;}
        public int? CanDelete_TaskCreator {get; set;}
        public int? CanDelete_EventCreator {get; set;}
        public int? CanDelete_MessageCreator {get; set;}
        public int? CanDelete_User_DeleteHasWorkflow {get; set;}
        public int? CanDelete_EventAssigner {get; set;}
        public int? IsTaskAssignee {get; set;}
        public int? CanDelete_FormCreator {get; set;}
        public int? CanDelete_FromRecordCreator {get; set;}
        public int? CanDelete_IsFromAssignee {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view UserListForEasyStart
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class UserListForEasyStart 
    { 
        public int User_UserID {get; set;}
        public string User_Login {get; set;}
        public string User_Name {get; set;}
        public string User_EMail {get; set;}
        public int Role_RoleID {get; set;}
        public string Role_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view UserListForEventMembers
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class UserListForEventMembers 
    { 
        public int User_UserID {get; set;}
        public string User_Name {get; set;}
        public string ActionsColumn {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view UserListForPortfolioMembers
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class UserListForPortfolioMembers 
    { 
        public string AvatarImage {get; set;}
        public int User_UserID {get; set;}
        public string User_Login {get; set;}
        public string User_Name {get; set;}
        public int Role_RoleID {get; set;}
        public byte[] User_Avatar {get; set;}
        public bool PortfolioMember_IsPortfolioManager {get; set;}
        public bool PortfolioMember_CanView {get; set;}
        public bool PortfolioMember_CanEdit {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view UserListForProjectMembers
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class UserListForProjectMembers 
    { 
        public string AvatarImage {get; set;}
        public int User_UserID {get; set;}
        public string User_Login {get; set;}
        public string User_Name {get; set;}
        public int Role_RoleID {get; set;}
        public int? Role_InternalRoleID {get; set;}
        public string Role_Name {get; set;}
        public bool? User_IsAvatarEmpty {get; set;}
        public string User_AvatarHash {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view UserListForTimeEntry
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class UserListForTimeEntry 
    { 
        public int ProjectMember_ProjectMemberID {get; set;}
        public int User_UserID {get; set;}
        public string User_Name {get; set;}
        public int TaskAssignee_TaskID {get; set;}
        public bool User_Enabled {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view UserNamesList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class UserNamesList 
    { 
        public int User_UserID {get; set;}
        public string User_Name {get; set;}
        public bool User_Enabled {get; set;}
        public bool User_CanLogin {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view UserScheduleList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class UserScheduleList 
    { 
        public int UserScheduleView_UserID {get; set;}
        public int UserScheduleView_RoleID {get; set;}
        public int UserScheduleView_Day {get; set;}
        public decimal UserScheduleView_Hours {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view UsersImport
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class UsersImport 
    { 
        public int User_UserID {get; set;}
        public string User_Login {get; set;}
        public string User_Name {get; set;}
        public string User_EMail {get; set;}
        public bool? User_Enabled {get; set;}
        public bool? User_CanLogin {get; set;}
        public decimal User_HourlyRate {get; set;}
        public string Customer_Name {get; set;}
        public string Password {get; set;}
        public string Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view UsersIncluderList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class UsersIncluderList 
    { 
        public int User_UserID {get; set;}
        public string User_Name {get; set;}
        public string ActionsColumn {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view Vacations
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class Vacations 
    { 
        public int Vacation_VacationID {get; set;}
        public int Vacation_UserID {get; set;}
        public DateTime Vacation_Date {get; set;}
        public string VacationType_Name {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view VacationsReport
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class VacationsReport 
    { 
        public DateTime? VacationsReportEntity_DateEntry {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view VacationTypeList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class VacationTypeList 
    { 
        public int VacationType_VacationTypeID {get; set;}
        public string VacationType_Name {get; set;}
        public string VacationType_Color {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view VyewBookList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class VyewBookList 
    { 
        public int VyewBook_VyewBookID {get; set;}
        public int? VyewUser_UserID {get; set;}
        public string VyewBook_Name {get; set;}
        public string VyewBook_MeetingUrl {get; set;}
        public string Invites {get; set;}
        public DateTime? VyewBook_LastAccessed {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view VyewUserList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class VyewUserList 
    { 
        public int VyewUser_VyewUserID {get; set;}
        public int? VyewUser_UserID {get; set;}
        public string VyewUser_Email {get; set;}
        public string User_Name {get; set;}
        public int? VyewUser_BooksUsed {get; set;}
        public int VyewUser_MaxBooks {get; set;}
        public string VyewUser_Package {get; set;}
        public bool VyewUser_Enabled {get; set;}
        public bool VyewUser_CanUpgrade {get; set;}
        public bool VyewUser_CanDowngrade {get; set;}
        public string ActionsColumn {get; set;}

	
	
    }
    
    /// <summary>
    /// Generated class for view WhatsNewMessages
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class WhatsNewMessages 
    { 
        public int Message_MessageID {get; set;}
        public DateTime Message_PostDate {get; set;}
        public int Task_TaskID {get; set;}
        public int Task_ProjectID {get; set;}
        public string Task_Name {get; set;}
        public string TaskType_Name {get; set;}

		
        public bool CanEditEntity  {get; set;}
	
	
    }
    
    /// <summary>
    /// Generated class for view WhatsNewProjectEvents
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class WhatsNewProjectEvents 
    { 
        public int Project_ProjectID {get; set;}
        public string Project_Name {get; set;}
        public int WorkflowEvent_WorkflowEventID {get; set;}
        public DateTime WorkflowEvent_EventDate {get; set;}
        public string WorkflowEvent_WorkflowEvent {get; set;}
        public int WorkflowEvent_WorkflowEventType {get; set;}

		
        public bool CanManageProjectMembersCalculated  {get; set;}
		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanManageProjectMembers  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view WhatsNewTaskEvents
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class WhatsNewTaskEvents 
    { 
        public int Task_TaskID {get; set;}
        public int Task_ProjectID {get; set;}
        public string Task_Name {get; set;}
        public int WorkflowEvent_WorkflowEventID {get; set;}
        public DateTime WorkflowEvent_EventDate {get; set;}
        public string TaskType_Name {get; set;}
        public string WorkflowEvent_WorkflowEvent {get; set;}
        public int WorkflowEvent_WorkflowEventType {get; set;}

		
        public bool CanCreateTasks  {get; set;}
		
        public bool CanCreateIssues  {get; set;}
		
        public bool CanCreateRequests  {get; set;}
		
        public bool IsProjectMember  {get; set;}
		
        public bool CanManage  {get; set;}
		
        public bool CanCreateTimeEntries  {get; set;}
		
        public bool CanCreateTimeEntriesForOther  {get; set;}
		
        public bool CanManageAssigneesTasks  {get; set;}
		
        public bool CanManageAssigneesIssues  {get; set;}
		
        public bool CanManageAssigneesRequests  {get; set;}
		
        public bool CanViewMembersAndAssignees  {get; set;}
		
        public bool CanEditAllTasks  {get; set;}
		
        public bool CanEditAllIssues  {get; set;}
		
        public bool CanEditAllRequests  {get; set;}
		
        public bool CanEditAssignedTasks  {get; set;}
		
        public bool CanEditAssignedIssues  {get; set;}
		
        public bool CanEditAssignedRequests  {get; set;}
		
        public bool IsPortfolioManager  {get; set;}
	
	
			public bool CanEdit  {get; set;}

			public bool CanDelete  {get; set;}
    }
    
    /// <summary>
    /// Generated class for view WorkflowEventsList
    /// </summary>
	[DebuggerDisplay("View.{ViewName}")]
	public partial class WorkflowEventsList 
    { 
        public int WorkflowEvent_WorkflowEventID {get; set;}
        public DateTime WorkflowEvent_EventDate {get; set;}
        public string Task_Name {get; set;}
        public string Project_Name {get; set;}
        public string User_Name {get; set;}
        public string WorkflowEvent_WorkflowEvent {get; set;}
        public int WorkflowEvent_WorkflowEventType {get; set;}

	
	
    }
    
}


