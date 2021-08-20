using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegracaoGithub.Model;
using IntegracaoGithub.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IntegracaoGithub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RepositoriesController : ControllerBase
    {
        public RepositoriesController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var repos = await new GithubService().GetReposByLanguageAsync("C#", 5, "takenet");

            return Ok(repos);
        }
    }
}
