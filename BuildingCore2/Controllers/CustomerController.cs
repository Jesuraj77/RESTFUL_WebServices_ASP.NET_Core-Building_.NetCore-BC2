using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuildingCore2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        //Create a mapping between for Customer DTO to the Customer Entity using AutoMapper.
       
        //Create a Get API method to pull all Customer details from the DB(GetCustomers Api Method)
        //Use few of the PATCH Operations on the Customer Data.

    }
}