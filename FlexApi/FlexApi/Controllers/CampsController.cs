using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlexApi.Controllers
{
	[Produces("application/json")]
	[Route("api/Camps")]
	public class CampsController : Controller
	{
		[HttpGet("")]
		public IActionResult Get()
		{
			return Ok(new { Name = "Yuvi", Color = "Orange" });
		}
	}
}