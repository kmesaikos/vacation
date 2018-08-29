using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace semester.Controllers
{
    [Route("api/airports")]
    [ApiController]
    public class AirlinesController
	{
		//private readonly IAviationService _aviationService;

	 //   public AirlinesController(IAviationService aviationService)
	 //   {
		//    _aviationService = aviationService;
	 //   }

		[Route("get")]
		public List<Airports> GetAirports()
	    {
		    using (var httpClient = new HttpClient())
		    {
			    httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");

			    var response = httpClient.GetStringAsync(new Uri(" ;;;;")).Result;

			    var airports = JsonConvert.DeserializeObject<List<Airports>>(response);

				return airports;
		    }
		}
    }
}