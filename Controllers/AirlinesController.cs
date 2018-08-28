using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace semester.Controllers
{
    [Route("api/airports")]
    [ApiController]
    public class AirlinesController : BaseWebApiController
	{
		private readonly IAviationService _aviationService;

	    public AirlinesController(IAviationService aviationService)
	    {
		    _aviationService = aviationService;
	    }

		[Route("get")]
	    public IHttpActionResult GetAirports()
	    {
			return Ok(_aviationService.GetAirports());
	    }
    }
}