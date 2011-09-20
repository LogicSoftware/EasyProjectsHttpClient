using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;

using System.Net;
using EasyProjects.ClientModel.Entities;

namespace EasyProjects.Client
{
    /// <summary>
    /// EP HttpClient
    /// </summary>
    public class EPHttpClient : HttpEntityConventionClient 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EPHttpClient"/> class.
        /// </summary>
        /// <param name="baseAddress">The base address.</param>
        public EPHttpClient(Uri baseAddress)
            : base(baseAddress, new JsonNetEntityFormatter(), new EPResourceNameConvention())
        {
            base.Http.MaxResponseContentBufferSize = int.MaxValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EPHttpClient"/> class.
        /// </summary>
        /// <param name="baseAddress"></param>
        public EPHttpClient(string baseAddress)
            : base(new Uri(baseAddress), new JsonNetEntityFormatter(), new EPResourceNameConvention())
        {
            base.Http.MaxResponseContentBufferSize = int.MaxValue;
        }

        /// <summary>
        /// Authorizes the specified client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool Authorize(string username, string password)
        {
            var request = new AuthenticateRequest() { username = username, password = password };
            var response = this.TryPost<AuthenticateRequest>("authentication", request, out request);

            return response.IsSuccessStatusCode;
        }
    }


    public class EPResourceNameConvention: IEntityResourceNameConvention
    {
        /// <summary>
        /// Gets the name of the resource corresponding to the 
        /// given entity.
        /// </summary>
        public string GetResourceName(Type entityType)
        {
            if (entityType == typeof(Task))
                return "activities";

            if (entityType == typeof(Project))
                return "projects";

            if (entityType == typeof(ProjectAttachment))
                return "projects-attachments";

            if (entityType == typeof(ProjectStatus))
                return "projectstatuses";

            if (entityType == typeof(Category))
                return "categories";

            if (entityType == typeof(ProjectMember))
                return "projects-members";

            if (entityType == typeof(TaskAttachment))
                return "attachments";

            if (entityType == typeof(TaskStatus))
                return "taskstatuses";

            if (entityType == typeof(IssueType))
                return "issuetypes";

            if (entityType == typeof(Priority))
                return "priority";

            if (entityType == typeof(TaskAssignee))
                return "activities-assignees";

            if (entityType == typeof(Portfolio))
                return "portfolios";

            if (entityType == typeof(PortfolioStatus))
                return "portfoliostatuses";

            if (entityType == typeof(PortfolioCategory))
                return "portfoliocategory";

            if (entityType == typeof(PortfolioMember))
                return "portfolios-members";

            if (entityType == typeof(TimeEntry))
                return "timelogs";

            if (entityType == typeof(PortfolioMember))
                return "portfolios-members";
            
            if (entityType == typeof(User))
                return "users";
            
            if (entityType == typeof(Role))
                return "roles";

            if (entityType == typeof(Customer))
                return "customers";

            if (entityType == typeof(Threshold))
                return "thresholds";

            if (entityType == typeof(CalendarEvent))
                return "calendar";

            if (entityType == typeof(Timeliness))
                return "timeliness";

            if (entityType == typeof(VacationType))
                return "vacationtypes";

            if (entityType == typeof(Message))
                return "messages";

            if (entityType == typeof(PortfolioList))
                return "portfoliolist";

            if (entityType == typeof(TaskListPlain))
                return "activitylist";

            if (entityType == typeof(ProjectList))
                return "projectlist";

            return entityType.ToString().ToLower();
        }
    }

}
