using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;

using System.Net;
using EasyProjects.ClientModel.Entities;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace EasyProjects.Client
{
    /// <summary>
    /// EP HttpClient
    /// </summary>
    public class HttpClient : HttpEntityConventionClient 
    {
        #region .ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClient"/> class.
        /// </summary>
        /// <param name="baseAddress">The base address.</param>
        public HttpClient(Uri baseAddress)
            : base(baseAddress, new JsonNetEntityFormatter(), new EPResourceNameConvention())
        {
            base.Http.MaxResponseContentBufferSize = int.MaxValue;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClient"/> class.
        /// </summary>
        /// <param name="baseAddress">The base address.</param>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        public HttpClient(Uri baseAddress, string userName, string password)
            : this(baseAddress)
        {
            AddBaseAuthenticationHeaders(userName, password);
        }

        #endregion

        /// <summary>
        /// Adds the base authentication headers.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        public void AddBaseAuthenticationHeaders(string username, string password)
        {
            byte[] authbytes = Encoding.ASCII.GetBytes(string.Concat(username, ":", password));
            string base64 = Convert.ToBase64String(authbytes);
            Http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", base64);
        }

        /// <summary>
        /// Queries as resource.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="resourcePath">The resource path.</param>
        /// <param name="args">The args.</param>
        /// <returns></returns>
        public IHttpEntityQuery<T> QueryAsResource<T>(string resourcePath, params object[] args)
        {
            return ((HttpEntityClient)this).Query<T>(String.Format(resourcePath, args));
        }

        /// <summary>
        /// Queries as resource.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="resourcePath">The resource path.</param>
        /// <returns></returns>
        public IHttpEntityQuery<T> QueryAsResource<T>(string resourcePath)
        {
            return ((HttpEntityClient)this).Query<T>(resourcePath);
        }

        #region Extra
        /// <summary>
        /// Posts as stream.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="stream">The stream.</param>
        public void PostAsStream(string path, Stream stream)
        {
            var content = new StreamContent(stream);
            base.Http.Post(path, content);
        }

        /// <summary>
        /// Gets as stream.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public Stream GetAsStream(string path)
        {
            var response = base.Http.Get(path);

            return response.Content.ContentReadStream;
        }

        #endregion
    }


    /// <summary>
    /// EP ResourceNameConvention
    /// </summary>
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

            if (entityType == typeof(Event))
                return "inner/events";

            if (entityType == typeof(Timeliness))
                return "timeliness";

            if (entityType == typeof(VacationType))
                return "vacationtypes";

            if (entityType == typeof(Message))
                return "messages";

            if (entityType == typeof(Payment))
                return "inner/payments";

            if (entityType == typeof(APIPortfolioList))
                return "views/portfoliolist";

            if (entityType == typeof(APITaskList))
                return "views/activitylist";

            if (entityType == typeof(APIProjectList))
                return "views/projectlist";

            if (entityType == typeof(APIProjectNamesList))
                return "views/projectnameslist";

            if (entityType == typeof(APITaskNamesList))
                return "views/activitynameslist";

            if (entityType == typeof (CustomField))
                return "inner/customfields";

            if (entityType == typeof(CustomFieldRestriction))
                return "inner/customfieldrestrictions";

            return entityType.ToString().ToLower();
        }
    }

}
