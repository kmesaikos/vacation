using semester.Integration;

namespace semester.Controllers
{
	public class AviationService : IAviationService
	{
		private readonly IRestService _restService;

		public AviationService(IRestService restService)
		{
			_restService = restService;
		}
		public Airports GetAirports()
		{
			var url =  "https://aviation-edge.com/api/public/airportDatabase?key=4f1bae-93d306-7add12-f4c427-d04a49&codeIso2Country=GR";

			return _restService.Get<Airports>(url);
		}
	}
}