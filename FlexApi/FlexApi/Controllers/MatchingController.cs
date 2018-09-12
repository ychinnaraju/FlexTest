using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlexApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlexApi.Controllers
{
	[Produces("application/json")]
	[Route("api/Matching")]
	public class MatchingController : Controller
	{
		[HttpPost]
		[ActionName("AddFileEvidence")]
		public IActionResult AddFileEvidence(FileEvidenceItem item )
		{
			return Ok(item.Id);

		}
	}
}