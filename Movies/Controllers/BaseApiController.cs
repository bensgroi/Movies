using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Movies.Models;

namespace Movies.Controllers
{
    public class BaseApiController : ApiController
    {
        #region Properties

        protected MoviesEntities DbContext { get; set; }

        #endregion

        #region Constructors

        public BaseApiController()
        {
            DbContext = new MoviesEntities();


        }

        #endregion

        #region Response Helpers

        protected HttpResponseMessage OK()
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        protected HttpResponseMessage OK<T>(T value)
        {
            return Request.CreateResponse(HttpStatusCode.OK, value);
        }

        #endregion
    }
}