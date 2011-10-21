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
	
    #region APIPortfolioList view
    /// <summary>
    /// Generated class for view APIPortfolioList
    /// </summary>
	
	[DebuggerDisplay("View.{ViewName}")]
	[DataContract(Name = "APIPortfolioList", Namespace = "easyprojects.net/rest/v1")]
	public partial class APIPortfolioList 
    { 
	    public const string ViewNameString = "APIPortfolioList";
        public string ViewName { get { return ViewNameString; } }
	
	
		[DataMember(Name = "Portfolio_PortfolioID")]		
        public int Portfolio_PortfolioID {get; set;}
	
		[DataMember(Name = "Portfolio_Name")]		
        public string Portfolio_Name {get; set;}
	
		[DataMember(Name = "Portfolio_ManagersSeparateLines")]		
        public string Portfolio_ManagersSeparateLines {get; set;}
	
		[DataMember(Name = "Portfolio_Description")]		
        public string Portfolio_Description {get; set;}
	
		[DataMember(Name = "Portfolio_Members")]		
        public string Portfolio_Members {get; set;}
	
		[DataMember(Name = "Portfolio_HasProjects")]		
        public int? Portfolio_HasProjects {get; set;}
	
		[DataMember(Name = "HasOpenProjects")]		
        public int? HasOpenProjects {get; set;}
	
		[DataMember(Name = "PortfolioCategory_Name")]		
        public string PortfolioCategory_Name {get; set;}
	
		[DataMember(Name = "PortfolioStatus_Name")]		
        public string PortfolioStatus_Name {get; set;}
	
		[DataMember(Name = "Icon")]		
        public string Icon {get; set;}

			
	
		#region Permissions Fields		
        public bool CanEdit  {get; set;}
        public bool CanDelete  {get; set;}
		#endregion
	
    }
    #endregion
    
    #region APIProjectList view
    /// <summary>
    /// Generated class for view APIProjectList
    /// </summary>
	
	[DebuggerDisplay("View.{ViewName}")]
	[DataContract(Name = "APIProjectList", Namespace = "easyprojects.net/rest/v1")]
	public partial class APIProjectList 
    { 
	    public const string ViewNameString = "APIProjectList";
        public string ViewName { get { return ViewNameString; } }
	
	
		[DataMember(Name = "Project_ProjectID")]		
        public int Project_ProjectID {get; set;}
	
		[DataMember(Name = "Project_Name")]		
        public string Project_Name {get; set;}
	
		[DataMember(Name = "Project_Managers")]		
        public string Project_Managers {get; set;}
	
		[DataMember(Name = "Customer_Name")]		
        public string Customer_Name {get; set;}
	
		[DataMember(Name = "Priority_Name")]		
        public string Priority_Name {get; set;}
	
		[DataMember(Name = "Project_Progress")]		
        public int Project_Progress {get; set;}
	
		[DataMember(Name = "Project_StartDate")]		
        public DateTime? Project_StartDate {get; set;}
	
		[DataMember(Name = "Project_EndDate")]		
        public DateTime? Project_EndDate {get; set;}
	
		[DataMember(Name = "ProjectAggregatedValues_EstimatedHours")]		
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
	
		[DataMember(Name = "ProjectStatus_Name")]		
        public string ProjectStatus_Name {get; set;}
	
		[DataMember(Name = "ProjectStatus_IsIconEmpty")]		
        public bool? ProjectStatus_IsIconEmpty {get; set;}
	
		[DataMember(Name = "ProjectStatus_IconHash")]		
        public string ProjectStatus_IconHash {get; set;}
	
		[DataMember(Name = "Project_Members")]		
        public string Project_Members {get; set;}
	
		[DataMember(Name = "Project_ActCompletionDate")]		
        public DateTime? Project_ActCompletionDate {get; set;}
	
		[DataMember(Name = "ProjectAggregatedValues_ActualHours")]		
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
	
		[DataMember(Name = "Priority_PriorityOrder")]		
        public int Priority_PriorityOrder {get; set;}
	
		[DataMember(Name = "Project_Cost")]		
        public decimal Project_Cost {get; set;}
	
		[DataMember(Name = "CreatorUser_Name")]		
        public string CreatorUser_Name {get; set;}
	
		[DataMember(Name = "Project_CreationDate")]		
        public DateTime? Project_CreationDate {get; set;}
	
		[DataMember(Name = "HasMessages")]		
        public int? HasMessages {get; set;}
	
		[DataMember(Name = "HasAttachments")]		
        public int? HasAttachments {get; set;}
	
		[DataMember(Name = "Project_PortfolioID")]		
        public int? Project_PortfolioID {get; set;}
	
		[DataMember(Name = "Portfolio_Name")]		
        public string Portfolio_Name {get; set;}
	
		[DataMember(Name = "Flags")]		
        public string Flags {get; set;}
	
		[DataMember(Name = "Timeliness")]		
        public string Timeliness {get; set;}
	
		[DataMember(Name = "ProjectStatus_TreatAsCompleted")]		
        public bool ProjectStatus_TreatAsCompleted {get; set;}
	
		[DataMember(Name = "ProjectAggregatedValues_Budget")]		
        public decimal? ProjectAggregatedValues_Budget {get; set;}
	
		[DataMember(Name = "ProjectEVA_Health")]		
        public int? ProjectEVA_Health {get; set;}

			
	
		#region Permissions Fields		
        public bool CanEdit  {get; set;}
        public bool CanDelete  {get; set;}
		#endregion
	
    }
    #endregion
    
    #region APIProjectNamesList view
    /// <summary>
    /// Generated class for view APIProjectNamesList
    /// </summary>
	
	[DebuggerDisplay("View.{ViewName}")]
	[DataContract(Name = "APIProjectNamesList", Namespace = "easyprojects.net/rest/v1")]
	public partial class APIProjectNamesList 
    { 
	    public const string ViewNameString = "APIProjectNamesList";
        public string ViewName { get { return ViewNameString; } }
	
	
		[DataMember(Name = "Project_ProjectID")]		
        public int Project_ProjectID {get; set;}
	
		[DataMember(Name = "Project_Name")]		
        public string Project_Name {get; set;}

			
	
		#region Permissions Fields		
        public bool CanEdit  {get; set;}
        public bool CanDelete  {get; set;}
		#endregion
    }
    #endregion
    
    #region APITaskList view
    /// <summary>
    /// Generated class for view APITaskList
    /// </summary>
	
	[DebuggerDisplay("View.{ViewName}")]
	[DataContract(Name = "APITaskList", Namespace = "easyprojects.net/rest/v1")]
	public partial class APITaskList 
    { 
	    public const string ViewNameString = "APITaskList";
        public string ViewName { get { return ViewNameString; } }
	
	
		[DataMember(Name = "Task_TaskID")]		
        public int Task_TaskID {get; set;}
	
		[DataMember(Name = "IsCriticalPath")]		
        public bool? IsCriticalPath {get; set;}
	
		[DataMember(Name = "Task_Name")]		
        public string Task_Name {get; set;}
	
		[DataMember(Name = "Task_NameStyle")]		
        public string Task_NameStyle {get; set;}
	
		[DataMember(Name = "Task_ProjectID")]		
        public int? Task_ProjectID {get; set;}
	
		[DataMember(Name = "Assignees")]		
        public string Assignees {get; set;}
	
		[DataMember(Name = "AssigneesID")]		
        public string AssigneesID {get; set;}
	
		[DataMember(Name = "IsCurrentUserAssignee")]		
        public int? IsCurrentUserAssignee {get; set;}
	
		[DataMember(Name = "Task_Progress")]		
        public int Task_Progress {get; set;}
	
		[DataMember(Name = "Task_TaskTypeID")]		
        public int? Task_TaskTypeID {get; set;}
	
		[DataMember(Name = "TaskType_Name")]		
        public string TaskType_Name {get; set;}
	
		[DataMember(Name = "Task_TaskStatusID")]		
        public int? Task_TaskStatusID {get; set;}
	
		[DataMember(Name = "TaskStatus_Name")]		
        public string TaskStatus_Name {get; set;}
	
		[DataMember(Name = "TaskStatus_IsIconEmpty")]		
        public bool? TaskStatus_IsIconEmpty {get; set;}
	
		[DataMember(Name = "TaskStatus_IconHash")]		
        public string TaskStatus_IconHash {get; set;}
	
		[DataMember(Name = "Task_CategoryID")]		
        public int? Task_CategoryID {get; set;}
	
		[DataMember(Name = "Category_Name")]		
        public string Category_Name {get; set;}
	
		[DataMember(Name = "Task_StartDate")]		
        public DateTime? Task_StartDate {get; set;}
	
		[DataMember(Name = "Task_EndDate")]		
        public DateTime? Task_EndDate {get; set;}
	
		[DataMember(Name = "MasterTaskCount")]		
        public int? MasterTaskCount {get; set;}
	
		[DataMember(Name = "FirstMasterTaskID")]		
        public int? FirstMasterTaskID {get; set;}
	
		[DataMember(Name = "Task_Duration")]		
        public int? Task_Duration {get; set;}
	
		[DataMember(Name = "Task_IsEndDateSelected")]		
        public bool? Task_IsEndDateSelected {get; set;}
	
		[DataMember(Name = "Task_EstimatedHours")]		
        public decimal? Task_EstimatedHours {get; set;}
	
		[DataMember(Name = "TaskAggregatedValues_EstimatedHours")]		
        public decimal? TaskAggregatedValues_EstimatedHours {get; set;}
	
		[DataMember(Name = "TaskAggregatedValues_ChildsEstimatedHours")]		
        public decimal? TaskAggregatedValues_ChildsEstimatedHours {get; set;}
	
		[DataMember(Name = "TaskAggregatedValues_ActualHours")]		
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
	
		[DataMember(Name = "Task_HoursLeft")]		
        public decimal? Task_HoursLeft {get; set;}
	
		[DataMember(Name = "Task_ActualCompletionDate")]		
        public DateTime? Task_ActualCompletionDate {get; set;}
	
		[DataMember(Name = "TaskPriority_PriorityOrder")]		
        public int TaskPriority_PriorityOrder {get; set;}
	
		[DataMember(Name = "TaskPriority_PriorityID")]		
        public int TaskPriority_PriorityID {get; set;}
	
		[DataMember(Name = "TaskPriority_Name")]		
        public string TaskPriority_Name {get; set;}
	
		[DataMember(Name = "Task_PriorityID")]		
        public int? Task_PriorityID {get; set;}
	
		[DataMember(Name = "Task_Cost")]		
        public decimal? Task_Cost {get; set;}
	
		[DataMember(Name = "TaskAggregatedValues_Budget")]		
        public decimal? TaskAggregatedValues_Budget {get; set;}
	
		[DataMember(Name = "TaskCreatorUser_UserID")]		
        public int TaskCreatorUser_UserID {get; set;}
	
		[DataMember(Name = "TaskCreatorUser_Name")]		
        public string TaskCreatorUser_Name {get; set;}
	
		[DataMember(Name = "Task_CreationDate")]		
        public DateTime? Task_CreationDate {get; set;}
	
		[DataMember(Name = "Task_IssueTypeID")]		
        public int? Task_IssueTypeID {get; set;}
	
		[DataMember(Name = "Task_IsMilestone")]		
        public bool? Task_IsMilestone {get; set;}
	
		[DataMember(Name = "IssueType_Name")]		
        public string IssueType_Name {get; set;}
	
		[DataMember(Name = "Task_FixedDate")]		
        public DateTime? Task_FixedDate {get; set;}
	
		[DataMember(Name = "TaskStatus_TreatAsCompleted")]		
        public bool TaskStatus_TreatAsCompleted {get; set;}
	
		[DataMember(Name = "Task_ParentID")]		
        public int? Task_ParentID {get; set;}
	
		[DataMember(Name = "Project_StartDate")]		
        public DateTime? Project_StartDate {get; set;}
	
		[DataMember(Name = "ParentTaskStartDate")]		
        public DateTime? ParentTaskStartDate {get; set;}
	
		[DataMember(Name = "Project_ProjectStatusID")]		
        public int? Project_ProjectStatusID {get; set;}
	
		[DataMember(Name = "CanCompleteParent")]		
        public bool? CanCompleteParent {get; set;}
	
		[DataMember(Name = "IsParentCompleted")]		
        public bool? IsParentCompleted {get; set;}
	
		[DataMember(Name = "Task_HasChild")]		
        public bool? Task_HasChild {get; set;}
	
		[DataMember(Name = "HasMessages")]		
        public int? HasMessages {get; set;}
	
		[DataMember(Name = "HasAttachments")]		
        public int? HasAttachments {get; set;}
	
		[DataMember(Name = "Flags")]		
        public string Flags {get; set;}
	
		[DataMember(Name = "CanDelete_TaskMaster")]		
        public int? CanDelete_TaskMaster {get; set;}
	
		[DataMember(Name = "Timeliness")]		
        public string Timeliness {get; set;}
	
		[DataMember(Name = "TaskExpand_IsExpanded")]		
        public bool? TaskExpand_IsExpanded {get; set;}
	
		[DataMember(Name = "Task_Approved")]		
        public bool? Task_Approved {get; set;}
	
		[DataMember(Name = "TaskEVA_Health")]		
        public int? TaskEVA_Health {get; set;}

			
	
		#region Permissions Fields		
        public bool CanEdit  {get; set;}
        public bool CanDelete  {get; set;}
		#endregion
	
    }
    #endregion
    
    #region APITaskNamesList view
    /// <summary>
    /// Generated class for view APITaskNamesList
    /// </summary>
	
	[DebuggerDisplay("View.{ViewName}")]
	[DataContract(Name = "APITaskNamesList", Namespace = "easyprojects.net/rest/v1")]
	public partial class APITaskNamesList 
    { 
	    public const string ViewNameString = "APITaskNamesList";
        public string ViewName { get { return ViewNameString; } }
	
	
		[DataMember(Name = "Task_TaskID")]		
        public int Task_TaskID {get; set;}
	
		[DataMember(Name = "Task_ParentID")]		
        public int? Task_ParentID {get; set;}
	
		[DataMember(Name = "Task_Name")]		
        public string Task_Name {get; set;}
	
		[DataMember(Name = "Task_Progress")]		
        public int Task_Progress {get; set;}
	
		[DataMember(Name = "Task_EstimatedHours")]		
        public decimal? Task_EstimatedHours {get; set;}
	
		[DataMember(Name = "TaskAggregatedValues_ActualHours")]		
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
	
		[DataMember(Name = "Task_TaskTypeID")]		
        public int? Task_TaskTypeID {get; set;}
	
		[DataMember(Name = "TaskStatus_TreatAsCompleted")]		
        public bool TaskStatus_TreatAsCompleted {get; set;}
	
		[DataMember(Name = "UserActualHours")]		
        public decimal? UserActualHours {get; set;}
	
		[DataMember(Name = "HasChildren")]		
        public bool? HasChildren {get; set;}

			
	
		#region Permissions Fields		
        public bool CanEdit  {get; set;}
        public bool CanDelete  {get; set;}
		#endregion
    }
    #endregion
    
}


