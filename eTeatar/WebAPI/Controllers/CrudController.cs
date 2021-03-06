﻿using Microsoft.AspNetCore.Mvc;
using System;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{

    public class CrudController<TTransferObject, TSearch, TInsert, TUpdate> : BaseController<TTransferObject, TSearch> where TTransferObject : class
    {
        private readonly ICrudService<TTransferObject, TSearch, TInsert, TUpdate> _service;
        public CrudController(ICrudService<TTransferObject, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public virtual ActionResult<TTransferObject> Insert([FromBody]TInsert request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public ActionResult<TTransferObject> Update(string id, [FromBody]TUpdate request)
        {
            return _service.Update(id, request);
        }
        
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                _service.Delete(id);
            }
            catch (ArgumentNullException)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}