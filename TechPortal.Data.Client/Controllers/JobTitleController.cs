using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TechPortal.Data.Domain;
using TechPortal.Data.Domain.Crud;
using TechPortal.Data.Domain.DataAccessObjects;

namespace TechPortal.Data.Client.Controllers
{
    public class JobTitleController : ApiController
    {
        private static AccessHelper helper = new AccessHelper();
        private TPDBEntities db = new TPDBEntities();

        [HttpGet]
        public HttpResponseMessage Get()
        {
            List<JobTitleDAO> t;
            try
            {
                if ((t = helper.GetJobTitles()) != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, t, "application/json");
                }

                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            catch (Exception e)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                JobTitleDAO t;
                if ((t = helper.GetJobTitles().FirstOrDefault(m => m.JobTitleName.Equals(id))) != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, t, "application/json");
                }

                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody]JobTitleDAO value)
        {
            if (value != null && ModelState.IsValid)
            {
                try
                {

                    if (helper.InsertJobTitle(value))
                    {

                        return Request.CreateResponse(HttpStatusCode.OK);
                    }

                    {
                        return Request.CreateResponse(HttpStatusCode.NotModified);
                    }
                }
                catch (Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError);
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        [HttpPut]
        public HttpResponseMessage Put(string id, [FromBody]JobTitleDAO value)
        {
            if (value != null && ModelState.IsValid)
            {
                try
                {
                    if (helper.UpdateJobTitle(id, value))
                    {
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.NotModified);
                    }
                }
                catch (Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError);
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }



        [HttpDelete]
        public HttpResponseMessage Delete(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                try
                {
                    return Request.CreateResponse(helper.DeleteJobTitle(helper.GetJobTitles().FirstOrDefault(m => m.JobTitleName.Equals(id))) ? HttpStatusCode.OK : HttpStatusCode.NotModified);
                }
                catch (Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError);
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool JobTitleExists(int id)
        {
            return db.JobTitle.Count(e => e.JobTitleID == id) > 0;
        }
    }
}