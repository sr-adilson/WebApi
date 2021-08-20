﻿using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<M, R> : ControllerBase where M : Base where R : BaseRepo<M>
    {
        R repo = Activator.CreateInstance<R>();
        // GET: api/<BAseController>
        [HttpGet]
        public List<M> Get()
        {
            return repo.Read();
        }

        // GET api/<BAseController>/5
        [HttpGet("{id}")]
        public M Get(int id)
        {
            return repo.Read(id);
        }

        // POST api/<BAseController>
        [HttpPost]
        public void Post([FromBody] M value)
        {
            repo.Create(value);
        }

        // PUT api/<BAseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] M value)
        {
            repo.Update(value);
        }

        // DELETE api/<BAseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.Delete(repo.Read(id));
        }
    }
}
