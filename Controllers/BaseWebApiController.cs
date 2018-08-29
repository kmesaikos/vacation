//using System.Web.Http;
//using System.Web.Http.Results;
//using Api.Common.RequestContext;
//using Newtonsoft.Json;

//namespace Api.Common
//{

//	public class BaseWebApiController : ApiController
//	{
//		public BaseWebApiController(IRequestContext apiRequestContext)
//		{
//			ApiRequestContext = apiRequestContext;
//		}

//		public IRequestContext ApiRequestContext { get; }

//		/// <summary>
//		///     The JSON serializer settings to use for formatting during JSON serialization and deserialization.
//		/// </summary>
//		protected JsonSerializerSettings JsonSerializerSettings => GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings;


//		/// <summary>
//		///     Creates a <see cref="T:System.Web.Http.Results.JsonResult`1" /> (200 OK) with the specified value.
//		/// </summary>
//		/// <typeparam name="T">The type of content in the entity body.</typeparam>
//		/// <param name="content">The content value to serialize in the entity body.</param>
//		/// <returns>
//		///     A <see cref="T:System.Web.Http.Results.JsonResult`1" /> with the specified value.
//		/// </returns>
//		protected new JsonResult<T> Json<T>(T content)
//		{
//			// This defaults serializationSettings to the GlobalConfiguration SerializationSettings instead of creating a new instance.
//			return Json(content, JsonSerializerSettings);
//		}
//	}
//}