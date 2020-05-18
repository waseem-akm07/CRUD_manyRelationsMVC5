using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataTransferObject.ViewModel;
using BusinessAccessLayer;
using System.Web.Http.ModelBinding;

namespace CRUD_manyRelationsMVC.Controllers
{
    public class authorController : ApiController
    {
         IBusinessLayer _businessLayer = new BusinessLayer();

        // GET: api/author
        [HttpGet]
        [Route("api/author/get")]
        public IQueryable<AuthorModel> Get()
        {
            return _businessLayer.GetEmployees();
        }

        // GET: api/author/5
        [HttpGet]
        [Route("api/author/get/id/{id}")]
        public IQueryable<AuthorModel> Get(int id)
        {
            return _businessLayer.GetEmployee(id);
        }

        // POST: api/author
        [HttpPost]
        [Route("api/author/post")]
        public void Post(List<AuthorModel> model)
        {
            _businessLayer.Create(model);
        }

        // PUT: api/author/5
        [HttpPut]
        [Route("api/author/put")]
        public void Put( List<AuthorModel> model)
        {
            _businessLayer.Update( model);
        }

        // DELETE: api/author/5
        [HttpDelete]
        [Route("api/author/delete")]
        public void Delete(List<IdModel> id)
        {
            _businessLayer.Delete(id);
        }
    }
}
