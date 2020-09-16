﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public IEnumerable<string> Values()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        public string Value(int id)
        {
            return "value";
        }

        [HttpPost]
        public void SaveNewValue([FromBody] string value)
        {
        }

        [HttpPut]
        public void UpdateValue(int id, [FromBody] string value)
        {
        }

        [HttpDelete]
        public void RemoveValue(int id)
        {
        }
    }
}