using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Git.GitHub.Controller
{
	[ApiController]
	[Route("api/[controller]")]
	public class UsersController : ControllerBase
	{
		private readonly IConfiguration _config;
		public UsersController(IConfiguration config)
		{
			_config = config;
		}

		public ActionResult GetTotalCount()
		{
			return Ok(10);
		}
	}
}