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
	
    #region PortfolioList view
    /// <summary>
    /// Generated class for view PortfolioList
    /// </summary>
	
	[DebuggerDisplay("View.{ViewName}")]
	[DataContract(Name = "PortfolioList", Namespace = "easyprojects.net/rest/v1")]
	public partial class PortfolioList 
    { 
	    public const string ViewNameString = "PortfolioList";
        public string ViewName { get { return ViewNameString; } }
	
	
		[DataMember(Name = "PortfolioID", IsRequired = false, EmitDefaultValue = true)]	
        public int Portfolio_PortfolioID {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string Portfolio_Name {get; set;}
	
		[DataMember(Name = "ManagersSeparateLines", IsRequired = false, EmitDefaultValue = true)]	
        public string Portfolio_ManagersSeparateLines {get; set;}
	
		[DataMember(Name = "Description", IsRequired = false, EmitDefaultValue = true)]	
        public string Portfolio_Description {get; set;}
	
		[DataMember(Name = "Members", IsRequired = false, EmitDefaultValue = true)]	
        public string Portfolio_Members {get; set;}
	
		[DataMember(Name = "HasProjects", IsRequired = false, EmitDefaultValue = true)]	
        public int? Portfolio_HasProjects {get; set;}
	
		[DataMember(Name = "HasOpenProjects", IsRequired = false, EmitDefaultValue = true)]	
        public int? HasOpenProjects {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string PortfolioCategory_Name {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string PortfolioStatus_Name {get; set;}
	
		[DataMember(Name = "Icon", IsRequired = false, EmitDefaultValue = true)]	
        public string Icon {get; set;}

			
	
		#region Permissions Fields		
        public bool CanEdit  {get; set;}
        public bool CanDelete  {get; set;}
		#endregion
	
    }
    #endregion
    
    #region ProjectList view
    /// <summary>
    /// Generated class for view ProjectList
    /// </summary>
	
	[DebuggerDisplay("View.{ViewName}")]
	[DataContract(Name = "ProjectList", Namespace = "easyprojects.net/rest/v1")]
	public partial class ProjectList 
    { 
	    public const string ViewNameString = "ProjectList";
        public string ViewName { get { return ViewNameString; } }
	
	
		[DataMember(Name = "ProjectID", IsRequired = false, EmitDefaultValue = true)]	
        public int Project_ProjectID {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string Project_Name {get; set;}
	
		[DataMember(Name = "Managers", IsRequired = false, EmitDefaultValue = true)]	
        public string Project_Managers {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string Customer_Name {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string Priority_Name {get; set;}
	
		[DataMember(Name = "Progress", IsRequired = false, EmitDefaultValue = true)]	
        public int Project_Progress {get; set;}
	
		[DataMember(Name = "StartDate", IsRequired = false, EmitDefaultValue = true)]	
        public DateTime? Project_StartDate {get; set;}
	
		[DataMember(Name = "EndDate", IsRequired = false, EmitDefaultValue = true)]	
        public DateTime? Project_EndDate {get; set;}
	
		[DataMember(Name = "EstimatedHours", IsRequired = false, EmitDefaultValue = true)]	
        public decimal? ProjectAggregatedValues_EstimatedHours {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string ProjectStatus_Name {get; set;}
	
		[DataMember(Name = "IsIconEmpty", IsRequired = false, EmitDefaultValue = true)]	
        public bool? ProjectStatus_IsIconEmpty {get; set;}
	
		[DataMember(Name = "IconHash", IsRequired = false, EmitDefaultValue = true)]	
        public string ProjectStatus_IconHash {get; set;}
	
		[DataMember(Name = "Members", IsRequired = false, EmitDefaultValue = true)]	
        public string Project_Members {get; set;}
	
		[DataMember(Name = "ActCompletionDate", IsRequired = false, EmitDefaultValue = true)]	
        public DateTime? Project_ActCompletionDate {get; set;}
	
		[DataMember(Name = "ActualHours", IsRequired = false, EmitDefaultValue = true)]	
        public decimal? ProjectAggregatedValues_ActualHours {get; set;}
	
		[DataMember(Name = "PriorityOrder", IsRequired = false, EmitDefaultValue = true)]	
        public int Priority_PriorityOrder {get; set;}
	
		[DataMember(Name = "Cost", IsRequired = false, EmitDefaultValue = true)]	
        public decimal Project_Cost {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string CreatorUser_Name {get; set;}
	
		[DataMember(Name = "CreationDate", IsRequired = false, EmitDefaultValue = true)]	
        public DateTime? Project_CreationDate {get; set;}
	
		[DataMember(Name = "HasMessages", IsRequired = false, EmitDefaultValue = true)]	
        public int? HasMessages {get; set;}
	
		[DataMember(Name = "HasAttachments", IsRequired = false, EmitDefaultValue = true)]	
        public int? HasAttachments {get; set;}
	
		[DataMember(Name = "PortfolioID", IsRequired = false, EmitDefaultValue = true)]	
        public int? Project_PortfolioID {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string Portfolio_Name {get; set;}
	
		[DataMember(Name = "Flags", IsRequired = false, EmitDefaultValue = true)]	
        public string Flags {get; set;}
	
		[DataMember(Name = "Timeliness", IsRequired = false, EmitDefaultValue = true)]	
        public string Timeliness {get; set;}
	
		[DataMember(Name = "TreatAsCompleted", IsRequired = false, EmitDefaultValue = true)]	
        public bool ProjectStatus_TreatAsCompleted {get; set;}
	
		[DataMember(Name = "Budget", IsRequired = false, EmitDefaultValue = true)]	
        public decimal? ProjectAggregatedValues_Budget {get; set;}
	
		[DataMember(Name = "Health", IsRequired = false, EmitDefaultValue = true)]	
        public int? ProjectEVA_Health {get; set;}

			
	
		#region Permissions Fields		
        public bool CanEdit  {get; set;}
        public bool CanDelete  {get; set;}
		#endregion
	
    }
    #endregion
    
    #region ProjectNamesList view
    /// <summary>
    /// Generated class for view ProjectNamesList
    /// </summary>
	
	[DebuggerDisplay("View.{ViewName}")]
	[DataContract(Name = "ProjectNamesList", Namespace = "easyprojects.net/rest/v1")]
	public partial class ProjectNamesList 
    { 
	    public const string ViewNameString = "ProjectNamesList";
        public string ViewName { get { return ViewNameString; } }
	
	
		[DataMember(Name = "ProjectID", IsRequired = false, EmitDefaultValue = true)]	
        public int Project_ProjectID {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string Project_Name {get; set;}

			
	
		#region Permissions Fields		
        public bool CanEdit  {get; set;}
        public bool CanDelete  {get; set;}
		#endregion
    }
    #endregion
    
    #region TaskListPlain view
    /// <summary>
    /// Generated class for view TaskListPlain
    /// </summary>
	
	[DebuggerDisplay("View.{ViewName}")]
	[DataContract(Name = "TaskListPlain", Namespace = "easyprojects.net/rest/v1")]
	public partial class TaskListPlain 
    { 
	    public const string ViewNameString = "TaskListPlain";
        public string ViewName { get { return ViewNameString; } }
	
	
		[DataMember(Name = "TaskID", IsRequired = false, EmitDefaultValue = true)]	
        public int Task_TaskID {get; set;}
	
		[DataMember(Name = "IsCriticalPath", IsRequired = false, EmitDefaultValue = true)]	
        public bool? IsCriticalPath {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string Task_Name {get; set;}
	
		[DataMember(Name = "NameStyle", IsRequired = false, EmitDefaultValue = true)]	
        public string Task_NameStyle {get; set;}
	
		[DataMember(Name = "ProjectID", IsRequired = false, EmitDefaultValue = true)]	
        public int? Task_ProjectID {get; set;}
	
		[DataMember(Name = "Assignees", IsRequired = false, EmitDefaultValue = true)]	
        public string Assignees {get; set;}
	
		[DataMember(Name = "AssigneesID", IsRequired = false, EmitDefaultValue = true)]	
        public string AssigneesID {get; set;}
	
		[DataMember(Name = "IsCurrentUserAssignee", IsRequired = false, EmitDefaultValue = true)]	
        public int? IsCurrentUserAssignee {get; set;}
	
		[DataMember(Name = "Progress", IsRequired = false, EmitDefaultValue = true)]	
        public int Task_Progress {get; set;}
	
		[DataMember(Name = "TaskTypeID", IsRequired = false, EmitDefaultValue = true)]	
        public int? Task_TaskTypeID {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string TaskType_Name {get; set;}
	
		[DataMember(Name = "TaskStatusID", IsRequired = false, EmitDefaultValue = true)]	
        public int? Task_TaskStatusID {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string TaskStatus_Name {get; set;}
	
		[DataMember(Name = "IsIconEmpty", IsRequired = false, EmitDefaultValue = true)]	
        public bool? TaskStatus_IsIconEmpty {get; set;}
	
		[DataMember(Name = "IconHash", IsRequired = false, EmitDefaultValue = true)]	
        public string TaskStatus_IconHash {get; set;}
	
		[DataMember(Name = "CategoryID", IsRequired = false, EmitDefaultValue = true)]	
        public int? Task_CategoryID {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string Category_Name {get; set;}
	
		[DataMember(Name = "StartDate", IsRequired = false, EmitDefaultValue = true)]	
        public DateTime? Task_StartDate {get; set;}
	
		[DataMember(Name = "EndDate", IsRequired = false, EmitDefaultValue = true)]	
        public DateTime? Task_EndDate {get; set;}
	
		[DataMember(Name = "MasterTaskCount", IsRequired = false, EmitDefaultValue = true)]	
        public int? MasterTaskCount {get; set;}
	
		[DataMember(Name = "FirstMasterTaskID", IsRequired = false, EmitDefaultValue = true)]	
        public int? FirstMasterTaskID {get; set;}
	
		[DataMember(Name = "Duration", IsRequired = false, EmitDefaultValue = true)]	
        public int? Task_Duration {get; set;}
	
		[DataMember(Name = "IsEndDateSelected", IsRequired = false, EmitDefaultValue = true)]	
        public bool? Task_IsEndDateSelected {get; set;}
	
		[DataMember(Name = "EstimatedHours", IsRequired = false, EmitDefaultValue = true)]	
        public decimal? Task_EstimatedHours {get; set;}
	
		[DataMember(Name = "EstimatedHours", IsRequired = false, EmitDefaultValue = true)]	
        public decimal? TaskAggregatedValues_EstimatedHours {get; set;}
	
		[DataMember(Name = "ChildsEstimatedHours", IsRequired = false, EmitDefaultValue = true)]	
        public decimal? TaskAggregatedValues_ChildsEstimatedHours {get; set;}
	
		[DataMember(Name = "ActualHours", IsRequired = false, EmitDefaultValue = true)]	
        public decimal? TaskAggregatedValues_ActualHours {get; set;}
	
		[DataMember(Name = "HoursLeft", IsRequired = false, EmitDefaultValue = true)]	
        public decimal? Task_HoursLeft {get; set;}
	
		[DataMember(Name = "ActualCompletionDate", IsRequired = false, EmitDefaultValue = true)]	
        public DateTime? Task_ActualCompletionDate {get; set;}
	
		[DataMember(Name = "PriorityOrder", IsRequired = false, EmitDefaultValue = true)]	
        public int TaskPriority_PriorityOrder {get; set;}
	
		[DataMember(Name = "PriorityID", IsRequired = false, EmitDefaultValue = true)]	
        public int TaskPriority_PriorityID {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string TaskPriority_Name {get; set;}
	
		[DataMember(Name = "PriorityID", IsRequired = false, EmitDefaultValue = true)]	
        public int? Task_PriorityID {get; set;}
	
		[DataMember(Name = "Cost", IsRequired = false, EmitDefaultValue = true)]	
        public decimal? Task_Cost {get; set;}
	
		[DataMember(Name = "Budget", IsRequired = false, EmitDefaultValue = true)]	
        public decimal? TaskAggregatedValues_Budget {get; set;}
	
		[DataMember(Name = "UserID", IsRequired = false, EmitDefaultValue = true)]	
        public int TaskCreatorUser_UserID {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string TaskCreatorUser_Name {get; set;}
	
		[DataMember(Name = "CreationDate", IsRequired = false, EmitDefaultValue = true)]	
        public DateTime? Task_CreationDate {get; set;}
	
		[DataMember(Name = "IssueTypeID", IsRequired = false, EmitDefaultValue = true)]	
        public int? Task_IssueTypeID {get; set;}
	
		[DataMember(Name = "IsMilestone", IsRequired = false, EmitDefaultValue = true)]	
        public bool? Task_IsMilestone {get; set;}
	
		[DataMember(Name = "Name", IsRequired = false, EmitDefaultValue = true)]	
        public string IssueType_Name {get; set;}
	
		[DataMember(Name = "FixedDate", IsRequired = false, EmitDefaultValue = true)]	
        public DateTime? Task_FixedDate {get; set;}
	
		[DataMember(Name = "TreatAsCompleted", IsRequired = false, EmitDefaultValue = true)]	
        public bool TaskStatus_TreatAsCompleted {get; set;}
	
		[DataMember(Name = "ParentID", IsRequired = false, EmitDefaultValue = true)]	
        public int? Task_ParentID {get; set;}
	
		[DataMember(Name = "StartDate", IsRequired = false, EmitDefaultValue = true)]	
        public DateTime? Project_StartDate {get; set;}
	
		[DataMember(Name = "ParentTaskStartDate", IsRequired = false, EmitDefaultValue = true)]	
        public DateTime? ParentTaskStartDate {get; set;}
	
		[DataMember(Name = "ProjectStatusID", IsRequired = false, EmitDefaultValue = true)]	
        public int? Project_ProjectStatusID {get; set;}
	
		[DataMember(Name = "CanCompleteParent", IsRequired = false, EmitDefaultValue = true)]	
        public bool? CanCompleteParent {get; set;}
	
		[DataMember(Name = "IsParentCompleted", IsRequired = false, EmitDefaultValue = true)]	
        public bool? IsParentCompleted {get; set;}
	
		[DataMember(Name = "Task_HasChild", IsRequired = false, EmitDefaultValue = true)]	
        public bool? Task_HasChild {get; set;}
	
		[DataMember(Name = "HasMessages", IsRequired = false, EmitDefaultValue = true)]	
        public int? HasMessages {get; set;}
	
		[DataMember(Name = "HasAttachments", IsRequired = false, EmitDefaultValue = true)]	
        public int? HasAttachments {get; set;}
	
		[DataMember(Name = "Flags", IsRequired = false, EmitDefaultValue = true)]	
        public string Flags {get; set;}
	
		[DataMember(Name = "CanDelete_TaskMaster", IsRequired = false, EmitDefaultValue = true)]	
        public int? CanDelete_TaskMaster {get; set;}
	
		[DataMember(Name = "Timeliness", IsRequired = false, EmitDefaultValue = true)]	
        public string Timeliness {get; set;}
	
		[DataMember(Name = "IsExpanded", IsRequired = false, EmitDefaultValue = true)]	
        public bool? TaskExpand_IsExpanded {get; set;}
	
		[DataMember(Name = "Approved", IsRequired = false, EmitDefaultValue = true)]	
        public bool? Task_Approved {get; set;}
	
		[DataMember(Name = "Health", IsRequired = false, EmitDefaultValue = true)]	
        public int? TaskEVA_Health {get; set;}

			
	
		#region Permissions Fields		
        public bool CanEdit  {get; set;}
        public bool CanDelete  {get; set;}
		#endregion
	
    }
    #endregion
    
}


